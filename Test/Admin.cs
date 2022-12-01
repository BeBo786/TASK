using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uc_Adduser1.Visible = false;
            btnDashboard.PerformClick();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uc_Adduser1.Visible = true;
            uc_Adduser1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
