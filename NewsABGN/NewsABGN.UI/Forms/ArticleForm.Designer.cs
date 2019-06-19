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
            this.lblMainContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainContent
            // 
            this.lblMainContent.AutoSize = true;
            this.lblMainContent.Location = new System.Drawing.Point(47, 96);
            this.lblMainContent.Name = "lblMainContent";
            this.lblMainContent.Size = new System.Drawing.Size(38, 12);
            this.lblMainContent.TabIndex = 0;
            this.lblMainContent.Text = "label1";
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleForm";
            this.Text = "ArticleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainContent;
    }
}