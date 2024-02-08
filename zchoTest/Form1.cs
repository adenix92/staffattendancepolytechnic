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

namespace ZKTEchoTest
{
    public partial class Form1 : Form
    {
        public IList<StaffAttendance> attendanceList = new List<StaffAttendance>();
        lnqAttendanceDataContext dc = new lnqAttendanceDataContext();
        public Form1()
        {
            InitializeComponent();
            //txbPort.Text = "4370";
            //txbIPAddress.Text = "192.168.10.201";
        }
        GaposaZkt div = new GaposaZkt();

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnFetchUsers_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new ucSettings());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "STATUS: CONNECTING...";
            lblStatus.ForeColor = Color.YellowGreen;
            if (div.Connect_Net(cfData.IPAddress, cfData.PortNum))
            {
                lblStatus.Text = "STATUS: CONNECTED";
                lblStatus.ForeColor = Color.ForestGreen;
                btnConnect.Text = "Disconnect";
                btnConnect.ForeColor = Color.Red;
                //lblSerialNumber.Text = div.SerialNumber;
            }
            else
            {
                lblStatus.Text = "STATUS: CONNECTION FAILED";
                lblStatus.ForeColor = Color.Red;
            }

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new ucAttendance());            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            System.Threading.Thread trd = new System.Threading.Thread(readData);
            trd.Start();
        }
        private void updateStatus(String msg)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.BeginInvoke((Action)(() =>
                {
                    lblStatus.Text = msg;
                }));
            }
            else
            {
                lblStatus.Text = msg;
            }

        }
        private void readData()
        {
            updateStatus("Genetating List");
            IList<StaffAttendance> updateList = dc.StaffAttendances.ToList();
            DataTable tbl = new DataTable("StaffAttendance");
            tbl.Columns.Add("SAID");
            tbl.Columns.Add("FileNo");
            tbl.Columns.Add("AttendanceDate");
            tbl.Columns.Add("SignIn");
            tbl.Columns.Add("SignOut");
            updateStatus("Fetching Records");
            string EnrolmentNumber2;
            int VerifyMode;
            int inOutMode;
            int year;
            int month;
            int day;
            int hour;
            int min;
            int sec;
            int dept = 0;
            if (div.ReadGeneralLogData(cfData.dwMachineNumber))
            {
                int cnt = 0;
                while (div.SSR_GetGeneralLogData(cfData.dwMachineNumber, out EnrolmentNumber2, out VerifyMode, out inOutMode, out year, out month, out day, out hour, out min, out sec, ref dept))
                {
                    DateTime attDate = new DateTime(year, month, day);
                    TimeSpan ts = new TimeSpan(hour, min, sec);
                    String FileNo = "GPS/" + EnrolmentNumber2.Insert(2, ".");
                    if (updateList.Where(x => x.AttendanceDate == attDate && x.FileNo == FileNo).Count() == 0)
                    {
                        if (attendanceList.Where(x => x.AttendanceDate == attDate && x.FileNo == FileNo).Count() > 0)
                        {
                            if (inOutMode == 1)
                            {
                                attendanceList.First(x => x.AttendanceDate == attDate && x.FileNo == FileNo).SignOut = ts;
                            }
                            else
                            {
                                attendanceList.First(x => x.AttendanceDate == attDate && x.FileNo == FileNo).SignIn = ts;
                            }
                            DataRow dr = tbl.NewRow();
                            dr["SAID"] = null;
                            dr["FileNo"] = FileNo;
                            dr["AttendanceDate"] = attDate;
                            dr["SignIn"] = attendanceList.First(x => x.AttendanceDate == attDate && x.FileNo == FileNo).SignIn;
                            dr["SignOut"] = attendanceList.First(x => x.AttendanceDate == attDate && x.FileNo == FileNo).SignOut;
                            tbl.Rows.Add(dr);
                        }
                        else
                        {
                            StaffAttendance sa = new StaffAttendance { AttendanceDate = attDate, FileNo = FileNo };
                            cnt++;
                            updateStatus(cnt.ToString() + " Fetched");
                            if (inOutMode == 1)
                            {
                                sa.SignOut = ts;
                            }
                            else
                            {
                                sa.SignIn = ts;
                            }
                            attendanceList.Add(sa);
                        }

                    }

                }
                updateStatus("Uploading Records");
                using (SqlConnection con = new SqlConnection("Data Source=gaposa.edu.ng;Initial Catalog=GaposaHR;Persist Security Info=True;User ID=LekeUser;Password=Ro@ckO@ges#93Te#Em")) {
                    con.Open();
                    using(SqlBulkCopy bc=new SqlBulkCopy(con)){
                        foreach(DataColumn col in tbl.Columns){
                            bc.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                        }
                        try {
                            bc.DestinationTableName = "StaffAttendance";
                            bc.BulkCopyTimeout = 600;
                            bc.SqlRowsCopied += CoppiedEvent;
                            bc.WriteToServer(tbl);
                        }catch(Exception ex){
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                updateStatus("Operation Completed");
            }
            else
            {
                MessageBox.Show("Read Failed");
            }


        }

        private void CoppiedEvent(object sender, SqlRowsCopiedEventArgs e)
        {
            updateStatus(e.RowsCopied+ " Uploaded");
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new ucSummary());            
        }
    }
}
