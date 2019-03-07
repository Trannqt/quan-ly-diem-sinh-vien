namespace QLDSV
{
    partial class ReportXemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportXemDiem));
            this.QLDIEMSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XemDiemDataSet = new QLDSV.XemDiemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLDIEMSVTableAdapter = new QLDSV.XemDiemDataSetTableAdapters.QLDIEMSVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDIEMSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XemDiemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // QLDIEMSVBindingSource
            // 
            this.QLDIEMSVBindingSource.DataMember = "QLDIEMSV";
            this.QLDIEMSVBindingSource.DataSource = this.XemDiemDataSet;
            // 
            // XemDiemDataSet
            // 
            this.XemDiemDataSet.DataSetName = "XemDiemDataSet";
            this.XemDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetXemDiem";
            reportDataSource1.Value = this.QLDIEMSVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLDSV.ReportXemDiem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLDIEMSVTableAdapter
            // 
            this.QLDIEMSVTableAdapter.ClearBeforeFill = true;
            // 
            // ReportXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 402);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportXemDiem";
            this.Text = "Điểm cá nhân";
            this.Load += new System.EventHandler(this.ReportXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDIEMSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XemDiemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QLDIEMSVBindingSource;
        private XemDiemDataSet XemDiemDataSet;
        private XemDiemDataSetTableAdapters.QLDIEMSVTableAdapter QLDIEMSVTableAdapter;
    }
}