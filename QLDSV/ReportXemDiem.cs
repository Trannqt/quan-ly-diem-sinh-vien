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
    public partial class ReportXemDiem : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string hocky = null;
        public ReportXemDiem()
        {
            InitializeComponent();
        }

        private void ReportXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetXemDiem.QLDIEMSV' table. You can move, or remove it, as needed.
            //this.QLDIEMSVTableAdapter.Fill(this.DataSetXemDiem.QLDIEMSV);
            var list = from sv in db.SINHVIENs
                       join kq in db.KETQUAs on sv.MASV equals kq.MASV
                       join hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                       where hp.HOCKY.ToString() == hocky && sv.MASV == frm_login.adminis
                       select new { hp.MAHP, hp.TENHP, kq.DIEMQT, kq.DIEMTHI, kq.DIEMTK, kq.KQ, sv.HOTEN, sv.MASV };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetXemDiem", list.ToList()));
            this.reportViewer1.RefreshReport();
        }
    }
}