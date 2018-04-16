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
-----------------------------------------------------------------------------------------
CREATE TABLE GiaoVien
(
	MaGV VARCHAR(10) PRIMARY KEY,
	TenGV NVARCHAR(100),
	SDT VARCHAR(50),
	DiaChi NVARCHAR(100),
	MaMH VARCHAR(10)
	FOREIGN KEY (MaMH) REFERENCES dbo.MonHoc(MaMH)
)
-----------------------------------------------------------------------------------------
CREATE TABLE MonHoc
(
	MaMH VARCHAR(10) PRIMARY KEY,
	TenMon NVARCHAR(100),
	HeSoMon INT DEFAULT 1
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
	MaLop VARCHAR(50) PRIMARY KEY,
	TenLop NVARCHAR(100),
	SiSo INT,
	LoaiLop INT DEFAULT 0, --0: lớp thường, 1: lớp chuyên
	MaKhoiLop NVARCHAR(50)
	FOREIGN KEY (MaKhoiLop) REFERENCES dbo.KhoiLop(MaKhoiLop)
)
GO
ALTER TABLE dbo.Lop ADD NamHoc NVARCHAR(50)
ALTER TABLE dbo.Lop ADD CONSTRAINT FK_L_NH FOREIGN KEY(NamHoc) REFERENCES dbo.NamHoc(MaNamHoc)
ALTER TABLE dbo.Lop ADD GVCN VARCHAR(10)
ALTER TABLE dbo.Lop ADD CONSTRAINT FK_L_GV FOREIGN KEY(GVCN) REFERENCES dbo.GiaoVien(MaGV)
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
CREATE TABLE CotDiem
(
	MaCotDiem VARCHAR(10) PRIMARY KEY,
	TenCotDiem NVARCHAR(50),
	MaLoaiDiem VARCHAR(10)
	FOREIGN KEY(MaLoaiDiem) REFERENCES dbo.LoaiDiem(MaLoaiDiem)
)
GO

