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
            return DataRepository.Scrap.GetByMemberId(memberid);
        }
    }
}
