using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Chinese;
using System.Windows.Forms;
using System.IO;

namespace SuperWenZiToolBox
{
    public partial class frmPinyin : Form
    {
        public frmPinyin()
        {
            InitializeComponent();
        }

        private void frmPinyin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox2.Text))
            {
                MessageBox.Show("请先转换");

            }
            else
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(richTextBox2.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           richTextBox2 .Text = Pinyin.GetString(richTextBox1 .Text , PinyinFormat.Phonetic);
        }
    }
}