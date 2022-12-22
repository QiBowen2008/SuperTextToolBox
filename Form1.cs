using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOCR fOCR = new frmOCR();
            fOCR.Show(); 
        }
    }
}
