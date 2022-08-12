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

namespace BBMS
{
    public partial class BoodTransfert : Form
    {
        public BoodTransfert()
        {
            InitializeComponent();
            fillPatientCb();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MCA\C#\BBMS\BBMS\BloodBankDb.mdf;Integrated Security=True");
        private void fillPatientCb()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select PNum from PatientTbl", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(dr);
            PatientIdCb.ValueMember = "PNum";
            PatientIdCb.DataSource = dt;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetData()
        {
            //Helps to get the BloodGroup and and name of Patient
            conn.Open();
            string query = "select * from PatientTbl where PNum ='" + PatientIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PName"].ToString();
                BGroupTb.Text = dr["PBGroup"].ToString();
            }
            conn.Close();
        }
        int stock;
        private void GetStock(string BGroup)
        {
            //Helps to get the actual astock of Blood based on particular Blood Group
            conn.Open();
            string query = "select * from BloodTbl where Bgroup ='" + BGroup + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            conn.Close();
        }
        private void BoodTransfert_Load(object sender, EventArgs e)
        {

        }
        /*
        int oldStock;
        private void GetStock(string BGroup)
        {
            conn.Open();
            string query = "select * from BloodTbl where Bgroup ='" + BGroup + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldStock = Convert.ToInt32(dr["BStock"].ToString());
            }
            conn.Close();
        }
        */
        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BGroupTb.Text);

            if (stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Available Stock";
                AvailableLbl.Visible = true;
            }
            else
            {
                AvailableLbl.Text = "Stock not Available";
                AvailableLbl.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BoodTransfert bt = new BoodTransfert();
            bt.Show();
            this.Hide();
        }
        private void reset()
        {
            PatNameTb.Text = BGroupTb.Text = string.Empty;
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }
        private void updateStock()
        {
            int newStock = stock - 1;
            try
            {
                String query = "update BloodTbl set BStock = '" +newStock + "' where BGroup = '" + BGroupTb.Text + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Patient Update Successfully");
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                String query = "insert into TransferTbl values('" + PatNameTb.Text + "','" + BGroupTb.Text + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Transfer");
                conn.Close();
                GetStock(BGroupTb.Text);
                updateStock();
                reset();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock Bstock = new BloodStock();
            Bstock.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor ob = new Donor();
            ob.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient ob = new ViewPatient();
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
