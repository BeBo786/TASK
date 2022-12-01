using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.AdminUC
{
    public partial class Uc_Adduser : UserControl
    {
        public Uc_Adduser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            
            txtPass.Clear();
            txtPhoneNo.Clear();
            txtusername.Clear();
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
