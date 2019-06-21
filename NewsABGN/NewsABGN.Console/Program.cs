using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsABGN.Logic;

namespace NewsABGN.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            var title = LogicRepository.Controller.WebCrawlbot.GetArticleContents("http://news.g-enews.com/view.php?ud=2019061000011141379ecba8d8b8_1&md=20190610000338_K").FirstOrDefault().Value;
        }
    }
}
