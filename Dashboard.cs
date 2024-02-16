using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MedicalStoreManagementSystem.Medicine;
using MedicalStoreManagementSystem.Company;

namespace MedicalStoreManagementSystem
{
    public partial class Dashboard : Form
    {
        private string username;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            label_welcome.Text = $"Hey {username}, Welcome Back!";
        }


        //Admin
        private void PROFILE_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(label_welcome);
            label_welcome.Text = $"Hey {username}, Welcome Back!";
        }

        private void LOGOUT_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void EXIT_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Comapny
        private void addCOMPANY_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            AddCompany ac = new AddCompany() {TopLevel = false, TopMost = true };
            ac.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(ac);
            ac.Show();
        }

        private void viewCOMPANY_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ViewCompany vc = new ViewCompany() { TopLevel = false, TopMost = true };
            vc.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(vc);
            vc.Show();
        }

        //medicine
        private void addMEDICINE_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            AddMedicine am = new AddMedicine() { TopLevel = false, TopMost = true };
            am.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(am);
            am.Show();
        }

        private void viewMEDICINE_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ViewMedicine vm = new ViewMedicine() { TopLevel = false, TopMost = true };
            vm.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(vm);
            vm.Show();
        }

        private void removeMEDICINE_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            RemoveMedicine rm = new RemoveMedicine() { TopLevel = false, TopMost = true };
            rm.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(rm);
            rm.Show();
        }
    }
}
