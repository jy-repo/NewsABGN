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
            Scrapper = new Scrapper();
        }

        public Searcher Searcher { get; }
        public Crawler Crawler { get; }
        public Scrapper Scrapper { get; }
    }
}
