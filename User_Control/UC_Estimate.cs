using System;
using System.Windows.Forms;
using System.Drawing;

using CoffeeHouseABC.Utils;
using CoffeeHouseABC.Database; 

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Estimate : UserControl
    {
        private Panel? panelThaiDo;
        private Panel? panelChatLuong;
        private Panel? panelKhongGian;
        private Panel? panelDoDaDang;

        public UC_Estimate()
        {
            InitializeComponent();
            CreateGroupPanels();
            SetupRadioButtonGroups();
        }

        private void CreateGroupPanels()
        {
            panelThaiDo = CreateInvisiblePanel("panelThaiDo", 880, 140, 350, 50);
            panelChatLuong = CreateInvisiblePanel("panelChatLuong", 880, 215, 350, 50);
            panelKhongGian = CreateInvisiblePanel("panelKhongGian", 880, 290, 350, 50);
            panelDoDaDang = CreateInvisiblePanel("panelDoDaDang", 880, 365, 350, 50);

            this.Controls.Add(panelThaiDo);
            this.Controls.Add(panelChatLuong);
            this.Controls.Add(panelKhongGian);
            this.Controls.Add(panelDoDaDang);

            MoveToPanel(panelThaiDo, rbThaiDo1, rbThaiDo2, rbThaiDo3, rbThaiDo4, rbThaiDo5, 
                        lbl1, lbl2, lbl3, lbl4, lbl5);
            MoveToPanel(panelChatLuong, rbChatLuong1, rbChatLuong2, rbChatLuong3, rbChatLuong4, rbChatLuong5,
                        lblCL1, lblCL2, lblCL3, lblCL4, lblCL5);
            MoveToPanel(panelKhongGian, rbKhongGian1, rbKhongGian2, rbKhongGian3, rbKhongGian4, rbKhongGian5,
                        lblKG1, lblKG2, lblKG3, lblKG4, lblKG5);
            MoveToPanel(panelDoDaDang, rbDoDaDang1, rbDoDaDang2, rbDoDaDang3, rbDoDaDang4, rbDoDaDang5,
                        lblDD1, lblDD2, lblDD3, lblDD4, lblDD5);

            panelThaiDo.BringToFront();
            panelChatLuong.BringToFront();
            panelKhongGian.BringToFront();
            panelDoDaDang.BringToFront();
        }

        private Panel CreateInvisiblePanel(string name, int x, int y, int width, int height)
        {
            return new Panel
            {
                Name = name,
                Location = new Point(x, y),
                Size = new Size(width, height),
                BackColor = Color.Transparent
            };
        }

        private void MoveToPanel(Panel panel, params Control[] controls)
        {
            foreach (var ctrl in controls)
            {
                Point oldLocation = ctrl.Location;
                this.Controls.Remove(ctrl);
                ctrl.Location = new Point(oldLocation.X - panel.Location.X, oldLocation.Y - panel.Location.Y);
                panel.Controls.Add(ctrl);
            }
        }

        private void SetupRadioButtonGroups()
        {
            SetTag("ThaiDo", rbThaiDo1, rbThaiDo2, rbThaiDo3, rbThaiDo4, rbThaiDo5);
            SetTag("ChatLuong", rbChatLuong1, rbChatLuong2, rbChatLuong3, rbChatLuong4, rbChatLuong5);
            SetTag("KhongGian", rbKhongGian1, rbKhongGian2, rbKhongGian3, rbKhongGian4, rbKhongGian5);
            SetTag("DoDaDang", rbDoDaDang1, rbDoDaDang2, rbDoDaDang3, rbDoDaDang4, rbDoDaDang5);
        }

        private void SetTag(string tag, params Guna.UI2.WinForms.Guna2CustomRadioButton[] buttons)
        {
            foreach (var rb in buttons)
            {
                rb.Tag = tag;
            }
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
