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
            this.spcKeyword_News = new System.Windows.Forms.SplitContainer();
            this.uscRealTimeKeywordPanel = new NewsABGN.UI.User_Controls.RealTimeKeywordPanel();
            this.spcSearch_Scrap = new System.Windows.Forms.SplitContainer();
            this.uscResultPanel = new NewsABGN.UI.User_Controls.Result.ResultPanel();
            this.uscSearchBar = new NewsABGN.UI.User_Controls.Search.SearchBar();
            this.lblLoginWaring = new System.Windows.Forms.Label();
            this.uscScrapPanel = new NewsABGN.UI.User_Controls.ScrapPanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.uscTitleBar = new NewsABGN.UI.User_Controls.TitleBar.TitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.spcKeyword_News)).BeginInit();
            this.spcKeyword_News.Panel1.SuspendLayout();
            this.spcKeyword_News.Panel2.SuspendLayout();
            this.spcKeyword_News.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSearch_Scrap)).BeginInit();
            this.spcSearch_Scrap.Panel1.SuspendLayout();
            this.spcSearch_Scrap.Panel2.SuspendLayout();
            this.spcSearch_Scrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcKeyword_News
            // 
            this.spcKeyword_News.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcKeyword_News.Location = new System.Drawing.Point(2, 64);
            this.spcKeyword_News.Name = "spcKeyword_News";
            // 
            // spcKeyword_News.Panel1
            // 
            this.spcKeyword_News.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.spcKeyword_News.Panel1.Controls.Add(this.uscRealTimeKeywordPanel);
            // 
            // spcKeyword_News.Panel2
            // 
            this.spcKeyword_News.Panel2.Controls.Add(this.spcSearch_Scrap);
            this.spcKeyword_News.Size = new System.Drawing.Size(1276, 823);
            this.spcKeyword_News.SplitterDistance = 235;
            this.spcKeyword_News.TabIndex = 3;
            // 
            // uscRealTimeKeywordPanel
            // 
            this.uscRealTimeKeywordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscRealTimeKeywordPanel.Location = new System.Drawing.Point(4, 16);
            this.uscRealTimeKeywordPanel.Name = "uscRealTimeKeywordPanel";
            this.uscRealTimeKeywordPanel.Size = new System.Drawing.Size(229, 344);
            this.uscRealTimeKeywordPanel.TabIndex = 0;
            this.uscRealTimeKeywordPanel.KeywordClicked += new System.EventHandler<NewsABGN.UI.User_Controls.RealTimeKeywordPanel.KeywordClickedEventArgs>(this.UscRealTimeKeywordPanel_KeywordClicked);
            // 
            // spcSearch_Scrap
            // 
            this.spcSearch_Scrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSearch_Scrap.Location = new System.Drawing.Point(0, 0);
            this.spcSearch_Scrap.Name = "spcSearch_Scrap";
            // 
            // spcSearch_Scrap.Panel1
            // 
            this.spcSearch_Scrap.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.spcSearch_Scrap.Panel1.Controls.Add(this.uscResultPanel);
            this.spcSearch_Scrap.Panel1.Controls.Add(this.uscSearchBar);
            // 
            // spcSearch_Scrap.Panel2
            // 
            this.spcSearch_Scrap.Panel2.Controls.Add(this.lblLoginWaring);
            this.spcSearch_Scrap.Panel2.Controls.Add(this.uscScrapPanel);
            this.spcSearch_Scrap.Panel2.Controls.Add(this.label1);
            this.spcSearch_Scrap.Size = new System.Drawing.Size(1037, 823);
            this.spcSearch_Scrap.SplitterDistance = 661;
            this.spcSearch_Scrap.SplitterWidth = 15;
            this.spcSearch_Scrap.TabIndex = 3;
            // 
            // uscResultPanel
            // 
            this.uscResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscResultPanel.BackColor = System.Drawing.Color.Transparent;
            this.uscResultPanel.Location = new System.Drawing.Point(3, 64);
            this.uscResultPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscResultPanel.Name = "uscResultPanel";
            this.uscResultPanel.Size = new System.Drawing.Size(655, 566);
            this.uscResultPanel.TabIndex = 2;
            // 
            // uscSearchBar
            // 
            this.uscSearchBar.Location = new System.Drawing.Point(3, 16);
            this.uscSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscSearchBar.Name = "uscSearchBar";
            this.uscSearchBar.Size = new System.Drawing.Size(382, 40);
            this.uscSearchBar.TabIndex = 1;
            this.uscSearchBar.SearchCatClicked += new System.EventHandler<NewsABGN.UI.User_Controls.Search.SearchBar.SearchCatClickedEventArgs>(this.SearchKeyword);
            // 
            // lblLoginWaring
            // 
            this.lblLoginWaring.AutoSize = true;
            this.lblLoginWaring.Font = new System.Drawing.Font("GungsuhChe", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLoginWaring.Location = new System.Drawing.Point(78, 143);
            this.lblLoginWaring.Name = "lblLoginWaring";
            this.lblLoginWaring.Size = new System.Drawing.Size(197, 32);
            this.lblLoginWaring.TabIndex = 3;
            this.lblLoginWaring.Text = "로그인 해라";
            // 
            // uscScrapPanel
            // 
            this.uscScrapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscScrapPanel.Location = new System.Drawing.Point(23, 41);
            this.uscScrapPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscScrapPanel.Name = "uscScrapPanel";
            this.uscScrapPanel.Size = new System.Drawing.Size(309, 589);
            this.uscScrapPanel.TabIndex = 0;
            this.uscScrapPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haan Sale M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "내가 스크랩 한 기사";
            // 
            // uscTitleBar
            // 
            this.uscTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uscTitleBar.Location = new System.Drawing.Point(2, 2);
            this.uscTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscTitleBar.Name = "uscTitleBar";
            this.uscTitleBar.Size = new System.Drawing.Size(1276, 60);
            this.uscTitleBar.TabIndex = 0;
            this.uscTitleBar.ExitButtonClicked += new System.EventHandler<NewsABGN.UI.User_Controls.TitleBar.TitleBar.ExitButtonClickedEventArgs>(this.UscTitleBar_ExitButtonClicked);
            this.uscTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseDown);
            this.uscTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseMove);
            this.uscTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UscTitleBar_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1280, 707);
            this.Controls.Add(this.spcKeyword_News);
            this.Controls.Add(this.uscTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "News An Bol Ggo Nyang ?_?";
            this.spcKeyword_News.Panel1.ResumeLayout(false);
            this.spcKeyword_News.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcKeyword_News)).EndInit();
            this.spcKeyword_News.ResumeLayout(false);
            this.spcSearch_Scrap.Panel1.ResumeLayout(false);
            this.spcSearch_Scrap.Panel2.ResumeLayout(false);
            this.spcSearch_Scrap.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSearch_Scrap)).EndInit();
            this.spcSearch_Scrap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.TitleBar.TitleBar uscTitleBar;
        private User_Controls.Search.SearchBar uscSearchBar;
        private System.Windows.Forms.SplitContainer spcKeyword_News;
        private User_Controls.Result.ResultPanel uscResultPanel;
        private System.Windows.Forms.SplitContainer spcSearch_Scrap;
        private User_Controls.ScrapPanelControl uscScrapPanel;
        private User_Controls.RealTimeKeywordPanel uscRealTimeKeywordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginWaring;
    }
}