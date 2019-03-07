namespace QLDSV
{
    partial class frmXemDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDiem));
            this.dgvDiemSV = new System.Windows.Forms.DataGridView();
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbTenSV = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
            this.lbInDiem = new System.Windows.Forms.Label();
            this.lbXepLoai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDiemTB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSV)).BeginInit();
            this.gbThongTinSV.SuspendLayout();
            this.gbKetQua.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiemSV
            // 
            this.dgvDiemSV.AllowUserToAddRows = false;
            this.dgvDiemSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMon,
            this.colDiemQT,
            this.colDiemThi,
            this.colDiemTK,
            this.colKetQua});
            this.dgvDiemSV.Location = new System.Drawing.Point(3, 52);
            this.dgvDiemSV.Name = "dgvDiemSV";
            this.dgvDiemSV.Size = new System.Drawing.Size(449, 265);
            this.dgvDiemSV.TabIndex = 2;
            this.dgvDiemSV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiemSV_CellFormatting);
            // 
            // colMon
            // 
            this.colMon.DataPropertyName = "TENHP";
            this.colMon.HeaderText = "Môn";
            this.colMon.Name = "colMon";
            // 
            // colDiemQT
            // 
            this.colDiemQT.DataPropertyName = "DIEMQT";
            this.colDiemQT.HeaderText = "Điểm quá trình";
            this.colDiemQT.Name = "colDiemQT";
            // 
            // colDiemThi
            // 
            this.colDiemThi.DataPropertyName = "DIEMTHI";
            this.colDiemThi.HeaderText = "Điểm thi";
            this.colDiemThi.Name = "colDiemThi";
            // 
            // colDiemTK
            // 
            this.colDiemTK.DataPropertyName = "DIEMTK";
            this.colDiemTK.HeaderText = "Điểm TK";
            this.colDiemTK.Name = "colDiemTK";
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "KQ";
            this.colKetQua.HeaderText = "Kết quả";
            this.colKetQua.Name = "colKetQua";
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Controls.Add(this.label8);
            this.gbThongTinSV.Controls.Add(this.lbGioiTinh);
            this.gbThongTinSV.Controls.Add(this.lbKhoa);
            this.gbThongTinSV.Controls.Add(this.lbLop);
            this.gbThongTinSV.Controls.Add(this.lbDiaChi);
            this.gbThongTinSV.Controls.Add(this.lbNgaySinh);
            this.gbThongTinSV.Controls.Add(this.lbTenSV);
            this.gbThongTinSV.Controls.Add(this.lbMaSV);
            this.gbThongTinSV.Controls.Add(this.label7);
            this.gbThongTinSV.Controls.Add(this.label11);
            this.gbThongTinSV.Controls.Add(this.label9);
            this.gbThongTinSV.Controls.Add(this.label5);
            this.gbThongTinSV.Controls.Add(this.label2);
            this.gbThongTinSV.Controls.Add(this.label1);
            this.gbThongTinSV.Location = new System.Drawing.Point(458, 52);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(339, 157);
            this.gbThongTinSV.TabIndex = 1;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Khoa:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(203, 62);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(46, 13);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "GioiTinh";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(203, 93);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(32, 13);
            this.lbKhoa.TabIndex = 2;
            this.lbKhoa.Text = "Khoa";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(82, 93);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(25, 13);
            this.lbLop.TabIndex = 2;
            this.lbLop.Text = "Lop";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(83, 124);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(38, 13);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "DiaChi";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(82, 62);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(42, 13);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "NgSinh";
            // 
            // lbTenSV
            // 
            this.lbTenSV.AutoSize = true;
            this.lbTenSV.Location = new System.Drawing.Point(203, 30);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Size = new System.Drawing.Size(40, 13);
            this.lbTenSV.TabIndex = 2;
            this.lbTenSV.Text = "HoTen";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(81, 30);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(36, 13);
            this.lbMaSV.TabIndex = 2;
            this.lbMaSV.Text = "MaSV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lớp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SV:";
            // 
            // gbKetQua
            // 
            this.gbKetQua.Controls.Add(this.lbInDiem);
            this.gbKetQua.Controls.Add(this.lbXepLoai);
            this.gbKetQua.Controls.Add(this.label6);
            this.gbKetQua.Controls.Add(this.lbDiemTB);
            this.gbKetQua.Controls.Add(this.label4);
            this.gbKetQua.Controls.Add(this.cbbHocKy);
            this.gbKetQua.Controls.Add(this.label3);
            this.gbKetQua.Location = new System.Drawing.Point(458, 215);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Size = new System.Drawing.Size(339, 102);
            this.gbKetQua.TabIndex = 0;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "Kết quả";
            // 
            // lbInDiem
            // 
            this.lbInDiem.AutoSize = true;
            this.lbInDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInDiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInDiem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbInDiem.Location = new System.Drawing.Point(283, 83);
            this.lbInDiem.Name = "lbInDiem";
            this.lbInDiem.Size = new System.Drawing.Size(50, 16);
            this.lbInDiem.TabIndex = 2;
            this.lbInDiem.Text = "In điểm";
            this.lbInDiem.Click += new System.EventHandler(this.lbInDiem_Click);
            // 
            // lbXepLoai
            // 
            this.lbXepLoai.AutoSize = true;
            this.lbXepLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXepLoai.ForeColor = System.Drawing.Color.Red;
            this.lbXepLoai.Location = new System.Drawing.Point(207, 68);
            this.lbXepLoai.Name = "lbXepLoai";
            this.lbXepLoai.Size = new System.Drawing.Size(32, 15);
            this.lbXepLoai.TabIndex = 4;
            this.lbXepLoai.Text = "Kém";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Xếp loại:";
            // 
            // lbDiemTB
            // 
            this.lbDiemTB.AutoSize = true;
            this.lbDiemTB.Location = new System.Drawing.Point(115, 69);
            this.lbDiemTB.Name = "lbDiemTB";
            this.lbDiemTB.Size = new System.Drawing.Size(22, 13);
            this.lbDiemTB.TabIndex = 3;
            this.lbDiemTB.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm trung bình:";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Location = new System.Drawing.Point(145, 19);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(136, 21);
            this.cbbHocKy.TabIndex = 1;
            this.cbbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbbHocKy_SelectedIndexChanged);
            this.cbbHocKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbHocKy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học kỳ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 43);
            this.panel1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(332, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ĐIỂM CÁ NHÂN";
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbKetQua);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.dgvDiemSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm cá nhân";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSV)).EndInit();
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            this.gbKetQua.ResumeLayout(false);
            this.gbKetQua.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiemSV;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbTenSV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.Label lbXepLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDiemTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
        private System.Windows.Forms.Label lbInDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}