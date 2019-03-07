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
    public partial class frm_timKiem : Form
    {
        public frm_timKiem()
        {
            InitializeComponent();
        }


        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frm_timKiem_Load(object sender, EventArgs e)
        {
            cbbKhoa_tìmKiem.DataSource = db.KHOAs.Select(p => p.MAKHOA);
            cbbKhoa_tìmKiem.DisplayMember = "";
            cbbKhoa_tìmKiem.ValueMember = "";
            cbbLopHoc_tìmKiem.DataSource = db.LOPs.Where(p => p.MAKHOA == cbbKhoa_tìmKiem.SelectedValue.ToString())
                .Select(p => p.MALOP);
            if (db.LOPs.Where(p => p.MAKHOA == cbbKhoa_tìmKiem.SelectedValue.ToString()).FirstOrDefault() != null)
                LoadDS();
            if (dtgvDS_timKiem.RowCount >= 1)
            {
                string masv = dtgvDS_timKiem.Rows[0].Cells[0].Value.ToString();
                blinding(masv);
            }
            else
            {
                resetText();
            }
        }

        private void resetText()
        {
            txtMaSV_timKiem.ResetText();
            txtHoTen_timKiem.ResetText();
            dtpNgaySinh_timkiem.Value = DateTime.Now;
            txtgioitinh_TK.ResetText();
            txtdiaChi_TK.ResetText();
        }

        private void blinding(string masv)
        {
            SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == masv).SingleOrDefault();
            txtMaSV_timKiem.Text = sv.MASV;
            txtHoTen_timKiem.Text = sv.HOTEN;
            dtpNgaySinh_timkiem.Value = sv.NGAYSINH; ;
            txtgioitinh_TK.Text = sv.GIOITINH;
            txtdiaChi_TK.Text = sv.DIACHI;
        }
        private void LoadDS()
        {
            if (txtTimKiem.Text == "")
            {
                dtgvDS_timKiem.DataSource = db.SINHVIENs.Where(p => p.LOP.MAKHOA == cbbKhoa_tìmKiem.SelectedValue.ToString()
                && p.MALOP == cbbLopHoc_tìmKiem.SelectedValue.ToString())
                .Select(p => new
                {
                    p.MASV,
                    p.HOTEN,
                    p.NGAYSINH,
                    p.GIOITINH,
                    p.DIACHI,
                    p.LOP.KHOA.TENKHOA

                }).OrderBy(p => p.MASV);
            }
            else
            {
                timKiem();
            }
            
        }

        private void cbbKhoa_tìmKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhoa = cbbKhoa_tìmKiem.SelectedValue.ToString();

            LOP lop = db.LOPs.Where(p => p.MAKHOA == makhoa).FirstOrDefault();
            if (lop != null)
            {
                cbbLopHoc_tìmKiem.DataSource = db.LOPs.Where(p => p.MAKHOA == makhoa).Select(p => p.MALOP);
                if (db.LOPs.Where(p => p.MAKHOA == cbbKhoa_tìmKiem.SelectedValue.ToString()).FirstOrDefault() != null)
                    LoadDS();
                if (dtgvDS_timKiem.RowCount >= 1)
                {
                    if (dtgvDS_timKiem.Rows[0].Cells[0].Value.ToString() != null)
                    {
                        string masv = dtgvDS_timKiem.Rows[0].Cells[0].Value.ToString();
                        blinding(masv);
                    }

                }
                else
                {
                    txtHoTen_timKiem.ResetText();
                    dtpNgaySinh_timkiem.Value = DateTime.Now;
                    txtgioitinh_TK.ResetText();
                    txtdiaChi_TK.ResetText();
                }
            }
            else
            {
                resetText();
                cbbLopHoc_tìmKiem.Text = "";
                cbbLopHoc_tìmKiem.DataSource = db.LOPs.Where(p => p.MAKHOA == cbbKhoa_tìmKiem.SelectedValue.ToString()).OrderBy(p => p.MALOP);
                LoadDSmakhoa(cbbKhoa_tìmKiem.SelectedValue.ToString());
            }
        }
        private void LoadDSmakhoa(string makhoa)
        {
            dtgvDS_timKiem.DataSource = db.SINHVIENs.Where(p => p.LOP.MAKHOA == makhoa).
            Select(p => new
            {
                p.MASV,
                p.HOTEN,
                p.NGAYSINH,
                p.GIOITINH,
                p.DIACHI,
                p.LOP.KHOA.TENKHOA
            });
        }
        private void cbbLopHoc_tìmKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cbbLopHoc_tìmKiem.SelectedValue.ToString();
            LoadDSmalop(malop);

            SINHVIEN sv = db.SINHVIENs.Where(p => p.MALOP == malop).FirstOrDefault();
            if (sv != null)
            {
                if (dtgvDS_timKiem.RowCount >= 1)
                {
                    string masv = dtgvDS_timKiem.Rows[0].Cells[0].Value.ToString();
                    blinding(masv);
                }
            }
            else
            {
                txtMaSV_timKiem.ResetText();
                txtHoTen_timKiem.ResetText();
                dtpNgaySinh_timkiem.Value = DateTime.Now;
                txtgioitinh_TK.ResetText();
                txtdiaChi_TK.ResetText();
            }
        }

        private void LoadDSmalop(string malop)
        {
            if (txtTimKiem.Text == "")
            {
                dtgvDS_timKiem.DataSource = db.SINHVIENs.Where(p => p.LOP.MALOP == malop).
                Select(p => new
                {
                    p.MASV,
                    p.HOTEN,
                    p.NGAYSINH,
                    p.GIOITINH,
                    p.DIACHI,
                    p.LOP.KHOA.TENKHOA
                }).OrderBy(p=>p.MASV);
            }
            else
            {
                timKiem();
            }
            
        }

        private void dtgvDS_timKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow >= 0)
            {
                string masv = dtgvDS_timKiem.Rows[idrow].Cells[0].Value.ToString();
                blinding(masv);
            }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_timKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát ứng dụng không ?", "Cảnh báo !", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (rs != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbLopHoc_tìmKiem.Text!="")
                timKiem();
        }

        private void timKiem()
        {
            dtgvDS_timKiem.DataSource = db.SINHVIENs.Where(p => p.LOP.MAKHOA == cbbKhoa_tìmKiem.SelectedValue.ToString()
                && p.MALOP == cbbLopHoc_tìmKiem.SelectedValue.ToString() && (p.HOTEN.Contains(txtTimKiem.Text.Trim())
                || p.MASV.Contains(txtTimKiem.Text.Trim()) || p.GIOITINH.Contains(txtTimKiem.Text.Trim()) ||
                p.DIACHI.Contains(txtTimKiem.Text.Trim())))
            .Select(p => new
            {
                p.MASV,
                p.HOTEN,
                p.NGAYSINH,
                p.GIOITINH,
                p.DIACHI,
                p.LOP.KHOA.TENKHOA

            }).OrderBy(p => p.MASV);
        }
        
    }
}
