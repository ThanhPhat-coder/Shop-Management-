using System.Windows.Forms;

namespace LoginTest
{
    partial class frmSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblDanhMucSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.picAnh);
            this.panel1.Controls.Add(this.txtAnh);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.txtNgayNhap);
            this.panel1.Controls.Add(this.txtDonGiaBan);
            this.panel1.Controls.Add(this.txtDonGiaNhap);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.lblAnh);
            this.panel1.Controls.Add(this.lblGhiChu);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.lblDonGiaNhap);
            this.panel1.Controls.Add(this.lblDonGiaBan);
            this.panel1.Controls.Add(this.lblNgayNhap);
            this.panel1.Controls.Add(this.lblTenSanPham);
            this.panel1.Controls.Add(this.lblMaSanPham);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Location = new System.Drawing.Point(-2, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 322);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(937, 2);
            this.picAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(240, 320);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 18;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(569, 178);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(240, 72);
            this.txtAnh.TabIndex = 17;
            this.txtAnh.TextChanged += new System.EventHandler(this.txtAnh_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(569, 36);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(240, 112);
            this.txtGhiChu.TabIndex = 16;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(217, 281);
            this.txtNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(191, 26);
            this.txtNgayNhap.TabIndex = 15;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(217, 236);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(191, 26);
            this.txtDonGiaBan.TabIndex = 14;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(217, 191);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(191, 26);
            this.txtDonGiaNhap.TabIndex = 13;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(217, 136);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(191, 26);
            this.txtSoLuong.TabIndex = 12;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(217, 84);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(191, 26);
            this.txtTenSP.TabIndex = 11;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(217, 32);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(191, 26);
            this.txtMaSP.TabIndex = 10;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnh.Location = new System.Drawing.Point(483, 178);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(44, 23);
            this.lblAnh.TabIndex = 9;
            this.lblAnh.Text = "Ảnh";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(483, 36);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(76, 23);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(60, 138);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(85, 23);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaNhap.Location = new System.Drawing.Point(60, 191);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(120, 23);
            this.lblDonGiaNhap.TabIndex = 6;
            this.lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaBan.Location = new System.Drawing.Point(60, 240);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(110, 23);
            this.lblDonGiaBan.TabIndex = 5;
            this.lblDonGiaBan.Text = "Đơn giá bán";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(60, 285);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(97, 23);
            this.lblNgayNhap.TabIndex = 4;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(60, 84);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(123, 23);
            this.lblTenSanPham.TabIndex = 3;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanPham.Location = new System.Drawing.Point(60, 32);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(119, 23);
            this.lblMaSanPham.TabIndex = 2;
            this.lblMaSanPham.Text = "Mã sản phẩm";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(647, 281);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblDanhMucSP
            // 
            this.lblDanhMucSP.AutoSize = true;
            this.lblDanhMucSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDanhMucSP.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucSP.Location = new System.Drawing.Point(530, 11);
            this.lblDanhMucSP.Name = "lblDanhMucSP";
            this.lblDanhMucSP.Size = new System.Drawing.Size(283, 37);
            this.lblDanhMucSP.TabIndex = 1;
            this.lblDanhMucSP.Text = "Danh mục sản phẩm";
            this.lblDanhMucSP.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnHienThi);
            this.panel2.Controls.Add(this.btnBoQua);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Location = new System.Drawing.Point(-2, 624);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 104);
            this.panel2.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::LoginTest.Properties.Resources.plus2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(884, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 50);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(16, 11);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(191, 26);
            this.txtFind.TabIndex = 19;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::LoginTest.Properties.Resources.b_home;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1153, 36);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 50);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::LoginTest.Properties.Resources.save_as;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1020, 36);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 50);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Image = global::LoginTest.Properties.Resources.ds2;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(249, 34);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(179, 50);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "&Hiển thị DS";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(449, 34);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(114, 50);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "&Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::LoginTest.Properties.Resources.b_find_replace;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFind.Location = new System.Drawing.Point(16, 46);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(123, 38);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "&Tìm kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::LoginTest.Properties.Resources.fix;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(746, 34);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::LoginTest.Properties.Resources.xed2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(611, 36);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(-2, 390);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1282, 238);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDanhMucSP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSanPham";
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.Label lblDanhMucSP;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtFind;
        private Button btnThem;
    }
    
}