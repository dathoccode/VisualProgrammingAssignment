namespace CoffeeHouseABC.Models
{
    public class KhachHang
    {
        public int MaKH { get; set; }
        public string TenTaiKhoan { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string VaiTro { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; }

        public string Email { get; set; } = string.Empty;
        public static KhachHang? CurrentUser { get; set; }
    }
}