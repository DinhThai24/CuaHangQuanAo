CREATE DATABASE DATA_QUANAO
GO
USE DATA_QUANAO
GO
drop DATABASE DATA_QUANAO

CREATE TABLE Loai(
	MaLoai char(10) PRIMARY KEY NOT NULL,
	TenLoai nvarchar(50) NULL,
) 
GO
CREATE TABLE SanPham
(
	MaQA char(10) PRIMARY KEY NOT NULL,
	TenQA nvarchar(50) NULL,
	Size int NULL,
	GiaBan float NULL,
	MaLoai char(10) NULL,
	SoLuong int,
	FOREIGN KEY(MaLoai) REFERENCES Loai(MaLoai)
)
GO
CREATE TABLE KhachHang
(
	MaKH char(10) PRIMARY KEY NOT NULL,
	TenKH nvarchar(50) NULL,
	SDT char(11) NULL,
	DiaChi nvarchar(50) NULL,
	Email nvarchar(50) NULL,
	TenTK varchar(20) NULL,
	FOREIGN KEY(TenTK) REFERENCES TaiKhoan(TenTK)
)
GO

CREATE TABLE TaiKhoan (
	TenTK VARCHAR(20) PRIMARY KEY,
	MatKhau VARCHAR(20) NOT NULL,
	PhanQuyen NVARCHAR(30)
);
GO

CREATE TABLE NhanVien (
	MaNV CHAR(10),
	TenNV NVARCHAR(50) NULL,
	SDT CHAR(11) NULL,
	Email NVARCHAR(50) NULL,
	TenTK VARCHAR(20) NOT NULL,
	PRIMARY KEY (MaNV),
	FOREIGN KEY(TenTK) REFERENCES TaiKhoan(TenTK)
);
GO

CREATE TABLE HoaDon
(
	MaHD char(10) PRIMARY KEY NOT NULL,
	MaNV char(10),
	MaKH char(10),
	NgayLap date,
	TongTien float,
	FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
	FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
)
GO
CREATE TABLE ChiTietHD
(
	MaHD char(10)  NOT NULL,
	MaQA char(10)  NOT NULL ,
	SoLuong int ,
	GiaBan float,
	PRIMARY KEY(MaHD,MaQA),
	FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
	FOREIGN KEY(MaQA) REFERENCES SanPham(MaQA)
)
GO
CREATE TABLE PhieuNhap
(
	MaPN char(10) PRIMARY KEY NOT NULL,
	MaNV char(10),
	NgayNhap date,
	TongTien float,
	FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
)
GO
CREATE TABLE ChiTietPN
(
	MaPN char(10)  NOT NULL,
	MaQA char(10)  NOT NULL ,
	SoLuong int ,
	GiaNhap float,
	PRIMARY KEY(MaPN,MaQA),
	FOREIGN KEY(MaPN) REFERENCES PhieuNhap(MaPN),
	FOREIGN KEY(MaQA) REFERENCES SanPham(MaQA)
)
GO
				--------------- Xem-------------------
select * from HoaDon
select * from ChiTietHD
select * from KhachHang
select * from Loai
select * from NhanVien
select * from SanPham
select * from PhieuNhap
select * from ChiTietPN

					--------------- Xóa-------------------
Delete HoaDon
Delete ChiTietHD
Delete KhachHang
Delete Loai
Delete NhanVien
Delete SanPham
Delete PhieuNhap
Delete ChiTietPN

Drop table HoaDon
Drop table ChiTietHD
Drop table PhieuNhap
Drop table ChiTietPN
Drop table KhachHang
Drop table Loai
Drop table NhanVien
Drop table SanPham
Drop table TaiKhoan

					--------------- Thêm-------------------
		------- Loai ------- 
INSERT INTO LOAI VALUES
('L01',N'Áo thun'),
('L02',N'Áo voan'),
('L03',N'Áo sơ mi'),
('L04',N'Áo sweater'),
('L05',N'Chân váy'),
('L06',N'Hoodies'),
('L07',N'Áo ấm'),
('L08',N'Quần jean'),
('L09',N'Quần Kaki'),
('L10',N'Váy')
       --------TaiKhoan------------
INSERT INTO TaiKhoan VALUES
('dat','123',N'Nhân Viên'),
('binh','123',N'Nhân Viên'),
('phuoc','123',N'Nhân Viên'),
('dinh','123',N'Nhân Viên'),
('khoi','123',N'Nhân Viên'),
('admin','123',N'Admin'),
('Anh','123',N'Khách hàng')

select * from TaiKhoan
       --------SanPham------------
