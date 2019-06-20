using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    partial class Keyword : Entity
    {
        public override string ToText()
        {
            return PushName;
        }
    }
}
