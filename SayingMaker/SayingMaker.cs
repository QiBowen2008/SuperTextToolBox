using System.IO;
using System.Net;
using System.Text;

namespace SayingMaker
{
    public static  class Maker
    {
        public static string GetSaying()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://v.api.aa1.cn/api/api-wenan-mingrenmingyan/index.php?aa1=text");
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            int length = unprocessresult.Length;
            string result = unprocessresult.Substring(3, length - 7);
            return result;
        }
    }
}
