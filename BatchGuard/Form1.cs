using System;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

using BatchGuard.Protections;

namespace BatchGuard
{
    public partial class Form1 : Form
    {
        private string openedfilepath = string.Empty;
        public Form1()
        {
            Debug.Log("Form opened.", LogType.Success);
            InitializeComponent();
            Debug.Log("Components initialised.", LogType.Info);
            listBox1.BackColor = Color.FromArgb(38, 38, 66);
            listBox1.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openedfilepath = ofd.FileName;
                textBox1.Text = File.ReadAllText(ofd.FileName);
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
            Debug.Log("Obfuscating batch script...", LogType.Normal);

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
                    Debug.Log($"Embedded {item}", LogType.Success);
                }
            }

            string batchcode = textBox1.Text;
            if (checkBox4.Checked) // Strip comments
            {
                Debug.Log("Stripping comments...", LogType.Normal);
                int commentsremoved = 0;
                StringBuilder nocomments = new StringBuilder();
                string[] lines = batchcode.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToLower().StartsWith("rem"))
                    {
                        Debug.Log($"Comment found on line {i + 1}.", LogType.Warning);
                        commentsremoved++;
                        continue;
                    }
                    nocomments.AppendLine(lines[i]);
                }
                batchcode = nocomments.ToString();
                Debug.Log($"Removed {commentsremoved} comment(s).", LogType.Success);
            }
            if (checkBox1.Checked) // String substitution
            {
                Debug.Log("Substituting strings...", LogType.Normal);
                gencode.Append(StringSub.GenVars(rng));
                Debug.Log("Generated variables.", LogType.Info);
                batchcode = StringSub.GenCode(batchcode, rng);
                Debug.Log("Generated code.", LogType.Info);
                Debug.Log("String substitution complete.", LogType.Success);
            }
            if (checkBox2.Checked) // Splitting strings
            {
                Debug.Log("Splitting strings...", LogType.Normal);
                batchcode = StringSplit.GenCode(batchcode, rng, checkBox1.Checked, 3);
                Debug.Log("Generated code with complexity level 3.", LogType.Info);
                Debug.Log("String splitting complete.", LogType.Success);
            }
            gencode.AppendLine(batchcode);

            if (listBox1.Items.Count > 0)
            {
                // Add code for cleaning up extracted files
                foreach (string item in listBox1.Items)
                {
                    gencode.AppendLine($"del \"%~dp0\\{Path.GetFileName(item)}\"");
                    Debug.Log($"Added cleanup code for embedded item: {item}", LogType.Success);
                }
            }

            if (checkBox3.Checked) finaloutput = UTF16BOM.Process(gencode.ToString());
            else finaloutput = Encoding.ASCII.GetBytes(gencode.ToString());

            string outpath = $"{Path.GetDirectoryName(openedfilepath)}\\{Path.GetFileNameWithoutExtension(openedfilepath)}_obf.bat";
            File.WriteAllBytes(outpath, finaloutput);
            Debug.Log("Output saved.", LogType.Success);

            Process.Start("notepad.exe", outpath);
            button3.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no lol");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no lol");
        }
    }
}
