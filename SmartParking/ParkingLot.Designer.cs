namespace TeamVaxxers
{
    partial class ParkingLot
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
        private void InitializeComponent()// need settings button and setting page
        {
            this.loadBtn = new System.Windows.Forms.Button();
            //this.button1 = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBtn.Location = new System.Drawing.Point(12, 0);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Read Data";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadData);
            // 
            // button1
            // 
            
            //this.button1.Click += new System.EventHandler(this.DrawSlots);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(613, 559);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(112, 35);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // ParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            //this.Controls.Add(this.button1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.settingsBtn);
            this.Name = "ParkingLot";
            this.Text = "Engine";
            this.Load += new System.EventHandler(this.ParkingLot_Load);
            this.Paint += DrawSlots;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button settingsBtn;
    }
}