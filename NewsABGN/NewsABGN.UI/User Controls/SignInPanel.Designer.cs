namespace NewsABGN.UI.User_Controls
{
    partial class SignInPanel
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
            this.lblSignInSuccess = new System.Windows.Forms.Label();
            this.lblSignInName = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSignInSuccess
            // 
            this.lblSignInSuccess.AutoSize = true;
            this.lblSignInSuccess.Font = new System.Drawing.Font("중간안상수체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSignInSuccess.ForeColor = System.Drawing.Color.White;
            this.lblSignInSuccess.Location = new System.Drawing.Point(151, 20);
            this.lblSignInSuccess.Name = "lblSignInSuccess";
            this.lblSignInSuccess.Size = new System.Drawing.Size(100, 21);
            this.lblSignInSuccess.TabIndex = 0;
            this.lblSignInSuccess.Text = "님 환영합니다.";
            this.lblSignInSuccess.Visible = false;
            // 
            // lblSignInName
            // 
            this.lblSignInName.Font = new System.Drawing.Font("중간안상수체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSignInName.ForeColor = System.Drawing.Color.White;
            this.lblSignInName.Location = new System.Drawing.Point(23, 20);
            this.lblSignInName.Name = "lblSignInName";
            this.lblSignInName.Size = new System.Drawing.Size(111, 19);
            this.lblSignInName.TabIndex = 0;
            this.lblSignInName.Text = "이름";
            this.lblSignInName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSignInName.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("가는안상수체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(286, 12);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(73, 36);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "로 그 인";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // SignInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblSignInName);
            this.Controls.Add(this.lblSignInSuccess);
            this.Name = "SignInPanel";
            this.Size = new System.Drawing.Size(379, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignInSuccess;
        private System.Windows.Forms.Label lblSignInName;
        private System.Windows.Forms.Button btnSignIn;
    }
}
