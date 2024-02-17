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
    public partial class RemoveMedicine : Form
    {
        public RemoveMedicine()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        SqlDataReader dr;
        string query;

        private void Load_Medicine()
        {
            query = $"SELECT medicineName FROM medicine";
            dr = db.getData(query);
            while (dr.Read())
            {
                comboBox_medicine.Items.Add(dr[0].ToString());
            }
        }

        private void RemoveMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Medicine();
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

        private void button_removeMedicine_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            if (comboBox_medicine.Text != "")
            {
                try
                {

                    query = $"SELECT quantity FROM stockRecord WHERE medicineName = '{comboBox_medicine.Text}'";
                    dr = db.getData(query);
                    dr.Read();
                    int quantity = Convert.ToInt32(dr[0].ToString());
                    db.closeConnection();

                    if (quantity > 0)
                    {
                        MessageBox.Show("Medicine Available In Stock, first Remove from Stock");
                    }
                    else
                    {


                        if (quantity == 0)
                        {
                            query = $"DELETE FROM stockRecord WHERE medicineName = '{comboBox_medicine.Text}'";
                            db.setData(query);

                            query = $"DELETE FROM medicine WHERE medicineName = '{comboBox_medicine.Text}'";
                            db.setData(query);

                            MessageBox.Show("Medicine Deleted");
                        }


                        comboBox_medicine.Items.Clear();
                        Load_Medicine();
                        comboBox_medicine.Text = string.Empty;
                        comboBox_medicine.Focus();
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
            else
            {
                MessageBox.Show("Select Medicine");
            }
        }
    }
}
