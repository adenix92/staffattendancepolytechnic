using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ZKTEchoTest
{
    public partial class ucAttendance : UserControl
    {
        public ucAttendance()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try {
                fmAttdReport fm = new fmAttdReport();
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("FromDate", dtpFrom.Value.Date.ToString());
                parameters[1] = new ReportParameter("ToDate", dtpTo.Value.Date.ToString());
                fm.reportViewer1.LocalReport.SetParameters(parameters);
                fm.vw_StaffAttendanceTableAdapter.FillByEDate(fm.dsAttandance.vw_StaffAttendance, dtpFrom.Value.ToString(), dtpTo.Value.ToString());
                fm.ShowDialog();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
