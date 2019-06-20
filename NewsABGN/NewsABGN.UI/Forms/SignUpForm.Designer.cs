namespace NewsABGN.UI
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPWConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpSignUp = new System.Windows.Forms.GroupBox();
            this.uscTitleBar = new NewsABGN.UI.User_Controls.TitleBar.TitleBarControl();
            this.grpSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Enabled = false;
            this.btnSignUp.Location = new System.Drawing.Point(201, 276);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(73, 36);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "회원가입";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtPW.Location = new System.Drawing.Point(116, 90);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(121, 27);
            this.txtPW.TabIndex = 2;
            this.txtPW.TextChanged += new System.EventHandler(this.TxtPW_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(53, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "비밀번호";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtID.Location = new System.Drawing.Point(116, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 27);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(60, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(244, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "확인";
            // 
            // txtPWConfirm
            // 
            this.txtPWConfirm.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtPWConfirm.Location = new System.Drawing.Point(280, 90);
            this.txtPWConfirm.Name = "txtPWConfirm";
            this.txtPWConfirm.PasswordChar = '●';
            this.txtPWConfirm.Size = new System.Drawing.Size(121, 27);
            this.txtPWConfirm.TabIndex = 3;
            this.txtPWConfirm.TextChanged += new System.EventHandler(this.TxtPW_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(73, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtName.Location = new System.Drawing.Point(116, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(70, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "나이";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtAge.Location = new System.Drawing.Point(116, 123);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 27);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextChanged += new System.EventHandler(this.Txt_CheckNum);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(33, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "휴대폰 번호";
            // 
            // txtHP
            // 
            this.txtHP.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtHP.Location = new System.Drawing.Point(116, 156);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(121, 27);
            this.txtHP.TabIndex = 6;
            this.txtHP.TextChanged += new System.EventHandler(this.Txt_CheckNum);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(53, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "거주지역";
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.Font = new System.Drawing.Font("Gulim", 13F);
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "------------",
            "서울",
            "대구",
            "광주",
            "대전",
            "부산",
            "울산",
            "인천",
            "제주",
            "경북",
            "경남",
            "전남",
            "전북",
            "충남",
            "충북",
            "강원"});
            this.cbCity.Location = new System.Drawing.Point(116, 189);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 25);
            this.cbCity.TabIndex = 7;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("휴먼가는샘체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(58, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtEmail.Location = new System.Drawing.Point(116, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 27);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dotum", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(244, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "@";
            // 
            // cbEmail
            // 
            this.cbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmail.Font = new System.Drawing.Font("Gulim", 13F);
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Items.AddRange(new object[] {
            "------------",
            "daum.net",
            "gmail.com",
            "yahoo.com",
            "naver.com"});
            this.cbEmail.Location = new System.Drawing.Point(280, 220);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(121, 25);
            this.cbEmail.TabIndex = 9;
            this.cbEmail.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "정 정";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // grpSignUp
            // 
            this.grpSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSignUp.Controls.Add(this.cbEmail);
            this.grpSignUp.Controls.Add(this.cbCity);
            this.grpSignUp.Controls.Add(this.btnClear);
            this.grpSignUp.Controls.Add(this.btnSignUp);
            this.grpSignUp.Controls.Add(this.label7);
            this.grpSignUp.Controls.Add(this.txtEmail);
            this.grpSignUp.Controls.Add(this.label10);
            this.grpSignUp.Controls.Add(this.label8);
            this.grpSignUp.Controls.Add(this.txtHP);
            this.grpSignUp.Controls.Add(this.label6);
            this.grpSignUp.Controls.Add(this.txtAge);
            this.grpSignUp.Controls.Add(this.label5);
            this.grpSignUp.Controls.Add(this.txtName);
            this.grpSignUp.Controls.Add(this.label4);
            this.grpSignUp.Controls.Add(this.txtPWConfirm);
            this.grpSignUp.Controls.Add(this.label1);
            this.grpSignUp.Controls.Add(this.txtPW);
            this.grpSignUp.Controls.Add(this.label3);
            this.grpSignUp.Controls.Add(this.txtID);
            this.grpSignUp.Controls.Add(this.label2);
            this.grpSignUp.Font = new System.Drawing.Font("휴먼중간샘체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpSignUp.Location = new System.Drawing.Point(12, 66);
            this.grpSignUp.Name = "grpSignUp";
            this.grpSignUp.Size = new System.Drawing.Size(439, 331);
            this.grpSignUp.TabIndex = 16;
            this.grpSignUp.TabStop = false;
            this.grpSignUp.Text = "회원가입이다냥";
            // 
            // uscTitleBar
            // 
            this.uscTitleBar.BackColor = System.Drawing.Color.White;
            this.uscTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTitleBar.Location = new System.Drawing.Point(0, 0);
            this.uscTitleBar.Name = "uscTitleBar";
            this.uscTitleBar.Size = new System.Drawing.Size(463, 60);
            this.uscTitleBar.TabIndex = 17;
            this.uscTitleBar.ExitButtonClicked += new System.EventHandler<NewsABGN.UI.User_Controls.TitleBar.TitleBarControl.ExitButtonClickedEventArgs>(this.UscTitleBar_ExitButtonClicked);
            this.uscTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseDown);
            this.uscTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseMove);
            this.uscTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseUp);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 409);
            this.Controls.Add(this.uscTitleBar);
            this.Controls.Add(this.grpSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignUpForm";
            this.grpSignUp.ResumeLayout(false);
            this.grpSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPWConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpSignUp;
        private User_Controls.TitleBar.TitleBarControl uscTitleBar;
    }
}