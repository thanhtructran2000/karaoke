USE [master]
GO
/****** Object:  Database [QuanLyKaraoke]    Script Date: 12/03/2021 18:54:31 ******/
CREATE DATABASE [QuanLyKaraoke] ON  PRIMARY 
( NAME = N'QuanLyKaraoke', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QuanLyKaraoke.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKaraoke_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QuanLyKaraoke_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyKaraoke] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKaraoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyKaraoke] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyKaraoke] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLyKaraoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyKaraoke] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyKaraoke] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyKaraoke] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLyKaraoke] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyKaraoke] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyKaraoke] SET DB_CHAINING OFF
GO
USE [QuanLyKaraoke]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](20) NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DonViTinh] ON
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Chiếc1', CAST(0x0000ADD3016033FB AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (2, N'Thùng', CAST(0x0000ADD3016AF606 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (3, N'Két', CAST(0x0000ADD3016AFEF5 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (4, N'Gói', CAST(0x0000ADD3016B0584 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (5, N'Đĩa', CAST(0x0000ADD3016B14B7 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (6, N'Lon', CAST(0x0000ADD3016D33F2 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (7, N'Chai lớn', CAST(0x0000ADD3016D3A1C AS DateTime), N'admin', CAST(0x0000ADF3010CE799 AS DateTime), N'admin')
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[DonGia] [int] NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Phòng thường', 70000, CAST(0x0000ADD501579778 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (2, N'Phòng VIP', 120000, CAST(0x0000ADD5015D787B AS DateTime), N'admin', CAST(0x0000ADD50160D02F AS DateTime), N'admin')
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[HoVaTen] [nvarchar](30) NULL,
	[DienThoai] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([Username], [Password], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'admin', N'123', N'Trần Thanh Trúc', N'0949463412', N'Ngô Quyền')
INSERT [dbo].[NhanVien] ([Username], [Password], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'nv01', N'123', N'nhân viên 1', N'0819123439', N'Nguyễn Trung Trực')
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](150) NOT NULL,
	[DienThoai] [varchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Email] [varchar](150) NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON
