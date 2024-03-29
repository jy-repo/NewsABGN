﻿using System;
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
    public partial class SignInControl : UserControl
    {
        public SignInControl()
        {
            InitializeComponent();
        }


        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            TryLogin();
        }


        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryLogin();
        }

        private void TryLogin()
        {
            if (txtID.Text == "" && txtPW.Text == "")
                return;

            var member = DataRepository.Member.GetMember(txtID.Text, txtPW.Text);

            if (member != null)
            {
                OnBtnSignInClick(member);
                txtID.Text = "";
                txtPW.Text = "";
            }
            else
            {
                MessageBox.Show("아이디나 비밀번호가 틀립니다!");
                return;
            }
        }

        #region BtnSignInClick event things for C# 3.0
        public event EventHandler<BtnSignInClickEventArgs> BtnSignInClick;

        protected virtual void OnBtnSignInClick(BtnSignInClickEventArgs e)
        {
            if (BtnSignInClick != null)
                BtnSignInClick(this, e);
        }

        private BtnSignInClickEventArgs OnBtnSignInClick(Member member)
        {
            BtnSignInClickEventArgs args = new BtnSignInClickEventArgs(member);
            OnBtnSignInClick(args);

            return args;
        }

        private BtnSignInClickEventArgs OnBtnSignInClickForOut()
        {
            BtnSignInClickEventArgs args = new BtnSignInClickEventArgs();
            OnBtnSignInClick(args);

            return args;
        }

        public class BtnSignInClickEventArgs : EventArgs
        {
            public Member Member { get; set; }

            public BtnSignInClickEventArgs()
            {
            }

            public BtnSignInClickEventArgs(Member member)
            {
                Member = member;
            }
        }
        #endregion

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }
    }
}
