using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Medicine
{
    public partial class UpdateMedicine : Form
    {
        public UpdateMedicine()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        SqlDataReader dr;
        string query;

        private void UpdateMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox_medicineName.Focus();
                query = $"SELECT medicineName FROM medicine";
                dr = db.getData(query);
                while (dr.Read())
                {
                    comboBox_medicineName.Items.Add(dr[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void comboBox_medicineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM medicine WHERE medicineName = '{comboBox_medicineName.Text}'";
                dr = db.getData(query);
                while (dr.Read())
                {
                    textBox_genericName.Text = dr[1].ToString();
                    comboBox_medicineType.Text = dr[2].ToString();
                    comboBox_companyName.Text = dr[3].ToString();
                }
                db.closeConnection();

                comboBox_medicineType.Items.Clear();
                string[] MedicineType = { "Tablet", "Capsule", "Syrup", "Drops", "Inhalers", "Injections", "Antiseptic", "Oral rinse", "Lotion", "Spray", "Gel", "Powder" };
                comboBox_medicineType.Items.AddRange(MedicineType);

                comboBox_companyName.Items.Clear();
                query = $"SELECT companyName FROM company";
                dr = db.getData(query);
                while (dr.Read())
                {
                    comboBox_companyName.Items.Add(dr[0].ToString());
                }
                db.closeConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_medicineName.Text != "")
                {
                    if (textBox_genericName.Text != "")
                    {
                        if (comboBox_medicineType.Text != "")
                        {
                            if (comboBox_companyName.Text != "")
                            {
                                query = $"SELECT companyName FROM company";
                                dr = db.getData(query);
                                bool found = false;
                                while (dr.Read())
                                {
                                    if (dr[0].ToString() == comboBox_companyName.Text)
                                    {
                                        found = true;
                                    }
                                }
                                db.closeConnection();

                                if (found)
                                {
                                    try
                                    {
                                        query = $"UPDATE medicine SET medicineName = '{comboBox_medicineName.Text}', genericName = '{textBox_genericName.Text}', medicineType = '{comboBox_medicineType.SelectedItem}', companyName = '{comboBox_companyName.Text}' WHERE medicineName = '{comboBox_medicineName.Text}'";
                                        db.setData(query);
                                        MessageBox.Show("Medicine updated to list");

                                        comboBox_medicineName.Text = "";
                                        textBox_genericName.Text = "";
                                        comboBox_medicineType.Text = "";
                                        comboBox_companyName.Text = "";
                                        comboBox_medicineName.Focus();
                                    }
                                    catch (SqlException se)
                                    {
                                        MessageBox.Show(se.Message);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Company Not Found. please first register company.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Select Company Name");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Select Medicine Type");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Generic Name");
                    }

                }
                else
                {
                    MessageBox.Show("Enter Medicine Name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }


    }
}
