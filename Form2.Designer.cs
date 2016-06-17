namespace Safiye
{
    partial class Form2
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
            this.gridPosTrnx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPosTrnx)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPosTrnx
            // 
            this.gridPosTrnx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPosTrnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPosTrnx.Location = new System.Drawing.Point(0, 0);
            this.gridPosTrnx.Name = "gridPosTrnx";
            this.gridPosTrnx.RowTemplate.Height = 24;
            this.gridPosTrnx.Size = new System.Drawing.Size(930, 233);
            this.gridPosTrnx.TabIndex = 20;
            this.gridPosTrnx.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPosTrnx_RowHeaderMouseDoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(930, 233);
            this.Controls.Add(this.gridPosTrnx);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPosTrnx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPosTrnx;
    }
}