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

namespace LoginTest
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string email = txtEmail.Text;
                string mk = txtPass.Text;

                // Kiểm tra tính hợp lệ của dữ liệu nhập vào
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu chưa
                string checkEmailQuery = "SELECT COUNT(*) FROM NhanVien WHERE Email = @Email";
                SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, conn);
                checkEmailCmd.Parameters.AddWithValue("@Email", email);
                int emailCount = (int)checkEmailCmd.ExecuteScalar();

                if (emailCount > 0)
                {
                    MessageBox.Show("Email đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Nếu email chưa tồn tại, thêm tài khoản mới vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO NhanVien (MaNhanVien, Email, [Password]) VALUES (@MaNhanVien, @Email, @Password)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@Password", mk);
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form đăng ký và hiển thị lại form đăng nhập
                    this.Close();
                    frmDangNhap loginForm = new frmDangNhap();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại! Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Đóng form đăng ký và hiển thị lại form đăng nhập
            this.Close();
            frmDangNhap loginForm = new frmDangNhap();
            loginForm.Show();
        }
    }
}
