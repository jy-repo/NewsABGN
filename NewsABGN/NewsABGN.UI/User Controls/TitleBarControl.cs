using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI.User_Controls.TitleBar
{
    public partial class TitleBarControl : UserControl
    {
        public TitleBarControl()
        {
            InitializeComponent();
        }

        public void Logged_In(string name)
        {
            lblSignInName.Visible = true;
            lblSignInSuccess.Visible = true;

            lblSignInName.Text = name;
            btnSignIn.Text = "로그아웃";
        }

        public void Logged_Out()
        {
            lblSignInName.Visible = false;
            lblSignInSuccess.Visible = false;

            btnSignIn.Text = "로그인";
        }


        private void PicbExit_Click(object sender, EventArgs e)
        {
            OnExitButtonClicked();
        }

        #region ExitButtonClicked event things for C# 3.0
        public event EventHandler<ExitButtonClickedEventArgs> ExitButtonClicked;

        protected virtual void OnExitButtonClicked(ExitButtonClickedEventArgs e)
        {
            if (ExitButtonClicked != null)
                ExitButtonClicked(this, e);
        }

        private ExitButtonClickedEventArgs OnExitButtonClicked()
        {
            ExitButtonClickedEventArgs args = new ExitButtonClickedEventArgs();
            OnExitButtonClicked(args);

            return args;
        }

        /*private ExitButtonClickedEventArgs OnExitButtonClickedForOut()
        {
            ExitButtonClickedEventArgs args = new ExitButtonClickedEventArgs();
            OnExitButtonClicked(args);

            return args;
        }*/

        public class ExitButtonClickedEventArgs : EventArgs
        {


            /*public ExitButtonClickedEventArgs()
            {
            }

            public ExitButtonClickedEventArgs()
            {

            }*/
        }
        #endregion

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            OnBtnSignInClick();
        }

        #region BtnSignInClick event things for C# 3.0
        public event EventHandler<BtnSignInClickEventArgs> BtnSignInClick;

        protected virtual void OnBtnSignInClick(BtnSignInClickEventArgs e)
        {
            if (BtnSignInClick != null)
                BtnSignInClick(this, e);
        }

        private BtnSignInClickEventArgs OnBtnSignInClick()
        {
            BtnSignInClickEventArgs args = new BtnSignInClickEventArgs();
            OnBtnSignInClick(args);

            return args;
        }

        /*private BtnSignInClickEventArgs OnBtnSignInClickForOut()
        {
            BtnSignInClickEventArgs args = new BtnSignInClickEventArgs();
            OnBtnSignInClick(args);

            return args;
        }*/

        public class BtnSignInClickEventArgs : EventArgs
        {


            /*public BtnSignInClickEventArgs()
            {
            }

            public BtnSignInClickEventArgs()
            {

            }*/
        }


        #endregion
    }
}
