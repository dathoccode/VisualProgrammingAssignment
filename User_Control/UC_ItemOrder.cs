using CoffeeHouseABC.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_ItemOrder : UserControl
    {
        private ChiTietDonHang _ct = new ChiTietDonHang();

        public UC_ItemOrder()
        {
            InitializeComponent();
        }

        public void SetData(ChiTietDonHang ct, string tenSP)
        {
            _ct = ct;

            guna2HtmlLabel2.Text = tenSP;
            guna2HtmlLabel3.Text = $"{ct.DonGiaBan:N0} VNĐ";
            guna2NumericUpDown1.Value = ct.SoLuong;

            try
            {
                Image? img = null;
                if (!string.IsNullOrEmpty(ct.HinhAnh))
                    img = Properties.Resources.ResourceManager.GetObject(ct.HinhAnh) as Image;

                guna2PictureBox1.Image = img ?? Properties.Resources.default_image;
            }
            catch
            {
                guna2PictureBox1.Image = Properties.Resources.default_image;
            }
        }

        // 🔹 Khi thay đổi số lượng
        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _ct.SoLuong = (int)guna2NumericUpDown1.Value;

            // Nếu người dùng chỉnh về 0 → tự xóa control
            if (_ct.SoLuong == 0)
            {
                XoaKhoiDonHang();
            }
        }

        // 🔹 Khi bấm nút Xóa
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?",
                                          "Xác nhận",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                XoaKhoiDonHang();
            }
        }

        // 🔹 Hàm xử lý chung khi cần xóa sản phẩm khỏi giỏ hàng
        private void XoaKhoiDonHang()
        {
            HomePage home = this.FindForm() as HomePage;
            if (home != null)
            {
                // Gọi về UC_Order để xóa sản phẩm này
                var ucOrder = this.Parent?.Parent as UC_Order;
                ucOrder?.XoaSanPhamKhoiDonHang(_ct.MaSP);

                // Reset lại số lượng trong Menu
                home.MenuControl?.ResetSoLuongSanPham(_ct.MaSP);

                // Xóa control hiện tại khỏi flowPanel
                this.Parent?.Controls.Remove(this);

              
            }
        }
    }
}
