namespace NewsABGN.UI.User_Controls
{
    partial class UserKeywordListControl
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
            this.flpKeywordList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpKeywordList
            // 
            this.flpKeywordList.AutoScroll = true;
            this.flpKeywordList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpKeywordList.Location = new System.Drawing.Point(3, 3);
            this.flpKeywordList.Name = "flpKeywordList";
            this.flpKeywordList.Size = new System.Drawing.Size(280, 274);
            this.flpKeywordList.TabIndex = 0;
            this.flpKeywordList.WrapContents = false;
            // 
            // UserKeywordListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpKeywordList);
            this.Name = "UserKeywordListControl";
            this.Size = new System.Drawing.Size(265, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKeywordList;
    }
}
