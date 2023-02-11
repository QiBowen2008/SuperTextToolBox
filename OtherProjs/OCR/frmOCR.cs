using System;
using System.Drawing;
using System.Windows.Forms;
using PaddleOCRSharp;
using System.IO;

namespace OCR
{
    public partial class frmOCR : Form
    {
        public frmOCR()
        {
            InitializeComponent();
        }

        private void frmOCR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.png;*.jpg;*.jpeg;*.tiff;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            //使用默认中英文V3模型
            pictureBox1.Image = Image.FromFile(ofd.FileName);
            textBox1.Text = "正在识别";
            OCRModelConfig config = null;
            //使用默认参数
            OCRParameter oCRParameter = new OCRParameter();
            //识别结果对象
            OCRResult ocrResult = new OCRResult();
            //建议程序全局初始化一次即可，不必每次识别都初始化，容易报错。     
            PaddleOCREngine engine = new PaddleOCREngine(config, oCRParameter);
            {
                ocrResult = engine.DetectText(ofd.FileName);
            }
            if (ocrResult != null)
            {
                textBox1.Text = ocrResult.Text;
            }
            else
            {
                MessageBox.Show("未识别到文本");
                textBox1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1 .Text))
            {
                MessageBox.Show("请先识别");

            }
            else
            {
                saveFileDialog1.Filter = "文本文档 | *.txt";
                saveFileDialog1.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
