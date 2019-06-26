namespace NewsABGN.UI.User_Controls.Result
{
    partial class ArticleControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbScrap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbScrap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Gulim", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(441, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title SampleTitle SampleTitle SampleTitle Sample";
            this.lblTitle.Click += new System.EventHandler(this.Result_DoubleClick);
            this.lblTitle.MouseLeave += new System.EventHandler(this.LblTitle_MouseLeave);
            this.lblTitle.MouseHover += new System.EventHandler(this.LblTitle_MouseHover);
            // 
            // lblContents
            // 
            this.lblContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContents.AutoSize = true;
            this.lblContents.BackColor = System.Drawing.Color.Transparent;
            this.lblContents.Location = new System.Drawing.Point(17, 73);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(149, 12);
            this.lblContents.TabIndex = 1;
            this.lblContents.Text = "news contents goes here";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 1);
            this.label1.TabIndex = 2;
            // 
            // ptbScrap
            // 
            this.ptbScrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbScrap.Image = global::NewsABGN.UI.Properties.Resources.output_onlinepngtools__1_;
            this.ptbScrap.Location = new System.Drawing.Point(554, 124);
            this.ptbScrap.Name = "ptbScrap";
            this.ptbScrap.Size = new System.Drawing.Size(43, 35);
            this.ptbScrap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbScrap.TabIndex = 3;
            this.ptbScrap.TabStop = false;
            this.ptbScrap.Visible = false;
            this.ptbScrap.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ArticleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ptbScrap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblTitle);
            this.Name = "ArticleControl";
            this.Size = new System.Drawing.Size(603, 172);
            ((System.ComponentModel.ISupportInitialize)(this.ptbScrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbScrap;
    }
}
