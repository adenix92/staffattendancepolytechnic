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
    public partial class fmAttdReport : Form
    {
        public fmAttdReport()
        {
            InitializeComponent();
        }

        private void fmAttdReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAttandance.vw_StaffAttendance' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
