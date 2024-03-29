﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Stock
{
    public partial class AddStock : Form
    {
        public AddStock()
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

        private void AddStock_Load(object sender, EventArgs e)
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
                query = $"SELECT companyName FROM medicine WHERE medicineName = '{comboBox_medicineName.SelectedItem}'";
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

        private void updateStock()
        {
            //query = $"SELECT SUM(stockQuantity) FROM stock WHERE medicineName = '{comboBox_medicineName.Text}'";
            //dr = db.getData(query);
            //dr.Read();
            //int updatedQuantity = Convert.ToInt32(dr[0].ToString());

            query = $"SELECT SUM(stockQuantity) FROM stock WHERE medicineName = '{comboBox_medicineName.Text}'";
            dr = db.getData(query);
            dr.Read();
            int oldQuantity = Convert.ToInt32(dr[0].ToString());

            db.closeConnection();

            query = $"SELECT SUM(saleQuantity) FROM sales WHERE medicineName = '{comboBox_medicineName.Text}'";
            dr = db.getData(query);
            dr.Read();
            int newQuantity;
            if (dr[0].ToString() == "")
            {
                newQuantity = 0;
            }
            else
            {
                newQuantity = Convert.ToInt32(dr[0].ToString());
            }

            int updatedQuantity = oldQuantity - newQuantity;

            db.closeConnection();

            query = $"UPDATE stockRecord SET quantity = '{updatedQuantity}' WHERE medicineName = '{comboBox_medicineName.Text}'";
            db.setData(query);
            MessageBox.Show("quantity Updated");
        }

        private void button_addStock_Click(object sender, EventArgs e)
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
                                if (textBox_totalPrice.Text == Convert.ToString(Convert.ToInt32(textBox_quantity.Text) * Convert.ToInt32(textBox_price.Text)))
                                {

                                    if (dateTimePicker_expiryDate.Text != "")
                                    {
                                        query = $"INSERT INTO stock (medicineName, companyName, stockQuantity, stockPrice, stockTotalPrice, expiryDate, purchaseDate) values ('{comboBox_medicineName.Text}','{comboBox_companyName.Text}','{textBox_quantity.Text}','{textBox_price.Text}', '{textBox_totalPrice.Text}',Convert(date, '{dateTimePicker_expiryDate.Text}', 103),Convert(date, '{dateTimePicker_purchaseDate.Text}', 103))";
                                        db.setData(query);
                                        MessageBox.Show("Stock Entry Done");

                                        query = $"SELECT medicineName FROM stockRecord WHERE medicineName = '{comboBox_medicineName.Text}'";
                                        dr = db.getData(query);
                                        if (dr.Read())
                                        {
                                            db.closeConnection();

                                            updateStock();
                                        }
                                        else
                                        {
                                            db.closeConnection();

                                            query = $"INSERT INTO stockRecord (medicineName) values ('{comboBox_medicineName.Text}')";
                                            db.setData(query);

                                            updateStock();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter Expiry date");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Enter Total Price");
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

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {
            try
            {

                textBox_totalPrice.Text = Convert.ToString(Convert.ToInt32(textBox_quantity.Text) * Convert.ToInt32(textBox_price.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
