namespace LoginTest
{
    partial class frmKhachHang
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
            this.gpChucNang = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.gpDSKH = new System.Windows.Forms.GroupBox();
            this.dvgKhachHang = new System.Windows.Forms.DataGridView();
            this.lblDanhMucKhachHang = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gpLyLich = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.gpChucNang.SuspendLayout();
            this.gpDSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKhachHang)).BeginInit();
            this.gpLyLich.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpChucNang
            // 
            this.gpChucNang.Controls.Add(this.btnFind);
            this.gpChucNang.Controls.Add(this.btnBoQua);
            this.gpChucNang.Controls.Add(this.btnSave);
            this.gpChucNang.Controls.Add(this.btnDelete);
            this.gpChucNang.Controls.Add(this.btnUpdate);
            this.gpChucNang.Controls.Add(this.btnAdd);
            this.gpChucNang.Controls.Add(this.label4);
            this.gpChucNang.Controls.Add(this.txtFind);
            this.gpChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpChucNang.Location = new System.Drawing.Point(30, 405);
            this.gpChucNang.Name = "gpChucNang";
            this.gpChucNang.Size = new System.Drawing.Size(1119, 77);
            this.gpChucNang.TabIndex = 21;
            this.gpChucNang.TabStop = false;
            this.gpChucNang.Text = "Chức năng";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(968, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(116, 39);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(594, 25);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(116, 39);
            this.btnBoQua.TabIndex = 12;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(454, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(737, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập Mã khách hàng";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(741, 38);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(210, 26);
            this.txtFind.TabIndex = 5;
            // 
            // gpDSKH
            // 
            this.gpDSKH.Controls.Add(this.dvgKhachHang);
            this.gpDSKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDSKH.Location = new System.Drawing.Point(428, 71);
            this.gpDSKH.Name = "gpDSKH";
            this.gpDSKH.Size = new System.Drawing.Size(721, 328);
            this.gpDSKH.TabIndex = 19;
            this.gpDSKH.TabStop = false;
            this.gpDSKH.Text = "Danh sách khách hàng";
            // 
            // dvgKhachHang
            // 
            this.dvgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgKhachHang.Location = new System.Drawing.Point(6, 25);
            this.dvgKhachHang.Name = "dvgKhachHang";
            this.dvgKhachHang.RowHeadersWidth = 51;
            this.dvgKhachHang.RowTemplate.Height = 24;
            this.dvgKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgKhachHang.Size = new System.Drawing.Size(708, 296);
            this.dvgKhachHang.TabIndex = 0;
            this.dvgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgKhachHang_CellClick);
            // 
            // lblDanhMucKhachHang
            // 
            this.lblDanhMucKhachHang.AutoSize = true;
            this.lblDanhMucKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhMucKhachHang.Location = new System.Drawing.Point(12, 16);
            this.lblDanhMucKhachHang.Name = "lblDanhMucKhachHang";
            this.lblDanhMucKhachHang.Size = new System.Drawing.Size(350, 38);
            this.lblDanhMucKhachHang.TabIndex = 17;
            this.lblDanhMucKhachHang.Text = "Thông tin khách hàng";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(14, 485);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 29);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Tình trạng";
            // 
            // gpLyLich
            // 
            this.gpLyLich.Controls.Add(this.txtSoDienThoai);
            this.gpLyLich.Controls.Add(this.label3);
            this.gpLyLich.Controls.Add(this.txtDiaChi);
            this.gpLyLich.Controls.Add(this.label2);
            this.gpLyLich.Controls.Add(this.txtTenKH);
            this.gpLyLich.Controls.Add(this.label1);
            this.gpLyLich.Controls.Add(this.txtMaKhachHang);
            this.gpLyLich.Controls.Add(this.lblMaKhachHang);
            this.gpLyLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLyLich.Location = new System.Drawing.Point(19, 71);
            this.gpLyLich.Name = "gpLyLich";
            this.gpLyLich.Size = new System.Drawing.Size(390, 328);
            this.gpLyLich.TabIndex = 18;
            this.gpLyLich.TabStop = false;
            this.gpLyLich.Text = "Lý lịch";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(174, 254);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(210, 26);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(174, 185);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(174, 117);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(210, 26);
            this.txtTenKH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(174, 47);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(210, 26);
            this.txtMaKhachHang.TabIndex = 3;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(6, 47);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(129, 20);
            this.lblMaKhachHang.TabIndex = 2;
            this.lblMaKhachHang.Text = "Mã Khách Hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 530);
            this.Controls.Add(this.gpChucNang);
            this.Controls.Add(this.gpDSKH);
            this.Controls.Add(this.lblDanhMucKhachHang);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gpLyLich);
            this.Name = "frmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.gpChucNang.ResumeLayout(false);
            this.gpChucNang.PerformLayout();
            this.gpDSKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgKhachHang)).EndInit();
            this.gpLyLich.ResumeLayout(false);
            this.gpLyLich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpChucNang;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.GroupBox gpDSKH;
        private System.Windows.Forms.DataGridView dvgKhachHang;
        private System.Windows.Forms.Label lblDanhMucKhachHang;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gpLyLich;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
    }
}