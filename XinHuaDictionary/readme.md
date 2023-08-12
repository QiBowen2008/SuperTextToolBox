# XinHuaDictionary——给你的程序内嵌在线字典 #
## 使用示范 ##

C#代码

	using System;
	using SuperFreeApi.XinHuaDictionary;
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
	            string character = textBox1.Text;
	            textBox2.Text = Dictionary.GetCharacterbs (character);
	            textBox3.Text = Dictionary.GetCharacteryj (character);
	            textBox4.Text = Dictionary.GetCharacterbsbh (character);
	            textBox5.Text = Dictionary.GetCharacterbwbh (character);
	            textBox6.Text = Dictionary.GetCharacterzsbh  (character);
	            textBox7.Text = Dictionary.GetCharacterbsxf (character);
	        }
	    }
	}

VB.NET代码

    Imports SuperFreeApi.XinHuaDictionary

	Public Class Form1
    	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
    	    Dim character As String = textBox1.Text
    	    textBox2.Text = Dictionary.GetCharacterbs(character)
    	    textBox3.Text = Dictionary.GetCharacteryj(character)
    	    textBox4.Text = Dictionary.GetCharacterbsbh(character)
    	    textBox5.Text = Dictionary.GetCharacterbwbh(character)
    	    textBox6.Text = Dictionary.GetCharacterzsbh(character)
    	    textBox7.Text = Dictionary.GetCharacterbsxf(character)
    	End Sub
	End Class

效果

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/XinHuaDictionary/1.PNG)
