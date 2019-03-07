namespace QLDSV
{
    partial class frm_timKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_timKiem));
            this.dtpNgaySinh_timkiem = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbLopHoc_tìmKiem = new System.Windows.Forms.ComboBox();
            this.cbbKhoa_tìmKiem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtgioitinh_TK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV_timKiem = new System.Windows.Forms.TextBox();
            this.txtHoTen_timKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiaChi_TK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvDS_timKiem = new System.Windows.Forms.DataGridView();
            this.mssv_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hvt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Thoát = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS_timKiem)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgaySinh_timkiem
            // 
            this.dtpNgaySinh_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaySinh_timkiem.Location = new System.Drawing.Point(84, 69);
            this.dtpNgaySinh_timkiem.Name = "dtpNgaySinh_timkiem";
            this.dtpNgaySinh_timkiem.Size = new System.Drawing.Size(147, 20);
            this.dtpNgaySinh_timkiem.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(16, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 41);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(363, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "THÔNG TIN SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.cbbLopHoc_tìmKiem);
            this.groupBox1.Controls.Add(this.cbbKhoa_tìmKiem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(526, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = global::QLDSV.Properties.Resources.search;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "     Dữ liệu cần tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(127, 64);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbLopHoc_tìmKiem
            // 
            this.cbbLopHoc_tìmKiem.FormattingEnabled = true;
            this.cbbLopHoc_tìmKiem.Location = new System.Drawing.Point(266, 21);
            this.cbbLopHoc_tìmKiem.Name = "cbbLopHoc_tìmKiem";
            this.cbbLopHoc_tìmKiem.Size = new System.Drawing.Size(121, 21);
            this.cbbLopHoc_tìmKiem.TabIndex = 1;
            this.cbbLopHoc_tìmKiem.SelectedIndexChanged += new System.EventHandler(this.cbbLopHoc_tìmKiem_SelectedIndexChanged);
            // 
            // cbbKhoa_tìmKiem
            // 
            this.cbbKhoa_tìmKiem.FormattingEnabled = true;
            this.cbbKhoa_tìmKiem.Location = new System.Drawing.Point(54, 21);
            this.cbbKhoa_tìmKiem.Name = "cbbKhoa_tìmKiem";
            this.cbbKhoa_tìmKiem.Size = new System.Drawing.Size(143, 21);
            this.cbbKhoa_tìmKiem.TabIndex = 0;
            this.cbbKhoa_tìmKiem.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_tìmKiem_SelectedIndexChanged);
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
            this.groupBox2.Controls.Add(this.txtgioitinh_TK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaSV_timKiem);
            this.groupBox2.Controls.Add(this.dtpNgaySinh_timkiem);
            this.groupBox2.Controls.Add(this.txtHoTen_timKiem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtdiaChi_TK);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(526, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtgioitinh_TK
            // 
            this.txtgioitinh_TK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtgioitinh_TK.Location = new System.Drawing.Point(301, 69);
            this.txtgioitinh_TK.Name = "txtgioitinh_TK";
            this.txtgioitinh_TK.Size = new System.Drawing.Size(104, 20);
            this.txtgioitinh_TK.TabIndex = 3;
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
            // txtMaSV_timKiem
            // 
            this.txtMaSV_timKiem.Location = new System.Drawing.Point(84, 32);
            this.txtMaSV_timKiem.Name = "txtMaSV_timKiem";
            this.txtMaSV_timKiem.Size = new System.Drawing.Size(113, 20);
            this.txtMaSV_timKiem.TabIndex = 0;
            // 
            // txtHoTen_timKiem
            // 
            this.txtHoTen_timKiem.Location = new System.Drawing.Point(252, 32);
            this.txtHoTen_timKiem.Name = "txtHoTen_timKiem";
            this.txtHoTen_timKiem.Size = new System.Drawing.Size(153, 20);
            this.txtHoTen_timKiem.TabIndex = 1;
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới Tính";
            // 
            // txtdiaChi_TK
            // 
            this.txtdiaChi_TK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdiaChi_TK.Location = new System.Drawing.Point(75, 107);
            this.txtdiaChi_TK.Name = "txtdiaChi_TK";
            this.txtdiaChi_TK.Size = new System.Drawing.Size(330, 20);
            this.txtdiaChi_TK.TabIndex = 4;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvDS_timKiem);
            this.groupBox3.Location = new System.Drawing.Point(7, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 266);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dtgvDS_timKiem
            // 
            this.dtgvDS_timKiem.AllowUserToAddRows = false;
            this.dtgvDS_timKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS_timKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS_timKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv_col,
            this.hvt_col,
            this.birthday_col,
            this.sex_col,
            this.diachi_col,
            this.makhoa});
            this.dtgvDS_timKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS_timKiem.Location = new System.Drawing.Point(3, 16);
            this.dtgvDS_timKiem.Name = "dtgvDS_timKiem";
            this.dtgvDS_timKiem.Size = new System.Drawing.Size(497, 247);
            this.dtgvDS_timKiem.TabIndex = 2;
            this.dtgvDS_timKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS_timKiem_CellClick);
            // 
            // mssv_col
            // 
            this.mssv_col.DataPropertyName = "MASV";
            this.mssv_col.FillWeight = 74.3147F;
            this.mssv_col.HeaderText = "Mã Sinh VIên";
            this.mssv_col.Name = "mssv_col";
            // 
            // hvt_col
            // 
            this.hvt_col.DataPropertyName = "HOTEN";
            this.hvt_col.FillWeight = 95.42642F;
            this.hvt_col.HeaderText = "Họ Và Tên";
            this.hvt_col.Name = "hvt_col";
            // 
            // birthday_col
            // 
            this.birthday_col.DataPropertyName = "NGAYSINH";
            this.birthday_col.FillWeight = 74.3147F;
            this.birthday_col.HeaderText = "Ngày Sinh";
            this.birthday_col.Name = "birthday_col";
            // 
            // sex_col
            // 
            this.sex_col.DataPropertyName = "GIOITINH";
            this.sex_col.FillWeight = 74.3147F;
            this.sex_col.HeaderText = "Giới Tính";
            this.sex_col.Name = "sex_col";
            // 
            // diachi_col
            // 
            this.diachi_col.DataPropertyName = "DIACHI";
            this.diachi_col.FillWeight = 74.3147F;
            this.diachi_col.HeaderText = "Địa Chỉ";
            this.diachi_col.Name = "diachi_col";
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "TENKHOA";
            this.makhoa.FillWeight = 74.3147F;
            this.makhoa.HeaderText = "Khoa";
            this.makhoa.Name = "makhoa";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Thoát});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(865, 17);
            // 
            // Thoát
            // 
            this.Thoát.AutoSize = false;
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(50, 17);
            this.Thoát.Text = "Thoát";
            this.Thoát.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // frm_timKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 349);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_timKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_timKiem_FormClosing);
            this.Load += new System.EventHandler(this.frm_timKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS_timKiem)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaySinh_timkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbLopHoc_tìmKiem;
        private System.Windows.Forms.ComboBox cbbKhoa_tìmKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtgioitinh_TK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV_timKiem;
        private System.Windows.Forms.TextBox txtHoTen_timKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiaChi_TK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvDS_timKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Thoát;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn hvt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;

    }
}