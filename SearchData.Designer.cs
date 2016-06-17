using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Safiye
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtErrorCode = new System.Windows.Forms.TextBox();
            this.lblRrn = new System.Windows.Forms.Label();
            this.txtRrn = new System.Windows.Forms.TextBox();
            this.lblMerchant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDev = new System.Windows.Forms.RadioButton();
            this.rdInt = new System.Windows.Forms.RadioButton();
            this.rdUat = new System.Windows.Forms.RadioButton();
            this.rdProd = new System.Windows.Forms.RadioButton();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.lblPcode = new System.Windows.Forms.Label();
            this.txtMTI = new System.Windows.Forms.TextBox();
            this.lblMTI = new System.Windows.Forms.Label();
            this.txtTrnxSubCode = new System.Windows.Forms.TextBox();
            this.lblTrnxSubCode = new System.Windows.Forms.Label();
            this.txtTrnxCode = new System.Windows.Forms.TextBox();
            this.lblTrnxCode = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPcode = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.btnTextSearch = new System.Windows.Forms.Button();
            this.BtnMerchant = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnErrorCode = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.btnCardNo = new System.Windows.Forms.Button();
            this.btnSeqNo = new System.Windows.Forms.Button();
            this.txtSeqNo = new System.Windows.Forms.TextBox();
            this.lblSeqNo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblProcessResult = new System.Windows.Forms.Label();
            this.txtProcesResult = new System.Windows.Forms.TextBox();
            this.txtTrnxType = new System.Windows.Forms.TextBox();
            this.lblTrnxType = new System.Windows.Forms.Label();
            this.txtSourceFui = new System.Windows.Forms.TextBox();
            this.lblSourceFui = new System.Windows.Forms.Label();
            this.txtDestFui = new System.Windows.Forms.TextBox();
            this.lblDestFui = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnBank = new System.Windows.Forms.Button();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.lblBankCode = new System.Windows.Forms.Label();
            this.BtnCopyDate = new System.Windows.Forms.Button();
            this.chkMngmnt = new System.Windows.Forms.CheckBox();
            this.txtMerchant = new System.Windows.Forms.TextBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.btnDbLog = new System.Windows.Forms.Button();
            this.txtPosGuid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSysDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSysTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApc = new System.Windows.Forms.Button();
            this.btnApcReport = new System.Windows.Forms.Button();
            this.rdBatch = new System.Windows.Forms.RadioButton();
            this.rdOnline = new System.Windows.Forms.RadioButton();
            this.apcGroupBox = new System.Windows.Forms.GroupBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbThem = new System.Windows.Forms.ComboBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSurum = new System.Windows.Forms.Button();
            this.grid3 = new System.Windows.Forms.DataGridView();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.grid1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.apcGroupBox.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(114, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Julian date";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(16, 140);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(92, 17);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error Code:";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.Location = new System.Drawing.Point(117, 140);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.Size = new System.Drawing.Size(100, 22);
            this.txtErrorCode.TabIndex = 14;
            // 
            // lblRrn
            // 
            this.lblRrn.AutoSize = true;
            this.lblRrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRrn.ForeColor = System.Drawing.Color.White;
            this.lblRrn.Location = new System.Drawing.Point(16, 182);
            this.lblRrn.Name = "lblRrn";
            this.lblRrn.Size = new System.Drawing.Size(51, 17);
            this.lblRrn.TabIndex = 16;
            this.lblRrn.Text = "RRN :";
            // 
            // txtRrn
            // 
            this.txtRrn.Location = new System.Drawing.Point(117, 177);
            this.txtRrn.Name = "txtRrn";
            this.txtRrn.Size = new System.Drawing.Size(100, 22);
            this.txtRrn.TabIndex = 0;
            this.txtRrn.TextChanged += new System.EventHandler(this.txtRrn_TextChanged);
            this.txtRrn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRrn_KeyPress);
            // 
            // lblMerchant
            // 
            this.lblMerchant.AutoSize = true;
            this.lblMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMerchant.ForeColor = System.Drawing.Color.White;
            this.lblMerchant.Location = new System.Drawing.Point(336, 26);
            this.lblMerchant.Name = "lblMerchant";
            this.lblMerchant.Size = new System.Drawing.Size(57, 17);
            this.lblMerchant.TabIndex = 23;
            this.lblMerchant.Text = "İşyeri :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDev);
            this.groupBox1.Controls.Add(this.rdInt);
            this.groupBox1.Controls.Add(this.rdUat);
            this.groupBox1.Controls.Add(this.rdProd);
            this.groupBox1.Location = new System.Drawing.Point(650, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 138);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // rdDev
            // 
            this.rdDev.AutoSize = true;
            this.rdDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdDev.ForeColor = System.Drawing.Color.Transparent;
            this.rdDev.Location = new System.Drawing.Point(17, 103);
            this.rdDev.Name = "rdDev";
            this.rdDev.Size = new System.Drawing.Size(57, 21);
            this.rdDev.TabIndex = 33;
            this.rdDev.TabStop = true;
            this.rdDev.Text = "Dev";
            this.rdDev.UseVisualStyleBackColor = true;
            // 
            // rdInt
            // 
            this.rdInt.AutoSize = true;
            this.rdInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdInt.ForeColor = System.Drawing.Color.Transparent;
            this.rdInt.Location = new System.Drawing.Point(17, 76);
            this.rdInt.Name = "rdInt";
            this.rdInt.Size = new System.Drawing.Size(47, 21);
            this.rdInt.TabIndex = 32;
            this.rdInt.TabStop = true;
            this.rdInt.Text = "Int";
            this.rdInt.UseVisualStyleBackColor = true;
            // 
            // rdUat
            // 
            this.rdUat.AutoSize = true;
            this.rdUat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdUat.ForeColor = System.Drawing.Color.Transparent;
            this.rdUat.Location = new System.Drawing.Point(17, 49);
            this.rdUat.Name = "rdUat";
            this.rdUat.Size = new System.Drawing.Size(54, 21);
            this.rdUat.TabIndex = 31;
            this.rdUat.TabStop = true;
            this.rdUat.Text = "Uat";
            this.rdUat.UseVisualStyleBackColor = true;
            // 
            // rdProd
            // 
            this.rdProd.AutoSize = true;
            this.rdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdProd.ForeColor = System.Drawing.Color.Transparent;
            this.rdProd.Location = new System.Drawing.Point(17, 22);
            this.rdProd.Name = "rdProd";
            this.rdProd.Size = new System.Drawing.Size(63, 21);
            this.rdProd.TabIndex = 30;
            this.rdProd.TabStop = true;
            this.rdProd.Text = "Prod";
            this.rdProd.UseVisualStyleBackColor = true;
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTerminal.ForeColor = System.Drawing.Color.White;
            this.lblTerminal.Location = new System.Drawing.Point(336, 100);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(81, 17);
            this.lblTerminal.TabIndex = 32;
            this.lblTerminal.Text = "Terminal :";
            // 
            // txtPcode
            // 
            this.txtPcode.Location = new System.Drawing.Point(467, 134);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(100, 22);
            this.txtPcode.TabIndex = 36;
            // 
            // lblPcode
            // 
            this.lblPcode.AutoSize = true;
            this.lblPcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPcode.ForeColor = System.Drawing.Color.White;
            this.lblPcode.Location = new System.Drawing.Point(336, 140);
            this.lblPcode.Name = "lblPcode";
            this.lblPcode.Size = new System.Drawing.Size(63, 17);
            this.lblPcode.TabIndex = 35;
            this.lblPcode.Text = "Pcode :";
            // 
            // txtMTI
            // 
            this.txtMTI.Location = new System.Drawing.Point(467, 173);
            this.txtMTI.Name = "txtMTI";
            this.txtMTI.ReadOnly = true;
            this.txtMTI.Size = new System.Drawing.Size(100, 22);
            this.txtMTI.TabIndex = 39;
            // 
            // lblMTI
            // 
            this.lblMTI.AutoSize = true;
            this.lblMTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMTI.ForeColor = System.Drawing.Color.White;
            this.lblMTI.Location = new System.Drawing.Point(336, 177);
            this.lblMTI.Name = "lblMTI";
            this.lblMTI.Size = new System.Drawing.Size(44, 17);
            this.lblMTI.TabIndex = 38;
            this.lblMTI.Text = "MTI :";
            // 
            // txtTrnxSubCode
            // 
            this.txtTrnxSubCode.Location = new System.Drawing.Point(467, 283);
            this.txtTrnxSubCode.Name = "txtTrnxSubCode";
            this.txtTrnxSubCode.ReadOnly = true;
            this.txtTrnxSubCode.Size = new System.Drawing.Size(100, 22);
            this.txtTrnxSubCode.TabIndex = 41;
            // 
            // lblTrnxSubCode
            // 
            this.lblTrnxSubCode.AutoSize = true;
            this.lblTrnxSubCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrnxSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrnxSubCode.ForeColor = System.Drawing.Color.White;
            this.lblTrnxSubCode.Location = new System.Drawing.Point(336, 283);
            this.lblTrnxSubCode.Name = "lblTrnxSubCode";
            this.lblTrnxSubCode.Size = new System.Drawing.Size(125, 17);
            this.lblTrnxSubCode.TabIndex = 40;
            this.lblTrnxSubCode.Text = "Trnx Sub Code :";
            // 
            // txtTrnxCode
            // 
            this.txtTrnxCode.Location = new System.Drawing.Point(467, 247);
            this.txtTrnxCode.Name = "txtTrnxCode";
            this.txtTrnxCode.ReadOnly = true;
            this.txtTrnxCode.Size = new System.Drawing.Size(100, 22);
            this.txtTrnxCode.TabIndex = 43;
            // 
            // lblTrnxCode
            // 
            this.lblTrnxCode.AutoSize = true;
            this.lblTrnxCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrnxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrnxCode.ForeColor = System.Drawing.Color.White;
            this.lblTrnxCode.Location = new System.Drawing.Point(336, 253);
            this.lblTrnxCode.Name = "lblTrnxCode";
            this.lblTrnxCode.Size = new System.Drawing.Size(92, 17);
            this.lblTrnxCode.TabIndex = 42;
            this.lblTrnxCode.Text = "Trnx Code :";
            // 
            // btnPcode
            // 
            this.btnPcode.Image = global::Safiye.Properties.Resources.search;
            this.btnPcode.Location = new System.Drawing.Point(573, 134);
            this.btnPcode.Name = "btnPcode";
            this.btnPcode.Size = new System.Drawing.Size(34, 26);
            this.btnPcode.TabIndex = 37;
            this.btnPcode.UseVisualStyleBackColor = true;
            this.btnPcode.Click += new System.EventHandler(this.btnPcode_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.Image = global::Safiye.Properties.Resources.search;
            this.btnTerminal.Location = new System.Drawing.Point(573, 94);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(34, 26);
            this.btnTerminal.TabIndex = 34;
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // btnTextSearch
            // 
            this.btnTextSearch.Image = global::Safiye.Properties.Resources.location_searching_white_48x48;
            this.btnTextSearch.Location = new System.Drawing.Point(844, 56);
            this.btnTextSearch.Name = "btnTextSearch";
            this.btnTextSearch.Size = new System.Drawing.Size(63, 61);
            this.btnTextSearch.TabIndex = 31;
            this.btnTextSearch.UseVisualStyleBackColor = true;
            this.btnTextSearch.Click += new System.EventHandler(this.btnTextSearch_Click);
            // 
            // BtnMerchant
            // 
            this.BtnMerchant.Image = global::Safiye.Properties.Resources.search;
            this.BtnMerchant.Location = new System.Drawing.Point(573, 20);
            this.BtnMerchant.Name = "BtnMerchant";
            this.BtnMerchant.Size = new System.Drawing.Size(34, 26);
            this.BtnMerchant.TabIndex = 25;
            this.BtnMerchant.UseVisualStyleBackColor = true;
            this.BtnMerchant.Click += new System.EventHandler(this.BtnMerchant_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = global::Safiye.Properties.Resources.find_in_page_white_48x48;
            this.BtnFind.Location = new System.Drawing.Point(772, 56);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(63, 61);
            this.BtnFind.TabIndex = 18;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnErrorCode
            // 
            this.BtnErrorCode.Image = global::Safiye.Properties.Resources.search;
            this.BtnErrorCode.Location = new System.Drawing.Point(223, 140);
            this.BtnErrorCode.Name = "BtnErrorCode";
            this.BtnErrorCode.Size = new System.Drawing.Size(34, 26);
            this.BtnErrorCode.TabIndex = 15;
            this.BtnErrorCode.UseVisualStyleBackColor = true;
            this.BtnErrorCode.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(115, 100);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 46;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(13, 100);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 17);
            this.lblTime.TabIndex = 45;
            this.lblTime.Text = "Time :";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(467, 320);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(140, 22);
            this.txtCardNo.TabIndex = 48;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNo.ForeColor = System.Drawing.Color.White;
            this.lblCardNo.Location = new System.Drawing.Point(336, 320);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(72, 17);
            this.lblCardNo.TabIndex = 47;
            this.lblCardNo.Text = "Card No:";
            // 
            // btnCardNo
            // 
            this.btnCardNo.Image = global::Safiye.Properties.Resources.search;
            this.btnCardNo.Location = new System.Drawing.Point(613, 320);
            this.btnCardNo.Name = "btnCardNo";
            this.btnCardNo.Size = new System.Drawing.Size(34, 26);
            this.btnCardNo.TabIndex = 49;
            this.btnCardNo.UseVisualStyleBackColor = true;
            this.btnCardNo.Click += new System.EventHandler(this.btnCardNo_Click);
            // 
            // btnSeqNo
            // 
            this.btnSeqNo.Image = global::Safiye.Properties.Resources.search;
            this.btnSeqNo.Location = new System.Drawing.Point(573, 56);
            this.btnSeqNo.Name = "btnSeqNo";
            this.btnSeqNo.Size = new System.Drawing.Size(34, 26);
            this.btnSeqNo.TabIndex = 52;
            this.btnSeqNo.UseVisualStyleBackColor = true;
            this.btnSeqNo.Click += new System.EventHandler(this.btnSeqNo_Click);
            // 
            // txtSeqNo
            // 
            this.txtSeqNo.Location = new System.Drawing.Point(467, 56);
            this.txtSeqNo.Name = "txtSeqNo";
            this.txtSeqNo.ReadOnly = true;
            this.txtSeqNo.Size = new System.Drawing.Size(100, 22);
            this.txtSeqNo.TabIndex = 51;
            // 
            // lblSeqNo
            // 
            this.lblSeqNo.AutoSize = true;
            this.lblSeqNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeqNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeqNo.ForeColor = System.Drawing.Color.White;
            this.lblSeqNo.Location = new System.Drawing.Point(336, 62);
            this.lblSeqNo.Name = "lblSeqNo";
            this.lblSeqNo.Size = new System.Drawing.Size(52, 17);
            this.lblSeqNo.TabIndex = 50;
            this.lblSeqNo.Text = "Bölüm";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Safiye.Properties.Resources.clear_all_white_48x48;
            this.btnClear.Location = new System.Drawing.Point(913, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 61);
            this.btnClear.TabIndex = 53;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_3);
            // 
            // lblProcessResult
            // 
            this.lblProcessResult.AutoSize = true;
            this.lblProcessResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProcessResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProcessResult.ForeColor = System.Drawing.Color.White;
            this.lblProcessResult.Location = new System.Drawing.Point(19, 218);
            this.lblProcessResult.Name = "lblProcessResult";
            this.lblProcessResult.Size = new System.Drawing.Size(95, 17);
            this.lblProcessResult.TabIndex = 55;
            this.lblProcessResult.Text = "İşlem Cevap";
            // 
            // txtProcesResult
            // 
            this.txtProcesResult.Location = new System.Drawing.Point(120, 213);
            this.txtProcesResult.Name = "txtProcesResult";
            this.txtProcesResult.ReadOnly = true;
            this.txtProcesResult.Size = new System.Drawing.Size(35, 22);
            this.txtProcesResult.TabIndex = 56;
            // 
            // txtTrnxType
            // 
            this.txtTrnxType.Location = new System.Drawing.Point(467, 212);
            this.txtTrnxType.Name = "txtTrnxType";
            this.txtTrnxType.ReadOnly = true;
            this.txtTrnxType.Size = new System.Drawing.Size(100, 22);
            this.txtTrnxType.TabIndex = 59;
            // 
            // lblTrnxType
            // 
            this.lblTrnxType.AutoSize = true;
            this.lblTrnxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrnxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrnxType.ForeColor = System.Drawing.Color.White;
            this.lblTrnxType.Location = new System.Drawing.Point(336, 218);
            this.lblTrnxType.Name = "lblTrnxType";
            this.lblTrnxType.Size = new System.Drawing.Size(91, 17);
            this.lblTrnxType.TabIndex = 58;
            this.lblTrnxType.Text = "Trnx Type :";
            // 
            // txtSourceFui
            // 
            this.txtSourceFui.Location = new System.Drawing.Point(117, 248);
            this.txtSourceFui.Name = "txtSourceFui";
            this.txtSourceFui.ReadOnly = true;
            this.txtSourceFui.Size = new System.Drawing.Size(91, 22);
            this.txtSourceFui.TabIndex = 64;
            // 
            // lblSourceFui
            // 
            this.lblSourceFui.AutoSize = true;
            this.lblSourceFui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSourceFui.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSourceFui.ForeColor = System.Drawing.Color.White;
            this.lblSourceFui.Location = new System.Drawing.Point(16, 253);
            this.lblSourceFui.Name = "lblSourceFui";
            this.lblSourceFui.Size = new System.Drawing.Size(86, 17);
            this.lblSourceFui.TabIndex = 63;
            this.lblSourceFui.Text = "Source Fui";
            // 
            // txtDestFui
            // 
            this.txtDestFui.Location = new System.Drawing.Point(120, 283);
            this.txtDestFui.Name = "txtDestFui";
            this.txtDestFui.ReadOnly = true;
            this.txtDestFui.Size = new System.Drawing.Size(91, 22);
            this.txtDestFui.TabIndex = 66;
            // 
            // lblDestFui
            // 
            this.lblDestFui.AutoSize = true;
            this.lblDestFui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDestFui.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDestFui.ForeColor = System.Drawing.Color.White;
            this.lblDestFui.Location = new System.Drawing.Point(19, 288);
            this.lblDestFui.Name = "lblDestFui";
            this.lblDestFui.Size = new System.Drawing.Size(101, 17);
            this.lblDestFui.TabIndex = 65;
            this.lblDestFui.Text = "DestFui/Dest";
            this.lblDestFui.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(225, 285);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(52, 22);
            this.txtDest.TabIndex = 67;
            // 
            // btnBank
            // 
            this.btnBank.Image = global::Safiye.Properties.Resources.search;
            this.btnBank.Location = new System.Drawing.Point(573, 356);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(34, 26);
            this.btnBank.TabIndex = 70;
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(467, 356);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(100, 22);
            this.txtBankCode.TabIndex = 69;
            // 
            // lblBankCode
            // 
            this.lblBankCode.AutoSize = true;
            this.lblBankCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankCode.ForeColor = System.Drawing.Color.White;
            this.lblBankCode.Location = new System.Drawing.Point(336, 356);
            this.lblBankCode.Name = "lblBankCode";
            this.lblBankCode.Size = new System.Drawing.Size(49, 17);
            this.lblBankCode.TabIndex = 68;
            this.lblBankCode.Text = "Bank:";
            // 
            // BtnCopyDate
            // 
            this.BtnCopyDate.Image = global::Safiye.Properties.Resources.copy;
            this.BtnCopyDate.Location = new System.Drawing.Point(233, 53);
            this.BtnCopyDate.Name = "BtnCopyDate";
            this.BtnCopyDate.Size = new System.Drawing.Size(39, 31);
            this.BtnCopyDate.TabIndex = 71;
            this.BtnCopyDate.UseVisualStyleBackColor = true;
            this.BtnCopyDate.Click += new System.EventHandler(this.BtnCopyDate_Click);
            // 
            // chkMngmnt
            // 
            this.chkMngmnt.AutoSize = true;
            this.chkMngmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMngmnt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkMngmnt.Location = new System.Drawing.Point(772, 145);
            this.chkMngmnt.Name = "chkMngmnt";
            this.chkMngmnt.Size = new System.Drawing.Size(113, 21);
            this.chkMngmnt.TabIndex = 72;
            this.chkMngmnt.Text = "Managment";
            this.chkMngmnt.UseVisualStyleBackColor = true;
            // 
            // txtMerchant
            // 
            this.txtMerchant.Location = new System.Drawing.Point(467, 21);
            this.txtMerchant.Name = "txtMerchant";
            this.txtMerchant.Size = new System.Drawing.Size(100, 22);
            this.txtMerchant.TabIndex = 74;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(467, 96);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(100, 22);
            this.txtTerminal.TabIndex = 75;
            // 
            // btnDbLog
            // 
            this.btnDbLog.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDbLog.Location = new System.Drawing.Point(1030, 158);
            this.btnDbLog.Name = "btnDbLog";
            this.btnDbLog.Size = new System.Drawing.Size(88, 41);
            this.btnDbLog.TabIndex = 76;
            this.btnDbLog.Text = "DB Log";
            this.btnDbLog.UseVisualStyleBackColor = true;
            this.btnDbLog.Click += new System.EventHandler(this.btnDbLog_Click);
            // 
            // txtPosGuid
            // 
            this.txtPosGuid.Location = new System.Drawing.Point(120, 324);
            this.txtPosGuid.Name = "txtPosGuid";
            this.txtPosGuid.Size = new System.Drawing.Size(210, 22);
            this.txtPosGuid.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Pos Guid";
            // 
            // txtSysDate
            // 
            this.txtSysDate.Enabled = false;
            this.txtSysDate.Location = new System.Drawing.Point(120, 356);
            this.txtSysDate.Name = "txtSysDate";
            this.txtSysDate.ReadOnly = true;
            this.txtSysDate.Size = new System.Drawing.Size(91, 22);
            this.txtSysDate.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Sys Date :";
            // 
            // txtSysTime
            // 
            this.txtSysTime.Enabled = false;
            this.txtSysTime.Location = new System.Drawing.Point(267, 358);
            this.txtSysTime.Name = "txtSysTime";
            this.txtSysTime.ReadOnly = true;
            this.txtSysTime.Size = new System.Drawing.Size(63, 22);
            this.txtSysTime.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(215, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Time :";
            // 
            // btnApc
            // 
            this.btnApc.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApc.Location = new System.Drawing.Point(21, 22);
            this.btnApc.Name = "btnApc";
            this.btnApc.Size = new System.Drawing.Size(51, 31);
            this.btnApc.TabIndex = 84;
            this.btnApc.Text = "Trnx";
            this.btnApc.UseVisualStyleBackColor = true;
            this.btnApc.Click += new System.EventHandler(this.btnApc_Click);
            // 
            // btnApcReport
            // 
            this.btnApcReport.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApcReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApcReport.Location = new System.Drawing.Point(21, 58);
            this.btnApcReport.Name = "btnApcReport";
            this.btnApcReport.Size = new System.Drawing.Size(66, 34);
            this.btnApcReport.TabIndex = 85;
            this.btnApcReport.Text = "Report";
            this.btnApcReport.UseVisualStyleBackColor = true;
            this.btnApcReport.Click += new System.EventHandler(this.btnApcReport_Click);
            // 
            // rdBatch
            // 
            this.rdBatch.AutoSize = true;
            this.rdBatch.Checked = true;
            this.rdBatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdBatch.Location = new System.Drawing.Point(99, 30);
            this.rdBatch.Name = "rdBatch";
            this.rdBatch.Size = new System.Drawing.Size(70, 21);
            this.rdBatch.TabIndex = 86;
            this.rdBatch.TabStop = true;
            this.rdBatch.Text = "Batch";
            this.rdBatch.UseVisualStyleBackColor = true;
            this.rdBatch.CheckedChanged += new System.EventHandler(this.rdBatch_CheckedChanged);
            // 
            // rdOnline
            // 
            this.rdOnline.AutoSize = true;
            this.rdOnline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdOnline.Location = new System.Drawing.Point(99, 65);
            this.rdOnline.Name = "rdOnline";
            this.rdOnline.Size = new System.Drawing.Size(76, 21);
            this.rdOnline.TabIndex = 87;
            this.rdOnline.Text = "Online";
            this.rdOnline.UseVisualStyleBackColor = true;
            this.rdOnline.CheckedChanged += new System.EventHandler(this.rdOnline_CheckedChanged);
            // 
            // apcGroupBox
            // 
            this.apcGroupBox.AutoSize = true;
            this.apcGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apcGroupBox.Controls.Add(this.rdBatch);
            this.apcGroupBox.Controls.Add(this.rdOnline);
            this.apcGroupBox.Controls.Add(this.btnApc);
            this.apcGroupBox.Controls.Add(this.btnApcReport);
            this.apcGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apcGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apcGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apcGroupBox.Location = new System.Drawing.Point(1031, 213);
            this.apcGroupBox.Name = "apcGroupBox";
            this.apcGroupBox.Size = new System.Drawing.Size(196, 113);
            this.apcGroupBox.TabIndex = 88;
            this.apcGroupBox.TabStop = false;
            this.apcGroupBox.Text = "Apc";
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.AutoSize = true;
            this.mainGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainGroupBox.Controls.Add(this.groupBox2);
            this.mainGroupBox.Controls.Add(this.btnSurum);
            this.mainGroupBox.Controls.Add(this.label2);
            this.mainGroupBox.Controls.Add(this.apcGroupBox);
            this.mainGroupBox.Controls.Add(this.dateTimePicker1);
            this.mainGroupBox.Controls.Add(this.numericUpDown1);
            this.mainGroupBox.Controls.Add(this.label1);
            this.mainGroupBox.Controls.Add(this.txtSysTime);
            this.mainGroupBox.Controls.Add(this.lblError);
            this.mainGroupBox.Controls.Add(this.label7);
            this.mainGroupBox.Controls.Add(this.txtErrorCode);
            this.mainGroupBox.Controls.Add(this.txtSysDate);
            this.mainGroupBox.Controls.Add(this.BtnErrorCode);
            this.mainGroupBox.Controls.Add(this.label6);
            this.mainGroupBox.Controls.Add(this.lblRrn);
            this.mainGroupBox.Controls.Add(this.txtRrn);
            this.mainGroupBox.Controls.Add(this.txtPosGuid);
            this.mainGroupBox.Controls.Add(this.BtnFind);
            this.mainGroupBox.Controls.Add(this.label5);
            this.mainGroupBox.Controls.Add(this.btnDbLog);
            this.mainGroupBox.Controls.Add(this.lblMerchant);
            this.mainGroupBox.Controls.Add(this.txtTerminal);
            this.mainGroupBox.Controls.Add(this.BtnMerchant);
            this.mainGroupBox.Controls.Add(this.txtMerchant);
            this.mainGroupBox.Controls.Add(this.groupBox1);
            this.mainGroupBox.Controls.Add(this.btnTextSearch);
            this.mainGroupBox.Controls.Add(this.chkMngmnt);
            this.mainGroupBox.Controls.Add(this.lblTerminal);
            this.mainGroupBox.Controls.Add(this.BtnCopyDate);
            this.mainGroupBox.Controls.Add(this.btnTerminal);
            this.mainGroupBox.Controls.Add(this.btnBank);
            this.mainGroupBox.Controls.Add(this.lblPcode);
            this.mainGroupBox.Controls.Add(this.txtBankCode);
            this.mainGroupBox.Controls.Add(this.txtPcode);
            this.mainGroupBox.Controls.Add(this.lblBankCode);
            this.mainGroupBox.Controls.Add(this.btnPcode);
            this.mainGroupBox.Controls.Add(this.txtDest);
            this.mainGroupBox.Controls.Add(this.lblMTI);
            this.mainGroupBox.Controls.Add(this.txtDestFui);
            this.mainGroupBox.Controls.Add(this.txtMTI);
            this.mainGroupBox.Controls.Add(this.lblDestFui);
            this.mainGroupBox.Controls.Add(this.lblTrnxSubCode);
            this.mainGroupBox.Controls.Add(this.txtSourceFui);
            this.mainGroupBox.Controls.Add(this.txtTrnxSubCode);
            this.mainGroupBox.Controls.Add(this.lblSourceFui);
            this.mainGroupBox.Controls.Add(this.lblTrnxCode);
            this.mainGroupBox.Controls.Add(this.txtTrnxCode);
            this.mainGroupBox.Controls.Add(this.lblTime);
            this.mainGroupBox.Controls.Add(this.txtTime);
            this.mainGroupBox.Controls.Add(this.txtTrnxType);
            this.mainGroupBox.Controls.Add(this.lblCardNo);
            this.mainGroupBox.Controls.Add(this.lblTrnxType);
            this.mainGroupBox.Controls.Add(this.txtCardNo);
            this.mainGroupBox.Controls.Add(this.btnCardNo);
            this.mainGroupBox.Controls.Add(this.txtProcesResult);
            this.mainGroupBox.Controls.Add(this.lblSeqNo);
            this.mainGroupBox.Controls.Add(this.lblProcessResult);
            this.mainGroupBox.Controls.Add(this.txtSeqNo);
            this.mainGroupBox.Controls.Add(this.btnClear);
            this.mainGroupBox.Controls.Add(this.btnSeqNo);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(1283, 403);
            this.mainGroupBox.TabIndex = 89;
            this.mainGroupBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbThem);
            this.groupBox2.Controls.Add(this.btnMaximize);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(1090, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(184, 46);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 24);
            this.button1.TabIndex = 95;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbThem
            // 
            this.cmbThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThem.FormattingEnabled = true;
            this.cmbThem.Items.AddRange(new object[] {
            "Cyan",
            "Blue",
            "Green",
            "BlackAndRed",
            "Teal"});
            this.cmbThem.Location = new System.Drawing.Point(6, 14);
            this.cmbThem.Name = "cmbThem";
            this.cmbThem.Size = new System.Drawing.Size(69, 24);
            this.cmbThem.TabIndex = 90;
            this.cmbThem.SelectedIndexChanged += new System.EventHandler(this.cmbThem_SelectedIndexChanged);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Image = global::Safiye.Properties.Resources.flip_to_front_white_18x18;
            this.btnMaximize.Location = new System.Drawing.Point(79, 14);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 24);
            this.btnMaximize.TabIndex = 93;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Safiye.Properties.Resources.close_white_18x18;
            this.btnClose.Location = new System.Drawing.Point(112, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 24);
            this.btnClose.TabIndex = 92;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSurum
            // 
            this.btnSurum.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSurum.Location = new System.Drawing.Point(1031, 346);
            this.btnSurum.Name = "btnSurum";
            this.btnSurum.Size = new System.Drawing.Size(196, 34);
            this.btnSurum.TabIndex = 89;
            this.btnSurum.Text = "Sürüm Kontrol";
            this.btnSurum.UseVisualStyleBackColor = true;
            this.btnSurum.Click += new System.EventHandler(this.btnSurum_Click);
            // 
            // grid3
            // 
            this.grid3.AllowUserToAddRows = false;
            this.grid3.AllowUserToDeleteRows = false;
            this.grid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.grid3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid3.Location = new System.Drawing.Point(0, 728);
            this.grid3.Name = "grid3";
            this.grid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grid3.RowTemplate.Height = 24;
            this.grid3.Size = new System.Drawing.Size(1283, 96);
            this.grid3.TabIndex = 90;
            this.grid3.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowDetail);
            // 
            // grid2
            // 
            this.grid2.AllowUserToAddRows = false;
            this.grid2.AllowUserToDeleteRows = false;
            this.grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid2.Location = new System.Drawing.Point(0, 626);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grid2.RowTemplate.Height = 24;
            this.grid2.Size = new System.Drawing.Size(1283, 102);
            this.grid2.TabIndex = 91;
            this.grid2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowDetail);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid1.Location = new System.Drawing.Point(0, 408);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grid1.RowTemplate.Height = 24;
            this.grid1.Size = new System.Drawing.Size(1283, 218);
            this.grid1.TabIndex = 92;
            this.grid1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid1_RowHeaderMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1283, 824);
            this.ControlBox = false;
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid3);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(1600, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.apcGroupBox.ResumeLayout(false);
            this.apcGroupBox.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtErrorCode;
        private System.Windows.Forms.Button BtnErrorCode;
        private System.Windows.Forms.Label lblRrn;
        private System.Windows.Forms.TextBox txtRrn;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnMerchant;
        private System.Windows.Forms.Label lblMerchant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDev;
        private System.Windows.Forms.RadioButton rdInt;
        private System.Windows.Forms.RadioButton rdUat;
        private System.Windows.Forms.RadioButton rdProd;
        private System.Windows.Forms.Button btnTextSearch;
        private System.Windows.Forms.Button btnTerminal;
        //private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Button btnPcode;
        private System.Windows.Forms.TextBox txtPcode;
        private System.Windows.Forms.Label lblPcode;
        private System.Windows.Forms.TextBox txtMTI;
        private System.Windows.Forms.Label lblMTI;
        private System.Windows.Forms.TextBox txtTrnxSubCode;
        private System.Windows.Forms.Label lblTrnxSubCode;
        private System.Windows.Forms.TextBox txtTrnxCode;
        private System.Windows.Forms.Label lblTrnxCode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Button btnCardNo;
        private System.Windows.Forms.Button btnSeqNo;
        private System.Windows.Forms.TextBox txtSeqNo;
        private System.Windows.Forms.Label lblSeqNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblProcessResult;
        private System.Windows.Forms.TextBox txtProcesResult;
        private System.Windows.Forms.TextBox txtTrnxType;
        private System.Windows.Forms.Label lblTrnxType;
        private System.Windows.Forms.TextBox txtSourceFui;
        private System.Windows.Forms.Label lblSourceFui;
        private System.Windows.Forms.TextBox txtDestFui;
        private System.Windows.Forms.Label lblDestFui;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Label lblBankCode;
        private System.Windows.Forms.Button BtnCopyDate;
        private System.Windows.Forms.CheckBox chkMngmnt;
        private System.Windows.Forms.TextBox txtMerchant;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button btnDbLog;
        private System.Windows.Forms.TextBox txtPosGuid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSysDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSysTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApc;
        private System.Windows.Forms.Button btnApcReport;
        private System.Windows.Forms.RadioButton rdBatch;
        private System.Windows.Forms.RadioButton rdOnline;
        private System.Windows.Forms.GroupBox apcGroupBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Button btnSurum;
        private System.Windows.Forms.DataGridView grid3;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.DataGridView grid1;
        private ComboBox cmbThem;
        private Button btnClose;
        private Button btnMaximize;
        private GroupBox groupBox2;
        private Button button1;
    }
}