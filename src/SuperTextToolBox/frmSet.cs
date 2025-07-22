using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperTextToolBox
{
    public partial class frmSet : AntdUI.BaseForm
    {
        public frmSet()
        {
            InitializeComponent();
        }
        string IniPath = Set.INIpath;
        public static string lang = "ch";
        public static string oldpath;
        private void button2_Click(object sender, EventArgs e) => Close();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (uiCheckBox2.Checked == true)
            {
                uiButton3.Enabled = true;
            }
            else
            {
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
                if (control ==uiTabControl1)
                {
                    foreach(Control tcontrol in uiTabControl1.Controls)
                    {
                        if(tcontrol is TabPage tpage)
                        {
                            foreach (Control pcon in tpage.Controls)
                            {
                                pcon .Width = (int)(pcon.Width * scaleFactor);
                                pcon.Height = (int)(pcon.Height * scaleFactor);
                                pcon.Left = (int)(pcon.Left * scaleFactor);
                                pcon .Top = (int)(pcon.Top * scaleFactor);
                            }
                        }
                    }
                }
            }
            this.uiTabControl1.ItemSize = new System.Drawing.Size((int)(150*scaleFactor) ,(int)( 40*scaleFactor ));
            Height = (int)(474 * scaleFactor);
            Width = (int)(659 * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
             
            moveable = false;
            textBox2.Text = IniManager.getString("Set", "FileSavePath", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            string autosave = IniManager.getString("Set", "AutoSave", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            if (autosave == "True")
                uiCheckBox2.Checked = true;
            else
                uiCheckBox2.Checked = false;
        }
        public string[] oldpaths = new string[8];
        public string[] oldfiles = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {
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
            Close();
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

        public void DownloadFile(string URL, string filename, ProgressBar prog, Label label1)
        {
            float percent = 0;
            System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URL);
            System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
            long totalBytes = myrp.ContentLength;
            if (prog != null)
            {
                if ((int)totalBytes >= 0)
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://developer.aliyun.com/article/1174048");
        public static bool moveable;
        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}