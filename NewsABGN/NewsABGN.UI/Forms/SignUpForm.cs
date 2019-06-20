using NewsABGN.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsABGN.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            cbEmail.SelectedIndex = 0;
            cbCity.SelectedIndex = 0;
        }

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

        #region window resize
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPW.Text = "";
            txtPWConfirm.Text = "";
            txtHP.Text = "";
            txtEmail.Text = "";

            cbEmail.SelectedIndex = 0;
            cbCity.SelectedIndex = 0;
        }


        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            
            member.Id = txtID.Text;
            member.Password = txtPW.Text;
            member.Name = txtName.Text;
            member.Age = Int32.Parse(txtAge.Text);
            member.Phone = txtHP.Text;
            member.City = cbCity.SelectedItem.ToString();
            member.Email = $"{txtEmail.Text}@{cbEmail.SelectedItem.ToString()}";
            DataRepository.Member.Insert(member);
            this.Close();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            if (IsNullCheck()) btnSignUp.Enabled = true;
            else btnSignUp.Enabled = false;
        }

        private bool IsNullCheck()
        {
            if (string.IsNullOrEmpty(txtID.Text)
                || string.IsNullOrEmpty(txtPW.Text)
                || string.IsNullOrEmpty(txtPWConfirm.Text)
                || string.IsNullOrEmpty(txtHP.Text)
                || string.IsNullOrEmpty(txtAge.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || cbCity.SelectedIndex == 0
                || cbEmail.SelectedIndex == 0)
                return false;
            else return true;
        }

        //ID체크 - DB접속
        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            if (DataRepository.Member.GetAll(x => x.Id == txtID.Text).Count() != 0)
            {
                txtID.BackColor = Color.Red;
                btnSignUp.Enabled = false;
            }
            else txtID.BackColor = Color.Green;
        }

        //패스워드, 패스워드 확인 체크
        private void TxtPW_TextChanged(object sender, EventArgs e)
        {
            if (txtPW.Text != txtPWConfirm.Text 
                || string.IsNullOrEmpty(txtPW.Text)
                || string.IsNullOrEmpty(txtPWConfirm.Text))
            {
                txtPW.BackColor = Color.Red;
                txtPWConfirm.BackColor = Color.Red;
                btnSignUp.Enabled = false;
            }
            else
            {
                txtPW.BackColor = Color.Green;
                txtPWConfirm.BackColor = Color.Green;
            }
            
        }

        // txtHP, txtAge 숫자 체크
        private void Txt_CheckNum(object sender, EventArgs e)
        {
            //TODO
            if (int.TryParse(txtAge.Text, out int i))
                txtAge.BackColor = Color.Green;
            else
            {
                txtAge.BackColor = Color.Red;
                btnSignUp.Enabled = false;
            }

            if (int.TryParse(txtHP.Text, out int j))
                txtHP.BackColor = Color.Green;
            else
            {
                txtHP.BackColor = Color.Red;
                btnSignUp.Enabled = false;
            }

        }

    }
}
