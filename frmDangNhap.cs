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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Khởi tạo kết nối đến cơ sở dữ liệu
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=QuanLyBanHang;Integrated Security=True");
            try
            {
                // Mở kết nối
                conn.Open();
                string email = txtEmail.Text;
                string mk = txtPass.Text;
                if (email == null || email.Equals(""))
                {
                    MessageBox.Show("Chưa nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mk == null || mk.Equals(""))
                {
                    MessageBox.Show("Chưa nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Tạo câu truy vấn SQL để kiểm tra đăng nhập
                string sql = "select * from NhanVien where Email = '" + email + "' and Password = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader(); // Thực thi câu lệnh select và nhận dữ liệu trả về
                // Kiểm tra xem có dữ liệu trả về từ câu lệnh SQL không
                if (rdr.HasRows)
                {
                    // Nếu đăng nhập thành công, hiển thị form chính và ẩn form đăng nhập
                    /*frmMain frm = new frmMain(email);
                    frm.Show();// hiển thị main*/
                    frmTrangChu frm = new frmTrangChu();
                    frm.Show();
                    this.Hide();// ẩn login
                }
                else
                {
                    // Hiển thị thông báo khi tài khoản không tồn tại
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception )
            {
                // Hiển thị thông báo khi có lỗi kết nối hoặc thực thi câu lệnh SQL
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                // Đóng kết nối sau khi thực hiện xong
                conn.Close();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận việc thoát
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn OK hay không
            if (result == DialogResult.OK)
            {
                // Thoát ứng dụng
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }

        private void cbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu checkbox được chọn, hiển thị mật khẩu
            if (cbShowPassWord.Checked)
            {
                txtPass.UseSystemPasswordChar = false; // Hiển thị mật khẩu
            }
            else
            {
                txtPass.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím người dùng nhấn có phải là phím Enter không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Thực hiện hành động đăng nhập
                btnLogin_Click(sender, e);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.KeyPress += new KeyPressEventHandler(txtEmail_KeyPress);
            txtPass.KeyPress += new KeyPressEventHandler(txtPass_KeyPress);
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím người dùng nhấn có phải là phím Enter không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Thực hiện hành động đăng nhập
                btnLogin_Click(sender, e);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        internal string GetUserName()
        {
            throw new NotImplementedException();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
