namespace MedicalStoreManagementSystem.Medicine
{
    partial class RemoveMedicine
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
            this.label_removeMedicine = new System.Windows.Forms.Label();
            this.label_selectMedicine = new System.Windows.Forms.Label();
            this.comboBox_medicine = new System.Windows.Forms.ComboBox();
            this.button_removeMedicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_removeMedicine
            // 
            this.label_removeMedicine.AutoSize = true;
            this.label_removeMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.label_removeMedicine.Location = new System.Drawing.Point(580, 27);
            this.label_removeMedicine.Name = "label_removeMedicine";
            this.label_removeMedicine.Size = new System.Drawing.Size(264, 37);
            this.label_removeMedicine.TabIndex = 0;
            this.label_removeMedicine.Text = "REMOVE MEDICINE";
            // 
            // label_selectMedicine
            // 
            this.label_selectMedicine.AutoSize = true;
            this.label_selectMedicine.Location = new System.Drawing.Point(551, 177);
            this.label_selectMedicine.Name = "label_selectMedicine";
            this.label_selectMedicine.Size = new System.Drawing.Size(331, 37);
            this.label_selectMedicine.TabIndex = 1;
            this.label_selectMedicine.Text = "SELECT MEDICINE NAME";
            // 
            // comboBox_medicine
            // 
            this.comboBox_medicine.FormattingEnabled = true;
            this.comboBox_medicine.Location = new System.Drawing.Point(379, 265);
            this.comboBox_medicine.Name = "comboBox_medicine";
            this.comboBox_medicine.Size = new System.Drawing.Size(644, 45);
            this.comboBox_medicine.TabIndex = 2;
            // 
            // button_removeMedicine
            // 
            this.button_removeMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.button_removeMedicine.ForeColor = System.Drawing.SystemColors.Control;
            this.button_removeMedicine.Location = new System.Drawing.Point(627, 365);
            this.button_removeMedicine.Name = "button_removeMedicine";
            this.button_removeMedicine.Size = new System.Drawing.Size(175, 70);
            this.button_removeMedicine.TabIndex = 3;
            this.button_removeMedicine.Text = "REMOVE";
            this.button_removeMedicine.UseVisualStyleBackColor = false;
            this.button_removeMedicine.Click += new System.EventHandler(this.button_removeMedicine_Click);
            // 
            // RemoveMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 752);
            this.Controls.Add(this.button_removeMedicine);
            this.Controls.Add(this.comboBox_medicine);
            this.Controls.Add(this.label_selectMedicine);
            this.Controls.Add(this.label_removeMedicine);
            this.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1420, 799);
            this.Name = "RemoveMedicine";
            this.Text = "RemoveMedicine";
            this.Load += new System.EventHandler(this.RemoveMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_removeMedicine;
        private System.Windows.Forms.Label label_selectMedicine;
        private System.Windows.Forms.ComboBox comboBox_medicine;
        private System.Windows.Forms.Button button_removeMedicine;
    }
}