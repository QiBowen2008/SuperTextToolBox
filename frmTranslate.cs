using Chinese;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Text;
using System.Web;
using System.Drawing;
using System.Windows.Forms;
namespace SuperWenZiToolBox
{
    public partial class frmTranslate : Sunny.UI.UIForm
    {
        public frmTranslate()
        {
            InitializeComponent();
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
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("请输入文本");
            }
            else
            {
                string q = richTextBox1.Text;
                // 源语言
                string from = comboBox1.Text;
                // 目标语言
                string to = comboBox2.Text;
                // 改成您的APP ID
                string appId = Properties.Settings.Default.TranslateAppID;
                Random rd = new Random();
                string salt = rd.Next(100000).ToString();
                // 改成您的密钥
                string secretKey = Properties.Settings.Default.TranslateApiKey;
                if (!string.IsNullOrEmpty(comboBox3.Text))
                {
                    if (comboBox3.Text == "普通")
                    {
                        toolStripStatusLabel1.Text = "翻译中";
                        if ((from != "zh" && to != "繁体中文") || (from != "繁体中文" && to != "zh"))
                        {
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
                                toolStripStatusLabel1.Text = "翻译成功";
                            }
                            else
                            {
                                textBox1.AppendText(res.Error_msg);
                                toolStripStatusLabel1.Text = "出现错误";
                            }
                        }

                        else if (from == "zh" && to == "繁体中文")
                        {
                            textBox1.Text = ChineseConverter.ToTraditional(richTextBox1.Text);
                            toolStripStatusLabel1.Text = "翻译成功";
                        }
                        else if (from == "繁体中文" && to == "zh")
                        {
                            textBox1.Text = ChineseConverter.ToSimplified(richTextBox1.Text);
                            toolStripStatusLabel1.Text = "翻译成功";

                        }
                    }
                    else
                    {
                        //domain
                        string domain = comboBox3.Text;
                        // 改成您的密钥
                        string url = "http://api.fanyi.baidu.com/api/trans/vip/fieldtranslate?";
                        string sign = EncryptString(appId + q + salt + domain + secretKey);
                        url += "q=" + HttpUtility.UrlEncode(q);
                        url += "&from=" + from;
                        url += "&to=" + to;
                        url += "&appid=" + appId;
                        url += "&salt=" + salt;
                        url += "&domain=" + domain;
                        url += "&sign=" + sign;
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "GET";
                        request.ContentType = "text/html;charset=UTF-8";
                        request.UserAgent = null;
                        request.Timeout = 6000;
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
                            toolStripStatusLabel1.Text = "翻译成功";
                        }
                        else
                        {
                            textBox1.AppendText(res.Error_msg);
                            toolStripStatusLabel1.Text = "出现错误";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("领域不能为空");
                }

            }
                Focus();
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
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(0));
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
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
                string autosave = IniManager.getString("Set", "AutoSave", "", Set.INIpath);
                if (autosave == "True")
                {
                    string filesavepath = IniManager.getString("Set", "FileSavePath", "", Set.INIpath);
                    if (filesavepath != "")
                    {
                        StreamWriter sw = new StreamWriter(filesavepath + "\\" + Guid.NewGuid().ToString() + ".txt");
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(textBox1.Text);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "朗读中";
            SpeechSynthesizer voice = new SpeechSynthesizer
            {
                Rate = trackBar2.Value - 5,
                Volume = trackBar1.Value * 10 //设置音量,[0,100]
            };   //创建语音实例
            voice.SpeakAsync(textBox1.Text);
            //播放指定的字符串,这是异步朗读
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
                toolStripStatusLabel1.Text = "保存成功";
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int txtlength = richTextBox1.Text.Length;
            if (txtlength < 2000)
            {
                toolStripStatusLabel3.Text = txtlength.ToString();
                toolStripStatusLabel3.ForeColor = Color.FromArgb(0, 0, 0);
                toolStripStatusLabel1.Text = "就绪";
            }
            else
            {
                toolStripStatusLabel3.Text = txtlength.ToString();
                toolStripStatusLabel3.ForeColor = Color.FromArgb(255, 0, 0);
                toolStripStatusLabel1.Text = "超过2000字，可能影响翻译质量";
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("翻译领域.rtf");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("翻译语言.rtf");
    }
}
