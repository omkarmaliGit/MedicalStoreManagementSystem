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

namespace MedicalStoreManagementSystem.Company
{
    public partial class RemoveCompany : Form
    {
        public RemoveCompany()
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

        private void RemoveCompany_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Company();
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

        private void button_removeCompany_Click(object sender, EventArgs e)
        {
            if (comboBox_companyName.Text != "")
            {
                try
                {
                    query = $"DELETE FROM company WHERE companyName = '{comboBox_companyName.Text}'";
                    db.setData(query);
                    MessageBox.Show("Company Deleted");

                    comboBox_companyName.Items.Clear();
                    Load_Company();
                    comboBox_companyName.Text = string.Empty;
                    comboBox_companyName.Focus();
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
                MessageBox.Show("Select Company");
            }
        }
    }
}
