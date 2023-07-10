using Chinese;
using System;
using System.IO;
using System.Windows.Forms;
namespace SuperWenZiToolBox
{
    public partial class frmPinyin : Sunny.UI.UIForm
    {
        public frmPinyin()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sd = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(0));
                richTextBox1.Text = sd.ReadToEnd();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先转换");
            }
            else
            {
                saveFileDialog1.Filter = "文本文档 | *.txt";
                string autosave = IniManager.getString("Set", "AutoSave", "", Set.INIpath);
                if (autosave == "True")
                {
                    string filesavepath = IniManager.getString("Set", "FileSavePath", "", Set.INIpath);
                    if (filesavepath != "")
                    {
                        string nowtime = DateTime.Now.ToShortTimeString().ToString();
                        StreamWriter sw = new StreamWriter(filesavepath + "\\" + Guid.NewGuid().ToString() + ".txt");
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(textBox1.Text);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("请输入文本");
            }
            else
            {
                toolStripStatusLabel1.Text = "正在转换";
                textBox1.Text = Pinyin.GetString(richTextBox1.Text, PinyinFormat.Phonetic);
            }
        }
    }
}