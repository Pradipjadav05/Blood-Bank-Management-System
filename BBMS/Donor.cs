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
using System.Data;


namespace BBMS
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MCA\C#\BBMS\BBMS\BloodBankDb.mdf;Integrated Security=True");
        private void DSaveBtn_Click(object sender, EventArgs e)
        {
            if(DNameTb.Text=="" || DAgeTb.Text == "" || DGenderCb.SelectedIndex == -1 || DPhoneTb.Text =="" || DAddresstb.Text =="" || DBGroupCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                String query = "insert into DonorTbl values('"+DNameTb.Text+ "','"+DAgeTb.Text+ "','"+DGenderCb.SelectedItem+ "','"+DPhoneTb.Text+ "','"+DAddresstb.Text
                    + "','"+DBGroupCb.Text+"')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donor Successfully saved");
                conn.Close();
                reset();
            }
        }

        private void reset()
        {
            DNameTb.Text = DAgeTb.Text = DPhoneTb.Text = DAddresstb.Text = string.Empty;
            DGenderCb.SelectedIndex = DBGroupCb.SelectedIndex = -1;
        }

        private void Donor_Load(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient ob = new ViewPatient();
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
