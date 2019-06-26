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
        // Keywords
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
        // Scraps
        public List<Scrap> GetScraps(int memberId)
        {              
            return DataRepository.Scrap.GetByMemberId(memberId);
        }

        public void AddScrap(int memberId, Dictionary<string,string> news)
        {
            DataRepository.Scrap.InsertByMemberId(memberId, news);
        }

        public void DeleteScrap(int memberId, string link)
        {
            DataRepository.Scrap.DeleteScrap(memberId, link);
        }
        // Members
        public Dictionary<string, string> TryLogin(string id, string pw)
        {
            // DB멤버 가져오기
            var member = DataRepository.Member.GetMember(id, pw);
            
            // 멤버 있는지 체크
            if (member == null)
                return null;

            Dictionary<string, string> info = new Dictionary<string, string>();

            info.Add("id", member.MemberId.ToString());
            info.Add("name", member.Name);

            return info;

        }
    }
}
