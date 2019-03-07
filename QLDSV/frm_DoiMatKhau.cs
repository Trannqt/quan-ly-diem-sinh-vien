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
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        
        private void btnXacNhan_DMK_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = db.TAIKHOANs.SingleOrDefault(p => p.TenTN == frm_login.adminis);

            if (txtMatKhauCu_DMK.Text == "" || txtMatKhauMoi_DMK.Text == "" || txtXacNhanMk_DMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ để đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatKhauCu_DMK.Focus();
            }
            else
            {
                if (txtMatKhauCu_DMK.Text != tk.Pass)
                {
                    MessageBox.Show("Sai mật khẩu  \nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatKhauCu_DMK.Focus();
                    txtMatKhauCu_DMK.SelectAll();
                }
                else
                {
                    if (txtXacNhanMk_DMK.Text == txtMatKhauMoi_DMK.Text)
                    {
                        tk.Pass = txtMatKhauMoi_DMK.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Đổi mật khẩu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới không trùng khớp  \nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtXacNhanMk_DMK.Focus();
                        txtXacNhanMk_DMK.SelectAll();
                    }
                }
            }
        }

        private void btnHuy_DMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ckbAnHienMK_DMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAnHienMK_DMK.Checked == false){
                txtMatKhauCu_DMK.PasswordChar = '*';
                txtMatKhauMoi_DMK.PasswordChar= '*';
                txtXacNhanMk_DMK.PasswordChar= '*';
            }
            else
            {
                txtMatKhauCu_DMK.PasswordChar = '\0';
                txtMatKhauMoi_DMK.PasswordChar = '\0';
                txtXacNhanMk_DMK.PasswordChar = '\0';
            }
                
        }

        
         
        }

 
        
    
}
