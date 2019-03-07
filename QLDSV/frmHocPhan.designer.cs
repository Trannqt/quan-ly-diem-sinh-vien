namespace QLDSV
{
    partial class frmHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.cbbKhoaPT = new System.Windows.Forms.ComboBox();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.colMaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhanTram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinHP = new System.Windows.Forms.GroupBox();
            this.nudPhanTram = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.gbThongTinHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhanTram)).BeginInit();
            this.gbChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên học phần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tín chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã học phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khoa phụ trách:";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(100, 25);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.ReadOnly = true;
            this.txtMaHP.Size = new System.Drawing.Size(123, 20);
            this.txtMaHP.TabIndex = 0;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(100, 64);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.ReadOnly = true;
            this.txtTenHP.Size = new System.Drawing.Size(123, 20);
            this.txtTenHP.TabIndex = 1;
            // 
            // txtTinChi
            // 
            this.txtTinChi.Location = new System.Drawing.Point(324, 64);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.ReadOnly = true;
            this.txtTinChi.Size = new System.Drawing.Size(34, 20);
            this.txtTinChi.TabIndex = 4;
            this.txtTinChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(324, 25);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(34, 20);
            this.txtHocKy.TabIndex = 3;
            this.txtHocKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbKhoaPT
            // 
            this.cbbKhoaPT.FormattingEnabled = true;
            this.cbbKhoaPT.Location = new System.Drawing.Point(100, 104);
            this.cbbKhoaPT.Name = "cbbKhoaPT";
            this.cbbKhoaPT.Size = new System.Drawing.Size(123, 21);
            this.cbbKhoaPT.TabIndex = 2;
            this.cbbKhoaPT.SelectedIndexChanged += new System.EventHandler(this.cbbKhoaPT_SelectedIndexChanged);
            this.cbbKhoaPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbKhoaPT_KeyPress);
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AllowUserToAddRows = false;
            this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHP,
            this.colTenHP,
            this.colTinChi,
            this.colHocKy,
            this.colPhanTram,
            this.colKhoaPT});
            this.dgvHocPhan.Location = new System.Drawing.Point(12, 206);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.Size = new System.Drawing.Size(701, 231);
            this.dgvHocPhan.TabIndex = 2;
            this.dgvHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellClick);
            // 
            // colMaHP
            // 
            this.colMaHP.DataPropertyName = "MAHP";
            this.colMaHP.HeaderText = "Mã học phần";
            this.colMaHP.Name = "colMaHP";
            // 
            // colTenHP
            // 
            this.colTenHP.DataPropertyName = "TENHP";
            this.colTenHP.HeaderText = "Tên học phần";
            this.colTenHP.Name = "colTenHP";
            // 
            // colTinChi
            // 
            this.colTinChi.DataPropertyName = "TINCHI";
            this.colTinChi.HeaderText = "Tín chỉ";
            this.colTinChi.Name = "colTinChi";
            // 
            // colHocKy
            // 
            this.colHocKy.DataPropertyName = "HOCKY";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.Name = "colHocKy";
            // 
            // colPhanTram
            // 
            this.colPhanTram.DataPropertyName = "PHANTRAMQT";
            this.colPhanTram.HeaderText = "Phần trăm QT";
            this.colPhanTram.Name = "colPhanTram";
            // 
            // colKhoaPT
            // 
            this.colKhoaPT.DataPropertyName = "TENKHOA";
            this.colKhoaPT.HeaderText = "Tên khoa";
            this.colKhoaPT.Name = "colKhoaPT";
            // 
            // gbThongTinHP
            // 
            this.gbThongTinHP.Controls.Add(this.nudPhanTram);
            this.gbThongTinHP.Controls.Add(this.label5);
            this.gbThongTinHP.Controls.Add(this.txtTenHP);
            this.gbThongTinHP.Controls.Add(this.txtMaHP);
            this.gbThongTinHP.Controls.Add(this.cbbKhoaPT);
            this.gbThongTinHP.Controls.Add(this.label3);
            this.gbThongTinHP.Controls.Add(this.txtHocKy);
            this.gbThongTinHP.Controls.Add(this.label1);
            this.gbThongTinHP.Controls.Add(this.label6);
            this.gbThongTinHP.Controls.Add(this.label4);
            this.gbThongTinHP.Controls.Add(this.label2);
            this.gbThongTinHP.Controls.Add(this.txtTinChi);
            this.gbThongTinHP.Location = new System.Drawing.Point(12, 61);
            this.gbThongTinHP.Name = "gbThongTinHP";
            this.gbThongTinHP.Size = new System.Drawing.Size(374, 139);
            this.gbThongTinHP.TabIndex = 0;
            this.gbThongTinHP.TabStop = false;
            this.gbThongTinHP.Text = "Thông tin học phần";
            // 
            // nudPhanTram
            // 
            this.nudPhanTram.Location = new System.Drawing.Point(324, 105);
            this.nudPhanTram.Name = "nudPhanTram";
            this.nudPhanTram.ReadOnly = true;
            this.nudPhanTram.Size = new System.Drawing.Size(34, 20);
            this.nudPhanTram.TabIndex = 5;
            this.nudPhanTram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phần trăm QT:";
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnThoat);
            this.gbChucNang.Controls.Add(this.btnHuy);
            this.gbChucNang.Controls.Add(this.btnSua);
            this.gbChucNang.Controls.Add(this.btnLuu);
            this.gbChucNang.Controls.Add(this.btnXoa);
            this.gbChucNang.Controls.Add(this.btnThem);
            this.gbChucNang.Location = new System.Drawing.Point(392, 61);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(321, 139);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLDSV.Properties.Resources.Login_Huy_16px1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(225, 90);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 30);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 43);
            this.panel1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(236, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "QUẢN LÝ HỌC PHẦN";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = global::QLDSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(129, 90);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(59, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLDSV.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(225, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::QLDSV.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(32, 90);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(59, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLDSV.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(129, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLDSV.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(32, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.dgvHocPhan);
            this.Controls.Add(this.gbThongTinHP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học phần";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHocPhan_FormClosing);
            this.Load += new System.EventHandler(this.frmHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.gbThongTinHP.ResumeLayout(false);
            this.gbThongTinHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhanTram)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.ComboBox cbbKhoaPT;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.GroupBox gbThongTinHP;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhanTram;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaPT;
        private System.Windows.Forms.NumericUpDown nudPhanTram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.Button btnLuu;
    }
}