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
   
    public partial class frm_trangChu : Form
    {
        public static bool setadmin = false;

        public frm_trangChu()
        {
            InitializeComponent();
            timer1.Start();

           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult  rs = MessageBox.Show("Bạn có muốn đóng ứng dụng không ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)  
            {
                this.Close();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timetxt.Text = DateTime.Now.ToString("dddd | dd/MM/yyyy | hh:mm:ss ");
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
    {
            frm_sinhvien frm = new frm_sinhvien();
                 
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void cậpNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khoa frm = new frm_khoa();
                
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lop frm = new frm_lop();
                
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void họcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocPhan frm = new frmHocPhan();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_diem frm = new frm_diem();
                
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void setttingDangNhap()
        {

            if (setadmin == false)
            {
                đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
                ChangePass.Visible = false;
                quảnLýToolStripMenuItem.Visible = false;
                tìmKiếmToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                xemDiemToolStripMenuItem.Visible = false;
                lblTenND.Visible = false;
            }
            else
            {
                if (frm_login.right == "8" || frm_login.right == "9")
                {
                    quảnLýToolStripMenuItem.Visible = true;
                    tìmKiếmToolStripMenuItem.Visible = true;
                    xemDiemToolStripMenuItem.Visible = false;
                    if (frm_login.right == "9")
                    {
                        adminPanel.Visible = true;
                    }
                    else
                    {
                        adminPanel.Visible = false;
                    }
                }
                else
                    xemDiemToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Text = "Đăng xuất";
                ChangePass.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                lblTenND.Visible = true;
                lblTenND.Text = "Xin chào " + frm_login.adminis + "!";
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setttingDangNhap();
            textBox1.Text = "- Trường Đại học Sư phạm Thành phố Hồ Chí Minh thành lập ngày 27/10/1976 theo Quyết định số 436/TTg của Thủ tướng Chính phủ. \r\n- Tiền thân của Trường là Đại học Sư phạm Quốc gia Sài Gòn được thành lập năm 1957. \r\n- Năm 1995, Trường là thành viên của Đại học Quốc gia Thành phố Hồ Chí Minh. \r\n- Năm 1999, Chính phủ quyết định tách trường Đại học Quốc gia Thành phố Hồ Chí Minh để xây dựng thành Trường Đại học Sư phạm Thành Hồ Chí Minh";
        }

        private void thôngTinCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_timKiem f = new frm_timKiem();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(); 
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (setadmin == false)
            {
                frm_login frm = new frm_login();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
            else
            {
                setadmin = false;
            }

            setttingDangNhap();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongKe_DauRot frm = new thongKe_DauRot();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
         
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin frm = new admin();
            frm.ShowDialog();
        }

        private void xemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemDiem frm = new frmXemDiem();
            frm.Show();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            frm_about frm = new frm_about();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
