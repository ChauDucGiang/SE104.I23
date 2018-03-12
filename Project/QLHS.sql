CREATE TABLE Lop
(
	MaLop INT PRIMARY KEY,
	TenLop NVARCHAR(100),
	SiSo INT,
	LoaiLop INT
)
GO 
CREATE TABLE HocSinh
(
	MaHS INT PRIMARY KEY,
	HoTen NVARCHAR(100),
	GioiTinh NVARCHAR(100),
	NgSinh DATE,
	NoiSinh NVARCHAR(100),
	DienThoai NVARCHAR(100),
	Email NVARCHAR(100),
	DiaChi NVARCHAR(100),
	MaLop int

	FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
)
GO
CREATE TABLE MonHoc
(
	MaMH INT PRIMARY KEY,
	TenMon NVARCHAR(100),
	MaHS INT,
	HeSoMon int
	FOREIGN KEY (MaHS) REFERENCES dbo.HocSinh(MaHS)
)
GO
CREATE TABLE LoaiDiem
(
	MaLoaiDiem INT PRIMARY KEY,
	TenLoaiDiem NVARCHAR(100),
	HeSo FLOAT
)
GO
CREATE TABLE Account
(
	ID INT PRIMARY KEY,
	UserName NVARCHAR(100),
	PassWord NVARCHAR(100),
	DisplayName NVARCHAR(100)
)
GO
CREATE TABLE HanhKiem
(
	MaHK INT,
	LoaiHK NVARCHAR(10)
	PRIMARY KEY (MaHK)
)
GO
CREATE TABLE ThoiGian
(
	NamHoc NVARCHAR(50),
	HocKi INT
	CONSTRAINT PK_TG PRIMARY KEY(NamHoc,HocKi)
)
GO
CREATE TABLE BangDiem
(
	ID INT PRIMARY KEY,
	MaHS INT,
	MaMon INT,
	MaLop INT,
	MaLoaiDiem INT,
	Diem FLOAT,
	HocKi INT,
	NamHoc NVARCHAR(50),
	MaHK INT
	FOREIGN KEY(MaMon) REFERENCES dbo.MonHoc(MaMH),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLoaiDiem) REFERENCES dbo.LoaiDiem(MaLoaiDiem),
	CONSTRAINT FK_ThoiGian FOREIGN KEY (HocKi,NamHoc) REFERENCES ThoiGian(HocKi,NamHoc),
	FOREIGN KEY(MaHK) REFERENCES dbo.HanhKiem(MaHK),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop)
)
GO 