namespace MedicalStoreManagementSystem.Sales
{
    partial class AddSales
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
            this.dateTimePicker_saleDate = new System.Windows.Forms.DateTimePicker();
            this.button_addSales = new System.Windows.Forms.Button();
            this.label_saleDate = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            this.comboBox_medicineName = new System.Windows.Forms.ComboBox();
            this.label_companyName = new System.Windows.Forms.Label();
            this.label_medicineName = new System.Windows.Forms.Label();
            this.label_addSales = new System.Windows.Forms.Label();
            this.textBox_totalPrice = new System.Windows.Forms.TextBox();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_saleDate
            // 
            this.dateTimePicker_saleDate.Enabled = false;
            this.dateTimePicker_saleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_saleDate.Location = new System.Drawing.Point(751, 470);
            this.dateTimePicker_saleDate.Name = "dateTimePicker_saleDate";
            this.dateTimePicker_saleDate.Size = new System.Drawing.Size(482, 42);
            this.dateTimePicker_saleDate.TabIndex = 29;
            // 
            // button_addSales
            // 
            this.button_addSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.button_addSales.ForeColor = System.Drawing.SystemColors.Control;
            this.button_addSales.Location = new System.Drawing.Point(602, 559);
            this.button_addSales.Name = "button_addSales";
            this.button_addSales.Size = new System.Drawing.Size(240, 70);
            this.button_addSales.TabIndex = 27;
            this.button_addSales.Text = "ADD TO SALES";
            this.button_addSales.UseVisualStyleBackColor = false;
            this.button_addSales.Click += new System.EventHandler(this.button_addSales_Click);
            // 
            // label_saleDate
            // 
            this.label_saleDate.AutoSize = true;
            this.label_saleDate.Location = new System.Drawing.Point(744, 408);
            this.label_saleDate.Name = "label_saleDate";
            this.label_saleDate.Size = new System.Drawing.Size(162, 38);
            this.label_saleDate.TabIndex = 26;
            this.label_saleDate.Text = "SALE DATE";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(751, 337);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(482, 42);
            this.textBox_price.TabIndex = 24;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(177, 337);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(482, 42);
            this.textBox_quantity.TabIndex = 23;
            this.textBox_quantity.TextChanged += new System.EventHandler(this.textBox_quantity_TextChanged);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(744, 275);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(226, 38);
            this.label_price.TabIndex = 22;
            this.label_price.Text = "PRICE PER UNIT";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(170, 275);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(158, 38);
            this.label_quantity.TabIndex = 21;
            this.label_quantity.Text = "QUANTITY";
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(490, 179);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(743, 45);
            this.comboBox_companyName.TabIndex = 20;
            // 
            // comboBox_medicineName
            // 
            this.comboBox_medicineName.FormattingEnabled = true;
            this.comboBox_medicineName.Location = new System.Drawing.Point(490, 106);
            this.comboBox_medicineName.Name = "comboBox_medicineName";
            this.comboBox_medicineName.Size = new System.Drawing.Size(743, 45);
            this.comboBox_medicineName.TabIndex = 19;
            this.comboBox_medicineName.SelectedIndexChanged += new System.EventHandler(this.comboBox_medicineName_SelectedIndexChanged);
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(170, 182);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(250, 38);
            this.label_companyName.TabIndex = 18;
            this.label_companyName.Text = "COMPANY NAME";
            // 
            // label_medicineName
            // 
            this.label_medicineName.AutoSize = true;
            this.label_medicineName.Location = new System.Drawing.Point(170, 109);
            this.label_medicineName.Name = "label_medicineName";
            this.label_medicineName.Size = new System.Drawing.Size(244, 38);
            this.label_medicineName.TabIndex = 17;
            this.label_medicineName.Text = "MEDICINE NAME";
            // 
            // label_addSales
            // 
            this.label_addSales.AutoSize = true;
            this.label_addSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(184)))));
            this.label_addSales.Location = new System.Drawing.Point(616, 27);
            this.label_addSales.Name = "label_addSales";
            this.label_addSales.Size = new System.Drawing.Size(194, 38);
            this.label_addSales.TabIndex = 16;
            this.label_addSales.Text = "SALES ENTRY";
            // 
            // textBox_totalPrice
            // 
            this.textBox_totalPrice.Location = new System.Drawing.Point(177, 470);
            this.textBox_totalPrice.Name = "textBox_totalPrice";
            this.textBox_totalPrice.Size = new System.Drawing.Size(482, 42);
            this.textBox_totalPrice.TabIndex = 31;
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Location = new System.Drawing.Point(170, 408);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(188, 38);
            this.label_totalPrice.TabIndex = 30;
            this.label_totalPrice.Text = "TOTAL PRICE";
            // 
            // AddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.textBox_totalPrice);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.dateTimePicker_saleDate);
            this.Controls.Add(this.button_addSales);
            this.Controls.Add(this.label_saleDate);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.comboBox_medicineName);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_medicineName);
            this.Controls.Add(this.label_addSales);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "AddSales";
            this.Text = "AddSales";
            this.Load += new System.EventHandler(this.AddSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_saleDate;
        private System.Windows.Forms.Button button_addSales;
        private System.Windows.Forms.Label label_saleDate;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.ComboBox comboBox_companyName;
        private System.Windows.Forms.ComboBox comboBox_medicineName;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.Label label_medicineName;
        private System.Windows.Forms.Label label_addSales;
        private System.Windows.Forms.TextBox textBox_totalPrice;
        private System.Windows.Forms.Label label_totalPrice;
    }
}