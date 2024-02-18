namespace MedicalStoreManagementSystem.Report
{
    partial class StockReport
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
            this.dataGridView_stockReport = new System.Windows.Forms.DataGridView();
            this.label_viewStockReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stockReport
            // 
            this.dataGridView_stockReport.AllowUserToAddRows = false;
            this.dataGridView_stockReport.AllowUserToDeleteRows = false;
            this.dataGridView_stockReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stockReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_stockReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_stockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockReport.Location = new System.Drawing.Point(49, 83);
            this.dataGridView_stockReport.Name = "dataGridView_stockReport";
            this.dataGridView_stockReport.ReadOnly = true;
            this.dataGridView_stockReport.RowHeadersWidth = 51;
            this.dataGridView_stockReport.RowTemplate.Height = 30;
            this.dataGridView_stockReport.Size = new System.Drawing.Size(1318, 569);
            this.dataGridView_stockReport.TabIndex = 5;
            // 
            // label_viewStockReport
            // 
            this.label_viewStockReport.AutoSize = true;
            this.label_viewStockReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(67)))));
            this.label_viewStockReport.Location = new System.Drawing.Point(619, 18);
            this.label_viewStockReport.Name = "label_viewStockReport";
            this.label_viewStockReport.Size = new System.Drawing.Size(218, 38);
            this.label_viewStockReport.TabIndex = 4;
            this.label_viewStockReport.Text = "STOCK REPORT";
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dataGridView_stockReport);
            this.Controls.Add(this.label_viewStockReport);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "StockReport";
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stockReport;
        private System.Windows.Forms.Label label_viewStockReport;
    }
}