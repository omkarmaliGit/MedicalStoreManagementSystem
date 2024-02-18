namespace MedicalStoreManagementSystem.Company
{
    partial class RemoveCompany
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
            this.label_removeCompany_Title = new System.Windows.Forms.Label();
            this.label_companyName = new System.Windows.Forms.Label();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            this.button_removeCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_removeCompany_Title
            // 
            this.label_removeCompany_Title.AutoSize = true;
            this.label_removeCompany_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(131)))));
            this.label_removeCompany_Title.Location = new System.Drawing.Point(555, 48);
            this.label_removeCompany_Title.Name = "label_removeCompany_Title";
            this.label_removeCompany_Title.Size = new System.Drawing.Size(281, 38);
            this.label_removeCompany_Title.TabIndex = 0;
            this.label_removeCompany_Title.Text = "REMOVE COMPANY";
            // 
            // label_companyName
            // 
            this.label_companyName.AutoSize = true;
            this.label_companyName.Location = new System.Drawing.Point(524, 189);
            this.label_companyName.Name = "label_companyName";
            this.label_companyName.Size = new System.Drawing.Size(351, 38);
            this.label_companyName.TabIndex = 1;
            this.label_companyName.Text = "SELECT COMPANY NAME";
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(415, 267);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(582, 45);
            this.comboBox_companyName.TabIndex = 2;
            // 
            // button_removeCompany
            // 
            this.button_removeCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(131)))));
            this.button_removeCompany.ForeColor = System.Drawing.SystemColors.Control;
            this.button_removeCompany.Location = new System.Drawing.Point(531, 374);
            this.button_removeCompany.Name = "button_removeCompany";
            this.button_removeCompany.Size = new System.Drawing.Size(325, 70);
            this.button_removeCompany.TabIndex = 3;
            this.button_removeCompany.Text = "REMOVE COMPANY";
            this.button_removeCompany.UseVisualStyleBackColor = false;
            this.button_removeCompany.Click += new System.EventHandler(this.button_removeCompany_Click);
            // 
            // RemoveCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.button_removeCompany);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.label_companyName);
            this.Controls.Add(this.label_removeCompany_Title);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "RemoveCompany";
            this.Text = "RemoveMedicine";
            this.Load += new System.EventHandler(this.RemoveCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_removeCompany_Title;
        private System.Windows.Forms.Label label_companyName;
        private System.Windows.Forms.ComboBox comboBox_companyName;
        private System.Windows.Forms.Button button_removeCompany;
    }
}