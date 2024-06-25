using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class frmQLHD : Form
    {
        private object Functions;
        private System.Data.DataTable HoaDon;
        public frmQLHD()
        {
            InitializeComponent();
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);

        }
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");

        public static System.Data.DataTable GetDataToTable(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            System.Data.DataTable HoaDon = new System.Data.DataTable();
            adapter.Fill(HoaDon);
            return HoaDon;
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM HoaDon";
            HoaDon = GetDataToTable(sql); // Lấy dữ liệu từ cơ sở dữ liệu
            dgvHoaDon.DataSource = HoaDon;

            // Thêm cột STT
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();

            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Gắn sự kiện RowPostPaint để tự động thêm số thứ tự vào cột STT
            dgvHoaDon.RowPostPaint += dgvHoaDon_RowPostPaint;
        }

        private void dgvHoaDon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Vẽ số thứ tự vào cột STT
            using (SolidBrush b = new SolidBrush(dgvHoaDon.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Đảm bảo pnlMain tự động điều chỉnh kích thước của nó để chứa toàn bộ nội dung bên trong
            pnlMain.AutoSize = true;
            // Đảm bảo pnlMain lấp đầy không gian của form cha
            pnlMain.Dock = DockStyle.Fill;
        }
        private void frmQLHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet1.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.quanLyBanHangDataSet1.HoaDon);

        }

        private void pnlHD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNHD());
        }

        private void mnuXemCTHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietHD());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvHoaDon.Columns)
            {
                column.ReadOnly = false;
            }
            dgvHoaDon.EditMode = DataGridViewEditMode.EditOnEnter;
            try
            {

                // Gọi phương thức LoadDataGridView để tải toàn bộ dữ liệu từ SQL Server lên DataGridView
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHoaDon.Rows[e.RowIndex];
            }
        }
        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHoaDon.Rows[e.RowIndex];
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHoaDon = txtFind.Text.Trim();

                // Kiểm tra xem mã nhân viên có được nhập không
                if (string.IsNullOrEmpty(MaHoaDon))
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu truy vấn SQL để tìm kiếm nhân viên theo Mã nhân viên
                string sql = "SELECT * FROM HoaDon WHERE MaHoaDon LIKE @MaHoaDon";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaHoaDon", "%" + MaHoaDon + "%");

                // Tạo một bảng dữ liệu mới để lưu trữ kết quả tìm kiếm
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);

                // Kiểm tra xem có dữ liệu trả về từ tìm kiếm không
                if (resultTable.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = resultTable; // Hiển thị kết quả tìm kiếm trên DataGridView        
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn phù hợp '" + MaHoaDon + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng xong
                conn.Close();
            }
        }
    }
}
