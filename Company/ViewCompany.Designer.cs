namespace MedicalStoreManagementSystem.Company
{
    partial class ViewCompany
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
            this.label_viewCompany = new System.Windows.Forms.Label();
            this.dataGridView_companyTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_companyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label_viewCompany
            // 
            this.label_viewCompany.AutoSize = true;
            this.label_viewCompany.Location = new System.Drawing.Point(620, 28);
            this.label_viewCompany.Name = "label_viewCompany";
            this.label_viewCompany.Size = new System.Drawing.Size(214, 37);
            this.label_viewCompany.TabIndex = 0;
            this.label_viewCompany.Text = "COMPANY LIST";
            // 
            // dataGridView_companyTable
            // 
            this.dataGridView_companyTable.AllowUserToAddRows = false;
            this.dataGridView_companyTable.AllowUserToDeleteRows = false;
            this.dataGridView_companyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_companyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_companyTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_companyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_companyTable.Location = new System.Drawing.Point(43, 93);
            this.dataGridView_companyTable.Name = "dataGridView_companyTable";
            this.dataGridView_companyTable.ReadOnly = true;
            this.dataGridView_companyTable.RowHeadersWidth = 51;
            this.dataGridView_companyTable.RowTemplate.Height = 30;
            this.dataGridView_companyTable.Size = new System.Drawing.Size(1318, 569);
            this.dataGridView_companyTable.TabIndex = 1;
            // 
            // ViewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dataGridView_companyTable);
            this.Controls.Add(this.label_viewCompany);
            this.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "ViewCompany";
            this.Text = "viewCompany";
            this.Load += new System.EventHandler(this.viewCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_companyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_viewCompany;
        private System.Windows.Forms.DataGridView dataGridView_companyTable;
    }
}