--------------------------------------------------------------------------------------------
CREATE TABLE BangDiem
(
	ID INT PRIMARY KEY,
	MaHS INT,
	MaLop VARCHAR(50),
	MaCotDiem VARCHAR(10),
	Diem FLOAT,
	HocKi INT,
	NamHoc NVARCHAR(50),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaCotDiem) REFERENCES dbo.CotDiem(MaCotDiem),
	CONSTRAINT FK_ThoiGian FOREIGN KEY (NamHoc) REFERENCES dbo.ThoiGian(NamHoc),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop)
)
----------------------------------------------------------------------------------
CREATE TABLE CTBD
(
	MaMH VARCHAR(10),
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
	MaLop VARCHAR(50),
	MaMH VARCHAR(10),
	MaNamHoc NVARCHAR(50),
	DTBMonHocKi FLOAT
	CONSTRAINT PK_KQ_HK_MH PRIMARY KEY(MaHS,MaLop,MaMH,MaNamHoc)
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH),
	FOREIGN KEY (MaNamHoc) REFERENCES dbo.ThoiGian(NamHoc)
)
GO
ALTER TABLE dbo.KetQua_HocKi_MonHoc ADD HocKi INT
---------------------------------------------------------------------------------
CREATE TABLE KQ_CaNam_MonHoc
(
	MaHS INT,
	MaLop VARCHAR(50),
	NamHoc NVARCHAR(50),
	MaMH VARCHAR(10),
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
	MaLop VARCHAR(50),
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
--------------------------------------------------------------------------------------------------
CREATE TABLE XepLop
(
	MaLop VARCHAR(50),
	MaHS INT,
	Namhoc NVARCHAR(50),
	CONSTRAINT PK_XL PRIMARY KEY(MaLop,MaHS),
	FOREIGN KEY (MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY (MaHS) REFERENCES dbo.HocSinh(MaHS),
	CONSTRAINT FK_XLTime FOREIGN KEY (Namhoc) REFERENCES dbo.NamHoc(NamHoc)
)
GO
--------------------------------------------------------------------------------------------------------------------------
CREATE TABLE NamHoc
(
	MaNamHoc NVARCHAR(50) PRIMARY KEY,
	TenNamHoc NVARCHAR(100)
)
GO
ALTER TABLE dbo.XepLop ADD CONSTRAINT FK_NH_XL FOREIGN KEY(Namhoc) REFERENCES dbo.NamHoc(MaNamHoc)
ALTER TABLE dbo.KQ_TongHop ADD CONSTRAINT FK_TH_NH FOREIGN KEY (NamHoc) REFERENCES dbo.NamHoc(MaNamHoc)
ALTER TABLE dbo.KQ_CaNam_MonHoc ADD CONSTRAINT FK_CN_NH FOREIGN KEY(NamHoc) REFERENCES dbo.NamHoc(MaNamHoc)
ALTER TABLE dbo.KetQua_HocKi_MonHoc ADD CONSTRAINT FK_KQHK_NH FOREIGN KEY(MaNamHoc) REFERENCES dbo.NamHoc(MaNamHoc)
--------------------------------------------------------------------------------------------------------------------------
CREATE TABLE HocKi
(
	MaHocKi INT PRIMARY KEY,
	TenHocKi NVARCHAR(50)
)
GO
ALTER TABLE dbo.KetQua_HocKi_MonHoc ADD CONSTRAINT FK_HK_KQ FOREIGN KEY(HocKi) REFERENCES dbo.HocKi(MaHocKi)
ALTER TABLE dbo.BangDiem ADD CONSTRAINT FK_BD_HK FOREIGN KEY (HocKi) REFERENCES dbo.HocKi(MaHocKi)
ALTER TABLE dbo.HocKi ADD HeSo INT DEFAULT 1
---------------------------------------------------------------------------------------------------------------------------
--Login
CREATE PROC USP_User_Login
@userName NVARCHAR(100),
@passWord NVARCHAR(100)
AS
	BEGIN
		SELECT dbo.Account.UserName,dbo.Account.PassWord FROM dbo.Account WHERE UserName=@userName AND	PassWord = @passWord
	END	
GO
--Them Hoc Sinh
CREATE PROC USP_ThemHocSinh
@mahs INT, @hoten NVARCHAR(100), @gioitinh NVARCHAR(100),
@ngaysinh DATE,@noisinh NVARCHAR(100), @dienthoai NVARCHAR(100),
@email NVARCHAR(100),@diachi NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.HocSinh
	        ( MaHS ,
	          HoTen ,
	          GioiTinh ,
	          NgSinh ,
	          NoiSinh ,
	          DienThoai ,
	          Email ,
	          DiaChi ,
	          CheckInClass
	        )
	VALUES  ( @mahs , -- MaHS - int
	          @hoten , -- HoTen - nvarchar(100)
	          @gioitinh , -- GioiTinh - nvarchar(100)
	          @ngaysinh , -- NgSinh - date
	          @noisinh , -- NoiSinh - nvarchar(100)
	          @dienthoai , -- DienThoai - nvarchar(100)
	          @email , -- Email - nvarchar(100)
	          @diachi , -- DiaChi - nvarchar(100)
	          0  -- CheckInClass - int
	        )
END
GO

--Them Nam Hoc
CREATE PROC USP_ThemNamHoc
@manamhoc nvarchar(50), @tennamhoc NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.NamHoc
	        ( MaNamHoc, TenNamHoc )
	VALUES  ( @manamhoc, -- MaNamHoc - nvarchar(50)
	          @tennamhoc -- TenNamHoc - nvarchar(100)
	          )
END
GO
-- Xoa Nam hoc
CREATE PROC USP_XoaNamHoc
@manamhoc NVARCHAR(50)
AS
BEGIN
	DELETE dbo.NamHoc WHERE MaNamHoc=@manamhoc
END
GO

-- Thêm Lớp
ALTER PROC ThemLop
@malop VARCHAR(50), @tenlop NVARCHAR(100),@makhoilop NVARCHAR(50),
@namhoc NVARCHAR(50),@gvcn VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.Lop
	        ( MaLop ,
	          TenLop ,
	          SiSo ,
	          LoaiLop ,
	          MaKhoiLop ,
	          NamHoc ,
	          GVCN
	        )
	VALUES  ( @malop , -- MaLop - varchar(50)
	          @tenlop , -- TenLop - nvarchar(100)
	          0 , -- SiSo - int
	          0 , -- LoaiLop - int
	          @makhoilop , -- MaKhoiLop - nvarchar(50)
	          @namhoc , -- NamHoc - nvarchar(50)
	          @gvcn  -- GVCN - varchar(10)
	        )
END
GO
 
EXEC ThemLop @malop , @tenlop , @makhoilop , @namhoc , @gvcn
--
