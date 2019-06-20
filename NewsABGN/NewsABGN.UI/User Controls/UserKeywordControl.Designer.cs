namespace NewsABGN.UI.User_Controls
{
    partial class UserKeywordControl
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
            this.lblUserKeyword = new System.Windows.Forms.Label();
            this.lblRemoveKeyword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserKeyword
            // 
            this.lblUserKeyword.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserKeyword.Location = new System.Drawing.Point(0, 7);
            this.lblUserKeyword.Name = "lblUserKeyword";
            this.lblUserKeyword.Size = new System.Drawing.Size(168, 25);
            this.lblUserKeyword.TabIndex = 0;
            this.lblUserKeyword.Text = "user Keyword 1";
            this.lblUserKeyword.Click += new System.EventHandler(this.LblUserKeyword_Click);
            // 
            // lblRemoveKeyword
            // 
            this.lblRemoveKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemoveKeyword.Font = new System.Drawing.Font("Gulim", 15F);
            this.lblRemoveKeyword.Location = new System.Drawing.Point(166, 6);
            this.lblRemoveKeyword.Name = "lblRemoveKeyword";
            this.lblRemoveKeyword.Size = new System.Drawing.Size(25, 25);
            this.lblRemoveKeyword.TabIndex = 1;
            this.lblRemoveKeyword.Text = "X";
            this.lblRemoveKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserKeywordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemoveKeyword);
            this.Controls.Add(this.lblUserKeyword);
            this.MinimumSize = new System.Drawing.Size(190, 0);
            this.Name = "UserKeywordControl";
            this.Size = new System.Drawing.Size(190, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserKeyword;
        private System.Windows.Forms.Label lblRemoveKeyword;
    }
}
