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

        private void AddScrollEvent()
        {
            flpResultPanel
        }

        private void ScrollableControl1_Scroll(Object sender, ScrollEventArgs e)
        {

            StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ScrollOrientation", e.ScrollOrientation);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Type", e.Type);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "NewValue", e.NewValue);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "OldValue", e.OldValue);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Scroll Event");
        }
    }
}
