using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SuperWenZiToolBox
{
    public partial class frmLangrecognize :Sunny .UI .UIForm 
    {
        public frmLangrecognize()
        {
            InitializeComponent();
        }
        public class Data
        {
            public string src { get; set; }
        }
        private  void recongnize(object sender,EventArgs e)
        {
            // 原文
            string q = "apple";
            // 改成您的APP ID
            string appId = "20230101001515968";
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            // 改成您的密钥
            string secretKey = "4xaPms6ok7erM5n6MuuE";
            string sign = EncryptString(appId + q + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/language?";
            url += "q=" + HttpUtility.UrlEncode(q);
            url += "&appid=" + appId;
            url += "&salt=" + salt;
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
            Result res = JsonConvert.DeserializeObject<Result>(retString);
            if (res.error_code == 0)
            {
                label2.Text =res.data .src;
            }
            else
            {
                textBox1.AppendText(res.error_msg);
            }

        }
        // 计算MD5值
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
        public class Result
        {
            public int error_code { get; set; }
            public string error_msg { get; set; }
            public Data data { get; set; }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("翻译语言.rtf");
    }
}
