using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Company
{
    public partial class ViewCompany : Form
    {
        public ViewCompany()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dt;
        string query;

        private void viewCompany_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM company";
                dt = db.getTable(query);
                dataGridView_companyTable.DataSource = dt;
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
