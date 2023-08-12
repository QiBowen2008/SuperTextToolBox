using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace SuperFreeApi.SensitiveWordetection
{
    public class Detection
    {
        internal static Result GetWordinformation(string word)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://v.api.aa1.cn/api/api-mgc/index.php?msg=" + word);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(unprocessresult);
            return result;
        }
        internal class Result
        {
            /// <summary>
            /// 状态码
            /// </summary>
            public string code { get; set; }

            /// <summary>
            /// 1：为检测到敏感词，0或者其他：未检测到敏感词
            /// </summary>
            public string num { get; set; }

            /// <summary>
            /// 暂无敏感词 / 存在敏感词
            /// </summary>
            public string desc { get; set; }
            public string ci { get; set; }

        }
        public static string CheckText(string Text)
        {try
            {
                return GetWordinformation(Text).desc;
            }
            catch
            {
                return "无敏感词";
            }
        }
        public static string GetSensitiveWord(string Text)
        {
            try
            {
                return GetWordinformation(Text).ci;
            }
            catch
            {
                return "无敏感词";
            }
        }

    }
}
