IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CuaHangDTDD')
BEGIN
    CREATE DATABASE CuaHangDTDD
END
GO
USE [CuaHangDTDD]
GO
/****** Object:  Table [dbo].[ChiTiet_DonHang]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[ChiTiet_NhapHang]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[DonHangs]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[HangSXes]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[HinhAnhs]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[MauSacs]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[NhapHangs]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[SanPham_ChiTiet]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[SanPhams]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[Settings]    Script Date: 08/01/2014 11:12:27 PM ******/
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
/****** Object:  Table [dbo].[TonKhoes]    Script Date: 08/01/2014 11:12:27 PM ******/
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
SET IDENTITY_INSERT [dbo].[ChiTiet_DonHang] ON 

GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (1, 2, 3900000, 1, 9)
GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (2, 1, 2100000, 1, 23)
GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (3, 2, 2100000, 2, 23)
GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (4, 2, 4700000, 2, 2)
GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (5, 1, 1790000, 3, 38)
GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (6, 1, 5790000, 3, 40)
GO
INSERT [dbo].[ChiTiet_DonHang] ([id], [soluong], [dongia], [donhang_id], [sanpham_chitiet_id]) VALUES (7, 1, 4100000, 4, 31)
GO
SET IDENTITY_INSERT [dbo].[ChiTiet_DonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTiet_NhapHang] ON 

GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (1, 10, 4500000, 1, 1)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (2, 10, 4500000, 1, 2)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (3, 10, 2000000, 1, 3)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (4, 10, 2000000, 1, 4)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (5, 10, 390000, 1, 5)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (6, 5, 390000, 1, 6)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (7, 3, 390000, 1, 7)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (8, 1, 390000, 1, 8)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (9, 20, 3500000, 1, 9)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (10, 20, 3500000, 1, 10)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (11, 5, 3000000, 1, 11)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (12, 5, 3000000, 1, 12)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (13, 3, 3000000, 1, 13)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (14, 3, 2500000, 1, 14)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (15, 7, 14000000, 1, 15)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (16, 7, 14000000, 1, 16)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (17, 7, 14000000, 1, 17)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (18, 7, 14000000, 1, 18)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (19, 13, 1800000, 1, 23)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (20, 1, 6700000, 2, 25)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (21, 1, 6700000, 2, 26)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (22, 1, 10000000, 2, 27)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (23, 2, 10000000, 2, 28)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (24, 2, 6000000, 2, 29)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (25, 2, 6000000, 2, 30)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (26, 2, 1900000, 2, 31)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (27, 17, 12000000, 2, 32)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (28, 1, 450000, 2, 34)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (29, 1, 2000000, 3, 23)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (30, 2, 1200000, 4, 40)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (31, 1, 199000, 4, 38)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (32, 1, 199000, 4, 34)
GO
INSERT [dbo].[ChiTiet_NhapHang] ([id], [soluong], [dongia], [nhaphang_id], [sanpham_chitiet_id]) VALUES (33, 4, 2100000, 6, 33)
GO
SET IDENTITY_INSERT [dbo].[ChiTiet_NhapHang] OFF
GO
SET IDENTITY_INSERT [dbo].[DonHangs] ON 

GO
INSERT [dbo].[DonHangs] ([id], [ngay], [tongtien], [dagiaohang], [active], [kh_ten], [kh_diachi], [kh_email], [kh_sdt]) VALUES (1, CAST(0x0000A2AB016C707A AS DateTime), 9900000, 1, 1, N'Nguyễn Quốc Dũng', N'692/17 Nguyễn Tri Phương, P12, Q10, HCM', N'quocdunginfo@gmail.com', N'0979996234')
GO
INSERT [dbo].[DonHangs] ([id], [ngay], [tongtien], [dagiaohang], [active], [kh_ten], [kh_diachi], [kh_email], [kh_sdt]) VALUES (2, CAST(0x0000A2AC0174F855 AS DateTime), 13600000, 1, 1, N'Trần Hài', N'123 An Dương Vương, Q5, HCM', N'hoangthuo@yahoo.com', N'0123876523')
GO
INSERT [dbo].[DonHangs] ([id], [ngay], [tongtien], [dagiaohang], [active], [kh_ten], [kh_diachi], [kh_email], [kh_sdt]) VALUES (3, CAST(0x0000A2AD0175FDD4 AS DateTime), 7580000, 0, 1, N'Phạm Văn Trớt', N'Đoàn Dự, 32 Nguyễn Bính, Phòng 1, Lầu 6', N'tran_van_trot_xiteeen@gmail.com', N'113')
GO
INSERT [dbo].[DonHangs] ([id], [ngay], [tongtien], [dagiaohang], [active], [kh_ten], [kh_diachi], [kh_email], [kh_sdt]) VALUES (4, CAST(0x0000A2AD01764D7C AS DateTime), 4100000, 1, 1, N'Phạm Thị Troll', N'69 Trần hưng Đạo, P4, Q5', N'tranbinh_563454@hotmail.com', N'115')
GO
SET IDENTITY_INSERT [dbo].[DonHangs] OFF
GO
SET IDENTITY_INSERT [dbo].[HangSXes] ON 

GO
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (1, N'Blackberry', 1)
GO
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (2, N'Palm', 1)
GO
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (3, N'Panasonic', 1)
GO
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (4, N'Toshiba', 1)
GO
INSERT [dbo].[HangSXes] ([id], [ten], [active]) VALUES (5, N'Nokia', 1)
GO
SET IDENTITY_INSERT [dbo].[HangSXes] OFF
GO
SET IDENTITY_INSERT [dbo].[HinhAnhs] ON 

GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (1, N'9A995782C3A2CC57DB0C.jpg', N'_thumb_9A995782C3A2CC57DB0C.jpg', 0, 1)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (2, N'12943333FB26E7ABFB33.jpg', N'_thumb_12943333FB26E7ABFB33.jpg', 0, 1)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (3, N'F5CAB9BFEADABA135DD2.jpg', N'_thumb_F5CAB9BFEADABA135DD2.jpg', 0, 1)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (4, N'5E477F5002F6F33C9284.JPG', N'_thumb_5E477F5002F6F33C9284.JPG', 1, 1)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (5, N'22A6B1CFDFEE3A1BAC4D.jpg', N'_thumb_22A6B1CFDFEE3A1BAC4D.jpg', 1, 2)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (8, N'427E0EA91C519889D1D6.jpg', N'_thumb_427E0EA91C519889D1D6.jpg', 0, 2)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (9, N'64589EF6CF82292E4449.jpg', N'_thumb_64589EF6CF82292E4449.jpg', 0, 2)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (10, N'93730169CA57DC38D1A2.jpg', N'_thumb_93730169CA57DC38D1A2.jpg', 1, 3)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (11, N'9C691255DF349F275E59.jpg', N'_thumb_9C691255DF349F275E59.jpg', 1, 4)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (12, N'FB2B612F1BC3E61D7C36.jpg', N'_thumb_FB2B612F1BC3E61D7C36.jpg', 1, 5)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (13, N'2958BDF10C7BEEB05D2D.jpg', N'_thumb_2958BDF10C7BEEB05D2D.jpg', 1, 6)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (14, N'FE969938BF38AA79D36C.jpg', N'_thumb_FE969938BF38AA79D36C.jpg', 0, 6)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (15, N'C3016B12C560F1A6594F.jpg', N'_thumb_C3016B12C560F1A6594F.jpg', 1, 7)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (16, N'5790FCE31D758CF2AA05.jpg', N'_thumb_5790FCE31D758CF2AA05.jpg', 0, 7)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (17, N'A5D76F3AEACE36A98AF4.jpg', N'_thumb_A5D76F3AEACE36A98AF4.jpg', 0, 7)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (18, N'77383390731835F1A0EA.JPG', N'_thumb_77383390731835F1A0EA.JPG', 1, 8)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (19, N'1616CEF1FEF8C68D9B91.JPG', N'_thumb_1616CEF1FEF8C68D9B91.JPG', 0, 8)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (20, N'EA9C293A13CA2F6E9E8B.jpg', N'_thumb_EA9C293A13CA2F6E9E8B.jpg', 1, 9)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (21, N'DC63CB137C38368F11E0.jpg', N'_thumb_DC63CB137C38368F11E0.jpg', 0, 9)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (22, N'55904CAEBB253195C277.JPG', N'_thumb_55904CAEBB253195C277.JPG', 1, 10)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (23, N'73CD8B89ED119793E255.jpg', N'_thumb_73CD8B89ED119793E255.jpg', 0, 10)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (24, N'E9D4153458896ABB9F2C.jpg', N'_thumb_E9D4153458896ABB9F2C.jpg', 0, 10)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (25, N'3EF456D5F77AC5E64252.jpg', N'_thumb_3EF456D5F77AC5E64252.jpg', 0, 10)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (26, N'48F53B0C9CE46A1137BD.jpg', N'_thumb_48F53B0C9CE46A1137BD.jpg', 0, 10)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (27, N'A71C685A439E31DCDAE5.jpg', N'_thumb_A71C685A439E31DCDAE5.jpg', 0, 10)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (28, N'FC5FC931AD4C602D9E59.JPG', N'_thumb_FC5FC931AD4C602D9E59.JPG', 1, 11)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (29, N'A674EE2FC27F539571AD.JPG', N'_thumb_A674EE2FC27F539571AD.JPG', 0, 11)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (30, N'E1C89F5E22A07F4AFE12.JPG', N'_thumb_E1C89F5E22A07F4AFE12.JPG', 0, 11)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (31, N'893A4944D319B1BD8A8D.jpg', N'_thumb_893A4944D319B1BD8A8D.jpg', 0, 11)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (40, N'74AD9CE80C6EDFD01FCA.JPG', N'_thumb_74AD9CE80C6EDFD01FCA.JPG', 1, 13)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (41, N'D4ABFFE59C1E62FC8B87.JPG', N'_thumb_D4ABFFE59C1E62FC8B87.JPG', 0, 13)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (42, N'0AF41325F8E120D49933.jpg', N'_thumb_0AF41325F8E120D49933.jpg', 0, 13)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (43, N'81847EBB9445AC21FFAB.jpg', N'_thumb_81847EBB9445AC21FFAB.jpg', 0, 13)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (44, N'0245A98E61E4E5574B55.jpg', N'_thumb_0245A98E61E4E5574B55.jpg', 0, 14)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (45, N'3FEC85F568C3A908864E.jpg', N'_thumb_3FEC85F568C3A908864E.jpg', 0, 14)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (46, N'47E92AD8A1902FCC3879.jpg', N'_thumb_47E92AD8A1902FCC3879.jpg', 0, 14)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (47, N'E971750772B90EE07781.JPG', N'_thumb_E971750772B90EE07781.JPG', 1, 14)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (50, N'5E4C96BB8A61869CD835.jpg', N'_thumb_5E4C96BB8A61869CD835.jpg', 1, 15)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (51, N'23169563796C464054CF.jpg', N'_thumb_23169563796C464054CF.jpg', 0, 15)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (52, N'1B0B7B17FE476AB0BC6A.jpg', N'_thumb_1B0B7B17FE476AB0BC6A.jpg', 0, 15)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (53, N'7B2C08C3D3AD24003290.jpg', N'_thumb_7B2C08C3D3AD24003290.jpg', 0, 16)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (54, N'3635D3BD35EE94B384DD.jpg', N'_thumb_3635D3BD35EE94B384DD.jpg', 0, 16)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (55, N'5E62AE7A77B9886F603D.jpg', N'_thumb_5E62AE7A77B9886F603D.jpg', 0, 16)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (56, N'E1E5C25CBC77E12279A5.JPG', N'_thumb_E1E5C25CBC77E12279A5.JPG', 0, 16)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (57, N'0618990738BC24B85247.JPG', N'_thumb_0618990738BC24B85247.JPG', 1, 16)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (58, N'BCBF30B130F8C6E9D333.jpg', N'_thumb_BCBF30B130F8C6E9D333.jpg', 0, 17)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (59, N'52C072098FF97683F476.jpg', N'_thumb_52C072098FF97683F476.jpg', 0, 17)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (60, N'A25DBB96EBE7151F9F2A.jpg', N'_thumb_A25DBB96EBE7151F9F2A.jpg', 0, 17)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (61, N'6D36A77DBAEED3093828.JPG', N'_thumb_6D36A77DBAEED3093828.JPG', 1, 17)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (62, N'DF4B3C305D1A82AC2EDD.JPG', N'_thumb_DF4B3C305D1A82AC2EDD.JPG', 0, 17)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (63, N'8D1ED924549FB7386ACA.jpg', N'_thumb_8D1ED924549FB7386ACA.jpg', 0, 18)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (64, N'B306FADF62088A51B086.jpg', N'_thumb_B306FADF62088A51B086.jpg', 0, 18)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (65, N'0B9A8448333253AF2AC0.jpg', N'_thumb_0B9A8448333253AF2AC0.jpg', 0, 18)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (66, N'5E7FD0B4BA5929B33E35.jpg', N'_thumb_5E7FD0B4BA5929B33E35.jpg', 1, 18)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (67, N'72C536FD7F206409405D.jpg', N'_thumb_72C536FD7F206409405D.jpg', 0, 19)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (68, N'0A6D703EFAA61212CDFB.jpg', N'_thumb_0A6D703EFAA61212CDFB.jpg', 0, 19)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (69, N'CF979FAC9FA3E7D378C0.jpg', N'_thumb_CF979FAC9FA3E7D378C0.jpg', 1, 19)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (70, N'47840F8ED481BE2E85A3.jpg', N'_thumb_47840F8ED481BE2E85A3.jpg', 0, 19)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (71, N'09AA1FEF8BAD895A0E45.jpg', N'_thumb_09AA1FEF8BAD895A0E45.jpg', 0, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (72, N'7E62033AAD669C6CD622.jpg', N'_thumb_7E62033AAD669C6CD622.jpg', 0, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (73, N'C144B699D88B526B3C2C.jpg', N'_thumb_C144B699D88B526B3C2C.jpg', 0, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (74, N'D924AC5E6CF06A403D28.jpg', N'_thumb_D924AC5E6CF06A403D28.jpg', 0, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (75, N'FDB2B297E4F9085339BA.jpg', N'_thumb_FDB2B297E4F9085339BA.jpg', 0, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (76, N'B2E098997B179F96A5EB.jpg', N'_thumb_B2E098997B179F96A5EB.jpg', 0, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (77, N'428CFA51F4103A26A649.jpg', N'_thumb_428CFA51F4103A26A649.jpg', 1, 20)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (78, N'6BA3985B022C7F4C060B.jpg', N'_thumb_6BA3985B022C7F4C060B.jpg', 0, 21)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (79, N'E735431D56B0D433A7FC.JPG', N'_thumb_E735431D56B0D433A7FC.JPG', 0, 21)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (80, N'A06A9032E6FBDE24B45C.JPG', N'_thumb_A06A9032E6FBDE24B45C.JPG', 1, 21)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (81, N'6E2666FA69A1709609F7.gif', N'_thumb_6E2666FA69A1709609F7.gif', 0, 22)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (82, N'B0DFD4759B67E038C528.jpg', N'_thumb_B0DFD4759B67E038C528.jpg', 0, 22)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (83, N'56B1D86A83089289DDB5.jpg', N'_thumb_56B1D86A83089289DDB5.jpg', 1, 22)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (84, N'90F195FA5429F735D759.jpg', N'_thumb_90F195FA5429F735D759.jpg', 0, 23)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (85, N'EEE66263DC74C23CF549.jpg', N'_thumb_EEE66263DC74C23CF549.jpg', 1, 23)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (86, N'237B43F1117390008C03.jpg', N'_thumb_237B43F1117390008C03.jpg', 0, 24)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (87, N'D4CD08FD52AF49D4C299.jpg', N'_thumb_D4CD08FD52AF49D4C299.jpg', 0, 24)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (88, N'0500123C320D162B9314.JPG', N'_thumb_0500123C320D162B9314.JPG', 0, 24)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (89, N'0E9FFC8EDB42B6CAB29F.JPG', N'_thumb_0E9FFC8EDB42B6CAB29F.JPG', 1, 24)
GO
INSERT [dbo].[HinhAnhs] ([id], [duongdan], [duongdan_thumb], [macdinh], [sanpham_id]) VALUES (90, N'211033008CA00EB54341.jpg', N'_thumb_211033008CA00EB54341.jpg', 1, 25)
GO
SET IDENTITY_INSERT [dbo].[HinhAnhs] OFF
GO
SET IDENTITY_INSERT [dbo].[MauSacs] ON 

GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (1, N'Xanh biển', 1)
GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (2, N'Đen', 1)
GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (3, N'Đỏ', 1)
GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (4, N'Vàng', 1)
GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (5, N'Trắng', 1)
GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (6, N'Hồng', 1)
GO
INSERT [dbo].[MauSacs] ([id], [giatri], [active]) VALUES (7, N'Xám', 1)
GO
SET IDENTITY_INSERT [dbo].[MauSacs] OFF
GO
SET IDENTITY_INSERT [dbo].[NhapHangs] ON 

GO
INSERT [dbo].[NhapHangs] ([id], [ngay], [tongtien], [active]) VALUES (1, CAST(0x0000A2AB016F867E AS DateTime), 739310000, 1)
GO
INSERT [dbo].[NhapHangs] ([id], [ngay], [tongtien], [active]) VALUES (2, CAST(0x0000A2AB0173A30F AS DateTime), 275650000, 1)
GO
INSERT [dbo].[NhapHangs] ([id], [ngay], [tongtien], [active]) VALUES (3, CAST(0x0000A2AB01742846 AS DateTime), 2000000, 1)
GO
INSERT [dbo].[NhapHangs] ([id], [ngay], [tongtien], [active]) VALUES (4, CAST(0x0000A2AC0175BA2F AS DateTime), 2798000, 1)
GO
INSERT [dbo].[NhapHangs] ([id], [ngay], [tongtien], [active]) VALUES (6, CAST(0x0000A2AD01783690 AS DateTime), 8400000, 1)
GO
SET IDENTITY_INSERT [dbo].[NhapHangs] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham_ChiTiet] ON 

GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (1, 1, 10, 2, 1)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (2, 1, 8, 1, 1)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (3, 1, 10, 7, 2)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (4, 1, 10, 4, 2)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (5, 1, 10, 1, 3)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (6, 1, 5, 2, 3)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (7, 1, 3, 5, 3)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (8, 1, 1, 6, 3)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (9, 1, 18, 2, 4)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (10, 1, 20, 5, 4)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (11, 1, 5, 7, 5)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (12, 1, 5, 3, 5)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (13, 1, 3, 1, 6)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (14, 1, 3, 2, 6)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (15, 1, 7, 1, 7)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (16, 1, 7, 2, 7)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (17, 1, 7, 3, 7)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (18, 1, 7, 4, 7)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (19, 1, 0, 5, 7)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (20, 1, 0, 1, 8)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (21, 1, 0, 6, 8)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (22, 1, 0, 2, 9)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (23, 1, 11, 2, 10)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (24, 1, 0, 5, 10)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (25, 1, 1, 2, 11)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (26, 1, 1, 5, 11)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (27, 1, 1, 2, 13)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (28, 1, 2, 3, 13)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (29, 1, 2, 2, 14)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (30, 1, 2, 5, 14)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (31, 1, 1, 4, 17)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (32, 1, 17, 7, 16)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (33, 1, 4, 2, 18)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (34, 1, 2, 1, 19)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (35, 1, 0, 2, 20)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (36, 1, 0, 6, 20)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (37, 1, 0, 4, 23)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (38, 1, 0, 2, 23)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (39, 1, 0, 1, 24)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (40, 1, 1, 2, 24)
GO
INSERT [dbo].[SanPham_ChiTiet] ([id], [active], [tonkho], [mausac_id], [sanpham_id]) VALUES (41, 1, 0, 1, 25)
GO
SET IDENTITY_INSERT [dbo].[SanPham_ChiTiet] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPhams] ON 

GO
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
GO
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
GO
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
GO
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
GO
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
GO
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
GO
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
GO
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
GO
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
GO
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
GO
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
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (13, N'BB003', N'Blackberry Z30', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 850 / 900 / 1900 / 2100 / 800
4G Network	LTE 800 / 900 / 1800 / 2100 / 2600
SIM	Micro-SIM
Announced	2013, September
Status	Available. Released 2013, October
BODY	Dimensions	140.7 x 72 x 9.4 mm (5.54 x 2.83 x 0.37 in)
Weight	170 g (6.00 oz)
DISPLAY	Type	Super AMOLED capacitive touchscreen, 16M colors
Size	720 x 1280 pixels, 5.0 inches (~294 ppi pixel density)
Multitouch	Yes
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes, with stereo speakers
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 64 GB
Internal	16 GB, 2 GB RAM
DATA	GPRS	Yes
EDGE	Yes
Speed	HSDPA, HSUPA, LTE
WLAN	Wi-Fi 802.11 a/b/g/n, dual-band, Wi-Fi Direct, Wi-Fi hotspot
Bluetooth	Yes, v4.0 with A2DP, LE
NFC	Yes
USB	Yes, microUSB v2.0, USB On-the-go
CAMERA	Primary	8 MP, 3264 x 2448 pixels, autofocus, LED flash, check quality
Features	Geo-tagging, face detection, image stabilization, HDR
Video	Yes, 1080p@30fps, video stabilization, check quality
Secondary	Yes, 2 MP, 720p@30fps
FEATURES	OS	BlackBerry 10.2 OS
Chipset	Qualcomm MSM8960T Pro Snapdragon
CPU	Dual-core 1.7 GHz Krait
GPU	Adreno 320
Sensors	Accelerometer, gyro, proximity, compass
Messaging	SMS, MMS, Email, Push Email, IM, BBM 6
Browser	HTML5, Adobe Flash
Radio	No
GPS	Yes, with A-GPS support and GLONASS
Java	Yes, MIDP 2.1
Colors	Black
 	- Active noise cancellation with dedicated mic
- SNS integration
- HDMI port
- BlackBerry maps
- Organizer
- Document editor
- Photo/video editor
- MP3/WMA/WAV/eAAC+/FlAC player
- DivX/XviD/MP4/WMV/H.263/H.264 player
- Voice memo/dial
- Predictive text input
BATTERY	 	Li-Ion 2880 mAh battery
Stand-by	 (2G) / Up to 384 h (3G)
Talk time	Up to 25 h (2G) / Up to 18 h (3G)', 12990000, 1, 1)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (14, N'BB004', N'Blackberry Q5', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900 - all versions
3G Network	HSDPA 800 / 850 / 1700 / 1900 / 2100 - SQR100-1
 	HSDPA 850 / 900 / 1900 / 2100 - SQR100-2, SQR100-3
4G Network	LTE 700 / 850 / 1700 / 1900 / 2100 - SQR100-1
 	LTE 800 / 900 / 1800 / 2600 - SQR100-2
SIM	Micro-SIM
Announced	2013, May
Status	Available. Released 2013, June
BODY	Dimensions	120 x 66 x 10.8 mm (4.72 x 2.60 x 0.43 in)
Weight	120 g (4.23 oz)
Keyboard	QWERTY
DISPLAY	Type	IPS LCD capacitive touchscreen, 16M colors
Size	720 x 720 pixels, 3.1 inches (~328 ppi pixel density)
Multitouch	Yes
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 32 GB
Internal	8 GB, 2 GB RAM
DATA	GPRS	Yes
EDGE	Yes
Speed	DC-HSPA+, 42 Mbps; HSDPA; LTE, Cat3, 50 Mbps UL, 100 Mbps DL
WLAN	Wi-Fi 802.11 b/g/n, Wi-Fi hotspot
Bluetooth	Yes, v4.0 with A2DP, LE
NFC	Yes (market dependent)
USB	Yes, microUSB v2.0
CAMERA	Primary	5 MP, 2592х1944 pixels, autofocus, LED flash, check quality
Features	Geo-tagging, touch focus, image stabilization
Video	Yes, 1080p@30fps, video stabilization, check quality
Secondary	Yes, 2 MP, 720p
FEATURES	OS	BlackBerry 10 OS, upgradable to v10.1
Chipset	Qualcomm Snapdragon 4
CPU	Dual-core 1.2 GHz
Sensors	Accelerometer, gyro, proximity, compass
Messaging	SMS, MMS, Email, Push Email, IM, BBM 6
Browser	HTML5
Radio	No
GPS	Yes, with A-GPS support
Java	Yes, MIDP 2.1
Colors	Black, White, Red, Gray, Pink
 	- SNS integration
- BlackBerry maps
- Organizer
- Document viewer
- Photo viewer
- MP3/WMA/WAV/eAAC+ player
- Xvid/MP4/WMV/MKV/H.263/H.264 player
- Voice memo/dial
- Predictive text input
BATTERY	 	Non-removable Li-Ion 2180 mAh battery
Stand-by	 (2G) / Up to 336 h (3G)
Talk time	 (2G) / Up to 12 h 30 min (3G)
MISC	SAR US	 1.33 W/kg (head)     0.85 W/kg (body)    
SAR EU	 1.38 W/kg (head)     0.85 W/kg (body)    
Price group	About 200 EUR
TESTS	Display	Contrast ratio: 1293:1 (nominal) / 1.682:1 (sunlight)
Loudspeaker	Voice 75dB / Noise 69dB / Ring 76dB
Audio quality	Noise -91.7dB / Crosstalk -90.7dB
Camera	Photo / Video
Battery life	Endurance rating 55h', 9342000, 1, 1)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (15, N'NK001', N'Nokia N73 ME', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	UMTS 2100
SIM	Mini-SIM
Announced	2006, April. Released 2006, August
Status	Discontinued
BODY	Dimensions	110 x 49 x 19 mm (4.33 x 1.93 x 0.75 in)
Weight	116 g (4.09 oz)
DISPLAY	Type	TFT, 256K colors
Size	240 x 320 pixels, 2.4 inches, 36 x 48 mm (~167 ppi pixel density)
 	- Downloadable themes
- Light sensor
SOUND	Alert types	Vibration; Downloadable polyphonic, MP3 ringtones
Loudspeaker	Yes, with stereo speakers
3.5mm jack	No
MEMORY	Card slot	miniSD
Internal	42 MB storage, 64 MB RAM
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Class 11, 236.8 kbps
Speed	Yes, 384 kbps
WLAN	No
Bluetooth	Yes, v2.0 with A2DP (latest firmware)
Infrared port	Yes
USB	Yes, v2.0, Pop-Port
CAMERA	Primary	3.15 MP, 2048x1536 pixels, Carl Zeiss optics, autofocus, LED flash
Video	Yes, CIF
Secondary	VGA videocall camera
FEATURES	OS	Symbian OS 9.1, S60 3rd edition
CPU	220 MHz Dual ARM 9
Messaging	SMS, MMS, Email, Instant Messaging
Browser	WAP 2.0/xHTML, HTML
Radio	Stereo FM radio; Visual radio
GPS	No
Java	Yes, MIDP 2.0
Colors	Silver Grey/Deep Plum, Frost White/Metallic Red, Black (Music Edition)
 	- Push to talk
- Video download
- WMV/RV/MP4/3GP video player
- MP3/WMA/WAV/RA/AAC/M4A music player
- Predictive text input
- Voice command/dial
- Organizer
- Printing
- Document viewer (Word, Excel, PowerPoint, PDF)
- Photo/video editor
BATTERY	 	Li-Ion 1100 mAh battery (BP-6M )
Stand-by	Up to 350 h (2G) / 370 h (3G)
Talk time	Up to 6 h (2G) / 3 h 46 min (3G)', 2500000, 1, 5)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (16, N'NK002', N'Nokia Lumia 1520', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900 - all versions
3G Network	HSDPA 850 / 900 / 1900 / 2100 - RM-937, RM-939, RM-940
 	HSDPA 850 / 900 / 1700 / 1900 / 2100 - RM-938
4G Network	LTE 800 / 900 / 1800 / 2100 / 2600 - RM-937
 	LTE 700 / 850 / 1700 / 1900 / 2100 / 2600 - RM-938, RM-940
SIM	Nano-SIM
Announced	2013, October
Status	Available. Released 2013, November
BODY	Dimensions	162.8 x 85.4 x 8.7 mm, 120.3 cc (6.41 x 3.36 x 0.34 in)
Weight	209 g (7.37 oz)
DISPLAY	Type	IPS LCD capacitive touchscreen, 16M colors
Size	1080 x 1920 pixels, 6.0 inches (~367 ppi pixel density)
Multitouch	Yes
Protection	Corning Gorilla Glass 2
 	- ClearBlack display
SOUND	Alert types	Vibration; MP3, WAV ringtones
Loudspeaker	Yes
3.5mm jack	Yes
 	- Dolby Headphone sound enhancement
MEMORY	Card slot	microSD, up to 64 GB
Internal	16 GB (RM-940 only)/32 GB, 2 GB RAM
DATA	GPRS	Yes
EDGE	Up to 236.8 kbps
Speed	HSDPA, 42.2 Mbps; HSUPA, 5.76 Mbps; LTE, Cat4, 50 Mbps UL, 150 Mbps DL
WLAN	Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi hotspot
Bluetooth	Yes, v4.0 with A2DP
NFC	Yes
USB	Yes, microUSB v2.0
CAMERA	Primary	20 MP, Carl Zeiss optics, optical image stabilization, autofocus, dual-LED flash, check quality
Features	1/2.5'''' sensor size, PureView technology, dual capture, geo-tagging, face detection, panorama
Video	Yes, 1080p@30fps, video light, stereo sound rec., check quality
Secondary	Yes, 1.2 MP, 720p@30fps
FEATURES	OS	Microsoft Windows Phone 8 Black
Chipset	Qualcomm MSM8974 Snapdragon 800
CPU	Quad-core 2.2 GHz Krait 400
GPU	Adreno 330
Sensors	Accelerometer, gyro, proximity, compass
Messaging	SMS (threaded view), MMS, Email, Push Email, IM
Browser	HTML5
Radio	FM radio
GPS	Yes, with A-GPS support and GLONASS
Java	No
Colors	Yellow, white, black, red
 	- SNS integration
- Active noise cancellation with a dedicated mic
- 7GB free SkyDrive storage
- MP3/WMA/WAV/eAAC+ player
- MP4/DivX/XviD/H.264/H.263/WMV player
- Organizer
- Document viewer
- Video/photo editor
- Voice memo/command/dial
- Predictive text input
BATTERY	 	Non-removable Li-Ion 3400 mAh battery (BV-4BW)
Stand-by	Up to 768 h (2G) / Up to 768 h (3G)
Talk time	Up to 27 h 40 min (2G) / Up to 25 h (3G)
Music play	Up to 124 h', 14890000, 1, 5)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (17, N'NK003', N'Nokia Asha 210', N'GENERAL	2G Network	GSM 850 / 1900 - RM-926
900 / 1800 - RM-925
 	GSM 900 / 1800 - SIM 1 & SIM 2 - RM-924
SIM	Optional Dual SIM (Mini-SIM)
Announced	2013, April
Status	Available. Released 2013, May
BODY	Dimensions	111.5 x 60 x 11.8 mm, 76.3 cc (4.39 x 2.36 x 0.46 in)
Weight	97.3 g (3.42 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT, 65K colors
Size	320 x 240 pixels, 2.4 inches (~167 ppi pixel density)
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 32 GB
Phonebook	1000 entries
Call records	Yes
Internal	64 MB, 32 MB RAM
DATA	GPRS	Class 32
EDGE	Class 32
WLAN	Wi-Fi 802.11 b/g
Bluetooth	Yes, v2.1 with EDR
USB	Yes, microUSB
CAMERA	Primary	2 MP, 1600x1200 pixels
Video	Yes, QCIF@10fps
Secondary	No
FEATURES	Messaging	SMS(threaded view), MMS, Email, IM
Browser	WAP 2.0/xHTML
Radio	Stereo FM radio with RDS; FM recording
Games	Yes
GPS	No
Java	Yes, MIDP 2.1
Colors	Yellow, Black, White, Cyan, Magenta
 	- SNS apps
- MP4/H.263/WMV player
- MP3/WAV/WMA/AAC player
- Organizer
- Voice memo
- Predictive text input
BATTERY	 	Li-Ion 1200 mAh battery (BL-4U)
Stand-by	Up to 1104 h
Talk time	Up to 12 h
Music play	Up to 40 h', 4100000, 1, 5)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (18, N'NK004', N'Nokia N93', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
3G Network	UMTS 2100
SIM	Mini-SIM
Announced	2006, April
Status	Discontinued
BODY	Dimensions	118 x 55.5 x 28.2 mm, 133 cc (4.65 x 2.19 x 1.11 in)
Weight	180 g (6.35 oz)
DISPLAY	Type	TFT, 256K colors
Size	240 x 320 pixels, 2.4 inches, 36 x 48 mm (~167 ppi pixel density)
 	- Second 65K colors display (128 x 36 pixels)
- Twist and rotating screen
- Downloadable themes
SOUND	Alert types	Vibration; Downloadable polyphonic, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	No
MEMORY	Card slot	miniSD, 128 MB included
Internal	50 MB storage, 64 MB RAM
DATA	GPRS	Class 32, 107.2/64.2 kbps
EDGE	Class 32, 296 kbps; DTM Class 11, 236.8 kbps
Speed	Yes, 384 kbps
WLAN	Wi-Fi 802.11b/g
Bluetooth	Yes, v2.0
Infrared port	Yes
USB	Yes, v2.0
CAMERA	Primary	3.15 MP, 2048x1536 pixels, 3x optical zoom, Carl Zeiss optics, autofocus, LED flash
Video	Yes, VGA@30fps
Secondary	CIF videocall camera
FEATURES	OS	Symbian OS 9.1, S60 3rd edition
CPU	332 MHz Dual ARM 11
GPU	3D Graphics HW Accelerator
Messaging	SMS, MMS, Email, Instant Messaging
Browser	WAP 2.0/xHTML, HTML
Radio	Stereo FM radio; Visual radio
GPS	No
Java	Yes, MIDP 2.0
Colors	Black, Silver
 	- Video download
- UPnP technology
- Push to talk
- WMV/RV/MP4/3GP video player
- MP3/WMA/WAV/RA/AAC/M4A music player
- Predictive text input
- TV-out
- Voice command/memo
- Organizer
- Printing
- Photo/video editor
BATTERY	 	Li-Po 1100 mAh battery (BP-6M)
Stand-by	Up to 240 h (2G) / 240 h (3G)
Talk time	Up to 5 h (2G) / 3 h 42 min (3G)', 3500000, 1, 5)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (19, N'NK005', N'Nokia 7110', N'GENERAL	2G Network	GSM 900 / 1800
SIM	Mini-SIM
Announced	
Status	Discontinued
BODY	Dimensions	125 x 53 x 24 mm, 125 cc (4.92 x 2.09 x 0.94 in)
Weight	141 g (4.97 oz)
DISPLAY	Type	Monochrome graphic
Size	96 x 65 pixels, 6 lines
 	- Dynamic font size 
- Softkey
SOUND	Alert types	Vibration; Downloadable monophonic ringtones
Loudspeaker	No
3.5mm jack	No
 	- Profile Selection
- Ascending ringing tones
- Personal alert tones
MEMORY	Card slot	No
Phonebook	1000
Call records	10 dialed, 10 received, 10 missed calls
 	- 3 numbers and 1 text field for each name
DATA	GPRS	No
EDGE	No
WLAN	No
Bluetooth	No
Infrared port	Yes
USB	 
CAMERA	 	No
FEATURES	Messaging	SMS
Browser	WAP
Radio	No
Clock	Yes
Alarm	Yes
Games	4
Languages	34 total
GPS	No
Java	No
Colors	Dark green
 	- Predictive text input
- Navi roller
- Organizer
BATTERY	 	Li-Po 600 mAh battery (BPS-1)
Stand-by	35 - 170 h
Talk time	1 h 40 min - 3 h
 	Slim, Li-Ion 900 mAh, 141 g (BLS-2N)
Stand-by	Up to 260 h
Talk time	Up to 4 h 30 min', 450000, 1, 5)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (20, N'NK006', N'Nokia N96', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 900 / 2100
 	HSDPA 850 / 1900 - American version
SIM	Mini-SIM
Announced	2008, February. Released 2008, September
Status	Discontinued
BODY	Dimensions	103 x 55 x 18 mm, 92 cc (4.06 x 2.17 x 0.71 in)
Weight	125 g (4.41 oz)
DISPLAY	Type	TFT, 16M colors
Size	240 x 320 pixels, 2.8 inches (~143 ppi pixel density)
SOUND	Alert types	Vibration, MP3, WAV ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 32 GB
Internal	16 GB storage, 128 MB RAM
DATA	GPRS	Class 32, 107 / 64.2 kbps
EDGE	Class 32, 296 kbps; DTM Class 11, 177 kbps
Speed	HSDPA, 3.6 Mbps
WLAN	Wi-Fi 802.11 b/g, UPnP technology
Bluetooth	Yes, v2.0 with A2DP
USB	Yes, microUSB v2.0
CAMERA	Primary	5 MP, 2592x1944 pixels, Carl Zeiss optics, autofocus, LED flash
Video	Yes, VGA@30fps
Secondary	VGA videocall camera
FEATURES	OS	Symbian OS 9.3, S60 rel. 3.2
CPU	264 MHz Dual ARM 9
Sensors	Accelerometer
Messaging	SMS, MMS, Email, Instant Messaging
Browser	WAP 2.0/xHTML, HTML, RSS reader
Radio	Stereo FM radio with RDS; Visual radio
GPS	Yes, with A-GPS support; Nokia Maps
Java	Yes, MIDP 2.1
Colors	Black, Silver, Quartz
 	- DVB-H TV broadcast receiver
- Dual slide design
- WMV/RV/MP4/3GP video player
- MP3/WMA/WAV/RA/AAC/M4A music player
- TV-out
- Organizer
- Document viewer (Word, Excel, PowerPoint, PDF)
- Predictive text input
- Push to talk 
- Voice dial/memo
- Kickstand
BATTERY	 	Li-Ion 950 mAh battery (BL-5F)
Stand-by	Up to 220 h (2G) / 192 h (3G)
Talk time	Up to 3 h 40 min (2G) / 2 h 36 min (3G)
Music play	Up to 14 h', 2199000, 1, 5)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (21, N'BB006', N'Blackberry Bold 9900', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 850 / 1900 / 2100 / 800
 	HSDPA 900 / 1700 / 2100
SIM	Mini-SIM
Announced	2011, May
Status	Available. Released 2011, August
BODY	Dimensions	115 x 66 x 10.5 mm (4.53 x 2.60 x 0.41 in)
Weight	130 g (4.59 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT capacitive touchscreen, 16M colors
Size	640 x 480 pixels, 2.8 inches (~286 ppi pixel density)
 	- Optical trackpad
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 32 GB
Internal	8GB storage, 768 MB RAM
DATA	GPRS	Yes
EDGE	Yes
Speed	HSDPA 14.4Mbps, HSUPA 5.76Mbps
WLAN	Wi-Fi 802.11 b/g/n, dual-band
Bluetooth	Yes, v2.1 with A2DP, EDR
NFC	Yes
USB	Yes, microUSB v2.0
CAMERA	Primary	5 MP, 2592x1944 pixels, LED flash, check quality
Features	Geo-tagging, face detection, image stabilization
Video	Yes, 720p, check quality
Secondary	No
FEATURES	OS	BlackBerry OS 7.0
CPU	1.2 GHz QC 8655
Sensors	Proximity, compass
Messaging	SMS, MMS, Email, Push Email, IM
Browser	HTML
Radio	No
GPS	Yes, with A-GPS support, BlackBerry Maps
Java	Yes, MIDP 2.1
Colors	Black, White
 	- BlackBerry maps
- Document viewer
- MP4/WMV/H.263/H.264 player
- MP3/eAAC+/WMA player
- Organizer
- Voice memo/dial
- Predictive text input
BATTERY	 	Li-Ion 1230 mAh battery
Stand-by	Up to 307 h (2G) / Up to 307 h (3G)
Talk time	Up to 6 h 30 min (2G) / Up to 5 h 50 min (3G)
Music play	Up to 50 h', 3690000, 1, 1)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (22, N'BB007', N'Blackberry 8830', N'GENERAL	2G Network	GSM 900 / 1800 / CDMA2000 1x EV-DO
SIM	Mini-SIM
Announced	2007, April
Status	Discontinued
BODY	Dimensions	114 x 66 x 14 mm (4.49 x 2.60 x 0.55 in)
Weight	132 g (4.66 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT, 65K colors
Size	320 x 240 pixels, 2.5 inches (~160 ppi pixel density)
 	- Trackball navigation
SOUND	Alert types	Vibration; Polyphonic, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	No
MEMORY	Card slot	microSD
Internal	64 MB storage, 16 MB RAM
DATA	GPRS	Yes
EDGE	Yes
WLAN	No
Bluetooth	Yes, v2.0
USB	Yes, miniUSB
CAMERA	 	No
FEATURES	OS	BlackBerry OS
Chipset	Qualcomm MSM6550
Messaging	SMS, MMS, Email, Instant Messaging
Browser	HTML
Radio	No
GPS	Yes
Java	Yes
Colors	Black
 	- BlackBerry maps
- Media player
- Organizer
- Organizer
- Document viewer (Word, Excel, PowerPoint, PDF)
- Voice dial
BATTERY	 	Li-Ion 1400 mAh battery', 499000, 1, 1)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (23, N'BB008', N'Blackberry 8220', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
SIM	Mini-SIM
Announced	2008, September. Released 2008, October
Status	Discontinued
BODY	Dimensions	101.1 x 50 x 17.5 mm (3.98 x 1.97 x 0.69 in)
Weight	102 g (3.60 oz)
Keyboard	Half-QWERTY
DISPLAY	Type	65K colors
Size	240 x 320 pixels, 2.6 inches (~154 ppi pixel density)
 	- Secondary external 65K TFT display, 128x160 pixels
- Trackball navigation
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 8 GB
Internal	75 MB
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Class 10, 236.8 kbps
WLAN	Wi-Fi 802.11 b/g
Bluetooth	Yes, v2.0 with A2DP
USB	Yes, microUSB v2.0
CAMERA	Primary	2 MP, 1600x1200 pixels, LED flash
Video	Yes
Secondary	No
FEATURES	OS	BlackBerry OS
CPU	32-bit Intel XScale PXA272 312 MHz
Messaging	SMS, MMS, Email, IM
Browser	HTML
Radio	No
GPS	No
Java	Yes, MIDP 2.0
Colors	Black
 	- BlackBerry maps
- Document editor (Word, Excel, PowerPoint, PDF)
- MP4/WMV/H.263/H.264 player
- MP3/eAAC+/WMA player
- Organizer
- Voice memo/dial
BATTERY	 	Li-Ion 900 mAh battery
Stand-by	Up to 336 h
Talk time	Up to 4 h', 1790000, 1, 1)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (24, N'BB009', N'Blackberry 9800', N'GENERAL	2G Network	GSM 850 / 900 / 1800 / 1900
3G Network	HSDPA 850 / 1900 / 2100 /800
SIM	Mini-SIM
Announced	2010, August
Status	Available. Released 2010, August
BODY	Dimensions	111 x 62 x 14.6 mm (4.37 x 2.44 x 0.57 in)
Weight	161 g (5.68 oz)
Keyboard	QWERTY
DISPLAY	Type	TFT capacitive touchscreen, 16M colors
Size	360 x 480 pixels, 3.2 inches (~188 ppi pixel density)
Multitouch	Yes
 	- Optical trackpad
SOUND	Alert types	Vibration, MP3 ringtones
Loudspeaker	Yes
3.5mm jack	Yes
MEMORY	Card slot	microSD, up to 32 GB, 4 GB included
Internal	4 GB storage, 512 MB RAM, 512 MB ROM
DATA	GPRS	Class 10 (4+1/3+2 slots), 32 - 48 kbps
EDGE	Class 10, 236.8 kbps
Speed	HSDPA; HSUPA
WLAN	Wi-Fi 802.11 b/g/n, UMA (carrier-dependent)
Bluetooth	Yes, v2.1 with A2DP
USB	Yes, microUSB v2.0
CAMERA	Primary	5 MP, 2592х1944 pixels, autofocus, LED flash, check quality
Features	Geo-tagging, image stabilization
Video	Yes, VGA@24fps
Secondary	No
FEATURES	OS	BlackBerry OS 6.0
CPU	624 MHz
Sensors	Proximity
Messaging	SMS, MMS, Email, Push Email, IM
Browser	HTML
Radio	No
GPS	Yes, with A-GPS support
Java	Yes, MIDP 2.0
Colors	Black, White, Dark Orange
 	- Social feeds
- BlackBerry maps
- Document viewer (Word, Excel, PowerPoint)
- Media player MP3/WMA/eAAC+/FlAC/OGG player
- Video player DivX/XviD/MP4/WMV/H.263/H.264
- Organizer
- Voice memo/dial
BATTERY	 	Li-Ion 1300 mAh battery
Stand-by	Up to 432 h (2G) / Up to 336 h (3G)
Talk time	Up to 5 h 30 min (2G) / Up to 5 h 40 min (3G)
Music play	Up to 30 h', 5790000, 1, 1)
GO
INSERT [dbo].[SanPhams] ([id], [masp], [ten], [mota], [gia], [active], [hangsx_id]) VALUES (25, N'BB010', N'Blackberry 6230', N'GENERAL	2G Network	GSM 900 / 1800 / 1900
SIM	Mini-SIM
Announced	2003, 2Q
Status	Discontinued
BODY	Dimensions	113 x 75 x 20 mm (4.45 x 2.95 x 0.79 in)
Weight	136 g (4.80 oz)
Keyboard	QWERTY
DISPLAY	Type	Monochrome
Size	, 2.6 inches
SOUND	Alert types	Vibration; Monophonic ringtones
Loudspeaker	Yes
3.5mm jack	No
MEMORY	Card slot	No
Internal	16 MB storage, 1 MB RAM
DATA	GPRS	
EDGE	No
WLAN	No
Bluetooth	No
USB	Yes
CAMERA	 	No
FEATURES	OS	BlackBerry OS
Messaging	SMS, Email
Browser	HTML
Radio	No
GPS	No
Java	No
Colors	 
 	- Organize
BATTERY	 	Li-Ion battery
Stand-by	Up to 380 h
Talk time	Up to 5 h', 199000, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[SanPhams] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

GO
INSERT [dbo].[Settings] ([id], [key], [value]) VALUES (1, N'path_to_website', N'http://localhost:12430')
GO
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[TonKhoes] ON 

GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (1, 10, CAST(0x0000A2AB016F867E AS DateTime), 1)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (2, 10, CAST(0x0000A2AB016F867E AS DateTime), 2)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (3, 10, CAST(0x0000A2AB016F867E AS DateTime), 3)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (4, 10, CAST(0x0000A2AB016F867E AS DateTime), 4)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (5, 10, CAST(0x0000A2AB016F867E AS DateTime), 5)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (6, 5, CAST(0x0000A2AB016F867E AS DateTime), 6)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (7, 3, CAST(0x0000A2AB016F867E AS DateTime), 7)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (8, 1, CAST(0x0000A2AB016F867E AS DateTime), 8)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (9, 20, CAST(0x0000A2AB016F867E AS DateTime), 9)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (10, 20, CAST(0x0000A2AB016F867E AS DateTime), 10)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (11, 5, CAST(0x0000A2AB016F867E AS DateTime), 11)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (12, 5, CAST(0x0000A2AB016F867E AS DateTime), 12)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (13, 3, CAST(0x0000A2AB016F867E AS DateTime), 13)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (14, 3, CAST(0x0000A2AB016F867E AS DateTime), 14)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (15, 7, CAST(0x0000A2AB016F867E AS DateTime), 15)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (16, 7, CAST(0x0000A2AB016F867E AS DateTime), 16)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (17, 7, CAST(0x0000A2AB016F867E AS DateTime), 17)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (18, 7, CAST(0x0000A2AB016F867E AS DateTime), 18)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (19, 13, CAST(0x0000A2AB016F867E AS DateTime), 23)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (20, 18, CAST(0x0000A2AB016C707A AS DateTime), 9)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (21, 12, CAST(0x0000A2AB016C707A AS DateTime), 23)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (22, 1, CAST(0x0000A2AB0173A30F AS DateTime), 25)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (23, 1, CAST(0x0000A2AB0173A30F AS DateTime), 26)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (24, 1, CAST(0x0000A2AB0173A30F AS DateTime), 27)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (25, 2, CAST(0x0000A2AB0173A30F AS DateTime), 28)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (26, 2, CAST(0x0000A2AB0173A30F AS DateTime), 29)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (27, 2, CAST(0x0000A2AB0173A30F AS DateTime), 30)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (28, 2, CAST(0x0000A2AB0173A30F AS DateTime), 31)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (29, 17, CAST(0x0000A2AB0173A30F AS DateTime), 32)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (30, 1, CAST(0x0000A2AB0173A30F AS DateTime), 34)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (31, 13, CAST(0x0000A2AB01742846 AS DateTime), 23)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (32, 11, CAST(0x0000A2AC0174F855 AS DateTime), 23)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (33, 8, CAST(0x0000A2AC0174F855 AS DateTime), 2)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (34, 2, CAST(0x0000A2AC0175BA2F AS DateTime), 34)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (35, 1, CAST(0x0000A2AC0175BA2F AS DateTime), 38)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (36, 2, CAST(0x0000A2AC0175BA2F AS DateTime), 40)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (37, 0, CAST(0x0000A2AD0175FDD4 AS DateTime), 38)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (38, 1, CAST(0x0000A2AD0175FDD4 AS DateTime), 40)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (39, 1, CAST(0x0000A2AD01764D7C AS DateTime), 31)
GO
INSERT [dbo].[TonKhoes] ([id], [soluong], [ngay], [sanpham_chitiet_id]) VALUES (40, 4, CAST(0x0000A2AD01783690 AS DateTime), 33)
GO
SET IDENTITY_INSERT [dbo].[TonKhoes] OFF
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
