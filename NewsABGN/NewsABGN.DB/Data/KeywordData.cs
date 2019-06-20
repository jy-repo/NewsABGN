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
                    .ToList();
            }
        }
    }
}
