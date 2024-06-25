using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginTest
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
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
        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLHD());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            //frmNhanVien frmNV = new frmNhanVien();
            //frmNV.Show();
            //this.Hide();
            OpenChildForm(new frmNhanVien());
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                this.Close();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
            }
            else if (tb == DialogResult.Cancel)
            {
                // không làm gì cả, form hiện tại sẽ được giữ nguyên
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            // Đảm bảo pnlMain tự động điều chỉnh kích thước của nó để chứa toàn bộ nội dung bên trong
            pnlMain.AutoSize = true;

            // Đảm bảo pnlMain lấp đầy không gian của form cha
            pnlMain.Dock = DockStyle.Fill;

            // Cập nhật kích thước của frmTrangChu để phù hợp với pnlMain
            this.Size = new Size(pnlMain.Width - 45, pnlMain.Height + 200);
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoanhThu());
        }
    }
}
