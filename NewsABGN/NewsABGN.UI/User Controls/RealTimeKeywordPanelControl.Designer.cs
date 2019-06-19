namespace NewsABGN.UI.User_Controls
{
    partial class RealTimeKeywordPanelControl
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
            this.lblLastUpdateTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblKeywordNumberA = new System.Windows.Forms.Label();
            this.lblKeywordNumberB = new System.Windows.Forms.Label();
            this.lblKeywordNumberC = new System.Windows.Forms.Label();
            this.lblKeywordNumberD = new System.Windows.Forms.Label();
            this.lblKeywordNumberE = new System.Windows.Forms.Label();
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
            this.lblKeywordA.Location = new System.Drawing.Point(65, 59);
            this.lblKeywordA.Name = "lblKeywordA";
            this.lblKeywordA.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordA.TabIndex = 1;
            this.lblKeywordA.Text = "1   a";
            this.lblKeywordA.Click += new System.EventHandler(this.Keyword_Click);
            // 
            // lblKeywordB
            // 
            this.lblKeywordB.AutoSize = true;
            this.lblKeywordB.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordB.Location = new System.Drawing.Point(64, 100);
            this.lblKeywordB.Name = "lblKeywordB";
            this.lblKeywordB.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordB.TabIndex = 2;
            this.lblKeywordB.Text = "2   a";
            this.lblKeywordB.Click += new System.EventHandler(this.Keyword_Click);
            // 
            // lblKeywordC
            // 
            this.lblKeywordC.AutoSize = true;
            this.lblKeywordC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordC.Location = new System.Drawing.Point(64, 140);
            this.lblKeywordC.Name = "lblKeywordC";
            this.lblKeywordC.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordC.TabIndex = 3;
            this.lblKeywordC.Text = "3   a";
            this.lblKeywordC.Click += new System.EventHandler(this.Keyword_Click);
            // 
            // lblKeywordD
            // 
            this.lblKeywordD.AutoSize = true;
            this.lblKeywordD.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordD.Location = new System.Drawing.Point(64, 180);
            this.lblKeywordD.Name = "lblKeywordD";
            this.lblKeywordD.Size = new System.Drawing.Size(41, 16);
            this.lblKeywordD.TabIndex = 4;
            this.lblKeywordD.Text = "4   a";
            this.lblKeywordD.Click += new System.EventHandler(this.Keyword_Click);
            // 
            // lblKeywordE
            // 
            this.lblKeywordE.AutoSize = true;
            this.lblKeywordE.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordE.Location = new System.Drawing.Point(64, 220);
            this.lblKeywordE.Name = "lblKeywordE";
            this.lblKeywordE.Size = new System.Drawing.Size(40, 16);
            this.lblKeywordE.TabIndex = 5;
            this.lblKeywordE.Text = "5   a";
            this.lblKeywordE.Click += new System.EventHandler(this.Keyword_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewsABGN.UI.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(191, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // lblPrev
            // 
            this.lblPrev.AutoSize = true;
            this.lblPrev.Location = new System.Drawing.Point(24, 257);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(29, 12);
            this.lblPrev.TabIndex = 8;
            this.lblPrev.Text = "<<<";
            this.lblPrev.Click += new System.EventHandler(this.LblPrev_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(191, 257);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(29, 12);
            this.lblNext.TabIndex = 9;
            this.lblNext.Text = ">>>";
            this.lblNext.Click += new System.EventHandler(this.LblNext_Click);
            // 
            // lblKeywordNumberA
            // 
            this.lblKeywordNumberA.AutoSize = true;
            this.lblKeywordNumberA.Location = new System.Drawing.Point(29, 61);
            this.lblKeywordNumberA.Name = "lblKeywordNumberA";
            this.lblKeywordNumberA.Size = new System.Drawing.Size(38, 12);
            this.lblKeywordNumberA.TabIndex = 10;
            this.lblKeywordNumberA.Text = "label2";
            // 
            // lblKeywordNumberB
            // 
            this.lblKeywordNumberB.AutoSize = true;
            this.lblKeywordNumberB.Location = new System.Drawing.Point(29, 102);
            this.lblKeywordNumberB.Name = "lblKeywordNumberB";
            this.lblKeywordNumberB.Size = new System.Drawing.Size(38, 12);
            this.lblKeywordNumberB.TabIndex = 11;
            this.lblKeywordNumberB.Text = "label3";
            // 
            // lblKeywordNumberC
            // 
            this.lblKeywordNumberC.AutoSize = true;
            this.lblKeywordNumberC.Location = new System.Drawing.Point(29, 143);
            this.lblKeywordNumberC.Name = "lblKeywordNumberC";
            this.lblKeywordNumberC.Size = new System.Drawing.Size(38, 12);
            this.lblKeywordNumberC.TabIndex = 12;
            this.lblKeywordNumberC.Text = "label4";
            // 
            // lblKeywordNumberD
            // 
            this.lblKeywordNumberD.AutoSize = true;
            this.lblKeywordNumberD.Location = new System.Drawing.Point(29, 183);
            this.lblKeywordNumberD.Name = "lblKeywordNumberD";
            this.lblKeywordNumberD.Size = new System.Drawing.Size(38, 12);
            this.lblKeywordNumberD.TabIndex = 13;
            this.lblKeywordNumberD.Text = "label5";
            // 
            // lblKeywordNumberE
            // 
            this.lblKeywordNumberE.AutoSize = true;
            this.lblKeywordNumberE.Location = new System.Drawing.Point(29, 223);
            this.lblKeywordNumberE.Name = "lblKeywordNumberE";
            this.lblKeywordNumberE.Size = new System.Drawing.Size(38, 12);
            this.lblKeywordNumberE.TabIndex = 14;
            this.lblKeywordNumberE.Text = "label6";
            // 
            // RealTimeKeywordPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKeywordNumberE);
            this.Controls.Add(this.lblKeywordNumberD);
            this.Controls.Add(this.lblKeywordNumberC);
            this.Controls.Add(this.lblKeywordNumberB);
            this.Controls.Add(this.lblKeywordNumberA);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblPrev);
            this.Controls.Add(this.lblLastUpdateTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKeywordE);
            this.Controls.Add(this.lblKeywordD);
            this.Controls.Add(this.lblKeywordC);
            this.Controls.Add(this.lblKeywordB);
            this.Controls.Add(this.lblKeywordA);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(225, 340);
            this.Name = "RealTimeKeywordPanelControl";
            this.Size = new System.Drawing.Size(225, 344);
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
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblKeywordNumberA;
        private System.Windows.Forms.Label lblKeywordNumberB;
        private System.Windows.Forms.Label lblKeywordNumberC;
        private System.Windows.Forms.Label lblKeywordNumberD;
        private System.Windows.Forms.Label lblKeywordNumberE;
    }
}
