
﻿using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;

namespace SuperFreeApi.Translate
{
    public static class Translator
    {
        /// <summary>
        /// 获取翻译的json结果
        /// </summary>
        /// <param name="word">翻译原文</param>
        /// <param name="lang">翻译类型（1代表中-英，2代表英-中，3代表中<=>英【自动检测翻译】）</param>
        /// <returns>返回json结果</returns>
        internal static Result GetTranslateJsonResult(string word,int lang)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://v.api.aa1.cn/api/api-fanyi-yd/index.php?msg="+word+"&type="+lang.ToString());
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
            /// 中英互译
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// 中文翻译英文
            /// </summary>
            public string desc { get; set; }
            public string text { get; set; }

        }

        /// <summary>
        /// 返回文本格式翻译结果
        /// </summary>
        /// <param name="word">原文</param>
        /// <param name="lang">翻译类型（1代表中-英，2代表英-中，3代表中<=>英【自动检测翻译】）</param>
        /// <returns></returns>
        public static string Translate(string word,int lang)
        {
            return GetTranslateJsonResult(word, lang).text;
        }
    }
}
