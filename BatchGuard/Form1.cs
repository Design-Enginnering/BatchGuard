using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BatchGuard
{
    public partial class Form1 : Form
    {
        private string letchars = "abcdefghijklmnopqrstuvwxyz";
        private string letupchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string numchars = "0123456789";

        public Form1()
        {
            InitializeComponent();
            listBox1.BackColor = Color.FromArgb(38, 38, 66);
            listBox1.ForeColor = Color.WhiteSmoke;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string content;
            try
            {
                content = File.ReadAllText(textBox1.Text);
            }
            catch
            {
                content = "Invalid file.";
            }

            textBox2.Text = content;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            byte[] finaloutput;
            Random rng = new Random();
            StringBuilder gencode = new StringBuilder();
            // Boilerplate
            gencode.AppendLine("@echo off");
            gencode.AppendLine("cls");
            gencode.AppendLine("setlocal enabledelayedexpansion");

            if (listBox1.Items.Count > 0)
            {
                // Add code for extracting "embedded" files
                foreach (string item in listBox1.Items)
                {
                    string encoded = Convert.ToBase64String(File.ReadAllBytes(item));
                    gencode.AppendLine($"powershell -Command \"[System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String('{encoded}'))\" > \"%~dp0\\{Path.GetFileName(item)}\"");
                }
            }

            string batchcode = textBox2.Text;
            List<string[]> linevars = new List<string[]>();
            if (checkBox2.Checked) // Splitting strings
            {
                string[] lines = batchcode.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                batchcode = string.Empty;

                List<string> setlines = new List<string>();
                foreach (string line in lines)
                {
                    // Split each line every 8 characters
                    List<string> splitted = new List<string>();
                    string sc = string.Empty;
                    bool invar = false;
                    foreach (char c in line)
                    {
                        if (c == '%')
                        {
                            invar = !invar;
                            sc += c;
                            continue;
                        }
                        if (!invar)
                        {
                            if (sc.Length >= 8)
                            {
                                splitted.Add(sc);
                                sc = string.Empty;
                            }
                        }
                        sc += c;
                    }
                    splitted.Add(sc);

                    List<string> vars = new List<string>();
                    foreach (string s in splitted)
                    {
                        string name = $"BGUARD_{ Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 8)}";
                        setlines.Add($"set \"{name}={s}\"{Environment.NewLine}");
                        vars.Add(name);
                    }
                    linevars.Add(vars.ToArray());
                }
                foreach (string sl in setlines.OrderBy(x => rng.Next()).ToArray()) batchcode += sl; // Write all variables in random order
            }

            if (checkBox1.Checked) // String substitution
            {
                string bcopy = batchcode;
                batchcode = string.Empty;
                string lsetname = $"BGUARD_{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 10)}";
                string ulsetname = $"BGUARD_{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 10)}";
                string numsetname = $"BGUARD_{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 10)}";

                string letterset = new string(letchars.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
                string upletterset = new string(letupchars.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
                string numberset = new string(numchars.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());

                int[] setorder = new int[] { 1, 2, 3 }.OrderBy(x => rng.Next()).ToArray();
                foreach (int s in setorder)
                {
                    switch (s)
                    {
                        case 1:
                            gencode.AppendLine($"set {lsetname}={letterset}");
                            break;
                        case 2:
                            gencode.AppendLine($"set {ulsetname}={upletterset}");
                            break;
                        case 3:
                            gencode.AppendLine($"set {numsetname}={numberset}");
                            break;
                    }
                }

                bool invar = false;
                foreach (char c in bcopy)
                {
                    if (c == '%') invar = !invar;
                    if (invar)
                    {
                        if (char.IsLetter(c))
                        {
                            int r = rng.Next(0, 2);
                            if (r == 0) batchcode += char.ToUpper(c);
                            else batchcode += char.ToLower(c);
                        }
                        else batchcode += c;
                        continue;
                    }
                    if (char.IsLetter(c))
                    {
                        if (char.IsUpper(c)) batchcode += $"%{ulsetname}:~{upletterset.IndexOf(c)},1%";
                        else batchcode += $"%{lsetname}:~{letterset.IndexOf(c)},1%";
                    }
                    else if (char.IsDigit(c)) batchcode += $"%{numsetname}:~{numberset.IndexOf(c)},1%";
                    else batchcode += c;
                }
            }

            if (checkBox2.Checked) // Splitting strings
            {
                // Call all variables in correct order
                foreach (string[] line in linevars)
                {
                    foreach (string s in line)
                    {
                        batchcode += $"%{s}%";
                    }
                    batchcode += Environment.NewLine;
                }
            }

            gencode.AppendLine(batchcode);

            if (listBox1.Items.Count > 0)
            {
                // Add code for cleaning up extracted files
                foreach (string item in listBox1.Items)
                {
                    gencode.AppendLine($"del \"%~dp0\\{Path.GetFileName(item)}\"");
                }
            }

            if (checkBox3.Checked) // UTF-16 BOM
            {
                byte[] uniheader = new byte[] { 0xFF, 0xFE, 0x0D, 0x0A };
                byte[] gencodebytes = Encoding.ASCII.GetBytes(gencode.ToString());
                finaloutput = new byte[uniheader.Length + gencodebytes.Length + 1];
                uniheader.CopyTo(finaloutput, 0);
                gencodebytes.CopyTo(finaloutput, uniheader.Length);
            }
            else
            {
                finaloutput = Encoding.ASCII.GetBytes(gencode.ToString());
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sfd.FileName, finaloutput);
            }

            textBox1.Text = sfd.FileName;
            button3.Enabled = true;
        }
    }
}
