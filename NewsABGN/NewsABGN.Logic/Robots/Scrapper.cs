using NewsABGN.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.Logic
{
    public class Scrapper
    {
        // return type to be changed to List<Scrap>
        //public List<NewsABGN.d Scrap> GetScraps(int memberId)
        ////{
        ////    return .GetByMemberId(memberId);
        //}


        public List<Scrap> GetScraps(int memberid)
        {
            if (memberid == 0)  // test
            {
                List<Scrap> testList = new List<Scrap>();

                for (int i = 0; i < 99; i++)
                {
                    Scrap scrap = new Scrap();
                    testList.Add(scrap);
                }

                return testList;    
            }

            return DataRepository.Scrap.GetByMemberId(memberid);
        }
    }
}
