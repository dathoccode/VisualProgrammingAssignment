namespace CoffeeHouseABC.Models
{
    public class DonHang
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; } = string.Empty;
        public DateTime NgayLap { get; set; }
    }
}