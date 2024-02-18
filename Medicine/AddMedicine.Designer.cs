namespace MedicalStoreManagementSystem.Medicine
{
    partial class AddMedicine
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
            this.label_addMedicine_Title = new System.Windows.Forms.Label();
            this.label_medicineName = new System.Windows.Forms.Label();
            this.label_genericName = new System.Windows.Forms.Label();
            this.label_medicineType = new System.Windows.Forms.Label();
            this.label_companyName = new System.Windows.Forms.Label();
            this.textBox_medicineName = new System.Windows.Forms.TextBox();
            this.textBox_genericName = new System.Windows.Forms.TextBox();
            this.comboBox_medicineType = new System.Windows.Forms.ComboBox();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_addMedicine_Title
            // 
            this.label_addMedicine_Title.AutoSize = true;
            this.label_addMedicine_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.label_addMedicine_Title.Location = new System.Drawing.Point(602, 36);
            this.label_addMedicine_Title.Name = "label_addMedicine_Title";
            this.label_addMedicine_Title.Size = new System.Drawing.Size(213, 37);
            this.label_addMedicine_Title.TabIndex = 0;
            this.label_addMedicine_Title.Text = "ADD MEDICINE";
            // 
            // label_medicineName
            // 
            this.label_medicineName.AutoSize = true;
            this.label_medicineName.Location = new System.Drawing.Point(346, 134);
            this.label_medicineName.Name = "label_medicineName";
            this.label_medicineName.Size = new System.Drawing.Size(234, 37);
            this.label_medicineName.TabIndex = 1;
            this.label_medicineName.Text = "MEDICINE NAME";
            // 
            // label_genericName
            // 
            this.label_genericName.AutoSize = true;
            this.label_genericName.Location = new System.Drawing.Point(346, 224);
            this.label_genericName.Name = "label_genericName";
            this.label_genericName.Size = new System.Drawing.Size(216, 37);
            this.label_genericName.TabIndex = 2;
            this.label_genericName.Text = "GENERIC NAME";
            // 
            // label_medicineType
            // 
            this.label_medicineType.AutoSize = true;
            this.label_medicineType.Location = new System.Drawing.Point(346, 316);
            this.label_medicineType.Name = "label_medicineType";
            this.label_medicineType.Size = new System.Drawing.Size(217, 37);
            this.label_medicineType.TabIndex = 3;
            this.label_medicineType.Text = "MEDICINE TYPE";
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(346, 409);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(240, 37);
            this.label_companyName.TabIndex = 4;
            this.label_companyName.Text = "COMPANY NAME";
            // 
            // textBox_medicineName
            // 
            this.textBox_medicineName.Location = new System.Drawing.Point(640, 131);
            this.textBox_medicineName.Name = "textBox_medicineName";
            this.textBox_medicineName.Size = new System.Drawing.Size(477, 42);
            this.textBox_medicineName.TabIndex = 5;
            // 
            // textBox_genericName
            // 
            this.textBox_genericName.Location = new System.Drawing.Point(640, 221);
            this.textBox_genericName.Name = "textBox_genericName";
            this.textBox_genericName.Size = new System.Drawing.Size(477, 42);
            this.textBox_genericName.TabIndex = 6;
            // 
            // comboBox_medicineType
            // 
            this.comboBox_medicineType.FormattingEnabled = true;
            this.comboBox_medicineType.Items.AddRange(new object[] {
            "Tablet",
            "Capsule",
            "Syrup",
            "Drops",
            "Inhalers",
            "Injections",
            "Antiseptic",
            "Oral rinse",
            "Lotion",
            "Spray",
            "Gel",
            "Powder"});
            this.comboBox_medicineType.Location = new System.Drawing.Point(640, 313);
            this.comboBox_medicineType.Name = "comboBox_medicineType";
            this.comboBox_medicineType.Size = new System.Drawing.Size(477, 45);
            this.comboBox_medicineType.TabIndex = 7;
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(640, 406);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(477, 45);
            this.comboBox_companyName.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(584, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD MEDICINE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.comboBox_medicineType);
            this.Controls.Add(this.textBox_genericName);
            this.Controls.Add(this.textBox_medicineName);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_medicineType);
            this.Controls.Add(this.label_genericName);
            this.Controls.Add(this.label_medicineName);
            this.Controls.Add(this.label_addMedicine_Title);
            this.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addMedicine_Title;
        private System.Windows.Forms.Label label_medicineName;
        private System.Windows.Forms.Label label_genericName;
        private System.Windows.Forms.Label label_medicineType;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.TextBox textBox_medicineName;
        private System.Windows.Forms.TextBox textBox_genericName;
        private System.Windows.Forms.ComboBox comboBox_medicineType;
        private System.Windows.Forms.ComboBox comboBox_companyName;
        private System.Windows.Forms.Button button1;
    }
}