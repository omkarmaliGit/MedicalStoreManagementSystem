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

namespace MedicalStoreManagementSystem.Report
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dt;
        string query;

        private void StockReport_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM stockRecord";
                dt = db.getTable(query);
                dataGridView_stockReport.DataSource = dt;

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
