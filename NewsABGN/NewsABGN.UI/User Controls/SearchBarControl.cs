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
    public partial class SearchBarControl : UserControl
    {
        public SearchBarControl()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txbKeyword.Text))
                OnSearchCatClicked(txbKeyword.Text);
        }

        #region SearchCatClicked event things for C# 3.0
        public event EventHandler<SearchCatClickedEventArgs> SearchCatClicked;

        protected virtual void OnSearchCatClicked(SearchCatClickedEventArgs e)
        {
            if (SearchCatClicked != null)
                SearchCatClicked(this, e);
        }

        private SearchCatClickedEventArgs OnSearchCatClicked(string keyword)
        {
            SearchCatClickedEventArgs args = new SearchCatClickedEventArgs(keyword);
            OnSearchCatClicked(args);

            return args;
        }

        private SearchCatClickedEventArgs OnSearchCatClickedForOut()
        {
            SearchCatClickedEventArgs args = new SearchCatClickedEventArgs();
            OnSearchCatClicked(args);

            return args;
        }

        public class SearchCatClickedEventArgs : EventArgs
        {
            public string Keyword { get; set; }

            public SearchCatClickedEventArgs()
            {
            }

            public SearchCatClickedEventArgs(string keyword)
            {
                Keyword = keyword;
            }
        }
        #endregion

        private void TxbKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!string.IsNullOrEmpty(txbKeyword.Text))
                    OnSearchCatClicked(txbKeyword.Text);
        }
    }
}
