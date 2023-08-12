# SensitiveWordetection——敏感词检测
功能：检测文本中有无反政府的词语
## 使用示范
界面效果

<<<<<<< HEAD
-   ![TEST.PNG](https://tucdn.wpon.cn/2023/07/21/d4fb89df22cc1.PNG)

C#代码

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
	            string word = textBox1.Text;
	            textBox2.Text = SuperFreeApi.SensitiveWordetection.Detection.CheckText(word);
	            textBox3.Text = SuperFreeApi.SensitiveWordetection.Detection.GetSensitiveWord(word);
	        }
	    }
	}
VB.NET代码

	Public Class Form1
	    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
	        Dim word As String = textBox1.Text
	        textBox2.Text = SuperFreeApi.SensitiveWordetection.Detection.CheckText(word);
	        textBox3.Text = SuperFreeApi.SensitiveWordetection.Detection.GetSensitiveWord(word);
	    End Sub
	End Class

=======
>>>>>>> db93b806048f3e5197339dc98421e4ab59b20888

