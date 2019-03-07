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
    public partial class frm_khoa : Form
    {
        public frm_khoa()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        
        private void dtgKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (dtgKhoa.RowCount>=1 && idrow >= 0)
            {
                string makhoa = dtgKhoa.Rows[idrow].Cells[0].Value.ToString();
                bindingdsKhoa(makhoa);
            }
        }

        private void bindingdsKhoa(string makhoa)
        {
            KHOA khoa = db.KHOAs.Where(p => p.MAKHOA == makhoa).SingleOrDefault();
            txtMaKhoa.Text = khoa.MAKHOA;
            txtTenKhoa.Text = khoa.TENKHOA;
            txtNam.Text = khoa.NAMTHANHLAP.ToString();
        }

        private void fillKhoa()
        {
         
            dtgKhoa.DataSource = db.KHOAs  
                            .Select(p => new { p.MAKHOA, p.TENKHOA, p.NAMTHANHLAP })
                            .OrderBy(p => p.MAKHOA);
        }
        private void fillKhoa(string makhoa)
        {
            dtgKhoa.DataSource = db.KHOAs
                .Where(p=>p.MAKHOA == makhoa)
                            .Select(p => new { p.MAKHOA, p.TENKHOA, p.NAMTHANHLAP })
                            .OrderBy(p => p.MAKHOA);
        }
        private void frm_khoa_Load(object sender, EventArgs e)
        {
            fillKhoa();
            if (dtgKhoa.Rows.Count > 0)
            {
                string makhoa = dtgKhoa.Rows[0].Cells[0].Value.ToString();
                bindingdsKhoa(makhoa);
            }
            else
            {
                resetText();
            }
            cheDoXem();
        }

        public bool nhanThem = false;
        public bool nhanSua = false;
        private void add_Click(object sender, EventArgs e)
        {
            nhanThem = true;

            cheDoChinhSua();
            resetText();
            txtTenKhoa.Focus();
        }

        private void resetText()
        {
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            txtNam.ResetText();
        }

        private void cheDoChinhSua()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            edit.Enabled = false;
            del.Enabled = false;
            add.Enabled = false;
            txtMaKhoa.ReadOnly = false;
            txtTenKhoa.ReadOnly = false;
            txtNam.ReadOnly = false;
            txtTenKhoa.Focus();
            txtTenKhoa.SelectAll();
        }

        private void del_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Khoa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if (txtMaKhoa.Text != "")
                {
                    KHOA khoa = db.KHOAs.SingleOrDefault(p => p.MAKHOA == txtMaKhoa.Text);

                    LOP lop = db.LOPs.SingleOrDefault(p => p.MAKHOA == txtMaKhoa.Text);
                    HOCPHAN hhpan = db.HOCPHANs.FirstOrDefault(p => p.MAKHOA == txtMaKhoa.Text);

                    if (lop != null && hhpan != null)
                    {
                        MessageBox.Show("Xóa thông tin bảng Học phần và bảng Lớp trước", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (hhpan != null)
                    {
                        MessageBox.Show("Xóa thông tin bảng Học phần trước", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (lop != null)
                    {
                        MessageBox.Show("Xóa thông tin bảng Lớp trước", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (lop == null && hhpan == null)
                    {

                        if (khoa != null)
                        {
                            db.KHOAs.DeleteOnSubmit(khoa);
                            db.SubmitChanges();
                            fillKhoa();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillKhoa();
                            if (dtgKhoa.Rows.Count > 0)
                            {
                                string makhoa = dtgKhoa.Rows[0].Cells[0].Value.ToString();
                                bindingdsKhoa(makhoa);
                            }
                            else
                            {
                                resetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã lớp học phần không tồn tại", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                } 
                else
                    MessageBox.Show("Mời bạn chọn khoa để xóa", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void edit_Click(object sender, EventArgs e)
        {
            nhanSua = true;
            cheDoChinhSua();
            txtTenKhoa.Focus();
            txtTenKhoa.SelectAll();
        }


        private void load_Click(object sender, EventArgs e)
        {
            fillKhoa();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nhanThem)
            {
                if (txtMaKhoa.Text == "" || txtNam.Text == "" || txtTenKhoa.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
                }
                else
                {
                    KHOA khoa = new KHOA()
                    {
                        MAKHOA = txtMaKhoa.Text,
                        TENKHOA = txtTenKhoa.Text,
                        NAMTHANHLAP = int.Parse(txtNam.Text)
                    };
                    if (db.KHOAs.Where(p => p.MAKHOA == txtMaKhoa.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Mã lớp học phần đã tồn tại", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaKhoa.Focus();
                        txtMaKhoa.SelectAll();
                    }
                    else
                    {
                        db.KHOAs.InsertOnSubmit(khoa);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillKhoa();
                        if (dtgKhoa.Rows.Count > 0)
                        {
                            string makhoa = dtgKhoa.Rows[0].Cells[0].Value.ToString();
                            bindingdsKhoa(makhoa);
                        }
                        cheDoXem();
                        nhanSua = false;
                        nhanThem = false;
                        
                    }
                }
            }
            if (nhanSua)
            {
                if (txtTenKhoa.Text == "" || txtNam.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                }
                else
                {
                    txtMaKhoa.Enabled = true;
                    KHOA khoa = db.KHOAs.SingleOrDefault(p => p.MAKHOA == txtMaKhoa.Text);
                    if (khoa != null)
                    {
                        khoa.TENKHOA = txtTenKhoa.Text;
                        khoa.NAMTHANHLAP = int.Parse(txtNam.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillKhoa();
                        if (dtgKhoa.Rows.Count > 0)
                        {
                            string makhoa = dtgKhoa.Rows[0].Cells[0].Value.ToString();
                            bindingdsKhoa(makhoa);
                        }
                        cheDoXem();
                        nhanSua = false;
                        nhanThem = false;
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại mã khoa", "Sửa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMaKhoa.Focus();
                        txtMaKhoa.SelectAll();
                    }
                    
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cheDoXem();
            nhanSua = false;
            nhanThem = false;

            fillKhoa();
            if (dtgKhoa.Rows.Count > 0)
            {
                string makhoa = dtgKhoa.Rows[0].Cells[0].Value.ToString();
                bindingdsKhoa(makhoa);
            }
            else
            {
                resetText();
            }
            
        }

        private void cheDoXem()
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            edit.Enabled = true;
            del.Enabled = true;
            add.Enabled = true;
            txtMaKhoa.ReadOnly = true;
            txtTenKhoa.ReadOnly = true;
            txtNam.ReadOnly = true;
        }

        private void frm_khoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)   && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
