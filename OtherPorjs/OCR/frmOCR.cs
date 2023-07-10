using PaddleOCRSharp;
using Sunny.UI;
using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace OCR
{
    public partial class frmOCR : Sunny.UI.UIForm
    {
        public static string path = IniManager.getString("Set", "OCRSavePath", Application.StartupPath, Application.StartupPath + "\\config.ini");
        public static string selectlang;
        public static string lang = "";
        public readonly static string ed = "_PP-OCRv3_rec_infer";
        public frmOCR()
        {
            InitializeComponent();
        }
        private void frmOCR_Load(object sender, EventArgs e)
        {
            path = IniManager.getString("Set", "OCRSavePath", Application.StartupPath+"\\inference", Application.StartupPath + "\\config.ini");
            uiComboBox1.Text = "简体中文";
            if (Directory.Exists(path + "\\ch_ppocr_server_v2.0_rec"))
            {
                uiButton1.Enabled = true;
                toolStripStatusLabel1.Text = "就绪";
            }
            else
            {
                uiButton1.Enabled = false;
                toolStripStatusLabel1.Text = "该语言配置文件未下载，请去设置界面下载";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "识别中";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.png;*.jpg;*.jpeg;*.tiff;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            //使用默认中英文V3模型
            pictureBox1.Image = Image.FromFile(ofd.FileName);
            OCRModelConfig config = new OCRModelConfig();
            if (uiComboBox1.Text == "简体中文")
            {
                config.det_infer = path + @"/ch_PP-OCRv3_det_infer";
                config.rec_infer = path + @"/ch_PP-OCRv3_rec_infer";
                config.cls_infer = path + @"/ch_ppocr_mobile_v2.0_cls_infer";
                config.keys = Application.StartupPath + "\\ppocr_keys.txt";
            }
            else if (uiComboBox1.Text == "英文")
            {
                config.det_infer = path + @"/en_PP-OCRv3_det_infer";
                config.rec_infer = path + @"/en_PP-OCRv3_rec_infer";
                config.cls_infer = path + @"/ch_ppocr_mobile_v2.0_cls_infer";
                config.keys = path + @"/en_dict.txt";
            }
            else
            {
                config.det_infer = path + @"/Multilingual_PP-OCRv3_det_infer";
                config.rec_infer = path + @"/" + selectlang;
                config.cls_infer = path + @"/ch_ppocr_mobile_v2.0_cls_infer";
                config.keys = path + "\\" + lang + "_dict.txt";
            }
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
                toolStripStatusLabel1.Text = "识别成功";
            }
            else
            {
                MessageBox.Show("未识别到文本");
                toolStripStatusLabel1.Text = "就绪";
            }
            engine.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先识别");
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
        public void FolderExist(string selectl)
        {
            if (Directory.Exists(path + "\\" + selectl))
            {
                toolStripStatusLabel1.Text = "就绪"; uiButton1.Enabled = true;
            }
            else
            {
                toolStripStatusLabel1.Text = "该语言配置文件未下载，请去设置界面下载"; uiButton1.Enabled = false;
            }
        }
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.Text == "简体中文")
            {
                lang = "ch";
                selectlang = "chinese/ch_PP-OCRv3_rec_infer";
            }
            else if (uiComboBox1.Text == "英文")
            {
                lang = "en";
                selectlang = "english/en_PP-OCRv3_rec_infer";
            }
            else
            {
                if (uiComboBox1.Text == "日文")
                {
                    lang = "japan";
                }
                else if (uiComboBox1.Text == "韩文")
                {
                    lang = "korean";
                }
                selectlang = lang + ed;
            }
            if (Directory.Exists(path + "\\" + lang + ed))
            {
                toolStripStatusLabel1 .Text = "已下载"; uiButton1.Enabled =true ;
            }
            else
            {
                toolStripStatusLabel1 .Text = "未下载"; uiButton1.Enabled =false  ;
            }
        }
    }
}
