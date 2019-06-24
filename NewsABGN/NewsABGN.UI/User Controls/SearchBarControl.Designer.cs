namespace NewsABGN.UI.User_Controls
{
    partial class SearchBarControl
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
            this.txbKeyword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAddKeyword = new System.Windows.Forms.PictureBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txbKeyword
            // 
            this.txbKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbKeyword.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbKeyword.Location = new System.Drawing.Point(3, 2);
            this.txbKeyword.Name = "txbKeyword";
            this.txbKeyword.Size = new System.Drawing.Size(518, 35);
            this.txbKeyword.TabIndex = 0;
            this.txbKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbKeyword_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(207)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.ptbAddKeyword);
            this.panel1.Controls.Add(this.ptbSearch);
            this.panel1.Controls.Add(this.txbKeyword);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 40);
            this.panel1.TabIndex = 1;
            // 
            // ptbAddKeyword
            // 
            this.ptbAddKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbAddKeyword.Image = global::NewsABGN.UI.Properties.Resources.output_onlinepngtools;
            this.ptbAddKeyword.Location = new System.Drawing.Point(576, 5);
            this.ptbAddKeyword.Name = "ptbAddKeyword";
            this.ptbAddKeyword.Size = new System.Drawing.Size(43, 32);
            this.ptbAddKeyword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddKeyword.TabIndex = 2;
            this.ptbAddKeyword.TabStop = false;
            this.ptbAddKeyword.Click += new System.EventHandler(this.PtbAddKeyword_Click);
            // 
            // ptbSearch
            // 
            this.ptbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbSearch.Image = global::NewsABGN.UI.Properties.Resources.cat_search;
            this.ptbSearch.Location = new System.Drawing.Point(527, 5);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(43, 32);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSearch.TabIndex = 1;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.PtbSearch_Click);
            // 
            // SearchBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SearchBarControl";
            this.Size = new System.Drawing.Size(622, 40);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbKeyword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.PictureBox ptbAddKeyword;
    }
}
