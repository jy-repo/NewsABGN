namespace NewsABGN.UI.User_Controls
{
    partial class WordCloudControl
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
            this.lblWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWords
            // 
            this.lblWords.Location = new System.Drawing.Point(44, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(158, 316);
            this.lblWords.TabIndex = 0;
            // 
            // WordCloudControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWords);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordCloudControl";
            this.Size = new System.Drawing.Size(253, 316);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWords;
    }
}
