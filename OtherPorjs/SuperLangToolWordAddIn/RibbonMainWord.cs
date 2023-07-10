using Microsoft.Office.Tools.Ribbon;
using System.Diagnostics;

namespace SuperLangToolWordAddIn
{
    public partial class RibbonMainWord
    {
        private void RibbonMain_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {

            Process.Start("WordCloudApp.exe");

        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            frmFenci fenci = new frmFenci();
            fenci.Show();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            frmTranslate translate = new frmTranslate();
            translate.Show();
        }
    }
}
