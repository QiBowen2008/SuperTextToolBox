using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperWenZiToolBox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTexttoWave ftexttoWave = new frmTexttoWave();
            ftexttoWave.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            button4.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTranslate ftranslate = new frmTranslate();
            ftranslate.Show();
        }



        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmPinyin fpinyin = new frmPinyin();
            fpinyin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmFenci fFenci = new frmFenci();
            fFenci.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool type;
            type = Environment.Is64BitOperatingSystem;
            if (type == true)
            {
                Process.Start("OCR.exe");
            }
            else
            {
                MessageBox.Show("需要64位操作系统");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("WordCloudApp.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCyjl cyjl = new frmCyjl();
            cyjl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSet set = new frmSet();
            set.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
    }
}
