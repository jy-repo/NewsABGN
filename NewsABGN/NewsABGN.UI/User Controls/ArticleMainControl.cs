using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI.User_Controls
{
    public partial class ArticleMainControl : UserControl
    {
        private string _url;
        public ArticleMainControl()
        {
            InitializeComponent();
        }
        public ArticleMainControl(string url) : this()
        {
            _url = url;
        }

        public void FillTitle(string title)
        {
            lblTItle.Text = title;
        }

        public void FillContent(string content)
        {
            txbBody.Text = content;
        }

        private void Open_original_web(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnLinkClicked();
        }
        public void Open_url(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        #region LinkClicked event things for C# 3.0
        public event EventHandler<LinkClickedEventArgs> LinkClicked;

        protected virtual void OnLinkClicked(LinkClickedEventArgs e)
        {
            if (LinkClicked != null)
                LinkClicked(this, e);
        }

        private LinkClickedEventArgs OnLinkClicked()
        {
            LinkClickedEventArgs args = new LinkClickedEventArgs();
            OnLinkClicked(args);

            return args;
        }

        /*private LinkClickedEventArgs OnLinkClickedForOut()
        {
            LinkClickedEventArgs args = new LinkClickedEventArgs();
            OnLinkClicked(args);

            return args;
        }*/

        public class LinkClickedEventArgs : EventArgs
        {


            /*public LinkClickedEventArgs()
            {
            }

            public LinkClickedEventArgs()
            {

            }*/
        }
        #endregion
    }
}
