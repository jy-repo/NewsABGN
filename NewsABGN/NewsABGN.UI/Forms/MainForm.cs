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
using NewsABGN.DB;
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

        private bool _loggedIn = false;
        // private Member member = null;


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

        // search results to result panel and a list
        private List<User_Controls.Result.ArticleControl> _newsResults = new List<User_Controls.Result.ArticleControl>();

        private void SearchKeyword(object sender, User_Controls.Search.SearchBarControl.SearchCatClickedEventArgs e)
        {
            SearchAndFill(e.Keyword);
        }

        private void UscRealTimeKeywordPanel_KeywordClicked(object sender, User_Controls.RealTimeKeywordPanelControl.KeywordClickedEventArgs e)
        {
            SearchAndFill(e.Keyword);
        }

        private void SearchAndFill(string keyword)
        {
            // search news with keyword - Logic
            var contentList = LogicRepository.Controller.Searcher.Search(keyword);
            // fill result panel - UI
            var newsResults = uscResultPanel.FillResults(contentList);
            
            foreach(var result in newsResults)
                result.ResultDoubleClicked += 
                    new EventHandler<ArticleControl.ResultDoubleClickedEventArgs>(Open_Article);

            // save added news results to a list : for access to each control
            _newsResults = newsResults;
        }

        private void Open_Article(object sender, ArticleControl.ResultDoubleClickedEventArgs e)
        {
            ArticleForm articleForm = new ArticleForm(e.Url);
            articleForm.ShowDialog();
        }

        // TODO: get and save scraps
        private void GetScrapsAndFill(int memberId)
        {
            // get scrap list from DB through logic
            List<Scrap> scraps = LogicRepository.Controller.Scrapper.GetScraps(memberId);

            

            // fill scrap panel UI with scrap list
            var scrapControls = uscScrapListControl.FillScrapPanel(scraps);
            foreach (var scrapControl in scrapControls)
                scrapControl.ScrapDoubleClicked +=
                    new EventHandler<User_Controls.ScrapControl.ScrapDoubleClickedEventArgs>(Open_Article);
        }
        
        private void Open_Article(object sender, User_Controls.ScrapControl.ScrapDoubleClickedEventArgs e)
        {
            ArticleForm articleForm = new ArticleForm(e.Url);
            articleForm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblLoginWaring.Visible = _loggedIn;
            _loggedIn = !_loggedIn;
            uscScrapListControl.Visible = _loggedIn;

            if (_loggedIn)  // in
            {
                btnLogin.Text = "Logged in / click to log out";
                GetScrapsAndFill(0);
            }
            else    // out
            {
                btnLogin.Text = "Logged out / click to log in";
                uscScrapListControl.EmptyScrapPanel();
            }
        }
    }
}
