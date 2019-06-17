using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsABGN.Logic
{
    // singleton logicRepository : Controller
    public class LogicRepository
    {
        private static LogicRepository _controller = null;

        public static LogicRepository Controller
        {
            get
            {
                if (_controller == null)
                    _controller = new LogicRepository();
                return _controller;
            }
        }

        private LogicRepository()
        {
            Searcher = new Searcher();
        }

        public Searcher Searcher { get; }

    }
}
