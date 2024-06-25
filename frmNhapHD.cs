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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
using System.Xml.Linq;


namespace LoginTest
{
    public partial class frmNHD : Form
    {
        private object Functions;
        private System.Data.DataTable HoaDon;
        public frmNHD()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=(local); DataBase=QuanLyBanHang; Integrated Security=True; Encrypt=False");
        public static System.Data.DataTable GetDataToTable(string sql)
        {
            SqlConnection conn = new SqlConnection("Server=(local); DataBase=QuanLyBanHang; Integrated Security=True; Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            System.Data.DataTable HoaDon = new System.Data.DataTable();
            adapter.Fill(HoaDon);
            return HoaDon;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlConnection conn = new SqlConnection("Server=(local); DataBase=QuanLyBanHang; Integrated Security=True; Encrypt=False");
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            System.Data.DataTable table = new System.Data.DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

     
        private void lblTenSanPham_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmIHD_Load(object sender, EventArgs e)
        {
            txtStt.Enabled = false;
            txtStt5.Enabled = false;
            txtStt2.Enabled = false;
            txtStt3.Enabled = false;
            txtStt4.Enabled = false;

            txtDonGia.Enabled = false;
            txtDonGia2.Enabled = false;
            txtDonGia3.Enabled = false;
            txtDonGia4.Enabled = false;
            txtDonGia5.Enabled = false;
            txtThanhTien.Enabled = false;
            txtThanhTien2.Enabled = false;
            txtThanhTien3.Enabled = false;
            txtThanhTien4.Enabled = false;
            txtThanhTien5.Enabled = false;
            txtTongTien.Enabled = false;
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Server=(local); DataBase=QuanLyBanHang; Integrated Security=True; Encrypt=False"))
                {
                    conn.Open();

                    // Tạo câu lệnh SQL để chèn thông tin hóa đơn vào bảng ChiTietHoaDon
                    string sqlInsertHoaDon = @"
                INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, TenKhachHang, SoDienThoai, DiaChi, TenSanPham, SoLuong, DonGia, ThanhTien, TongTien)
                VALUES (@MaHoaDon, @MaSanPham, @TenKhachHang, @SoDienThoai, @DiaChi, @TenSanPham, @SoLuong, @DonGia, @ThanhTien, @TongTien)";

                    using (SqlCommand cmd = new SqlCommand(sqlInsertHoaDon, conn))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);
                        cmd.Parameters.AddWithValue("@TenKhachHang", CB_TenKH.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);

                        // Lưu thông tin từng sản phẩm
                        AddProductDetails(cmd, comboBox1, txtSoLuong, txtDonGia, txtThanhTien, txtMaSP);
                        AddProductDetails(cmd, comboBox2, txtSoLuong2, txtDonGia2, txtThanhTien2, txtMaSP2);
                        AddProductDetails(cmd, comboBox3, txtSoLuong3, txtDonGia3, txtThanhTien3, txtMaSP3);
                        AddProductDetails(cmd, comboBox4, txtSoLuong4, txtDonGia4, txtThanhTien4, txtMaSP4);
                        AddProductDetails(cmd, comboBox5, txtSoLuong5, txtDonGia5, txtThanhTien5, txtMaSP5);
                    }

                    MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductDetails(SqlCommand cmd, ComboBox productComboBox, TextBox quantityTextBox, TextBox priceTextBox, TextBox amountTextBox, TextBox MaSPTextBox)
        {
            if (!string.IsNullOrEmpty(productComboBox.Text))
            {
                cmd.Parameters.AddWithValue("@TenSanPham", productComboBox.Text);
                cmd.Parameters.AddWithValue("@SoLuong", quantityTextBox.Text);
                cmd.Parameters.AddWithValue("@DonGia", priceTextBox.Text);
                cmd.Parameters.AddWithValue("@ThanhTien", amountTextBox.Text);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSPTextBox.Text);
                // Thực thi câu lệnh chèn thông tin sản phẩm vào bảng ChiTietHoaDon
                cmd.ExecuteNonQuery();

                // Xóa các tham số để chuẩn bị cho sản phẩm tiếp theo
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaHoaDon", txtMaHoaDon.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", CB_TenKH.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
              
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // Hộp thoại lưu tệp để chọn vị trí lưu PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
            saveFileDialog.FileName = "HoaDon.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(saveFileDialog.FileName);
            }
        }

