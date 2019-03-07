using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLDSV
{
    public partial class ReportQLDiemSV : Form
    {
        public ReportQLDiemSV()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void ReportQLDiemSV_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'QLDSVDataSet1.QLDIEMSV' table. You can move, or remove it, as needed.
            ///

            this.QLDIEMSVTableAdapter.Fill(this.QLDSVDataSet1.QLDIEMSV);

            this.reportViewer1.RefreshReport();

            cbbLoad.DataSource = db.HOCPHANs.OrderBy(p => p.MAHP);
            cbbLoad.DisplayMember = "TENHP";
            cbbLoad.ValueMember = "MAHP";
            cbbLoad.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var list = from sv in db.SINHVIENs join kq in db.KETQUAs on sv.MASV equals kq.MASV join hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                       where hp.MAHP == cbbLoad.SelectedValue.ToString()
                       select new { sv.MASV, sv.HOTEN, hp.MAHP, hp.TENHP, kq.DIEMQT, kq.DIEMTHI, kq.DIEMTK, kq.KQ };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetQLDiemSV", list.ToList()));
            this.reportViewer1.RefreshReport();

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            var list = from sv in db.SINHVIENs
                       join kq in db.KETQUAs on sv.MASV equals kq.MASV
                       join hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                       select new { sv.MASV, sv.HOTEN, hp.MAHP, hp.TENHP, kq.DIEMQT, kq.DIEMTHI, kq.DIEMTK, kq.KQ };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetQLDiemSV", list.ToList()));
            this.reportViewer1.RefreshReport();
        }

    }
}
