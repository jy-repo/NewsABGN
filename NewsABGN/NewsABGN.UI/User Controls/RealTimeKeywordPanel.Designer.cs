namespace NewsABGN.UI.User_Controls
{
    partial class RealTimeKeywordPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKeywordA = new System.Windows.Forms.Label();
            this.lblKeywordB = new System.Windows.Forms.Label();
            this.lblKeywordC = new System.Windows.Forms.Label();
            this.lblKeywordD = new System.Windows.Forms.Label();
            this.lblKeywordE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLastUpdateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "실시간 키워드";
            // 
            // lblKeywordA
            // 
            this.lblKeywordA.AutoSize = true;
            this.lblKeywordA.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordA.Location = new System.Drawing.Point(23, 60);
            this.lblKeywordA.Name = "lblKeywordA";
            this.lblKeywordA.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordA.TabIndex = 1;
            this.lblKeywordA.Text = "1   a";
            // 
            // lblKeywordB
            // 
            this.lblKeywordB.AutoSize = true;
            this.lblKeywordB.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordB.Location = new System.Drawing.Point(23, 100);
            this.lblKeywordB.Name = "lblKeywordB";
            this.lblKeywordB.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordB.TabIndex = 2;
            this.lblKeywordB.Text = "2   a";
            // 
            // lblKeywordC
            // 
            this.lblKeywordC.AutoSize = true;
            this.lblKeywordC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordC.Location = new System.Drawing.Point(23, 140);
            this.lblKeywordC.Name = "lblKeywordC";
            this.lblKeywordC.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordC.TabIndex = 3;
            this.lblKeywordC.Text = "3   a";
            // 
            // lblKeywordD
            // 
            this.lblKeywordD.AutoSize = true;
            this.lblKeywordD.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordD.Location = new System.Drawing.Point(23, 180);
            this.lblKeywordD.Name = "lblKeywordD";
            this.lblKeywordD.Size = new System.Drawing.Size(41, 16);
            this.lblKeywordD.TabIndex = 4;
            this.lblKeywordD.Text = "4   a";
            // 
            // lblKeywordE
            // 
            this.lblKeywordE.AutoSize = true;
            this.lblKeywordE.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordE.Location = new System.Drawing.Point(23, 220);
            this.lblKeywordE.Name = "lblKeywordE";
            this.lblKeywordE.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordE.TabIndex = 5;
            this.lblKeywordE.Text = "5   a";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewsABGN.UI.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(199, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Refresh_Clicked);
            // 
            // lblLastUpdateTime
            // 
            this.lblLastUpdateTime.AutoSize = true;
            this.lblLastUpdateTime.Font = new System.Drawing.Font("Gulim", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLastUpdateTime.Location = new System.Drawing.Point(24, 284);
            this.lblLastUpdateTime.Name = "lblLastUpdateTime";
            this.lblLastUpdateTime.Size = new System.Drawing.Size(93, 11);
            this.lblLastUpdateTime.TabIndex = 7;
            this.lblLastUpdateTime.Text = "마지막 업데이트: ";
            // 
            // RealTimeKeywordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLastUpdateTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKeywordE);
            this.Controls.Add(this.lblKeywordD);
            this.Controls.Add(this.lblKeywordC);
            this.Controls.Add(this.lblKeywordB);
            this.Controls.Add(this.lblKeywordA);
            this.Controls.Add(this.label1);
            this.Name = "RealTimeKeywordPanel";
            this.Size = new System.Drawing.Size(265, 344);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKeywordA;
        private System.Windows.Forms.Label lblKeywordB;
        private System.Windows.Forms.Label lblKeywordC;
        private System.Windows.Forms.Label lblKeywordD;
        private System.Windows.Forms.Label lblKeywordE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLastUpdateTime;
    }
}
