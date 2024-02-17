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
using MedicalStoreManagementSystem.Stock;
using MedicalStoreManagementSystem.Sales;
using MedicalStoreManagementSystem.Report;

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

        private void updateCOMPANY_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UpdateCompany uc = new UpdateCompany() { TopLevel = false, TopMost = true };
            uc.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(uc);
            uc.Show();
        }

        private void removeCOMPANY_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            RemoveCompany rc = new RemoveCompany() { TopLevel = false, TopMost = true };
            rc.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(rc);
            rc.Show();
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

        private void updateMEDICINE_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UpdateMedicine um = new UpdateMedicine() { TopLevel = false, TopMost = true };
            um.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(um);
            um.Show();
        }


        //Stock
        private void addSTOCK_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            AddStock ast = new AddStock() { TopLevel = false, TopMost = true };
            ast.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(ast);
            ast.Show();

        }

        private void viewSTOCK_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ViewStock vst = new ViewStock() { TopLevel = false, TopMost = true };
            vst.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(vst);
            vst.Show();

        }

        private void updateSTOCK_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UpdateStock ust = new UpdateStock() { TopLevel = false, TopMost = true };
            ust.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(ust);
            ust.Show();

        }


        //Sales
        private void addSALES_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            AddSales ads = new AddSales() { TopLevel = false, TopMost = true };
            ads.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(ads);
            ads.Show();

        }

        private void viewSALES_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ViewStock vis = new ViewStock() { TopLevel = false, TopMost = true };
            vis.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(vis);
            vis.Show();
        }

        private void updateSALES_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UpdateSales ups = new UpdateSales() { TopLevel = false, TopMost = true };
            ups.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(ups);
            ups.Show();
        }


        //Report
        private void stockREPORT_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            StockReport str = new StockReport() { TopLevel = false, TopMost = true };
            str.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(str);
            str.Show();

        }

        private void salesREPORT_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            SalesReport sar = new SalesReport() { TopLevel = false, TopMost = true };
            sar.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(sar);
            sar.Show();

        }





    }
}
