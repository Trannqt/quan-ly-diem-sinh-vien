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
    public partial class frm_sinhvien : Form
    {
        public frm_sinhvien()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
            cbb_SinhVien_Khoa.DisplayMember = "TENKHOA";
            cbb_SinhVien_Khoa.ValueMember = "MAKHOA";
            cbb_SinhVien_Khoa.DataSource = db.KHOAs.OrderBy(p => p.TENKHOA);
            cbb_SinhVien_Khoa.BindingContext = this.BindingContext;

            
            cbb_SinhVien_LopHoc.DataSource = db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).OrderBy(p => p.TENLOP);
            cbb_SinhVien_LopHoc.DisplayMember = "TENLOP";
            cbb_SinhVien_LopHoc.ValueMember = "MALOP";
            cbb_SinhVien_LopHoc.BindingContext = this.BindingContext;

            if(db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).FirstOrDefault() != null)
                LoadDS();
            if (dtgv_SinhVien_DS.RowCount >= 1)
            {
                string masv = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                blinding(masv);
            }
            else{
                resetText();
            }
            cheDoXem();
        }

        private void resetText()
        {
            txt_SinhVien_MaSV.ResetText();
            txt_SinhVien_hoTen.ResetText();
            dtp_SinhVien_ngaySinh.Value = DateTime.Now;
            txt_SinhVien_gioitinh.ResetText();
            txt_SinhVien_diaChi.ResetText();
        }

        private void LoadDS()
        {
            dtgv_SinhVien_DS.DataSource = db.SINHVIENs.Where(p => p.LOP.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString() 
                && p.MALOP == cbb_SinhVien_LopHoc.SelectedValue.ToString()).
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
        private void LoadDSmakhoa(string makhoa)
        {

            dtgv_SinhVien_DS.DataSource = db.SINHVIENs.Where(p => p.LOP.MAKHOA == makhoa).
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
        private void LoadDSmalop(string malop)
        {

            dtgv_SinhVien_DS.DataSource = db.SINHVIENs.Where(p => p.LOP.MALOP == malop).
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

        private void cbb_SinhVien_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhoa = cbb_SinhVien_Khoa.SelectedValue.ToString();

            LOP lop = db.LOPs.Where(p => p.MAKHOA == makhoa).FirstOrDefault();
            if (lop != null)
            {
                cbb_SinhVien_LopHoc.DataSource = db.LOPs.Where(p => p.MAKHOA == makhoa).Select(p => p.MALOP);
                if (db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).FirstOrDefault() != null)
                    LoadDS();
                if (dtgv_SinhVien_DS.RowCount >= 1)
                {
                    if (dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString() != null)
                    {
                        string masv = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                        blinding(masv);
                    }
                    
                }
                else
                {
                    resetText();
                }
            }
            else
            {
                 resetText();
                cbb_SinhVien_LopHoc.Text = "";
                cbb_SinhVien_LopHoc.DataSource = db.LOPs.Where(p => p.MAKHOA==cbb_SinhVien_Khoa.SelectedValue.ToString()).OrderBy(p=>p.MALOP);
                LoadDSmakhoa(cbb_SinhVien_Khoa.SelectedValue.ToString());
            }

            
        }

        private void cbb_SinhVien_LopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cbb_SinhVien_LopHoc.SelectedValue.ToString();
            LoadDSmalop(malop);

            SINHVIEN sv = db.SINHVIENs.Where(p => p.MALOP == malop).FirstOrDefault();
            if (sv != null)
            {
                if (dtgv_SinhVien_DS.RowCount >= 1)
                {
                    string masv = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                    blinding(masv);
                }
            }
            else
            {
                resetText();
            }
        }

        private void dtgv_SinhVien_DS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (dtgv_SinhVien_DS.RowCount>=1 &&  idrow >= 0)
            {
                string masv = dtgv_SinhVien_DS.Rows[idrow].Cells[0].Value.ToString();
                blinding(masv);
            }
        }

        private void blinding(string masv)
        {
            SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == masv).SingleOrDefault();
            txt_SinhVien_MaSV.Text = sv.MASV;
            txt_SinhVien_hoTen.Text = sv.HOTEN;
            dtp_SinhVien_ngaySinh.Value = sv.NGAYSINH; ;
            txt_SinhVien_gioitinh.Text = sv.GIOITINH;
            txt_SinhVien_diaChi.Text = sv.DIACHI;
        }

        private void btn_SinhVien_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool nhanThem = false;
        public bool nhanSua = false;
        private void btn_SinhVien_Them_Click(object sender, EventArgs e)
        {
            nhanThem = true;
            resetText();
            cheDoChinhSua();
            txt_SinhVien_MaSV.Focus();
        }

        private void btn_SinhVien_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa sinh viên này không ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                
                string masv = txt_SinhVien_MaSV.Text;
                if (masv != "")
                {
                    SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == masv).SingleOrDefault();
                    KETQUA kq = db.KETQUAs.Where(p => p.MASV == masv).FirstOrDefault();

                    if (sv == null)
                    {
                        MessageBox.Show("Không tồn tại sinh viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (kq != null)
                        {
                            db.KETQUAs.DeleteOnSubmit(kq);
                            db.SubmitChanges();
                        }
                        db.SINHVIENs.DeleteOnSubmit(sv);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDSmakhoa(cbb_SinhVien_Khoa.SelectedValue.ToString());
                        cheDoXem();
                        if (db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).FirstOrDefault() != null)
                            LoadDS();
                        if (dtgv_SinhVien_DS.RowCount >= 1)
                        {
                            if (dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString() != null)
                            {
                                string MSSV = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                                blinding(MSSV);
                            }

                        }
                        else
                        {
                            resetText();
                        }
                        cheDoXem();
                    }
                }
                else
                    MessageBox.Show("Mời bạn chọn sinh viên để xóa", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btn_SinhVien_Sua_Click(object sender, EventArgs e)
        {
            txt_SinhVien_MaSV.Enabled = false;
            nhanSua = true;
            cheDoChinhSua();
            txt_SinhVien_hoTen.Focus();
            txt_SinhVien_hoTen.SelectAll();
        }
        private void cheDoChinhSua()
        {
            btn_SinhVien_Luu.Enabled = true;
            btn_SinhVien_KLuu.Enabled = true;
            btn_SinhVien_Sua.Enabled = false;
            btn_SinhVien_Xoa.Enabled = false;
            btn_SinhVien_Them.Enabled = false;

            txt_SinhVien_MaSV.ReadOnly = false;
            txt_SinhVien_diaChi.ReadOnly = false;
            txt_SinhVien_gioitinh.ReadOnly = false;
            txt_SinhVien_hoTen.ReadOnly = false;
            dtp_SinhVien_ngaySinh.Enabled = true;
        }
        private void cheDoXem()
        {
            btn_SinhVien_Luu.Enabled = false;
            btn_SinhVien_KLuu.Enabled = false;
            btn_SinhVien_Sua.Enabled = true;
            btn_SinhVien_Xoa.Enabled = true;
            btn_SinhVien_Them.Enabled = true;

            txt_SinhVien_MaSV.ReadOnly = true;
            txt_SinhVien_diaChi.ReadOnly = true;
            txt_SinhVien_gioitinh.ReadOnly = true;
            txt_SinhVien_hoTen.ReadOnly = true;
            dtp_SinhVien_ngaySinh.Enabled = false ;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool flag = true;
        private void btn_SinhVien_Luu_Click(object sender, EventArgs e)
        {
            if (txt_SinhVien_MaSV.Text == "" || txt_SinhVien_hoTen.Text == "" || txt_SinhVien_gioitinh.Text == "" || txt_SinhVien_diaChi.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
            }
            else
            {
                txt_SinhVien_MaSV.Enabled = true;
                if (nhanThem)
                {
                    SINHVIEN sv = new SINHVIEN();
                    sv.MASV = txt_SinhVien_MaSV.Text;
                    sv.HOTEN = txt_SinhVien_hoTen.Text;
                    sv.NGAYSINH = dtp_SinhVien_ngaySinh.Value;
                    sv.GIOITINH = txt_SinhVien_gioitinh.Text;
                    sv.DIACHI = txt_SinhVien_diaChi.Text;
                    sv.MALOP = cbb_SinhVien_LopHoc.SelectedValue.ToString();

                    if (db.SINHVIENs.Where(p => p.MASV == txt_SinhVien_MaSV.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Đã tồn tại sinh viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_SinhVien_MaSV.Focus();
                        txt_SinhVien_MaSV.SelectAll();
                    }
                    else
                    {
                        if (txt_SinhVien_gioitinh.Text == "Nam" || txt_SinhVien_gioitinh.Text == "Nữ")
                        {
                            db.SINHVIENs.InsertOnSubmit(sv);

                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.SubmitChanges();
                            if (db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).FirstOrDefault() != null)
                                LoadDS();
                            if (dtgv_SinhVien_DS.RowCount >= 1)
                            {
                                if (dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString() != null)
                                {
                                    string MSSV = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                                    blinding(MSSV);
                                }

                            }
                            cheDoXem();
                            nhanSua = false;
                            nhanThem = false;

                        } else
                        {
                            MessageBox.Show("Giới tính: \"Nam\" hoặc \"Nữ\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }
            if (flag == true)
            {
                if (txt_SinhVien_MaSV.Text == "" || txt_SinhVien_hoTen.Text == "" || txt_SinhVien_gioitinh.Text == "" || txt_SinhVien_diaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (nhanSua)
                    {  
                        string masv = txt_SinhVien_MaSV.Text;
                        SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == masv).SingleOrDefault();
                        if (sv == null)
                        {
                            MessageBox.Show("Không tồn tại sinh viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_SinhVien_MaSV.Focus();
                            txt_SinhVien_MaSV.SelectAll();
                        }
                        else
                        {
                            if (txt_SinhVien_gioitinh.Text == "Nam" || txt_SinhVien_gioitinh.Text == "Nữ")
                            {
                           
                            sv.MASV = txt_SinhVien_MaSV.Text;
                            sv.HOTEN = txt_SinhVien_hoTen.Text;
                            sv.NGAYSINH = dtp_SinhVien_ngaySinh.Value;
                            sv.GIOITINH = txt_SinhVien_gioitinh.Text;
                            sv.DIACHI = txt_SinhVien_diaChi.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).FirstOrDefault() != null)
                                LoadDS();
                            if (dtgv_SinhVien_DS.RowCount >= 1)
                            {
                                if (dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString() != null)
                                {
                                    string MSSV = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                                    blinding(MSSV);
                                }

                            }

                            cheDoXem();
                            nhanSua = false;
                            nhanThem = false;

                            btn_SinhVien_Sua.Enabled = true;
                            btn_SinhVien_Xoa.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Giới tính: \"Nam\" hoặc \"Nữ\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
        }

        private void btn_SinhVien_KLuu_Click(object sender, EventArgs e)
        {
            cheDoXem();
            nhanThem = false;
            nhanSua = false;
            if (db.LOPs.Where(p => p.MAKHOA == cbb_SinhVien_Khoa.SelectedValue.ToString()).FirstOrDefault() != null)
                LoadDS();
            if (dtgv_SinhVien_DS.RowCount >= 1)
            {
                string masv = dtgv_SinhVien_DS.Rows[0].Cells[0].Value.ToString();
                blinding(masv);
            }
            else
            {
                txt_SinhVien_MaSV.ResetText();
                txt_SinhVien_hoTen.ResetText();
                dtp_SinhVien_ngaySinh.Value = DateTime.Now;
                txt_SinhVien_gioitinh.ResetText();
                txt_SinhVien_diaChi.ResetText();
            }
            
        }

        private void frm_sinhvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát ứng dụng không ?", "Cảnh báo !", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation);
            if (rs != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

    }
}
