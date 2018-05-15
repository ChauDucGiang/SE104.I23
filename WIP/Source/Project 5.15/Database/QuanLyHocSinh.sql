------------------------------------------------------------------------------------------
CREATE DATABASE QuanLyHocSinh
USE QuanLyHocSinh
CREATE TABLE QuyDinhTruong
(
	MaTruong VARCHAR(50) PRIMARY KEY,
	TenTruong NVARCHAR(100),
	SiSoMax VARCHAR(10),
	SiSoMin VARCHAR(10),
	AgeMax VARCHAR(10),
	AgeMin VARCHAR(10),
	DiemDat VARCHAR(10),
)
GO
INSERT INTO dbo.QuyDinhTruong
        ( MaTruong ,
          TenTruong ,
          SiSoMax ,
          SiSoMin ,
          AgeMax ,
          AgeMin ,
          DiemDat
        )
VALUES  ( 'THPT_BCCD' , -- MaTruong - varchar(50)
          N'Trường THPT BCCD' , -- TenTruong - nvarchar(100)
          '40' , -- SiSoMax - varchar(10)
          '0' , -- SiSoMin - varchar(10)
          '20' , -- AgeMax - varchar(10)
          '15' , -- AgeMin - varchar(10)
          '5'  -- DiemDat - varchar(10)
        )
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
	MaHS VARCHAR(10) PRIMARY KEY,
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
--CREATE TABLE LoaiDiem
--(
--	MaLoaiDiem VARCHAR(10) PRIMARY KEY,
--	TenLoaiDiem NVARCHAR(100),
--	HeSo FLOAT DEFAULT 1
--)
--GO
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
-------------------------------------------------------------------------------------
CREATE TABLE CotDiem
(
	MaCotDiem VARCHAR(10) PRIMARY KEY,
	TenCotDiem NVARCHAR(50),
	HeSo INT
)
GO

--------------------------------------------------------------------------------------------
CREATE TABLE BangDiem
(
	ID INT PRIMARY KEY,
	MaHS VARCHAR(50),
	MaLop NVARCHAR(100),
	MaCotDiem VARCHAR(10),
	Diem FLOAT,
	HocKi INT,
	NamHoc NVARCHAR(50),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaCotDiem) REFERENCES dbo.CotDiem(MaCotDiem),
	CONSTRAINT FK_BangDiem_NamHoc FOREIGN KEY (NamHoc) REFERENCES dbo.NamHoc(MaNamHoc),
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
	MaHS VARCHAR(50),
	MaLop NVARCHAR(100),
	MaMH VARCHAR(10),
	MaNamHoc NVARCHAR(50),
	DTBMonHocKi FLOAT
	CONSTRAINT PK_KQ_HK_MH PRIMARY KEY(MaHS,MaLop,MaMH,MaNamHoc)
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH),
	FOREIGN KEY (MaNamHoc) REFERENCES dbo.NamHoc(MaNamHoc)
)
GO
ALTER TABLE dbo.KetQua_HocKi_MonHoc ADD HocKi INT
---------------------------------------------------------------------------------
CREATE TABLE KQ_CaNam_MonHoc
(
	MaHS VARCHAR(50),
	MaLop NVARCHAR(100),
	NamHoc NVARCHAR(50),
	MaMH VARCHAR(10),
	DTBMonCaNam FLOAT
	CONSTRAINT PK_KQ_CaNam_MH PRIMARY KEY(MaHS,MaMH,NamHoc),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(NamHoc) REFERENCES dbo.NamHoc(MaNamHoc),
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH)
)
GO
-----------------------------------------------------------------------------
CREATE TABLE KQ_TongHop
(
	MaHS VARCHAR(50),
	MaLop NVARCHAR(100),
	NamHoc NVARCHAR(50),
	MaHocLuc VARCHAR(10),
	MaHK VARCHAR(10),
	DiemTBNam FLOAT
	CONSTRAINT PK_KQ_TongHop PRIMARY KEY(MaHS,NamHoc,MaLop)
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(NamHoc) REFERENCES dbo.NamHoc(MaNamHoc),
	FOREIGN KEY(MaHK) REFERENCES dbo.HanhKiem(MaHK),
	FOREIGN KEY(MaHocLuc) REFERENCES dbo.HocLuc(MaHocLuc)
)
GO
----------------------------------------------------------------------------------------------
CREATE TABLE KQ_HocKi_TongHop
(
	MaHS VARCHAR(50),
	MaLop NVARCHAR(100),
	MaHocKi INT,
	NamHoc NVARCHAR(50),
	MaHocLuc VARCHAR(10),
	MaHK VARCHAR(10),
	DiemTBHocKi FLOAT
	CONSTRAINT PK_KQ_HocKi_TongHop PRIMARY KEY(MaHS,MaLop,MaHocKi,NamHoc)
	FOREIGN KEY (MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop),
	FOREIGN KEY(MaHocKi) REFERENCES dbo.HocKi(MaHocKi),
	FOREIGN KEY(NamHoc) REFERENCES dbo.NamHoc(MaNamHoc),
	FOREIGN KEY(MaHocLuc) REFERENCES dbo.HocLuc(MaHocLuc),
	FOREIGN KEY (MaHK) REFERENCES dbo.HanhKiem(MaHK)
)
GO

