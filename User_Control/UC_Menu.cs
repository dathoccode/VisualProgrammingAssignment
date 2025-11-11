using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Models;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Menu : UserControl
    {
        public UC_Menu()
        {
            InitializeComponent();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            try
            {
                DatabaseService db = new DatabaseService();
                List<SanPham> ds = db.GetSanPham();

                flowPanel.Controls.Clear();

                foreach (var sp in ds)
                {
                    var item = new UC_ItemSanPham();
                    item.SetData(sp);
                    flowPanel.Controls.Add(item);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị menu: " + ex.Message);
            }
        }

        private void btnDatHang_Click(object sender, System.EventArgs e)
        {
            List<ChiTietDonHang> ds = new();
            List<string> tenSP = new();

            foreach (UC_ItemSanPham item in flowPanel.Controls.OfType<UC_ItemSanPham>())
            {
                if (item.SoLuong > 0)
                {
                    ds.Add(new ChiTietDonHang
                    {
                        MaSP = item.SanPham.MaSP,
                        SoLuong = item.SoLuong,
                        DonGiaBan = item.SanPham.Gia,
                        HinhAnh = item.SanPham.HinhAnh
                    });

                    tenSP.Add(item.SanPham.TenSP);
                }
            }

            if (ds.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào.");
                return;
            }

            
            HomePage home = this.FindForm() as HomePage;
            if (home != null)
            {
                home.CapNhatGioHang(ds, tenSP);

                // chuyển trang + highlight nút Đơn hàng
                home.ChuyenSangDonHang();
            }
        }
    }
}
