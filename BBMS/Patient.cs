using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBMS
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MCA\C#\BBMS\BBMS\BloodBankDb.mdf;Integrated Security=True");

        private void PSaveBtn_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PAgeTb.Text == "" || PGenderCb.SelectedIndex == -1 || PPhoneTb.Text == "" || PAddressTb.Text == "" || PBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                String query = "insert into PatientTbl values('" + PNameTb.Text + "','" + PAgeTb.Text + "','" + PPhoneTb.Text + "','" + PGenderCb.SelectedItem + "','" + PBGroupCb.Text + "','" + PAddressTb.Text + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully saved");
                conn.Close();
                reset();
            }
        }
        private void reset()
        {
            PNameTb.Text = PAgeTb.Text = PPhoneTb.Text = PAddressTb.Text = string.Empty;
            PGenderCb.SelectedIndex = PBGroupCb.SelectedIndex = -1;
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient vp = new ViewPatient();
            vp.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Donor ob = new Donor();
            ob.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DonateBlood ob = new DonateBlood();
            ob.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewDonor ob = new ViewDonor();
            ob.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Patient ob = new Patient();
            ob.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock ob = new BloodStock();
            ob.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BoodTransfert ob = new BoodTransfert();
            ob.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoard ob = new DashBoard();
            ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            login ob = new login();
            ob.Show();
            this.Hide();
        }
    }
}
