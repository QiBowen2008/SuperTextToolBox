using JiebaNet.Segmenter;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace SuperTextToolBox
{
    public partial class frmFenci : AntdUI.BaseForm
    {
        JiebaSegmenter _segmenter = new JiebaSegmenter();
        public frmFenci()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sd = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(0));
                richTextBox1.Text = sd.ReadToEnd();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1 .Text.Trim();
            if (!string.IsNullOrEmpty(inputText))
            {
                var segments = _segmenter.Cut(inputText, cutAll: false); // 使用精确模式
                richTextBox3.Text = string.Join(" / ", segments);
            }
            else
            {
                MessageBox.Show("请输入要分词的文本！");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox3.Text))
            {
                MessageBox.Show("请先分词");
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
                        sw.Write(richTextBox3.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(richTextBox3.Text);
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
                        sw.Write(richTextBox3.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }

        private void frmFenci_Load(object sender, EventArgs e)
        {
            // 获取当前DPI比例
            float dpiX, dpiY;
            using (Graphics g = CreateGraphics())
            {
                dpiX = g.DpiX;
                dpiY = g.DpiY;
            }
            // 根据DPI比例调整控件尺寸
            float scaleFactor = dpiX / 96f; // 96 DPI 是标准DPI
            foreach (Control control in Controls)
            {
                control.Width = (int)(control.Width * scaleFactor);
                control.Height = (int)(control.Height * scaleFactor);
                control.Left = (int)(control.Left * scaleFactor);
                control.Top = (int)(control.Top * scaleFactor);
                 
            }
            Height = (int)(450 * scaleFactor);
            Width = (int)(594 * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
             
        }
    }
}
