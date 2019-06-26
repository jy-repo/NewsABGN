namespace NewsABGN.UI
{
    partial class MainForm
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
            this.lblKeywordTItleAlt = new System.Windows.Forms.Label();
            this.lblKeywordTitle = new System.Windows.Forms.Label();
            this.lblLoginWarning = new System.Windows.Forms.Label();
            this.lblScrapTitle = new System.Windows.Forms.Label();
            this.pcbDidi = new System.Windows.Forms.PictureBox();
            this.lblLoginWarningBig = new System.Windows.Forms.Label();
            this.uscrTitleBar = new NewsABGN.UI.User_Controls.TitleBar.TitleBarControl();
            this.uscWordCloud = new NewsABGN.UI.User_Controls.WordCloudControl();
            this.uscSignInControl = new NewsABGN.UI.User_Controls.SignInControl();
            this.uscScrapListControl = new NewsABGN.UI.User_Controls.ScrapListControl();
            this.uscRealTimeKeywordPanelControl = new NewsABGN.UI.User_Controls.RealTimeKeywordPanelControl();
            this.uscUserKeywordPanelControl = new NewsABGN.UI.User_Controls.UserKeywordListControl();
            this.uscSearchBar = new NewsABGN.UI.User_Controls.SearchBarControl();
            this.uscResultPanel = new NewsABGN.UI.User_Controls.Result.ArticleListControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDidi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKeywordTItleAlt
            // 
            this.lblKeywordTItleAlt.AutoSize = true;
            this.lblKeywordTItleAlt.BackColor = System.Drawing.Color.White;
            this.lblKeywordTItleAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKeywordTItleAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKeywordTItleAlt.Font = new System.Drawing.Font("중간안상수체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordTItleAlt.Location = new System.Drawing.Point(202, 77);
            this.lblKeywordTItleAlt.Name = "lblKeywordTItleAlt";
            this.lblKeywordTItleAlt.Size = new System.Drawing.Size(47, 13);
            this.lblKeywordTItleAlt.TabIndex = 3;
            this.lblKeywordTItleAlt.Text = "유저 검색어";
            this.lblKeywordTItleAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKeywordTItleAlt.Visible = false;
            this.lblKeywordTItleAlt.Click += new System.EventHandler(this.LblKeywordTItleAlt_Click);
            this.lblKeywordTItleAlt.MouseLeave += new System.EventHandler(this.LblKeywordTItleAlt_MouseLeave);
            this.lblKeywordTItleAlt.MouseHover += new System.EventHandler(this.LblKeywordTItleAlt_MouseHover);
            // 
            // lblKeywordTitle
            // 
            this.lblKeywordTitle.BackColor = System.Drawing.Color.White;
            this.lblKeywordTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeywordTitle.Font = new System.Drawing.Font("굵은안상수체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordTitle.Location = new System.Drawing.Point(7, 61);
            this.lblKeywordTitle.Name = "lblKeywordTitle";
            this.lblKeywordTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblKeywordTitle.Size = new System.Drawing.Size(265, 633);
            this.lblKeywordTitle.TabIndex = 2;
            this.lblKeywordTitle.Text = "실시간 검색어";
            // 
            // lblLoginWarning
            // 
            this.lblLoginWarning.AutoSize = true;
            this.lblLoginWarning.BackColor = System.Drawing.Color.White;
            this.lblLoginWarning.Font = new System.Drawing.Font("가는안상수체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLoginWarning.ForeColor = System.Drawing.Color.Peru;
            this.lblLoginWarning.Location = new System.Drawing.Point(945, 417);
            this.lblLoginWarning.Name = "lblLoginWarning";
            this.lblLoginWarning.Size = new System.Drawing.Size(287, 21);
            this.lblLoginWarning.TabIndex = 3;
            this.lblLoginWarning.Text = "스크랩기능을 사용하는 것은 행복하지만 어려움도 많아요";
            // 
            // lblScrapTitle
            // 
            this.lblScrapTitle.BackColor = System.Drawing.Color.White;
            this.lblScrapTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScrapTitle.Font = new System.Drawing.Font("굵은안상수체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScrapTitle.Location = new System.Drawing.Point(927, 61);
            this.lblScrapTitle.Name = "lblScrapTitle";
            this.lblScrapTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblScrapTitle.Size = new System.Drawing.Size(330, 633);
            this.lblScrapTitle.TabIndex = 2;
            this.lblScrapTitle.Text = "내가 스크랩 한 기사";
            // 
            // pcbDidi
            // 
            this.pcbDidi.Location = new System.Drawing.Point(935, 155);
            this.pcbDidi.Name = "pcbDidi";
            this.pcbDidi.Size = new System.Drawing.Size(316, 259);
            this.pcbDidi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDidi.TabIndex = 6;
            this.pcbDidi.TabStop = false;
            // 
            // lblLoginWarningBig
            // 
            this.lblLoginWarningBig.AutoSize = true;
            this.lblLoginWarningBig.BackColor = System.Drawing.Color.White;
            this.lblLoginWarningBig.Font = new System.Drawing.Font("중간안상수체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLoginWarningBig.ForeColor = System.Drawing.Color.Peru;
            this.lblLoginWarningBig.Location = new System.Drawing.Point(966, 440);
            this.lblLoginWarningBig.Name = "lblLoginWarningBig";
            this.lblLoginWarningBig.Size = new System.Drawing.Size(244, 27);
            this.lblLoginWarningBig.TabIndex = 3;
            this.lblLoginWarningBig.Text = "로그인을 신속하게 진행해주세요";
            // 
            // uscrTitleBar
            // 
            this.uscrTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uscrTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscrTitleBar.Location = new System.Drawing.Point(0, 0);
            this.uscrTitleBar.Name = "uscrTitleBar";
            this.uscrTitleBar.Size = new System.Drawing.Size(1263, 60);
            this.uscrTitleBar.TabIndex = 8;
            this.uscrTitleBar.ExitButtonClicked += new System.EventHandler<NewsABGN.UI.User_Controls.TitleBar.TitleBarControl.ExitButtonClickedEventArgs>(this.UscTitleBar_ExitButtonClicked);
            this.uscrTitleBar.BtnSignInClick += new System.EventHandler<NewsABGN.UI.User_Controls.TitleBar.TitleBarControl.BtnSignInClickEventArgs>(this.UscrTitleBar_BtnSignInClick);
            this.uscrTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseDown);
            this.uscrTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseMove);
            this.uscrTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseUp);
            // 
            // uscWordCloud
            // 
            this.uscWordCloud.BackColor = System.Drawing.Color.White;
            this.uscWordCloud.Location = new System.Drawing.Point(13, 371);
            this.uscWordCloud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscWordCloud.Name = "uscWordCloud";
            this.uscWordCloud.Size = new System.Drawing.Size(253, 316);
            this.uscWordCloud.TabIndex = 7;
            // 
            // uscSignInControl
            // 
            this.uscSignInControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uscSignInControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uscSignInControl.Location = new System.Drawing.Point(923, 49);
            this.uscSignInControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscSignInControl.MaximumSize = new System.Drawing.Size(265, 220);
            this.uscSignInControl.MinimumSize = new System.Drawing.Size(265, 220);
            this.uscSignInControl.Name = "uscSignInControl";
            this.uscSignInControl.Size = new System.Drawing.Size(265, 220);
            this.uscSignInControl.TabIndex = 5;
            this.uscSignInControl.Visible = false;
            this.uscSignInControl.BtnSignInClick += new System.EventHandler<NewsABGN.UI.User_Controls.SignInControl.BtnSignInClickEventArgs>(this.UscSignInControl_BtnSignInClick);
            // 
            // uscScrapListControl
            // 
            this.uscScrapListControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uscScrapListControl.Location = new System.Drawing.Point(940, 101);
            this.uscScrapListControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscScrapListControl.Name = "uscScrapListControl";
            this.uscScrapListControl.Size = new System.Drawing.Size(305, 586);
            this.uscScrapListControl.TabIndex = 0;
            this.uscScrapListControl.Visible = false;
            // 
            // uscRealTimeKeywordPanelControl
            // 
            this.uscRealTimeKeywordPanelControl.BackColor = System.Drawing.Color.White;
            this.uscRealTimeKeywordPanelControl.Location = new System.Drawing.Point(13, 106);
            this.uscRealTimeKeywordPanelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscRealTimeKeywordPanelControl.Name = "uscRealTimeKeywordPanelControl";
            this.uscRealTimeKeywordPanelControl.Size = new System.Drawing.Size(253, 258);
            this.uscRealTimeKeywordPanelControl.TabIndex = 0;
            this.uscRealTimeKeywordPanelControl.KeywordClicked += new System.EventHandler<NewsABGN.UI.User_Controls.RealTimeKeywordPanelControl.KeywordClickedEventArgs>(this.UscRealTimeKeywordPanel_KeywordClicked);
            // 
            // uscUserKeywordPanelControl
            // 
            this.uscUserKeywordPanelControl.BackColor = System.Drawing.Color.White;
            this.uscUserKeywordPanelControl.Location = new System.Drawing.Point(17, 107);
            this.uscUserKeywordPanelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscUserKeywordPanelControl.Name = "uscUserKeywordPanelControl";
            this.uscUserKeywordPanelControl.Size = new System.Drawing.Size(245, 258);
            this.uscUserKeywordPanelControl.TabIndex = 1;
            this.uscUserKeywordPanelControl.Visible = false;
            // 
            // uscSearchBar
            // 
            this.uscSearchBar.Location = new System.Drawing.Point(279, 62);
            this.uscSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscSearchBar.Name = "uscSearchBar";
            this.uscSearchBar.Size = new System.Drawing.Size(643, 39);
            this.uscSearchBar.TabIndex = 1;
            this.uscSearchBar.SearchCatClicked += new System.EventHandler<NewsABGN.UI.User_Controls.SearchBarControl.SearchCatClickedEventArgs>(this.SearchKeyword);
            this.uscSearchBar.AddKeywordCatClicked += new System.EventHandler<NewsABGN.UI.User_Controls.SearchBarControl.AddKeywordCatClickedEventArgs>(this.UscSearchBar_AddKeywordCatClicked);
            // 
            // uscResultPanel
            // 
            this.uscResultPanel.BackColor = System.Drawing.Color.White;
            this.uscResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uscResultPanel.Location = new System.Drawing.Point(277, 107);
            this.uscResultPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscResultPanel.Name = "uscResultPanel";
            this.uscResultPanel.Size = new System.Drawing.Size(646, 587);
            this.uscResultPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1263, 707);
            this.Controls.Add(this.uscrTitleBar);
            this.Controls.Add(this.uscWordCloud);
            this.Controls.Add(this.uscSignInControl);
            this.Controls.Add(this.pcbDidi);
            this.Controls.Add(this.uscScrapListControl);
            this.Controls.Add(this.uscRealTimeKeywordPanelControl);
            this.Controls.Add(this.lblKeywordTItleAlt);
            this.Controls.Add(this.uscUserKeywordPanelControl);
            this.Controls.Add(this.lblKeywordTitle);
            this.Controls.Add(this.uscSearchBar);
            this.Controls.Add(this.lblLoginWarningBig);
            this.Controls.Add(this.lblLoginWarning);
            this.Controls.Add(this.lblScrapTitle);
            this.Controls.Add(this.uscResultPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1263, 707);
            this.MinimumSize = new System.Drawing.Size(1263, 690);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "News An Bol Ggo Nyang ?_?";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDidi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private User_Controls.RealTimeKeywordPanelControl uscRealTimeKeywordPanelControl;
        private User_Controls.SignInControl uscSignInControl;
        private User_Controls.UserKeywordListControl uscUserKeywordPanelControl;
        private System.Windows.Forms.Label lblKeywordTitle;
        private System.Windows.Forms.Label lblKeywordTItleAlt;
        private User_Controls.SearchBarControl uscSearchBar;
        private User_Controls.Result.ArticleListControl uscResultPanel;
        private User_Controls.ScrapListControl uscScrapListControl;
        private System.Windows.Forms.Label lblScrapTitle;
        private System.Windows.Forms.Label lblLoginWarning;
        private System.Windows.Forms.PictureBox pcbDidi;
        private System.Windows.Forms.Label lblLoginWarningBig;
        private User_Controls.WordCloudControl uscWordCloud;
        private User_Controls.TitleBar.TitleBarControl uscrTitleBar;
    }
}