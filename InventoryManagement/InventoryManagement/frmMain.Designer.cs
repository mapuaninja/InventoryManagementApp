﻿namespace InventoryManagement
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.imgMainImage = new System.Windows.Forms.ImageList(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chkShowAllLocation = new System.Windows.Forms.CheckBox();
            this.chkShowAllSubType = new System.Windows.Forms.CheckBox();
            this.chkShowAllType = new System.Windows.Forms.CheckBox();
            this.chkShowAllStatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSubtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.pnlRightInfo = new System.Windows.Forms.Panel();
            this.pnlRightContent = new System.Windows.Forms.Panel();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblLifeSpan = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDatePurchase = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSubType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlRightInfo.SuspendLayout();
            this.pnlRightContent.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvMain);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(836, 601);
            this.pnlMain.TabIndex = 3;
            // 
            // lvMain
            // 
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.LargeImageList = this.imgMainImage;
            this.lvMain.Location = new System.Drawing.Point(5, 77);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(826, 519);
            this.lvMain.SmallImageList = this.imgMainImage;
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
            // 
            // imgMainImage
            // 
            this.imgMainImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMainImage.ImageStream")));
            this.imgMainImage.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMainImage.Images.SetKeyName(0, "Desktop-My-Computer-icon.png");
            this.imgMainImage.Images.SetKeyName(1, "Extras-Unlock-icon.png");
            this.imgMainImage.Images.SetKeyName(2, "Drives-RAM-Drive-icon.png");
            this.imgMainImage.Images.SetKeyName(3, "Extras-Battery-icon.png");
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.chkShowAllLocation);
            this.pnlTop.Controls.Add(this.chkShowAllSubType);
            this.pnlTop.Controls.Add(this.chkShowAllType);
            this.pnlTop.Controls.Add(this.chkShowAllStatus);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.cbxLocation);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.cbxSubtype);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.cbxType);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.cbxStatus);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(826, 72);
            this.pnlTop.TabIndex = 1;
            // 
            // chkShowAllLocation
            // 
            this.chkShowAllLocation.AutoSize = true;
            this.chkShowAllLocation.Checked = true;
            this.chkShowAllLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllLocation.Location = new System.Drawing.Point(600, 40);
            this.chkShowAllLocation.Name = "chkShowAllLocation";
            this.chkShowAllLocation.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllLocation.TabIndex = 46;
            this.chkShowAllLocation.Text = "Show All";
            this.chkShowAllLocation.UseVisualStyleBackColor = true;
            this.chkShowAllLocation.CheckedChanged += new System.EventHandler(this.chkShowAllLocation_CheckedChanged);
            // 
            // chkShowAllSubType
            // 
            this.chkShowAllSubType.AutoSize = true;
            this.chkShowAllSubType.Checked = true;
            this.chkShowAllSubType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllSubType.Location = new System.Drawing.Point(414, 40);
            this.chkShowAllSubType.Name = "chkShowAllSubType";
            this.chkShowAllSubType.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllSubType.TabIndex = 45;
            this.chkShowAllSubType.Text = "Show All";
            this.chkShowAllSubType.UseVisualStyleBackColor = true;
            this.chkShowAllSubType.CheckedChanged += new System.EventHandler(this.chkShowAllSubType_CheckedChanged);
            // 
            // chkShowAllType
            // 
            this.chkShowAllType.AutoSize = true;
            this.chkShowAllType.Checked = true;
            this.chkShowAllType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllType.Location = new System.Drawing.Point(226, 40);
            this.chkShowAllType.Name = "chkShowAllType";
            this.chkShowAllType.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllType.TabIndex = 44;
            this.chkShowAllType.Text = "Show All";
            this.chkShowAllType.UseVisualStyleBackColor = true;
            this.chkShowAllType.CheckedChanged += new System.EventHandler(this.chkShowAllType_CheckedChanged);
            // 
            // chkShowAllStatus
            // 
            this.chkShowAllStatus.AutoSize = true;
            this.chkShowAllStatus.Checked = true;
            this.chkShowAllStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllStatus.Location = new System.Drawing.Point(62, 40);
            this.chkShowAllStatus.Name = "chkShowAllStatus";
            this.chkShowAllStatus.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllStatus.TabIndex = 43;
            this.chkShowAllStatus.Text = "Show All";
            this.chkShowAllStatus.UseVisualStyleBackColor = true;
            this.chkShowAllStatus.CheckedChanged += new System.EventHandler(this.chkShowAllStatus_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Location";
            // 
            // cbxLocation
            // 
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(600, 11);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(121, 23);
            this.cbxLocation.TabIndex = 41;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sub-Type";
            // 
            // cbxSubtype
            // 
            this.cbxSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubtype.FormattingEnabled = true;
            this.cbxSubtype.Location = new System.Drawing.Point(414, 11);
            this.cbxSubtype.Name = "cbxSubtype";
            this.cbxSubtype.Size = new System.Drawing.Size(121, 23);
            this.cbxSubtype.TabIndex = 39;
            this.cbxSubtype.SelectedIndexChanged += new System.EventHandler(this.cbxSubtype_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(226, 11);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 23);
            this.cbxType.TabIndex = 37;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(62, 11);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 0;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // pnlRightInfo
            // 
            this.pnlRightInfo.Controls.Add(this.pnlRightContent);
            this.pnlRightInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightInfo.Location = new System.Drawing.Point(836, 24);
            this.pnlRightInfo.Name = "pnlRightInfo";
            this.pnlRightInfo.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.pnlRightInfo.Size = new System.Drawing.Size(315, 601);
            this.pnlRightInfo.TabIndex = 2;
            // 
            // pnlRightContent
            // 
            this.pnlRightContent.BackColor = System.Drawing.Color.White;
            this.pnlRightContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightContent.Controls.Add(this.lblCurrentValue);
            this.pnlRightContent.Controls.Add(this.label35);
            this.pnlRightContent.Controls.Add(this.lblLifeSpan);
            this.pnlRightContent.Controls.Add(this.label28);
            this.pnlRightContent.Controls.Add(this.lblAmount);
            this.pnlRightContent.Controls.Add(this.label30);
            this.pnlRightContent.Controls.Add(this.lblDatePurchase);
            this.pnlRightContent.Controls.Add(this.label32);
            this.pnlRightContent.Controls.Add(this.label33);
            this.pnlRightContent.Controls.Add(this.lblLastUpdate);
            this.pnlRightContent.Controls.Add(this.label26);
            this.pnlRightContent.Controls.Add(this.lblOwner);
            this.pnlRightContent.Controls.Add(this.label24);
            this.pnlRightContent.Controls.Add(this.lblStatus);
            this.pnlRightContent.Controls.Add(this.label22);
            this.pnlRightContent.Controls.Add(this.label20);
            this.pnlRightContent.Controls.Add(this.label19);
            this.pnlRightContent.Controls.Add(this.lblSerial);
            this.pnlRightContent.Controls.Add(this.label18);
            this.pnlRightContent.Controls.Add(this.lblModel);
            this.pnlRightContent.Controls.Add(this.label16);
            this.pnlRightContent.Controls.Add(this.lblBrand);
            this.pnlRightContent.Controls.Add(this.label14);
            this.pnlRightContent.Controls.Add(this.lblSubType);
            this.pnlRightContent.Controls.Add(this.label12);
            this.pnlRightContent.Controls.Add(this.lblType);
            this.pnlRightContent.Controls.Add(this.label10);
            this.pnlRightContent.Controls.Add(this.lblDescription);
            this.pnlRightContent.Controls.Add(this.label8);
            this.pnlRightContent.Controls.Add(this.lblName);
            this.pnlRightContent.Controls.Add(this.label6);
            this.pnlRightContent.Controls.Add(this.lblAssetTag);
            this.pnlRightContent.Controls.Add(this.label4);
            this.pnlRightContent.Controls.Add(this.lblId);
            this.pnlRightContent.Controls.Add(this.label1);
            this.pnlRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContent.Location = new System.Drawing.Point(0, 5);
            this.pnlRightContent.Name = "pnlRightContent";
            this.pnlRightContent.Size = new System.Drawing.Size(310, 591);
            this.pnlRightContent.TabIndex = 0;
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.Location = new System.Drawing.Point(114, 373);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(174, 15);
            this.lblCurrentValue.TabIndex = 34;
            this.lblCurrentValue.Text = "-";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(22, 373);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 15);
            this.label35.TabIndex = 33;
            this.label35.Text = "Current Value";
            // 
            // lblLifeSpan
            // 
            this.lblLifeSpan.Location = new System.Drawing.Point(114, 358);
            this.lblLifeSpan.Name = "lblLifeSpan";
            this.lblLifeSpan.Size = new System.Drawing.Size(174, 15);
            this.lblLifeSpan.TabIndex = 32;
            this.lblLifeSpan.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 358);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 15);
            this.label28.TabIndex = 31;
            this.label28.Text = "LifeSpan";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(114, 343);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(174, 15);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(22, 343);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 15);
            this.label30.TabIndex = 29;
            this.label30.Text = "Amount";
            // 
            // lblDatePurchase
            // 
            this.lblDatePurchase.Location = new System.Drawing.Point(114, 328);
            this.lblDatePurchase.Name = "lblDatePurchase";
            this.lblDatePurchase.Size = new System.Drawing.Size(174, 15);
            this.lblDatePurchase.TabIndex = 28;
            this.lblDatePurchase.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(22, 328);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 15);
            this.label32.TabIndex = 27;
            this.label32.Text = "Date Purchase";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(22, 293);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label33.Size = new System.Drawing.Size(71, 35);
            this.label33.TabIndex = 26;
            this.label33.Text = "ITEM VALUE";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Location = new System.Drawing.Point(114, 278);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(174, 15);
            this.lblLastUpdate.TabIndex = 25;
            this.lblLastUpdate.Text = "-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 278);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 15);
            this.label26.TabIndex = 24;
            this.label26.Text = "Last Update";
            // 
            // lblOwner
            // 
            this.lblOwner.Location = new System.Drawing.Point(114, 263);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(174, 15);
            this.lblOwner.TabIndex = 23;
            this.lblOwner.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 263);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 15);
            this.label24.TabIndex = 22;
            this.label24.Text = "Owner";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(114, 248);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(174, 15);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 248);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 15);
            this.label22.TabIndex = 20;
            this.label22.Text = "Status";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 213);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label20.Size = new System.Drawing.Size(74, 35);
            this.label20.TabIndex = 19;
            this.label20.Text = "ITEM STATUS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 16);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label19.Size = new System.Drawing.Size(78, 25);
            this.label19.TabIndex = 18;
            this.label19.Text = "ITEM DETAILS";
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(114, 198);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(174, 15);
            this.lblSerial.TabIndex = 17;
            this.lblSerial.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "Serial";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(114, 183);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(167, 15);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Model";
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(114, 168);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(167, 15);
            this.lblBrand.TabIndex = 13;
            this.lblBrand.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Brand";
            // 
            // lblSubType
            // 
            this.lblSubType.Location = new System.Drawing.Point(114, 153);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(167, 15);
            this.lblSubType.TabIndex = 11;
            this.lblSubType.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sub-Type";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(114, 138);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(167, 15);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(114, 86);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 52);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(114, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.Location = new System.Drawing.Point(114, 56);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(167, 15);
            this.lblAssetTag.TabIndex = 3;
            this.lblAssetTag.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Asset Tag";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(114, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(167, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1151, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUsername
            // 
            this.tssUsername.Name = "tssUsername";
            this.tssUsername.Size = new System.Drawing.Size(84, 17);
            this.tssUsername.Text = "Current User []";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1151, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1151, 647);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRightInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlRightInfo.ResumeLayout(false);
            this.pnlRightContent.ResumeLayout(false);
            this.pnlRightContent.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUsername;
        private System.Windows.Forms.Panel pnlRightInfo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ImageList imgMainImage;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRightContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblLifeSpan;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDatePurchase;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSubtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.CheckBox chkShowAllLocation;
        private System.Windows.Forms.CheckBox chkShowAllSubType;
        private System.Windows.Forms.CheckBox chkShowAllType;
        private System.Windows.Forms.CheckBox chkShowAllStatus;
    }
}

