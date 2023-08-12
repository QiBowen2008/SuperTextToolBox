using System.Net;
using Newtonsoft.Json;
using System.Text;
using System;
using System.IO;

namespace SuperFreeApi.WeatherReporter
{
    public static  class WeatherReporter
    {
        public static Result GetWeatherinformation(string city)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.axtn.net/api/weather?name=" + city);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(unprocessresult);
            return result;
        }
        public static string GetProvince(string city)
        {
            return GetWeatherinformation(city).province;
        }
        public static string GetTemperature(string city)
        {
            return GetWeatherinformation(city).temperature;
        }
        public static string GetWeather(string city)
        {
            return GetWeatherinformation(city).weather;
        }
        public static string GetWindDirection(string city)
        {
            return GetWeatherinformation(city).wind_direction;
        }
        public static string GetWindPower(string city)
        {
            return GetWeatherinformation(city).wind_power;
        }
        public static string GetHumidity(string city)
        {
            return GetWeatherinformation(city).humidity;
        }
        public static string GetReporttime(string city)
        {
            return GetWeatherinformation(city).reporttime.ToString ();
        }
    }
    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 北京
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 北京市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string temperature { get; set; }
        /// <summary>
        /// 晴
        /// </summary>
        public string weather { get; set; }
        /// <summary>
        /// 东北
        /// </summary>
        public string wind_direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wind_power { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string humidity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime reporttime { get; set; }
    }

}
