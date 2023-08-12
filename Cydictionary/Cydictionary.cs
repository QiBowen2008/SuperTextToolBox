using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace  SuperFreeApi.CyDictionary
{
    public static class Dictionary
    {
        public static Result GetCyinformation(string Cy)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://v.api.aa1.cn/api/api-chengyu/index.php?msg=" + Cy);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(unprocessresult);
            return result;
        }
        public class Result
        {
            /// <summary>
            /// 查询的成语
            /// </summary>
            public string cycx { get; set; }
            /// <summary>
            /// 成语解释
            /// </summary>
            public string cyjs { get; set; }
            /// <summary>
            /// 成语出处
            /// </summary>
            public string cycc { get; set; }
            /// <summary>
            /// 成语造句
            /// </summary>
            public string cyzj { get; set; }
            /// <summary>
            /// 成语辨析
            /// </summary>
            public string cybx { get; set; }
            /// <summary>
            /// 成语使用
            /// </summary>
            public string cysy { get; set; }
            /// <summary>
            /// 0：查询失败，1：查询成功
            /// </summary>
            public string code { get; set; }
            /// <summary>
            /// 查询失败返回内容
            /// </summary>
            public string error { get; set; }
        }
        public static string GetCycx(string Cy)
        {
            return GetCyinformation(Cy).cycx;
        }
        public static string Getcycc(string Cy)
        {
            return GetCyinformation(Cy).cycc;
        }
        public static string Getcyzj(string Cy)
        {
            return GetCyinformation(Cy).cyzj;
        }
        public static string Getcybx(string Cy)
        {
            return GetCyinformation(Cy).cybx;
        }
        public static string Getcyjs(string Cy)
        {
            return GetCyinformation(Cy).cyjs;
        }
        public static string Getcysy(string Cy)
        {
            return GetCyinformation(Cy).cysy;
        }

    }
}
