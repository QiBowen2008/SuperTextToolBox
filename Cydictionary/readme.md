# CyDictionary——成语词典模块 #

功能：查询成语解释，用法，辨析（仅限部分），造句，出处

## 使用示范 ##

界面：

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/Cydictionary/1.PNG)

C#代码

    using System;
	using SuperFreeApi.CyDictionary;
	using System.Windows.Forms;

	namespace DLLtest
	{
    	public partial class Form1 : Form
    	{
    	    public Form1()
    	    {
    	        InitializeComponent();
    	    }
	
    	    private void button1_Click(object sender, EventArgs e)
    	    {
    	        string Cy = textBox1.Text;
    	        textBox2.Text = Dictionary.Getcyjs(Cy);
    	        textBox3.Text = Dictionary.Getcyzj(Cy);
    	        textBox4.Text = Dictionary.Getcycc(Cy);
    	        textBox5.Text = Dictionary.Getcybx(Cy);
    	        textBox6.Text = Dictionary.Getcysy(Cy);
    	    }
    	}
	}

VB.NET代码

    Imports SuperFreeApi.CyDictionary

	Public Class Form1
    	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
    	    Dim Cy As String = textBox1.Text
    	    textBox2.Text = Dictionary.Getcyjs(Cy)
    	    textBox3.Text = Dictionary.Getcyzj(Cy)
    	    textBox4.Text = Dictionary.Getcycc(Cy)
    	    textBox5.Text = Dictionary.Getcybx(Cy)
    	    textBox6.Text = Dictionary.Getcysy(Cy)
    	End Sub
	End Class
