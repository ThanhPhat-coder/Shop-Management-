using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class frmNhanVien : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
        private DataTable NhanVien;
        private string gt;

        public frmNhanVien()
        {
            InitializeComponent();
            chkNam.Click += new EventHandler(chkNam_Click);
            chkNu.Click += new EventHandler(chkNu_Click);
           
        }

        private void chkNam_Click(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                chkNu.Checked = false;
                gt = "Nam";
            }
        }

        private void chkNu_Click(object sender, EventArgs e)
        {
            if (chkNu.Checked)
            {
                chkNam.Checked = false;
                gt = "Nữ";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmTrangChu frmTC = new frmTrangChu();
            //frmTC.Show();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
            dgvNhanVien.CellClick += new DataGridViewCellEventHandler(dgvNhanVien_CellClick);

        }

        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
            txtDiaChi.Text = "";
            mskNgaySinh.Text = "";
            mtbDienThoai.Text = "";
            picAvatar.Image = null;
            txtAnh.Text = "";
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM NhanVien";
            NhanVien = GetDataToTable(sql);
            dgvNhanVien.DataSource = NhanVien;

            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[6].HeaderText = "Email";
            dgvNhanVien.Columns[7].HeaderText = "Mật Khẩu";
            dgvNhanVien.Columns[8].HeaderText = "Hình Ảnh";

            dgvNhanVien.Columns[0].Width = 100;
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[2].Width = 100;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 100;
            dgvNhanVien.Columns[5].Width = 100;
            dgvNhanVien.Columns[6].Width = 100;
            dgvNhanVien.Columns[7].Width = 100;
            dgvNhanVien.Columns[8].Width = 100;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                chkNam.Checked = gioiTinh == "Nam";
                chkNu.Checked = gioiTinh == "Nữ";
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                mtbDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                // Kiểm tra và xử lý giá trị ngày sinh
                object ngaySinhValue = row.Cells["NgaySinh"].Value;
                if (ngaySinhValue != DBNull.Value && ngaySinhValue != null)
                {
                    if (DateTime.TryParse(ngaySinhValue.ToString(), out DateTime ngaySinh))
                    {
                        mskNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show("Giá trị ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskNgaySinh.Text = string.Empty;
                    }
                }
                else
                {
                    mskNgaySinh.Text = string.Empty;
                }
                // Lấy đường dẫn ảnh từ cột "HinhAnh"
                string imagePath = row.Cells["HinhAnh"].Value.ToString();

                // Hiển thị ảnh lên pictureBox
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        picAvatar.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Nếu đường dẫn ảnh rỗng, đặt pictureBox thành null
                    picAvatar.Image = null;
                }


                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                conn.Open();
                string sql = "SELECT MaNhanVien FROM NhanVien WHERE MaNhanVien=@MaNhanVien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    txtMaNhanVien.Text = "";
                    reader.Close();
                    return;
                }
                reader.Close();

                // Thêm đường dẫn hình ảnh vào cơ sở dữ liệu
                sql = "INSERT INTO NhanVien(MaNhanVien, TenNhanVien, GioiTinh, DiaChi, SoDienThoai, NgaySinh, HinhAnh) VALUES (@MaNhanVien, @TenNhanVien, @GioiTinh, @DiaChi, @SoDienThoai, @NgaySinh, @HinhAnh)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text.Trim());
                cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@SoDienThoai", mtbDienThoai.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.ParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@HinhAnh", selectedImagePath); 
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadDataGridView();
                ResetValues();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                txtMaNhanVien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                conn.Close();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (!ValidateInput())
            {
                return;
            }

            // Kiểm tra xem người dùng đã chọn hình ảnh mới để cập nhật hay chưa
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE NhanVien SET TenNhanVien=@TenNhanVien, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, NgaySinh=@NgaySinh, HinhAnh=@HinhAnh WHERE MaNhanVien=@MaNhanVien";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", gt);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@SoDienThoai", mtbDienThoai.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", DateTime.ParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@HinhAnh", selectedImagePath);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadDataGridView();
                    ResetValues();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else
            {
                // Nếu không có hình ảnh mới được chọn, hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng chọn hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xoá bằng cách nhấn vào ô Mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM NhanVien WHERE MaNhanVien=@MaNhanVien";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadDataGridView();
                    ResetValues();
                    MessageBox.Show("Xoá nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        private DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return false;
            }

            if (!chkNam.Checked && !chkNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(mtbDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(mskNgaySinh.Text) || !DateTime.TryParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Vui lòng nhập Ngày sinh đúng định dạng (dd/MM/yyyy).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return false;
            }

            return true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = txtFind.Text.Trim();

                // Kiểm tra xem mã nhân viên có được nhập không
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Vui lòng nhập Mã nhân viên cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu truy vấn SQL để tìm kiếm nhân viên theo Mã nhân viên
                string sql = "SELECT * FROM NhanVien WHERE MaNhanVien LIKE @MaNhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaNhanVien", "%" + maNhanVien + "%");

                // Tạo một bảng dữ liệu mới để lưu trữ kết quả tìm kiếm
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);

                // Kiểm tra xem có dữ liệu trả về từ tìm kiếm không
                if (resultTable.Rows.Count > 0)
                {
                    dgvNhanVien.DataSource = resultTable; // Hiển thị kết quả tìm kiếm trên DataGridView

                    // Hiển thị thông tin của nhân viên đầu tiên trong kết quả tìm kiếm trên các trường thông tin tương ứng
                    DataRow row = resultTable.Rows[0];
                    txtMaNhanVien.Text = row["MaNhanVien"].ToString();
                    txtTenNhanVien.Text = row["TenNhanVien"].ToString();
                    string gioiTinh = row["GioiTinh"].ToString();
                    chkNam.Checked = gioiTinh == "Nam";
                    chkNu.Checked = gioiTinh == "Nữ";
                    txtDiaChi.Text = row["DiaChi"].ToString();
                    mtbDienThoai.Text = row["SoDienThoai"].ToString();
                    mskNgaySinh.Text = ((DateTime)row["NgaySinh"]).ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với Mã nhân viên '" + maNhanVien + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
               
            }
        }

        private void pnlNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }
        private string selectedImagePath;
        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh nhân viên";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dlgOpen.FileName; // Lưu đường dẫn của tệp ảnh đã chọn
                picAvatar.Image = Image.FromFile(selectedImagePath);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

    }
}
