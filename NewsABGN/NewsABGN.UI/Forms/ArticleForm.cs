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

namespace NewsABGN.UI.Forms
{
    public partial class ArticleForm : Form
    {
        private string _link;
        public ArticleForm(string link)
        {
            InitializeComponent();
            _link = link;
        }

        private void FillMainContent(string link)
        {
            var engine = Python.CreateEngine();
            var folderPath = engine.GetSearchPaths();
            folderPath = "";
        }
    }
}
