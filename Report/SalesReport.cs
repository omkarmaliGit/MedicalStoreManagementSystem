using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Report
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dt;
        string query;

        private void SalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM salesRecord";
                dt = db.getTable(query);
                dataGridView_salesReport.DataSource = dt;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM salesRecord WHERE medicineName like '{textBox1.Text}%'";
                dt = db.getTable(query);
                dataGridView_salesReport.DataSource = dt;

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
