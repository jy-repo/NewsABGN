using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsABGN.Logic;

namespace NewsABGN.UI.User_Controls
{
    public partial class RealTimeKeywordPanelControl : UserControl
    {
        public RealTimeKeywordPanelControl()
        {
            InitializeComponent();
        }

        private List<string> _keywords = new List<string>();
        private int page = 0;
        public void FillKeywords()
        {
            _keywords = LogicRepository.Controller.Crawler.GetRealTimeKeywordList();
            Paging(page);
            lblLastUpdateTime.Text = "마지막 업데이트 시각: " + DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Paging(int page)
        {
            int p = page * 5;
            lblKeywordA.Text = _keywords.ElementAt(p);
            lblKeywordB.Text = _keywords.ElementAt(p + 1);
            lblKeywordC.Text = _keywords.ElementAt(p + 2);
            lblKeywordD.Text = _keywords.ElementAt(p + 3);
            lblKeywordE.Text = _keywords.ElementAt(p + 4);

            lblKeywordNumberA.Text = p + 1 + "";
            lblKeywordNumberB.Text = p + 2 + "";
            lblKeywordNumberC.Text = p + 3 + "";
            lblKeywordNumberD.Text = p + 4 + "";
            lblKeywordNumberE.Text = p + 5 + "";

        }

        private void Refresh_Clicked(object sender, EventArgs e)
        {
            page = 0;
            FillKeywords();
        }

        private void LblPrev_Click(object sender, EventArgs e)
        {
            Paging((page + 3) % 4);
            page--;
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            Paging((page + 1) % 4);
            page++;
        }

        private void Keyword_Click(object sender, EventArgs e)
        {
            var keywordLabel = (Label)sender;
            OnKeywordClicked(keywordLabel.Text);
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

    }
}
