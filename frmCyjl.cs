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
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先预设成语");
            }
            else 
            {
                lbltip.Text = "";
                settime = Convert.ToInt32(comboBox1.Text);//读取时间
                int score = Convert.ToInt32(lblscore.Text);//读取分数
                comboBox1.Enabled = false;//锁定时间框
                string newt = textBox1.Text;//读取成语
                if (listBox1.Items.Count == 0)//判断是不是第一次输入
                {
                    lbltime.Text = settime.ToString();//赋值时间
                    listBox1.Items.Add(newt);//添加成语到列表
                    oldt = newt;//添加之后把新的成语变成旧的成语
                    newt = "";//销毁新成语
                    label1.Text = "请接龙";//以下四行修改属性，进入游戏状态
                    textBox1.Text = "";
                    button1.Text = "接龙";
                    timer1.Enabled = true;//开始计时
                }
                else
                {
                    if (listBox1.FindStringExact(newt) == -1)//判断成语是否用过
                    {
                        if (newt.Length != 4)//判断成语是不是四字词语
                        {
                            lbltip.Text = "目前仅支持四字词语";
                        }
                        else
                        {
                            if (oldt.Substring(oldt.Length - 1, 1) == newt.Substring(0, 1))//判断接龙是否正确
                            {
                                lbltime.Text = settime.ToString();//复位时间
                                timer1.Enabled = true;//重新计时
                                listBox1.Items.Add(newt);
                                oldt = newt;
                                newt = "";
                                score = score + 1;//分数+1
                                lblscore.Text = score.ToString();//赋值新分数
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbltime.Text != "0")//判断是否时间结束
            {
                int lasttime = Convert.ToInt32(lbltime.Text);
                lasttime = lasttime - 1;
                lbltime.Text = lasttime.ToString();
            }
            else
            {
                lbltip.Text = "游戏结束";//如果剩余0秒代表时间到了，停止游戏
                button1.Enabled = false;//设置按钮不能输入
            }
        }

        private void button2_Click(object sender, EventArgs e)//复位游戏
        {
            listBox1.Items.Clear();//清理列表框
            textBox1.Text = "";//请客文本框
            comboBox1.Enabled = true;//激活组合框
            timer1.Enabled = false;//停止计时
            lbltime.Text = settime.ToString () ;//复位时间
            lblscore.Text = "0";//分数归零
        }
    }
}
