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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace LoginTest
{
    public partial class frmChiTietHD : Form
    {
        private object Functions;
        private System.Data.DataTable ChiTietHoaDon;
        public frmChiTietHD()
        {
            InitializeComponent();
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellContentClick);


        }
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
        public static System.Data.DataTable GetDataToTable(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            System.Data.DataTable ChiTietHoaDon = new System.Data.DataTable();
            adapter.Fill(ChiTietHoaDon);
            return ChiTietHoaDon;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM ChiTietHoaDon";
            ChiTietHoaDon = GetDataToTable(sql); // Lấy dữ liệu từ cơ sở dữ liệu
            dgvChiTietHoaDon.DataSource = ChiTietHoaDon;

            // Thêm cột STT
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();

            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dgvChiTietHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvChiTietHoaDon.Rows[e.RowIndex];
            }
        }
        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvChiTietHoaDon.Rows[e.RowIndex];

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
                string sql = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon LIKE @MaHoaDon";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaHoaDon", "%" + MaHoaDon + "%");

                // Tạo một bảng dữ liệu mới để lưu trữ kết quả tìm kiếm
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                // Kiểm tra xem có dữ liệu trả về từ tìm kiếm không
                if (resultTable.Rows.Count > 0)
                {
                    dgvChiTietHoaDon.DataSource = resultTable; // Hiển thị kết quả tìm kiếm trên DataGridView    
                }
                else
                {
                    MessageBox.Show("Hóa đơn bạn tìm không tồn tại!'" + MaHoaDon + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvChiTietHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvChiTietHoaDon.Columns)
            {
                column.ReadOnly = false;
            }
            dgvChiTietHoaDon.EditMode = DataGridViewEditMode.EditOnEnter;
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

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.quanLyBanHangDataSet.ChiTietHoaDon);

        }
    }
}
