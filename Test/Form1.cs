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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "bahaa" && txtPassword.Text == "bebo")
            {
                Admin am = new Admin();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName OR Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