INSERT [dbo].[NhaCungCap] ([ID], [TenNCC], [DienThoai], [DiaChi], [Email], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (0, N'Đại lý bia M3T', N'0949463412', N'27 Ngô Quyền', N'dailybia@gmail.com', CAST(0x0000ADD600D2D81D AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[NhaCungCap] ([ID], [TenNCC], [DienThoai], [DiaChi], [Email], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Vựa trái cây NQ', N'0837383858', N'Nguyễn Kim', N'traicay@gmail.com', CAST(0x0000ADD600D590A1 AS DateTime), N'admin', CAST(0x0000ADD600D82DF4 AS DateTime), N'admin')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
/****** Object:  Table [dbo].[Phong]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[TrangThai] [tinyint] NULL,
	[IDLoaiPhong] [int] NULL,
	[SucChua] [int] NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Phong] ON
INSERT [dbo].[Phong] ([ID], [TenPhong], [TrangThai], [IDLoaiPhong], [SucChua], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Phòng 011', 0, 1, 5, CAST(0x0000ADD5016FB79F AS DateTime), N'admin', CAST(0x0000ADD5017527B8 AS DateTime), NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [TrangThai], [IDLoaiPhong], [SucChua], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (3, N'Phòng 012', 0, 1, 4, CAST(0x0000ADDA00CDFC9E AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [TrangThai], [IDLoaiPhong], [SucChua], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (4, N'Phòng 013', 0, 1, 5, CAST(0x0000ADDA00CE1618 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [TrangThai], [IDLoaiPhong], [SucChua], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (5, N'Phòng 021', 0, 2, 10, CAST(0x0000ADDA00CE3798 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [TrangThai], [IDLoaiPhong], [SucChua], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (6, N'Phòng 022', 1, 2, 15, CAST(0x0000ADDA00CE46DB AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Phong] OFF
/****** Object:  Table [dbo].[MatHang]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMatHang] [nvarchar](50) NOT NULL,
	[DVT] [int] NULL,
	[DonGiaBan] [int] NOT NULL,
	[IdCha] [int] NULL,
	[Tile] [int] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayTao] [datetime] NULL,
	[NguoiCapNhat] [varchar](50) NULL,
	[NgayCapNhat] [datetime] NULL,
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MatHang] ON
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (1, N'Trái cây', NULL, 200000, NULL, NULL, N'admin', CAST(0x0000ADD5013D149A AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (2, N'Bia', NULL, 0, NULL, NULL, N'admin', CAST(0x0000ADD5013D429A AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (3, N'Trái cây', 5, 250000, -1, 0, N'admin', CAST(0x0000ADD5013F2C90 AS DateTime), N'admin', CAST(0x0000ADF3010BD41F AS DateTime))
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (4, N'Bia 333', 3, 340000, NULL, NULL, N'admin', CAST(0x0000ADD50144A0FF AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (5, N'Bia 333', 6, 15000, NULL, NULL, N'admin', CAST(0x0000ADD80118C3AB AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (8, N'Trai cay lớn', 5, 250000, 1, 2, N'admin', CAST(0x0000ADE50151ECC3 AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (9, N'Bia tiger', 2, 240000, -1, 0, N'admin', CAST(0x0000ADF3010BBEAF AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [IdCha], [Tile], [NguoiTao], [NgayTao], [NguoiCapNhat], [NgayCapNhat]) VALUES (10, N'Bia Tiger', 2, 350000, -1, 0, N'admin', CAST(0x0000ADF3010CB632 AS DateTime), N'admin', CAST(0x0000ADF3010CC3BD AS DateTime))
SET IDENTITY_INSERT [dbo].[MatHang] OFF
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NhanVienNhap] [varchar](30) NOT NULL,
	[IDNhaCC] [int] NULL,
	[NgayNhap] [datetime] NOT NULL,
	[DaNhap] [tinyint] NULL,
	[TienThanhToan] [int] NULL,
	[NgayTao] [datetime] NOT NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonNhap] ON
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'admin', 0, CAST(0x0000ADD800000000 AS DateTime), 1, 3000000, CAST(0x0000ADD800A47AC9 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (2, N'admin', 0, CAST(0x0000ADD800000000 AS DateTime), 1, 0, CAST(0x0000ADD800A94E76 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (3, N'nv01', 1, CAST(0x0000ADD800000000 AS DateTime), 1, 0, CAST(0x0000ADD800CEA572 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (4, N'admin', 1, CAST(0x0000ADE500000000 AS DateTime), 1, 2600000, CAST(0x0000ADE5014E4323 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (5, N'admin', 0, CAST(0x0000ADE700000000 AS DateTime), NULL, NULL, CAST(0x0000ADE700E2C5B9 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (6, N'nv01', 1, CAST(0x0000ADF300000000 AS DateTime), 1, 4200000, CAST(0x0000ADF3010DAE44 AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[HoaDonNhap] OFF
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[IDHoaDon] [bigint] IDENTITY(1,1) NOT NULL,
	[IDPhong] [int] NULL,
	[ThoiGianBDau] [datetime] NULL,
	[ThoiGianKThuc] [datetime] NULL,
	[DonGiaPhong] [int] NULL,
	[NguoiBan] [varchar](30) NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](50) NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonBanHang] ON
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, 1, CAST(0x0000AC7800C5C100 AS DateTime), NULL, 700000, N'admin', NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (5, 3, CAST(0x0000AC7900D21D10 AS DateTime), NULL, 700000, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (6, 1, CAST(0x0000ADE600FFFB40 AS DateTime), CAST(0x0000ADE6010951E0 AS DateTime), NULL, N'admin', CAST(0x0000ADE6010021F5 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (7, 3, CAST(0x0000ADE601027410 AS DateTime), CAST(0x0000ADE700CED150 AS DateTime), NULL, N'admin', CAST(0x0000ADE6010285F7 AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (8, 1, CAST(0x0000ADE700CED150 AS DateTime), CAST(0x0000ADE700CED150 AS DateTime), NULL, N'admin', CAST(0x0000ADE700CF0D5B AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (9, 1, CAST(0x0000ADE701060620 AS DateTime), CAST(0x0000ADE7010F5CC0 AS DateTime), NULL, N'admin', CAST(0x0000ADE70106513F AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (10, 1, CAST(0x0000ADF3010DFD30 AS DateTime), CAST(0x0000ADF3010E4380 AS DateTime), NULL, N'admin', CAST(0x0000ADF3010E22EC AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (11, 6, CAST(0x0000ADF3010E4380 AS DateTime), NULL, NULL, N'admin', CAST(0x0000ADF3010E57A7 AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[HoaDonBanHang] OFF
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[IDHoaDon] [bigint] NOT NULL,
	[IDMatHang] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDMatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (1, 3, 30, 100000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (2, 2, 5, 200000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (2, 4, 15, 350000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (2, 5, 24, 150000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (3, 8, 20, 400000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (4, 3, 10, 260000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (6, 9, 12, 350000)
/****** Object:  Table [dbo].[ChiTietHoaDonBan]    Script Date: 12/03/2021 18:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBan](
	[IDHoaDon] [bigint] NOT NULL,
	[IDMatHang] [int] NOT NULL,
	[SL] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDMatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (6, 3, 1, 200000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (6, 8, 1, 250000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (7, 4, 1, 340000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (8, 5, 2, 15000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (9, 3, 1, 200000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (10, 9, 1, 240000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGia]) VALUES (11, 3, 2, 250000)
/****** Object:  Default [DF_DonViTinh_NgayTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  Default [DF_DonViTinh_NguoiTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
/****** Object:  Default [DF_DonViTinh_NgayCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
/****** Object:  Default [DF_DonViTinh_NguoiCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
/****** Object:  Default [DF_NhaCungCap_NgayTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  Default [DF_NhaCungCap_NguoiTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
/****** Object:  Default [DF_NhaCungCap_NgayCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
/****** Object:  Default [DF_NhaCungCap_NguoiCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
/****** Object:  Default [DF_Phong_TrangThai]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF_Phong_NgayTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  Default [DF_Phong_NguoiTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
/****** Object:  Default [DF_Phong_NgayCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
/****** Object:  Default [DF_Phong_NguoiCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
/****** Object:  Default [DF_MatHang_NguoiTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
/****** Object:  Default [DF_MatHang_NgayTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  Default [DF_MatHang_NguoiCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
/****** Object:  Default [DF_MatHang_NgayCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
/****** Object:  Default [DF_HoaDonNhap_NgayTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  Default [DF_HoaDonNhap_NguoiTao]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
/****** Object:  Default [DF_HoaDonNhap_NgayCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
/****** Object:  Default [DF_HoaDonNhap_NguoiCapNhat]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
/****** Object:  ForeignKey [FK_Phong_LoaiPhong]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
/****** Object:  ForeignKey [FK_MatHang_DonViTinh]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_DonViTinh] FOREIGN KEY([DVT])
REFERENCES [dbo].[DonViTinh] ([ID])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_DonViTinh]
GO
/****** Object:  ForeignKey [FK_HoaDonNhap_NhaCungCap]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap] FOREIGN KEY([IDNhaCC])
REFERENCES [dbo].[NhaCungCap] ([ID])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_HoaDonBanHang_Phong]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_Phong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_Phong]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonNhap_HoaDonNhap]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDonNhap] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonNhap_MatHang]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_MatHang] FOREIGN KEY([IDMatHang])
REFERENCES [dbo].[MatHang] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_MatHang]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonBan_HoaDonBanHang]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBan_HoaDonBanHang] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDonBanHang] ([IDHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan] CHECK CONSTRAINT [FK_ChiTietHoaDonBan_HoaDonBanHang]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonBan_MatHang]    Script Date: 12/03/2021 18:54:32 ******/
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBan_MatHang] FOREIGN KEY([IDMatHang])
REFERENCES [dbo].[MatHang] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan] CHECK CONSTRAINT [FK_ChiTietHoaDonBan_MatHang]
GO
