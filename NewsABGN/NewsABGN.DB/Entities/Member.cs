using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.DB
{
    partial class Member : Entity
    {
        public override string ToText()
        {
            return Name;
        }
    }
}
