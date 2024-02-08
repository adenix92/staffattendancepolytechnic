using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZKTEchoTest
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cfData.staff = cfData.dc.StaffDetails.First(x => x.FileNo == txbStaffNumber.Text && x.Password == txbPassword.Text);
                this.Hide();
                this.Visible = false;
                cfData.fmHome.ShowDialog();
                this.Visible = true;
                this.Show();
            }
            catch (Exception ex) {
                MessageBox.Show("Login Failed");
                Console.WriteLine(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
