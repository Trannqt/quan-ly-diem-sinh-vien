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
    public partial class frm_lop : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_lop()
        {
            InitializeComponent();

        }
        private void loaddt()
        {
            DGV_Lop.DataSource = db.LOPs.
                Select(p => new {  p.MALOP, p.TENLOP, p.KHOA.TENKHOA, p.SISO })
                .OrderBy(p=> p.TENLOP);
        }
        private void loaddl1(string maKhoa)
        {
            DGV_Lop.DataSource = db
                .LOPs
                .Where(p=> p.MAKHOA == maKhoa)
                .Select(p => new { p.MALOP, p.TENLOP, p.KHOA.TENKHOA, p.SISO })
                .OrderBy(p => p.TENLOP);

        }
        private void loaddl2(string malop)
        {
            DGV_Lop.DataSource = db
                .LOPs
                .Where(p => p.MALOP == malop)
                .Select(p => new { p.MALOP, p.TENLOP, p.KHOA.TENKHOA, p.SISO })
                .OrderBy(p => p.TENLOP);

        }
        private void bindingdl(string malop1)
        {
            LOP lop = db.LOPs.Where(p => p.MALOP == malop1).SingleOrDefault();
            tenlop_Lop.Text = lop.TENLOP;
            malop_Lop.Text = lop.MALOP;
            khoa_Lop.Text = lop.KHOA.TENKHOA;
            siso_Lop.Value = (decimal)lop.SISO.Value;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRow = e.RowIndex;
            if ( DGV_Lop.RowCount>=1 && idRow >= 0)
            {
                string malop = DGV_Lop.Rows[idRow].Cells[0].Value.ToString();
                bindingdl(malop);
            }
        }

        private void frm_lop_Load(object sender, EventArgs e)
        {   
            khoa_Lop.DataSource = db.KHOAs.OrderBy(p => p.MAKHOA);
            khoa_Lop.DisplayMember = "TENKHOA";
            khoa_Lop.ValueMember = "MAKHOA";
            string mlhp = khoa_Lop.SelectedValue.ToString();
            loaddl1(mlhp);
            if (DGV_Lop.Rows.Count > 0)
            {
                string malop = DGV_Lop.Rows[0].Cells[0].Value.ToString();
                bindingdl(malop);
            }
            else
            {
                resetText();
            }
            cheDoXem();
        }

        public bool nhanThem = false;
        public bool nhanSua = false;

        private void khoa_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mlhp = khoa_Lop.SelectedValue.ToString();
            loaddl1(mlhp);
            if (DGV_Lop.Rows.Count > 0 )
            {
                string mlhp1 = DGV_Lop.Rows[0].Cells[0].Value.ToString();
                bindingdl(mlhp1);
            }
            else
            {
                resetText();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nhanThem)
            {
                if (khoa_Lop.Text == "" || malop_Lop.Text == "" || tenlop_Lop.Text == "" || siso_Lop.Text=="")
                {
                    MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);     
                }
                else
                {
                    LOP lop = new LOP();

                    lop.MALOP = malop_Lop.Text;
                    lop.TENLOP = tenlop_Lop.Text;
                    lop.MAKHOA = khoa_Lop.SelectedValue.ToString();
                    lop.SISO = int.Parse(siso_Lop.Text);

                    if (db.LOPs.Where(p => p.MALOP == malop_Lop.Text).SingleOrDefault() != null)
                    {
                        MessageBox.Show("Mã lớp học đã tồn tại", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        malop_Lop.Focus();
                        malop_Lop.SelectAll();
                    }
                    else
                    {
                        db.LOPs.InsertOnSubmit(lop);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string mlhp = khoa_Lop.SelectedValue.ToString();
                        loaddl1(mlhp);
                        if (DGV_Lop.Rows.Count > 0)
                        {
                            string malop = DGV_Lop.Rows[0].Cells[0].Value.ToString();
                            bindingdl(malop);
                        }

                        cheDoXem();
                        nhanThem = false;
                        nhanSua = false;
                    }
                }
            }
            if (nhanSua)
            {
                if (khoa_Lop.Text == "" || malop_Lop.Text == "" || tenlop_Lop.Text == "" || siso_Lop.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Sửa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    LOP lop = db.LOPs.SingleOrDefault(p => p.MALOP == malop_Lop.Text);
                    if (lop != null)
                    {
                        lop.TENLOP = tenlop_Lop.Text;
                        lop.MAKHOA = khoa_Lop.SelectedValue.ToString();
                        lop.SISO = int.Parse(siso_Lop.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string mlhp = khoa_Lop.SelectedValue.ToString();
                        loaddl1(mlhp);
                        if (DGV_Lop.Rows.Count > 0)
                        {
                            string malop = DGV_Lop.Rows[0].Cells[0].Value.ToString();
                            bindingdl(malop);
                        }

                        cheDoXem();
                        nhanThem = false;
                        nhanSua = false;
                    }
                    else
                    {
                        MessageBox.Show("Mã lớp học không tồn tại", "Sửa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        malop_Lop.Focus();
                        malop_Lop.SelectAll();
                    }
                }
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanThem = true;

            cheDoChinhSua();
            resetText();
            malop_Lop.Focus();
        }

        private void resetText()
        {
            malop_Lop.ResetText();
            tenlop_Lop.ResetText();
            siso_Lop.Value = 50;
        }

        private void cheDoChinhSua()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            malop_Lop.ReadOnly = false;
            tenlop_Lop.ReadOnly = false;
            siso_Lop.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (malop_Lop.Text != "")
                {
                    LOP lop = db.LOPs.SingleOrDefault(p => p.MALOP == malop_Lop.Text);

                    SINHVIEN sv = db.SINHVIENs.Where(p => p.MALOP == malop_Lop.Text).FirstOrDefault();


                    if (lop != null)
                    {

                        if (sv != null)
                        {
                            KETQUA kq = db.KETQUAs.Where(p => p.MASV == sv.MASV).FirstOrDefault();
                            if (kq != null)
                            {
                                db.KETQUAs.DeleteOnSubmit(kq);
                                db.SubmitChanges();
                            }

                            db.SINHVIENs.DeleteOnSubmit(sv);
                            db.SubmitChanges();
                        }

                        db.LOPs.DeleteOnSubmit(lop);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SubmitChanges();
                        string mlhp = khoa_Lop.SelectedValue.ToString();
                        loaddl1(mlhp);
                        if (DGV_Lop.Rows.Count > 0)
                        {
                            string malop = DGV_Lop.Rows[0].Cells[0].Value.ToString();
                            bindingdl(malop);
                        }
                        else
                        {
                            resetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Mời bạn chọn lớp để xóa", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cheDoXem();
            nhanThem = false;
            nhanSua = false;
   
            string mlhp = khoa_Lop.SelectedValue.ToString();
            loaddl1(mlhp);

            if (DGV_Lop.Rows.Count > 0)
            {
                string malop = DGV_Lop.Rows[0].Cells[0].Value.ToString();
                bindingdl(malop);
            }
            else resetText();
            
        }

        private void cheDoXem()
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            malop_Lop.ReadOnly = true;
            tenlop_Lop.ReadOnly = true;
            siso_Lop.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nhanSua = true;

            cheDoChinhSua();
            tenlop_Lop.Focus();
            tenlop_Lop.SelectAll();
        }

        private void frm_lop_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
