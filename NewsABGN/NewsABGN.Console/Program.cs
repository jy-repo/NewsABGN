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
            var title = LogicRepository.Controller.WordCloud.MakeWordCloud("백종원");

            System.Console.WriteLine(title[0]);
        }
    }
}
