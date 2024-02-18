namespace MedicalStoreManagementSystem.Company
{
    partial class UpdateCompany
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
            this.button_updateCompany = new System.Windows.Forms.Button();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.textBox_contactNumber = new System.Windows.Forms.TextBox();
            this.label_location = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_companyName = new System.Windows.Forms.Label();
            this.label_UpdateCompany_Title = new System.Windows.Forms.Label();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_updateCompany
            // 
            this.button_updateCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(131)))));
            this.button_updateCompany.ForeColor = System.Drawing.SystemColors.Control;
            this.button_updateCompany.Location = new System.Drawing.Point(562, 517);
            this.button_updateCompany.Name = "button_updateCompany";
            this.button_updateCompany.Size = new System.Drawing.Size(310, 70);
            this.button_updateCompany.TabIndex = 15;
            this.button_updateCompany.Text = "UPDATE COMPANY";
            this.button_updateCompany.UseVisualStyleBackColor = false;
            this.button_updateCompany.Click += new System.EventHandler(this.button_updateCompany_Click);
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(597, 333);
            this.textBox_location.Multiline = true;
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(523, 108);
            this.textBox_location.TabIndex = 14;
            // 
            // textBox_contactNumber
            // 
            this.textBox_contactNumber.Location = new System.Drawing.Point(597, 247);
            this.textBox_contactNumber.Name = "textBox_contactNumber";
            this.textBox_contactNumber.Size = new System.Drawing.Size(523, 42);
            this.textBox_contactNumber.TabIndex = 13;
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(294, 349);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(144, 38);
            this.label_location.TabIndex = 11;
            this.label_location.Text = "ADDRESS";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(294, 250);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(274, 38);
            this.label_contact.TabIndex = 10;
            this.label_contact.Text = "CONTACT NUMBER";
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(294, 166);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(250, 38);
            this.label_companyName.TabIndex = 9;
            this.label_companyName.Text = "COMPANY NAME";
            // 
            // label_UpdateCompany_Title
            // 
            this.label_UpdateCompany_Title.AutoSize = true;
            this.label_UpdateCompany_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(131)))));
            this.label_UpdateCompany_Title.Location = new System.Drawing.Point(577, 50);
            this.label_UpdateCompany_Title.Name = "label_UpdateCompany_Title";
            this.label_UpdateCompany_Title.Size = new System.Drawing.Size(275, 38);
            this.label_UpdateCompany_Title.TabIndex = 8;
            this.label_UpdateCompany_Title.Text = "UPDATE COMPANY";
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(597, 163);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(523, 45);
            this.comboBox_companyName.TabIndex = 16;
            this.comboBox_companyName.SelectedIndexChanged += new System.EventHandler(this.comboBox_companyName_SelectedIndexChanged);
            // 
            // UpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.button_updateCompany);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.textBox_contactNumber);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_UpdateCompany_Title);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "UpdateCompany";
            this.Text = "UpdateCompany";
            this.Load += new System.EventHandler(this.UpdateCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_updateCompany;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.TextBox textBox_contactNumber;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.Label label_UpdateCompany_Title;
        private System.Windows.Forms.ComboBox comboBox_companyName;
    }
}