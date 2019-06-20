using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsABGN.DB;

namespace NewsABGN.UI.User_Controls
{
    public partial class ScrapControl : UserControl
    {
        string _link;
        public ScrapControl()
        {
            InitializeComponent();
        }

        public ScrapControl(Scrap scrap) : this()
        {
            // scrap
            _link = scrap.Link;
            lblTitle.Text = FitWidth(scrap.Title);
            lblPubDate.Text = scrap.PubDate.ToString();
        }

        private void ScrapControl_DoubleClick(object sender, EventArgs e)
        {
            OnScrapDoubleClicked(_link);
        }
        private int lineLengthTitle = 15;
        private string FitWidth(string str)
        {
            str = str.Replace("<b>", "");
            str = str.Replace("</b>", "");
            str = str.Replace("&quot;", "");
            str = str.Replace("&amp;", "");

            string result = "";
            int i = 1;
            foreach (var letter in str)
            {
                if (i == lineLengthTitle * 2 - 3)
                {
                    result += "...";
                    i++;
                    break;
                }
                result += letter;
                if (i % lineLengthTitle == 0)
                    result += "\r\n";
                i++;
            }
            return result;
        }


        private void LblDelete_Click(object sender, EventArgs e)
        {
            OnDeleteScrapclicked(_link);
        }

        #region ScrapDoubleClicked event things for C# 3.0
        public event EventHandler<ScrapDoubleClickedEventArgs> ScrapDoubleClicked;

        protected virtual void OnScrapDoubleClicked(ScrapDoubleClickedEventArgs e)
        {
            if (ScrapDoubleClicked != null)
                ScrapDoubleClicked(this, e);
        }

        private ScrapDoubleClickedEventArgs OnScrapDoubleClicked(string url)
        {
            ScrapDoubleClickedEventArgs args = new ScrapDoubleClickedEventArgs(url);
            OnScrapDoubleClicked(args);

            return args;
        }

        private ScrapDoubleClickedEventArgs OnScrapDoubleClickedForOut()
        {
            ScrapDoubleClickedEventArgs args = new ScrapDoubleClickedEventArgs();
            OnScrapDoubleClicked(args);

            return args;
        }

        public class ScrapDoubleClickedEventArgs : EventArgs
        {
            public string Url { get; set; }

            public ScrapDoubleClickedEventArgs()
            {
            }

            public ScrapDoubleClickedEventArgs(string url)
            {
                Url = url;
            }
        }
        #endregion

        #region DeleteScrapclicked event things for C# 3.0
        public event EventHandler<DeleteScrapclickedEventArgs> DeleteScrapclicked;

        protected virtual void OnDeleteScrapclicked(DeleteScrapclickedEventArgs e)
        {
            if (DeleteScrapclicked != null)
                DeleteScrapclicked(this, e);
        }

        private DeleteScrapclickedEventArgs OnDeleteScrapclicked(string link)
        {
            DeleteScrapclickedEventArgs args = new DeleteScrapclickedEventArgs(link);
            OnDeleteScrapclicked(args);

            return args;
        }

        private DeleteScrapclickedEventArgs OnDeleteScrapclickedForOut()
        {
            DeleteScrapclickedEventArgs args = new DeleteScrapclickedEventArgs();
            OnDeleteScrapclicked(args);

            return args;
        }

        public class DeleteScrapclickedEventArgs : EventArgs
        {
            public string Link { get; set; }

            public DeleteScrapclickedEventArgs()
            {
            }

            public DeleteScrapclickedEventArgs(string link)
            {
                Link = link;
            }
        }
        #endregion
    }
}
