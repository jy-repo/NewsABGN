using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    public class DataRepository
    {
        static DataRepository()
        {
            Scrap = new ScrapData();
            Member = new MemberData();
            //Keyword = new KeywordData();
        }

        public static ScrapData Scrap { get; }
        public static MemberData Member { get; }
        //public static KeywordData Keyword { get; }
    }
}
