using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmXemDiem : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void xepLoai(double dTB)
        {
            if (dTB >= 8.5)
                lbXepLoai.Text = "Giỏi";
            else if (dTB >= 7.0)
                lbXepLoai.Text = "Khá";
            else if (dTB >= 7.0)
                lbXepLoai.Text = "Trung bình";
            else if (dTB >= 4.0)
                lbXepLoai.Text = "Trung bình yếu";
            else
                lbXepLoai.Text = "Kém";
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            dgvDiemSV.DataSource = from kq in db.KETQUAs join
                                   hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                                   where kq.MASV == frm_login.adminis
                                   select new { hp.TENHP, kq.DIEMTHI, kq.DIEMQT, kq.KQ, kq.DIEMTK };
            SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == frm_login.adminis).SingleOrDefault();
            lbDiaChi.Text = sv.DIACHI;
            lbGioiTinh.Text = sv.GIOITINH;
            lbTenSV.Text = sv.HOTEN;
            lbMaSV.Text = sv.MASV;
            lbNgaySinh.Text = sv.NGAYSINH.ToString("dd/MM/yyyy");
            LOP lp = db.LOPs.Where(p => p.MALOP == sv.MALOP).SingleOrDefault();
            lbLop.Text = lp.TENLOP;
            KHOA kh = db.KHOAs.Where(p => p.MAKHOA == lp.MAKHOA).SingleOrDefault();
            lbKhoa.Text = kh.TENKHOA;
            if (dgvDiemSV.RowCount >= 1)
            {
                double diemTB = db.KETQUAs.Where(p => p.MASV == frm_login.adminis).Average(p => p.DIEMTK);
                lbDiemTB.Text = Math.Round(diemTB, 1).ToString();
                xepLoai(diemTB);
            }

            cbbHocKy.DataSource = db.HOCPHANs.Select(p => p.HOCKY).Distinct();

        }

        private void dgvDiemSV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDiemSV.Columns[e.ColumnIndex].Name == "colKetQua")
            {
                string value = e.Value.ToString().ToLower();
                if(value == "true")
                    e.Value = "Qua môn";
                else
                {
                    e.Value = "Rớt môn";
                    e.CellStyle.ForeColor = Color.Red;
                }
                    
            }
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDiemSV.DataSource = from kq in db.KETQUAs
                                   join
             hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                                   where kq.MASV == frm_login.adminis && hp.HOCKY == int.Parse(cbbHocKy.Text)
                                   select new { hp.TENHP, kq.DIEMQT, kq.DIEMTHI, kq.KQ, kq.DIEMTK };
            if (dgvDiemSV.RowCount >= 1)
            {
                double diemTB = (from kq in db.KETQUAs
                                 join
          hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                                 where kq.MASV == frm_login.adminis && hp.HOCKY == int.Parse(cbbHocKy.Text)
                                 select kq.DIEMTK).Average();
                lbDiemTB.Text = Math.Round(diemTB, 1).ToString();
                xepLoai(diemTB);
                lbInDiem.Visible = true;
            }
            else
            {
                lbInDiem.Visible = false;

            }
        }

        private void lbInDiem_Click(object sender, EventArgs e)
        {
            
            
            ReportXemDiem frm = new ReportXemDiem();
            ReportXemDiem.hocky = cbbHocKy.Text;
            frm.ShowDialog();
        }

        private void cbbHocKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
