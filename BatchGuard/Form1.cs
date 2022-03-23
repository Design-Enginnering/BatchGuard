using System;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BatchGuard
{
    public partial class Form1 : Form
    {

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
            if (checkBox4.Checked) // Strip comments
            {
                StringBuilder nocomments = new StringBuilder();
                foreach (string line in batchcode.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    if (!line.ToLower().StartsWith("rem"))
                    {
                        nocomments.AppendLine(line);
                    }
                }
                batchcode = nocomments.ToString();
            }
            if (checkBox1.Checked) // String substitution
            {
                gencode.Append(StringSub.GenVars(rng));
                batchcode = StringSub.GenCode(batchcode, rng);
            }
            if (checkBox2.Checked) // Splitting strings
            {
                batchcode = StringSplit.GenCode(batchcode, rng, checkBox1.Checked, 3);
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

            string outputpath = $"{Path.GetDirectoryName(textBox1.Text)}\\{Path.GetFileNameWithoutExtension(textBox1.Text)}_obf.bat";
            File.WriteAllBytes(outputpath, finaloutput);

            textBox1.Text = outputpath;
            button3.Enabled = true;
        }
    }
}
