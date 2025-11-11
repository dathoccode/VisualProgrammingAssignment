using CoffeeHouseABC.Models;
using System;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_ItemSanPham : UserControl
    {
        public SanPham SanPham { get; private set; }

        public int SoLuong => (int)guna2NumericUpDown1.Value;

        public UC_ItemSanPham()
        {
            InitializeComponent();
        }

        public void SetData(SanPham sp)
        {
            SanPham = sp;

            guna2HtmlLabel2.Text = sp.TenSP;
            guna2HtmlLabel3.Text = sp.Gia.ToString("N0") + " VNĐ";

            try
            {
                var img = Properties.Resources.ResourceManager.GetObject(sp.HinhAnh);
                guna2PictureBox1.Image = img as Image ?? Properties.Resources.default_image;
            }
            catch
            {
                guna2PictureBox1.Image = Properties.Resources.default_image;
            }

            guna2NumericUpDown1.Value = 0;
        }
    }
}
