namespace MedicalStoreManagementSystem.Sales
{
    partial class ViewSales
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
            this.dataGridView_salesEntry = new System.Windows.Forms.DataGridView();
            this.label_viewSalesEntry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salesEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_salesEntry
            // 
            this.dataGridView_salesEntry.AllowUserToAddRows = false;
            this.dataGridView_salesEntry.AllowUserToDeleteRows = false;
            this.dataGridView_salesEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_salesEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_salesEntry.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_salesEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_salesEntry.Location = new System.Drawing.Point(42, 89);
            this.dataGridView_salesEntry.Name = "dataGridView_salesEntry";
            this.dataGridView_salesEntry.ReadOnly = true;
            this.dataGridView_salesEntry.RowHeadersWidth = 51;
            this.dataGridView_salesEntry.RowTemplate.Height = 30;
            this.dataGridView_salesEntry.Size = new System.Drawing.Size(1318, 569);
            this.dataGridView_salesEntry.TabIndex = 5;
            // 
            // label_viewSalesEntry
            // 
            this.label_viewSalesEntry.AutoSize = true;
            this.label_viewSalesEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.label_viewSalesEntry.Location = new System.Drawing.Point(619, 24);
            this.label_viewSalesEntry.Name = "label_viewSalesEntry";
            this.label_viewSalesEntry.Size = new System.Drawing.Size(217, 38);
            this.label_viewSalesEntry.TabIndex = 4;
            this.label_viewSalesEntry.Text = "SALES ENTRIES";
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dataGridView_salesEntry);
            this.Controls.Add(this.label_viewSalesEntry);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salesEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_salesEntry;
        private System.Windows.Forms.Label label_viewSalesEntry;
    }
}