using System;
using System.Diagnostics;
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
             
            moveable = false;
            input1.Text = IniManager.getString("Set", "FileSavePath", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            string autosave = IniManager.getString("Set", "AutoSave", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            if (autosave == "True")
                switch2.Checked = true;
            else
                switch2.Checked = false;
        }
        public string[] oldpaths = new string[8];
        public string[] oldfiles = new string[3];
        private void SaveSet(object sender, EventArgs e)
        {
            if (switch2.Checked == true)
                IniManager.writeString("Set", "AutoSave", "True", IniPath);
            else
                IniManager.writeString("Set", "AutoSave", "False", IniPath);
            Properties.Settings.Default.AutoIcon = switch1.Checked;
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
        public static bool moveable;
        private void ShowDialohg(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                input1.Text = folderBrowserDialog1.SelectedPath;
        }


        private void ShowApiHelp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://blog.csdn.net/chenweicai1989/article/details/141183304");
        }

        private void switch2_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (switch2.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}