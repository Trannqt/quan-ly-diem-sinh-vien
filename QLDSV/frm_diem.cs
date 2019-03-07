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
    public partial class frm_diem : Form
    {
        private static bool nhanThem = false, nhanSua = false;
        public frm_diem()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void frm_diem_Load(object sender, EventArgs e)
        {
            cbbMon.DataSource = db.HOCPHANs.OrderBy(p => p.TENHP).Select(p => p.TENHP);
            //cbsv.DataSource = db.SINHVIENs.OrderBy(p => p.MASV).Select(p => p.MASV);
            fillDGV();

            if (dgvDiem.RowCount > 0)
            {
                string maSV = dgvDiem.Rows[0].Cells[colMaSo.Index].Value.ToString();
                string maMH = dgvDiem.Rows[0].Cells[2].Value.ToString();
                bindingDiem(maSV, maMH);
            }
            else
            {
                resetText();
            }

        }

        private void resetText()
        {
            txtMSSV.ResetText();
            nudDiemQT.Value = 0;
            nudDiemThi.Value = 0;
            lbHoTen.ResetText();
        }

        private void fillDGV()
        {
            dgvDiem.DataSource = from kq in db.KETQUAs
                                 join sv in db.SINHVIENs on kq.MASV equals sv.MASV
                                 join hp in db.HOCPHANs on kq.MAHP equals hp.MAHP
                                 where hp.TENHP == cbbMon.Text
                                 orderby kq.MASV ascending
                                 select (new { sv.MASV, sv.HOTEN, hp.MAHP, hp.TENHP, hp.TINCHI, kq.DIEMQT, kq.DIEMTHI, kq.DIEMTK });
        }

        //Hiển thị data lên các textbox
        private void bindingDiem(string maSV, string maMH)
        {
            txtMSSV.Text = maSV;
           
            SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == maSV).SingleOrDefault();
            KETQUA kq = db.KETQUAs.Where(p => p.MASV == maSV && p.MAHP == maMH).SingleOrDefault();
            HOCPHAN hp = db.HOCPHANs.Where(p => p.MAHP == maMH).SingleOrDefault();

            cbbMon.Text = hp.TENHP;
            lbMaMon.Text = maMH;
            lbTinChi.Text = hp.TINCHI.ToString();
            lblHocKy.Text = hp.HOCKY.ToString();
           
            nudDiemQT.Text = kq.DIEMQT.ToString();
            nudDiemThi.Text = kq.DIEMTHI.ToString();
            lbHoTen.Text = sv.HOTEN;
        }

        private void cbbMon_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true;}

        private void cbbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            HOCPHAN hp = db.HOCPHANs.Where(p => p.TENHP == cbbMon.SelectedItem.ToString()).SingleOrDefault();
            lbMaMon.Text = hp.MAHP;
            lbTinChi.Text = hp.TINCHI.ToString();
            dgvDiem.DataSource = from p in db.KETQUAs
                                 join q in db.SINHVIENs on p.MASV equals q.MASV
                                 join g in db.HOCPHANs on p.MAHP equals g.MAHP
                                 where g.TENHP == cbbMon.Text
                                 orderby p.MASV ascending
                                 select (new { q.MASV, q.HOTEN, g.MAHP, g.TENHP, g.TINCHI, p.DIEMTHI, p.DIEMQT, p.DIEMTK });

            if (dgvDiem.RowCount > 0)
            {
                string maSV = dgvDiem.Rows[0].Cells[colMaSo.Index].Value.ToString();
                string maMH = dgvDiem.Rows[0].Cells[2].Value.ToString();
                bindingDiem(maSV, maMH);
            }
            else resetText();
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSV = dgvDiem.Rows[e.RowIndex].Cells[colMaSo.Index].Value.ToString();
                string maMH = dgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                bindingDiem(maSV, maMH);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetText();
            cheDoChinhSua();
            nhanThem = true;
            txtMSSV.Focus();
        }

        private void cheDoChinhSua()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            nudDiemQT.ReadOnly = false;
            nudDiemThi.ReadOnly = false;
            txtMSSV.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Dữ liệu đã xóa không thể hoàn tác\nBạn có chắc chắn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                if (txtMSSV.Text != "")
                {
                    KETQUA kq = db.KETQUAs.Where(p => p.MASV == txtMSSV.Text && p.MAHP == lbMaMon.Text).SingleOrDefault();
                    if (db.SINHVIENs.Where(p => p.MASV == txtMSSV.Text.Trim()).SingleOrDefault() == null)
                        MessageBox.Show("Mã sinh viên không tồn tại", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (kq == null)
                        MessageBox.Show("Sinh viên không có học môn " + cbbMon.Text, "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        db.KETQUAs.DeleteOnSubmit(kq);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDGV();
                        if (dgvDiem.RowCount > 0)
                        {
                            string maSV = dgvDiem.Rows[0].Cells[colMaSo.Index].Value.ToString();
                            string maMH = dgvDiem.Rows[0].Cells[2].Value.ToString();
                            bindingDiem(maSV, maMH);
                        }
                        else
                        {
                            resetText();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mời bạn chọn sinh viên để xóa", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float quaTrinh = new float();
            float cuoiKy = new float();
            bool b = float.TryParse(nudDiemQT.Text, out quaTrinh);
            bool a = float.TryParse(nudDiemThi.Text, out cuoiKy);

            if (nhanThem == true)
            {
                KETQUA kq = new KETQUA()
                {
                    MASV = txtMSSV.Text,
                    MAHP = lbMaMon.Text,
                };
                HOCPHAN hp = db.HOCPHANs.Where(p => p.MAHP == lbMaMon.Text).SingleOrDefault();
                if (db.SINHVIENs.Where(p => p.MASV == txtMSSV.Text.Trim()).SingleOrDefault() == null)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSSV.Focus();
                    txtMSSV.SelectAll();
                }
                else if (db.KETQUAs.Where(p => p.MASV == txtMSSV.Text && p.MAHP == lbMaMon.Text).SingleOrDefault() != null)
                    MessageBox.Show("Sinh viên đã có điểm cho môn " + cbbMon.SelectedItem.ToString(), "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (b == false || a == false)
                    {
                        MessageBox.Show("Điểm chỉ được phép chứa 1 dấu phẩy", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
                    }
                    else
                    {
                        kq.DIEMQT = Math.Round(quaTrinh, 1);
                        kq.DIEMTHI = Math.Round(cuoiKy, 1);
                        float diemTK = (float)((kq.DIEMQT * hp.PHANTRAMQT / 100) + (kq.DIEMTHI * (100 - hp.PHANTRAMQT) / 100));
                        if (diemTK < 4.0)
                            kq.KQ = false;
                        else
                            kq.KQ = true;
                        kq.DIEMTK = Math.Round(diemTK, 1);
                        db.KETQUAs.InsertOnSubmit(kq);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDGV();
                        if (dgvDiem.RowCount > 0)
                        {
                            string maSV = dgvDiem.Rows[0].Cells[colMaSo.Index].Value.ToString();
                            string maMH = dgvDiem.Rows[0].Cells[2].Value.ToString();
                            bindingDiem(maSV, maMH);
                        }
                        cheDoXem();
                        nhanSua = false;
                        nhanThem = false;
                    }
                }
            }
            else if (nhanSua == true)
            {
                KETQUA kq = db.KETQUAs.Where(p => p.MASV == txtMSSV.Text && p.MAHP == lbMaMon.Text).SingleOrDefault();
                HOCPHAN hp = db.HOCPHANs.Where(p => p.MAHP == lbMaMon.Text).SingleOrDefault();
                if (db.SINHVIENs.Where(p => p.MASV == txtMSSV.Text.Trim()).SingleOrDefault() == null)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại", "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSSV.Focus();
                    txtMSSV.SelectAll();
                }
                else if (kq == null)
                    MessageBox.Show("Sinh viên không có điểm môn " + cbbMon.Text, "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (b == true || a == true)
                    {
                        kq.DIEMQT = Math.Round(quaTrinh, 1);
                        kq.DIEMTHI = Math.Round(cuoiKy, 1);
                        float diemTK = (float)((kq.DIEMQT * hp.PHANTRAMQT / 100) + (kq.DIEMTHI * (100 - hp.PHANTRAMQT) / 100));
                        if (diemTK < 4.0)
                            kq.KQ = false;
                        else
                            kq.KQ = true;
                        kq.DIEMTK = Math.Round(diemTK, 1);

                        db.SubmitChanges();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDGV();
                        if (dgvDiem.RowCount > 0)
                        {
                            string maSV = dgvDiem.Rows[0].Cells[colMaSo.Index].Value.ToString();
                            string maMH = dgvDiem.Rows[0].Cells[2].Value.ToString();
                            bindingDiem(maSV, maMH);
                        }

                        cheDoXem();
                        nhanSua = false;
                        nhanThem = false;

                    }
                    else
                        MessageBox.Show("Điểm chỉ được phép chứa 1 dấu chấm", "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cheDoXem()
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            nudDiemQT.ReadOnly = true;
            nudDiemThi.ReadOnly = true;
            txtMSSV.ReadOnly= true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cheDoXem();
            nhanSua = false;
            nhanThem = false;
            fillDGV();
            if (dgvDiem.RowCount > 0)
            {
                string maSV = dgvDiem.Rows[0].Cells[colMaSo.Index].Value.ToString();
                string maMH = dgvDiem.Rows[0].Cells[2].Value.ToString();
                bindingDiem(maSV, maMH);
            }
            else resetText();
        }

        private void btnThoat_Click(object sender, EventArgs e) 
        {
            this.Close();
            
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            ReportQLDiemSV frm = new ReportQLDiemSV();
            frm.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            cheDoChinhSua();
            nhanSua = true;
            txtMSSV.Focus();
            txtMSSV.SelectAll();
        }

        private void frm_diem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txtMSSV_Leave(object sender, EventArgs e)
        {
            string masv = txtMSSV.Text;
            SINHVIEN sv = db.SINHVIENs.Where(p => p.MASV == masv).SingleOrDefault();

            if(sv!=null){
                lbHoTen.Text = sv.HOTEN;
                lbHoTen.ForeColor = Color.Black;
            }
            else
            {
                lbHoTen.Text = "Mã sinh viên không tồn tại";
                lbHoTen.ForeColor = Color.Red;
            }
        }
    }
}
