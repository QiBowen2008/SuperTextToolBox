using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Security.Policy;

namespace SuperWenZiToolBox
{
    public partial class frmSet : Sunny.UI.UIForm
    {
        public frmSet()
        {
            InitializeComponent();
        }
        string IniPath = Set.INIpath;
        public static string selectlang;
        public readonly static string qt = "multilingual/";
        public static string lang = "ch";
        public static string oldpath;
        public readonly static string ed = "_PP-OCRv3_rec_infer";
        private void button2_Click(object sender, EventArgs e) => Close();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (uiCheckBox2.Checked == true)
            {
                textBox1.Enabled = true;
                uiButton3.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                uiButton3.Enabled = false;
            }
        }
        public static object CopyFolder(string sourceFolder, string destFolder)
        {
            try
            {
                //如果目标路径不存在,则创建目标路径
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }
                //得到原文件根目录下的所有文件
                string[] files = Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    string dest = Path.Combine(destFolder, name);
                    File.Copy(file, dest, true);//复制文件
                }
                //得到原文件根目录下的所有文件夹
                string[] folders = Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    string dest = Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);//构建目标路径,递归复制文件
                }
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        private void frmSet_Load(object sender, EventArgs e)
        {
            moveable = false;
            textBox2.Text = IniManager.getString("Set", "FileSavePath", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            string autosave = IniManager.getString("Set", "AutoSave", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            if (autosave == "False")
                uiCheckBox2.Checked = false;
            else
                uiCheckBox2.Checked = true;
            textBox1.Text = IniManager.getString("Set", "OCRSavePath", Application.StartupPath + "\\inference", Set.INIpath);
            if (textBox2.Text == "")
                textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (textBox1.Text == "")
            {
                textBox1.Text = Application.StartupPath + "\\inference";
                IniManager.writeString("Set", "OCRSavePath", textBox1.Text, IniPath);
            }
            uiComboBox4.Text = "简体中文";
            if (Directory.Exists(textBox1.Text + "\\ch_PP-OCRv3_rec_infer"))
            {
                label6.Text = "已下载"; uiButton4.Text = "删除";
            }
            else
                label6.Text = "未下载"; uiButton4.Text = "下载";
            selectlang = "chinese/ch_PP-OCRv3_rec_infer";
            lang = "ch";
            oldpath = textBox1.Text;
        }
        public  string[] oldpaths = new string[8];
        public  string[] oldfiles = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            IniManager.writeString("Set", "FileSavePath", textBox1.Text, IniPath);
            IniManager.writeString("Set", "OCRSavePath", textBox1.Text, IniPath);
            if (uiCheckBox2.Checked == true)
                IniManager.writeString("Set", "AutoSave", "True", IniPath);
            else
                IniManager.writeString("Set", "AutoSave", "False", IniPath);
            Properties.Settings.Default.AutoIcon = uiCheckBox1.Checked;
            if (uiComboBox1.Text != "" && uiComboBox2.Text != "")
            {
                Properties.Settings.Default.TranslateAppID = uiComboBox1.Text;
                Properties.Settings.Default.TranslateApiKey = uiComboBox2.Text;
            }
            else
            {
                MessageBox.Show("未设置Appid和Apikey，将无法使用翻译功能");
            }
            IniManager.writeString("Set", "OCRSavePath", textBox1.Text, IniPath);
            if (moveable == true)
            {
                string d = "_dict";
                oldpaths[0] = "\\ch" + ed;
                oldpaths[1] = "\\en" + ed;
                oldpaths[2] = "\\japan" + ed;
                oldpaths[3] = "\\korean" + ed;
                oldpaths[4] = "\\ch_ppocr_mobile_v2.0_cls_infer";//方向分类通用版
                oldpaths[5] = "\\ch_PP-OCRv3_det_infer";//文字内容识别
                oldpaths[6] = "\\en_PP-OCRv3_det_infer";
                oldpaths[7] = "\\Multilingual_PP-OCRv3_det_infer";
                for (i = 0; i < 8; i++)
                {
                    if (moveable == true)
                        if (Directory.Exists(oldpath + oldpaths[i]))
                            CopyFolder(oldpath + oldpaths[i], textBox1.Text + oldpaths[i]); 
                }
                oldfiles[0] = "en" + d;
                oldfiles[1] = "japan" + d;
                oldfiles[2] = "korean" + d;
                for (int j = 0; j < 3; j++)
                {
                    if (moveable == true)
                        if (File.Exists(oldpath + oldfiles[j]))
                            File.Copy(oldpath + oldfiles[j], textBox1.Text + oldfiles[j], true);
                }
            }
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                uiComboBox2.Focus();
            }
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                uiButton1.Focus();
            }
        }
        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (uiButton4.Text == "下载")
            {
                oldpath = textBox1.Text;
                label7.Visible = true;
                label8.Visible = true;
                progressBar1.Visible = true;
                if (lang == "ch")
                {
                    DownloadFile("https://gitee.com/raoyutian/paddle-ocrsharp/raw/master/models/PP-OCRv4/ch_PP-OCRv4.zip", textBox2.Text + "\\" + lang + ".tar");
                }
                else if (lang == "en")
                {
                    DownloadFile("https://gitee.com/raoyutian/paddle-ocrsharp/raw/master/models/PP-OCRv4/en_PP-OCRv4.zip", textBox2.Text + "\\" + lang + ".tar");
                }
                else
                {
                    DownloadFile("https://paddleocr.bj.bcebos.com/PP-OCRv3/" + selectlang + ".tar", textBox2.Text + "\\" + lang + ".tar", progressBar1, label8);
                }
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + Application.StartupPath + "\\7z.exe x " + textBox2.Text + "\\" + lang + ".tar " + "-o" + textBox1.Text;
                process.Start();
                if (Directory.Exists(textBox1.Text + "\\ch_ppocr_mobile_v2.0_cls_infer") == false)
                {
                    DownloadFile("https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_mobile_v2.0_cls_infer.tar", textBox2.Text + "\\" + "chtmp2.tar", progressBar1, label8);
                    Process process3 = new Process();
                    process3.StartInfo.FileName = "cmd.exe";
                    process3.StartInfo.Arguments = "/c " + Application.StartupPath + "\\7z.exe x " + textBox2.Text + "\\chtmp2.tar " + "-o" + textBox1.Text;
                    process3.Start();
                }
                if (uiComboBox4.Text == "简体中文")
                {

                }
                else
                {
                    if (lang == "英文")
                    {

                    }
                    else
                    {
                        DownloadFile("https://gitee.com/paddlepaddle/PaddleOCR/raw/dygraph/ppocr/utils/dict/" + lang + "_dict.txt", textBox1.Text + "\\" + lang + "_dict.txt", progressBar1, label8);
                        if (Directory.Exists(textBox1.Text + "\\Multilingual_PP-OCRv3_det_infer") == false)
                        {
                            DownloadFile("https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/Multilingual_PP-OCRv3_det_infer.tar", textBox2.Text + "\\" + "mltmp1.tar", progressBar1, label8);
                            Process process3 = new Process();
                            process3.StartInfo.FileName = "cmd.exe";
                            process3.StartInfo.Arguments = "/c " + Application.StartupPath + "\\7z.exe x " + textBox2.Text + "\\mltmp1.tar " + "-o" + textBox1.Text;
                            process3.Start();
                        }
                    }
                }
                label6.Text = "已下载";
                uiButton4.Text = "删除";
            }
            else
            {
                uiButton4.Text = "下载";

                if (uiComboBox4.Text == "简体中文")
                {
                    Directory.Delete(oldpath + "\\ch_PP-OCRv4", true);
                }
                else if (uiComboBox4.Text == "英文")
                {
                    Directory.Delete(oldpath + "\\en_PP-OCRv4");
                }
                else
                {
                    Directory.Delete(oldpath + "\\" + lang + ed, true);
                    File.Delete(oldpath + "\\" + lang + "_dict.txt");
                }
            }
        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                moveable = true;
            }
        }
        public void DownloadFile(string URL, string filename, ProgressBar prog, Label label1)
        {
            float percent = 0;
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    if((int)totalBytes >= 0)
                    {
                        prog.Maximum = (int)totalBytes;
                    }
                }
                Stream st = myrp.GetResponseStream();
                Stream so = new FileStream(filename, FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, by.Length);
                    percent = totalDownloadedByte / (float)totalBytes * 100;
                    label1.Text = "当前资源包下载进度" + percent.ToString() + "%";
                    Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
                label7.Hide();
                label8.Hide();
                progressBar1.Hide();
        }
        public void DownloadFile(string URL,string filename)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(URL, filename);
            }
            label8.Text = "正在下载";
        }
        private void uiComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox4.Text == "简体中文")
            {
                lang = "ch";
                selectlang = "chinese/ch_PP-OCRv3_rec_infer";
            }
            else if (uiComboBox4.Text == "英文")
            {
                lang = "en";
                selectlang = "english/en_PP-OCRv3_rec_infer";
            }
            else
            {
                if (uiComboBox4.Text == "日语")
                {
                    lang = "japan";
                }
                else if (uiComboBox4.Text == "韩语")
                {
                    lang = "korean";
                }
                selectlang = qt + lang + ed;
            }
            if (Directory.Exists(textBox1.Text + "\\" + lang + ed))
            {
                label6.Text = "已下载"; uiButton4.Text = "删除";
            }
            else
            {
                label6.Text = "未下载"; uiButton4.Text = "下载";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://developer.aliyun.com/article/1174048");
        public static bool moveable;
        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}