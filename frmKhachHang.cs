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
    public partial class frmKhachHang : Form
    {
        private SqlConnection conn = new SqlConnection("Server=(local); DataBase=QuanLyBanHang; Integrated Security=True; Encrypt=False");
        private DataTable KhachHang;
        public frmKhachHang()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(frmKhachHang_FormClosing);
        }

        private DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM KhachHang";
            KhachHang = GetDataToTable(sql);
            dvgKhachHang.DataSource = KhachHang;

            dvgKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dvgKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dvgKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dvgKhachHang.Columns[3].HeaderText = "Số điện thoại";


            dvgKhachHang.Columns[0].Width = 100;
            dvgKhachHang.Columns[1].Width = 150;
            dvgKhachHang.Columns[2].Width = 150;
            dvgKhachHang.Columns[3].Width = 150;
            dvgKhachHang.AllowUserToAddRows = false;
            dvgKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Khách Hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Khách Hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }
            return true;
        }

        private void ResetValues()
        {
            txtMaKhachHang.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnBoQua.Enabled = true;
            btnUpdate.Enabled = false;
            ResetValues();
            txtMaKhachHang.Enabled = true;
            txtMaKhachHang.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dòng nào được chọn trong DataGridView
            if (dvgKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu nhập vào
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                conn.Open();

                // Lấy mã khách hàng từ dòng được chọn trong DataGridView
                string maKhachHang = dvgKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();

                // Cập nhật dữ liệu trong CSDL
                string sql = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaKhachHang = @MaKhachHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", txtTenKH.Text.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text.Trim());

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblStatus.BackColor = Color.Green; // Đặt màu nền cho lblStatus
                    lblStatus.ForeColor = Color.White; // Đặt màu chữ cho lblStatus
                    lblStatus.Text = "Cập nhật thông tin khách hàng thành công.";
                    lblStatus.Visible = true; // Hiển thị lblStatus
                    ResetValues();
                    LoadDataGridView(); // Load lại dữ liệu trong DataGridView
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                    txtMaKhachHang.Enabled = false;
                }
                else
                {
                    lblStatus.Text = "Cập nhật thông tin khách hàng không thành công.";
                    lblStatus.Visible = true; // Hiển thị lblStatus
                }
            }
            catch (Exception ex)
            {
                lblStatus.BackColor = Color.Red; // Đặt màu nền cho lblStatus
                lblStatus.ForeColor = Color.White; // Đặt màu chữ cho lblStatus
                lblStatus.Text = "Lỗi: " + ex.Message;
                lblStatus.Visible = true; // Hiển thị lblStatus
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dòng nào được chọn trong DataGridView
            if (dvgKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    // Lấy mã khách hàng từ dòng được chọn trong DataGridView
                    string maKhachHang = dvgKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();

                    // Xóa dữ liệu trong CSDL
                    string sql = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblStatus.BackColor = Color.Green; // Đặt màu nền cho lblStatus
                        lblStatus.ForeColor = Color.White; // Đặt màu chữ cho lblStatus
                        lblStatus.Text = "Xóa khách hàng thành công.";
                        lblStatus.Visible = true; // Hiển thị lblStatus
                        ResetValues();
                        LoadDataGridView(); // Load lại dữ liệu trong DataGridView
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        lblStatus.Text = "Không thể xóa khách hàng này.";
                        lblStatus.Visible = true; // Hiển thị lblStatus
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.BackColor = Color.Red; // Đặt màu nền cho lblStatus
                    lblStatus.ForeColor = Color.White; // Đặt màu chữ cho lblStatus
                    lblStatus.Text = "Lỗi: " + ex.Message;
                    lblStatus.Visible = true; // Hiển thị lblStatus
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            try
            {
                conn.Open();
                string sql = "SELECT MaKhachHang FROM KhachHang WHERE MaKhachHang=@MaKhachHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Mã khách hàng này đã tồn tại, vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKhachHang.Focus();
                    txtMaKhachHang.Text = "";
                    reader.Close();
                    return;
                }
                reader.Close();

                // Thêm dữ liệu vào CSDL
                sql = "INSERT INTO KhachHang(MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) VALUES(@MaKhachHang, @TenKhachHang, @DiaChi, @SoDienThoai)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhachHang", txtTenKH.Text.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text.Trim());
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblStatus.BackColor = Color.Green; // Đặt màu nền cho lblStatus
                    lblStatus.ForeColor = Color.White; // Đặt màu chữ cho lblStatus
                    lblStatus.Text = "Thêm mới khách hàng thành công.";
                    lblStatus.Visible = true; // Hiển thị lblStatus
                    ResetValues();
                    LoadDataGridView(); // Load lại dữ liệu trong DataGridView
                    btnDelete.Enabled = true;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                    txtMaKhachHang.Enabled = false;
                }
                else
                {
                    lblStatus.Text = "Thêm mới khách hàng không thành công.";
                    lblStatus.Visible = true; // Hiển thị lblStatus
                }
            }
            catch (Exception ex)
            {
                lblStatus.BackColor = Color.Red; // Đặt màu nền cho lblStatus
                lblStatus.ForeColor = Color.White; // Đặt màu chữ cho lblStatus
                lblStatus.Text = "Lỗi: " + ex.Message;
                lblStatus.Visible = true; // Hiển thị lblStatus
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaKhachHang.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            lblStatus.Visible = false; // Ẩn lblStatus khi không cần thông báo
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFind.Focus();
                return;
            }

            try
            {
                conn.Open();
                string sql = "SELECT * FROM KhachHang WHERE MaKhachHang LIKE @MaKhachHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", "%" + txtFind.Text.Trim() + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable searchResult = new DataTable();
                searchResult.Load(reader);

                if (searchResult.Rows.Count > 0)
                {
                    // Hiển thị kết quả tìm kiếm trên DataGridView
                    dvgKhachHang.DataSource = searchResult;

                    // Hiển thị kết quả tìm kiếm đầu tiên trên các TextBox
                    DataRow firstRow = searchResult.Rows[0];
                    txtMaKhachHang.Text = firstRow["MaKhachHang"].ToString();
                    txtTenKH.Text = firstRow["TenKhachHang"].ToString();
                    txtDiaChi.Text = firstRow["DiaChi"].ToString();
                    txtSoDienThoai.Text = firstRow["SoDienThoai"].ToString();

                    lblStatus.BackColor = Color.Green;
                    lblStatus.ForeColor = Color.White;
                    lblStatus.Text = "Tìm thấy khách hàng.";
                    lblStatus.Visible = true;
                }
                else
                {
                    // Không tìm thấy khách hàng
                    MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.BackColor = Color.Red;
                    lblStatus.ForeColor = Color.White;
                    lblStatus.Text = "Không tìm thấy khách hàng.";
                    lblStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;
                lblStatus.Text = "Lỗi: " + ex.Message;
                lblStatus.Visible = true;
            }
            finally
            {
                conn.Close();
            }
        }

        private void dvgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dvgKhachHang.Rows[e.RowIndex];

                // Hiển thị thông tin của dòng được chọn trong các control tương ứng
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();


            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtMaKhachHang.Enabled = false;
            lblStatus.Visible = false;
            dvgKhachHang.CellClick += new DataGridViewCellEventHandler(dvgKhachHang_CellClick);
        }

        // Các thuộc tính để lấy thông tin khách hàng từ form
        public string MaKhachHang
        {
            get { return txtMaKhachHang.Text.Trim(); }
        }

        public string TenKhachHang
        {
            get { return txtTenKH.Text.Trim(); }
        }

        public string SoDienThoai
        {
            get { return txtSoDienThoai.Text.Trim(); }
        }

        public string DiaChi
        {
            get { return txtDiaChi.Text.Trim(); }
        }
        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đảm bảo rằng form đóng lại với DialogResult.OK nếu thông tin đã được điền
            if (this.DialogResult == DialogResult.OK)
            {
                if (!ValidateInput())
                {
                    e.Cancel = true; // Hủy đóng form nếu thông tin không hợp lệ
                }
            }
        }
    }
}
