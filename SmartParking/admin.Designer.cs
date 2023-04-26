﻿
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
        public void setUser(User currUser)
        {
            current = currUser;
        }
        public void setUsers(Users currUser)
        {
            userList = currUser;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.displayBtn = new System.Windows.Forms.Button();
            this.collCar = new System.Windows.Forms.Button();
            this.collUser = new System.Windows.Forms.Button();
            this.collChange = new System.Windows.Forms.Button();
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
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.addUserBox = new System.Windows.Forms.TextBox();
            this.removeUserBox = new System.Windows.Forms.TextBox();
            this.addPassword = new System.Windows.Forms.TextBox();
            this.ListUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderc1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderc2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderc3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderc4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBeacon = new System.Windows.Forms.TextBox();
            this.addDriver = new System.Windows.Forms.TextBox();
            this.addColor = new System.Windows.Forms.TextBox();
            this.addPlate = new System.Windows.Forms.TextBox();
            this.removeBeacon = new System.Windows.Forms.TextBox();
            this.removePlate = new System.Windows.Forms.TextBox();
            this.conBeacon = new System.Windows.Forms.TextBox();
            this.conCar = new System.Windows.Forms.TextBox();
            this.newCar = new System.Windows.Forms.TextBox();
            this.oldCar = new System.Windows.Forms.TextBox();
            this.newBeacon = new System.Windows.Forms.TextBox();
            this.oldBeacon = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ListCars = new System.Windows.Forms.ListView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.vScroller = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayBtn.Location = new System.Drawing.Point(543, 33);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(132, 30);
            this.displayBtn.TabIndex = 5;
            this.displayBtn.Text = "Parking Lot Display";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click_1);
            // 
            // collCar
            // 
            this.collCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("collCar.BackgroundImage")));
            this.collCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.collCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.collCar.ForeColor = System.Drawing.Color.Black;
            this.collCar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.collCar.Location = new System.Drawing.Point(0, 0);
            this.collCar.Name = "collCar";
            this.collCar.Size = new System.Drawing.Size(1354, 35);
            this.collCar.TabIndex = 0;
            this.collCar.Text = "Cars and Beacons";
            this.collCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.collCar.Click += new System.EventHandler(this.collCar_Click);
            // 
            // collUser
            // 
            this.collUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("collUser.BackgroundImage")));
            this.collUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.collUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.collUser.ForeColor = System.Drawing.Color.Black;
            this.collUser.Location = new System.Drawing.Point(0, 0);
            this.collUser.Name = "collUser";
            this.collUser.Size = new System.Drawing.Size(1354, 33);
            this.collUser.TabIndex = 0;
            this.collUser.Text = "Users";
            this.collUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.collUser.Click += new System.EventHandler(this.collUser_Click);
            // 
            // collChange
            // 
            this.collChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("collChange.BackgroundImage")));
            this.collChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.collChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.collChange.ForeColor = System.Drawing.Color.Black;
            this.collChange.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.collChange.Location = new System.Drawing.Point(0, 0);
            this.collChange.Name = "collChange";
            this.collChange.Size = new System.Drawing.Size(1354, 35);
            this.collChange.TabIndex = 0;
            this.collChange.Text = "Change Password";
            this.collChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.collChange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.collChange.Click += new System.EventHandler(this.collChange_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.ForeColor = System.Drawing.Color.Black;
            this.addUserBtn.Location = new System.Drawing.Point(93, 36);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(96, 23);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "add user";
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.ForeColor = System.Drawing.Color.Black;
            this.removeUserBtn.Location = new System.Drawing.Point(664, 33);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(75, 23);
            this.removeUserBtn.TabIndex = 0;
            this.removeUserBtn.Text = "remove user";
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // removeCarBtn
            // 
            this.removeCarBtn.ForeColor = System.Drawing.Color.Black;
            this.removeCarBtn.Location = new System.Drawing.Point(58, 17);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(114, 23);
            this.removeCarBtn.TabIndex = 0;
            this.removeCarBtn.Text = "remove car";
            this.removeCarBtn.Click += new System.EventHandler(this.removeCarBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.ForeColor = System.Drawing.Color.Black;
            this.addCarBtn.Location = new System.Drawing.Point(58, 59);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(114, 23);
            this.addCarBtn.TabIndex = 0;
            this.addCarBtn.Text = "add car";
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // removeBeaconBtn
            // 
            this.removeBeaconBtn.ForeColor = System.Drawing.Color.Black;
            this.removeBeaconBtn.Location = new System.Drawing.Point(608, 20);
            this.removeBeaconBtn.Name = "removeBeaconBtn";
            this.removeBeaconBtn.Size = new System.Drawing.Size(114, 23);
            this.removeBeaconBtn.TabIndex = 0;
            this.removeBeaconBtn.Text = "remove beacon";
            // 
            // addBeaconBtn
            // 
            this.addBeaconBtn.ForeColor = System.Drawing.Color.Black;
            this.addBeaconBtn.Location = new System.Drawing.Point(608, 62);
            this.addBeaconBtn.Name = "addBeaconBtn";
            this.addBeaconBtn.Size = new System.Drawing.Size(114, 23);
            this.addBeaconBtn.TabIndex = 0;
            this.addBeaconBtn.Text = "add Beacon";
            this.addBeaconBtn.Click += new System.EventHandler(this.addBeaconBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.ForeColor = System.Drawing.Color.Black;
            this.modifyBtn.Location = new System.Drawing.Point(14, 151);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(158, 23);
            this.modifyBtn.TabIndex = 0;
            this.modifyBtn.Text = "connect beacon and car";
            // 
            // swapBeaconBtn
            // 
            this.swapBeaconBtn.ForeColor = System.Drawing.Color.Black;
            this.swapBeaconBtn.Location = new System.Drawing.Point(608, 100);
            this.swapBeaconBtn.Name = "swapBeaconBtn";
            this.swapBeaconBtn.Size = new System.Drawing.Size(114, 23);
            this.swapBeaconBtn.TabIndex = 0;
            this.swapBeaconBtn.Text = "swap beacons";
            // 
            // swapCarBtn
            // 
            this.swapCarBtn.ForeColor = System.Drawing.Color.Black;
            this.swapCarBtn.Location = new System.Drawing.Point(58, 97);
            this.swapCarBtn.Name = "swapCarBtn";
            this.swapCarBtn.Size = new System.Drawing.Size(114, 23);
            this.swapCarBtn.TabIndex = 0;
            this.swapCarBtn.Text = "swap cars";
            // 
            // changePassBtn
            // 
            this.changePassBtn.ForeColor = System.Drawing.Color.Black;
            this.changePassBtn.Location = new System.Drawing.Point(51, 18);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(75, 23);
            this.changePassBtn.TabIndex = 0;
            this.changePassBtn.Text = "change password";
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.collChange);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.changePassBtn);
            this.splitContainer1.Panel2.Controls.Add(this.oldPassword);
            this.splitContainer1.Panel2.Controls.Add(this.newPassword);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 90);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 0;
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(172, 21);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(100, 20);
            this.oldPassword.TabIndex = 1;
            this.oldPassword.Text = "Current Password";
            this.oldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPassword.TextChanged += new System.EventHandler(this.oldPassword_TextChanged);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(342, 18);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(100, 20);
            this.newPassword.TabIndex = 2;
            this.newPassword.Text = "New Password";
            this.newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPassword.TextChanged += new System.EventHandler(this.newPassword_TextChanged);
            // 
            // addUserBox
            // 
            this.addUserBox.Location = new System.Drawing.Point(222, 36);
            this.addUserBox.Name = "addUserBox";
            this.addUserBox.Size = new System.Drawing.Size(100, 20);
            this.addUserBox.TabIndex = 3;
            this.addUserBox.Text = "User\'s username";
            this.addUserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeUserBox
            // 
            this.removeUserBox.Location = new System.Drawing.Point(795, 36);
            this.removeUserBox.Name = "removeUserBox";
            this.removeUserBox.Size = new System.Drawing.Size(100, 20);
            this.removeUserBox.TabIndex = 5;
            this.removeUserBox.Text = "User\'s username";
            this.removeUserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeUserBox.TextChanged += new System.EventHandler(this.removeUserBox_TextChanged);
            // 
            // addPassword
            // 
            this.addPassword.Location = new System.Drawing.Point(357, 36);
            this.addPassword.Name = "addPassword";
            this.addPassword.Size = new System.Drawing.Size(100, 20);
            this.addPassword.TabIndex = 4;
            this.addPassword.Text = "User\'s Password";
            this.addPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPassword.TextChanged += new System.EventHandler(this.addPassword_TextChanged);
            // 
            // ListUsers
            // 
            this.ListUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListUsers.HideSelection = false;
            this.ListUsers.Location = new System.Drawing.Point(342, 90);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(316, 127);
            this.ListUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListUsers.TabIndex = 0;
            this.ListUsers.UseCompatibleStateImageBehavior = false;
            this.ListUsers.View = System.Windows.Forms.View.Details;
            this.ListUsers.SelectedIndexChanged += new System.EventHandler(this.ListUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Level";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeaderc1
            // 
            this.columnHeaderc1.Text = "Owner";
            this.columnHeaderc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderc1.Width = 185;
            // 
            // columnHeaderc2
            // 
            this.columnHeaderc2.Text = "Color";
            this.columnHeaderc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderc2.Width = 308;
            // 
            // columnHeaderc3
            // 
            this.columnHeaderc3.Text = "Plate";
            this.columnHeaderc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderc3.Width = 324;
            // 
            // columnHeaderc4
            // 
            this.columnHeaderc4.Text = "Beacon ID";
            this.columnHeaderc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderc4.Width = 324;
            // 
            // addBeacon
            // 
            this.addBeacon.Location = new System.Drawing.Point(778, 61);
            this.addBeacon.Name = "addBeacon";
            this.addBeacon.Size = new System.Drawing.Size(100, 20);
            this.addBeacon.TabIndex = 6;
            this.addBeacon.Text = "Beacon ID";
            this.addBeacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addDriver
            // 
            this.addDriver.Location = new System.Drawing.Point(205, 62);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(100, 20);
            this.addDriver.TabIndex = 7;
            this.addDriver.Text = "Owner\'s Name";
            this.addDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addColor
            // 
            this.addColor.Location = new System.Drawing.Point(325, 65);
            this.addColor.Name = "addColor";
            this.addColor.Size = new System.Drawing.Size(100, 20);
            this.addColor.TabIndex = 8;
            this.addColor.Text = "Car Color";
            this.addColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPlate
            // 
            this.addPlate.Location = new System.Drawing.Point(446, 65);
            this.addPlate.Name = "addPlate";
            this.addPlate.Size = new System.Drawing.Size(100, 20);
            this.addPlate.TabIndex = 9;
            this.addPlate.Text = "Car\'s Plate Number";
            // 
            // removeBeacon
            // 
            this.removeBeacon.Location = new System.Drawing.Point(778, 23);
            this.removeBeacon.Name = "removeBeacon";
            this.removeBeacon.Size = new System.Drawing.Size(100, 20);
            this.removeBeacon.TabIndex = 10;
            this.removeBeacon.Text = "Beacon ID";
            this.removeBeacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removePlate
            // 
            this.removePlate.Location = new System.Drawing.Point(205, 20);
            this.removePlate.Name = "removePlate";
            this.removePlate.Size = new System.Drawing.Size(100, 20);
            this.removePlate.TabIndex = 11;
            this.removePlate.Text = "Plate Number";
            this.removePlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conBeacon
            // 
            this.conBeacon.Location = new System.Drawing.Point(205, 154);
            this.conBeacon.Name = "conBeacon";
            this.conBeacon.Size = new System.Drawing.Size(100, 20);
            this.conBeacon.TabIndex = 12;
            this.conBeacon.Text = "Beacon ID";
            this.conBeacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conCar
            // 
            this.conCar.Location = new System.Drawing.Point(325, 154);
            this.conCar.Name = "conCar";
            this.conCar.Size = new System.Drawing.Size(100, 20);
            this.conCar.TabIndex = 13;
            this.conCar.Text = "Car\'s Plate Number";
            // 
            // newCar
            // 
            this.newCar.Location = new System.Drawing.Point(205, 100);
            this.newCar.Name = "newCar";
            this.newCar.Size = new System.Drawing.Size(100, 20);
            this.newCar.TabIndex = 14;
            this.newCar.Text = "Car\'s Plate";
            this.newCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldCar
            // 
            this.oldCar.Location = new System.Drawing.Point(325, 103);
            this.oldCar.Name = "oldCar";
            this.oldCar.Size = new System.Drawing.Size(100, 20);
            this.oldCar.TabIndex = 15;
            this.oldCar.Text = " Other Car\'s Plate";
            this.oldCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newBeacon
            // 
            this.newBeacon.Location = new System.Drawing.Point(778, 102);
            this.newBeacon.Name = "newBeacon";
            this.newBeacon.Size = new System.Drawing.Size(100, 20);
            this.newBeacon.TabIndex = 16;
            this.newBeacon.Text = "Beacon\'s ID";
            this.newBeacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldBeacon
            // 
            this.oldBeacon.Location = new System.Drawing.Point(922, 103);
            this.oldBeacon.Name = "oldBeacon";
            this.oldBeacon.Size = new System.Drawing.Size(100, 20);
            this.oldBeacon.TabIndex = 17;
            this.oldBeacon.Text = "Other Beacon\'s ID";
            this.oldBeacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldBeacon.TextChanged += new System.EventHandler(this.oldBeacon_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 90);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.collUser);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.addUserBtn);
            this.splitContainer2.Panel2.Controls.Add(this.removeUserBtn);
            this.splitContainer2.Panel2.Controls.Add(this.addUserBox);
            this.splitContainer2.Panel2.Controls.Add(this.removeUserBox);
            this.splitContainer2.Panel2.Controls.Add(this.addPassword);
            this.splitContainer2.Panel2.Controls.Add(this.ListUsers);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1354, 258);
            this.splitContainer2.SplitterDistance = 31;
            this.splitContainer2.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Location = new System.Drawing.Point(0, 348);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.collCar);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.swapBeaconBtn);
            this.splitContainer3.Panel2.Controls.Add(this.ListCars);
            this.splitContainer3.Panel2.Controls.Add(this.swapCarBtn);
            this.splitContainer3.Panel2.Controls.Add(this.modifyBtn);
            this.splitContainer3.Panel2.Controls.Add(this.oldBeacon);
            this.splitContainer3.Panel2.Controls.Add(this.newBeacon);
            this.splitContainer3.Panel2.Controls.Add(this.oldCar);
            this.splitContainer3.Panel2.Controls.Add(this.newCar);
            this.splitContainer3.Panel2.Controls.Add(this.conCar);
            this.splitContainer3.Panel2.Controls.Add(this.conBeacon);
            this.splitContainer3.Panel2.Controls.Add(this.removePlate);
            this.splitContainer3.Panel2.Controls.Add(this.removeBeacon);
            this.splitContainer3.Panel2.Controls.Add(this.addPlate);
            this.splitContainer3.Panel2.Controls.Add(this.addColor);
            this.splitContainer3.Panel2.Controls.Add(this.addDriver);
            this.splitContainer3.Panel2.Controls.Add(this.addBeacon);
            this.splitContainer3.Panel2.Controls.Add(this.addCarBtn);
            this.splitContainer3.Panel2.Controls.Add(this.addBeaconBtn);
            this.splitContainer3.Panel2.Controls.Add(this.removeCarBtn);
            this.splitContainer3.Panel2.Controls.Add(this.removeBeaconBtn);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(1354, 371);
            this.splitContainer3.SplitterDistance = 37;
            this.splitContainer3.TabIndex = 0;
            // 
            // ListCars
            // 
            this.ListCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderc1,
            this.columnHeaderc2,
            this.columnHeaderc3,
            this.columnHeaderc4});
            this.ListCars.HideSelection = false;
            this.ListCars.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ListCars.Location = new System.Drawing.Point(70, 180);
            this.ListCars.Name = "ListCars";
            this.ListCars.Size = new System.Drawing.Size(1145, 144);
            this.ListCars.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListCars.TabIndex = 0;
            this.ListCars.UseCompatibleStateImageBehavior = false;
            this.ListCars.View = System.Windows.Forms.View.Details;
            this.ListCars.SelectedIndexChanged += new System.EventHandler(this.ListCars_SelectedIndexChanged);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer4.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Location = new System.Drawing.Point(0, 719);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.displayBtn);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Size = new System.Drawing.Size(1354, 94);
            this.splitContainer4.SplitterDistance = 69;
            this.splitContainer4.TabIndex = 6;
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
            this.ClientSize = new System.Drawing.Size(1371, 653);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "admin";
            this.Text = "Admin settings";
            this.Load += new System.EventHandler(this.admin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button collChange;
        private System.Windows.Forms.Button collUser;
        private System.Windows.Forms.Button collCar;
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
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox addPassword;
        private System.Windows.Forms.TextBox addUserBox;
        private System.Windows.Forms.TextBox removeUserBox;
        private System.Windows.Forms.TextBox addPlate;
        private System.Windows.Forms.TextBox addColor;
        private System.Windows.Forms.TextBox addDriver;
        private System.Windows.Forms.TextBox removePlate;
        private System.Windows.Forms.TextBox addBeacon;
        private System.Windows.Forms.TextBox removeBeacon;
        private System.Windows.Forms.TextBox oldBeacon;
        private System.Windows.Forms.TextBox newBeacon;
        private System.Windows.Forms.TextBox oldCar;
        private System.Windows.Forms.TextBox newCar;
        private System.Windows.Forms.TextBox conCar;
        private System.Windows.Forms.TextBox conBeacon;
        private System.Windows.Forms.ListView ListUsers;
        private System.Windows.Forms.ListView ListCars;












        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeaderc1;
        private System.Windows.Forms.ColumnHeader columnHeaderc2;
        private System.Windows.Forms.ColumnHeader columnHeaderc3;
        private System.Windows.Forms.ColumnHeader columnHeaderc4;
        


    }
}