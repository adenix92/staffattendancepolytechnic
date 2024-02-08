namespace ZKTEchoTest
{
    partial class fmSummaryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsAttandance = new ZKTEchoTest.dsAttandance();
            this.vw_StaffSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_StaffSummary = new ZKTEchoTest.dsAttandanceTableAdapters.vw_StaffSummary();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttandance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StaffSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_StaffSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ZKTEchoTest.rptSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(855, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsAttandance
            // 
            this.dsAttandance.DataSetName = "dsAttandance";
            this.dsAttandance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_StaffSummaryBindingSource
            // 
            this.vw_StaffSummaryBindingSource.DataMember = "vw_StaffSummary";
            this.vw_StaffSummaryBindingSource.DataSource = this.dsAttandance;
            // 
            // vw_StaffSummary
            // 
            this.vw_StaffSummary.ClearBeforeFill = true;
            // 
            // fmSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 418);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fmSummaryReport";
            this.Text = "fmSummaryReport";
            this.Load += new System.EventHandler(this.fmSummaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAttandance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_StaffSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource vw_StaffSummaryBindingSource;
        public dsAttandance dsAttandance;
        public dsAttandanceTableAdapters.vw_StaffSummary vw_StaffSummary;
    }
}