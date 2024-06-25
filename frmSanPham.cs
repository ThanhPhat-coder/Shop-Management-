using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace LoginTest
{
    public partial class frmSanPham : Form
    {
        private object Functions;
        private System.Data.DataTable SanPham;

        public frmSanPham()
        {
            InitializeComponent();
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);

        }
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
        public static System.Data.DataTable GetDataToTable(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            System.Data.DataTable SanPham = new System.Data.DataTable();
            adapter.Fill(SanPham);
            return SanPham;
        }

        private void LoadDataGridView()
        {

            string sql = "SELECT * FROM SanPham";
            SanPham = GetDataToTable(sql); // Lấy dữ liệu từ cơ sở dữ liệu
            dgvSanPham.DataSource = SanPham;


            SanPham = GetDataToTable(sql); // thay đổi ở đây
            dgvSanPham.DataSource = SanPham;

            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Số lượng";
            dgvSanPham.Columns[3].HeaderText = "Đơn giá nhập";
            dgvSanPham.Columns[4].HeaderText = "Đơn giá bán";
            dgvSanPham.Columns[5].HeaderText = "Ngày nhập";
            dgvSanPham.Columns[6].HeaderText = "Ghi chú";
            dgvSanPham.Columns[7].HeaderText = "Ảnh";

            dgvSanPham.Columns[0].Width = 100;
            dgvSanPham.Columns[1].Width = 100;
            dgvSanPham.Columns[2].Width = 100;
            dgvSanPham.Columns[3].Width = 100;
            dgvSanPham.Columns[4].Width = 100;
            dgvSanPham.Columns[5].Width = 100;
            dgvSanPham.Columns[6].Width = 100;
            dgvSanPham.Columns[7].Width = 100;

            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;

        }




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;


        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string MaSanPham = txtMaSP.Text;
                string TenSanPham = txtTenSP.Text;

                string SoLuong = txtSoLuong.Text;

                string DonGiaNhap = txtDonGiaNhap.Text;
                string DonGiaBan = txtDonGiaBan.Text;
                string NgayNhap = txtNgayNhap.Text;
                string GhiChu = txtGhiChu.Text;
                string Anh = txtAnh.Text;


                // Kiểm tra tính hợp lệ của dữ liệu nhập vào
                if (string.IsNullOrEmpty(MaSanPham) || string.IsNullOrEmpty(TenSanPham) || string.IsNullOrEmpty(SoLuong) || string.IsNullOrEmpty(DonGiaNhap) || string.IsNullOrEmpty(DonGiaBan) || string.IsNullOrEmpty(NgayNhap) || string.IsNullOrEmpty(GhiChu) || string.IsNullOrEmpty(Anh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu chưa
                string checkMaSPQuery = "SELECT COUNT(*) FROM SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand checkMaSPCmd = new SqlCommand(checkMaSPQuery, conn);
                checkMaSPCmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);
                int MaSPCount = (int)checkMaSPCmd.ExecuteScalar();

                if (MaSPCount > 0)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Nếu mã hóa đơn chưa tồn tại, thêm tài khoản mới vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO SanPham (MaSanPham, TenSanPham, SoLuong, DonGiaNhap, DonGiaBan, NgayNhap, GhiChu, Anh) VALUES (@MaSanPham, @TenSanPham, @SoLuong, @DonGiaNhap, @DonGiaBan, @NgayNhap, @GhiChu, @Anh)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
                insertCmd.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text);
                insertCmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                insertCmd.Parameters.AddWithValue("@DonGiaNhap", txtDonGiaNhap.Text);
                insertCmd.Parameters.AddWithValue("@DonGiaBan", txtDonGiaBan.Text);
                insertCmd.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
                insertCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                insertCmd.Parameters.AddWithValue("@Anh", txtAnh.Text);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    

                    // Đóng form đăng ký và hiển thị lại form đăng nhập


                    // Sau khi lưu thành công, hiển thị lại toàn bộ dữ liệu trên DataGridView
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại! Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChu frmTC = new frmTrangChu();
            frmTC.Show();
        }
        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSanPham.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ DataGridView lên các control tương ứng
                txtMaSP.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = selectedRow.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = selectedRow.Cells["DonGiaBan"].Value.ToString();
                txtNgayNhap.Text = selectedRow.Cells["NgayNhap"].Value.ToString();
                txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value.ToString();
                txtAnh.Text = selectedRow.Cells["Anh"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa

            if (dgvSanPham.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dgvSanPham.SelectedRows[0];
                string MaSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();

                // Cập nhật thông tin từ các control
                selectedRow.Cells["TenSanPham"].Value = txtTenSP.Text;
                selectedRow.Cells["SoLuong"].Value = txtSoLuong.Text;
                selectedRow.Cells["DonGiaNhap"].Value = txtDonGiaNhap.Text;
                selectedRow.Cells["DonGiaBan"].Value = txtDonGiaBan.Text;
                selectedRow.Cells["NgayNhap"].Value = txtNgayNhap.Text;
                selectedRow.Cells["GhiChu"].Value = txtGhiChu.Text;
                selectedRow.Cells["Anh"].Value = txtAnh.Text;
                // Các thông tin khác tương tự

                // Sau khi người dùng chỉnh sửa và lưu lại, cập nhật dữ liệu vào DataGridView và cơ sở dữ liệu
                // Xử lý sự kiện lưu sau khi chỉnh sửa
                // Ví dụ:
                try
                {
                    // Mở kết nối tới SQL Server
                    conn.Open();

                    // Thực hiện câu lệnh SQL UPDATE để cập nhật dữ liệu trong SQL Server
                    string updateQuery = "UPDATE SanPham SET TenSanPham = @TenSanPham, SoLuong = @SoLuong, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, NgayNhap = @NgayNhap, GhiChu = @GhiChu, Anh = @Anh WHERE MaSanPham = @MaSanPham";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                    // Thêm các tham số vào câu lệnh SQL UPDATE
                    updateCmd.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
                    updateCmd.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text);
                    updateCmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    updateCmd.Parameters.AddWithValue("@DonGiaNhap", txtDonGiaNhap.Text);
                    updateCmd.Parameters.AddWithValue("@DonGiaBan", txtDonGiaBan.Text);
                    updateCmd.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
                    updateCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    updateCmd.Parameters.AddWithValue("@Anh", txtAnh.Text);
                    // Thêm các thông tin khác tương tự

                    // Thực thi câu lệnh UPDATE và lấy số dòng bị ảnh hưởng
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    // Đóng kết nối
                    conn.Close();

                    // Kiểm tra xem việc cập nhật đã thành công hay không
                    if (rowsAffected > 0)
                    {
                        

                        // Sau khi cập nhật thành công, cập nhật dữ liệu trên DataGridView
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đóng kết nối
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            txtMaSP.Enabled = false;
        }
        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";

            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtNgayNhap.Text = "";
            txtGhiChu.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvSanPham.Columns)
            {
                column.ReadOnly = false;
            }
            dgvSanPham.EditMode = DataGridViewEditMode.EditOnEnter;
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string MaSanPham = txtFind.Text.Trim();

                // Kiểm tra xem mã nhân viên có được nhập không
                if (string.IsNullOrEmpty(MaSanPham))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu truy vấn SQL để tìm kiếm nhân viên theo Mã nhân viên
                string sql = "SELECT * FROM SanPham WHERE MaSanPham LIKE @MaSanPham";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaSanPham", "%" + MaSanPham + "%");

                // Tạo một bảng dữ liệu mới để lưu trữ kết quả tìm kiếm
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);

                // Kiểm tra xem có dữ liệu trả về từ tìm kiếm không
                if (resultTable.Rows.Count > 0)
                {
                    dgvSanPham.DataSource = resultTable; // Hiển thị kết quả tìm kiếm trên DataGridView

                    // Hiển thị thông tin của nhân viên đầu tiên trong kết quả tìm kiếm trên các trường thông tin tương ứng
                    DataRow row = resultTable.Rows[0];
                    txtMaSP.Text = row["MaSanPham"].ToString();
                    txtTenSP.Text = row["TenSanPham"].ToString();
                    txtSoLuong.Text = row["SoLuong"].ToString();
                    txtDonGiaNhap.Text = row["DonGiaNhap"].ToString();
                    txtDonGiaBan.Text = row["DonGiaBan"].ToString();
                    txtNgayNhap.Text = row["NgayNhap"].ToString();
                    txtGhiChu.Text = row["GhiChu"].ToString();
                    txtAnh.Text = row["Anh"].ToString();
                    string imagePath = row["Anh"].ToString();

                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        picAnh.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // Nếu không tìm thấy ảnh, đặt ảnh mặc định hoặc làm gì đó phù hợp với ứng dụng của bạn
                        picAnh.Image = null; // Đặt ảnh mặc định là null
                                             // Hoặc hiển thị thông báo cho người dùng
                       
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã sản phẩm '" + MaSanPham + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                // Lấy mã sản phẩm từ dòng được chọn
                string MaSanPham = dgvSanPham.SelectedRows[0].Cells["MaSanPham"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm có mã: " + MaSanPham + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Mở kết nối tới SQL Server
                        conn.Open();

                        // Xóa dòng tương ứng trong SQL Server
                        string deleteQuery = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        // Đóng kết nối
                        conn.Close();

                        // Kiểm tra xem dòng đã được xóa thành công từ SQL Server hay không
                        if (rowsAffected > 0)
                        {
                            // Xóa dòng khỏi DataGridView nếu việc xóa từ SQL Server thành công
                            dgvSanPham.Rows.RemoveAt(dgvSanPham.SelectedRows[0].Index);

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu mã sản phẩm " + MaSanPham + " để xóa trong SQL Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                   
                }
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSanPham.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ DataGridView lên các control tương ứng
                txtMaSP.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = selectedRow.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = selectedRow.Cells["DonGiaBan"].Value.ToString();
                txtNgayNhap.Text = selectedRow.Cells["NgayNhap"].Value.ToString();
                txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value.ToString();
                txtAnh.Text = selectedRow.Cells["Anh"].Value.ToString();

                // Hiển thị hình ảnh nếu có
                string imagePath = selectedRow.Cells["Anh"].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    picAnh.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Xử lý trường hợp không có ảnh
                    picAnh.Image = null;
                    
                }
            }
            btnXoa.Enabled = true;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
           
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            ResetValues();
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
        }

        private void picAnh_Click(object sender, EventArgs e)
        {

        }

        private void txtAnh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
