using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    public class ScrapData : EntityData<Scrap>
    {
        //한 회원이 스크랩한 기사들의 목록
        public List<Scrap> GetByMemberId(int memberId)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                var query = (from scrap in context.Scraps
                             from member in scrap.Members
                             select new
                             {
                                 Scrap = scrap,
                                 MemberName = member.Name,
                                 MemberId = member.MemberId
                             }).Where(x => x.MemberId == memberId);

                var list = query.ToList();
                foreach (var item in list)
                {
                    item.Scrap.MemberName = item.MemberName;
                }

                return list.ConvertAll(x => x.Scrap);
            }

        }
    }
}
