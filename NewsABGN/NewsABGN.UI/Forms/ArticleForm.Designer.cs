namespace NewsABGN.UI
{
    partial class ArticleForm
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
            this.articleMainControl1 = new NewsABGN.UI.User_Controls.ArticleMainControl();
            this.articleTitleBarControl1 = new NewsABGN.UI.User_Controls.ArticleTitleBarControl();
            this.SuspendLayout();
            // 
            // articleMainControl1
            // 
            this.articleMainControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleMainControl1.BackColor = System.Drawing.Color.Transparent;
            this.articleMainControl1.Location = new System.Drawing.Point(8, 51);
            this.articleMainControl1.Name = "articleMainControl1";
            this.articleMainControl1.Size = new System.Drawing.Size(580, 440);
            this.articleMainControl1.TabIndex = 1;
            // 
            // articleTitleBarControl1
            // 
            this.articleTitleBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTitleBarControl1.Location = new System.Drawing.Point(3, 3);
            this.articleTitleBarControl1.Name = "articleTitleBarControl1";
            this.articleTitleBarControl1.Size = new System.Drawing.Size(590, 44);
            this.articleTitleBarControl1.TabIndex = 0;
            this.articleTitleBarControl1.ExitButtonClicked += new System.EventHandler<NewsABGN.UI.User_Controls.ArticleTitleBarControl.ExitButtonClickedEventArgs>(this.ArticleTitleBarControl1_ExitButtonClicked);
            this.articleTitleBarControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseDown);
            this.articleTitleBarControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseMove);
            this.articleTitleBarControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseUp);
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(596, 496);
            this.Controls.Add(this.articleMainControl1);
            this.Controls.Add(this.articleTitleBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArticleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.ArticleTitleBarControl articleTitleBarControl1;
        private User_Controls.ArticleMainControl articleMainControl1;
    }
}