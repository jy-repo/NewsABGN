using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using IronPython;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython.Modules;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System.Diagnostics;

namespace NewsABGN.UI
{
    public partial class ArticleForm : Form
    {
        private string _link;
        public ArticleForm(string link)
        {
            InitializeComponent();
            //FillMainContent(link);
            _link = link;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //FillMainContent(_link);
        }

        private void FillMainContent(string link)
        {
            var engine = Python.CreateEngine();
            var searchPaths = engine.GetSearchPaths();
            searchPaths.Add(@"..\..\..\python\venv\Lib\site-packages");
            //searchPaths.Add(@"..\..\..\python");

            engine.SetSearchPaths(searchPaths);

            ScriptSource script =
                engine.CreateScriptSourceFromFile(@"..\..\..\python\NewsCrawler.py");
            ScriptScope scope = engine.CreateScope();
            script.Execute(scope);

            dynamic w = scope.GetVariable("NC")();
            List<string> contents = w.get_news(link);
            lblMainContent.Text = contents.First();
            //lblMainContent.Text = contents.First();
        }
    }
}
