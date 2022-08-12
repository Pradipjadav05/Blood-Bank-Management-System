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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int StartPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPos += 1;
            MyProgress.Value = StartPos;
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