        private void ExportToPDF(string fileName)
        {
            try
            {
                // Tạo tài liệu mới
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                document.Open();

                // Thêm tiêu đề
                BaseFont bfTitle = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bfTitle, 18, iTextSharp.text.Font.BOLD);
                Paragraph title = new Paragraph("Hóa Đơn Bán Hàng", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);
                document.Add(new Paragraph("\n"));

                // Thêm thông tin khách hàng
                BaseFont bfContent = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bfContent, 12);
                document.Add(new Paragraph("Tên Khách Hàng: " + CB_TenKH.Text, font));
                document.Add(new Paragraph("Địa Chỉ: " + txtDiaChi.Text, font));
                document.Add(new Paragraph("Số Điện Thoại: " + txtSoDienThoai.Text, font));
                document.Add(new Paragraph("Mã Hóa Đơn: " + txtMaHoaDon.Text, font));
                document.Add(new Paragraph("Tên Mã viên: " + CB_MaNV.Text, font));
                document.Add(new Paragraph("\n"));

                // Thêm bảng sản phẩm
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1, 3, 1, 1, 1 });

                // Thêm tiêu đề cột và căn giữa các tiêu đề
                table.AddCell(CreateCenteredCell("STT", font));
                table.AddCell(CreateCenteredCell("Tên Sản Phẩm", font));
                table.AddCell(CreateCenteredCell("Số Lượng", font));
                table.AddCell(CreateCenteredCell("Đơn Giá", font));
                table.AddCell(CreateCenteredCell("Thành Tiền", font));

                // Thêm hàng sản phẩm - AddProductRow đã được gọi trong vòng lặp
                AddProductRow(table, "1", comboBox1.Text, txtSoLuong.Text, txtDonGia.Text, txtThanhTien.Text, font);
                AddProductRow(table, "2", comboBox2.Text, txtSoLuong2.Text, txtDonGia2.Text, txtThanhTien2.Text, font);
                AddProductRow(table, "3", comboBox3.Text, txtSoLuong3.Text, txtDonGia3.Text, txtThanhTien3.Text, font);
                AddProductRow(table, "4", comboBox4.Text, txtSoLuong4.Text, txtDonGia4.Text, txtThanhTien4.Text, font);
                AddProductRow(table, "5", comboBox5.Text, txtSoLuong5.Text, txtDonGia5.Text, txtThanhTien5.Text, font);

                // Thêm ô trống để đẩy tổng cộng về bên phải
                PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                emptyCell.Colspan = 4;
                emptyCell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Chỉ định rõ namespace cho Rectangle
                table.AddCell(emptyCell);

                // Thêm ô tổng cộng
                PdfPCell totalCell = new PdfPCell(new Phrase("Tổng Cộng: " + txtTongTien.Text + " VNĐ", font));
                totalCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                totalCell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Chỉ định rõ namespace cho Rectangle
                table.AddCell(totalCell);

                document.Add(table);

                document.Close();

                MessageBox.Show("In hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PdfPCell CreateCenteredCell(string text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Padding = 5; // Thêm khoảng cách nếu cần
            return cell;
        }

        private void AddProductRow(PdfPTable table, string stt, string tenSanPham, string soLuong, string donGia, string thanhTien, iTextSharp.text.Font font)
        {
            if (!string.IsNullOrEmpty(tenSanPham))
            {
                // STT
                PdfPCell cellStt = new PdfPCell(new Phrase(stt, font));
                cellStt.HorizontalAlignment = Element.ALIGN_CENTER;
                cellStt.Padding = 5;
                table.AddCell(cellStt);

                // Tên sản phẩm
                PdfPCell cellTenSanPham = new PdfPCell(new Phrase(tenSanPham, font));
                cellTenSanPham.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTenSanPham.Padding = 5;
                table.AddCell(cellTenSanPham);

                // Số lượng
                PdfPCell cellSoLuong = new PdfPCell(new Phrase(soLuong, font));
                cellSoLuong.HorizontalAlignment = Element.ALIGN_CENTER;
                cellSoLuong.Padding = 5;
                table.AddCell(cellSoLuong);

                // Đơn giá
                PdfPCell cellDonGia = new PdfPCell(new Phrase(donGia, font));
                cellDonGia.HorizontalAlignment = Element.ALIGN_CENTER;
                cellDonGia.Padding = 5;
                table.AddCell(cellDonGia);

                // Thành tiền
                PdfPCell cellThanhTien = new PdfPCell(new Phrase(thanhTien, font));
                cellThanhTien.HorizontalAlignment = Element.ALIGN_CENTER;
                cellThanhTien.Padding = 5;
                table.AddCell(cellThanhTien);
            }
        }



        private void tblDG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_TenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn mục trong ComboBox chưa
                if (CB_TenKH.SelectedIndex >= 0)
                {
                    // Lấy mã khách hàng từ ComboBox
                    string TenKhachHang = CB_TenKH.SelectedValue.ToString();

                    // Truy vấn cơ sở dữ liệu để lấy thông tin khách hàng
                    string sql = "SELECT SoDienThoai, DiaChi FROM KhachHang WHERE TenKhachHang = N'" + TenKhachHang + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Nếu tìm thấy khách hàng
                    if (reader.Read())
                    {
                        // Cập nhật thông tin vào textbox
                        txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                        txtDiaChi.Text = reader["DiaChi"].ToString();
                    }
                 

                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_TenKH_DropDown(object sender, EventArgs e)
        {
            FillCombo("SELECT TenKhachHang FROM KhachHang", CB_TenKH, "TenKhachHang", "MaKhachHang");
            CB_TenKH.SelectedIndex = -1;
        }

        private void CB_MaNV_DropDown(object sender, EventArgs e)
        {
            FillCombo("SELECT MaNhanVien FROM NhanVien", CB_MaNV, "MaNhanVien", "MaNhanVien");
            CB_MaNV.SelectedIndex = -1;
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_TenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtStt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            FillCombo("SELECT TenSanPham FROM SanPham", comboBox1, "TenSanPham", "TenSanPham");
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            FillCombo("SELECT TenSanPham FROM SanPham", comboBox2, "TenSanPham", "TenSanPham");
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            FillCombo("SELECT TenSanPham FROM SanPham", comboBox3, "TenSanPham", "TenSanPham");
            comboBox3.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn mục trong ComboBox chưa
                if (comboBox1.SelectedIndex >= 0)
                {
                    // Lấy mã khách hàng từ ComboBox
                    string TenSanPham = comboBox1.SelectedValue.ToString();

                    // Truy vấn cơ sở dữ liệu để lấy thông tin khách hàng
                    string sql = "SELECT MaSanPham, DonGiaBan FROM SanPham WHERE TenSanPham = N'" + TenSanPham + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Nếu tìm thấy khách hàng
                    if (reader.Read())
                    {
                        // Cập nhật thông tin vào textbox
                        txtDonGia.Text = Convert.ToSingle(reader["DonGiaBan"]).ToString("N0");
                        txtMaSP.Text = Convert.ToString(reader["MaSanPham"]);
                    }

                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.SelectedIndex >= 0)
                {
                    string TenSanPham = comboBox4.SelectedValue.ToString();
                    string sql = "SELECT MaSanPham, DonGiaBan FROM SanPham WHERE TenSanPham = N'" + TenSanPham + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDonGia4.Text = Convert.ToSingle(reader["DonGiaBan"]).ToString("N0");
                        txtMaSP4.Text = Convert.ToString(reader["MaSanPham"]);
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
         
            FillCombo("SELECT TenSanPham FROM SanPham", comboBox4, "TenSanPham", "TenSanPham");
            comboBox4.SelectedIndex = -1;

        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            FillCombo("SELECT TenSanPham FROM SanPham", comboBox5, "TenSanPham", "TenSanPham");
            comboBox5.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex >= 0)
                {
                    string TenSanPham = comboBox2.SelectedValue.ToString();
                    string sql = "SELECT MaSanPham, DonGiaBan FROM SanPham WHERE TenSanPham = N'" + TenSanPham + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDonGia2.Text = Convert.ToSingle(reader["DonGiaBan"]).ToString("N0");
                        txtMaSP2.Text = Convert.ToString(reader["MaSanPham"]);
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedIndex >= 0)
                {
                    string TenSanPham = comboBox3.SelectedValue.ToString();
                    string sql = "SELECT MaSanPham, DonGiaBan FROM SanPham WHERE TenSanPham = N'" + TenSanPham + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDonGia3.Text = Convert.ToSingle(reader["DonGiaBan"]).ToString("N0");
                        txtMaSP3.Text = Convert.ToString(reader["MaSanPham"]);
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox5.SelectedIndex >= 0)
                {
                    string TenSanPham = comboBox5.SelectedValue.ToString();
                    string sql = "SELECT MaSanPham, DonGiaBan FROM SanPham WHERE TenSanPham = N'" + TenSanPham + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDonGia5.Text = Convert.ToSingle(reader["DonGiaBan"]).ToString("N0");
                        txtMaSP5.Text = Convert.ToString(reader["MaSanPham"]);
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void txtSoLuong2_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void txtSoLuong3_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void txtSoLuong4_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void txtSoLuong5_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void CalculateThanhTien()
        {
            try
            {
                // Lấy giá trị số lượng và đơn giá
                float soLuong1 = float.TryParse(txtSoLuong.Text, out float sl1) ? sl1 : 0;
                float soLuong2 = float.TryParse(txtSoLuong2.Text, out float sl2) ? sl2 : 0;
                float soLuong3 = float.TryParse(txtSoLuong3.Text, out float sl3) ? sl3 : 0;
                float soLuong4 = float.TryParse(txtSoLuong4.Text, out float sl4) ? sl4 : 0;
                float soLuong5 = float.TryParse(txtSoLuong5.Text, out float sl5) ? sl5 : 0;

                float donGia1 = float.TryParse(txtDonGia.Text, out float dg1) ? dg1 : 0;
                float donGia2 = float.TryParse(txtDonGia2.Text, out float dg2) ? dg2 : 0;
                float donGia3 = float.TryParse(txtDonGia3.Text, out float dg3) ? dg3 : 0;
                float donGia4 = float.TryParse(txtDonGia4.Text, out float dg4) ? dg4 : 0;
                float donGia5 = float.TryParse(txtDonGia5.Text, out float dg5) ? dg5 : 0;

                // Tính thành tiền cho từng sản phẩm
                float thanhTien1 = soLuong1 * donGia1;
                float thanhTien2 = soLuong2 * donGia2;
                float thanhTien3 = soLuong3 * donGia3;
                float thanhTien4 = soLuong4 * donGia4;
                float thanhTien5 = soLuong5 * donGia5;

                // Cập nhật giá trị thành tiền vào các TextBox
                txtThanhTien.Text = thanhTien1.ToString("N0");
                txtThanhTien2.Text = thanhTien2.ToString("N0");
                txtThanhTien3.Text = thanhTien3.ToString("N0");
                txtThanhTien4.Text = thanhTien4.ToString("N0");
                txtThanhTien5.Text = thanhTien5.ToString("N0");

                // Tính tổng tiền
                float tongTien = thanhTien1 + thanhTien2 + thanhTien3 + thanhTien4 + thanhTien5;
                txtTongTien.Text = tongTien.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewCus_Click(object sender, EventArgs e)
        {
            // Mở form mới để nhập thông tin khách hàng
            frmKhachHang addCustomerForm = new frmKhachHang();
            addCustomerForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSP2_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

