USE [master]
GO
/****** Object:  Database [QuanLyHocSinh]    Script Date: 6/26/2018 9:39:24 PM ******/
CREATE DATABASE [QuanLyHocSinh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHocSinh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyHocSinh.mdf' , SIZE = 5312KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyHocSinh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyHocSinh_log.ldf' , SIZE = 5824KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyHocSinh] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHocSinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocSinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHocSinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyHocSinh] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHocSinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHocSinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHocSinh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyHocSinh] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyHocSinh] SET QUERY_STORE = OFF
GO
USE [QuanLyHocSinh]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLyHocSinh]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 6/26/2018 9:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  Table [dbo].[Account]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NULL,
	[TenNguoiDung] [nvarchar](100) NULL,
	[DisplayName] [nvarchar](100) NULL,
	[Type] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHS] [varchar](50) NULL,
	[MaLop] [nvarchar](100) NULL,
	[MaCotDiem] [varchar](10) NULL,
	[Diem] [float] NULL,
	[HocKi] [int] NULL,
	[NamHoc] [nvarchar](50) NULL,
 CONSTRAINT [PK__BangDiem__3214EC27C68D9EC3] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CotDiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CotDiem](
	[MaCotDiem] [varchar](10) NOT NULL,
	[TenCotDiem] [nvarchar](50) NULL,
	[HeSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCotDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTBD]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTBD](
	[MaMH] [varchar](10) NOT NULL,
	[IDBangDiem] [int] NOT NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[IDBangDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](100) NULL,
	[SDT] [varchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaMH] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HanhKiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HanhKiem](
	[MaHK] [varchar](10) NOT NULL,
	[LoaiHK] [nvarchar](10) NULL,
 CONSTRAINT [PK__HanhKiem__2725A6E7180340D6] PRIMARY KEY CLUSTERED 
(
	[MaHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKi]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKi](
	[MaHocKi] [int] NOT NULL,
	[TenHocKi] [nvarchar](50) NULL,
	[HeSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocKi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocLuc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocLuc](
	[MaHocLuc] [varchar](10) NOT NULL,
	[TenHocLuc] [nvarchar](50) NULL,
	[DiemToiDa] [float] NULL,
	[DiemToiThieu] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocLuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](100) NULL,
	[NgSinh] [date] NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[CheckInClass] [int] NULL,
 CONSTRAINT [PK__HocSinh__2725A6EF355D9D71] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaKQ] [varchar](10) NOT NULL,
	[TenKQ] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua_HocKi_MonHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua_HocKi_MonHoc](
	[MaHS] [varchar](50) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[MaNamHoc] [nvarchar](50) NOT NULL,
	[DTBMonHocKi] [float] NULL,
	[HocKi] [int] NOT NULL,
 CONSTRAINT [PK_KQ_HK_MH] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaLop] ASC,
	[MaMH] ASC,
	[MaNamHoc] ASC,
	[HocKi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KQ_CaNam_MonHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KQ_CaNam_MonHoc](
	[MaHS] [varchar](50) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[NamHoc] [nvarchar](50) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[DTBMonCaNam] [float] NULL,
 CONSTRAINT [PK_KQ_CaNam_MH] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaLop] ASC,
	[NamHoc] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KQ_HocKi_TongHop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KQ_HocKi_TongHop](
	[MaHS] [varchar](50) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[MaHocKi] [int] NOT NULL,
	[NamHoc] [nvarchar](50) NOT NULL,
	[MaHocLuc] [varchar](10) NULL,
	[MaHK] [varchar](10) NULL,
	[DiemTBHocKi] [float] NULL,
 CONSTRAINT [PK_KQ_HocKi_TongHop] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaLop] ASC,
	[MaHocKi] ASC,
	[NamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KQ_TongHop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KQ_TongHop](
	[MaHS] [varchar](50) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[NamHoc] [nvarchar](50) NOT NULL,
	[MaHocLuc] [varchar](10) NULL,
	[MaHK] [varchar](10) NULL,
	[DiemTBNam] [float] NULL,
	[MaKQ] [varchar](10) NULL,
 CONSTRAINT [PK_KQ_TongHop] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaLop] ASC,
	[NamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoiLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoiLop](
	[MaKhoiLop] [nvarchar](50) NOT NULL,
	[TenKhoiLop] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoiLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDiem](
	[MaLoaiDiem] [varchar](10) NOT NULL,
	[TenLoaiDiem] [nvarchar](100) NULL,
	[HeSo] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](100) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[SiSo] [int] NULL,
	[LoaiLop] [int] NULL,
	[MaKhoiLop] [nvarchar](50) NULL,
	[GVCN] [varchar](10) NULL,
	[NamHoc] [nvarchar](50) NULL,
 CONSTRAINT [PK__Lop__3B98D273ED9FA1B8] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](100) NULL,
	[HeSoMon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NamHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NamHoc](
	[MaNamHoc] [nvarchar](50) NOT NULL,
	[TenNamHoc] [nvarchar](100) NULL,
 CONSTRAINT [PK__NamHoc__7DBADD748E89B836] PRIMARY KEY CLUSTERED 
(
	[MaNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinhTruong]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhTruong](
	[MaTruong] [varchar](50) NOT NULL,
	[TenTruong] [nvarchar](100) NULL,
	[SiSoMax] [varchar](10) NULL,
	[SiSoMin] [varchar](10) NULL,
	[AgeMax] [varchar](10) NULL,
	[AgeMin] [varchar](10) NULL,
	[DiemDat] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTruong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XepLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XepLop](
	[MaLop] [nvarchar](100) NOT NULL,
	[MaHS] [varchar](50) NOT NULL,
 CONSTRAINT [PK_XL] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[HocKi] ADD  DEFAULT ((1)) FOR [HeSo]
GO
ALTER TABLE [dbo].[HocSinh] ADD  CONSTRAINT [DF_HocSinh_CheckInClass]  DEFAULT ((0)) FOR [CheckInClass]
GO
ALTER TABLE [dbo].[LoaiDiem] ADD  DEFAULT ((1)) FOR [HeSo]
GO
ALTER TABLE [dbo].[Lop] ADD  CONSTRAINT [DF_Lop_SiSo]  DEFAULT ((0)) FOR [SiSo]
GO
ALTER TABLE [dbo].[Lop] ADD  CONSTRAINT [DF__Lop__LoaiLop__1CF15040]  DEFAULT ((0)) FOR [LoaiLop]
GO
ALTER TABLE [dbo].[MonHoc] ADD  DEFAULT ((1)) FOR [HeSoMon]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK__BangDiem__MaCotD__267ABA7A] FOREIGN KEY([MaCotDiem])
REFERENCES [dbo].[CotDiem] ([MaCotDiem])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK__BangDiem__MaCotD__267ABA7A]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK__BangDiem__MaHS__25869641] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK__BangDiem__MaHS__25869641]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK__BangDiem__MaLop__286302EC] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK__BangDiem__MaLop__286302EC]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_NamHoc] FOREIGN KEY([NamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_NamHoc]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BD_HK] FOREIGN KEY([HocKi])
REFERENCES [dbo].[HocKi] ([MaHocKi])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BD_HK]
GO
ALTER TABLE [dbo].[CTBD]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[CTBD]  WITH CHECK ADD  CONSTRAINT [FK__CTBD__IDBangDiem__2C3393D0] FOREIGN KEY([IDBangDiem])
REFERENCES [dbo].[BangDiem] ([ID])
GO
ALTER TABLE [dbo].[CTBD] CHECK CONSTRAINT [FK__CTBD__IDBangDiem__2C3393D0]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK__KetQua_Ho__DTBMo__34C8D9D1] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc] CHECK CONSTRAINT [FK__KetQua_Ho__DTBMo__34C8D9D1]
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK__KetQua_Ho__MaLop__35BCFE0A] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc] CHECK CONSTRAINT [FK__KetQua_Ho__MaLop__35BCFE0A]
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK__KetQua_Hoc__MaMH__36B12243] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc] CHECK CONSTRAINT [FK__KetQua_Hoc__MaMH__36B12243]
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_HK_KQ] FOREIGN KEY([HocKi])
REFERENCES [dbo].[HocKi] ([MaHocKi])
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc] CHECK CONSTRAINT [FK_HK_KQ]
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_KQHK_NH] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[KetQua_HocKi_MonHoc] CHECK CONSTRAINT [FK_KQHK_NH]
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK__KQ_CaNam___MaLop__3B75D760] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc] CHECK CONSTRAINT [FK__KQ_CaNam___MaLop__3B75D760]
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK__KQ_CaNam_M__MaHS__3A81B327] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc] CHECK CONSTRAINT [FK__KQ_CaNam_M__MaHS__3A81B327]
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK__KQ_CaNam_M__MaMH__3D5E1FD2] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc] CHECK CONSTRAINT [FK__KQ_CaNam_M__MaMH__3D5E1FD2]
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_CN_NH] FOREIGN KEY([NamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[KQ_CaNam_MonHoc] CHECK CONSTRAINT [FK_CN_NH]
GO
ALTER TABLE [dbo].[KQ_HocKi_TongHop]  WITH CHECK ADD FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[KQ_HocKi_TongHop]  WITH CHECK ADD FOREIGN KEY([MaHocKi])
REFERENCES [dbo].[HocKi] ([MaHocKi])
GO
ALTER TABLE [dbo].[KQ_HocKi_TongHop]  WITH CHECK ADD FOREIGN KEY([MaHocLuc])
REFERENCES [dbo].[HocLuc] ([MaHocLuc])
GO
ALTER TABLE [dbo].[KQ_HocKi_TongHop]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[KQ_HocKi_TongHop]  WITH CHECK ADD FOREIGN KEY([NamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[KQ_HocKi_TongHop]  WITH CHECK ADD FOREIGN KEY([MaHK])
REFERENCES [dbo].[HanhKiem] ([MaHK])
GO
ALTER TABLE [dbo].[KQ_TongHop]  WITH CHECK ADD  CONSTRAINT [FK__KQ_TongHo__DiemT__412EB0B6] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[KQ_TongHop] CHECK CONSTRAINT [FK__KQ_TongHo__DiemT__412EB0B6]
GO
ALTER TABLE [dbo].[KQ_TongHop]  WITH CHECK ADD  CONSTRAINT [FK__KQ_TongHo__MaHoc__44FF419A] FOREIGN KEY([MaHocLuc])
REFERENCES [dbo].[HocLuc] ([MaHocLuc])
GO
ALTER TABLE [dbo].[KQ_TongHop] CHECK CONSTRAINT [FK__KQ_TongHo__MaHoc__44FF419A]
GO
ALTER TABLE [dbo].[KQ_TongHop]  WITH CHECK ADD  CONSTRAINT [FK__KQ_TongHo__MaLop__4222D4EF] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[KQ_TongHop] CHECK CONSTRAINT [FK__KQ_TongHo__MaLop__4222D4EF]
GO
ALTER TABLE [dbo].[KQ_TongHop]  WITH CHECK ADD  CONSTRAINT [FK__KQ_TongHop__MaHK__440B1D61] FOREIGN KEY([MaHK])
REFERENCES [dbo].[HanhKiem] ([MaHK])
GO
ALTER TABLE [dbo].[KQ_TongHop] CHECK CONSTRAINT [FK__KQ_TongHop__MaHK__440B1D61]
GO
ALTER TABLE [dbo].[KQ_TongHop]  WITH CHECK ADD FOREIGN KEY([MaKQ])
REFERENCES [dbo].[KetQua] ([MaKQ])
GO
ALTER TABLE [dbo].[KQ_TongHop]  WITH CHECK ADD  CONSTRAINT [FK_TH_NH] FOREIGN KEY([NamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[KQ_TongHop] CHECK CONSTRAINT [FK_TH_NH]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK__Lop__MaKhoiLop__1DE57479] FOREIGN KEY([MaKhoiLop])
REFERENCES [dbo].[KhoiLop] ([MaKhoiLop])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK__Lop__MaKhoiLop__1DE57479]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_L_GV] FOREIGN KEY([GVCN])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_L_GV]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_L_NH] FOREIGN KEY([NamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_L_NH]
GO
ALTER TABLE [dbo].[XepLop]  WITH CHECK ADD  CONSTRAINT [FK__XepLop__MaHS__48CFD27E] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[XepLop] CHECK CONSTRAINT [FK__XepLop__MaHS__48CFD27E]
GO
ALTER TABLE [dbo].[XepLop]  WITH CHECK ADD  CONSTRAINT [FK__XepLop__MaLop__47DBAE45] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[XepLop] CHECK CONSTRAINT [FK__XepLop__MaLop__47DBAE45]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBangDiemByMaHS]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteBangDiemByMaHS]
@mahs VARCHAR(50)
AS
BEGIN
	DELETE dbo.CTBD WHERE IDBangDiem IN (SELECT ID FROM dbo.BangDiem WHERE MaHS=@mahs)
	DELETE dbo.BangDiem WHERE MaHS=@mahs
