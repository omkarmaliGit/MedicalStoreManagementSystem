namespace MedicalStoreManagementSystem.Report
{
    partial class SalesReport
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
            this.dataGridView_salesReport = new System.Windows.Forms.DataGridView();
            this.label_viewSalesReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_salesReport
            // 
            this.dataGridView_salesReport.AllowUserToAddRows = false;
            this.dataGridView_salesReport.AllowUserToDeleteRows = false;
            this.dataGridView_salesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_salesReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_salesReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_salesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_salesReport.Location = new System.Drawing.Point(42, 92);
            this.dataGridView_salesReport.Name = "dataGridView_salesReport";
            this.dataGridView_salesReport.ReadOnly = true;
            this.dataGridView_salesReport.RowHeadersWidth = 51;
            this.dataGridView_salesReport.RowTemplate.Height = 30;
            this.dataGridView_salesReport.Size = new System.Drawing.Size(1318, 569);
            this.dataGridView_salesReport.TabIndex = 7;
            // 
            // label_viewSalesReport
            // 
            this.label_viewSalesReport.AutoSize = true;
            this.label_viewSalesReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(79)))));
            this.label_viewSalesReport.Location = new System.Drawing.Point(612, 27);
            this.label_viewSalesReport.Name = "label_viewSalesReport";
            this.label_viewSalesReport.Size = new System.Drawing.Size(211, 38);
            this.label_viewSalesReport.TabIndex = 6;
            this.label_viewSalesReport.Text = "SALES REPORT";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dataGridView_salesReport);
            this.Controls.Add(this.label_viewSalesReport);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_salesReport;
        private System.Windows.Forms.Label label_viewSalesReport;
    }
}