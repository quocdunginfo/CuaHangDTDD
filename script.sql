USE [master]
GO
/****** Object:  Database [CuaHangDTDD]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE DATABASE [CuaHangDTDD] ON  PRIMARY 
( NAME = N'CuaHangDTDD', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CuaHangDTDD.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CuaHangDTDD_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CuaHangDTDD_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CuaHangDTDD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CuaHangDTDD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET ARITHABORT OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CuaHangDTDD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CuaHangDTDD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CuaHangDTDD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CuaHangDTDD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CuaHangDTDD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CuaHangDTDD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CuaHangDTDD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CuaHangDTDD] SET  MULTI_USER 
GO
ALTER DATABASE [CuaHangDTDD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CuaHangDTDD] SET DB_CHAINING OFF 
GO
USE [CuaHangDTDD]
GO
/****** Object:  Table [dbo].[ChiTiet_DonHang]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTiet_DonHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[donhang_id] [int] NULL,
	[sanpham_chitiet_id] [int] NULL,
 CONSTRAINT [PK_dbo.ChiTiet_DonHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTiet_NhapHang]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTiet_NhapHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[nhaphang_id] [int] NULL,
	[sanpham_chitiet_id] [int] NULL,
 CONSTRAINT [PK_dbo.ChiTiet_NhapHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHangs]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHangs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ngay] [datetime] NOT NULL,
	[tongtien] [int] NOT NULL,
	[dagiaohang] [bit] NOT NULL,
	[active] [bit] NOT NULL,
	[kh_ten] [nvarchar](max) NULL,
	[kh_diachi] [nvarchar](max) NULL,
	[kh_email] [nvarchar](max) NULL,
	[kh_sdt] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DonHangs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangSXes]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSXes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](max) NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HangSXes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HinhAnhs]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhAnhs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[duongdan] [nvarchar](max) NULL,
	[duongdan_thumb] [nvarchar](max) NULL,
	[macdinh] [bit] NOT NULL,
	[sanpham_id] [int] NULL,
 CONSTRAINT [PK_dbo.HinhAnhs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MauSacs]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauSacs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[giatri] [nvarchar](max) NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.MauSacs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhapHangs]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapHangs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ngay] [datetime] NOT NULL,
	[tongtien] [int] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.NhapHangs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham_ChiTiet]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham_ChiTiet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[active] [bit] NOT NULL,
	[tonkho] [int] NOT NULL,
	[mausac_id] [int] NULL,
	[sanpham_id] [int] NULL,
 CONSTRAINT [PK_dbo.SanPham_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPhams]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPhams](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masp] [nvarchar](max) NULL,
	[ten] [nvarchar](max) NULL,
	[mota] [nvarchar](max) NULL,
	[gia] [int] NOT NULL,
	[active] [bit] NOT NULL,
	[hangsx_id] [int] NULL,
 CONSTRAINT [PK_dbo.SanPhams] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Settings]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[key] [nvarchar](max) NULL,
	[value] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Settings] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TonKhoes]    Script Date: 05/01/2014 11:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonKhoes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[soluong] [int] NOT NULL,
	[ngay] [datetime] NOT NULL,
	[sanpham_chitiet_id] [int] NULL,
 CONSTRAINT [PK_dbo.TonKhoes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[HangSXes] ON 

INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (1, N'Blackberry', 1)
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (2, N'Palm', 1)
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (3, N'Panasonic', 1)
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (4, N'Toshiba', 1)
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (5, N'Nokia', 1)
SET IDENTITY_INSERT [dbo].[HangSXes] OFF
SET IDENTITY_INSERT [dbo].[HinhAnhs] ON 

INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (1, N'9A995782C3A2CC57DB0C.jpg', N'_thumb_9A995782C3A2CC57DB0C.jpg', 0, 1)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (2, N'12943333FB26E7ABFB33.jpg', N'_thumb_12943333FB26E7ABFB33.jpg', 0, 1)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (3, N'F5CAB9BFEADABA135DD2.jpg', N'_thumb_F5CAB9BFEADABA135DD2.jpg', 0, 1)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (4, N'5E477F5002F6F33C9284.JPG', N'_thumb_5E477F5002F6F33C9284.JPG', 1, 1)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (5, N'22A6B1CFDFEE3A1BAC4D.jpg', N'_thumb_22A6B1CFDFEE3A1BAC4D.jpg', 1, 2)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (8, N'427E0EA91C519889D1D6.jpg', N'_thumb_427E0EA91C519889D1D6.jpg', 0, 2)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (9, N'64589EF6CF82292E4449.jpg', N'_thumb_64589EF6CF82292E4449.jpg', 0, 2)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (10, N'93730169CA57DC38D1A2.jpg', N'_thumb_93730169CA57DC38D1A2.jpg', 1, 3)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (11, N'9C691255DF349F275E59.jpg', N'_thumb_9C691255DF349F275E59.jpg', 1, 4)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (12, N'FB2B612F1BC3E61D7C36.jpg', N'_thumb_FB2B612F1BC3E61D7C36.jpg', 1, 5)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (13, N'2958BDF10C7BEEB05D2D.jpg', N'_thumb_2958BDF10C7BEEB05D2D.jpg', 1, 6)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (14, N'FE969938BF38AA79D36C.jpg', N'_thumb_FE969938BF38AA79D36C.jpg', 0, 6)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (15, N'C3016B12C560F1A6594F.jpg', N'_thumb_C3016B12C560F1A6594F.jpg', 1, 7)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (16, N'5790FCE31D758CF2AA05.jpg', N'_thumb_5790FCE31D758CF2AA05.jpg', 0, 7)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (17, N'A5D76F3AEACE36A98AF4.jpg', N'_thumb_A5D76F3AEACE36A98AF4.jpg', 0, 7)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (18, N'77383390731835F1A0EA.JPG', N'_thumb_77383390731835F1A0EA.JPG', 1, 8)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (19, N'1616CEF1FEF8C68D9B91.JPG', N'_thumb_1616CEF1FEF8C68D9B91.JPG', 0, 8)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (20, N'EA9C293A13CA2F6E9E8B.jpg', N'_thumb_EA9C293A13CA2F6E9E8B.jpg', 1, 9)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (21, N'DC63CB137C38368F11E0.jpg', N'_thumb_DC63CB137C38368F11E0.jpg', 0, 9)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (22, N'55904CAEBB253195C277.JPG', N'_thumb_55904CAEBB253195C277.JPG', 1, 10)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (23, N'73CD8B89ED119793E255.jpg', N'_thumb_73CD8B89ED119793E255.jpg', 0, 10)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (24, N'E9D4153458896ABB9F2C.jpg', N'_thumb_E9D4153458896ABB9F2C.jpg', 0, 10)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (25, N'3EF456D5F77AC5E64252.jpg', N'_thumb_3EF456D5F77AC5E64252.jpg', 0, 10)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (26, N'48F53B0C9CE46A1137BD.jpg', N'_thumb_48F53B0C9CE46A1137BD.jpg', 0, 10)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (27, N'A71C685A439E31DCDAE5.jpg', N'_thumb_A71C685A439E31DCDAE5.jpg', 0, 10)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (28, N'FC5FC931AD4C602D9E59.JPG', N'_thumb_FC5FC931AD4C602D9E59.JPG', 1, 11)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (29, N'A674EE2FC27F539571AD.JPG', N'_thumb_A674EE2FC27F539571AD.JPG', 0, 11)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (30, N'E1C89F5E22A07F4AFE12.JPG', N'_thumb_E1C89F5E22A07F4AFE12.JPG', 0, 11)
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (31, N'893A4944D319B1BD8A8D.jpg', N'_thumb_893A4944D319B1BD8A8D.jpg', 0, 11)
SET IDENTITY_INSERT [dbo].[HinhAnhs] OFF
SET IDENTITY_INSERT [dbo].[SanPhams] ON 

INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (1, N'PN001', N'Panasonic Eluga DL1', N'Also known as Panasonic EB-3901
GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 900 / 2100
SIM	Micro-SIM
Announced	2012, February
Status	Available. Released 2012, April
BODY	Dimensions	123 x 62 x 7.8 mm (4.84 x 2.44 x 0.31 in)
Weight	103 g (3.63 oz)
 	- IP57 certified - dust and water resistant
- Water proof up to 1 meter and 30 minutes
DISPLAY	Type	OLED capacitive touchscreen, 16M colors
Size	540 x 960 pixels, 4.3 inches (~256 ppi pixel density)
Multitouch	Yes
SOUND	Alert types	Vibration; MP3, WAV ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	No
Internal	8 GB storage, 1 GB RAM
DATA	GPRS	Yes
EDGE	Yes
Speed	HSDPA, 21 Mbps; HSUPA, 5.76 Mbps
WLAN	Wi-Fi 802.11 b/g/n, DLNA, Wi-Fi hotspot
Bluetooth	Yes, v2.1 with A2DP, EDR
NFC	Yes
USB	Yes, microUSB v2.0
CAMERA	Primary	8 MP, 3264x2448 pixels, autofocus
Features	Geo-tagging, touch focus
Video	Yes
Secondary	 
FEATURES	OS	Android OS, v2.3.5 (Gingerbread), planned upgrade to v4.0 (Ice Cream Sandwich)
Chipset	TI OMAP 4430
CPU	Dual-core 1 GHz
Sensors	Accelerometer, proximity, compass
Messaging	SMS(threaded view), MMS, Email, Push Mail, IM, RSS
Browser	HTML, Adobe Flash
Radio	No
GPS	Yes, with A-GPS support
Java	Yes, via Java MIDP emulator
Colors	Black, Silver
 	- Active noise cancellation with dedicated mic
- DivX/MP4/H.264/H.263 player
- MP3/WAV/eAAC+/AC3 player
- Organizer
- Image/video editor
- Document viewer
- Google Search, Maps, Gmail,
YouTube, Calendar, Google Talk, Picasa
- Voice memo/dial
- Predictive text input
BATTERY	 	Non-removable Li-Ion 1150 mAh battery
Stand-by	Up to 300 h
Talk time	Up to 4 h', 4700000, 1, 3)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (2, N'PN002', N'Panasonic X300', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
SIM	Mini-SIM
Announced	2004, 1Q
Status	Discontinued
BODY	Dimensions	92 x 49 x 21 mm, 88 cc (3.62 x 1.93 x 0.83 in)
Weight	87 g (3.07 oz)
DISPLAY	Type	CSTN, 65K colors
Size	128 x 128 pixels, 1.5 inches (~121 ppi pixel density)
 	- Pop-up screen
- Wallpapers, themes
- Downloadable logos
SOUND	Alert types	Vibration; Downloadable polyphonic ringtones, composer
Loudspeaker	No
3.5mm jack	No
MEMORY	Card slot	No
Phonebook	500
Call records	10 dialed, 10 received, 10 missed calls
Internal	3 MB
DATA	GPRS	Class 8 (4+1 slots), 32 - 40 kbps
EDGE	No
WLAN	No
Bluetooth	No
USB	Yes
CAMERA	Primary	VGA, 640x480 pixels
Video	Yes
Secondary	No
FEATURES	Messaging	SMS, EMS, MMS
Browser	WAP 2.0/xHTML
Radio	No
Games	3 - Puddleland, Quadball, Exode
GPS	No
Java	No
Colors	Silver, Red, Gold
 	- Predictive text input
- Organizer
- Picture editor
BATTERY	 	Li-Ion 780 mAh battery
Stand-by	Up to 77 h - 260 h
Talk time	Up to 3 h - 11 h', 2180000, 1, 3)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (3, N'PN003', N'Panasonic GD55', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
SIM	Mini-SIM
Announced	2002, Oct
Status	Discontinued
BODY	Dimensions	77 x 43 x 17 mm, 51 cc (3.03 x 1.69 x 0.67 in)
Weight	65 g (2.29 oz)
DISPLAY	Type	Graphics
Size	112 x 64 pixels
 	- Blue backlight
- 20 wallpapers
- CallerID graphics
SOUND	Alert types	Vibration; Polyphonic(4) ringtones, composer
Loudspeaker	No
3.5mm jack	No
MEMORY	Card slot	No
Phonebook	250
Call records	20 dialed, 10 received, 10 missed calls
 	- Message templates
- 100 calendar events
DATA	GPRS	No
EDGE	No
WLAN	No
Bluetooth	No
USB	 
CAMERA	 	No
FEATURES	Messaging	SMS, EMS
Browser	WAP 1.2.1
Radio	No
Clock	Yes
Alarm	Yes
Games	1
GPS	No
Java	No
Colors	3 - Silver, Red, Pink
 	- Predictive text input
- Organizer
BATTERY	 	Li-Ion 720 mAh battery
Stand-by	Up to 230 h
Talk time	Up to 8 h', 499000, 1, 3)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (4, N'PL001', N'Palm Pre 2', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 850 / 1900
 	HSDPA 900 / 2100
SIM	Mini-SIM
Announced	2010, October
Status	Available. Released 2010, November
BODY	Dimensions	100.7 x 59.6 x 16.9 mm (3.96 x 2.35 x 0.67 in)
Weight	145 g (5.11 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT capacitive touchscreen, 16M colors
Size	320 x 480 pixels, 3.1 inches (~186 ppi pixel density)
Multitouch	Yes
Protection	Corning Gorilla Glass
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	No
Internal	16 GB storage, 512 MB RAM
DATA	GPRS	Yes
EDGE	Yes
Speed	HSDPA, 7.2 Mbps; HSUPA, 2 Mbps
WLAN	Wi-Fi 802.11 b/g
Bluetooth	Yes, v2.1 with A2DP, EDR
USB	Yes, microUSB v2.0
CAMERA	Primary	5 MP, 2592х1944 pixels, LED flash
Features	Geo-tagging
Video	Yes
Secondary	No
FEATURES	OS	HP webOS 2.0
CPU	1 GHz
Sensors	Accelerometer, proximity
Messaging	SMS (threaded view), MMS, Email, Push Email
Browser	HTML, Adobe Flash
GPS	Yes, with A-GPS support
Java	Yes, MIDP 2.1
Colors	Black
 	- MP3/WAV/eAAC+ player
- MP4/H.264/H.263 player
- Organizer
- Document viewer
- Voice memo/dial
- Predictive text input
BATTERY	 	Li-Ion battery
Stand-by	Up to 350 h
Talk time	Up to 5 h 30 min', 3900000, 1, 2)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (5, N'PL002', N'Palm Treo 180', N'GENERAL	2G Network	GSM 900 / 1800
 	GSM 900 / 1900 - US version
SIM	Mini-SIM
Announced	2002
Status	Discontinued
BODY	Dimensions	108 x 71 x 21 mm (4.25 x 2.80 x 0.83 in)
Weight	147 g (5.19 oz)
Keyboard	QWERTY
DISPLAY	Type	Monochrome resistive touchscreen, 16 shades
Size	160 x 160 pixels
SOUND	Alert types	Vibration; Monophonic ringtones
Loudspeaker	Yes
3.5mm jack	No
MEMORY	Card slot	No
Internal	16 MB
DATA	GPRS	No
EDGE	No
WLAN	No
Bluetooth	No
Infrared port	Yes
USB	Yes
CAMERA	 	No
FEATURES	OS	Palm OS v3.5.2H
CPU	Motorola DragonBall VZ MC68VZ328 33MHz
Messaging	SMS, MMS, Email
Browser	HTML (Blazer 2.0)
Radio	No
GPS	No
Java	No
Colors	Steel Blue
 	- 33 MHz Motorola Dragonball Processor
- Organizer
- Advanced calculator
- GPRS upgradeable
- Handsfree ear-bud headset included
BATTERY	 	Li-Ion battery
Stand-by	Up to 100 h
Talk time	Up to 2 h 30 min', 3100000, 1, 2)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (6, N'PL003', N'Palm Treo 750', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 850 / 1900 / 2100
SIM	Mini-SIM
Announced	2007, February
Status	Discontinued
BODY	Dimensions	111 x 58 x 22 mm (4.37 x 2.28 x 0.87 in)
Weight	154 g (5.43 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT resistive touchscreen, 65K colors
Size	240 x 240 pixels, 2.5 inches (~136 ppi pixel density)
 	- 5-way navigation button
SOUND	Alert types	Vibration; Downloadable polyphonic, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	No
MEMORY	Card slot	miniSD, up to 2 GB
Internal	60 MB
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Yes
Speed	Yes, 384 kbps
WLAN	No
Bluetooth	Yes, v1.2 with A2DP
Infrared port	Yes
USB	Yes
CAMERA	Primary	1.3 MP, 1280 x 1024 pixels
Features	Video-calling
Video	Yes
Secondary	No
FEATURES	OS	Microsoft Windows Mobile 5.0 PocketPC
CPU	300 MHz Samsung
Messaging	SMS, MMS, Email
Browser	WAP 2.0 / HTML (PocketIE)
Radio	No
GPS	No
Java	Yes, MIDP 2.0
Colors	Black
 	- MP3/AAC/AAC+/WMA/OGG/AMR player
- WMV/MP4 player
- Organizer
- Pocket Office (Word, Excel, PowerPoint, PDF viewer)
- Voice memo
BATTERY	 	Li-Ion 1200 mAh battery
Stand-by	Up to 200 h
Talk time	Up to 4 h 30 min', 1790000, 1, 2)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (7, N'TS', N'Toshiba G450', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
3G Network	HSDPA 2100
SIM	Mini-SIM
Announced	2008, January
Status	Discontinued
BODY	Dimensions	98 x 36 x 16 mm (3.86 x 1.42 x 0.63 in)
Weight	57 g (2.01 oz)
DISPLAY	Type	Monochrome graphics
Size	96 x 39 pixels
SOUND	Alert types	polyphonic, MP3 ringtones
Loudspeaker	No
3.5mm jack	No
MEMORY	Card slot	No
Phonebook	 
Call records	 
Internal	160 MB
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Class 10, 236.8 kbps
Speed	HSDPA, 3.6 Mbps
WLAN	No
Bluetooth	No
USB	Yes, miniUSB
CAMERA	 	No
FEATURES	Chipset	Qualcomm MSM6280
CPU	ARM 9
Messaging	SMS
Browser	No
Radio	No
Games	Yes
GPS	No
Java	No
Colors	Black, Red, White
 	- MP3, AAC, AAC+, eAAC+ player
- Predictive text input
BATTERY	 	Li-Ion 600 mAh battery
Stand-by	Up to 200 h
Talk time	Up to 2 h 20 min', 15700000, 1, 4)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (8, N'TS002', N'Toshiba TS808', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
3G Network	UMTS 2100
SIM	Mini-SIM
Announced	2005, 3Q
Status	Discontinued
BODY	Dimensions	98 x 47 x 23 mm (3.86 x 1.85 x 0.91 in)
Weight	125 g (4.41 oz)
DISPLAY	Type	TFT, 256K colors
Size	240 x 320 pixels, 2.4 inches, 48.8 x 36.6 mm (~167 ppi pixel density)
 	- Second external mono STN display (96 x 160 pixels)
SOUND	Alert types	Vibration; Downloadable polyphonic ringtones
Loudspeaker	Yes
3.5mm jack	No
MEMORY	Card slot	miniSD
Phonebook	Yes
Call records	20 dialed, 20 received, 20 missed calls
Internal	10 MB
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	No
Speed	Yes, 384 kbps
WLAN	No
Bluetooth	Yes
Infrared port	Yes
USB	Yes, v1.1
CAMERA	Primary	1.3 MP, 1280 x 1024 pixels
Video	Yes
Secondary	No
FEATURES	Messaging	SMS, MMS, Email
Browser	WAP 2.0
Radio	No
Games	Yes + downloadable
GPS	No
Java	Yes
Colors	Black
 	- MP3 player
- TV-out
- Voice memo
- Predictive text input
- Photo editor
- Organizer
BATTERY	 	Li-Ion battery
Stand-by	Up to 350 h
Talk time	Up to 2 h 50 min', 2780000, 1, 4)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (9, N'TS003', N'Toshiba G910/G920', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
3G Network	HSDPA 2100
SIM	Mini-SIM
Announced	2008, January. Released 2008, June
Status	Discontinued
BODY	Dimensions	117 x 64 x 19.8 mm, 145 cc (4.61 x 2.52 x 0.78 in)
Weight	183 g (6.46 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT resistive touchscreen, 65K colors
Size	800 x 480 pixels (Wide-VGA), 3.0 inches (~311 ppi pixel density)
SOUND	Alert types	Vibration; Downloadable polyphonic, MP3 ringtones
Loudspeaker	No
3.5mm jack	No
MEMORY	Card slot	microSD, up to 2 GB
Internal	128 MB RAM, 256 MB ROM
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Class 10, 236.8 kbps
Speed	HSDPA, 3.6 Mbps
WLAN	Wi-Fi 802.11b/g, VoIP over WLAN
Bluetooth	Yes, v2.0 with A2DP
USB	Yes
CAMERA	Primary	2 MP, 1600x1200 pixels, autofocus
Video	Yes
Secondary	VGA videocall camera
FEATURES	OS	Microsoft Windows Mobile 6 Professional
Chipset	Qualcomm MSM7200
CPU	400 MHz ARM 11
GPU	Adreno 130
Messaging	SMS, EMS, MMS, Email
Browser	WAP 2.0/xHTML, HTML (Opera 8.6)
Radio	No
GPS	Yes, with A-GPS support
Java	Yes, MIDP 2.0
Colors	Silver
 	- Biometric fingerprint scanner
- Pocket Office (Word, Excel, PowerPoint, PDF viewer)
- MP3/ACC+ player
- Photo editor
- Voice memo
- Organizer
BATTERY	 	Li-Ion 1320 mAh battery
Stand-by	Up to 330 h
Talk time	Up to 4 h 25 min', 7420000, 1, 4)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (10, N'BB001', N'Blackberry Bold 9000', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 850 / 1900 / 2100
SIM	Mini-SIM
Announced	2008, May
Status	Discontinued
BODY	Dimensions	114 x 66 x 14 mm (4.49 x 2.60 x 0.55 in)
Weight	133 g (4.69 oz)
Keyboard	QWERTY
DISPLAY	Type	65K colors
Size	480 x 320 pixels, 2.6 inches (~222 ppi pixel density)
 	- Trackball navigation
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 8 GB
Internal	1 GB storage, 128 MB RAM
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Class 10, 236.8 kbps
Speed	HSDPA, 3.6 Mbps
WLAN	Wi-Fi 802.11 a/b/g
Bluetooth	Yes, v2.0 with A2DP
USB	Yes, miniUSB v2.0
CAMERA	Primary	2 MP, 1600x1200 pixels, LED flash
Video	Yes
Secondary	No
FEATURES	OS	BlackBerry OS
CPU	624 MHz
Messaging	SMS, MMS, Email, IM
Browser	HTML
Radio	No
GPS	Yes, with A-GPS support, BlackBerry Maps
Java	Yes, MIDP 2.0
Colors	Black, White
 	- BlackBerry maps
- Document editor (Word, Excel, PowerPoint, PDF)
- MP4/WMV/H.263/H.264 player
- MP3/eAAC+/WMA player
- Organizer
- Voice memo/dial
BATTERY	 	Li-Ion 1500 mAh battery
Stand-by	Up to 310 h
Talk time	Up to 5 h
MISC	SAR US	 1.51 W/kg (head)     0.95 W/kg (body)    
SAR EU	 0.84 W/kg (head)     0.66 W/kg (body)', 2100000, 1, 1)
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (11, N'BB002', N'Blackberry Q10', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900 - all versions
 	CDMA 800 / 1900 - SQN100-2, SQN100-4
3G Network	HSDPA 850 / 1900 / 2100 - SQN100-1
 	HSDPA 850 / 900 / 1900 / 2100 - SQN100-2, SQN100-3, SQN100-4
HSDPA 850 / 1700 / 1900 / 2100 - SQN100-5
4G Network	LTE 700 / 850 / 1700 / 1900 - SQN100-1, SQN100-5
 	LTE 700 / 1700 - SQN100-2
LTE 800 / 900 / 1800 / 2600 - SQN100-3
LTE 1900 - SQN100-4
SIM	Micro-SIM
Announced	2013, January
Status	Available. Released 2013, April
BODY	Dimensions	119.6 x 66.8 x 10.4 mm (4.71 x 2.63 x 0.41 in)
Weight	139 g (4.90 oz)
Keyboard	QWERTY
DISPLAY	Type	Super AMOLED capacitive touchscreen, 16M colors
Size	720 x 720 pixels, 3.1 inches (~328 ppi pixel density)
Multitouch	Yes
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 64 GB
Internal	16 GB, 2 GB RAM
DATA	GPRS	Yes
EDGE	Yes
Speed	EV-DO Rev. A, up to 3.1 Mbps, HSPA, LTE (market dependent)
WLAN	Wi-Fi 802.11 a/b/g/n, dual band, Wi-Fi hotspot
Bluetooth	Yes, v4.0 with A2DP
NFC	Yes
USB	Yes, microUSB v2.0
CAMERA	Primary	8 MP, 3264 x 2448 pixels, autofocus, LED flash, check quality
Features	Geo-tagging, image stabilization, face detection
Video	Yes, 1080p@30fps, check quality
Secondary	Yes, 2 MP, 720p
FEATURES	OS	BlackBerry 10 OS, upgradable to v10.1
Chipset	Snapdragon S4 (LTE version)/ TI OMAP 4470 (Non-LTE)
CPU	Dual-core 1.5 GHz Krait (LTE version)/ Cortex-A9 (Non-LTE)
GPU	Adreno 225 (LTE version)/ PowerVR SGX544 (Non-LTE)
Sensors	Accelerometer, gyro, proximity, compass
Messaging	SMS, MMS, Email, Push Email, IM, BBM 6
Browser	HTML5
Radio	No
GPS	Yes, with A-GPS support
Java	Yes, MIDP 2.1
Colors	Black, White
 	- SNS integration
- HDMI port
- BlackBerry maps
- Organizer
- Document editor
- Photo viewer
- MP3/WMA/WAV/eAAC+/FlAC player
- DivX/XviD/MP4/WMV/H.263/H.264 player
- Voice memo/dial
- Predictive text input
BATTERY	 	Li-Ion 2100 mAh battery
Stand-by	 (2G) / Up to 360 h (3G)
Talk time	Up to 10 h (2G) / Up to 13 h 30 min (3G)
MISC	SAR US	 1.16 W/kg (head)     0.75 W/kg (body)    
SAR EU	 1.41 W/kg (head)     0.78 W/kg (body)    
Price group	About 310 EUR
TESTS	Display	Contrast ratio: Infinite (nominal) / 2.856:1 (sunlight)
Loudspeaker	Voice 69dB / Noise 66dB / Ring 75dB
Audio quality	Noise -89.6dB / Crosstalk -82.7dB
Camera	Photo / Video
Battery life	Endurance rating 56h', 12090000, 1, 1)
SET IDENTITY_INSERT [dbo].[SanPhams] OFF
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([id], [key], [value]) VALUES (1, N'path_to_website', N'http://localhost:12430')
SET IDENTITY_INSERT [dbo].[Settings] OFF
/****** Object:  Index [IX_donhang_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_donhang_id] ON [dbo].[ChiTiet_DonHang]
(
	[donhang_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_sanpham_chitiet_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_sanpham_chitiet_id] ON [dbo].[ChiTiet_DonHang]
(
	[sanpham_chitiet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_nhaphang_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_nhaphang_id] ON [dbo].[ChiTiet_NhapHang]
(
	[nhaphang_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_sanpham_chitiet_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_sanpham_chitiet_id] ON [dbo].[ChiTiet_NhapHang]
(
	[sanpham_chitiet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_sanpham_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_sanpham_id] ON [dbo].[HinhAnhs]
(
	[sanpham_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_mausac_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_mausac_id] ON [dbo].[SanPham_ChiTiet]
(
	[mausac_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_sanpham_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_sanpham_id] ON [dbo].[SanPham_ChiTiet]
(
	[sanpham_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_hangsx_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_hangsx_id] ON [dbo].[SanPhams]
(
	[hangsx_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_sanpham_chitiet_id]    Script Date: 05/01/2014 11:14:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_sanpham_chitiet_id] ON [dbo].[TonKhoes]
(
	[sanpham_chitiet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTiet_DonHang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTiet_DonHang_dbo.DonHangs_donhang_id] FOREIGN KEY([donhang_id])
REFERENCES [dbo].[DonHangs] ([id])
GO
ALTER TABLE [dbo].[ChiTiet_DonHang] CHECK CONSTRAINT [FK_dbo.ChiTiet_DonHang_dbo.DonHangs_donhang_id]
GO
ALTER TABLE [dbo].[ChiTiet_DonHang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTiet_DonHang_dbo.SanPham_ChiTiet_sanpham_chitiet_id] FOREIGN KEY([sanpham_chitiet_id])
REFERENCES [dbo].[SanPham_ChiTiet] ([id])
GO
ALTER TABLE [dbo].[ChiTiet_DonHang] CHECK CONSTRAINT [FK_dbo.ChiTiet_DonHang_dbo.SanPham_ChiTiet_sanpham_chitiet_id]
GO
ALTER TABLE [dbo].[ChiTiet_NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTiet_NhapHang_dbo.NhapHangs_nhaphang_id] FOREIGN KEY([nhaphang_id])
REFERENCES [dbo].[NhapHangs] ([id])
GO
ALTER TABLE [dbo].[ChiTiet_NhapHang] CHECK CONSTRAINT [FK_dbo.ChiTiet_NhapHang_dbo.NhapHangs_nhaphang_id]
GO
ALTER TABLE [dbo].[ChiTiet_NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTiet_NhapHang_dbo.SanPham_ChiTiet_sanpham_chitiet_id] FOREIGN KEY([sanpham_chitiet_id])
REFERENCES [dbo].[SanPham_ChiTiet] ([id])
GO
ALTER TABLE [dbo].[ChiTiet_NhapHang] CHECK CONSTRAINT [FK_dbo.ChiTiet_NhapHang_dbo.SanPham_ChiTiet_sanpham_chitiet_id]
GO
ALTER TABLE [dbo].[HinhAnhs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HinhAnhs_dbo.SanPhams_sanpham_id] FOREIGN KEY([sanpham_id])
REFERENCES [dbo].[SanPhams] ([id])
GO
ALTER TABLE [dbo].[HinhAnhs] CHECK CONSTRAINT [FK_dbo.HinhAnhs_dbo.SanPhams_sanpham_id]
GO
ALTER TABLE [dbo].[SanPham_ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SanPham_ChiTiet_dbo.MauSacs_mausac_id] FOREIGN KEY([mausac_id])
REFERENCES [dbo].[MauSacs] ([id])
GO
ALTER TABLE [dbo].[SanPham_ChiTiet] CHECK CONSTRAINT [FK_dbo.SanPham_ChiTiet_dbo.MauSacs_mausac_id]
GO
ALTER TABLE [dbo].[SanPham_ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SanPham_ChiTiet_dbo.SanPhams_sanpham_id] FOREIGN KEY([sanpham_id])
REFERENCES [dbo].[SanPhams] ([id])
GO
ALTER TABLE [dbo].[SanPham_ChiTiet] CHECK CONSTRAINT [FK_dbo.SanPham_ChiTiet_dbo.SanPhams_sanpham_id]
GO
ALTER TABLE [dbo].[SanPhams]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SanPhams_dbo.HangSXes_hangsx_id] FOREIGN KEY([hangsx_id])
REFERENCES [dbo].[HangSXes] ([id])
GO
ALTER TABLE [dbo].[SanPhams] CHECK CONSTRAINT [FK_dbo.SanPhams_dbo.HangSXes_hangsx_id]
GO
ALTER TABLE [dbo].[TonKhoes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TonKhoes_dbo.SanPham_ChiTiet_sanpham_chitiet_id] FOREIGN KEY([sanpham_chitiet_id])
REFERENCES [dbo].[SanPham_ChiTiet] ([id])
GO
ALTER TABLE [dbo].[TonKhoes] CHECK CONSTRAINT [FK_dbo.TonKhoes_dbo.SanPham_ChiTiet_sanpham_chitiet_id]
GO
USE [master]
GO
ALTER DATABASE [CuaHangDTDD] SET  READ_WRITE 
GO
