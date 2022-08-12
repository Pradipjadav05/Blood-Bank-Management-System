using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(AdminPassTb.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if(AdminPassTb.Text == "Password")
            {
                Employee emp = new Employee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password.Contact the system Admin");
                AdminPassTb.Text = "";
            }
        }
    }
}
