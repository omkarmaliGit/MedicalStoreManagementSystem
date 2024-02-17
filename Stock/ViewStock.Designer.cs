namespace MedicalStoreManagementSystem.Stock
{
    partial class ViewStock
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
            this.dataGridView_stockEntry = new System.Windows.Forms.DataGridView();
            this.label_viewStockEntry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stockEntry
            // 
            this.dataGridView_stockEntry.AllowUserToAddRows = false;
            this.dataGridView_stockEntry.AllowUserToDeleteRows = false;
            this.dataGridView_stockEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_stockEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_stockEntry.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_stockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockEntry.Location = new System.Drawing.Point(42, 92);
            this.dataGridView_stockEntry.Name = "dataGridView_stockEntry";
            this.dataGridView_stockEntry.ReadOnly = true;
            this.dataGridView_stockEntry.RowHeadersWidth = 51;
            this.dataGridView_stockEntry.RowTemplate.Height = 30;
            this.dataGridView_stockEntry.Size = new System.Drawing.Size(1318, 569);
            this.dataGridView_stockEntry.TabIndex = 3;
            // 
            // label_viewStockEntry
            // 
            this.label_viewStockEntry.AutoSize = true;
            this.label_viewStockEntry.Location = new System.Drawing.Point(619, 27);
            this.label_viewStockEntry.Name = "label_viewStockEntry";
            this.label_viewStockEntry.Size = new System.Drawing.Size(224, 38);
            this.label_viewStockEntry.TabIndex = 2;
            this.label_viewStockEntry.Text = "STOCK ENTRIES";
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dataGridView_stockEntry);
            this.Controls.Add(this.label_viewStockEntry);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "ViewStock";
            this.Text = "ViewStock";
            this.Load += new System.EventHandler(this.ViewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stockEntry;
        private System.Windows.Forms.Label label_viewStockEntry;
    }
}