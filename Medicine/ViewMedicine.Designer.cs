namespace MedicalStoreManagementSystem.Medicine
{
    partial class ViewMedicine
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
            this.label_viewMedicine = new System.Windows.Forms.Label();
            this.dataGridView_medicineTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medicineTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label_viewMedicine
            // 
            this.label_viewMedicine.AutoSize = true;
            this.label_viewMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.label_viewMedicine.Location = new System.Drawing.Point(611, 28);
            this.label_viewMedicine.Name = "label_viewMedicine";
            this.label_viewMedicine.Size = new System.Drawing.Size(208, 37);
            this.label_viewMedicine.TabIndex = 0;
            this.label_viewMedicine.Text = "MEDICINE LIST";
            // 
            // dataGridView_medicineTable
            // 
            this.dataGridView_medicineTable.AllowUserToAddRows = false;
            this.dataGridView_medicineTable.AllowUserToDeleteRows = false;
            this.dataGridView_medicineTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_medicineTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_medicineTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_medicineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_medicineTable.Location = new System.Drawing.Point(43, 93);
            this.dataGridView_medicineTable.Name = "dataGridView_medicineTable";
            this.dataGridView_medicineTable.ReadOnly = true;
            this.dataGridView_medicineTable.RowHeadersWidth = 51;
            this.dataGridView_medicineTable.RowTemplate.Height = 30;
            this.dataGridView_medicineTable.Size = new System.Drawing.Size(1318, 569);
            this.dataGridView_medicineTable.TabIndex = 1;
            // 
            // ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dataGridView_medicineTable);
            this.Controls.Add(this.label_viewMedicine);
            this.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "ViewMedicine";
            this.Text = "viewCompany";
            this.Load += new System.EventHandler(this.ViewMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medicineTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_viewMedicine;
        private System.Windows.Forms.DataGridView dataGridView_medicineTable;
    }
}