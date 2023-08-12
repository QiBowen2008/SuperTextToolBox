# WeatherReporetr——为你的应用程序嵌入天气预报 #

功能：输入市级行政区或县级行政区全民，即可获取查询天气

## 使用示范 ##

界面效果：

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/WeatherReporter/1.PNG)

C#代码

    using System;
	using SuperFreeApi.WeatherReporter;
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
            	string city = textBox1.Text;
            	textBox2.Text = WeatherReporter.GetProvince(city);
            	textBox3.Text = WeatherReporter.GetWeather(city);
            	textBox4.Text = WeatherReporter.GetTemperature(city);
            	textBox5.Text = WeatherReporter.GetWindDirection(city);
            	textBox6.Text = WeatherReporter.GetWindPower(city);
            	textBox7.Text = WeatherReporter.GetHumidity(city);
            	textBox8.Text = WeatherReporter.GetReporttime(city);
        	}


    	}
	}

VB.NET代码

    Imports SuperFreeApi.WeatherReporter
	Public Class Form1
    	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        	Dim city As String = textBox1.Text
        	textBox2.Text = WeatherReporter.GetProvince(city)
        	textBox3.Text = WeatherReporter.GetWeather(city)
        	textBox4.Text = WeatherReporter.GetTemperature(city)
        	textBox5.Text = WeatherReporter.GetWindDirection(city)
        	textBox6.Text = WeatherReporter.GetWindPower(city)
        	textBox7.Text = WeatherReporter.GetHumidity(city)
        	textBox8.Text = WeatherReporter.GetReporttime(city)
    	End Sub
	End Class
