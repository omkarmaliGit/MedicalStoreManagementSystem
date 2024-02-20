using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Sales
{
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dt;
        string query;

        private void ViewSales_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM sales";
                dt = db.getTable(query);
                dataGridView_salesEntry.DataSource = dt;

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

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM sales WHERE saleDate BETWEEN Convert(date, '{dateTimePicker_from.Text}',103) AND Convert(date, '{dateTimePicker_To.Text}',103)";
                dt = db.getTable(query);
                dataGridView_salesEntry.DataSource = dt;

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
