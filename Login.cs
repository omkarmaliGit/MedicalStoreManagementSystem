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
        SqlDataReader dr;
        string query;

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_username.Text != "")
                {
                    query = $"SELECT username FROM admin WHERE username = '{textBox_username.Text}'";
                    dr = db.getData(query);

                    if (dr.Read())
                    {
                        string username = textBox_username.Text;
                        db.closeConnection();

                        if (textBox_password.Text != "")
                        {
                            query = $"SELECT password FROM admin WHERE username = '{textBox_username.Text}'";
                            dr = db.getData(query);
                            dr.Read();

                            if (dr.GetValue(0).ToString() == textBox_password.Text)
                            {
                                Dashboard d = new Dashboard(username);
                                d.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Not Found");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Username");
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
    }
}
