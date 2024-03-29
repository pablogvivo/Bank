﻿namespace Bank
{
    partial class Main
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btTransfer = new System.Windows.Forms.Button();
            this.btDeposit = new System.Windows.Forms.Button();
            this.btCreateClient = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbCreate = new System.Windows.Forms.TabPage();
            this.btCreateMake = new System.Windows.Forms.Button();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tbDeposit = new System.Windows.Forms.TabPage();
            this.CBDepIBAN = new System.Windows.Forms.ComboBox();
            this.btDepMake = new System.Windows.Forms.Button();
            this.lblDepMoney = new System.Windows.Forms.Label();
            this.lblDepIBAN = new System.Windows.Forms.Label();
            this.txtDepMoney = new System.Windows.Forms.TextBox();
            this.txtDepIBAN = new System.Windows.Forms.TextBox();
            this.tbTransfer = new System.Windows.Forms.TabPage();
            this.btTransferMake = new System.Windows.Forms.Button();
            this.lblTransMoney = new System.Windows.Forms.Label();
            this.txtTransMoney = new System.Windows.Forms.TextBox();
            this.lblIBANRecv = new System.Windows.Forms.Label();
            this.txtIBANRecv = new System.Windows.Forms.TextBox();
            this.lblIBANSend = new System.Windows.Forms.Label();
            this.txtIBANSend = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.CBSendIBAN = new System.Windows.Forms.ComboBox();
            this.CBRecvIBAN = new System.Windows.Forms.ComboBox();
            this.tbTrans = new System.Windows.Forms.TabPage();
            this.btTransaction = new System.Windows.Forms.Button();
            this.CBTransaction = new System.Windows.Forms.ComboBox();
            this.DTTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbMain.SuspendLayout();
            this.tbCreate.SuspendLayout();
            this.tbDeposit.SuspendLayout();
            this.tbTransfer.SuspendLayout();
            this.tbTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btTransfer);
            this.splitContainer1.Panel1.Controls.Add(this.btDeposit);
            this.splitContainer1.Panel1.Controls.Add(this.btCreateClient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.tbMain);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(723, 371);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::Bank.Properties.Resources.Logo_green;
            this.pictureBox1.Location = new System.Drawing.Point(0, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.pictureBox1.Size = new System.Drawing.Size(153, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btTransfer
            // 
            this.btTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.btTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransfer.Location = new System.Drawing.Point(0, 100);
            this.btTransfer.Name = "btTransfer";
            this.btTransfer.Size = new System.Drawing.Size(153, 50);
            this.btTransfer.TabIndex = 2;
            this.btTransfer.Text = "TRANSFER";
            this.btTransfer.UseVisualStyleBackColor = false;
            this.btTransfer.Click += new System.EventHandler(this.BtTransfer_Click);
            // 
            // btDeposit
            // 
            this.btDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeposit.Location = new System.Drawing.Point(0, 50);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(153, 50);
            this.btDeposit.TabIndex = 1;
            this.btDeposit.Text = "DEPOSIT";
            this.btDeposit.UseVisualStyleBackColor = false;
            this.btDeposit.Click += new System.EventHandler(this.BtDeposit_Click);
            // 
            // btCreateClient
            // 
            this.btCreateClient.BackColor = System.Drawing.SystemColors.Control;
            this.btCreateClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateClient.Location = new System.Drawing.Point(0, 0);
            this.btCreateClient.Name = "btCreateClient";
            this.btCreateClient.Size = new System.Drawing.Size(153, 50);
            this.btCreateClient.TabIndex = 0;
            this.btCreateClient.Text = "CREATE CLIENT";
            this.btCreateClient.UseVisualStyleBackColor = false;
            this.btCreateClient.Click += new System.EventHandler(this.BtCreateClient_Click);
            // 
            // tbMain
            // 
            this.tbMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbMain.Controls.Add(this.tbCreate);
            this.tbMain.Controls.Add(this.tbDeposit);
            this.tbMain.Controls.Add(this.tbTransfer);
            this.tbMain.Controls.Add(this.tbTrans);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(566, 371);
            this.tbMain.TabIndex = 0;
            // 
            // tbCreate
            // 
            this.tbCreate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbCreate.Controls.Add(this.btCreateMake);
            this.tbCreate.Controls.Add(this.lblIBAN);
            this.tbCreate.Controls.Add(this.lblEmail);
            this.tbCreate.Controls.Add(this.lblTelephone);
            this.tbCreate.Controls.Add(this.lblSurname);
            this.tbCreate.Controls.Add(this.lblName);
            this.tbCreate.Controls.Add(this.txtIBAN);
            this.tbCreate.Controls.Add(this.txtEmail);
            this.tbCreate.Controls.Add(this.txtTelephone);
            this.tbCreate.Controls.Add(this.txtSurname);
            this.tbCreate.Controls.Add(this.txtName);
            this.tbCreate.Location = new System.Drawing.Point(4, 5);
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreate.Size = new System.Drawing.Size(558, 362);
            this.tbCreate.TabIndex = 0;
            this.tbCreate.Text = "tabPage1";
            // 
            // btCreateMake
            // 
            this.btCreateMake.Location = new System.Drawing.Point(314, 261);
            this.btCreateMake.Name = "btCreateMake";
            this.btCreateMake.Size = new System.Drawing.Size(199, 46);
            this.btCreateMake.TabIndex = 10;
            this.btCreateMake.Text = "CREATE";
            this.btCreateMake.UseVisualStyleBackColor = true;
            this.btCreateMake.Click += new System.EventHandler(this.BtCreateMake_Click);
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(30, 164);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(47, 20);
            this.lblIBAN.TabIndex = 9;
            this.lblIBAN.Text = "IBAN";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(30, 91);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 20);
            this.lblTelephone.TabIndex = 7;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(30, 54);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(150, 161);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(363, 26);
            this.txtIBAN.TabIndex = 4;
            this.txtIBAN.TextChanged += new System.EventHandler(this.TxtIBAN_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 26);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(150, 88);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(363, 26);
            this.txtTelephone.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(150, 51);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(363, 26);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.TxtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // tbDeposit
            // 
            this.tbDeposit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDeposit.Controls.Add(this.CBDepIBAN);
            this.tbDeposit.Controls.Add(this.btDepMake);
            this.tbDeposit.Controls.Add(this.lblDepMoney);
            this.tbDeposit.Controls.Add(this.lblDepIBAN);
            this.tbDeposit.Controls.Add(this.txtDepMoney);
            this.tbDeposit.Controls.Add(this.txtDepIBAN);
            this.tbDeposit.Location = new System.Drawing.Point(4, 5);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeposit.Size = new System.Drawing.Size(558, 362);
            this.tbDeposit.TabIndex = 1;
            this.tbDeposit.Text = "tabPage2";
            // 
            // CBDepIBAN
            // 
            this.CBDepIBAN.FormattingEnabled = true;
            this.CBDepIBAN.Location = new System.Drawing.Point(150, 14);
            this.CBDepIBAN.Name = "CBDepIBAN";
            this.CBDepIBAN.Size = new System.Drawing.Size(363, 28);
            this.CBDepIBAN.TabIndex = 5;
            this.CBDepIBAN.DropDown += new System.EventHandler(this.CBDepIBAN_DropDown);
            this.CBDepIBAN.SelectedIndexChanged += new System.EventHandler(this.CBDepIBAN_SelectedIndexChanged);
            this.CBDepIBAN.Click += new System.EventHandler(this.CBDepIBAN_Click);
            // 
            // btDepMake
            // 
            this.btDepMake.Location = new System.Drawing.Point(314, 261);
            this.btDepMake.Name = "btDepMake";
            this.btDepMake.Size = new System.Drawing.Size(199, 46);
            this.btDepMake.TabIndex = 4;
            this.btDepMake.Text = "DEPOSIT";
            this.btDepMake.UseVisualStyleBackColor = true;
            this.btDepMake.Click += new System.EventHandler(this.BtDepMake_Click);
            // 
            // lblDepMoney
            // 
            this.lblDepMoney.AutoSize = true;
            this.lblDepMoney.Location = new System.Drawing.Point(73, 128);
            this.lblDepMoney.Name = "lblDepMoney";
            this.lblDepMoney.Size = new System.Drawing.Size(67, 20);
            this.lblDepMoney.TabIndex = 3;
            this.lblDepMoney.Text = "MONEY";
            // 
            // lblDepIBAN
            // 
            this.lblDepIBAN.AutoSize = true;
            this.lblDepIBAN.Location = new System.Drawing.Point(93, 63);
            this.lblDepIBAN.Name = "lblDepIBAN";
            this.lblDepIBAN.Size = new System.Drawing.Size(47, 20);
            this.lblDepIBAN.TabIndex = 2;
            this.lblDepIBAN.Text = "IBAN";
            // 
            // txtDepMoney
            // 
            this.txtDepMoney.Location = new System.Drawing.Point(150, 125);
            this.txtDepMoney.Name = "txtDepMoney";
            this.txtDepMoney.Size = new System.Drawing.Size(363, 26);
            this.txtDepMoney.TabIndex = 1;
            this.txtDepMoney.TextChanged += new System.EventHandler(this.TxtDepMoney_TextChanged);
            // 
            // txtDepIBAN
            // 
            this.txtDepIBAN.Location = new System.Drawing.Point(150, 60);
            this.txtDepIBAN.Name = "txtDepIBAN";
            this.txtDepIBAN.Size = new System.Drawing.Size(363, 26);
            this.txtDepIBAN.TabIndex = 0;
            this.txtDepIBAN.TextChanged += new System.EventHandler(this.TxtDepIBAN_TextChanged);
            // 
            // tbTransfer
            // 
            this.tbTransfer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbTransfer.Controls.Add(this.CBRecvIBAN);
            this.tbTransfer.Controls.Add(this.CBSendIBAN);
            this.tbTransfer.Controls.Add(this.btTransferMake);
            this.tbTransfer.Controls.Add(this.lblTransMoney);
            this.tbTransfer.Controls.Add(this.txtTransMoney);
            this.tbTransfer.Controls.Add(this.lblIBANRecv);
            this.tbTransfer.Controls.Add(this.txtIBANRecv);
            this.tbTransfer.Controls.Add(this.lblIBANSend);
            this.tbTransfer.Controls.Add(this.txtIBANSend);
            this.tbTransfer.Location = new System.Drawing.Point(4, 5);
            this.tbTransfer.Name = "tbTransfer";
            this.tbTransfer.Size = new System.Drawing.Size(558, 362);
            this.tbTransfer.TabIndex = 2;
            this.tbTransfer.Text = "tabPage1";
            // 
            // btTransferMake
            // 
            this.btTransferMake.Location = new System.Drawing.Point(314, 261);
            this.btTransferMake.Name = "btTransferMake";
            this.btTransferMake.Size = new System.Drawing.Size(199, 46);
            this.btTransferMake.TabIndex = 6;
            this.btTransferMake.Text = "TRANSFER";
            this.btTransferMake.UseVisualStyleBackColor = true;
            this.btTransferMake.Click += new System.EventHandler(this.BtTransferMake_Click);
            // 
            // lblTransMoney
            // 
            this.lblTransMoney.AutoSize = true;
            this.lblTransMoney.Location = new System.Drawing.Point(67, 219);
            this.lblTransMoney.Name = "lblTransMoney";
            this.lblTransMoney.Size = new System.Drawing.Size(67, 20);
            this.lblTransMoney.TabIndex = 5;
            this.lblTransMoney.Text = "MONEY";
            // 
            // txtTransMoney
            // 
            this.txtTransMoney.Location = new System.Drawing.Point(150, 216);
            this.txtTransMoney.Name = "txtTransMoney";
            this.txtTransMoney.Size = new System.Drawing.Size(363, 26);
            this.txtTransMoney.TabIndex = 4;
            this.txtTransMoney.TextChanged += new System.EventHandler(this.TxtTransMoney_TextChanged);
            // 
            // lblIBANRecv
            // 
            this.lblIBANRecv.AutoSize = true;
            this.lblIBANRecv.Location = new System.Drawing.Point(11, 154);
            this.lblIBANRecv.Name = "lblIBANRecv";
            this.lblIBANRecv.Size = new System.Drawing.Size(123, 20);
            this.lblIBANRecv.TabIndex = 3;
            this.lblIBANRecv.Text = "IBAN RECIEVE";
            // 
            // txtIBANRecv
            // 
            this.txtIBANRecv.Location = new System.Drawing.Point(150, 151);
            this.txtIBANRecv.Name = "txtIBANRecv";
            this.txtIBANRecv.Size = new System.Drawing.Size(363, 26);
            this.txtIBANRecv.TabIndex = 2;
            this.txtIBANRecv.TextChanged += new System.EventHandler(this.TxtIBANRecv_TextChanged);
            // 
            // lblIBANSend
            // 
            this.lblIBANSend.AutoSize = true;
            this.lblIBANSend.Location = new System.Drawing.Point(38, 60);
            this.lblIBANSend.Name = "lblIBANSend";
            this.lblIBANSend.Size = new System.Drawing.Size(96, 20);
            this.lblIBANSend.TabIndex = 1;
            this.lblIBANSend.Text = "IBAN SEND";
            // 
            // txtIBANSend
            // 
            this.txtIBANSend.Location = new System.Drawing.Point(150, 57);
            this.txtIBANSend.Name = "txtIBANSend";
            this.txtIBANSend.Size = new System.Drawing.Size(363, 26);
            this.txtIBANSend.TabIndex = 0;
            this.txtIBANSend.TextChanged += new System.EventHandler(this.TxtIBANSend_TextChanged);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.IndianRed;
            this.txtError.Location = new System.Drawing.Point(0, 345);
            this.txtError.Name = "txtError";
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(723, 26);
            this.txtError.TabIndex = 1;
            // 
            // CBSendIBAN
            // 
            this.CBSendIBAN.FormattingEnabled = true;
            this.CBSendIBAN.Location = new System.Drawing.Point(150, 23);
            this.CBSendIBAN.Name = "CBSendIBAN";
            this.CBSendIBAN.Size = new System.Drawing.Size(363, 28);
            this.CBSendIBAN.TabIndex = 7;
            this.CBSendIBAN.DropDown += new System.EventHandler(this.CBSendIBAN_DropDown);
            this.CBSendIBAN.SelectedIndexChanged += new System.EventHandler(this.CBSendIBAN_SelectedIndexChanged);
            this.CBSendIBAN.Click += new System.EventHandler(this.CBSendIBAN_Click);
            // 
            // CBRecvIBAN
            // 
            this.CBRecvIBAN.FormattingEnabled = true;
            this.CBRecvIBAN.Location = new System.Drawing.Point(150, 117);
            this.CBRecvIBAN.Name = "CBRecvIBAN";
            this.CBRecvIBAN.Size = new System.Drawing.Size(363, 28);
            this.CBRecvIBAN.TabIndex = 8;
            this.CBRecvIBAN.DropDown += new System.EventHandler(this.CBRecvIBAN_DropDown);
            this.CBRecvIBAN.SelectedIndexChanged += new System.EventHandler(this.CBRecvIBAN_SelectedIndexChanged);
            this.CBRecvIBAN.Click += new System.EventHandler(this.CBRecvIBAN_Click);
            // 
            // tbTrans
            // 
            this.tbTrans.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbTrans.Controls.Add(this.DTTransaction);
            this.tbTrans.Controls.Add(this.CBTransaction);
            this.tbTrans.Location = new System.Drawing.Point(4, 5);
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.Size = new System.Drawing.Size(558, 362);
            this.tbTrans.TabIndex = 3;
            this.tbTrans.Text = "tabPage1";
            // 
            // btTransaction
            // 
            this.btTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.btTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransaction.Location = new System.Drawing.Point(0, 150);
            this.btTransaction.Name = "btTransaction";
            this.btTransaction.Size = new System.Drawing.Size(153, 50);
            this.btTransaction.TabIndex = 4;
            this.btTransaction.Text = "TRANSACTION";
            this.btTransaction.UseVisualStyleBackColor = false;
            this.btTransaction.Click += new System.EventHandler(this.BtTransaction_Click);
            // 
            // CBTransaction
            // 
            this.CBTransaction.FormattingEnabled = true;
            this.CBTransaction.Location = new System.Drawing.Point(249, 7);
            this.CBTransaction.Name = "CBTransaction";
            this.CBTransaction.Size = new System.Drawing.Size(301, 28);
            this.CBTransaction.TabIndex = 0;
            this.CBTransaction.DropDown += new System.EventHandler(this.CBTransaction_DropDown);
            this.CBTransaction.SelectedIndexChanged += new System.EventHandler(this.CBTransaction_SelectedIndexChanged);
            this.CBTransaction.Click += new System.EventHandler(this.CBTransaction_Click);
            // 
            // DTTransaction
            // 
            this.DTTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTTransaction.Location = new System.Drawing.Point(3, 44);
            this.DTTransaction.Name = "DTTransaction";
            this.DTTransaction.Size = new System.Drawing.Size(547, 290);
            this.DTTransaction.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(723, 371);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Brand New Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbMain.ResumeLayout(false);
            this.tbCreate.ResumeLayout(false);
            this.tbCreate.PerformLayout();
            this.tbDeposit.ResumeLayout(false);
            this.tbDeposit.PerformLayout();
            this.tbTransfer.ResumeLayout(false);
            this.tbTransfer.PerformLayout();
            this.tbTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btTransfer;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btCreateClient;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tbCreate;
        private System.Windows.Forms.TabPage tbDeposit;
        private System.Windows.Forms.TabPage tbTransfer;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblDepMoney;
        private System.Windows.Forms.Label lblDepIBAN;
        private System.Windows.Forms.TextBox txtDepMoney;
        private System.Windows.Forms.TextBox txtDepIBAN;
        private System.Windows.Forms.Button btDepMake;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Button btCreateMake;
        private System.Windows.Forms.Button btTransferMake;
        private System.Windows.Forms.Label lblTransMoney;
        private System.Windows.Forms.TextBox txtTransMoney;
        private System.Windows.Forms.Label lblIBANRecv;
        private System.Windows.Forms.TextBox txtIBANRecv;
        private System.Windows.Forms.Label lblIBANSend;
        private System.Windows.Forms.TextBox txtIBANSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBDepIBAN;
        private System.Windows.Forms.ComboBox CBRecvIBAN;
        private System.Windows.Forms.ComboBox CBSendIBAN;
        private System.Windows.Forms.Button btTransaction;
        private System.Windows.Forms.TabPage tbTrans;
        private System.Windows.Forms.ComboBox CBTransaction;
        private System.Windows.Forms.DataGridView DTTransaction;
    }
}

