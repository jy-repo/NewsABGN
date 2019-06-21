using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

using IronPython;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython.Modules;

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

        public Dictionary<string, string> GetArticleContents(string url)
        {
            Dictionary<string, string> contents = new Dictionary<string, string>();

            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();

            try
            {
                var pythonSource = engine.CreateScriptSourceFromFile(@"../../../NewsABGN.Logic/Python/Article.py");
                // var pythonSource = engine.CreateScriptSourceFromFile("Article.py");
                pythonSource.Execute(scope);

                //contents.Add("success", "success");
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine("failed");
                Console.WriteLine(ex.Message);
                //contents.Add("failed", "failed");
            }

            return contents;

        }
       
    }
}
