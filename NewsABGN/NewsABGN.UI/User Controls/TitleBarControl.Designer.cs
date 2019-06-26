namespace NewsABGN.UI.User_Controls.TitleBar
{
    partial class TitleBarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblSignInName = new System.Windows.Forms.Label();
            this.lblSignInSuccess = new System.Windows.Forms.Label();
            this.picbExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("가는안상수체", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "뉴스 안볼꺼냥??";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("가는안상수체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(1124, 11);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(73, 36);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "로 그 인";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // lblSignInName
            // 
            this.lblSignInName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignInName.Font = new System.Drawing.Font("중간안상수체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSignInName.ForeColor = System.Drawing.Color.White;
            this.lblSignInName.Location = new System.Drawing.Point(861, 19);
            this.lblSignInName.Name = "lblSignInName";
            this.lblSignInName.Size = new System.Drawing.Size(111, 19);
            this.lblSignInName.TabIndex = 3;
            this.lblSignInName.Text = "이름";
            this.lblSignInName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSignInName.Visible = false;
            // 
            // lblSignInSuccess
            // 
            this.lblSignInSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignInSuccess.AutoSize = true;
            this.lblSignInSuccess.Font = new System.Drawing.Font("중간안상수체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSignInSuccess.ForeColor = System.Drawing.Color.White;
            this.lblSignInSuccess.Location = new System.Drawing.Point(990, 19);
            this.lblSignInSuccess.Name = "lblSignInSuccess";
            this.lblSignInSuccess.Size = new System.Drawing.Size(100, 21);
            this.lblSignInSuccess.TabIndex = 4;
            this.lblSignInSuccess.Text = "님 환영합니다.";
            this.lblSignInSuccess.Visible = false;
            // 
            // picbExit
            // 
            this.picbExit.AccessibleName = "";
            this.picbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbExit.BackColor = System.Drawing.Color.Transparent;
            this.picbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbExit.Image = global::NewsABGN.UI.Properties.Resources.cat_exit1;
            this.picbExit.Location = new System.Drawing.Point(1206, 2);
            this.picbExit.Name = "picbExit";
            this.picbExit.Size = new System.Drawing.Size(54, 50);
            this.picbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbExit.TabIndex = 2;
            this.picbExit.TabStop = false;
            this.picbExit.Click += new System.EventHandler(this.PicbExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewsABGN.UI.Properties.Resources.cat_q;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TitleBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblSignInName);
            this.Controls.Add(this.lblSignInSuccess);
            this.Controls.Add(this.picbExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TitleBarControl";
            this.Size = new System.Drawing.Size(1263, 60);
            ((System.ComponentModel.ISupportInitialize)(this.picbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbExit;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblSignInName;
        private System.Windows.Forms.Label lblSignInSuccess;
    }
}
