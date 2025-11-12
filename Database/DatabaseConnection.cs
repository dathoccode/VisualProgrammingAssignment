using CoffeeHouseABC.Models;
using Microsoft.Data.SqlClient;

namespace CoffeeHouseABC.Database
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = "Data Source=Datphung;Initial Catalog=CoffeeHouseABC;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public class DatabaseService
    {
        public List<SanPham> GetSanPham()
        {
            List<SanPham> list = new List<SanPham>();

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT MaSP, TenSP, Gia, HinhAnh, MoTa FROM SANPHAM";

                using SqlCommand cmd = new SqlCommand(query, conn);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new SanPham
                    {
                        MaSP = reader.GetInt32(0),
                        TenSP = reader.GetString(1),
                        Gia = reader.GetDecimal(2),
                        HinhAnh = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        MoTa = reader.IsDBNull(4) ? "" : reader.GetString(4)
                    });
                }
            }

            return list;
        }

        public bool Register(string username, string password)
        {
            using SqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            string checkQuery = "SELECT COUNT(*) FROM KHACHHANG WHERE TenTaiKhoan = @User";
            using SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@User", username);

            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
                return false;

            string insertQuery = @"INSERT INTO KHACHHANG (TenTaiKhoan, MatKhau, VaiTro)
                               VALUES (@User, @Pass, 'User')";

            using SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@User", username);
            cmd.Parameters.AddWithValue("@Pass", password);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool DoiMatKhau(int maKH, string newPass)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE KHACHHANG SET MatKhau = @pass WHERE MaKH = @id";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pass", newPass);
                cmd.Parameters.AddWithValue("@id", maKH);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public KhachHang Login(string username, string password)
        {
            using SqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            string query = @"SELECT MaKH, TenTaiKhoan, MatKhau, VaiTro
                         FROM KHACHHANG
                         WHERE TenTaiKhoan = @User AND MatKhau = @Pass";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@User", username);
            cmd.Parameters.AddWithValue("@Pass", password);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new KhachHang
                {
                    MaKH = reader.GetInt32(0),
                    TenTaiKhoan = reader.GetString(1),
                    MatKhau = reader.GetString(2),
                    VaiTro = reader.GetString(3)
                };
            }

            return null;
        }
        public bool ThemDanhGia(int maKH, int pv, int cl, int kg, int dd, string gopy)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO DANHGIA 
                       (MaKH, DiemPhucVu, DiemChatLuong, DiemKhongGian, DiemDaDang, GopY)
                       VALUES (@kh, @pv, @cl, @kg, @dd, @gy)";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@kh", maKH);
                cmd.Parameters.AddWithValue("@pv", pv);
                cmd.Parameters.AddWithValue("@cl", cl);
                cmd.Parameters.AddWithValue("@kg", kg);
                cmd.Parameters.AddWithValue("@dd", dd);
                cmd.Parameters.AddWithValue("@gy", gopy ?? "");

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public string GetTenSanPham(int maSP)
        {
            using SqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            string sql = "SELECT TenSP FROM SANPHAM WHERE MaSP = @maSP";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);

            return cmd.ExecuteScalar()?.ToString() ?? "";
        }
        public int TaoDonHang(int maKH, decimal tongTien, string trangThai, List<ChiTietDonHang> chiTietList)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlHD = @"INSERT INTO DONHANG (MaKH, TongTien, TrangThai, NgayLap)
                             OUTPUT INSERTED.MaHD
                             VALUES (@maKH, @tongTien, @trangThai, GETDATE())";

                    using SqlCommand cmdHD = new SqlCommand(sqlHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@maKH", maKH);
                    cmdHD.Parameters.AddWithValue("@tongTien", tongTien);
                    cmdHD.Parameters.AddWithValue("@trangThai", trangThai);

                    int maHD = (int)cmdHD.ExecuteScalar();

                    foreach (var ct in chiTietList)
                    {
                        string sqlCT = @"INSERT INTO CHITIETDONHANG (MaHD, MaSP, SoLuong, DonGiaBan)
                                 VALUES (@maHD, @maSP, @soLuong, @gia)";
                        using SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@maHD", maHD);
                        cmdCT.Parameters.AddWithValue("@maSP", ct.MaSP);
                        cmdCT.Parameters.AddWithValue("@soLuong", ct.SoLuong);
                        cmdCT.Parameters.AddWithValue("@gia", ct.DonGiaBan);
                        cmdCT.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return maHD;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public bool XoaDonHang(int maHD)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlCT = "DELETE FROM CHITIETDONHANG WHERE MaHD = @maHD";
                    using SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@maHD", maHD);
                    cmdCT.ExecuteNonQuery();

                    string sqlHD = "DELETE FROM DONHANG WHERE MaHD = @maHD";
                    using SqlCommand cmdHD = new SqlCommand(sqlHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@maHD", maHD);
                    int result = cmdHD.ExecuteNonQuery();

                    tran.Commit();
                    return result > 0;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}