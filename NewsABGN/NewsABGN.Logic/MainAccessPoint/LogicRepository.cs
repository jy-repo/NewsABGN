using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            Crawler = new Crawler();
        }

        public Searcher Searcher { get; }
        public Crawler Crawler { get; }
    }
}
