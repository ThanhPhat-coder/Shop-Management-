namespace LoginTest
{
    partial class frmChiTietHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHD));
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new LoginTest.QuanLyBanHangDataSet();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.chiTietHoaDonTableAdapter = new LoginTest.QuanLyBanHangDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToOrderColumns = true;
            this.dgvChiTietHoaDon.AutoGenerateColumns = false;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dgvChiTietHoaDon.DataSource = this.chiTietHoaDonBindingSource;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(88, 123);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(865, 320);
            this.dgvChiTietHoaDon.TabIndex = 3;
            this.dgvChiTietHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellContentClick_1);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            this.tenSanPhamDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 150;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFind.Image = global::LoginTest.Properties.Resources.b_find_replace;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFind.Location = new System.Drawing.Point(88, 62);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 22);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "&Tìm kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.LightBlue;
            this.txtFind.Location = new System.Drawing.Point(203, 62);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(751, 22);
            this.txtFind.TabIndex = 20;
            this.txtFind.Text = "Nhập mã hóa đơn ";
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 31);
            this.label5.TabIndex = 61;
            this.label5.Text = "Bảng Thông tin chi tiết hóa đơn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(85, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Danh sách chi tiết hóa đơn bạn cần tìm";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(88, 466);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 28);
            this.btnDong.TabIndex = 63;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1314, 502);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChiTietHD";
            this.Text = "ChiTietHD";
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private QuanLyBanHangDataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}