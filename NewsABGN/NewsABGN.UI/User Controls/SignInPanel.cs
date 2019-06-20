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
    public partial class SignInPanel : UserControl
    {
        public SignInPanel()
        {
            InitializeComponent();
        }
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

        //로그인 성공 시,
        internal void ShowMemberName(string name)
        {
            lblSignInName.Visible = true;
            lblSignInSuccess.Visible = true;

            lblSignInName.Text = name;
            btnSignIn.Text = "로그아웃";
        }

        public void SignOut()
        {
            lblSignInName.Visible = false;
            lblSignInSuccess.Visible = false;

            btnSignIn.Text = "로그인";
        }


    }
}
