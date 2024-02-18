namespace MedicalStoreManagementSystem.Company
{
    partial class AddCompany
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
            this.label_AddCompany_Title = new System.Windows.Forms.Label();
            this.label_companyName = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.textBox_companyName = new System.Windows.Forms.TextBox();
            this.textBox_contactNumber = new System.Windows.Forms.TextBox();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.button_addCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AddCompany_Title
            // 
            this.label_AddCompany_Title.AutoSize = true;
            this.label_AddCompany_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(131)))));
            this.label_AddCompany_Title.Location = new System.Drawing.Point(603, 40);
            this.label_AddCompany_Title.Name = "label_AddCompany_Title";
            this.label_AddCompany_Title.Size = new System.Drawing.Size(219, 37);
            this.label_AddCompany_Title.TabIndex = 0;
            this.label_AddCompany_Title.Text = "ADD COMPANY";
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(335, 162);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(240, 37);
            this.label_companyName.TabIndex = 1;
            this.label_companyName.Text = "COMPANY NAME";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(335, 246);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(266, 37);
            this.label_contact.TabIndex = 2;
            this.label_contact.Text = "CONTACT NUMBER";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(335, 345);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(138, 37);
            this.label_location.TabIndex = 3;
            this.label_location.Text = "ADDRESS";
            // 
            // textBox_companyName
            // 
            this.textBox_companyName.Location = new System.Drawing.Point(638, 159);
            this.textBox_companyName.Name = "textBox_companyName";
            this.textBox_companyName.Size = new System.Drawing.Size(523, 42);
            this.textBox_companyName.TabIndex = 4;
            // 
            // textBox_contactNumber
            // 
            this.textBox_contactNumber.Location = new System.Drawing.Point(638, 243);
            this.textBox_contactNumber.Name = "textBox_contactNumber";
            this.textBox_contactNumber.Size = new System.Drawing.Size(523, 42);
            this.textBox_contactNumber.TabIndex = 5;
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(638, 329);
            this.textBox_location.Multiline = true;
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(523, 108);
            this.textBox_location.TabIndex = 6;
            // 
            // button_addCompany
            // 
            this.button_addCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(131)))));
            this.button_addCompany.ForeColor = System.Drawing.SystemColors.Control;
            this.button_addCompany.Location = new System.Drawing.Point(588, 525);
            this.button_addCompany.Name = "button_addCompany";
            this.button_addCompany.Size = new System.Drawing.Size(260, 70);
            this.button_addCompany.TabIndex = 7;
            this.button_addCompany.Text = "ADD COMPANY";
            this.button_addCompany.UseVisualStyleBackColor = false;
            this.button_addCompany.Click += new System.EventHandler(this.button_addCompany_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.button_addCompany);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.textBox_contactNumber);
            this.Controls.Add(this.textBox_companyName);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_AddCompany_Title);
            this.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "AddCompany";
            this.Text = "AddCompany";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddCompany_Title;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.TextBox textBox_companyName;
        private System.Windows.Forms.TextBox textBox_contactNumber;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.Button button_addCompany;
    }
}