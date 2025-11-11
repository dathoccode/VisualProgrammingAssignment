using CoffeeHouseABC.Models;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_ItemOrder : UserControl
    {
        private ChiTietDonHang _ct;

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
                var img = Properties.Resources.ResourceManager.GetObject(ct.HinhAnh);
                guna2PictureBox1.Image = img as Image ?? Properties.Resources.coffee;
            }
            catch
            {
                guna2PictureBox1.Image = Properties.Resources.coffee;
            }

        }
    }
}
