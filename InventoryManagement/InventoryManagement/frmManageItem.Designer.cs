﻿namespace InventoryManagement
{
    partial class frmManageItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageItem));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxHDD2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxHDD1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxMemory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxProcessor = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxOS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSubType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.txtLifetime = new System.Windows.Forms.TextBox();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLastUpdatedBy = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txtLastUpdatedUser = new System.Windows.Forms.TextBox();
            this.cbxCurrentOwner = new System.Windows.Forms.ComboBox();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 390);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.label21);
            this.pnlMain.Controls.Add(this.label18);
            this.pnlMain.Controls.Add(this.cbxHDD2);
            this.pnlMain.Controls.Add(this.label17);
            this.pnlMain.Controls.Add(this.cbxHDD1);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.cbxMemory);
            this.pnlMain.Controls.Add(this.label14);
            this.pnlMain.Controls.Add(this.cbxProcessor);
            this.pnlMain.Controls.Add(this.label16);
            this.pnlMain.Controls.Add(this.cbxOS);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.txtAssetTag);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtModel);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.cbxBrand);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.cbxSubType);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.cbxType);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.txtDescription);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(716, 347);
            this.pnlMain.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(23, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(665, 50);
            this.label21.TabIndex = 47;
            this.label21.Text = resources.GetString("label21.Text");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(382, 264);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 24);
            this.label18.TabIndex = 46;
            this.label18.Text = "HDD 2";
            // 
            // cbxHDD2
            // 
            this.cbxHDD2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHDD2.FormattingEnabled = true;
            this.cbxHDD2.Location = new System.Drawing.Point(481, 264);
            this.cbxHDD2.Name = "cbxHDD2";
            this.cbxHDD2.Size = new System.Drawing.Size(169, 32);
            this.cbxHDD2.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(382, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 24);
            this.label17.TabIndex = 44;
            this.label17.Text = "HDD 1";
            // 
            // cbxHDD1
            // 
            this.cbxHDD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHDD1.FormattingEnabled = true;
            this.cbxHDD1.Location = new System.Drawing.Point(481, 235);
            this.cbxHDD1.Name = "cbxHDD1";
            this.cbxHDD1.Size = new System.Drawing.Size(169, 32);
            this.cbxHDD1.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "Memory";
            // 
            // cbxMemory
            // 
            this.cbxMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMemory.FormattingEnabled = true;
            this.cbxMemory.Location = new System.Drawing.Point(481, 206);
            this.cbxMemory.Name = "cbxMemory";
            this.cbxMemory.Size = new System.Drawing.Size(169, 32);
            this.cbxMemory.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 24);
            this.label14.TabIndex = 40;
            this.label14.Text = "Processor";
            // 
            // cbxProcessor
            // 
            this.cbxProcessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProcessor.FormattingEnabled = true;
            this.cbxProcessor.Location = new System.Drawing.Point(481, 177);
            this.cbxProcessor.Name = "cbxProcessor";
            this.cbxProcessor.Size = new System.Drawing.Size(169, 32);
            this.cbxProcessor.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(382, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 24);
            this.label16.TabIndex = 38;
            this.label16.Text = "OS";
            // 
            // cbxOS
            // 
            this.cbxOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOS.FormattingEnabled = true;
            this.cbxOS.Location = new System.Drawing.Point(481, 148);
            this.cbxOS.Name = "cbxOS";
            this.cbxOS.Size = new System.Drawing.Size(169, 32);
            this.cbxOS.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Asset Tag";
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(121, 90);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.ReadOnly = true;
            this.txtAssetTag.Size = new System.Drawing.Size(169, 31);
            this.txtAssetTag.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(481, 119);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(169, 31);
            this.txtSerial.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(481, 90);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(169, 31);
            this.txtModel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Brand";
            // 
            // cbxBrand
            // 
            this.cbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(121, 290);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(169, 32);
            this.cbxBrand.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "SubType";
            // 
            // cbxSubType
            // 
            this.cbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubType.FormattingEnabled = true;
            this.cbxSubType.Location = new System.Drawing.Point(121, 261);
            this.cbxSubType.Name = "cbxSubType";
            this.cbxSubType.Size = new System.Drawing.Size(169, 32);
            this.cbxSubType.TabIndex = 11;
            this.cbxSubType.SelectedIndexChanged += new System.EventHandler(this.cbxSubType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(121, 232);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(169, 32);
            this.cbxType.TabIndex = 9;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 31);
            this.txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(121, 148);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 76);
            this.txtDescription.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtPurchasePrice);
            this.panel1.Controls.Add(this.dtpPurchaseDate);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblCurrentValue);
            this.panel1.Controls.Add(this.txtLifetime);
            this.panel1.Controls.Add(this.txtCurrentValue);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(716, 347);
            this.panel1.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(23, 20);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(665, 50);
            this.label19.TabIndex = 43;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 24);
            this.label15.TabIndex = 42;
            this.label15.Text = "Purchase Date";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(148, 113);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(169, 31);
            this.txtPurchasePrice.TabIndex = 35;
            this.txtPurchasePrice.Text = "0";
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(148, 84);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(169, 31);
            this.dtpPurchaseDate.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "Purchase Price";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(23, 174);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(125, 24);
            this.lblCurrentValue.TabIndex = 40;
            this.lblCurrentValue.Text = "Current Value";
            // 
            // txtLifetime
            // 
            this.txtLifetime.Location = new System.Drawing.Point(148, 142);
            this.txtLifetime.Name = "txtLifetime";
            this.txtLifetime.Size = new System.Drawing.Size(169, 31);
            this.txtLifetime.TabIndex = 37;
            this.txtLifetime.Text = "5";
            this.txtLifetime.TextChanged += new System.EventHandler(this.txtLifetime_TextChanged);
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Location = new System.Drawing.Point(148, 171);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(169, 31);
            this.txtCurrentValue.TabIndex = 39;
            this.txtCurrentValue.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 38;
            this.label13.Text = "Lifetime";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(722, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ownership";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblLastUpdatedBy);
            this.panel2.Controls.Add(this.cbxStatus);
            this.panel2.Controls.Add(this.txtLastUpdatedUser);
            this.panel2.Controls.Add(this.cbxCurrentOwner);
            this.panel2.Controls.Add(this.lblLastUpdated);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtLastUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(716, 347);
            this.panel2.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(23, 20);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(668, 50);
            this.label20.TabIndex = 44;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Status";
            // 
            // lblLastUpdatedBy
            // 
            this.lblLastUpdatedBy.AutoSize = true;
            this.lblLastUpdatedBy.Location = new System.Drawing.Point(23, 177);
            this.lblLastUpdatedBy.Name = "lblLastUpdatedBy";
            this.lblLastUpdatedBy.Size = new System.Drawing.Size(108, 24);
            this.lblLastUpdatedBy.TabIndex = 34;
            this.lblLastUpdatedBy.Text = "Updated By";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Enabled = false;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(146, 87);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(169, 32);
            this.cbxStatus.TabIndex = 27;
            // 
            // txtLastUpdatedUser
            // 
            this.txtLastUpdatedUser.Location = new System.Drawing.Point(146, 174);
            this.txtLastUpdatedUser.Name = "txtLastUpdatedUser";
            this.txtLastUpdatedUser.ReadOnly = true;
            this.txtLastUpdatedUser.Size = new System.Drawing.Size(169, 31);
            this.txtLastUpdatedUser.TabIndex = 33;
            // 
            // cbxCurrentOwner
            // 
            this.cbxCurrentOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrentOwner.FormattingEnabled = true;
            this.cbxCurrentOwner.Location = new System.Drawing.Point(146, 116);
            this.cbxCurrentOwner.Name = "cbxCurrentOwner";
            this.cbxCurrentOwner.Size = new System.Drawing.Size(169, 32);
            this.cbxCurrentOwner.TabIndex = 29;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(23, 148);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(121, 24);
            this.lblLastUpdated.TabIndex = 32;
            this.lblLastUpdated.Text = "Last Updated";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Current Owner";
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Location = new System.Drawing.Point(146, 145);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.ReadOnly = true;
            this.txtLastUpdate.Size = new System.Drawing.Size(169, 31);
            this.txtLastUpdate.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(528, 406);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(636, 406);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmManageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmManageItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Item";
            this.Load += new System.EventHandler(this.frmManageItem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSubType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLifetime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblLastUpdatedBy;
        private System.Windows.Forms.TextBox txtLastUpdatedUser;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCurrentOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxHDD2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxHDD1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxMemory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxProcessor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}