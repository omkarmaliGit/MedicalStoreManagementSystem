using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine.AddMedicine am = new Medicine.AddMedicine() {TopLevel = false, TopMost = true};
            am.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(am);
            am.Show();
        }
    }
}
