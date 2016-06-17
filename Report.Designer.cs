namespace Safiye
{
    partial class Report
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
            this.gridPosTrnx.AllowUserToOrderColumns = true;
            this.gridPosTrnx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridPosTrnx.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPosTrnx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPosTrnx.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridPosTrnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPosTrnx.Location = new System.Drawing.Point(0, 0);
            this.gridPosTrnx.Name = "gridPosTrnx";
            this.gridPosTrnx.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridPosTrnx.RowTemplate.Height = 24;
            this.gridPosTrnx.Size = new System.Drawing.Size(1198, 416);
            this.gridPosTrnx.TabIndex = 20;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 416);
            this.Controls.Add(this.gridPosTrnx);
            this.Name = "Report";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPosTrnx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPosTrnx;
    }
}