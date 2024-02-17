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

namespace MedicalStoreManagementSystem.Company
{
    public partial class UpdateCompany : Form
    {
        public UpdateCompany()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        SqlDataReader dr;
        string query;

        private void UpdateCompany_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox_companyName.Focus();
                query = $"SELECT companyName FROM company";
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

        private void comboBox_companyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM company WHERE companyName = '{comboBox_companyName.Text}'";
                dr = db.getData(query);
                while (dr.Read())
                {
                    textBox_contactNumber.Text = dr[1].ToString();
                    textBox_location.Text = dr[2].ToString();

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

        private void button_updateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_companyName.Text != "")
                {
                    if (textBox_contactNumber.Text != "")
                    {
                        if (textBox_location.Text != "")
                        {
                            try
                            {

                                query = $"UPDATE company SET companyName = '{comboBox_companyName.Text}', contact = '{textBox_contactNumber.Text}', location = '{textBox_location.Text}' WHERE companyName = '{comboBox_companyName.Text}'";

                                db.setData(query);
                                MessageBox.Show("Company Updated");

                                comboBox_companyName.Text = "";
                                textBox_contactNumber.Text = "";
                                textBox_location.Text = "";
                                comboBox_companyName.Focus();

                            }
                            catch (SqlException se)
                            {
                                MessageBox.Show(se.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Enter Address");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Contact Number");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Company Name");
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
