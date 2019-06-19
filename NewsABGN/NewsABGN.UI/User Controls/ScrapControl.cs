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
        string _url;
        public ScrapControl()
        {
            InitializeComponent();
        }

        public ScrapControl(Scrap scrap) : this()
        {
            // scrap
            _url = scrap.Link;
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

        private void ScrapControl_DoubleClick(object sender, EventArgs e)
        {
            OnScrapDoubleClicked(_url);
        }
    }
}
