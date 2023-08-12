# Translate——免费的翻译API

功能：中英互译

## 使用示范

界面效果

![输入图片描述](https://raw.githubusercontent.com/QiBowen2008/SuperFreeApi/main/Translate/%E7%95%8C%E9%9D%A2.PNG)

代码
C#

    using System;
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
	            int lang=1;
	            if(radioButton1 .Checked ==true)
	            {
	                lang = 1;
	            }
	            else if(radioButton2 .Checked ==true )
	            {
	                lang = 2;
	            }
	            else if(radioButton3 .Checked ==true)
	            {
	                lang = 3;
	            }
	            string word = textBox1.Text;
	            textBox2.Text = SuperFreeApi.Translate.Translator.Translate(word, lang);
	        }
	    }
	}
VB.NET

	Public Class Form1
	    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
		    Dim lang As Integer = 1
	        If radioButton1.Checked = True Then
	            lang = 1
	        ElseIf radioButton2.Checked = True Then
		        lang = 2
	        ElseIf radioButton3.Checked = True Then
	            lang = 3
	        End If
	        Dim word As String = textBox1.Text
	        textBox2.Text = SuperFreeApi.Translate.Translator.Translate(word, lang)
	    End Sub
	End Class

