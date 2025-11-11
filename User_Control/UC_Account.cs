using System;
using System.Windows.Forms;

using CoffeeHouseABC.Utils;
using CoffeeHouseABC.Database;   // thêm dòng này

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
            LoadAccountInfo();
        }

        private void LoadAccountInfo()
        {
            if (SessionManager.IsLoggedIn() && SessionManager.CurrentUser != null)
            {
                txtTenTaiKhoan.Text = SessionManager.CurrentUser.TenTaiKhoan;
                txtVaiTro.Text = SessionManager.CurrentUser.VaiTro;

                txtMatKhau.Text = "********";
                txtMatKhau.UseSystemPasswordChar = false;

                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.UseSystemPasswordChar = true;

                txtVaiTro.Enabled = false;
                txtTenTaiKhoan.ReadOnly = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn() || SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseService db = new DatabaseService();

            bool success = db.DoiMatKhau(SessionManager.CurrentUser.MaKH, txtMatKhauMoi.Text);

            if (success)
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMatKhau.Text = "********";
                txtMatKhauMoi.Text = "";
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
