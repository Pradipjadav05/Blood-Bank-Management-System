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
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MCA\C#\BBMS\BBMS\BloodBankDb.mdf;Integrated Security=True");

        private void ViewPatient_Load(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            conn.Open();
            String query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PGenderCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (PNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void PDeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the patient to Delete");
            }
            else
            {
                try
                {
                    String query = "Delete from PatientTbl where PNum = " + key + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted Successfully");
                    conn.Close();
                    reset();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void reset()
        {
            PNameTb.Text = PAgeTb.Text = PPhoneTb.Text = PAddressTb.Text = string.Empty;
            PGenderCb.SelectedIndex = PBGroupCb.SelectedIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void PEditBtn_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PAgeTb.Text == "" || PGenderCb.SelectedIndex == -1 || PPhoneTb.Text == "" || PAddressTb.Text == "" || PBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String query = "update PatientTbl set PName = '"+PNameTb.Text+"', PAge = '"+PAgeTb.Text+"', PPhone = '"+PPhoneTb.Text+"', PGender = '"+PGenderCb.SelectedItem.ToString()+"', PBGroup = '"+PBGroupCb.SelectedItem.ToString()+"', PAddress = '"+PAddressTb.Text+ "' where PNum = '"+key+"'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Update Successfully");
                    conn.Close();
                    reset();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
