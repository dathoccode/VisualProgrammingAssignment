using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_ItemPurchase : UserControl
    {
        public UC_ItemPurchase()
        {
            InitializeComponent();
        }
        public void SetData(string maHD, string ngay, string tongTien, string trangThai)
        {
            lblMaHD.Text = maHD;
            lblNgay.Text = ngay;
            lblTongTien.Text = tongTien;
            lblTrangThai.Text = trangThai;
        }
    }
}
