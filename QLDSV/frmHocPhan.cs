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
    public partial class frmHocPhan : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private bool nhanThem = false, nhanSua = false;
        public frmHocPhan()
        {
            InitializeComponent();
        }

        private void fillDGV()
        {
            dgvHocPhan.DataSource = db.HOCPHANs.Where(p => p.MAKHOA==cbbKhoaPT.SelectedValue.ToString()).Select(p => new
            {
                p.MAHP,
                p.TENHP,
                p.TINCHI,
                p.HOCKY,
                p.KHOA.TENKHOA,
                p.PHANTRAMQT
            }).OrderBy(p => p.MAHP);
        }

        private void fillControl(string maHP)
        {
            HOCPHAN hp = db.HOCPHANs.Where(p => p.MAHP == maHP).SingleOrDefault();
            txtMaHP.Text = hp.MAHP;
            txtTenHP.Text = hp.TENHP;
            txtTinChi.Text = hp.TINCHI.ToString();
            txtHocKy.Text = hp.HOCKY.ToString();
            nudPhanTram.Value = (decimal)hp.PHANTRAMQT;
            KHOA kh = db.KHOAs.Where(p => p.MAKHOA == hp.MAKHOA).SingleOrDefault();
            cbbKhoaPT.Text = kh.TENKHOA;
        }

        private void frmHocPhan_Load(object sender, EventArgs e)
        {
            cbbKhoaPT.DataSource = db.KHOAs.OrderBy(p => p.TENKHOA);
            cbbKhoaPT.DisplayMember = "TENKHOA";
            cbbKhoaPT.ValueMember = "MAKHOA";
            fillDGV();
            if (dgvHocPhan.RowCount > 0)
                fillControl(dgvHocPhan.Rows[0].Cells[0].Value.ToString());
            else
            {
                resetText();
            }
        }

        private void resetText()
        {
            txtHocKy.ResetText();
            txtMaHP.ResetText();
            txtTenHP.ResetText();
            txtTinChi.ResetText();
            nudPhanTram.Value = 0;
        }
        
        private void cheDoSua(bool b) // b == true chế độ sửa else chế độ xem
        {
            btnHuy.Enabled = b;
            btnLuu.Enabled = b;
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            txtMaHP.ReadOnly = !b;
            txtHocKy.ReadOnly = !b;
            txtTenHP.ReadOnly = !b;
            txtTinChi.ReadOnly = !b;
            nudPhanTram.ReadOnly = !b;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanThem = true;
            cheDoSua(true);
            txtHocKy.Text = "";
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            txtTinChi.Text = "";
            txtMaHP.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nhanSua = true;
            cheDoSua(true);
            txtTenHP.Focus();
            txtTenHP.SelectAll();
        }

        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHocPhan.RowCount >= 0)
            {
                if (e.RowIndex >= 0)
                    fillControl(dgvHocPhan.Rows[e.RowIndex].Cells[colMaHP.Index].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if(nhanThem == true)
            {
                if (txtHocKy.Text == "" || txtMaHP.Text == "" || txtTenHP.Text == "" || txtTinChi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    HOCPHAN hp = new HOCPHAN()  {
                           MAHP = txtMaHP.Text,
                           TENHP = txtTenHP.Text,
                           TINCHI = int.Parse(txtTinChi.Text),
                           HOCKY = int.Parse(txtHocKy.Text),
                           PHANTRAMQT = (int)nudPhanTram.Value
                     };
                    KHOA kh = db.KHOAs.Where(p => p.TENKHOA == cbbKhoaPT.Text).SingleOrDefault();
                    hp.MAKHOA = kh.MAKHOA;

                    if (db.HOCPHANs.Where(p => p.MAHP == txtMaHP.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Mã học phần đã tồn tại", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaHP.Focus();
                        txtMaHP.SelectAll();
                    }
                    else
                    {
                        db.HOCPHANs.InsertOnSubmit(hp);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDGV();
                        if (dgvHocPhan.RowCount > 0)
                            fillControl(dgvHocPhan.Rows[0].Cells[0].Value.ToString());
                        nhanThem = false;
                        nhanSua = false;
                        cheDoSua(false);
                    }
                }
               
            }
            else if(nhanSua == true)
            {
                if (txtHocKy.Text == "" || txtMaHP.Text == "" || txtTenHP.Text == "" || txtTinChi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    HOCPHAN hp = db.HOCPHANs.Where(p => p.MAHP == txtMaHP.Text).SingleOrDefault();
                    KHOA kh = db.KHOAs.Where(p => p.TENKHOA == cbbKhoaPT.Text).SingleOrDefault();

                    if (hp == null)
                    {
                        MessageBox.Show("Mã học phần không tồn tại", "Sửa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaHP.Focus();
                        txtMaHP.SelectAll();
                    }
                    else
                    {
                        hp.MAHP = txtMaHP.Text;
                        hp.TENHP = txtTenHP.Text;
                        hp.TINCHI = int.Parse(txtTinChi.Text);
                        hp.HOCKY = int.Parse(txtHocKy.Text);
                        hp.MAKHOA = kh.MAKHOA;
                        hp.PHANTRAMQT = (int)nudPhanTram.Value;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDGV();
                        fillDGV();
                        if (dgvHocPhan.RowCount > 0)
                            fillControl(dgvHocPhan.Rows[0].Cells[0].Value.ToString());

                        nhanThem = false;
                        nhanSua = false;
                        cheDoSua(false);
                    }
                }
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            nhanThem = false;
            nhanSua = false;
            if (nhanThem == false)
            {
                fillDGV();
                if (dgvHocPhan.RowCount > 0)
                    fillControl(dgvHocPhan.Rows[0].Cells[0].Value.ToString());
                else
                {
                    resetText();
                }
            }
            cheDoSua(false);
        }

        private void btnThoat_Click(object sender, EventArgs e) { this.Close(); }

        private void cbbKhoaPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHocPhan.DataSource = from hp in db.HOCPHANs
                                    join kh in db.KHOAs on hp.MAKHOA equals kh.MAKHOA
                                    where kh.TENKHOA == cbbKhoaPT.Text
                                    select new { hp.MAHP, hp.TENHP, hp.TINCHI, hp.HOCKY, kh.TENKHOA,hp.PHANTRAMQT };
            if (dgvHocPhan.RowCount > 0)
                fillControl(dgvHocPhan.Rows[0].Cells[0].Value.ToString());
            else resetText();
        }

        private void cbbKhoaPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtMaHP.Text != "")
                {
                    HOCPHAN hp = db.HOCPHANs.Where(p => p.MAHP == txtMaHP.Text).SingleOrDefault();
                    KETQUA kq = db.KETQUAs.Where(p => p.MAHP == hp.MAHP).FirstOrDefault();
                    if (hp == null)
                        MessageBox.Show("Mã học phần không tồn tại", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        if (kq != null)
                        {
                            MessageBox.Show("Phải xóa tất cả điểm của học phần " + hp.TENHP + " !", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            db.HOCPHANs.DeleteOnSubmit(hp);
                            db.SubmitChanges();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillDGV();

                            if (dgvHocPhan.RowCount > 0)
                                fillControl(dgvHocPhan.Rows[0].Cells[0].Value.ToString());
                            else
                            {
                                resetText();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Mời bạn chọn học phần để xóa", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmHocPhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
