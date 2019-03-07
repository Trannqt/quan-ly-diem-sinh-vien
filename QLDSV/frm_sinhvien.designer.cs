namespace QLDSV
{
    partial class frm_sinhvien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sinhvien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SinhVien_MaSV = new System.Windows.Forms.TextBox();
            this.txt_SinhVien_hoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SinhVien_diaChi = new System.Windows.Forms.TextBox();
            this.dtgv_SinhVien_DS = new System.Windows.Forms.DataGridView();
            this.mssv_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hvt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SinhVien_Them = new System.Windows.Forms.Button();
            this.btn_SinhVien_Sua = new System.Windows.Forms.Button();
            this.btn_SinhVien_Xoa = new System.Windows.Forms.Button();
            this.btn_SinhVien_Thoat = new System.Windows.Forms.Button();
            this.dtp_SinhVien_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_SinhVien_LopHoc = new System.Windows.Forms.ComboBox();
            this.cbb_SinhVien_Khoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_SinhVien_gioitinh = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_SinhVien_KLuu = new System.Windows.Forms.Button();
            this.btn_SinhVien_Luu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SinhVien_DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // txt_SinhVien_MaSV
            // 
            this.txt_SinhVien_MaSV.Location = new System.Drawing.Point(84, 32);
            this.txt_SinhVien_MaSV.Name = "txt_SinhVien_MaSV";
            this.txt_SinhVien_MaSV.Size = new System.Drawing.Size(113, 20);
            this.txt_SinhVien_MaSV.TabIndex = 0;
            // 
            // txt_SinhVien_hoTen
            // 
            this.txt_SinhVien_hoTen.Location = new System.Drawing.Point(252, 32);
            this.txt_SinhVien_hoTen.Name = "txt_SinhVien_hoTen";
            this.txt_SinhVien_hoTen.Size = new System.Drawing.Size(153, 20);
            this.txt_SinhVien_hoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới Tính";
            this.toolTip1.SetToolTip(this.label3, "Chỉ nhập Nam hoặc Nữ");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ";
            // 
            // txt_SinhVien_diaChi
            // 
            this.txt_SinhVien_diaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SinhVien_diaChi.Location = new System.Drawing.Point(75, 107);
            this.txt_SinhVien_diaChi.Name = "txt_SinhVien_diaChi";
            this.txt_SinhVien_diaChi.Size = new System.Drawing.Size(330, 20);
            this.txt_SinhVien_diaChi.TabIndex = 4;
            // 
            // dtgv_SinhVien_DS
            // 
            this.dtgv_SinhVien_DS.AllowUserToAddRows = false;
            this.dtgv_SinhVien_DS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_SinhVien_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SinhVien_DS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv_col,
            this.hvt_col,
            this.birthday_col,
            this.sex_col,
            this.diachi_col,
            this.makhoa});
            this.dtgv_SinhVien_DS.Location = new System.Drawing.Point(3, 16);
            this.dtgv_SinhVien_DS.Name = "dtgv_SinhVien_DS";
            this.dtgv_SinhVien_DS.Size = new System.Drawing.Size(497, 285);
            this.dtgv_SinhVien_DS.TabIndex = 3;
            this.dtgv_SinhVien_DS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_SinhVien_DS_CellClick);
            // 
            // mssv_col
            // 
            this.mssv_col.DataPropertyName = "MASV";
            this.mssv_col.HeaderText = "Mã Sinh VIên";
            this.mssv_col.Name = "mssv_col";
            // 
            // hvt_col
            // 
            this.hvt_col.DataPropertyName = "HOTEN";
            this.hvt_col.HeaderText = "Họ Và Tên";
            this.hvt_col.Name = "hvt_col";
            // 
            // birthday_col
            // 
            this.birthday_col.DataPropertyName = "NGAYSINH";
            this.birthday_col.HeaderText = "Ngày Sinh";
            this.birthday_col.Name = "birthday_col";
            // 
            // sex_col
            // 
            this.sex_col.DataPropertyName = "GIOITINH";
            this.sex_col.HeaderText = "Giới Tính";
            this.sex_col.Name = "sex_col";
            // 
            // diachi_col
            // 
            this.diachi_col.DataPropertyName = "DIACHI";
            this.diachi_col.HeaderText = "Địa Chỉ";
            this.diachi_col.Name = "diachi_col";
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "TENKHOA";
            this.makhoa.HeaderText = "Khoa";
            this.makhoa.Name = "makhoa";
            // 
            // btn_SinhVien_Them
            // 
            this.btn_SinhVien_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SinhVien_Them.Image = global::QLDSV.Properties.Resources.add;
            this.btn_SinhVien_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinhVien_Them.Location = new System.Drawing.Point(48, 19);
            this.btn_SinhVien_Them.Name = "btn_SinhVien_Them";
            this.btn_SinhVien_Them.Size = new System.Drawing.Size(73, 29);
            this.btn_SinhVien_Them.TabIndex = 5;
            this.btn_SinhVien_Them.Text = "   Thêm";
            this.btn_SinhVien_Them.UseVisualStyleBackColor = true;
            this.btn_SinhVien_Them.Click += new System.EventHandler(this.btn_SinhVien_Them_Click);
            // 
            // btn_SinhVien_Sua
            // 
            this.btn_SinhVien_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVien_Sua.Image = global::QLDSV.Properties.Resources.edit;
            this.btn_SinhVien_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinhVien_Sua.Location = new System.Drawing.Point(304, 19);
            this.btn_SinhVien_Sua.Name = "btn_SinhVien_Sua";
            this.btn_SinhVien_Sua.Size = new System.Drawing.Size(73, 29);
            this.btn_SinhVien_Sua.TabIndex = 7;
            this.btn_SinhVien_Sua.Text = "   Sửa";
            this.btn_SinhVien_Sua.UseVisualStyleBackColor = true;
            this.btn_SinhVien_Sua.Click += new System.EventHandler(this.btn_SinhVien_Sua_Click);
            // 
            // btn_SinhVien_Xoa
            // 
            this.btn_SinhVien_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVien_Xoa.Image = global::QLDSV.Properties.Resources.delete;
            this.btn_SinhVien_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinhVien_Xoa.Location = new System.Drawing.Point(176, 19);
            this.btn_SinhVien_Xoa.Name = "btn_SinhVien_Xoa";
            this.btn_SinhVien_Xoa.Size = new System.Drawing.Size(73, 29);
            this.btn_SinhVien_Xoa.TabIndex = 6;
            this.btn_SinhVien_Xoa.Text = "   Xóa";
            this.btn_SinhVien_Xoa.UseVisualStyleBackColor = true;
            this.btn_SinhVien_Xoa.Click += new System.EventHandler(this.btn_SinhVien_Xoa_Click);
            // 
            // btn_SinhVien_Thoat
            // 
            this.btn_SinhVien_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVien_Thoat.Image = global::QLDSV.Properties.Resources.Login_Huy_16px1;
            this.btn_SinhVien_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinhVien_Thoat.Location = new System.Drawing.Point(304, 56);
            this.btn_SinhVien_Thoat.Name = "btn_SinhVien_Thoat";
            this.btn_SinhVien_Thoat.Size = new System.Drawing.Size(73, 29);
            this.btn_SinhVien_Thoat.TabIndex = 10;
            this.btn_SinhVien_Thoat.Text = "   Thoát";
            this.btn_SinhVien_Thoat.UseVisualStyleBackColor = true;
            this.btn_SinhVien_Thoat.Click += new System.EventHandler(this.btn_SinhVien_Thoat_Click);
            // 
            // dtp_SinhVien_ngaySinh
            // 
            this.dtp_SinhVien_ngaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_SinhVien_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SinhVien_ngaySinh.Location = new System.Drawing.Point(84, 69);
            this.dtp_SinhVien_ngaySinh.Name = "dtp_SinhVien_ngaySinh";
            this.dtp_SinhVien_ngaySinh.Size = new System.Drawing.Size(147, 20);
            this.dtp_SinhVien_ngaySinh.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 41);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(362, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_SinhVien_LopHoc);
            this.groupBox1.Controls.Add(this.cbb_SinhVien_Khoa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(522, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 52);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbb_SinhVien_LopHoc
            // 
            this.cbb_SinhVien_LopHoc.FormattingEnabled = true;
            this.cbb_SinhVien_LopHoc.Location = new System.Drawing.Point(266, 21);
            this.cbb_SinhVien_LopHoc.Name = "cbb_SinhVien_LopHoc";
            this.cbb_SinhVien_LopHoc.Size = new System.Drawing.Size(121, 21);
            this.cbb_SinhVien_LopHoc.TabIndex = 1;
            this.cbb_SinhVien_LopHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_SinhVien_LopHoc_SelectedIndexChanged);
            // 
            // cbb_SinhVien_Khoa
            // 
            this.cbb_SinhVien_Khoa.FormattingEnabled = true;
            this.cbb_SinhVien_Khoa.Location = new System.Drawing.Point(54, 21);
            this.cbb_SinhVien_Khoa.Name = "cbb_SinhVien_Khoa";
            this.cbb_SinhVien_Khoa.Size = new System.Drawing.Size(143, 21);
            this.cbb_SinhVien_Khoa.TabIndex = 0;
            this.cbb_SinhVien_Khoa.SelectedIndexChanged += new System.EventHandler(this.cbb_SinhVien_Khoa_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lớp học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_SinhVien_gioitinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_SinhVien_MaSV);
            this.groupBox2.Controls.Add(this.dtp_SinhVien_ngaySinh);
            this.groupBox2.Controls.Add(this.txt_SinhVien_hoTen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_SinhVien_diaChi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(522, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txt_SinhVien_gioitinh
            // 
            this.txt_SinhVien_gioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SinhVien_gioitinh.Location = new System.Drawing.Point(301, 69);
            this.txt_SinhVien_gioitinh.Name = "txt_SinhVien_gioitinh";
            this.txt_SinhVien_gioitinh.Size = new System.Drawing.Size(104, 20);
            this.txt_SinhVien_gioitinh.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_SinhVien_gioitinh, "Chỉ nhập Nam hoặc Nữ");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_SinhVien_DS);
            this.groupBox3.Location = new System.Drawing.Point(3, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 304);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_SinhVien_Thoat);
            this.groupBox4.Controls.Add(this.btn_SinhVien_KLuu);
            this.groupBox4.Controls.Add(this.btn_SinhVien_Luu);
            this.groupBox4.Controls.Add(this.btn_SinhVien_Xoa);
            this.groupBox4.Controls.Add(this.btn_SinhVien_Them);
            this.groupBox4.Controls.Add(this.btn_SinhVien_Sua);
            this.groupBox4.Location = new System.Drawing.Point(522, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 90);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btn_SinhVien_KLuu
            // 
            this.btn_SinhVien_KLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVien_KLuu.Image = global::QLDSV.Properties.Resources.cancel;
            this.btn_SinhVien_KLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinhVien_KLuu.Location = new System.Drawing.Point(176, 56);
            this.btn_SinhVien_KLuu.Name = "btn_SinhVien_KLuu";
            this.btn_SinhVien_KLuu.Size = new System.Drawing.Size(73, 29);
            this.btn_SinhVien_KLuu.TabIndex = 9;
            this.btn_SinhVien_KLuu.Text = "   Hủy";
            this.btn_SinhVien_KLuu.UseVisualStyleBackColor = true;
            this.btn_SinhVien_KLuu.Click += new System.EventHandler(this.btn_SinhVien_KLuu_Click);
            // 
            // btn_SinhVien_Luu
            // 
            this.btn_SinhVien_Luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVien_Luu.Image = global::QLDSV.Properties.Resources.save;
            this.btn_SinhVien_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SinhVien_Luu.Location = new System.Drawing.Point(48, 54);
            this.btn_SinhVien_Luu.Name = "btn_SinhVien_Luu";
            this.btn_SinhVien_Luu.Size = new System.Drawing.Size(73, 29);
            this.btn_SinhVien_Luu.TabIndex = 8;
            this.btn_SinhVien_Luu.Text = "   Lưu";
            this.btn_SinhVien_Luu.UseVisualStyleBackColor = true;
            this.btn_SinhVien_Luu.Click += new System.EventHandler(this.btn_SinhVien_Luu_Click);
            // 
            // frm_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_sinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_sinhvien_FormClosing);
            this.Load += new System.EventHandler(this.frm_sinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SinhVien_DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SinhVien_MaSV;
        private System.Windows.Forms.TextBox txt_SinhVien_hoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SinhVien_diaChi;
        private System.Windows.Forms.DataGridView dtgv_SinhVien_DS;
        private System.Windows.Forms.Button btn_SinhVien_Them;
        private System.Windows.Forms.Button btn_SinhVien_Sua;
        private System.Windows.Forms.Button btn_SinhVien_Xoa;
        private System.Windows.Forms.Button btn_SinhVien_Thoat;
        private System.Windows.Forms.DateTimePicker dtp_SinhVien_ngaySinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_SinhVien_LopHoc;
        private System.Windows.Forms.ComboBox cbb_SinhVien_Khoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_SinhVien_Luu;
        private System.Windows.Forms.Button btn_SinhVien_KLuu;
        private System.Windows.Forms.TextBox txt_SinhVien_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn hvt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}