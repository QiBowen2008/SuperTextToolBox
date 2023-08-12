# Saying Maker——为你的应用程序添加随机名言 #
## 使用示范 ##


    using System;
	using SayingMaker;
	using System.Windows.Forms;

	namespace Test
	{
    	public partial class Form1 : Form
    	{
        	public Form1()
        	{
            	InitializeComponent();
        	}

        	private void Form1_Load(object sender, EventArgs e)
        	{
            	textBox1.Text = Maker.GetSaying();
        	}
    	}
	}
## 效果 ##

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/SayingMaker/1.jpg)
