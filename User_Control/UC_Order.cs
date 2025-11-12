using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Models;
using CoffeeHouseABC.Utils;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Order : UserControl
    {
        private List<ChiTietDonHang> _ds = new();
        private List<string> _tenSP = new();

        public UC_Order()
        {
            InitializeComponent();
            HienThiTrangThaiTrong();
        }

        public UC_Order(List<ChiTietDonHang> ds, List<string> tenSP)
        {
            InitializeComponent();
            _ds = ds;
            _tenSP = tenSP;
            LoadOrder();
        }

        private void HienThiTrangThaiTrong()
        {
            panelList.Controls.Clear();

            Label lbl = new Label
            {
                Text = "Bạn chưa chọn sản phẩm nào...",
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(20, 20)
            };

            panelList.Controls.Add(lbl);
            lblTongTien.Text = "Tổng: 0 VNĐ";
        }

        private void LoadOrder()
        {
            panelList.Controls.Clear();

            if (_ds == null || _ds.Count == 0)
            {
                HienThiTrangThaiTrong();
                return;
            }

            for (int i = 0; i < _ds.Count; i++)
            {
                var item = new UC_ItemOrder();
                item.SetData(_ds[i], _tenSP[i]);
                panelList.Controls.Add(item);
            }

            CapNhatTongTien();
        }

        // ✅ Hàm cập nhật tổng tiền (dùng lại nhiều nơi)
        public void CapNhatTongTien()
        {
            if (_ds == null || _ds.Count == 0)
            {
                lblTongTien.Text = "Tổng: 0 VNĐ";
                return;
            }

            decimal tong = _ds.Sum(x => x.DonGiaBan * x.SoLuong);
            lblTongTien.Text = $"Tổng: {tong:N0} VNĐ";
        }

        // ✅ Gọi từ UC_ItemOrder khi bấm Xóa hoặc số lượng = 0
        public void XoaSanPhamKhoiDonHang(int maSP)
        {
            _ds.RemoveAll(x => x.MaSP == maSP);
            _tenSP = _tenSP.Take(_ds.Count).ToList();
            LoadOrder();

            if (_ds.Count == 0)
                HienThiTrangThaiTrong();
        }

        // ✅ Số lượng sản phẩm còn trong giỏ
        public int SoLuongDonHang => _ds?.Count ?? 0;

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (_ds == null || _ds.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng!");
                return;
            }

            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi đặt hàng.");
                return;
            }

            try
            {
                DatabaseService db = new DatabaseService();
                int maKH = SessionManager.CurrentUser.MaKH;
                decimal tongTien = _ds.Sum(x => x.DonGiaBan * x.SoLuong);
                int maHD = db.TaoDonHang(maKH, tongTien, "Đã Thanh Toán", _ds);

                MessageBox.Show($"Đặt hàng thành công! Mã đơn hàng: {maHD}");

                var parent = this.Parent;
                if (parent != null)
                {
                    UC_PurchaseHistory historyUC = null;

                    foreach (Control ctrl in parent.Controls)
                    {
                        if (ctrl is UC_PurchaseHistory uc)
                        {
                            historyUC = uc;
                            break;
                        }
                    }

                    if (historyUC == null)
                    {
                        historyUC = new UC_PurchaseHistory();
                        historyUC.Dock = DockStyle.Fill;
                    }

                    historyUC.LoadPurchaseHistory();

                    parent.Controls.Clear();
                    parent.Controls.Add(historyUC);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy container để hiển thị lịch sử mua hàng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu đơn hàng: " + ex.Message);
            }
        }
    }
}
