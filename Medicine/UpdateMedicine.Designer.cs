namespace MedicalStoreManagementSystem.Medicine
{
    partial class UpdateMedicine
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
            this.label_updateMedicine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            this.comboBox_medicineType = new System.Windows.Forms.ComboBox();
            this.textBox_genericName = new System.Windows.Forms.TextBox();
            this.label_companyName = new System.Windows.Forms.Label();
            this.label_medicineType = new System.Windows.Forms.Label();
            this.label_genericName = new System.Windows.Forms.Label();
            this.label_medicineName = new System.Windows.Forms.Label();
            this.comboBox_medicineName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_updateMedicine
            // 
            this.label_updateMedicine.AutoSize = true;
            this.label_updateMedicine.Location = new System.Drawing.Point(592, 49);
            this.label_updateMedicine.Name = "label_updateMedicine";
            this.label_updateMedicine.Size = new System.Drawing.Size(260, 37);
            this.label_updateMedicine.TabIndex = 0;
            this.label_updateMedicine.Text = "UPDATE MEDICINE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(565, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 86);
            this.button1.TabIndex = 18;
            this.button1.Text = "UPDATE MEDICINE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(610, 422);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(477, 45);
            this.comboBox_companyName.TabIndex = 17;
            // 
            // comboBox_medicineType
            // 
            this.comboBox_medicineType.FormattingEnabled = true;
            this.comboBox_medicineType.Location = new System.Drawing.Point(610, 329);
            this.comboBox_medicineType.Name = "comboBox_medicineType";
            this.comboBox_medicineType.Size = new System.Drawing.Size(477, 45);
            this.comboBox_medicineType.TabIndex = 16;
            // 
            // textBox_genericName
            // 
            this.textBox_genericName.Location = new System.Drawing.Point(610, 237);
            this.textBox_genericName.Name = "textBox_genericName";
            this.textBox_genericName.Size = new System.Drawing.Size(477, 42);
            this.textBox_genericName.TabIndex = 15;
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(316, 425);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(240, 37);
            this.label_companyName.TabIndex = 13;
            this.label_companyName.Text = "COMPANY NAME";
            // 
            // label_medicineType
            // 
            this.label_medicineType.AutoSize = true;
            this.label_medicineType.Location = new System.Drawing.Point(316, 332);
            this.label_medicineType.Name = "label_medicineType";
            this.label_medicineType.Size = new System.Drawing.Size(217, 37);
            this.label_medicineType.TabIndex = 12;
            this.label_medicineType.Text = "MEDICINE TYPE";
            // 
            // label_genericName
            // 
            this.label_genericName.AutoSize = true;
            this.label_genericName.Location = new System.Drawing.Point(316, 240);
            this.label_genericName.Name = "label_genericName";
            this.label_genericName.Size = new System.Drawing.Size(216, 37);
            this.label_genericName.TabIndex = 11;
            this.label_genericName.Text = "GENERIC NAME";
            // 
            // label_medicineName
            // 
            this.label_medicineName.AutoSize = true;
            this.label_medicineName.Location = new System.Drawing.Point(316, 150);
            this.label_medicineName.Name = "label_medicineName";
            this.label_medicineName.Size = new System.Drawing.Size(234, 37);
            this.label_medicineName.TabIndex = 10;
            this.label_medicineName.Text = "MEDICINE NAME";
            // 
            // comboBox_medicineName
            // 
            this.comboBox_medicineName.FormattingEnabled = true;
            this.comboBox_medicineName.Location = new System.Drawing.Point(610, 147);
            this.comboBox_medicineName.Name = "comboBox_medicineName";
            this.comboBox_medicineName.Size = new System.Drawing.Size(477, 45);
            this.comboBox_medicineName.TabIndex = 19;
            this.comboBox_medicineName.SelectedIndexChanged += new System.EventHandler(this.comboBox_medicineName_SelectedIndexChanged);
            // 
            // UpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.comboBox_medicineName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.comboBox_medicineType);
            this.Controls.Add(this.textBox_genericName);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_medicineType);
            this.Controls.Add(this.label_genericName);
            this.Controls.Add(this.label_medicineName);
            this.Controls.Add(this.label_updateMedicine);
            this.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "UpdateMedicine";
            this.Text = "UpdateMedicine";
            this.Load += new System.EventHandler(this.UpdateMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_updateMedicine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_companyName;
        private System.Windows.Forms.ComboBox comboBox_medicineType;
        private System.Windows.Forms.TextBox textBox_genericName;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.Label label_medicineType;
        private System.Windows.Forms.Label label_genericName;
        private System.Windows.Forms.Label label_medicineName;
        private System.Windows.Forms.ComboBox comboBox_medicineName;
    }
}