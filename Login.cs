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

namespace MedicalStoreManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text != "")
            {
                try
                {
                    string query = $"SELECT username FROM medicalStoreDatabase WHERE username = '{textBox_username.Text}'";
                    SqlDataReader dr = db.getSingleData(query);

                if (textBox_username.Text != "")
                    {

                    }
                    else
                    {

                    }

                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally{
                    db.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Enter Username");
            }
        }
    }
}