INSERT INTO SanPham 
VALUES
('SP01', N'Áo thun unisex', 10, 160, 'L01',30),
('SP02', N'Quần short', 10, 130, 'L01',30),
('SP03', N'Áo voan nữ', 8, 220, 'L02',30),
('SP04', N'Quần jogger', 8, 180, 'L02',30),
('SP05', N'Áo sơ mi Hawaii', 9, 190, 'L03',30),
('SP06', N'Quần chinos', 9, 200, 'L03',30),
('SP07', N'Áo sơ mi tropical', 7, 140, 'L04',30),
('SP08', N'Quần tây âu', 7, 280, 'L04',30),
('SP09', N'Chân váy xẻ', 12, 120, 'L05',30),
('SP10', N'Chân váy Jean', 12, 180, 'L05',30),
('SP11', N'Áo khoác gió', 5, 250, 'L06',30),
('SP12', N'Quần dù', 5, 140, 'L06',30),
('SP13', N'Áo hoodie', 6, 320, 'L07',30),
('SP14', N'Quần thun', 6, 170, 'L07',30),
('SP15', N'Áo trễ vai', 11, 240, 'L08',30),
('SP16', N'Quần Jean ống loe', 11, 160, 'L08',30),
('SP17', N'Áo polo', 4, 230, 'L09',30),
('SP18', N'Quần kaki', 4, 260, 'L09',30),
('SP19', N'Váy body', 14, 200, 'L10',30),
('SP20', N'Váy dài', 14, 240, 'L10',30)
          
		 --------KhachHang-------------
INSERT INTO KhachHang 
VALUES
('KH001', N'Nguyễn Văn Anh', '01234567890', N'123 Trần Phú, TP.HCM', 'a@gmail.com','Anh')

--------------------NhanVien---------------------------------

INSERT INTO NhanVien 
VALUES
('NV1', N'Trương Phước', '0123435690', 'phuoc@gmail.com','phuoc'),
('NV2', N'Tạ Minh Khôi', '0987343210', 'khoi@gmail.com','khoi'),
('NV3', N'Nguyễn Thái Đỉnh', '0112674455', 'dinh@gmail.com','dinh'),
('NV4', N'Trần Trung Đạt', '0334455457', 'dat@gmail.com','dat'),
('NV5', N'Thạch Thái Bình', '0445523788', 'binh@gmail.com','binh')

select * from KhachHang where MaKH = 'KH001'


------------------HoaDon----------------------



SELECT * FROM HoaDon WHERE MONTH(NgayLap) = 5 AND YEAR(NgayLap) = 2023
SELECT * FROM HoaDon WHERE YEAR(NgayLap) = 2023

SELECT SUM(TongTien) AS TongDoanhThu FROM HoaDon WHERE MONTH(NgayLap) = 5 AND YEAR(NgayLap) = 2023


SELECT SUM(TongTien) AS TongDoanhThu
FROM HoaDon
WHERE DAY(NgayLap) = 17 AND MONTH(NgayLap) = 5 AND YEAR(NgayLap) = 2023

CREATE TRIGGER CapNhatSLSauChiTietHD
ON ChiTietHD
AFTER INSERT
AS
BEGIN
    -- Cập nhật SoLuong trong bảng SanPham
    UPDATE SanPham
    SET SoLuong = SanPham.SoLuong - i.SoLuong
    FROM SanPham
    INNER JOIN inserted i ON SanPham.MaQA = i.MaQA;
END;

CREATE TRIGGER TinhTongTien
ON ChiTietHD
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật TongTien trong bảng HoaDon
    UPDATE HoaDon
    SET TongTien = (
        SELECT SUM(ChiTietHD.SoLuong * SanPham.GiaBan)
        FROM ChiTietHD
        INNER JOIN SanPham ON ChiTietHD.MaQA = SanPham.MaQA
        WHERE ChiTietHD.MaHD = HoaDon.MaHD
    )
    FROM HoaDon
    INNER JOIN inserted i ON HoaDon.MaHD = i.MaHD;
END;

CREATE TRIGGER CapNhatSLSauKhiNhap
ON ChiTietPN
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật số lượng trong bảng SanPham
    UPDATE SanPham
    SET SoLuong = SanPham.SoLuong + (
        SELECT SoLuong
        FROM ChiTietPN
        WHERE ChiTietPN.MaQA = SanPham.MaQA
    )
    FROM SanPham
    INNER JOIN inserted i ON SanPham.MaQA = i.MaQA;
END;

-- Tạo trigger sau khi chèn mới hoặc cập nhật vào bảng ChiTietPN
CREATE TRIGGER TinhTongTienNhap
ON ChiTietPN
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật TongTien trong bảng PhieuNhap
    UPDATE PhieuNhap
    SET TongTien = (
        SELECT SUM(SoLuong * GiaNhap)
        FROM ChiTietPN
        WHERE ChiTietPN.MaPN = PhieuNhap.MaPN
    )
    FROM PhieuNhap
    INNER JOIN inserted i ON PhieuNhap.MaPN = i.MaPN;
END;



