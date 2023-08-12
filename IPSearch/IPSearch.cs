using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Text;

namespace SuperFreeApi.IPSearch
{
    public static class IPSearch
    {
        public static Result GetIPinformation(string ip)
        {

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.axtn.net/api/ipinfo?ip=" + ip);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(unprocessresult);
            return result;

        }
        
        public static string GetIPcountry(string ip)
        {
            return GetIPinformation(ip).country;
        }
        public static string GetIPregion(string ip)
        {
            return GetIPinformation(ip).region;
        }
        public static string GetIPcity(string ip)
        {
            return GetIPinformation(ip).city;
        }
        public static string GetIPasn(string ip)
        {
            return GetIPinformation(ip).asn;
        }
        public static string GetIPlatitude(string ip)
        {
            return GetIPinformation(ip).latitude;
        }
        public static string GetIPlongitude(string ip)
        {
            return GetIPinformation(ip).longitude;

        }
        public static string GetIPLLC(string ip)
        {
            return GetIPinformation(ip).LLC;
        }
        public static string GetIPmsg(string ip)
        {
            return GetIPinformation(ip).msg;
        }
    }
    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 河南省
        /// </summary>
        public string region { get; set; }
        /// <summary>
        /// 郑州市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string asn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LLC { get; set; }
        public string msg { get; set; }
    }

}
