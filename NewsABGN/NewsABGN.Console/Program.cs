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
            var words = LogicRepository.Controller.WordCloud.MakeWordCloud("일동제약");

            var wordListTmp = words.Trim().Substring(1, words.Length - 4).Replace("(", "").Replace("), ", "|").Replace(")", "").Split('|');

            foreach (var word in wordListTmp.Reverse())
            {
                var NewWord = word.Replace(", ", "|").Split('|');

                System.Console.WriteLine($"{NewWord[0],20}" + " ---- " + $"{NewWord[1],5}");
                
            }
        }
    }
}
