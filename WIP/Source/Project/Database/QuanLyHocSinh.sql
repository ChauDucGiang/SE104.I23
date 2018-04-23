------------------------------------------------------------------------------------------
CREATE DATABASE QuanLyHocSinh
USE QuanLyHocSinh
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(100) DEFAULT 0,
	TenNguoiDung NVARCHAR(100),
	DisplayName NVARCHAR(100),
	Type NVARCHAR(50)
)

GO	
INSERT INTO	dbo.Account
        ( UserName ,
          PassWord ,
          TenNguoiDung ,
          DisplayName ,
          Type
        )
VALUES  ( N'admin' , -- UserName - nvarchar(100)
          N'admin' , -- PassWord - nvarchar(100)
          N'Admin' , -- TenNguoiDung - nvarchar(100)
          N'Admin' , -- DisplayName - nvarchar(100)
          N'Admin'  -- Type - nvarchar(50)
        )

GO
INSERT INTO dbo.Account
        ( UserName ,
          PassWord ,
          TenNguoiDung ,
          DisplayName
        )
VALUES  ( N'duc' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          N'Phạm Thanh Đức' , -- TenNguoiDung - nvarchar(100)
          N'Thanh Đức'  -- DisplayName - nvarchar(100)
        )
INSERT INTO dbo.Account
        ( UserName ,
          PassWord ,
          TenNguoiDung ,
          DisplayName
        )
VALUES  ( N'cong' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          N'Nguyễn Thành Công' , -- TenNguoiDung - nvarchar(100)
          N'Thành Công'  -- DisplayName - nvarchar(100)
        )
