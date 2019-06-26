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
    public partial class UserKeywordControl : UserControl
    {
        public UserKeywordControl()
        {
            InitializeComponent();
        }

        public UserKeywordControl(string keyword) : this()
        {
            lblUserKeyword.Text = keyword;
        }


        private void LblUserKeyword_Click(object sender, EventArgs e)
        {
            OnKeywordClicked(lblUserKeyword.Text);
        }
        
        #region KeywordClicked event things for C# 3.0
        public event EventHandler<KeywordClickedEventArgs> KeywordClicked;

        protected virtual void OnKeywordClicked(KeywordClickedEventArgs e)
        {
            if (KeywordClicked != null)
                KeywordClicked(this, e);
        }

        private KeywordClickedEventArgs OnKeywordClicked(string keyword)
        {
            KeywordClickedEventArgs args = new KeywordClickedEventArgs(keyword);
            OnKeywordClicked(args);

            return args;
        }

        private KeywordClickedEventArgs OnKeywordClickedForOut()
        {
            KeywordClickedEventArgs args = new KeywordClickedEventArgs();
            OnKeywordClicked(args);

            return args;
        }

        public class KeywordClickedEventArgs : EventArgs
        {
            public string Keyword { get; set; }

            public KeywordClickedEventArgs()
            {
            }

            public KeywordClickedEventArgs(string keyword)
            {
                Keyword = keyword;
            }
        }
        #endregion

        #region DeleteKeywordClicked event things for C# 3.0
        public event EventHandler<DeleteKeywordClickedEventArgs> DeleteKeywordClicked;

        protected virtual void OnDeleteKeywordClicked(DeleteKeywordClickedEventArgs e)
        {
            if (DeleteKeywordClicked != null)
                DeleteKeywordClicked(this, e);
        }

        private DeleteKeywordClickedEventArgs OnDeleteKeywordClicked(string keyword)
        {
            DeleteKeywordClickedEventArgs args = new DeleteKeywordClickedEventArgs(keyword);
            OnDeleteKeywordClicked(args);

            return args;
        }

        private DeleteKeywordClickedEventArgs OnDeleteKeywordClickedForOut()
        {
            DeleteKeywordClickedEventArgs args = new DeleteKeywordClickedEventArgs();
            OnDeleteKeywordClicked(args);

            return args;
        }

        public class DeleteKeywordClickedEventArgs : EventArgs
        {
            public string Keyword { get; set; }

            public DeleteKeywordClickedEventArgs()
            {
            }

            public DeleteKeywordClickedEventArgs(string keyword)
            {
                Keyword = keyword;
            }
        }
        #endregion

        private void LblRemoveKeyword_Click(object sender, EventArgs e)
        {
            OnDeleteKeywordClicked(lblUserKeyword.Text);
        }

        private void LblWordFrequency_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblUserKeyword.Text);
        }
    }
}
