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

                Load_Company();
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

        private void button_addStock_Click(object sender, EventArgs e)
        {
            if (comboBox_medicineName.Text != "")
            {

            }
        }
    }
}
