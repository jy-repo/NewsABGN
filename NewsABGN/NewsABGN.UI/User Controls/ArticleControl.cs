using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using NewsABGN.Logic;

namespace NewsABGN.UI.User_Controls.Result
{
    public partial class ArticleControl : UserControl
    {
        private const int lineLengthTitle = 36;
        private const int lineLengthContent = 55;

        private Dictionary<string, string> _news = new Dictionary<string, string>();

        public ArticleControl()
        {
            InitializeComponent();
        }

        public ArticleControl(Dictionary<string, string> news) : this()
        {
            _news = news;
            lblTitle.Text = FitWidth(news["title"], "title");
            lblContents.Text =
                FitWidth(news["pubDate"], "content") + 
                "\r\n\r\n" +
                FitWidth(news["description"], "content");
        }

        private string FitWidth(string str, string type)
        {
            string result = "";
            int i = 1;

            str = str.Replace("<b>", "");
            str = str.Replace("</b>", "");
            str = str.Replace("&quot;", "");


            foreach (var letter in str)
            {
                if (i == lineLengthTitle * 2 - 3 && type == "title")
                {
                    result += "...";
                    i++;
                    break;
                }
                if (i == lineLengthContent * 2 - 3 && type == "content")
                {
                    result += "...";
                    i++;
                    break; ;
                }
                result += letter;
                if (type == "title" && i % lineLengthTitle == 0)
                    result += "\r\n";
                if (type == "content" && i % lineLengthContent == 0)
                    result += "\r\n";
                i++;
               
            }

            return result;
        }

        private void Result_DoubleClick(object sender, EventArgs e)
        {
            OnResultDoubleClicked(_news["link"]);
        }

        private void LblTitle_MouseHover(object sender, EventArgs e)
        {
            lblTitle.ForeColor = Color.Blue;
        }

        private void LblTitle_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.ForeColor = Color.Black;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OnScrapCatClicked(_news);
        }

        #region ResultDoubleClicked event things for C# 3.0
        public event EventHandler<ResultDoubleClickedEventArgs> ResultDoubleClicked;

        protected virtual void OnResultDoubleClicked(ResultDoubleClickedEventArgs e)
        {
            if (ResultDoubleClicked != null)
                ResultDoubleClicked(this, e);
        }

        private ResultDoubleClickedEventArgs OnResultDoubleClicked(string url)
        {
            ResultDoubleClickedEventArgs args = new ResultDoubleClickedEventArgs(url);
            OnResultDoubleClicked(args);

            return args;
        }

        private ResultDoubleClickedEventArgs OnResultDoubleClickedForOut()
        {
            ResultDoubleClickedEventArgs args = new ResultDoubleClickedEventArgs();
            OnResultDoubleClicked(args);

            return args;
        }

        public class ResultDoubleClickedEventArgs : EventArgs
        {
            public string Url { get; set; }

            public ResultDoubleClickedEventArgs()
            {
            }

            public ResultDoubleClickedEventArgs(string url)
            {
                Url = url;
            }
        }
        #endregion

        #region ScrapCatClicked event things for C# 3.0
        public event EventHandler<ScrapCatClickedEventArgs> ScrapCatClicked;

        protected virtual void OnScrapCatClicked(ScrapCatClickedEventArgs e)
        {
            if (ScrapCatClicked != null)
                ScrapCatClicked(this, e);
        }

        private ScrapCatClickedEventArgs OnScrapCatClicked(Dictionary<string, string> news)
        {
            ScrapCatClickedEventArgs args = new ScrapCatClickedEventArgs(news);
            OnScrapCatClicked(args);

            return args;
        }

        private ScrapCatClickedEventArgs OnScrapCatClickedForOut()
        {
            ScrapCatClickedEventArgs args = new ScrapCatClickedEventArgs();
            OnScrapCatClicked(args);

            return args;
        }

        public class ScrapCatClickedEventArgs : EventArgs
        {
            public Dictionary<string, string> News { get; set; }

            public ScrapCatClickedEventArgs()
            {
            }

            public ScrapCatClickedEventArgs(Dictionary<string, string> news)
            {
                News = news;
            }
        }
        #endregion
    }
}
