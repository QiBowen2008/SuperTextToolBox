using Chinese;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace SuperLangToolWordAddIn
{
    public partial class frmTranslate : Form
    {
        public frmTranslate()
        {
            InitializeComponent();
        }

        private void frmTranslate_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = richTextBox1.Text;
            // 源语言
            string from = "zh";
            // 目标语言
            string to = "en";
            // 改成您的APP ID
            string appId = "20230101001515968";
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            // 改成您的密钥
            string secretKey = "4xaPms6ok7erM5n6MuuE";
            string sign = EncryptString(appId + q + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
            url += "q=" + HttpUtility.UrlEncode(q);
            url += "&from=" + from;
            url += "&to=" + to;
            url += "&appid=" + appId;
            url += "&salt=" + salt;
            url += "&sign=" + sign;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 60000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            Console.WriteLine(retString);
            Console.ReadLine();
            textBox1.Clear();

            PostResult res = JsonConvert.DeserializeObject<PostResult>(retString);
            if (res.Error_code == null)
            {
                textBox1.AppendText(res.Trans_result[0].Dst);
            }
            else
                textBox1.AppendText(res.Error_msg);
        }
        public class PostResult
        {
            public string Error_code { set; get; }
            public string Error_msg { set; get; }
            public string From { set; get; }
            public string To { set; get; }
            public TranslateContent[] Trans_result { set; get; }
        }

        public class TranslateContent
        {
            public string Src { set; get; }
            public string Dst { set; get; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 原文
            string q = richTextBox1.Text;
            // 源语言
            string from = "en";
            // 目标语言
            string to = "zh";
            // 改成您的APP ID
            string appId = "20230101001515968";
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            // 改成您的密钥
            string secretKey = "4xaPms6ok7erM5n6MuuE";
            string sign = EncryptString(appId + q + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
            url += "q=" + HttpUtility.UrlEncode(q);
            url += "&from=" + from;
            url += "&to=" + to;
            url += "&appid=" + appId;
            url += "&salt=" + salt;
            url += "&sign=" + sign;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 60000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            Console.WriteLine(retString);
            Console.ReadLine();
            textBox1.Clear();

            PostResult res = JsonConvert.DeserializeObject<PostResult>(retString);
            if (res.Error_code == null)
            {
                textBox1.AppendText(res.Trans_result[0].Dst);
            }
            else
                textBox1.AppendText(res.Error_msg);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先翻译");

            }
            else
            {
                saveFileDialog1.Filter = "文本文档 | *.txt";
                saveFileDialog1.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ChineseConverter.ToTraditional(richTextBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = ChineseConverter.ToSimplified(richTextBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
            voice.Rate = trackBar2.Value - 5;
            voice.Volume = trackBar1.Value * 10; //设置音量,[0,100]
            voice.SpeakAsync(textBox1.Text);  //播放指定的字符串,这是异步朗读
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先输入文本");

            }
            else
            {
                saveFileDialog1.Filter = "音频|*.mp3";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                    voice.SetOutputToWaveFile(saveFileDialog1.FileName);
                    voice.Rate = trackBar2.Value - 5; //设置语速,[-10,10]
                    voice.Volume = trackBar1.Value * 10; //设置音量,[0,100]
                    voice.Speak(textBox1.Text);
                    voice.SetOutputToNull();
                }
            }
        }
    }
}
