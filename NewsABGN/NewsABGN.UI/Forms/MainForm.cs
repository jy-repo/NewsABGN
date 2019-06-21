using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsABGN.Logic;
using NewsABGN.UI.User_Controls;
using NewsABGN.UI.User_Controls.Result;

namespace NewsABGN.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            uscRealTimeKeywordPanelControl.FillKeywords();
        }


        #region window function: Exit / Drag / Resize
        private void UscTitleBar_ExitButtonClicked(object sender, User_Controls.TitleBar.TitleBarControl.ExitButtonClickedEventArgs e)
        {
            this.Close();
        }
        // drag & move

        private int _mouseOffsetX;
        private int _mouseOffsetY;
        private bool _mouseDown;

        private void UscTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseOffsetX = MousePosition.X - this.Left;
            _mouseOffsetY = MousePosition.Y - this.Top;
            _mouseDown = true;
        }

        private void UscTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
                this.SetDesktopLocation(MousePosition.X - _mouseOffsetX, MousePosition.Y - _mouseOffsetY);
        }

        private void UscTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
        
        // window resize
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region User login/logout
        private bool _loginState = false;
        private int _memberId;
        private string _memberName;
        // title bar '로그인' button clicked
        private void UscSignInPanel_BtnSignInClick(object sender, SignInPanel.BtnSignInClickEventArgs e)
        {
            if (!_loginState) // 로그인
                uscSignInControl.Visible = !uscSignInControl.Visible;
            else    // 로그아웃
                Toggle(_memberId, _memberName);
        }
        // popup '로그인' succeed
        private void UscSignInControl_BtnSignInClick(object sender, SignInControl.BtnSignInClickEventArgs e)
        {
            _memberId = e.Member.MemberId;
            _memberName = e.Member.Name;
            Toggle(_memberId, _memberName);
        }
        private void Toggle(int memberId, string name)
        {
            // close login control if open
            if(!_loginState)
                uscSignInControl.Visible = _loginState;

            // non signed-in contents
            lblLoginWarning.Visible = _loginState;

            // logged in state
            _loginState = !_loginState;

            // signed-in contents
            // title bar / keyword / scrap

            if (_loginState)  // 로그인
            {   
                uscSignInPanel.ShowMemberName(name);
                FillUserKeywords(memberId);
                foreach (var article in _newsResults)
                {
                    article.ToggleScrapButton();
                    article.Refresh();
                }
                FillUserScraps(memberId);
            }  // 로그 아웃
            else
            {
                uscSignInPanel.SignOut();
                uscUserKeywordPanelControl.EmptyKeywords();
                if (uscUserKeywordPanelControl.Visible)
                    SwapKeywordPanels();
                foreach (var article in _newsResults)
                {
                    article.ToggleScrapButton();
                    article.Refresh();
                }
                uscScrapListControl.EmptyScraps();
            }
            lblKeywordTItleAlt.Visible = _loginState;
            uscScrapListControl.Visible = _loginState;
            lblLoginWarning.Visible = !_loginState;

        }
        #endregion

        #region Keyword Section
        private bool rt_up = true;  // real time keyword panel visible?
        // private List<UserKeywordControl> _ukControls = new List<UserKeywordControl>();

        private void LblKeywordTItleAlt_Click(object sender, EventArgs e)
        {
            SwapKeywordPanels();
        }

        private void SwapKeywordPanels()
        {
            // text swap
            var temp = lblKeywordTitle.Text;
            lblKeywordTitle.Text = lblKeywordTItleAlt.Text;
            lblKeywordTItleAlt.Text = temp;

            // visibie state swap
            uscUserKeywordPanelControl.Visible = rt_up;
            rt_up = !rt_up;
            uscRealTimeKeywordPanelControl.Visible = rt_up;
        }

        private void FillUserKeywords(int memberId)
        {
            var _ukControls = uscUserKeywordPanelControl.FillKeywords(memberId);
            foreach (var uscUserKeywordContrl in _ukControls)
            {
                uscUserKeywordContrl.KeywordClicked +=
                    new EventHandler<UserKeywordControl.KeywordClickedEventArgs>(UserKeywordClicked);
                uscUserKeywordContrl.DeleteKeywordClicked +=
                    new EventHandler<UserKeywordControl.DeleteKeywordClickedEventArgs>(UserDeletedKeywordClicked);
            }
        }

        private void UserKeywordClicked(object sender, UserKeywordControl.KeywordClickedEventArgs e)
        {
            SearchAndFill(e.Keyword);
        }

        private void UserDeletedKeywordClicked(object sender, UserKeywordControl.DeleteKeywordClickedEventArgs e)
        {
            LogicRepository.Controller.DBbot.DeleteKeyword(_memberId, e.Keyword);
            uscUserKeywordPanelControl.EmptyKeywords();
            FillUserKeywords(_memberId);
        }

        private void UscRealTimeKeywordPanel_KeywordClicked(object sender, RealTimeKeywordPanelControl.KeywordClickedEventArgs e)
        {
            SearchAndFill(e.Keyword);
        }

        private void UscSearchBar_AddKeywordCatClicked(object sender, SearchBarControl.AddKeywordCatClickedEventArgs e)
        {
            if (_loginState == false)
                return;

            LogicRepository.Controller.DBbot.AddKeyword(_memberId, e.Keyword);
            uscUserKeywordPanelControl.EmptyKeywords();
            FillUserKeywords(_memberId);
        }
        #endregion

        #region Search and Result Section
        private void SearchKeyword(object sender, SearchBarControl.SearchCatClickedEventArgs e)
        {
            // reset keyword highlight in real time keywords panel
            uscRealTimeKeywordPanelControl.HightlightSelected(0, null);

            SearchAndFill(e.Keyword);
        }

        private void Scrap_Article(object sender, ArticleControl.ScrapCatClickedEventArgs e)
        {
            if (_loginState == false)
                return;
            LogicRepository.Controller.DBbot.AddScrap(_memberId, e.News);
            uscScrapListControl.EmptyScraps();
            uscScrapListControl.FillScrapPanel(_memberId);
        }

        private void Open_Article(object sender, ArticleControl.ResultDoubleClickedEventArgs e)
        {
            Open_Article(e.Url);
        }

        #endregion

        #region Scrap Section
        private void FillUserScraps(int memberId)
        {
            // add open article fuction
            var scrapControls = uscScrapListControl.FillScrapPanel(memberId);
            foreach (var scrapControl in scrapControls)
            {
                scrapControl.ScrapDoubleClicked +=
                    new EventHandler<ScrapControl.ScrapDoubleClickedEventArgs>(Open_Article);
                scrapControl.DeleteScrapclicked +=
                    new EventHandler<ScrapControl.DeleteScrapclickedEventArgs>(DeleteScrapClicked);
            }
        }

        private void DeleteScrapClicked(object sender, ScrapControl.DeleteScrapclickedEventArgs e)
        {
            LogicRepository.Controller.DBbot.DeleteScrap(_memberId, e.Link);
            uscScrapListControl.EmptyScraps();
            FillUserScraps(_memberId);
        }



        private void Open_Article(object sender, ScrapControl.ScrapDoubleClickedEventArgs e)
        {
            Open_Article(e.Url);
        }
        #endregion

        #region Common Functions
        // search results to result panel and a list
        private List<ArticleControl> _newsResults = new List<ArticleControl>();
        private void SearchAndFill(string keyword)
        {
            // search news with keyword - Logic
            var contentList = LogicRepository.Controller.APIbot.Search(keyword);
            // fill result panel - UI
            var newsResults = uscResultPanel.FillResults(contentList);

            foreach (var result in newsResults)
            {
                result.ResultDoubleClicked +=
                    new EventHandler<ArticleControl.ResultDoubleClickedEventArgs>(Open_Article);
                result.ScrapCatClicked +=
                    new EventHandler<ArticleControl.ScrapCatClickedEventArgs>(Scrap_Article);
            }

            // save added news results to a list : for access to each control
            _newsResults = newsResults;
        }

        private void Open_Article(string url)
        {
            ArticleForm articleForm = new ArticleForm(url);
            articleForm.ShowDialog();
        }
        #endregion


    }
}
