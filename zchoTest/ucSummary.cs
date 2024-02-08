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
    public partial class ucSummary : UserControl
    {
        public ucSummary()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try {
                fmSummaryReport fm = new fmSummaryReport();
                fm.vw_StaffSummary.FillSummary(fm.dsAttandance.vw_StaffSummary, dtpFrom.Value.ToString(), dtpTo.Value.ToString());
                fm.ShowDialog();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
