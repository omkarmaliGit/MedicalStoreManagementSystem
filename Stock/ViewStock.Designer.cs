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
            this.label_from = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stockEntry
            // 
            this.dataGridView_stockEntry.AllowUserToAddRows = false;
            this.dataGridView_stockEntry.AllowUserToDeleteRows = false;
            this.dataGridView_stockEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stockEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_stockEntry.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_stockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockEntry.Location = new System.Drawing.Point(42, 168);
            this.dataGridView_stockEntry.Name = "dataGridView_stockEntry";
            this.dataGridView_stockEntry.ReadOnly = true;
            this.dataGridView_stockEntry.RowHeadersWidth = 51;
            this.dataGridView_stockEntry.RowTemplate.Height = 30;
            this.dataGridView_stockEntry.Size = new System.Drawing.Size(1318, 520);
            this.dataGridView_stockEntry.TabIndex = 3;
            // 
            // label_viewStockEntry
            // 
            this.label_viewStockEntry.AutoSize = true;
            this.label_viewStockEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(176)))), ((int)(((byte)(123)))));
            this.label_viewStockEntry.Location = new System.Drawing.Point(615, 26);
            this.label_viewStockEntry.Name = "label_viewStockEntry";
            this.label_viewStockEntry.Size = new System.Drawing.Size(224, 38);
            this.label_viewStockEntry.TabIndex = 2;
            this.label_viewStockEntry.Text = "STOCK ENTRIES";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(193, 92);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(98, 38);
            this.label_from.TabIndex = 7;
            this.label_from.Text = "FROM";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(600, 92);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(54, 38);
            this.label_to.TabIndex = 8;
            this.label_to.Text = "TO";
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_from.Location = new System.Drawing.Point(322, 87);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(254, 42);
            this.dateTimePicker_from.TabIndex = 9;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(677, 87);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(254, 42);
            this.dateTimePicker_To.TabIndex = 10;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(176)))), ((int)(((byte)(123)))));
            this.button_search.ForeColor = System.Drawing.SystemColors.Control;
            this.button_search.Location = new System.Drawing.Point(985, 83);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(202, 54);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dateTimePicker_To);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_from);
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
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Button button_search;
    }
}