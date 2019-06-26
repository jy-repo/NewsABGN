namespace NewsABGN.UI.User_Controls
{
    partial class ScrapControl
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
            this.lblPubDate = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Gulim", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(3, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1031, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Some random title to test what happens if the text becomes too long it would actu" +
    "ally go out the window by far more than it can handle";
            this.lblTitle.Click += new System.EventHandler(this.ScrapControl_Click);
            this.lblTitle.MouseLeave += new System.EventHandler(this.LblTitle_MouseLeave);
            this.lblTitle.MouseHover += new System.EventHandler(this.LblTitle_MouseHover);
            // 
            // lblPubDate
            // 
            this.lblPubDate.AutoSize = true;
            this.lblPubDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPubDate.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPubDate.Location = new System.Drawing.Point(3, 3);
            this.lblPubDate.Name = "lblPubDate";
            this.lblPubDate.Size = new System.Drawing.Size(141, 12);
            this.lblPubDate.TabIndex = 2;
            this.lblPubDate.Text = "rand - om - da  te:he:re";
            // 
            // lblDelete
            // 
            this.lblDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDelete.Location = new System.Drawing.Point(256, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(28, 24);
            this.lblDelete.TabIndex = 3;
            this.lblDelete.Text = "X";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Click += new System.EventHandler(this.LblDelete_Click);
            // 
            // ScrapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPubDate);
            this.Name = "ScrapControl";
            this.Size = new System.Drawing.Size(285, 88);
            this.DoubleClick += new System.EventHandler(this.ScrapControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPubDate;
        private System.Windows.Forms.Label lblDelete;
    }
}
