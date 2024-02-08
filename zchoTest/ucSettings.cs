using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZKTEchoTest
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            txbIPAddress.Text = cfData.IPAddress;
            txbPort.Text = cfData.PortNum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                cfData.IPAddress = txbIPAddress.Text;
                cfData.PortNum = int.Parse(txbPort.Text);
                MessageBox.Show("Saved");
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
    }
}
