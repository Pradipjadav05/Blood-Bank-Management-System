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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            getData();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MCA\C#\BBMS\BBMS\BloodBankDb.mdf;Integrated Security=True");
        private void getData()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select count(*) from DonorTbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DonorLbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter da1 = new SqlDataAdapter("Select count(*) from TransferTbl", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            TransferLbl.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter da2 = new SqlDataAdapter("Select count(*) from TransferTbl", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            EmployeeLbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter da3 = new SqlDataAdapter("Select Sum(BStock) from BloodTbl", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            TotalLbl.Text = "" + BStock;

            SqlDataAdapter da4 = new SqlDataAdapter("Select BStock from BloodTbl where BGroup='O+'", conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            OPlushNumLbl.Text = dt4.Rows[0][0].ToString();
            double oPlushPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString())/BStock)*100;
            OPlushProgress.Value = Convert.ToInt32(oPlushPercentage);

            SqlDataAdapter da5 = new SqlDataAdapter("Select BStock from BloodTbl where BGroup='AB+'", conn);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            ABLbl.Text = dt5.Rows[0][0].ToString();
            double ABPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
            ABProgress.Value = Convert.ToInt32(ABPercentage);

            SqlDataAdapter da6 = new SqlDataAdapter("Select BStock from BloodTbl where BGroup = 'O-'", conn);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            OMinusLbl.Text = dt6.Rows[0][0].ToString();
            double OMinusPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;
            OMinusProgess.Value = Convert.ToInt32(OMinusPercentage);

            SqlDataAdapter da7 = new SqlDataAdapter("Select BStock from BloodTbl where BGroup = 'AB-'", conn);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            ABMinusLbl.Text = dt7.Rows[0][0].ToString();
            double ABMinusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;
            ABMinusProgess.Value = Convert.ToInt32(ABMinusPercentage);

            
            conn.Close();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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
