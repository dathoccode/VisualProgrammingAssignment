namespace CoffeeHouseABC.Models
{
    public class DanhGia
    {
        public int MaDG { get; set; }
        public int MaKH { get; set; }
        public int DiemPhucVu { get; set; }
        public int DiemChatLuong { get; set; }
        public int DiemKhongGian { get; set; }
        public int DiemDaDang { get; set; }
        public string GopY { get; set; } = string.Empty;
        public DateTime NgayDanhGia { get; set; }
    }
}