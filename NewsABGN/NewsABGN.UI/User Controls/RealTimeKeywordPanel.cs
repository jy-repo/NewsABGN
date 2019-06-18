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
    public partial class RealTimeKeywordPanel : UserControl
    {
        public RealTimeKeywordPanel()
        {
            InitializeComponent();
        }

        private List<string> _keywords = new List<string>();
        private int page = 1;
        public void FillKeywords()
        {
            _keywords = LogicRepository.Controller.Crawler.GetRealTimeKeywordList();
            Paging(page);
            lblLastUpdateTime.Text = "마지막 업데이트 시각: " + DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Paging(int page)
        {
            lblKeywordA.Text = "1   " + _keywords.ElementAt((page - 1) * 5);
            lblKeywordB.Text = "2   " + _keywords.ElementAt((page - 1) * 5 + 1);
            lblKeywordC.Text = "3  " + _keywords.ElementAt((page - 1) * 5 + 2);
            lblKeywordD.Text = "4  " + _keywords.ElementAt((page - 1) * 5 + 3);
            lblKeywordE.Text = "5   " + _keywords.ElementAt((page - 1) * 5 + 4);
        }
        
        private void ToNextPage()
        {
            Paging((page + 1) % 4);
        }

        private void ToPrevPage()
        {
            Paging((page - 1) % 4);
        }

        private void Refresh_Clicked(object sender, EventArgs e)
        {
            FillKeywords();
        }
    }
}
