using System;
using System.Windows.Forms;

namespace SuperWenZiToolBox
{
    public partial class frmCyjl : Form
    {
        public int settime;
        public string oldt;
        public frmCyjl()
        {
            InitializeComponent();
        }

        private void frmCyjl_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "10";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                button1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltip.Text = "";
            settime = Convert.ToInt32(comboBox1.Text);
            int score = Convert.ToInt32(lblscore .Text );
            comboBox1.Enabled = false;
            string newt = textBox1.Text;
            if (listBox1.Items.Count ==0) 
            {
                lbltime.Text = settime.ToString();
                listBox1.Items.Add(newt);
                oldt = newt;
                newt = "";
                label1.Text = "请接龙";
                textBox1.Text = "";
                button1.Text = "接龙";
                timer1.Enabled = true;
            }
            else
            {
                

                if(listBox1 .FindStringExact (newt )==-1)
                {
                    if (newt.Length!=4)
                    {
                        lbltip .Text ="目前仅支持四字词语";
                    }
                    else
                    {
                        if (oldt.Substring(oldt .Length -1,1) == newt.Substring(0, 1))
                        {
                            lbltime.Text = settime.ToString();
                            timer1.Enabled = true;
                            listBox1.Items.Add(newt);
                            oldt = newt;
                            newt = "";
                            score = score + 1;
                            lblscore.Text = score.ToString();
                        }
                        else
                        {
                            lbltip.Text = "请正确接龙";
                        }
                    }
                }
                else
                {
                    lbltip.Text = "成语已经用过了";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbltime .Text !="0")
            {
                int lasttime = Convert.ToInt32(lbltime.Text);
                lasttime = lasttime - 1;
                lbltime.Text = lasttime.ToString();
            }
            else
            {
                lbltip.Text = "游戏结束";
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            comboBox1.Enabled = true;
            timer1.Enabled = false;
            lbltime.Text = "";
            lblscore.Text = "0";
        }
    }
}
