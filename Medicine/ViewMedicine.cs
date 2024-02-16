using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.Medicine
{
    public partial class ViewMedicine : Form
    {
        public ViewMedicine()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dt;
        string query;

        private void ViewMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM medicine";
                dt = db.getTable(query);
                dataGridView_medicineTable.DataSource = dt;
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
