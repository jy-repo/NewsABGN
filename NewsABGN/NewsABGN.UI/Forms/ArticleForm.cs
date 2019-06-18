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
    }
}