GO
--------------------------------------------------------------------------------------------
CREATE TABLE BangDiem
(
	ID INT PRIMARY KEY,
	MaHS INT,
	MaLop INT,
	MaCotDiem VARCHAR(10),
	Diem FLOAT,
	HocKi INT,
	NamHoc NVARCHAR(50),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaCotDiem) REFERENCES dbo.CotDiem(MaCotDiem),
	CONSTRAINT FK_ThoiGian FOREIGN KEY (NamHoc) REFERENCES dbo.ThoiGian(NamHoc),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop)
)
GO
-------------------------------------------------------------------------------------------
CREATE TABLE ThoiGian
(
	NamHoc NVARCHAR(50) PRIMARY KEY,
	HocKi INT
)
GO
-------------------------------------------------------------------------------------
CREATE TABLE CotDiem
(
	MaCotDiem VARCHAR(10) PRIMARY KEY,
	TenCotDiem NVARCHAR(50),
	MaLoaiDiem VARCHAR(10)
	FOREIGN KEY(MaLoaiDiem) REFERENCES dbo.LoaiDiem(MaLoaiDiem)
)
GO
----------------------------------------------------------------------------------
CREATE TABLE CTBD
(
	MaMH INT,
	IDBangDiem INT
	CONSTRAINT PK_CTHD PRIMARY KEY(MaMH,IDBangDiem)
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH),
	FOREIGN KEY(IDBangDiem) REFERENCES dbo.BangDiem(ID)
)
GO
-----------------------------------------------------------------------------------
CREATE TABLE HanhKiem
(
	MaHK INT,
	LoaiHK NVARCHAR(10)
	PRIMARY KEY (MaHK)
)
GO
---------------------------------------------------------------------------------
CREATE TABLE HocLuc
(
	MaHocLuc VARCHAR(10) PRIMARY KEY,
	TenHocLuc NVARCHAR(50),
	DiemToiDa FLOAT,
	DiemToiThieu FLOAT,
	DiemKhongChe FLOAT
)
GO
---------------------------------------------------------------------------------
CREATE TABLE HocSinh
(
	MaHS INT PRIMARY KEY,
	HinhAnh IMAGE,
	HoTen NVARCHAR(100),
	GioiTinh NVARCHAR(100),
	NgSinh DATE,
	NoiSinh NVARCHAR(100),
	DienThoai NVARCHAR(100),
	Email NVARCHAR(100),
	DiaChi NVARCHAR(100),
	CheckInClass INT
)
GO
--------------------------------------------------------------------------------
CREATE TABLE KetQua
(
	MaKQ VARCHAR(10) PRIMARY KEY,
	TenKQ NVARCHAR(50)
)
GO
--------------------------------------------------------------------------------
CREATE TABLE KetQua_HocKi_MonHoc
(
	MaHS INT,
	MaLop INT,
	MaMH INT,
	MaNamHoc NVARCHAR(50),
	DTBMonHocKi FLOAT
	CONSTRAINT PK_KQ_HK_MH PRIMARY KEY(MaHS,MaLop,MaMH,MaNamHoc)
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH),
	FOREIGN KEY (MaNamHoc) REFERENCES dbo.ThoiGian(NamHoc)
)
GO
---------------------------------------------------------------------------------
CREATE TABLE KQ_CaNam_MonHoc
(
	MaHS INT,
	MaLop INT,
	NamHoc NVARCHAR(50),
	MaMH INT,
	MaKQ VARCHAR(10)
	CONSTRAINT PK_KQ_CaNam_MH PRIMARY KEY(MaHS,MaMH),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(NamHoc) REFERENCES dbo.ThoiGian(NamHoc),
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH),
	FOREIGN KEY(MaKQ) REFERENCES dbo.KetQua(MaKQ)
)
GO
-----------------------------------------------------------------------------
CREATE TABLE KQ_TongHop
(
	MaHS INT,
	MaLop INT,
	NamHoc NVARCHAR(50),
	MaHocLuc VARCHAR(10),
	MaHK INT,
	DiemTBNam FLOAT
	CONSTRAINT PK_KQ_TongHop PRIMARY KEY(MaHS,NamHoc)
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(NamHoc) REFERENCES dbo.ThoiGian(NamHoc),
	FOREIGN KEY(MaHK) REFERENCES dbo.HanhKiem(MaHK),
	FOREIGN KEY(MaHocLuc) REFERENCES dbo.HocLuc(MaHocLuc)
)
GO
------------------------------------------------------------------------------
CREATE TABLE KhoiLop
(
	MaKhoiLop NVARCHAR(50) PRIMARY KEY,
	TenKhoiLop NVARCHAR(50),
)
GO 
------------------------------------------------------------------------------
CREATE TABLE LoaiDiem
(
	MaLoaiDiem VARCHAR(10) PRIMARY KEY,
	TenLoaiDiem NVARCHAR(100),
	HeSo FLOAT DEFAULT 1
)
GO
--------------------------------------------------------------------------------
CREATE TABLE Lop
(
	MaLop INT PRIMARY KEY,
	TenLop NVARCHAR(100),
	SiSo INT,
	LoaiLop INT DEFAULT 0, --0: lớp thường, 1: lớp chuyên
	MaKhoiLop NVARCHAR(50)
	FOREIGN KEY (MaKhoiLop) REFERENCES dbo.KhoiLop(MaKhoiLop)
)
GO
-----------------------------------------------------------------------------------------
CREATE TABLE MonHoc
(
	MaMH INT PRIMARY KEY,
	TenMon NVARCHAR(100),
	HeSoMon INT DEFAULT 1
)
GO
---------------------------------------------------------------------------------------------------
CREATE TABLE ThoiGian
(
	NamHoc NVARCHAR(50) PRIMARY KEY,
	HocKi INT
)
GO
--------------------------------------------------------------------------------------------------
CREATE TABLE XepLop
(
	MaLop INT,
	MaHS INT,
	Namhoc NVARCHAR(50),
	CONSTRAINT PK_XL PRIMARY KEY(MaLop,MaHS),
	FOREIGN KEY (MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY (MaHS) REFERENCES dbo.HocSinh(MaHS),
	CONSTRAINT FK_XLTime FOREIGN KEY (Namhoc) REFERENCES dbo.ThoiGian(NamHoc)
)
GO
--------------------------------------------------------------------------------------------------------------------------
--Login
CREATE PROC USP_User_Login
@userName NVARCHAR(100),
@passWord NVARCHAR(100)
AS
	BEGIN
		SELECT dbo.Account.UserName,dbo.Account.PassWord FROM dbo.Account WHERE UserName=@userName AND	PassWord = @passWord
	END	
GO

EXEC dbo.USP_User_Login @userName = N'', -- nvarchar(100)
    @passWord = N'' -- nvarchar(100)
	