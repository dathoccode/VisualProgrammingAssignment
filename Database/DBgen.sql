INSERT INTO KHACHHANG (TenTaiKhoan, MatKhau, VaiTro)
VALUES
('admin', '123456', 'Admin'),
('duc123', '123456', 'User'),
('khanhnguyen', '123456', 'User');

INSERT INTO SANPHAM (TenSP, Gia, HinhAnh, MoTa)
VALUES
(N'Cà phê sữa đá', 25000, 'cfsuada', N'Cà phê pha phin truyền thống'),
(N'Cà phê đen đá', 22000, 'cfden', N'Đậm vị, không đường'),
(N'Trà đào cam sả', 35000, 'tradao', N'Thức uống giải khát'),
(N'Matcha latte', 40000, 'matcha', N'Matcha tươi, sữa thơm'),
(N'Bánh cheesecake', 30000,'cheesecake', N'Bánh mềm mịn'),
(N'Cà phê trứng', 350000, 'matcha', N'Vị như trứng'),
(N'Bạc xỉu', 20000,'cheesecake', N'Phù hợp với trẻ con');


INSERT INTO DONHANG (MaKH, TongTien, TrangThai)
VALUES
(1, 75000, N'Hoàn thành'),
(2, 40000, N'Hoàn thành'),
(3, 65000, N'Đang xử lý');

INSERT INTO CHITIETDONHANG (MaHD, MaSP, SoLuong, DonGiaBan)
VALUES
(1, 1, 1, 35000),
(1, 3, 1, 40000),
(2, 5, 1, 25000),
(3, 2, 1, 42000),
(3, 4, 1, 30000);

INSERT INTO DANHGIA (MaKH, DiemPhucVu, DiemChatLuong, DiemKhongGian, DiemDaDang, GopY)
VALUES
(1, 5, 5, 4, 5, N'Quán ổn, nhân viên thân thiện'),
(2, 4, 4, 4, 4, N'Ổn, nhưng phục vụ hơi chậm'),
(3, 5, 5, 5, 5, N'Tuyệt vời');

