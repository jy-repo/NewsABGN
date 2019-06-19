using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    public class MemberData : EntityData<Member>
    {
        //로그인 체크 기능
        public Member GetMember(string idText, string pwText)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                return context.Members.FirstOrDefault(x => (x.Id == idText && x.Password == pwText));
            }
        }

        //getByPK
        public Member GetByPK(int memberId)
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                return context.Members.FirstOrDefault(x => x.MemberId == memberId);
            }
        }

        public Member GetLastMember()
        {
            using (ABGNDBEntities context = new ABGNDBEntities())
            {
                return context.Members.OrderByDescending(x => x.MemberId).First();
            }
        }
    }
}
