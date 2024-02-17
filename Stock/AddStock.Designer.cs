namespace MedicalStoreManagementSystem.Stock
{
    partial class AddStock
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
            this.label_addStock = new System.Windows.Forms.Label();
            this.label_medicineName = new System.Windows.Forms.Label();
            this.label_companyName = new System.Windows.Forms.Label();
            this.comboBox_medicineName = new System.Windows.Forms.ComboBox();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_purchaseDate = new System.Windows.Forms.Label();
            this.label_expiryDate = new System.Windows.Forms.Label();
            this.button_addStock = new System.Windows.Forms.Button();
            this.dateTimePicker_purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_expiryDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_addStock
            // 
            this.label_addStock.AutoSize = true;
            this.label_addStock.Location = new System.Drawing.Point(624, 28);
            this.label_addStock.Name = "label_addStock";
            this.label_addStock.Size = new System.Drawing.Size(175, 38);
            this.label_addStock.TabIndex = 0;
            this.label_addStock.Text = "ADD STOCK";
            // 
            // label_medicineName
            // 
            this.label_medicineName.AutoSize = true;
            this.label_medicineName.Location = new System.Drawing.Point(178, 116);
            this.label_medicineName.Name = "label_medicineName";
            this.label_medicineName.Size = new System.Drawing.Size(244, 38);
            this.label_medicineName.TabIndex = 1;
            this.label_medicineName.Text = "MEDICINE NAME";
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(178, 189);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(250, 38);
            this.label_companyName.TabIndex = 2;
            this.label_companyName.Text = "COMPANY NAME";
            // 
            // comboBox_medicineName
            // 
            this.comboBox_medicineName.FormattingEnabled = true;
            this.comboBox_medicineName.Location = new System.Drawing.Point(498, 113);
            this.comboBox_medicineName.Name = "comboBox_medicineName";
            this.comboBox_medicineName.Size = new System.Drawing.Size(743, 45);
            this.comboBox_medicineName.TabIndex = 3;
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(498, 186);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(743, 45);
            this.comboBox_companyName.TabIndex = 4;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(178, 282);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(158, 38);
            this.label_quantity.TabIndex = 5;
            this.label_quantity.Text = "QUANTITY";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(752, 282);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(93, 38);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "PRICE";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(185, 344);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(482, 42);
            this.textBox_quantity.TabIndex = 7;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(759, 344);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(482, 42);
            this.textBox_price.TabIndex = 8;
            // 
            // label_purchaseDate
            // 
            this.label_purchaseDate.AutoSize = true;
            this.label_purchaseDate.Location = new System.Drawing.Point(752, 411);
            this.label_purchaseDate.Name = "label_purchaseDate";
            this.label_purchaseDate.Size = new System.Drawing.Size(242, 38);
            this.label_purchaseDate.TabIndex = 10;
            this.label_purchaseDate.Text = "PURCHACE DATE";
            // 
            // label_expiryDate
            // 
            this.label_expiryDate.AutoSize = true;
            this.label_expiryDate.Location = new System.Drawing.Point(178, 411);
            this.label_expiryDate.Name = "label_expiryDate";
            this.label_expiryDate.Size = new System.Drawing.Size(191, 38);
            this.label_expiryDate.TabIndex = 9;
            this.label_expiryDate.Text = "EXPIRY DATE";
            // 
            // button_addStock
            // 
            this.button_addStock.Location = new System.Drawing.Point(602, 562);
            this.button_addStock.Name = "button_addStock";
            this.button_addStock.Size = new System.Drawing.Size(235, 69);
            this.button_addStock.TabIndex = 13;
            this.button_addStock.Text = "ADD TO STOCK";
            this.button_addStock.UseVisualStyleBackColor = true;
            this.button_addStock.Click += new System.EventHandler(this.button_addStock_Click);
            // 
            // dateTimePicker_purchaseDate
            // 
            this.dateTimePicker_purchaseDate.Enabled = false;
            this.dateTimePicker_purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_purchaseDate.Location = new System.Drawing.Point(759, 471);
            this.dateTimePicker_purchaseDate.Name = "dateTimePicker_purchaseDate";
            this.dateTimePicker_purchaseDate.Size = new System.Drawing.Size(482, 42);
            this.dateTimePicker_purchaseDate.TabIndex = 15;
            // 
            // dateTimePicker_expiryDate
            // 
            this.dateTimePicker_expiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_expiryDate.Location = new System.Drawing.Point(185, 471);
            this.dateTimePicker_expiryDate.Name = "dateTimePicker_expiryDate";
            this.dateTimePicker_expiryDate.Size = new System.Drawing.Size(482, 42);
            this.dateTimePicker_expiryDate.TabIndex = 14;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.dateTimePicker_purchaseDate);
            this.Controls.Add(this.dateTimePicker_expiryDate);
            this.Controls.Add(this.button_addStock);
            this.Controls.Add(this.label_purchaseDate);
            this.Controls.Add(this.label_expiryDate);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.comboBox_medicineName);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_medicineName);
            this.Controls.Add(this.label_addStock);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addStock;
        private System.Windows.Forms.Label label_medicineName;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.ComboBox comboBox_medicineName;
        private System.Windows.Forms.ComboBox comboBox_companyName;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_purchaseDate;
        private System.Windows.Forms.Label label_expiryDate;
        private System.Windows.Forms.Button button_addStock;
        private System.Windows.Forms.DateTimePicker dateTimePicker_purchaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expiryDate;
    }
}