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
                             }).Where(x => x.MemberId == memberId)
                             .OrderByDescending(x => x.Scrap.ScrapId);

                var list = query.ToList();
                foreach (var item in list)
                {
                    item.Scrap.MemberName = item.MemberName;
                }

                return list.ConvertAll(x => x.Scrap);
            }
        }
        public void InsertByMemberId(int memberId, Dictionary<string, string> news)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                string link = news["link"];
                var scrap = context.Scraps.FirstOrDefault(x => x.Link == link);
                var LoginedUser = context.Members.FirstOrDefault(x => x.MemberId == memberId);

                foreach (var sc in LoginedUser.Scraps)
                    if (sc == scrap)
                        return;

                if (scrap == null)
                {
                    scrap = new Scrap();
                    scrap.PubDate = DateTime.Now;
                    scrap.Title = news["title"];
                    scrap.Description = news["description"];
                    scrap.Link = news["link"];
                    scrap.OriginalLink = news["originalLink"];
                }

                LoginedUser.Scraps.Add(scrap);
                context.SaveChanges();
            }
        }

        public void DeleteScrap(int memberId, string link)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                var scrap = context.Scraps.FirstOrDefault(x => x.Link == link);
                var member = context.Members.FirstOrDefault(x => x.MemberId == memberId);

                member.Scraps.Remove(scrap);
                context.SaveChanges();
            }
        }
    }
}
