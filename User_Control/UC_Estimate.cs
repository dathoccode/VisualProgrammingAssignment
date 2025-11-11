using System;
using System.Windows.Forms;

using CoffeeHouseABC.Utils;
using CoffeeHouseABC.Database;   // thêm thư viện DatabaseService

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Estimate : UserControl
    {
        public UC_Estimate()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn() || SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập để gửi đánh giá!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int diemPhucVu = GetDiemThaiDo();
            int diemChatLuong = GetDiemChatLuong();
            int diemKhongGian = GetDiemKhongGian();
            int diemDaDang = GetDiemDoDaDang();

            if (diemPhucVu == 0 || diemChatLuong == 0 || diemKhongGian == 0 || diemDaDang == 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ các mục đánh giá!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DatabaseService db = new DatabaseService();

            bool success = db.ThemDanhGia(
                SessionManager.CurrentUser.MaKH,
                diemPhucVu,
                diemChatLuong,
                diemKhongGian,
                diemDaDang,
                txtGopY.Text
            );

            if (success)
            {
                MessageBox.Show("Cảm ơn bạn đã gửi đánh giá!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ResetForm();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi gửi đánh giá!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetDiemThaiDo()
        {
            if (rbThaiDo1.Checked) return 1;
            if (rbThaiDo2.Checked) return 2;
            if (rbThaiDo3.Checked) return 3;
            if (rbThaiDo4.Checked) return 4;
            if (rbThaiDo5.Checked) return 5;
            return 0;
        }

        private int GetDiemChatLuong()
        {
            if (rbChatLuong1.Checked) return 1;
            if (rbChatLuong2.Checked) return 2;
            if (rbChatLuong3.Checked) return 3;
            if (rbChatLuong4.Checked) return 4;
            if (rbChatLuong5.Checked) return 5;
            return 0;
        }

        private int GetDiemKhongGian()
        {
            if (rbKhongGian1.Checked) return 1;
            if (rbKhongGian2.Checked) return 2;
            if (rbKhongGian3.Checked) return 3;
            if (rbKhongGian4.Checked) return 4;
            if (rbKhongGian5.Checked) return 5;
            return 0;
        }

        private int GetDiemDoDaDang()
        {
            if (rbDoDaDang1.Checked) return 1;
            if (rbDoDaDang2.Checked) return 2;
            if (rbDoDaDang3.Checked) return 3;
            if (rbDoDaDang4.Checked) return 4;
            if (rbDoDaDang5.Checked) return 5;
            return 0;
        }

        private void ResetForm()
        {
            rbThaiDo1.Checked = rbThaiDo2.Checked = rbThaiDo3.Checked = rbThaiDo4.Checked = rbThaiDo5.Checked = false;
            rbChatLuong1.Checked = rbChatLuong2.Checked = rbChatLuong3.Checked = rbChatLuong4.Checked = rbChatLuong5.Checked = false;
            rbKhongGian1.Checked = rbKhongGian2.Checked = rbKhongGian3.Checked = rbKhongGian4.Checked = rbKhongGian5.Checked = false;
            rbDoDaDang1.Checked = rbDoDaDang2.Checked = rbDoDaDang3.Checked = rbDoDaDang4.Checked = rbDoDaDang5.Checked = false;

            txtGopY.Text = "";
        }
    }
}
