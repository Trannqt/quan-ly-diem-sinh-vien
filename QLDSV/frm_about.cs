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
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
            label3.Text = "Giáo viên hướng dẫn: ";
            label4.Text = "Sinh viên thực hiện: ";
            label5.Text = "Nguyễn Minh Hiếu - 43.01.104.050";
            label6.Text = "Trần Vĩnh Phước - 43.01.104.136";
            label7.Text = "Nguyễn Quang Trường Trận - 43.01.104.186";
            label8.Text = "Trịnh Đăng Tuyên - 43.01.104.203";

        }
    }
}
