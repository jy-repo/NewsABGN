using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NewsABGN.Logic
{
    public class APIbot
    {
        // search variables
        private const int displayNumber = 10;
        private const int startNumber = 1;
        private const string sortSytle = "sim";

        // NAVER API access info
        private const string clientID = "mEXVI6WRB13hrHJiHT0H";
        private const string clientSecret = "giZbMHsY14";

        public List<Dictionary<string, string>> Search(string keyword)
        {
            List<Dictionary<string, string>> contentsList = new List<Dictionary<string, string>>();

            //////// NAVER API

            //build query string
            string query = keyword;
            string url = "https://openapi.naver.com/v1/search/news.json?query=" + query +
            $"&display = {displayNumber} & start = {startNumber} & sort = {sortSytle}";

            // get response with NAVER API ID/Secret
            HttpWebResponse response = GetResponse(url);
            string status = response.StatusCode.ToString();

            if (status == "OK")     // get json success
                contentsList = FillContentsList(response);
            else {
                // API error
            }

            return contentsList;
        }

        private HttpWebResponse GetResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", clientID);               // 클라이언트 아이디
            request.Headers.Add("X-Naver-Client-Secret", clientSecret);       // 클라이언트 시크릿
            return (HttpWebResponse)request.GetResponse();
        }

        private List<Dictionary<string, string>> FillContentsList(HttpWebResponse response)
        {
            var contentsList = new List<Dictionary<string, string>>();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string jsonText = reader.ReadToEnd();

            JObject jObject = JObject.Parse(jsonText);
            JArray jArray = JArray.Parse(jObject["items"].ToString());


            foreach (var item in jArray)
            {
                var newsContents = new Dictionary<string, string>();

                newsContents.Add("pubDate", item["pubDate"].ToString());
                newsContents.Add("title", item["title"].ToString());
                newsContents.Add("description", item["description"].ToString());
                newsContents.Add("link", item["link"].ToString());
                newsContents.Add("originalLink", item["originallink"].ToString());

                contentsList.Add(newsContents);
            }

            return contentsList;
        }
    }
}
