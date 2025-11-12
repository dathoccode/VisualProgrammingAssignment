using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_ItemPurchase : UserControl
    {
        private int _maHD;
        public event EventHandler<int>? DeleteClicked;

        public UC_ItemPurchase()
        {
            InitializeComponent();
            btnXoa.Click += BtnXoa_Click;
        }
        
        public void SetData(string maHD, string ngay, string tongTien, string trangThai)
        {
            _maHD = int.Parse(maHD);
            
            lblMaHD.Text = maHD;
            lblNgay.Text = ngay;
            lblTongTien.Text = tongTien;
            lblTrangThai.Text = trangThai;

            if (trangThai.Contains("Đã thanh toán") || trangThai.Contains("Hoàn thành"))
            {
                lblTrangThai.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else if (trangThai.Contains("Đã hủy"))
            {
                lblTrangThai.ForeColor = Color.Red;
            }
            else
            {
                lblTrangThai.ForeColor = Color.Black;
            }
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa đơn hàng {lblMaHD.Text}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteClicked?.Invoke(this, _maHD);
            }
        }
    }
}
