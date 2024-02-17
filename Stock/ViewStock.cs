using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Stock
{
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dt;
        string query;

        private void ViewStock_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM stock";
                dt = db.getTable(query);
                dataGridView_stockEntry.DataSource = dt;

            }
            catch(Exception ex)
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
