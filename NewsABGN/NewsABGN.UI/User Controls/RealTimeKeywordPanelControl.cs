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
            FillLabelLists();
        }

        private List<Label> _numberLabels = new List<Label>();
        private List<Label> _keywordLabels = new List<Label>();
        private List<string> _keywords = new List<string>();
        private int page = 0;
        private int _selectedLabelPage;
        private Label _selectedLabel;

        private void FillLabelLists()
        {
            _numberLabels.Add(lblKeywordNumberA);
            _numberLabels.Add(lblKeywordNumberB);
            _numberLabels.Add(lblKeywordNumberC);
            _numberLabels.Add(lblKeywordNumberD);
            _numberLabels.Add(lblKeywordNumberE);

            _keywordLabels.Add(lblKeywordA);
            _keywordLabels.Add(lblKeywordB);
            _keywordLabels.Add(lblKeywordC);
            _keywordLabels.Add(lblKeywordD);
            _keywordLabels.Add(lblKeywordE);
        }


        public void FillKeywords()
        {
            _keywords = LogicRepository.Controller.WebCrawlbot.GetRealTimeKeywordList();
            Paging(page);
            lblLastUpdateTime.Text = "마지막 업데이트 시각: " + DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Paging(int page)
        {
            int p = page * 5;
            for (int i=0; i < _numberLabels.Count; i++)
            {
                _numberLabels.ElementAt(i).Text = (p + 1 + i) + "";
                _keywordLabels.ElementAt(i).Text = _keywords.ElementAt(p + i);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            page = 0;
            _selectedLabel = null;
            HightlightSelected(_selectedLabelPage, _selectedLabel);

            FillKeywords();
        }

        private void LblPrev_Click(object sender, EventArgs e)
        {
            page = (page + 3) % 4;
            Paging(page);
            HightlightSelected(_selectedLabelPage, _selectedLabel);
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            page = (page + 1) % 4;
            Paging(page);
            HightlightSelected(_selectedLabelPage, _selectedLabel);
        }

        private void Keyword_Click(object sender, EventArgs e)
        {
            _selectedLabel = (Label)sender;
            _selectedLabelPage = page;

            HightlightSelected(_selectedLabelPage, _selectedLabel);

            OnKeywordClicked(_selectedLabel.Text);
        }
        
        public void HightlightSelected(int selectedPage, Label selectedLabel)
        {
            foreach(var label in _keywordLabels)
            {
                if (page == selectedPage && label == selectedLabel)
                    label.Font = new Font(label.Font, FontStyle.Bold);
                else
                    label.Font = new Font(label.Font, FontStyle.Regular);
            }
            if (selectedLabel == null)
                _selectedLabel = null;
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
