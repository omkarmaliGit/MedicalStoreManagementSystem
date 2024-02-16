using System;
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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        SqlDataReader dr;
        string query;

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT companyName from company";
                dr = db.getData(query);
                while (dr.Read())
                {
                    comboBox_companyName.Items.Add(dr[0].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_medicineName.Text != "")
                {
                    query = $"SELECT medicineName FROM medicine WHERE medicineName = '{textBox_medicineName.Text}'";
                    dr = db.getData(query);

                    if (!dr.Read())
                    {
                        db.closeConnection();

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
                                    db.closeConnection() ;

                                    if (found) {
                                        try
                                        {
                                            query = $"INSERT INTO medicine (medicineName, genericName, medicineType, companyName) values ('{textBox_medicineName.Text}','{textBox_genericName.Text}','{comboBox_medicineType.Text}','{comboBox_companyName.Text}')";
                                            db.setData(query);
                                            MessageBox.Show("Medicine added to list");

                                            textBox_medicineName.Text = "";
                                            textBox_genericName.Text = "";
                                            comboBox_medicineType.Text = "";
                                            comboBox_companyName.Text = "";
                                            textBox_medicineName.Focus();
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
                        MessageBox.Show("Medicine is already listed");
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
