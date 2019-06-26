using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    public class KeywordData : EntityData<Keyword>
    {
        public List<Keyword> GetByMemberId(int memberId)
        {
            using (var context = new ABGNDBEntities())
            {
                return context.Members
                    .Where(x => x.MemberId == memberId)
                    .FirstOrDefault()
                    .Keywords
                    .OrderByDescending(x => x.KeywordId)
                    .ToList();
            }
        }

        public void InsertKeyword(int memberId, string str)
        {
            using (var context = new ABGNDBEntities())
            {
                // keyword 유무 확인
                var keyword = context.Keywords.FirstOrDefault(x => x.PushName == str);

                // member 에 keyword 있는지 확인
                var member = context.Members.FirstOrDefault(x => x.MemberId == memberId);

                foreach (var kw in member.Keywords)
                    if (kw == keyword)
                        return;

                // keyword 테이블에 없을 시 새로 생성
                if (keyword == null)
                {
                    keyword = new Keyword();
                    keyword.PushDate = DateTime.Now;
                    keyword.PushName = str;
                }

                // 매핑 테이블에 추가
                member.Keywords.Add(keyword);
                context.SaveChanges();
            }
        }

        public void DeleteKeyword(int memberId, string str)
        {
            using (var context = new ABGNDBEntities())
            {
                var keyword = context.Keywords.FirstOrDefault(x => x.PushName == str);

                context.Members.FirstOrDefault(x => x.MemberId == memberId).Keywords.Remove(keyword);
                context.SaveChanges();
            }
        }
    }
}
