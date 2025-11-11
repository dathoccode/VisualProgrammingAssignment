namespace CoffeeHouseABC.Models
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; } = string.Empty;
        public decimal Gia { get; set; }
        public string HinhAnh { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
    }
}