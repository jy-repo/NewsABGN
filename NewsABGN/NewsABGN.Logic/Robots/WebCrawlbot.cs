using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.Logic
{
    public class WebCrawlbot
    {
        public List<string> GetRealTimeKeywordList()
        {
            List<string> realTimeKeywordList = new List<string>();

            var webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            string html = webClient.DownloadString("https://www.naver.com");
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            var rtKeywordNodes = 
                doc.DocumentNode.SelectNodes("//div[contains(@class, 'ah_l')]").FirstOrDefault().Descendants("span").Where(x => x.Attributes["class"].Value.Contains("ah_k"));

            foreach (var RTKnodes in rtKeywordNodes)
                realTimeKeywordList.Add(RTKnodes.InnerHtml);

            return realTimeKeywordList;
        }
       
    }
}
