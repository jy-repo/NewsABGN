using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    partial class Scrap : Entity
    {
        public string MemberName { get; internal set; }
        public int MemberId { get; internal set; }

        public override string ToText()
        {
            return Title;
        }
    }
}
