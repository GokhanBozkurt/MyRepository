namespace Safiye
{
    partial class SearchText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchText));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.lblFoundFile = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSearchPattern = new System.Windows.Forms.Label();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new System.Windows.Forms.ComboBox();
            this.cmbSearchPattern = new System.Windows.Forms.ComboBox();
            this.btnFileList = new System.Windows.Forms.Button();
            this.btnFolderBrowse = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.chkStartTime = new System.Windows.Forms.CheckBox();
            this.chkEndTime = new System.Windows.Forms.CheckBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnStartTimeAdd = new System.Windows.Forms.Button();
            this.btnStartTimeSubstract = new System.Windows.Forms.Button();
            this.btnEndTimeSubstract = new System.Windows.Forms.Button();
            this.btnEndTimeAdd = new System.Windows.Forms.Button();
            this.chkError = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkAllSet = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(62, 36);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(200, 22);
            this.txtText.TabIndex = 1;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(332, 36);
            this.lstResult.Name = "lstResult";
            this.lstResult.ScrollAlwaysVisible = true;
            this.lstResult.Size = new System.Drawing.Size(757, 324);
            this.lstResult.TabIndex = 3;
            this.lstResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFileCount.ForeColor = System.Drawing.Color.White;
            this.lblFileCount.Location = new System.Drawing.Point(357, 9);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 17);
            this.lblFileCount.TabIndex = 4;
            // 
            // lblFoundFile
            // 
            this.lblFoundFile.AutoSize = true;
            this.lblFoundFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFoundFile.ForeColor = System.Drawing.Color.Snow;
            this.lblFoundFile.Location = new System.Drawing.Point(629, 9);
            this.lblFoundFile.Name = "lblFoundFile";
            this.lblFoundFile.Size = new System.Drawing.Size(0, 17);
            this.lblFoundFile.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(13, 36);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(49, 17);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Text :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(13, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(268, 87);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(18, 17);
            this.chkDate.TabIndex = 8;
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // lblSearchPattern
            // 
            this.lblSearchPattern.AutoSize = true;
            this.lblSearchPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchPattern.ForeColor = System.Drawing.Color.White;
            this.lblSearchPattern.Location = new System.Drawing.Point(13, 217);
            this.lblSearchPattern.Name = "lblSearchPattern";
            this.lblSearchPattern.Size = new System.Drawing.Size(127, 17);
            this.lblSearchPattern.TabIndex = 12;
            this.lblSearchPattern.Text = "Search Pattern :";
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.ForeColor = System.Drawing.Color.White;
            this.chkSubFolders.Location = new System.Drawing.Point(178, 294);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(106, 21);
            this.chkSubFolders.TabIndex = 13;
            this.chkSubFolders.Text = "Sub Folders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFolder.ForeColor = System.Drawing.Color.White;
            this.lblFolder.Location = new System.Drawing.Point(15, 257);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(54, 17);
            this.lblFolder.TabIndex = 15;
            this.lblFolder.Text = "Folder";
            // 
            // cmbFolder
            // 
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.Items.AddRange(new object[] {
            "DEV",
            "UAT",
            "SET1",
            "SET2",
            "SET3",
            "SET4",
            "LOCAL"});
            this.cmbFolder.Location = new System.Drawing.Point(75, 250);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(182, 24);
            this.cmbFolder.TabIndex = 16;
            // 
            // cmbSearchPattern
            // 
            this.cmbSearchPattern.FormattingEnabled = true;
            this.cmbSearchPattern.Items.AddRange(new object[] {
            "*SOB*",
            "*APC*",
            "*AKIL*",
            "*HST*",
            "*MCR*",
            "*DOM*",
            "*ECO*",
            "*SRI*",
            "*IEN*",
            "*VER*",
            "*SRV*",
            "*HTTP*",
            "*STIP*",
            "*.TRC*"});
            this.cmbSearchPattern.Location = new System.Drawing.Point(146, 217);
            this.cmbSearchPattern.Name = "cmbSearchPattern";
            this.cmbSearchPattern.Size = new System.Drawing.Size(115, 24);
            this.cmbSearchPattern.TabIndex = 17;
            this.cmbSearchPattern.Text = "*.*";
            // 
            // btnFileList
            // 
            this.btnFileList.Image = global::Safiye.Properties.Resources._1416924046_documents;
            this.btnFileList.Location = new System.Drawing.Point(97, 328);
            this.btnFileList.Name = "btnFileList";
            this.btnFileList.Size = new System.Drawing.Size(59, 55);
            this.btnFileList.TabIndex = 18;
            this.btnFileList.UseVisualStyleBackColor = true;
            this.btnFileList.Click += new System.EventHandler(this.btnFileList_Click_1);
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Image = global::Safiye.Properties.Resources.folder;
            this.btnFolderBrowse.Location = new System.Drawing.Point(263, 250);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(38, 38);
            this.btnFolderBrowse.TabIndex = 9;
            this.btnFolderBrowse.UseVisualStyleBackColor = true;
            this.btnFolderBrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Safiye.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(12, 328);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 55);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(157, 125);
            this.txtStartTime.MaxLength = 8;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 22);
            this.txtStartTime.TabIndex = 20;
            this.txtStartTime.Text = "00:00:00";
            this.txtStartTime.Leave += new System.EventHandler(this.txtStartTime_Leave);
            // 
            // txtEndTime
            // 
            this.txtEndTime.Enabled = false;
            this.txtEndTime.Location = new System.Drawing.Point(157, 170);
            this.txtEndTime.MaxLength = 8;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 22);
            this.txtEndTime.TabIndex = 21;
            this.txtEndTime.Text = "23:59:59";
            this.txtEndTime.Leave += new System.EventHandler(this.txtEndTime_Leave);
            // 
            // chkStartTime
            // 
            this.chkStartTime.AutoSize = true;
            this.chkStartTime.Location = new System.Drawing.Point(122, 130);
            this.chkStartTime.Name = "chkStartTime";
            this.chkStartTime.Size = new System.Drawing.Size(18, 17);
            this.chkStartTime.TabIndex = 22;
            this.chkStartTime.UseVisualStyleBackColor = true;
            this.chkStartTime.CheckedChanged += new System.EventHandler(this.chkStartTime_CheckedChanged);
            // 
            // chkEndTime
            // 
            this.chkEndTime.AutoSize = true;
            this.chkEndTime.Location = new System.Drawing.Point(122, 174);
            this.chkEndTime.Name = "chkEndTime";
            this.chkEndTime.Size = new System.Drawing.Size(18, 17);
            this.chkEndTime.TabIndex = 23;
            this.chkEndTime.UseVisualStyleBackColor = true;
            this.chkEndTime.CheckedChanged += new System.EventHandler(this.chkEndTime_CheckedChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(9, 128);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(83, 17);
            this.lblStartTime.TabIndex = 24;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(15, 174);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(76, 17);
            this.lblEndTime.TabIndex = 25;
            this.lblEndTime.Text = "End Time";
            // 
            // btnStartTimeAdd
            // 
            this.btnStartTimeAdd.Location = new System.Drawing.Point(263, 123);
            this.btnStartTimeAdd.Name = "btnStartTimeAdd";
            this.btnStartTimeAdd.Size = new System.Drawing.Size(23, 28);
            this.btnStartTimeAdd.TabIndex = 26;
            this.btnStartTimeAdd.Text = "+";
            this.btnStartTimeAdd.UseVisualStyleBackColor = true;
            this.btnStartTimeAdd.Click += new System.EventHandler(this.btnStartTimePlus_Click);
            // 
            // btnStartTimeSubstract
            // 
            this.btnStartTimeSubstract.Location = new System.Drawing.Point(292, 123);
            this.btnStartTimeSubstract.Name = "btnStartTimeSubstract";
            this.btnStartTimeSubstract.Size = new System.Drawing.Size(23, 28);
            this.btnStartTimeSubstract.TabIndex = 27;
            this.btnStartTimeSubstract.Text = "-";
            this.btnStartTimeSubstract.UseVisualStyleBackColor = true;
            this.btnStartTimeSubstract.Click += new System.EventHandler(this.btnStartTimeNegative_Click);
            // 
            // btnEndTimeSubstract
            // 
            this.btnEndTimeSubstract.Location = new System.Drawing.Point(292, 167);
            this.btnEndTimeSubstract.Name = "btnEndTimeSubstract";
            this.btnEndTimeSubstract.Size = new System.Drawing.Size(23, 28);
            this.btnEndTimeSubstract.TabIndex = 29;
            this.btnEndTimeSubstract.Text = "-";
            this.btnEndTimeSubstract.UseVisualStyleBackColor = true;
            this.btnEndTimeSubstract.Click += new System.EventHandler(this.btnEndTimeSubstract_Click);
            // 
            // btnEndTimeAdd
            // 
            this.btnEndTimeAdd.Location = new System.Drawing.Point(263, 167);
            this.btnEndTimeAdd.Name = "btnEndTimeAdd";
            this.btnEndTimeAdd.Size = new System.Drawing.Size(23, 28);
            this.btnEndTimeAdd.TabIndex = 28;
            this.btnEndTimeAdd.Text = "+";
            this.btnEndTimeAdd.UseVisualStyleBackColor = true;
            this.btnEndTimeAdd.Click += new System.EventHandler(this.btnEndTimeAdd_Click);
            // 
            // chkError
            // 
            this.chkError.AutoSize = true;
            this.chkError.ForeColor = System.Drawing.Color.White;
            this.chkError.Location = new System.Drawing.Point(103, 294);
            this.chkError.Name = "chkError";
            this.chkError.Size = new System.Drawing.Size(62, 21);
            this.chkError.TabIndex = 30;
            this.chkError.Text = "Error";
            this.chkError.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 31;
            this.button2.Text = "Restart Service";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 33;
            this.button3.Text = "Stop Service";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkAllSet
            // 
            this.chkAllSet.AutoSize = true;
            this.chkAllSet.ForeColor = System.Drawing.Color.White;
            this.chkAllSet.Location = new System.Drawing.Point(16, 294);
            this.chkAllSet.Name = "chkAllSet";
            this.chkAllSet.Size = new System.Drawing.Size(70, 21);
            this.chkAllSet.TabIndex = 34;
            this.chkAllSet.Text = "All Set";
            this.chkAllSet.UseVisualStyleBackColor = true;
            this.chkAllSet.CheckedChanged += new System.EventHandler(this.chkAllSet_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1013, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(209, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Safiye.Properties.Resources.stick_figure_search_clues_anim_md_wm_v2;
            this.pictureBox1.Location = new System.Drawing.Point(575, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 219);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // SearchText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1114, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chkAllSet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkError);
            this.Controls.Add(this.btnEndTimeSubstract);
            this.Controls.Add(this.btnEndTimeAdd);
            this.Controls.Add(this.btnStartTimeSubstract);
            this.Controls.Add(this.btnStartTimeAdd);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.chkEndTime);
            this.Controls.Add(this.chkStartTime);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.btnFileList);
            this.Controls.Add(this.cmbSearchPattern);
            this.Controls.Add(this.cmbFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.chkSubFolders);
            this.Controls.Add(this.lblSearchPattern);
            this.Controls.Add(this.btnFolderBrowse);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblFoundFile);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchText";
            this.Load += new System.EventHandler(this.SearchText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label lblFoundFile;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblSearchPattern;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ComboBox cmbFolder;
        private System.Windows.Forms.ComboBox cmbSearchPattern;
        private System.Windows.Forms.Button btnFileList;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.CheckBox chkStartTime;
        private System.Windows.Forms.CheckBox chkEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnStartTimeAdd;
        private System.Windows.Forms.Button btnStartTimeSubstract;
        private System.Windows.Forms.Button btnEndTimeSubstract;
        private System.Windows.Forms.Button btnEndTimeAdd;
        private System.Windows.Forms.CheckBox chkError;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkAllSet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}