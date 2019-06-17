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
    public partial class ResultPanel : UserControl
    {
        public ResultPanel()
        {
            InitializeComponent();
        }

        public List<NewsResult> FillResults(List<Dictionary<string,string>> newsList)
        {
            flpResultPanel.Controls.Clear();
            List<NewsResult> results = new List<NewsResult>();

            foreach(var news in newsList)
            {
                NewsResult nr = new NewsResult(news);
                results.Add(nr);
                flpResultPanel.Controls.Add(nr);
            }

            return results;
        }
    }
}
