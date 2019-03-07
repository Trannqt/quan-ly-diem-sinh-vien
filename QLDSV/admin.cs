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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void fill()
        {
            dataGridView1.DataSource = db.TAIKHOANs.Select(p => new
            {
                p.rights,
                p.TenTN,
                p.Pass
            });
        }
        private void admin_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void binding(string id)
        {
            TAIKHOAN tk = db.TAIKHOANs.Where(p => p.TenTN == id).SingleOrDefault();
            textBox1.Text = tk.TenTN;
            textBox2.Text = tk.Pass;
            numericUpDown1.Value = tk.rights.Value;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow >=0)
            {
                string tentk = dataGridView1.Rows[idrow].Cells[1].Value.ToString();
                binding(tentk);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   
            }
            else
            {

                TAIKHOAN tk = new TAIKHOAN()
                {
                    TenTN = textBox1.Text,
                    Pass = textBox2.Text,
                    rights = int.Parse(numericUpDown1.Value.ToString())
                };

                if (db.TAIKHOANs.Where(p => p.TenTN == textBox1.Text).SingleOrDefault() == null)
                {
                    db.TAIKHOANs.InsertOnSubmit(tk);
                    db.SubmitChanges();
                    fill();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thêm không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   
            }
            else
            {
                TAIKHOAN tk = db.TAIKHOANs.Where(p => p.TenTN == textBox1.Text).SingleOrDefault();

                if (tk != null)
                {
                    tk.Pass = textBox2.Text;
                    tk.rights = int.Parse(numericUpDown1.Value.ToString());
                    db.SubmitChanges();
                    fill();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại", "Sửa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBox1.Text != "")
                {
                    TAIKHOAN tk = db.TAIKHOANs.Where(p => p.TenTN == textBox1.Text).SingleOrDefault();
                    if (tk != null)
                    {
                        db.TAIKHOANs.DeleteOnSubmit(tk);
                        db.SubmitChanges();
                        fill();
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Mời bạn chọn người dùng để xóa", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
           
               this.Close();
           
        }

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

       
    }
}
