using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Company
{
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        SqlDataReader dr;
        string query;

        private void button_addCompany_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_companyName.Text != "")
                {
                    query = $"SELECT companyName FROM company WHERE companyName = '{textBox_companyName.Text}'";
                    dr = db.getData(query);

                    if (!dr.Read())
                    {
                        db.closeConnection();

                        if (textBox_contactNumber.Text != "")
                        {
                            query = $"SELECT contact FROM company WHERE contact = '{textBox_contactNumber.Text}'";
                            dr = db.getData(query);

                            if (!dr.Read())
                            {
                                db.closeConnection();

                                if (textBox_location.Text != "")
                                {
                                    query = $"SELECT location FROM company WHERE location = '{textBox_location.Text}'";
                                    dr = db.getData(query);

                                    if (!dr.Read())
                                    {
                                        db.closeConnection();

                                        try
                                        {

                                            query = $"INSERT INTO company (companyName, contact, location) VALUES ('{textBox_companyName.Text}','{textBox_contactNumber.Text}','{textBox_location.Text}')";

                                            db.setData(query);
                                            MessageBox.Show("Company Registered");

                                            textBox_companyName.Text = "";
                                            textBox_contactNumber.Text = "";
                                            textBox_location.Text = "";
                                            textBox_companyName.Focus();

                                        }
                                        catch (SqlException se)
                                        {
                                            MessageBox.Show(se.Message);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Address is already registered");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter Address");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Contact Number is already registered");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Contact Number");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Company is already registered");
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
