namespace QLDSV
{
    partial class frm_diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_diem));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTinChi = new System.Windows.Forms.Label();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.colMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudDiemThi = new System.Windows.Forms.NumericUpDown();
            this.nudDiemQT = new System.Windows.Forms.NumericUpDown();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemQT)).BeginInit();
            this.gbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblHocKy);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbTinChi);
            this.groupBox3.Controls.Add(this.lbMaMon);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbbMon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 121);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn học phần";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(216, 86);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(51, 17);
            this.lblHocKy.TabIndex = 8;
            this.lblHocKy.Text = "HocKy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Học kỳ:";
            // 
            // lbTinChi
            // 
            this.lbTinChi.AutoSize = true;
            this.lbTinChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinChi.Location = new System.Drawing.Point(92, 86);
            this.lbTinChi.Name = "lbTinChi";
            this.lbTinChi.Size = new System.Drawing.Size(46, 17);
            this.lbTinChi.TabIndex = 6;
            this.lbTinChi.Text = "TinChi";
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMon.Location = new System.Drawing.Point(92, 54);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(55, 17);
            this.lbMaMon.TabIndex = 6;
            this.lbMaMon.Text = "MaMon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Tín Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã môn:";
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(49, 20);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(228, 21);
            this.cbbMon.TabIndex = 0;
            this.cbbMon.SelectedIndexChanged += new System.EventHandler(this.cbbMon_SelectedIndexChanged);
            this.cbbMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMon_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Image = global::QLDSV.Properties.Resources.edit;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(224, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "   Sửa";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Image = global::QLDSV.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(23, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSo,
            this.colHoTen,
            this.colMaHP,
            this.colMon,
            this.colTinChi,
            this.colDiemQT,
            this.colDiemThi,
            this.colDiemTK});
            this.dgvDiem.Location = new System.Drawing.Point(12, 295);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(636, 138);
            this.dgvDiem.TabIndex = 4;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // colMaSo
            // 
            this.colMaSo.DataPropertyName = "MASV";
            this.colMaSo.HeaderText = "Mã Số";
            this.colMaSo.Name = "colMaSo";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HOTEN";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colMaHP
            // 
            this.colMaHP.DataPropertyName = "MAHP";
            this.colMaHP.HeaderText = "Mã môn";
            this.colMaHP.Name = "colMaHP";
            // 
            // colMon
            // 
            this.colMon.DataPropertyName = "TENHP";
            this.colMon.HeaderText = "Tên môn";
            this.colMon.Name = "colMon";
            // 
            // colTinChi
            // 
            this.colTinChi.DataPropertyName = "TINCHI";
            this.colTinChi.HeaderText = "Tín chỉ";
            this.colTinChi.Name = "colTinChi";
            // 
            // colDiemQT
            // 
            this.colDiemQT.DataPropertyName = "DIEMQT";
            this.colDiemQT.HeaderText = "Điểm quá trình";
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
            this.colDiemTK.HeaderText = "Điểm tổng kết";
            this.colDiemTK.Name = "colDiemTK";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nudDiemThi);
            this.groupBox2.Controls.Add(this.nudDiemQT);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMSSV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // nudDiemThi
            // 
            this.nudDiemThi.DecimalPlaces = 1;
            this.nudDiemThi.Location = new System.Drawing.Point(388, 62);
            this.nudDiemThi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDiemThi.Name = "nudDiemThi";
            this.nudDiemThi.ReadOnly = true;
            this.nudDiemThi.Size = new System.Drawing.Size(120, 20);
            this.nudDiemThi.TabIndex = 3;
            this.nudDiemThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDiemQT
            // 
            this.nudDiemQT.DecimalPlaces = 1;
            this.nudDiemQT.Location = new System.Drawing.Point(130, 62);
            this.nudDiemQT.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDiemQT.Name = "nudDiemQT";
            this.nudDiemQT.ReadOnly = true;
            this.nudDiemQT.Size = new System.Drawing.Size(120, 20);
            this.nudDiemQT.TabIndex = 2;
            this.nudDiemQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(388, 23);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(48, 17);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "HoTen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm thi:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(130, 22);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(175, 20);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.Leave += new System.EventHandler(this.txtMSSV_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điểm quá trình:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "MSSV:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ Tên:";
            // 
            // gbChucNang
            // 
            this.gbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChucNang.Controls.Add(this.btnInDanhSach);
            this.gbChucNang.Controls.Add(this.btnThoat);
            this.gbChucNang.Controls.Add(this.btnHuy);
            this.gbChucNang.Controls.Add(this.btnLuu);
            this.gbChucNang.Controls.Add(this.btnXoa);
            this.gbChucNang.Controls.Add(this.btnCapNhat);
            this.gbChucNang.Controls.Add(this.btnThem);
            this.gbChucNang.Location = new System.Drawing.Point(326, 71);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(322, 114);
            this.gbChucNang.TabIndex = 2;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Location = new System.Drawing.Point(23, 78);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(276, 23);
            this.btnInDanhSach.TabIndex = 6;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.UseVisualStyleBackColor = true;
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLDSV.Properties.Resources.Login_Huy_16px1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(224, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = global::QLDSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(125, 49);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "   Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::QLDSV.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(23, 49);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLDSV.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(125, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(174, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "THÔNG TIN ĐIỂM SINH VIÊN";
            // 
            // frm_diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 445);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 484);
            this.Name = "frm_diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_diem_FormClosing);
            this.Load += new System.EventHandler(this.frm_diem_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemQT)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTinChi;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDiemThi;
        private System.Windows.Forms.NumericUpDown nudDiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTK;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label label4;
    }
}