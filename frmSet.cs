using System;
using System.Windows.Forms;

namespace SuperWenZiToolBox
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false; 
            }
        }

        private void frmSet_Load(object sender, EventArgs e)
        {
            textBox1.Text = IniManager.getString("Set", "FileSavePath", "", Set.INIpath);
            string autosave = IniManager.getString("Set", "AutoSave", "", Set.INIpath);
            if (autosave =="False")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IniPath = Set.INIpath;
            IniManager.writeString("Set", "FileSavePath", textBox1.Text, IniPath);
            if (checkBox1 .Checked ==true )
            {
                IniManager.writeString("Set", "AutoSave", "True", IniPath);
            }
            else
            {
                IniManager.writeString("Set", "AutoSave", "False", IniPath);
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
