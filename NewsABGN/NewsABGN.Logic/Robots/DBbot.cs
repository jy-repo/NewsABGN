using NewsABGN.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.Logic
{
    public class DBbot
    {
        public List<Scrap> GetScraps(int memberId)
        {
            return DataRepository.Scrap.GetByMemberId(memberId);
        }

        public List<Keyword> GetKeywords(int memberId)
        {
            return DataRepository.Keyword.GetByMemberId(memberId);
        }

        public void AddKeyword(int memberId, string str)
        {
            DataRepository.Keyword.InsertKeyword(memberId, str);

        }

        public void DeleteKeyword(int memberId, string str)
        {
            DataRepository.Keyword.DeleteKeyword(memberId, str);
        }

        public void AddScrap(int memberId, Dictionary<string,string> news)
        {
            DataRepository.Scrap.InsertByMemberId(memberId, news);
        }

        public void DeleteScrap(int memberId, string link)
        {
            DataRepository.Scrap.DeleteScrap(memberId, link);
        }
    }
}
