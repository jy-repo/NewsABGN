namespace NewsABGN.UI.User_Controls.Result
{
    partial class ArticleListControl
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
            this.flpResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpResultPanel
            // 
            this.flpResultPanel.AutoScroll = true;
            this.flpResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResultPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpResultPanel.Location = new System.Drawing.Point(0, 0);
            this.flpResultPanel.Name = "flpResultPanel";
            this.flpResultPanel.Size = new System.Drawing.Size(678, 579);
            this.flpResultPanel.TabIndex = 0;
            this.flpResultPanel.WrapContents = false;
            // 
            // ArticleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.flpResultPanel);
            this.Name = "ArticleListControl";
            this.Size = new System.Drawing.Size(678, 579);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpResultPanel;
    }
}
