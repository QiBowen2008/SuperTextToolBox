using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Text;

namespace SuperFreeApi.XinHuaDictionary
{
    public class Dictionary
    {
        public static Result GetCharacterinformation(string character)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://v.api.aa1.cn/api/api-zi/index.php?msg=" + character);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(unprocessresult);
            return result;
        }
        public static string GetCharacteryj(string character)
        {
            string tmp= GetCharacterinformation(character).yj;
            return tmp.Substring(0, tmp.Length - 7);
        }
        public static string GetCharacterbs(string character)
        {
            return GetCharacterinformation(character).bs;
        }
        public static string GetCharacterbsbh(string character)
        {
            return GetCharacterinformation(character).bsbh;
        }
        public static string GetCharacterbwbh(string character)
        {
            return GetCharacterinformation(character).bwbh;
        }
        /// <summary>
        /// 其中1为横或提，2为竖或竖弯钩，3为撇，4为捺或点，5为折或竖提
        /// </summary>
        public static string GetCharacterbsxf(string character)
        {
            return GetCharacterinformation(character).bsxf;
        }
        public static string GetCharacterzsbh(string characetr)
        {
            return GetCharacterinformation(characetr).zsbh;
        }
        public class Result
        {
            /// <summary>
            /// 1：查询成功，0：查询失败
            /// </summary>
            public string code { get; set; }
            /// <summary>
            /// 查询的字
            /// </summary>
            public string cx { get; set; }
            /// <summary>
            /// 音节
            /// </summary>
            public string yj { get; set; }
            /// <summary>
            /// 部首
            /// </summary>
            public string bs { get; set; }
            /// <summary>
            /// 部首笔画
            /// </summary>
            public string bsbh { get; set; }
            /// <summary>
            /// 部外笔画
            /// </summary>
            public string bwbh { get; set; }
            /// <summary>
            /// 笔画总数
            /// </summary>
            public string zsbh { get; set; }
            /// <summary>
            /// 笔顺写法
            /// </summary>
            public string bsxf { get; set; }
        }

    }
}
