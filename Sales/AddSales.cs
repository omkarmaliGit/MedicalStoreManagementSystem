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

namespace MedicalStoreManagementSystem.Sales
{
    public partial class AddSales : Form
    {
        public AddSales()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        SqlDataReader dr;
        string query;

        private void Load_Company()
        {
            query = $"SELECT companyName FROM company";
            dr = db.getData(query);
            while (dr.Read())
            {
                comboBox_companyName.Items.Add(dr[0].ToString());
            }

        }

        private void Load_Medicine()
        {
            query = $"SELECT medicineName FROM medicine";
            dr = db.getData(query);
            while (dr.Read())
            {
                comboBox_medicineName.Items.Add(dr[0].ToString());
            }
        }

        private void AddSales_Load(object sender, EventArgs e)
        {

            try
            {
                comboBox_medicineName.Focus();
                comboBox_medicineName.Items.Clear();
                comboBox_medicineName.Items.Clear();

                Load_Medicine();
                //db.closeConnection();
                //Load_Company();
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

        private void comboBox_medicineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT companyName FROM medicine WHERE medicineName = '{comboBox_medicineName.Text}'";
                dr = db.getData(query);

                if (dr.Read())
                {
                    comboBox_companyName.Text = dr[0].ToString();
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

        private void button_addSales_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_medicineName.Text != "")
                {
                    if (comboBox_companyName.Text != "")
                    {
                        if (textBox_quantity.Text != "")
                        {
                            if (textBox_price.Text != "")
                            {
                                if (dateTimePicker_saleDate.Text != "")
                                {

                                    query = $"SELECT quantity FROM stockRecord WHERE medicineName = '{comboBox_medicineName.Text}'";
                                    dr = db.getData(query);
                                    dr.Read();
                                    int quantity = Convert.ToInt32(dr[0].ToString());

                                    if (quantity > 0 && quantity >= Convert.ToInt32(textBox_quantity.Text))
                                    {
                                        db.closeConnection();

                                        query = $"INSERT INTO sales (medicineName, companyName, saleQuantity, salePrice, saleDate) values ('{comboBox_medicineName.Text}','{comboBox_companyName.Text}','{textBox_quantity.Text}','{textBox_price.Text}',Convert(date,'{dateTimePicker_saleDate.Text}',103))";
                                        db.setData(query);
                                        MessageBox.Show("Sale Entry Done");

                                        query = $"SELECT quantity FROM stockRecord WHERE medicineName = '{comboBox_medicineName.Text}'";
                                        dr = db.getData(query);
                                        dr.Read();
                                        int oldQuantity = Convert.ToInt32(dr[0].ToString());
                                        int newQuantity = Convert.ToInt32(textBox_quantity.Text);
                                        int updatedQuantity = oldQuantity - newQuantity;

                                        db.closeConnection();

                                        query = $"UPDATE stockRecord SET quantity = '{updatedQuantity}' WHERE medicineName = '{comboBox_medicineName.Text}'";
                                        db.setData(query);
                                        MessageBox.Show("quantity Updated");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Medicine is not in stock");
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Sales Date is Not Selected");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Enter Price");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Quantity");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Company Not Selected");
                    }
                }
                else
                {
                    MessageBox.Show("Select Medicine");
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
