
namespace Mix_System
{
    partial class frm_Report
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
            this.DssqlReport = new Mix_System.DssqlReport();
            this.Mix_System_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mix_System_DataTableAdapter = new Mix_System.DssqlReportTableAdapters.Mix_System_DataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DssqlReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mix_System_DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSQLReport";
            reportDataSource1.Value = this.Mix_System_DataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mix_System.rp_sqlRepot.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DssqlReport
            // 
            this.DssqlReport.DataSetName = "DssqlReport";
            this.DssqlReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Mix_System_DataBindingSource
            // 
            this.Mix_System_DataBindingSource.DataMember = "Mix_System_Data";
            this.Mix_System_DataBindingSource.DataSource = this.DssqlReport;
            // 
            // Mix_System_DataTableAdapter
            // 
            this.Mix_System_DataTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Report";
            this.Text = "frm_Report";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DssqlReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mix_System_DataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Mix_System_DataBindingSource;
        private DssqlReport DssqlReport;
        private DssqlReportTableAdapters.Mix_System_DataTableAdapter Mix_System_DataTableAdapter;
    }
}