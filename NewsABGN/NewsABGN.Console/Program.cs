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
            var list = LogicRepository.Controller.Crawler.GetRealTimeKeywordList();

            foreach(var w in list)
                System.Console.WriteLine(w);
        }
    }
}