--------------------------------------------------------------------------------------------------
CREATE TABLE XepLop
(
	MaLop VARCHAR(50),
	MaHS VARCHAR(50),
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
	TenHocKi NVARCHAR(50),
	HeSo int
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
--Lay danh sach hoc sinh
CREATE PROC USP_GetHocSinh
AS
BEGIN
	SELECT dbo.HocSinh.MaHS,HoTen,GioiTinh,NgSinh,NoiSinh,DienThoai,Email,DiaChi,TenLop 
	FROM (HocSinh LEFT JOIN XepLop on HocSinh.MaHS = XepLop.MaHS) LEFT JOIN dbo.Lop ON Lop.MaLop = XepLop.MaLop
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
--Sửa năm học
CREATE PROC USP_SuaNamHoc
@tennh NVARCHAR(100),@manh NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.NamHoc SET TenNamHoc=@tennh WHERE MaNamHoc=@manh
END
GO
-- Thêm Lớp
CREATE PROC ThemLop
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
--Trigger Them hoc sinh
ALTER TRIGGER UTG_ThemHocSinh
ON dbo.HocSinh FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @mahs VARCHAR(50)
	DECLARE @ngaysinh DATE
	SELECT @mahs = MaHS,@ngaysinh=Inserted.NgSinh FROM Inserted
	DECLARE @age INT
	SET @age = YEAR(GETDATE())-YEAR(@ngaysinh)
	IF(@age>20 OR @age<15) ROLLBACK TRAN
END
GO
-------------------------------------
--Trigger tăng sỉ sổ
CREATE TRIGGER UTG_TangSiSo
ON dbo.XepLop FOR INSERT
AS
BEGIN
	DECLARE @malop INT
	SELECT @malop=MaLop FROM Inserted
	DECLARE @siso INT
	SELECT @siso=SiSo FROM dbo.Lop WHERE MaLop=@malop
	IF(@siso<40)
		UPDATE dbo.Lop SET SiSo=SiSo+1 WHERE MaLop=@malop
	ELSE ROLLBACK TRAN
END
GO
--Trigger giảm sỉ số
CREATE TRIGGER UTG_GiamSiSo
ON dbo.XepLop FOR DELETE
AS
BEGIN
	DECLARE @malop INT
	SELECT @malop=MaLop FROM Deleted
	UPDATE dbo.Lop SET SiSo=SiSo-1 WHERE MaLop=@malop
END
GO
--------------------------------------
-- Thiết lập mốc giới hạn cho sỉ số
CREATE PROCEDURE USP_ChangeSiSo
@maxsiso NVARCHAR(50), @minsiso NVARCHAR(50)
AS
BEGIN
	DECLARE @SQL NVARCHAR(MAX)=
	'ALTER TRIGGER [dbo].[USP_TangSiSo]
ON [dbo].[XepLop] FOR INSERT
AS
BEGIN
	DECLARE @malop VARCHAR(50)
	SELECT @malop=MaLop FROM Inserted
	DECLARE @siso INT
	SELECT @siso=SiSo FROM dbo.Lop WHERE MaLop=@malop
	IF(@siso<'+@maxsiso+')
		UPDATE dbo.Lop SET SiSo=SiSo+1 WHERE MaLop=@malop
	ELSE ROLLBACK TRAN
END'
	DECLARE @s NVARCHAR(MAX)=
	'ALTER TRIGGER [dbo].[USP_GiamSiSo]
ON [dbo].[XepLop] FOR DELETE
AS
BEGIN
	DECLARE @malop VARCHAR(50)
	SELECT @malop=MaLop FROM Inserted
	DECLARE @siso INT
	SELECT @siso=SiSo FROM dbo.Lop WHERE MaLop=@malop
	IF(@siso>'+@minsiso+')
		UPDATE dbo.Lop SET SiSo=SiSo-1 WHERE MaLop=@malop
	ELSE ROLLBACK TRAN
END'
	EXEC sys.sp_executesql @SQL
	EXEC sys.sp_executesql @s
END
GO
--Them giao vien
CREATE PROC USP_ThemGiaoVien
@magv VARCHAR(10),@tengv NVARCHAR(100),@sdt VARCHAR(50),
@diachi NVARCHAR(100),@mamh VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.GiaoVien
	        ( MaGV, TenGV, SDT, DiaChi, MaMH )
	VALUES  ( @magv, -- MaGV - varchar(10)
	          @tengv, -- TenGV - nvarchar(100)
	          @sdt, -- SDT - varchar(50)
	          @diachi, -- DiaChi - nvarchar(100)
	          @mamh  -- MaMH - varchar(10)
	          )
END
GO
CREATE PROC USP_XoaGiaoVien
@magv VARCHAR(10)
AS
BEGIN
	DELETE dbo.GiaoVien WHERE MaGV=@magv
END
GO
CREATE PROC USP_SuaGiaoVien
@magv VARCHAR(10),@tengv NVARCHAR(100),@sdt VARCHAR(50),
@diachi NVARCHAR(100),@mamh VARCHAR(10)	
AS
BEGIN
	UPDATE dbo.GiaoVien SET TenGV=@tengv,
							SDT =@sdt,
							DiaChi=@diachi,
							MaMH=@mamh
						WHERE MaGV=@magv
END
GO
-------------------
--Them Diem
CREATE PROC InsertDiemAndMon
@mahs INT,@malop VARCHAR(50),@macotdiem VARCHAR(10),@diem FLOAT,@hocki INT,@namhoc NVARCHAR(50),@monhoc VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.BangDiem
	        ( MaHS ,
	          MaLop ,
	          MaCotDiem ,
	          Diem ,
	          HocKi ,
	          NamHoc
	        )
	VALUES  ( @mahs , -- MaHS - int
	          @malop , -- MaLop - varchar(50)
	          @macotdiem , -- MaCotDiem - varchar(10)
	          @diem , -- Diem - float
	          @hocki , -- HocKi - int
	          @namhoc  -- NamHoc - nvarchar(50)
	        )

	DECLARE @id INT
	SELECT @id=ID FROM dbo.BangDiem WHERE MaHS =@mahs

	INSERT INTO dbo.CTBD
	        ( MaMH, IDBangDiem )
	VALUES  ( @monhoc, -- MaMH - varchar(10)
	          @id-- IDBangDiem - int
	          )
END
GO 
----------
--Xoa Diem
CREATE PROC DeleteBangDiemByMaHS
@mahs INT
AS
BEGIN
	DELETE dbo.CTBD WHERE IDBangDiem IN (SELECT ID FROM dbo.BangDiem WHERE MaHS=@mahs)
	DELETE dbo.BangDiem WHERE MaHS=@mahs
END
GO
--Lay Bang Diem
ALTER PROC USP_GetBangDiem
@malop VARCHAR(50), @manamhoc NVARCHAR(50)
AS
BEGIN
	SELECT dbo.HocSinh.MaHS,HoTen
	FROM (HocSinh LEFT JOIN XepLop on HocSinh.MaHS = XepLop.MaHS) LEFT JOIN dbo.Lop ON Lop.MaLop = XepLop.MaLop
	WHERE Lop.MaLop=@malop AND NamHoc=@manamhoc
END
GO
EXEC dbo.USP_GetBangDiem @malop = '10220162017', -- varchar(50)
    @manamhoc = N'NH20162017' -- nvarchar(50)

-------------------------
--Hàm tìm gần đúng
CREATE FUNCTION [dbo].[fuConvertToUnsign1] 
( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
	BEGIN 
		IF @strInput IS NULL 
		RETURN @strInput IF @strInput = '' 
		RETURN @strInput 

		DECLARE @RT NVARCHAR(4000) 
		DECLARE @SIGN_CHARS NCHAR(136) 
		DECLARE @UNSIGN_CHARS NCHAR (136) 
		
		SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
		SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
		
		DECLARE @COUNTER int 
		DECLARE @COUNTER1 int 
		SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
		BEGIN 
			SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
			BEGIN 
				IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
					BEGIN 
						IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
						ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
						BREAK 
					END 
				SET @COUNTER1 = @COUNTER1 +1 
			END 
			SET @COUNTER = @COUNTER +1 
		END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
	END
GO
-----------------------------------
--Xep lop
CREATE PROC USP_XepLop
@mahs VARCHAR(10),@malop VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.XepLop
	        ( MaLop, MaHS )
	VALUES  ( @malop, -- MaLop - varchar(50)
	          @mahs  -- MaHS - varchar(10)
	          )
	UPDATE dbo.HocSinh SET CheckInClass=1 WHERE MaHS=@mahs
END
GO

--Update xếp lớp
CREATE PROC USP_UpdateXepLop
@mahs VARCHAR(10),@malopmoi VARCHAR(50)
AS
BEGIN
	UPDATE dbo.XepLop SET MaLop=@malopmoi WHERE MaHS=@mahs
END
GO 
---- Xóa xếp lớp
CREATE PROC USP_DeleteXepLop
@mahs VARCHAR(10)
AS
BEGIN
	DELETE dbo.XepLop WHERE MaHS=@mahs;
	UPDATE dbo.HocSinh SET CheckInClass = 0 WHERE MaHS=@mahs
END
GO
------------------------
--Lay hoc sinh thuoc lop va nam hoc
CREATE PROC USP_GetHSByMaLopAndNamHoc
@malop VARCHAR(50),@manamhoc NVARCHAR(50)
AS
SELECT HocSinh.MaHS,HoTen,GioiTinh,NgSinh,NoiSinh,DienThoai,Email,DiaChi FROM dbo.HocSinh,dbo.XepLop,dbo.Lop WHERE HocSinh.MaHS=dbo.XepLop.MaHS AND Lop.MaLop=Lop.MaLop AND CheckInClass=1 AND Lop.MaLop=@malop AND NamHoc=@manamhoc
GO
-- QUy Dinh tuoi
CREATE TRIGGER TG_DoTuoi ON dbo.HocSinh
FOR INSERT, UPDATE
AS
BEGIN	
	DECLARE @mahs VARCHAR(50)
	DECLARE @ngaysinh DATE
	SELECT @mahs = MaHS,@ngaysinh=Inserted.NgSinh FROM Inserted
	DECLARE @age INT
	SET @age = YEAR(GETDATE())-YEAR(@ngaysinh)
	IF(@age>20 OR @age<15) ROLLBACK TRAN
END
GO
CREATE PROC USP_QuiDinhTuoi
@maxage VARCHAR(10), @minage VARCHAR(10)
AS
BEGIN
	DECLARE @SQL NVARCHAR(max)=
	'ALTER TRIGGER TG_DoTuoi ON dbo.HocSinh
	FOR INSERT, UPDATE
	AS
	BEGIN	
	DECLARE @mahs VARCHAR(50)
	DECLARE @ngaysinh DATE
	SELECT @mahs = MaHS,@ngaysinh=Inserted.NgSinh FROM Inserted
	DECLARE @age INT
	SET @age = YEAR(GETDATE())-YEAR(@ngaysinh)
	IF(@age>'+@maxage+' OR @age<'+@minage+') ROLLBACK TRAN
	END
	'
	EXEC sys.sp_executesql @SQL
END
GO 
------Xoa hoc sinh
CREATE PROC USP_XoaHocSinh
@mahs INT
AS
	BEGIN
		DELETE dbo.HocSinh WHERE MaHS = @mahs
	END
GO
--Sửa lớp
CREATE PROC USP_UpdateLop
@malop VARCHAR(50), @tenlop NVARCHAR(100), @tenkhoilop NVARCHAR(50), @tengiaovien NVARCHAR(100), @tennamhoc NVARCHAR(50)
AS 
BEGIN
DECLARE @makhoi NVARCHAR(50)
	DECLARE @magv NVARCHAR(10)
	DECLARE @manh NVARCHAR(50)
	SELECT @makhoi = dbo.Lop.MaKhoiLop FROM dbo.Lop WHERE Malop = @malop
	SELECT @magv = dbo.Lop.GVCN FROM	 dbo.Lop WHERE MaLop = @malop
	SELECT @manh = dbo.Lop.NamHoc FROM	 dbo.Lop WHERE MaLop = @malop
	UPDATE dbo.Lop SET TenLop=@tenlop WHERE MaLop = @malop
	UPDATE dbo.KhoiLop SET TenKhoiLop=@tenkhoilop WHERE MaKhoiLop = @makhoi
	UPDATE dbo.GiaoVien SET TenGV = @tengiaovien WHERE MaGV =@magv
	UPDATE dbo.NamHoc SET TenNamHoc = @tennamhoc WHERE MaNamHoc= @manh
	
END	
GO
--Xóa lớp
CREATE PROC USP_DeleteLop
@malop VARCHAR(50)
AS
BEGIN
    DELETE dbo.Lop WHERE MaLop=@malop
END
GO
ALTER PROC USP_GetStudentFromBangDiem
@malop NVARCHAR(100)
AS
BEGIN
	SELECT BangDiem.MaHS,HoTen,TenHocKi,TenCotDiem,Diem,TenNamHoc,TenMon FROM dbo.BangDiem,dbo.HocSinh,dbo.CotDiem,dbo.HocKi,dbo.NamHoc,dbo.CTBD,dbo.MonHoc
	WHERE dbo.BangDiem.MaHS=dbo.HocSinh.MaHS AND BangDiem.MaCotDiem=CotDiem.MaCotDiem
	AND HocKi.MaHocKi=dbo.BangDiem.HocKi AND NamHoc=MaNamHoc
	AND MaLop=@malop AND CTBD.MaMH=MonHoc.MaMH AND CTBD.IDBangDiem=BangDiem.ID
END
GO
DELETE dbo.KQ_TongHop WHERE MaHS='' AND MaLop=N'' AND NamHoc = N''
