namespace LoginTest
{
    partial class frmQLHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHD));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuNhapHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemCTHD = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet1 = new LoginTest.QuanLyBanHangDataSet1();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.hoaDonTableAdapter = new LoginTest.QuanLyBanHangDataSet1TableAdapters.HoaDonTableAdapter();
            this.menuStrip2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapHD,
            this.mnuXemCTHD});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(178, 644);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuNhapHD
            // 
            this.mnuNhapHD.AutoSize = false;
            this.mnuNhapHD.Image = global::LoginTest.Properties.Resources.b_print;
            this.mnuNhapHD.Name = "mnuNhapHD";
            this.mnuNhapHD.Size = new System.Drawing.Size(172, 75);
            this.mnuNhapHD.Text = "&Nhập hóa đơn";
            this.mnuNhapHD.Click += new System.EventHandler(this.mnuIn_Click);
            // 
            // mnuXemCTHD
            // 
            this.mnuXemCTHD.Image = global::LoginTest.Properties.Resources.eye;
            this.mnuXemCTHD.Name = "mnuXemCTHD";
            this.mnuXemCTHD.Size = new System.Drawing.Size(165, 29);
            this.mnuXemCTHD.Text = "Xem Chi Tiết";
            this.mnuXemCTHD.Click += new System.EventHandler(this.mnuXemCTHD_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvHoaDon);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(178, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1100, 644);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHD_Paint);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToOrderColumns = true;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maNhanVienDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.maKhachHangDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.hoaDonBindingSource;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1100, 644);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 150;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            this.ngayBanDataGridViewTextBoxColumn.Width = 150;
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyBanHangDataSet1;
            // 
            // quanLyBanHangDataSet1
            // 
            this.quanLyBanHangDataSet1.DataSetName = "QuanLyBanHangDataSet1";
            this.quanLyBanHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(0, 530);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(178, 47);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFind.Image = global::LoginTest.Properties.Resources.b_find_replace;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(0, 390);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(178, 49);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "&Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(0, 346);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(178, 26);
            this.txtFind.TabIndex = 20;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLHD";
            this.Text = "frmQLHD";
            this.Load += new System.EventHandler(this.frmQLHD_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHD;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuXemCTHD;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private QuanLyBanHangDataSet1 quanLyBanHangDataSet1;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyBanHangDataSet1TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}