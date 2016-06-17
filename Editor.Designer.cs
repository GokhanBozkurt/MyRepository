namespace Safiye
{
    partial class Editor
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
            this.richAscii = new System.Windows.Forms.RichTextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblSelectedLength = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richHex = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnAscii = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richAscii
            // 
            this.richAscii.Location = new System.Drawing.Point(74, 10);
            this.richAscii.Name = "richAscii";
            this.richAscii.Size = new System.Drawing.Size(575, 58);
            this.richAscii.TabIndex = 0;
            this.richAscii.Text = "";
            this.richAscii.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richAscii.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(11, 30);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 17);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length :";
            // 
            // lblSelectedLength
            // 
            this.lblSelectedLength.AutoSize = true;
            this.lblSelectedLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedLength.ForeColor = System.Drawing.Color.White;
            this.lblSelectedLength.Location = new System.Drawing.Point(11, 62);
            this.lblSelectedLength.Name = "lblSelectedLength";
            this.lblSelectedLength.Size = new System.Drawing.Size(136, 17);
            this.lblSelectedLength.TabIndex = 2;
            this.lblSelectedLength.Text = "Selected Length :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.lblSelectedLength);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(74, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text";
            // 
            // richHex
            // 
            this.richHex.Location = new System.Drawing.Point(74, 74);
            this.richHex.Name = "richHex";
            this.richHex.Size = new System.Drawing.Size(575, 58);
            this.richHex.TabIndex = 6;
            this.richHex.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "HEX";
            // 
            // btnHex
            // 
            this.btnHex.Image = global::Safiye.Properties.Resources._1416939549_ascii;
            this.btnHex.Location = new System.Drawing.Point(655, 95);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(34, 37);
            this.btnHex.TabIndex = 9;
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAscii
            // 
            this.btnAscii.Image = global::Safiye.Properties.Resources._1416939644_ascii__2_;
            this.btnAscii.Location = new System.Drawing.Point(655, 17);
            this.btnAscii.Name = "btnAscii";
            this.btnAscii.Size = new System.Drawing.Size(38, 42);
            this.btnAscii.TabIndex = 5;
            this.btnAscii.UseVisualStyleBackColor = true;
            this.btnAscii.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Safiye.Properties.Resources._1416842860_edit_clear;
            this.btnClear.Location = new System.Drawing.Point(699, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Safiye.Properties.Resources._1416842860_edit_clear;
            this.button1.Location = new System.Drawing.Point(695, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(765, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richHex);
            this.Controls.Add(this.btnAscii);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richAscii);
            this.Name = "Editor";
            this.Text = "Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richAscii;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSelectedLength;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAscii;
        private System.Windows.Forms.RichTextBox richHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button button1;
    }
}