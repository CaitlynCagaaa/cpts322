
namespace TeamVaxxers
{
    partial class admin
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
            this.displayBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.removeCarBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.removeBeaconBtn = new System.Windows.Forms.Button();
            this.addBeaconBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.swapBeaconBtn = new System.Windows.Forms.Button();
            this.swapCarBtn = new System.Windows.Forms.Button();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.vScroller = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayBtn.Location = new System.Drawing.Point(258, 116);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(132, 30);
            this.displayBtn.TabIndex = 5;
            this.displayBtn.Text = "Parking Lot Display";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click_1);
            // 
            // addUserBtn
            // 
            this.addUserBtn.ForeColor = System.Drawing.Color.Black;
            this.addUserBtn.Location = new System.Drawing.Point(50, 33);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "add user";
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.ForeColor = System.Drawing.Color.Black;
            this.removeUserBtn.Location = new System.Drawing.Point(50, 81);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(75, 23);
            this.removeUserBtn.TabIndex = 0;
            this.removeUserBtn.Text = "remove user";
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // removeCarBtn
            // 
            this.removeCarBtn.ForeColor = System.Drawing.Color.Black;
            this.removeCarBtn.Location = new System.Drawing.Point(203, 154);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(75, 23);
            this.removeCarBtn.TabIndex = 0;
            this.removeCarBtn.Text = "remove car";
            // 
            // addCarBtn
            // 
            this.addCarBtn.ForeColor = System.Drawing.Color.Black;
            this.addCarBtn.Location = new System.Drawing.Point(437, 200);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 0;
            this.addCarBtn.Text = "add car";
            // 
            // removeBeaconBtn
            // 
            this.removeBeaconBtn.ForeColor = System.Drawing.Color.Black;
            this.removeBeaconBtn.Location = new System.Drawing.Point(315, 154);
            this.removeBeaconBtn.Name = "removeBeaconBtn";
            this.removeBeaconBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBeaconBtn.TabIndex = 0;
            this.removeBeaconBtn.Text = "remove beacon";
            // 
            // addBeaconBtn
            // 
            this.addBeaconBtn.ForeColor = System.Drawing.Color.Black;
            this.addBeaconBtn.Location = new System.Drawing.Point(97, 154);
            this.addBeaconBtn.Name = "addBeaconBtn";
            this.addBeaconBtn.Size = new System.Drawing.Size(75, 23);
            this.addBeaconBtn.TabIndex = 0;
            this.addBeaconBtn.Text = "add Beacon";
            // 
            // modifyBtn
            // 
            this.modifyBtn.ForeColor = System.Drawing.Color.Black;
            this.modifyBtn.Location = new System.Drawing.Point(315, 200);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 0;
            this.modifyBtn.Text = "connect beacon and car";
            // 
            // swapBeaconBtn
            // 
            this.swapBeaconBtn.ForeColor = System.Drawing.Color.Black;
            this.swapBeaconBtn.Location = new System.Drawing.Point(97, 200);
            this.swapBeaconBtn.Name = "swapBeaconBtn";
            this.swapBeaconBtn.Size = new System.Drawing.Size(75, 23);
            this.swapBeaconBtn.TabIndex = 0;
            this.swapBeaconBtn.Text = "swap beacons";
            // 
            // swapCarBtn
            // 
            this.swapCarBtn.ForeColor = System.Drawing.Color.Black;
            this.swapCarBtn.Location = new System.Drawing.Point(203, 200);
            this.swapCarBtn.Name = "swapCarBtn";
            this.swapCarBtn.Size = new System.Drawing.Size(75, 23);
            this.swapCarBtn.TabIndex = 0;
            this.swapCarBtn.Text = "swap cars";
            // 
            // changePassBtn
            // 
            this.changePassBtn.ForeColor = System.Drawing.Color.Black;
            this.changePassBtn.Location = new System.Drawing.Point(50, 35);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(75, 23);
            this.changePassBtn.TabIndex = 0;
            this.changePassBtn.Text = "change password";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.changePassBtn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.addUserBtn);
            this.splitContainer1.Panel2.Controls.Add(this.removeUserBtn);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(774, 348);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Location = new System.Drawing.Point(0, 349);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.swapBeaconBtn);
            this.splitContainer2.Panel1.Controls.Add(this.swapCarBtn);
            this.splitContainer2.Panel1.Controls.Add(this.modifyBtn);
            this.splitContainer2.Panel1.Controls.Add(this.addCarBtn);
            this.splitContainer2.Panel1.Controls.Add(this.addBeaconBtn);
            this.splitContainer2.Panel1.Controls.Add(this.removeCarBtn);
            this.splitContainer2.Panel1.Controls.Add(this.removeBeaconBtn);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.displayBtn);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(774, 452);
            this.splitContainer2.SplitterDistance = 238;
            this.splitContainer2.TabIndex = 6;
            // 
            // vScroller
            // 
            this.vScroller.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScroller.Location = new System.Drawing.Point(0, 0);
            this.vScroller.Name = "vScroller";
            this.vScroller.Size = new System.Drawing.Size(30, 200);
            this.vScroller.TabIndex = 0;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 653);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitContainer2);
            this.Name = "admin";
            this.Text = "Admin settings";
            this.Load += new System.EventHandler(this.admin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.VScrollBar vScroller;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button removeCarBtn;
        private System.Windows.Forms.Button addBeaconBtn;
        private System.Windows.Forms.Button removeBeaconBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button swapCarBtn;
        private System.Windows.Forms.Button swapBeaconBtn;
        private System.Windows.Forms.Button changePassBtn;



        #endregion
    }
}