using System;
using System.Windows.Forms;

using CoffeeHouseABC.Database;   // để dùng DatabaseService
using CoffeeHouseABC.Utils;      // SessionManager
using CoffeeHouseABC.Models;
namespace CoffeeHouseABC.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // gọi DatabaseService để kiểm tra đăng nhập
            DatabaseService db = new DatabaseService();
            var user = db.Login(username, password);

            if (user != null)
            {
                SessionManager.CurrentUser = user;

                MessageBox.Show($"Đăng nhập thành công!\nXin chào {user.TenTaiKhoan}",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}
