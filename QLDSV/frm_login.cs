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
    public partial class frm_login : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string adminis = "";
        public static string right;


        public frm_login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            TAIKHOAN us = db.TAIKHOANs.SingleOrDefault(p => p.TenTN == username.Text);
            TAIKHOAN tk = db.TAIKHOANs.Where(p => p.TenTN == username.Text).SingleOrDefault();

            

            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                login.Focus();
            }
            else
            {
                if (us != null)   {
                    if (username.Text == tk.TenTN && password.Text == tk.Pass)  {
                        frm_trangChu.setadmin = true;
                        adminis = username.Text;
                        right = us.rights.ToString();
                        MessageBox.Show("HI " + adminis + " ! Bạn đã đăng nhập thành công !", "Thông báo ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu \nVui lòng đăng nhập lại!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        password.Focus();
                        password.SelectAll();
                    }

                } else {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu \nVui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    password.Focus();
                    password.SelectAll();
                }
            }
            
        }

        private void Thoat_Click_1(object sender, EventArgs e)
        {
            frm_trangChu.setadmin = false;
            this.Close();
        }

        private void frm_login_Load_1(object sender, EventArgs e)
        {
            login.Focus();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                password.PasswordChar = '*';
            else
                password.PasswordChar = '\0';
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                login.PerformClick();
            }
        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Thoat_MouseHover(object sender, EventArgs e)
        {
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Thoat_MouseLeave(object sender, EventArgs e)
        {
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
