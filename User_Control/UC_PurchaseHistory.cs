using System;
using System.Windows.Forms;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Utils;
using Microsoft.Data.SqlClient;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_PurchaseHistory : UserControl
    {
        private bool _isLoaded = false;

        public UC_PurchaseHistory()
        {
            InitializeComponent();
        }

        private void UC_PurchaseHistory_Load(object sender, EventArgs e)
        {
            if (!_isLoaded)
            {
                LoadPurchaseHistory();
                _isLoaded = true;
            }
        }

        public void LoadPurchaseHistory()
        {
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi xem lịch sử mua hàng.");
                return;
            }

            int maKH = SessionManager.CurrentUser.MaKH;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT MaHD, NgayLap, TongTien, TrangThai 
                        FROM DONHANG
                        WHERE MaKH = @maKH
                        ORDER BY NgayLap DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@maKH", maKH);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.SuspendLayout();
                            flowLayoutPanel1.Controls.Clear();

                            bool hasData = false;

                            while (reader.Read())
                            {
                                hasData = true;
                                string maHD = reader["MaHD"].ToString();
                                string ngay = Convert.ToDateTime(reader["NgayLap"]).ToString("dd/MM/yyyy");
                                string tong = string.Format("{0:N0}", reader["TongTien"]);
                                string tt = reader["TrangThai"].ToString();

                                var item = new UC_ItemPurchase();
                                item.SetData(maHD, ngay, tong, tt);
                                item.DeleteClicked += Item_DeleteClicked;
                                flowLayoutPanel1.Controls.Add(item);
                            }

                            if (!hasData)
                            {
                                Label lbl = new Label()
                                {
                                    Text = "Bạn chưa có đơn hàng nào.",
                                    AutoSize = true,
                                    Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Italic),
                                    ForeColor = System.Drawing.Color.Gray,
                                    Padding = new Padding(10)
                                };
                                flowLayoutPanel1.Controls.Add(lbl);
                            }

                            flowLayoutPanel1.ResumeLayout();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử mua hàng: " + ex.Message);
            }
        }

        private void Item_DeleteClicked(object? sender, int maHD)
        {
            try
            {
                DatabaseService db = new DatabaseService();
                bool success = db.XoaDonHang(maHD);

                if (success)
                {
                    MessageBox.Show("Xóa đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPurchaseHistory();
                }
                else
                {
                    MessageBox.Show("Không thể xóa đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
