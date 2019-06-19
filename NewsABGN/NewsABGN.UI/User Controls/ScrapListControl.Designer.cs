namespace NewsABGN.UI.User_Controls
{
    partial class ScrapListControl
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
            this.flpScrapPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpScrapPanel
            // 
            this.flpScrapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpScrapPanel.AutoScroll = true;
            this.flpScrapPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpScrapPanel.Location = new System.Drawing.Point(3, 3);
            this.flpScrapPanel.Name = "flpScrapPanel";
            this.flpScrapPanel.Size = new System.Drawing.Size(389, 744);
            this.flpScrapPanel.TabIndex = 0;
            this.flpScrapPanel.WrapContents = false;
            // 
            // ScrapPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpScrapPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScrapPanelControl";
            this.Size = new System.Drawing.Size(395, 750);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpScrapPanel;
    }
}