END
GO
/****** Object:  StoredProcedure [dbo].[GetHS]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHS]
AS
BEGIN
	SELECT hs.MaHS,hs.HoTen,hs.NgSinh,hs.NoiSinh,hs.DiaChi,TenLop,nh.TenNamHoc FROM dbo.HocSinh AS hs, dbo.XepLop AS xl, Lop, dbo.NamHoc AS nh
	WHERE
	hs.MaHS=xl.MaHS AND xl.MaLop=Lop.MaLop AND Lop.NamHoc = nh.MaNamHoc
END
GO
/****** Object:  StoredProcedure [dbo].[GetHSByMaKhoi]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHSByMaKhoi]
@makhoi NVARCHAR(100)
AS
BEGIN
	SELECT HocSinh.MaHS,HoTen,NgSinh, NoiSinh, DiaChi, TenLop, TenNamHoc
	FROM HocSinh, dbo.XepLop, Lop, dbo.NamHoc, dbo.KhoiLop
	WHERE
	dbo.HocSinh.MaHS=dbo.XepLop.MaHS AND dbo.XepLop.MaLop=Lop.MaLop AND Lop.NamHoc=NamHoc.MaNamHoc AND dbo.Lop.MaKhoiLop=dbo.KhoiLop.MaKhoiLop AND KhoiLop.MaKhoiLop=@makhoi
END
GO
/****** Object:  StoredProcedure [dbo].[GetHSByMaKhoiNH]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHSByMaKhoiNH]
@makhoi NVARCHAR(100),
@manamhoc NVARCHAR(100)
AS
BEGIN
	SELECT HocSinh.MaHS,HoTen,NgSinh, NoiSinh, DiaChi, TenLop, TenNamHoc
	FROM HocSinh, dbo.XepLop, Lop, dbo.NamHoc, dbo.KhoiLop
	WHERE
	dbo.HocSinh.MaHS=dbo.XepLop.MaHS AND dbo.XepLop.MaLop=Lop.MaLop AND Lop.NamHoc=NamHoc.MaNamHoc AND dbo.Lop.MaKhoiLop=dbo.KhoiLop.MaKhoiLop AND KhoiLop.MaKhoiLop=@makhoi AND MaNamHoc=@manamhoc
END
GO
/****** Object:  StoredProcedure [dbo].[GetHSByMaLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHSByMaLop]
@malop VARCHAR(50)
AS 
BEGIN
	SELECT HocSinh.MaHS,HoTen,NgSinh, NoiSinh, DiaChi, TenLop, TenNamHoc
	FROM HocSinh, dbo.XepLop, Lop, dbo.NamHoc
	WHERE
	dbo.HocSinh.MaHS=dbo.XepLop.MaHS AND dbo.XepLop.MaLop=Lop.MaLop AND Lop.NamHoc=NamHoc.MaNamHoc AND Lop.MaLop = @malop
END
GO
/****** Object:  StoredProcedure [dbo].[GetHSByMaLopNH]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHSByMaLopNH]
@malop VARCHAR(50),
@namhoc NVARCHAR(100)
AS
 BEGIN
	SELECT HocSinh.MaHS,HoTen,NgSinh, NoiSinh, DiaChi, TenLop, TenNamHoc
	FROM HocSinh, dbo.XepLop, Lop, dbo.NamHoc
	WHERE
	dbo.HocSinh.MaHS=dbo.XepLop.MaHS AND dbo.XepLop.MaLop=Lop.MaLop AND Lop.NamHoc=NamHoc.MaNamHoc AND Lop.MaLop = @malop AND MaNamHoc=@namhoc
 END
GO
/****** Object:  StoredProcedure [dbo].[InsertDiemAndMon]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertDiemAndMon]
@mahs VARCHAR(50),@malop NVARCHAR(100),@macotdiem VARCHAR(10),@diem FLOAT,@hocki INT,@namhoc NVARCHAR(50),@monhoc VARCHAR(10)
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
	VALUES  ( @mahs , -- MaHS - varchar(50)
	          @malop , -- MaLop - nvarchar(50)
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
/****** Object:  StoredProcedure [dbo].[LoadClassByKL]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadClassByKL]
@makhoi NVARCHAR(100)
AS 
BEGIN
	SELECT MaLop, TenLop, TenGV, TenNamHoc, SiSo FROM dbo.Lop, dbo.GiaoVien, dbo.NamHoc, dbo.KhoiLop WHERE dbo.KhoiLop.MaKhoiLop=Lop.MaKhoiLop AND Lop.GVCN=dbo.GiaoVien.MaGV AND Lop.NamHoc=NamHoc.MaNamHoc AND KhoiLop.MaKhoiLop=@makhoi
END
GO
/****** Object:  StoredProcedure [dbo].[LoadCLassByNH]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadCLassByNH]
@manamhoc NVARCHAR(100)
AS
	BEGIN
		SELECT MaLop, TenLop, TenGV, TenNamHoc, SiSo FROM dbo.Lop, dbo.GiaoVien, dbo.NamHoc WHERE Lop.GVCN=dbo.GiaoVien.MaGV AND Lop.NamHoc=NamHoc.MaNamHoc AND NamHoc=@manamhoc
	END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQCN_LopByNamHocAndLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQCN_LopByNamHocAndLop]
@manamhoc NVARCHAR(100),
@malop NVARCHAR(100)
AS 
BEGIN
		SELECT HocSinh.MaHS,HoTen, (SELECT DiemTBHocKi FROM dbo.KQ_HocKi_TongHop WHERE MaHocKi=1 AND MaLop=@malop AND NamHoc=@manamhoc) AS DTBHK1, (SELECT DiemTBHocKi FROM dbo.KQ_HocKi_TongHop WHERE MaHocKi=2 AND MaLop=@malop AND NamHoc=@manamhoc) AS DTBHK2, DiemTBNam FROM dbo.KQ_TongHop,HocSinh,dbo.Lop WHERE dbo.KQ_TongHop.MaHS=dbo.HocSinh.MaHS AND dbo.KQ_TongHop.MaLop = Lop.MaLop AND KQ_TongHop.MaLop=@malop AND KQ_TongHop.NamHoc=@manamhoc
END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQCN_LopToReport]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQCN_LopToReport]
AS
BEGIN
	SELECT HocSinh.MaHS,HoTen, (SELECT DiemTBHocKi FROM dbo.KQ_HocKi_TongHop WHERE MaHocKi=1) AS DTBHK1, (SELECT DiemTBHocKi FROM dbo.KQ_HocKi_TongHop WHERE MaHocKi=2) AS DTBHK2, DiemTBNam,TenKQ FROM dbo.KQ_TongHop,HocSinh,dbo.Lop,dbo.KetQua WHERE dbo.KQ_TongHop.MaHS=dbo.HocSinh.MaHS AND dbo.KQ_TongHop.MaLop = Lop.MaLop AND dbo.KQ_TongHop.MaKQ=dbo.KetQua.MaKQ
END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQHKByMaLopAndNamHocAndHocKi]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQHKByMaLopAndNamHocAndHocKi]
@manamhoc NVARCHAR(100),
@malop NVARCHAR(100),
@mahocki NVARCHAR(100)
AS
	BEGIN
		SELECT HocSinh.MaHS, HoTen,TenLop, TenHocKi, DiemTBHocKi FROM dbo.KQ_HocKi_TongHop,dbo.HocSinh,dbo.HocKi,dbo.Lop WHERE dbo.KQ_HocKi_TongHop.MaHS=dbo.HocSinh.MaHS AND dbo.KQ_HocKi_TongHop.MaHocKi=dbo.HocKi.MaHocKi AND dbo.KQ_HocKi_TongHop.MaLop=@malop AND dbo.KQ_HocKi_TongHop.NamHoc=@manamhoc AND KQ_HocKi_TongHop.MaHocKi=@mahocki AND dbo.KQ_HocKi_TongHop.MaLop=dbo.Lop.MaLop
	END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQHKMonHocByNamHocAndHocKiAndMonHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQHKMonHocByNamHocAndHocKiAndMonHoc]
@manamhoc NVARCHAR(100),
@mahocki NVARCHAR(100),
@mamonhoc NVARCHAR(100)
AS
BEGIN
	SELECT HocSinh.MaHS,HoTen,DTBMonHocKi,TenMon FROM dbo.KetQua_HocKi_MonHoc,dbo.HocSinh,dbo.MonHoc WHERE dbo.HocSinh.MaHS=dbo.KetQua_HocKi_MonHoc.MaHS AND dbo.KetQua_HocKi_MonHoc.MaMH=dbo.MonHoc.MaMH AND MaNamHoc=@manamhoc AND HocKi=@mahocki AND KetQua_HocKi_MonHoc.MaMH=@mamonhoc
END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQHKMonToReport]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQHKMonToReport]
AS
BEGIN
	SELECT HocSinh.MaHS,HoTen,DTBMonHocKi,TenMon FROM dbo.KetQua_HocKi_MonHoc,dbo.HocSinh,dbo.MonHoc WHERE dbo.HocSinh.MaHS=dbo.KetQua_HocKi_MonHoc.MaHS AND dbo.KetQua_HocKi_MonHoc.MaMH=dbo.MonHoc.MaMH
END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQHKtoReport]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQHKtoReport]
AS
	BEGIN
		SELECT HocSinh.MaHS, HoTen,TenLop, TenHocKi, DiemTBHocKi FROM dbo.KQ_HocKi_TongHop,dbo.HocSinh,dbo.HocKi, Lop WHERE dbo.KQ_HocKi_TongHop.MaHS=dbo.HocSinh.MaHS AND dbo.KQ_HocKi_TongHop.MaHocKi=dbo.HocKi.MaHocKi AND dbo.KQ_HocKi_TongHop.MaLop=dbo.Lop.MaLop
	END
GO
/****** Object:  StoredProcedure [dbo].[LoadKQMH_CaNamByNamHocAndMonHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQMH_CaNamByNamHocAndMonHoc]
@manamhoc NVARCHAR(100),
@mamonhoc NVARCHAR(100)
AS
BEGIN
SELECT HocSinh.MaHS, HoTen,(SELECT DTBMonHocKi FROM dbo.KetQua_HocKi_MonHoc WHERE HocKi=1 AND MaNamHoc=@manamhoc AND MaMH=@mamonhoc) AS DTBHK1,(SELECT DTBMonHocKi FROM dbo.KetQua_HocKi_MonHoc WHERE HocKi=2 AND MaNamHoc=@manamhoc AND MaMH=@mamonhoc) AS DTBHK2,DTBMonCaNam,TenMon FROM dbo.KQ_CaNam_MonHoc,dbo.HocSinh,dbo.MonHoc WHERE HocSinh.MaHS=dbo.KQ_CaNam_MonHoc.MaHS AND dbo.KQ_CaNam_MonHoc.MaMH=dbo.MonHoc.MaMH AND NamHoc=@manamhoc AND KQ_CaNam_MonHoc.MaMH=@mamonhoc
END 
GO
/****** Object:  StoredProcedure [dbo].[LoadKQMH_CaNamToReport]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadKQMH_CaNamToReport]
AS
BEGIN
SELECT HocSinh.MaHS, HoTen,TenMon,(SELECT DTBMonHocKi FROM dbo.KetQua_HocKi_MonHoc WHERE HocKi=1) AS DTBHK1,(SELECT DTBMonHocKi FROM dbo.KetQua_HocKi_MonHoc WHERE HocKi=2) AS DTBHK2,DTBMonCaNam FROM dbo.KQ_CaNam_MonHoc,dbo.HocSinh,dbo.MonHoc WHERE HocSinh.MaHS=dbo.KQ_CaNam_MonHoc.MaHS AND dbo.KQ_CaNam_MonHoc.MaMH=dbo.MonHoc.MaMH
END
GO
/****** Object:  StoredProcedure [dbo].[ThemLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLop]
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
/****** Object:  StoredProcedure [dbo].[USP_ChangeSiSo]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_ChangeSiSo]
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
/****** Object:  StoredProcedure [dbo].[USP_DeleteBangDiemByID]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteBangDiemByID] @id INT AS BEGIN DELETE dbo.CTBD WHERE IDBangDiem=@id DELETE dbo.BangDiem WHERE ID=@id END
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xóa lớp

CREATE PROC [dbo].[USP_DeleteLop]
@malop VARCHAR(50)
AS
BEGIN
    DELETE dbo.Lop WHERE MaLop=@malop
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteXepLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteXepLop]
@mahs VARCHAR(10)
AS
BEGIN
	DELETE dbo.XepLop WHERE MaHS=@mahs;
	UPDATE dbo.HocSinh SET CheckInClass = 0 WHERE MaHS=@mahs
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBangDiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetBangDiem]
@malop VARCHAR(50), @manamhoc NVARCHAR(50)
AS
BEGIN
	SELECT dbo.HocSinh.MaHS,HoTen
	FROM (HocSinh LEFT JOIN XepLop on HocSinh.MaHS = XepLop.MaHS) LEFT JOIN dbo.Lop ON Lop.MaLop = XepLop.MaLop
	WHERE Lop.MaLop=@malop AND NamHoc=@manamhoc
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetHocSinh]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetHocSinh]
AS
BEGIN
	SELECT dbo.HocSinh.MaHS,HoTen,GioiTinh,NgSinh,NoiSinh,DienThoai,Email,DiaChi,TenLop 
	FROM (HocSinh LEFT JOIN XepLop on HocSinh.MaHS = XepLop.MaHS) LEFT JOIN dbo.Lop ON Lop.MaLop = XepLop.MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetHSByMaLopAndNamHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetHSByMaLopAndNamHoc]
@malop VARCHAR(100),@manamhoc NVARCHAR(50)
AS
SELECT HocSinh.MaHS,HoTen,GioiTinh,NgSinh,NoiSinh,DienThoai,Email,DiaChi FROM dbo.HocSinh,dbo.XepLop,dbo.Lop
 WHERE HocSinh.MaHS=dbo.XepLop.MaHS AND Lop.MaLop=dbo.XepLop.MaLop AND Lop.MaLop=@malop AND NamHoc=@manamhoc AND CheckInClass=1
GO
/****** Object:  StoredProcedure [dbo].[USP_GetStudentFromBangDiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetStudentFromBangDiem]
@malop NVARCHAR(100)
AS
BEGIN
	SELECT dbo.BangDiem.ID,BangDiem.MaHS,HoTen,TenHocKi,TenCotDiem,Diem,TenNamHoc,TenMon FROM dbo.BangDiem,dbo.HocSinh,dbo.CotDiem,dbo.HocKi,dbo.NamHoc,dbo.CTBD,dbo.MonHoc
	WHERE dbo.BangDiem.MaHS=dbo.HocSinh.MaHS AND BangDiem.MaCotDiem=CotDiem.MaCotDiem
	AND HocKi.MaHocKi=dbo.BangDiem.HocKi AND NamHoc=MaNamHoc
	AND MaLop=@malop AND CTBD.MaMH=MonHoc.MaMH AND CTBD.IDBangDiem=BangDiem.ID
END
GO
/****** Object:  StoredProcedure [dbo].[USP_QuiDinhTuoi]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_QuiDinhTuoi]
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
/****** Object:  StoredProcedure [dbo].[USP_SuaGiaoVien]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SuaGiaoVien]
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
/****** Object:  StoredProcedure [dbo].[USP_SuaNamHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SuaNamHoc]
@tennh NVARCHAR(100),@manh NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.NamHoc SET TenNamHoc=@tennh WHERE MaNamHoc=@manh
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemGiaoVien]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ThemGiaoVien]
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
/****** Object:  StoredProcedure [dbo].[USP_ThemHocSinh]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ThemHocSinh]
@mahs VARCHAR(10), @hoten NVARCHAR(100), @gioitinh NVARCHAR(100),
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
	VALUES  ( @mahs , -- MaHS -varchar(10)
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
/****** Object:  StoredProcedure [dbo].[USP_ThemNamHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ThemNamHoc]
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
/****** Object:  StoredProcedure [dbo].[USP_UpdateHocSinh]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateHocSinh]
@mahs VARCHAR(10), @tenhs NVARCHAR(100), @ngaysinh DATETIME, @noisinh NVARCHAR(100), @sodienthoai NVARCHAR(100), @diachi NVARCHAR(100), @gioitinh NVARCHAR(100), @email NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.HocSinh SET
    Hoten=@tenhs,
	GioiTinh=@gioitinh,
	NgSinh=@ngaysinh,
	NoiSinh=@noisinh,
	DienThoai=@sodienthoai,
	Email=@email,
	DiaChi=@diachi
	WHERE MaHS=@mahs
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateLop]
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
/****** Object:  StoredProcedure [dbo].[USP_UpdateXepLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateXepLop]
@mahs VARCHAR(10),@malopmoi VARCHAR(50)
AS
BEGIN
	UPDATE dbo.XepLop SET MaLop=@malopmoi WHERE MaHS=@mahs
END
GO
/****** Object:  StoredProcedure [dbo].[USP_User_Login]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------------------------------------------------------------
--Login
CREATE PROC [dbo].[USP_User_Login]
@userName NVARCHAR(100),
@passWord NVARCHAR(100)
AS
	BEGIN
		SELECT dbo.Account.UserName,dbo.Account.PassWord FROM dbo.Account WHERE UserName=@userName AND	PassWord = @passWord
	END	
GO
/****** Object:  StoredProcedure [dbo].[USP_XepLop]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XepLop]
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
/****** Object:  StoredProcedure [dbo].[USP_XoaGiaoVien]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaGiaoVien]
@magv VARCHAR(10)
AS
BEGIN
	DELETE dbo.GiaoVien WHERE MaGV=@magv
END
GO
/****** Object:  StoredProcedure [dbo].[USP_XoaHocSinh]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaHocSinh]
@mahs VARCHAR(10)
AS
	BEGIN
		DELETE dbo.KetQua_HocKi_MonHoc WHERE MaHS = @mahs
		DELETE dbo.KQ_CaNam_MonHoc WHERE MaHS = @mahs
		DELETE dbo.KQ_HocKi_TongHop WHERE MaHS=@mahs
		DELETE dbo.KQ_TongHop WHERE MaHS=@mahs
		DELETE dbo.BangDiem WHERE MaHS=@mahs
		DELETE dbo.HocSinh WHERE MaHS = @mahs
	END
GO
/****** Object:  StoredProcedure [dbo].[USP_XoaNamHoc]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaNamHoc]
@manamhoc NVARCHAR(50)
AS
BEGIN
	DELETE dbo.NamHoc WHERE MaNamHoc=@manamhoc
END
GO
/****** Object:  StoredProcedure [dbo].[USP_XoaTungLoaiDiem]    Script Date: 6/26/2018 9:39:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_XoaTungLoaiDiem]
@mahs VARCHAR(50),@tencotdiem NVARCHAR(100),@idbangdiem INT
AS
BEGIN
    DELETE dbo.CTBD WHERE IDBangDiem =@idbangdiem
	DELETE dbo.BangDiem WHERE ID=@idbangdiem
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyHocSinh] SET  READ_WRITE 
GO
