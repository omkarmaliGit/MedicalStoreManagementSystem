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
            this.button_search = new System.Windows.Forms.Button();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.label_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
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
            this.dataGridView_salesEntry.Location = new System.Drawing.Point(42, 173);
            this.dataGridView_salesEntry.Name = "dataGridView_salesEntry";
            this.dataGridView_salesEntry.ReadOnly = true;
            this.dataGridView_salesEntry.RowHeadersWidth = 51;
            this.dataGridView_salesEntry.RowTemplate.Height = 30;
            this.dataGridView_salesEntry.Size = new System.Drawing.Size(1318, 512);
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
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.button_search.ForeColor = System.Drawing.SystemColors.Control;
            this.button_search.Location = new System.Drawing.Point(995, 85);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(202, 54);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(687, 89);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(254, 42);
            this.dateTimePicker_To.TabIndex = 15;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_from.Location = new System.Drawing.Point(332, 89);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(254, 42);
            this.dateTimePicker_from.TabIndex = 14;
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(610, 94);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(54, 38);
            this.label_to.TabIndex = 13;
            this.label_to.Text = "TO";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(203, 94);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(98, 38);
            this.label_from.TabIndex = 12;
            this.label_from.Text = "FROM";
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dateTimePicker_To);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_from);
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
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
    }
}