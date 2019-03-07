namespace QLDSV
{
    partial class thongKe_DauRot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongKe_DauRot));
            this.DSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetThongke = new QLDSV.DataSetThongke();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSSVTableAdapter = new QLDSV.DataSetThongkeTableAdapters.DSSVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // DSSVBindingSource
            // 
            this.DSSVBindingSource.DataMember = "DSSV";
            this.DSSVBindingSource.DataSource = this.DataSetThongke;
            // 
            // DataSetThongke
            // 
            this.DataSetThongke.DataSetName = "DataSetThongke";
            this.DataSetThongke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetThongke";
            reportDataSource1.Value = this.DSSVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLDSV.thongKe_DauRot.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(651, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSSVTableAdapter
            // 
            this.DSSVTableAdapter.ClearBeforeFill = true;
            // 
            // thongKe_DauRot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "thongKe_DauRot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sinh viên đậu & rớt";
            this.Load += new System.EventHandler(this.thongKe_DauRot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetThongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSSVBindingSource;
        private DataSetThongke DataSetThongke;
        private DataSetThongkeTableAdapters.DSSVTableAdapter DSSVTableAdapter;
    }
}