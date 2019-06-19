using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI.User_Controls.Result
{
    public partial class ArticleListControl : UserControl
    {
        public ArticleListControl()
        {
            InitializeComponent();
        }

        public List<ArticleControl> FillResults(List<Dictionary<string,string>> newsList)
        {
            flpResultPanel.Controls.Clear();
            List<ArticleControl> results = new List<ArticleControl>();

            foreach(var news in newsList)
            {
                ArticleControl nr = new ArticleControl(news);
                results.Add(nr);
                flpResultPanel.Controls.Add(nr);
            }

            return results;
        }
    }
}
