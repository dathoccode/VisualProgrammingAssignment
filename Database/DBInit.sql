-- Tạo cơ sở dữ liệu
CREATE DATABASE CoffeeHouseABC;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE CoffeeHouseABC;
GO

-- ============================
-- BẢNG KHÁCH HÀNG
-- ============================
CREATE TABLE KHACHHANG (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(100) NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    VaiTro NVARCHAR(50),
    NgayTao DATETIME DEFAULT GETDATE()
);
GO

-- ============================
-- BẢNG SẢN PHẨM
-- ============================
CREATE TABLE SANPHAM (
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenSP NVARCHAR(255) NOT NULL,
    Gia DECIMAL(18,2) NOT NULL,
    HinhAnh NVARCHAR(255),
    MoTa NVARCHAR(500)
);
GO

-- ============================
-- BẢNG ĐƠN HÀNG
-- ============================
CREATE TABLE DONHANG (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    TongTien DECIMAL(18,2),
    TrangThai NVARCHAR(50),
    NgayLap DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
);
GO

-- ============================
-- BẢNG CHI TIẾT ĐƠN HÀNG
-- ============================
CREATE TABLE CHITIETDONHANG (
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGiaBan DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaHD, MaSP),
    FOREIGN KEY (MaHD) REFERENCES DONHANG(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)
);
GO

-- ============================
-- BẢNG ĐÁNH GIÁ
-- ============================
CREATE TABLE DANHGIA (
    MaDG INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    DiemPhucVu INT CHECK (DiemPhucVu BETWEEN 1 AND 5),
    DiemChatLuong INT CHECK (DiemChatLuong BETWEEN 1 AND 5),
    DiemKhongGian INT CHECK (DiemKhongGian BETWEEN 1 AND 5),
    DiemDaDang INT CHECK (DiemDaDang BETWEEN 1 AND 5),
    GopY NVARCHAR(500),
    NgayDanhGia DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
);
GO
