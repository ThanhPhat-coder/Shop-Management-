using System;
using System.Windows.Forms;

namespace LoginTest
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblDanhMucNhanVien = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnMo = new System.Windows.Forms.Button();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlCongCu = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pnlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlCongCu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(353, 175);
            this.chkNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(46, 20);
            this.chkNu.TabIndex = 12;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(290, 175);
            this.chkNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(58, 20);
            this.chkNam.TabIndex = 11;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(713, 82);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(253, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(606, 175);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 20);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(606, 129);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(84, 20);
            this.lblSoDienThoai.TabIndex = 6;
            this.lblSoDienThoai.Text = "Điện thoại";
            this.lblSoDienThoai.Click += new System.EventHandler(this.lblSoDienThoai_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(607, 80);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.Click += new System.EventHandler(this.lblDiaChi_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(213, 175);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(353, 129);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(220, 22);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(353, 82);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(220, 22);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(213, 131);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(119, 20);
            this.lblTenNhanVien.TabIndex = 2;
            this.lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(213, 80);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(114, 20);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // lblDanhMucNhanVien
            // 
            this.lblDanhMucNhanVien.AutoSize = true;
            this.lblDanhMucNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhMucNhanVien.Location = new System.Drawing.Point(363, 21);
            this.lblDanhMucNhanVien.Name = "lblDanhMucNhanVien";
            this.lblDanhMucNhanVien.Size = new System.Drawing.Size(321, 38);
            this.lblDanhMucNhanVien.TabIndex = 0;
            this.lblDanhMucNhanVien.Text = "Thông tin nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 264);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(978, 216);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // btnDong
            // 
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(845, 15);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 28);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlNhanVien.Controls.Add(this.lblAnh);
            this.pnlNhanVien.Controls.Add(this.txtAnh);
            this.pnlNhanVien.Controls.Add(this.btnMo);
            this.pnlNhanVien.Controls.Add(this.mskNgaySinh);
            this.pnlNhanVien.Controls.Add(this.mtbDienThoai);
            this.pnlNhanVien.Controls.Add(this.picAvatar);
            this.pnlNhanVien.Controls.Add(this.chkNu);
            this.pnlNhanVien.Controls.Add(this.chkNam);
            this.pnlNhanVien.Controls.Add(this.txtDiaChi);
            this.pnlNhanVien.Controls.Add(this.lblNgaySinh);
            this.pnlNhanVien.Controls.Add(this.lblSoDienThoai);
            this.pnlNhanVien.Controls.Add(this.lblDiaChi);
            this.pnlNhanVien.Controls.Add(this.lblGioiTinh);
            this.pnlNhanVien.Controls.Add(this.txtTenNhanVien);
            this.pnlNhanVien.Controls.Add(this.txtMaNhanVien);
            this.pnlNhanVien.Controls.Add(this.lblTenNhanVien);
            this.pnlNhanVien.Controls.Add(this.lblMaNhanVien);
            this.pnlNhanVien.Controls.Add(this.lblDanhMucNhanVien);
            this.pnlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.pnlNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(978, 264);
            this.pnlNhanVien.TabIndex = 3;
            this.pnlNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNhanVien_Paint);
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnh.Location = new System.Drawing.Point(606, 218);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(38, 20);
            this.lblAnh.TabIndex = 18;
            this.lblAnh.Text = "Ảnh";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(713, 218);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(253, 22);
            this.txtAnh.TabIndex = 17;
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(79, 218);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(75, 32);
            this.btnMo.TabIndex = 16;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(713, 173);
            this.mskNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(253, 22);
            this.mskNgaySinh.TabIndex = 15;
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(713, 127);
            this.mtbDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(253, 22);
            this.mtbDienThoai.TabIndex = 14;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(33, 21);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(162, 176);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 13;
            this.picAvatar.TabStop = false;
            // 
            // pnlCongCu
            // 
            this.pnlCongCu.Controls.Add(this.txtFind);
            this.pnlCongCu.Controls.Add(this.btnBoQua);
            this.pnlCongCu.Controls.Add(this.btnTimKiem);
            this.pnlCongCu.Controls.Add(this.btnDong);
            this.pnlCongCu.Controls.Add(this.btnLuu);
            this.pnlCongCu.Controls.Add(this.btnSua);
            this.pnlCongCu.Controls.Add(this.btnXoa);
            this.pnlCongCu.Controls.Add(this.btnThem);
            this.pnlCongCu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCongCu.Location = new System.Drawing.Point(0, 480);
            this.pnlCongCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCongCu.Name = "pnlCongCu";
            this.pnlCongCu.Size = new System.Drawing.Size(978, 53);
            this.pnlCongCu.TabIndex = 5;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(344, 20);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(154, 22);
            this.txtFind.TabIndex = 50;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::LoginTest.Properties.Resources.reload;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBoQua.Location = new System.Drawing.Point(611, 15);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(93, 30);
            this.btnBoQua.TabIndex = 49;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::LoginTest.Properties.Resources.b_find_replace;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(504, 16);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 28);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tim kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::LoginTest.Properties.Resources.save_as1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(731, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 28);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::LoginTest.Properties.Resources.fix1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(134, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 28);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::LoginTest.Properties.Resources.xed21;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(237, 14);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 28);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::LoginTest.Properties.Resources.plus2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(11, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 533);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlNhanVien);
            this.Controls.Add(this.pnlCongCu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pnlNhanVien.ResumeLayout(false);
            this.pnlNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlCongCu.ResumeLayout(false);
            this.pnlCongCu.PerformLayout();
            this.ResumeLayout(false);

        }

   

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được nhấp là cột MaNhanVien và không phải là hàng header
            if (e.ColumnIndex == dgvNhanVien.Columns["MaNhanVien"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dgvNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex];
                MessageBox.Show("Giá trị của ô được nhấp là: " + cell.Value.ToString());
            }
        }


        private void lblDiaChi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblSoDienThoai_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblDanhMucNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlNhanVien;
        private System.Windows.Forms.Panel pnlCongCu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private Button btnBoQua;
        private TextBox txtFind;
        private Button btnMo;
        private TextBox txtAnh;
        private Label lblAnh;
    }
}