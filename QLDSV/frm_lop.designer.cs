namespace QLDSV
{
    partial class frm_lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lop));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tenlop_Lop = new System.Windows.Forms.TextBox();
            this.siso_Lop = new System.Windows.Forms.NumericUpDown();
            this.khoa_Lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.malop_Lop = new System.Windows.Forms.TextBox();
            this.DGV_Lop = new System.Windows.Forms.DataGridView();
            this.tenlop_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopkhoa_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ss_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siso_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLDSV.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(50, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "   Thêm";
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tenlop_Lop);
            this.groupBox1.Controls.Add(this.siso_Lop);
            this.groupBox1.Controls.Add(this.khoa_Lop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.malop_Lop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(441, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // tenlop_Lop
            // 
            this.tenlop_Lop.Location = new System.Drawing.Point(64, 55);
            this.tenlop_Lop.Name = "tenlop_Lop";
            this.tenlop_Lop.Size = new System.Drawing.Size(136, 20);
            this.tenlop_Lop.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tenlop_Lop, "Tên Lớp");
            // 
            // siso_Lop
            // 
            this.siso_Lop.Location = new System.Drawing.Point(266, 54);
            this.siso_Lop.Name = "siso_Lop";
            this.siso_Lop.Size = new System.Drawing.Size(111, 20);
            this.siso_Lop.TabIndex = 3;
            this.toolTip1.SetToolTip(this.siso_Lop, "Sỉ số lớp sinh viên");
            // 
            // khoa_Lop
            // 
            this.khoa_Lop.FormattingEnabled = true;
            this.khoa_Lop.Location = new System.Drawing.Point(64, 22);
            this.khoa_Lop.Name = "khoa_Lop";
            this.khoa_Lop.Size = new System.Drawing.Size(136, 21);
            this.khoa_Lop.TabIndex = 0;
            this.toolTip1.SetToolTip(this.khoa_Lop, "Khoa");
            this.khoa_Lop.SelectedIndexChanged += new System.EventHandler(this.khoa_Lop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sỉ Số";
            this.toolTip1.SetToolTip(this.label4, "Sỉ Số");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Lớp";
            this.toolTip1.SetToolTip(this.label3, "Mã Lớp");
            // 
            // malop_Lop
            // 
            this.malop_Lop.Location = new System.Drawing.Point(266, 22);
            this.malop_Lop.Name = "malop_Lop";
            this.malop_Lop.Size = new System.Drawing.Size(111, 20);
            this.malop_Lop.TabIndex = 1;
            this.toolTip1.SetToolTip(this.malop_Lop, "Mã Lớp");
            // 
            // DGV_Lop
            // 
            this.DGV_Lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenlop_col,
            this.malop_col,
            this.lopkhoa_col,
            this.ss_col});
            this.DGV_Lop.Location = new System.Drawing.Point(12, 62);
            this.DGV_Lop.Name = "DGV_Lop";
            this.DGV_Lop.Size = new System.Drawing.Size(414, 237);
            this.DGV_Lop.TabIndex = 2;
            this.DGV_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tenlop_col
            // 
            this.tenlop_col.DataPropertyName = "TENLOP";
            this.tenlop_col.HeaderText = "Tên Lớp";
            this.tenlop_col.Name = "tenlop_col";
            // 
            // malop_col
            // 
            this.malop_col.DataPropertyName = "MALOP";
            this.malop_col.HeaderText = "Mã Lớp";
            this.malop_col.Name = "malop_col";
            // 
            // lopkhoa_col
            // 
            this.lopkhoa_col.DataPropertyName = "TENKHOA";
            this.lopkhoa_col.HeaderText = "Khoa";
            this.lopkhoa_col.Name = "lopkhoa_col";
            // 
            // ss_col
            // 
            this.ss_col.DataPropertyName = "SISO";
            this.ss_col.HeaderText = "Sỉ Số";
            this.ss_col.Name = "ss_col";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLDSV.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(282, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "   Sửa";
            this.toolTip1.SetToolTip(this.btnSua, "Cập Nhập");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLDSV.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(171, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "   Xóa";
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(441, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLDSV.Properties.Resources.Login_Huy_16px1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(282, 93);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QLDSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(171, 93);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 41);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "   Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLDSV.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(50, 93);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 41);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "   Lưu";
            this.toolTip1.SetToolTip(this.btnLuu, "Lưu");
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 43);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(342, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "QUẢN LÝ LỚP ";
            // 
            // frm_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGV_Lop);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_lop_FormClosing);
            this.Load += new System.EventHandler(this.frm_lop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siso_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox malop_Lop;
        private System.Windows.Forms.DataGridView DGV_Lop;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox khoa_Lop;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.NumericUpDown siso_Lop;
        private System.Windows.Forms.TextBox tenlop_Lop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopkhoa_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ss_col;
    }
}