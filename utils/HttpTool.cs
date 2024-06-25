using System;
using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApp1.utils
{
    public static class HttpTool
    {

        public static string token { set; get; }

        static string BASE_URL = "https://hero.hithium.com:8001/iot-api";
        public static T doPost<T>(string path, string postData) where T : class
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(BASE_URL + path);
            req.Method = "POST";
            req.ContentType = "application/json";
            req.Headers.Add("Authorization", token);
            byte[] data = Encoding.UTF8.GetBytes(postData);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            if (null == result)
            {
                return null;
            }
            Console.WriteLine("path:{0} resStr:{1}", path, result);
            return JsonTool.fromJson<T>(result);
        }

    }
}
