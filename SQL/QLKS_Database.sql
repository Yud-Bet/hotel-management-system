USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 12/28/2020 9:11:02 AM ******/
CREATE DATABASE [QLKS]
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKS', N'ON'
GO
ALTER DATABASE [QLKS] SET QUERY_STORE = OFF
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillDate] [date] NULL,
	[RoomReservationID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[TotalMoney] [money] NOT NULL,
	[ServiceTotalMoney] [money] NOT NULL,
	[Discount] [int] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[BillID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ServiceCount] [int] NULL,
	[ServicePrice] [money] NULL,
 CONSTRAINT [PK_BillDetail] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[Birthday] [date] NULL,
	[IdentityNumber] [nvarchar](50) NULL,
	[Passport] [nvarchar](50) NULL,
	[Addr] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[Sex] [bit] NULL,
	[Nationality] [nvarchar](50) NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodsReceipt]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodsReceipt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ImporterReceiptTime] [date] NULL,
	[StaffID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[TotalMoney] [money] NOT NULL,
	[ImproterReceiptNote] [nvarchar](100) NULL,
 CONSTRAINT [PK_GoodsReceipt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](10) NULL,
	[Price] [money] NOT NULL,
	[Total] [int] NULL,
	[SupplierID] [int] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomTypeID] [int] NOT NULL,
	[Area] [int] NULL,
	[Status_] [tinyint] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomReservation]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomReservation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReservationDate] [date] NOT NULL,
	[ArrivalDate] [date] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[DownPayment] [money] NOT NULL,
	[RoomCharge] [money] NOT NULL,
	[PaymentStatus] [bit] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_RoomReservation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomReservationDetail]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomReservationDetail](
	[RoomReservationID] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
	[RoomPrice] [money] NOT NULL,
 CONSTRAINT [PK_RoomReservationDetail] PRIMARY KEY CLUSTERED 
(
	[RoomReservationID] ASC,
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicesBillOnly]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicesBillOnly](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillServiceOnlyDate] [date] NULL,
	[StaffID] [int] NOT NULL,
	[TotalMoney] [money] NOT NULL,
	[Discount] [int] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_BillServiceOnly] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicesBillOnlyDetail]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicesBillOnlyDetail](
	[BillServiceOnlyID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ServiceCount] [int] NULL,
	[ServicePrice] [money] NULL,
 CONSTRAINT [PK_BillServiceOnlyDetail] PRIMARY KEY CLUSTERED 
(
	[BillServiceOnlyID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTb]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTb](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceTypeID] [int] NOT NULL,
	[Name_] [nvarchar](50) NULL,
	[Unit] [nvarchar](10) NULL,
	[Price] [money] NOT NULL,
	[Status] [bit] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_ServiceTb] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_ServiceType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](25) NULL,
	[Password] [nvarchar](100) NOT NULL,
	[BirthDay] [date] NULL,
	[Sex] [bit] NOT NULL,
	[Addr] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[IdentityNumber] [nvarchar](50) NULL,
	[Position] [bit] NOT NULL,
	[StartingDate] [date] NULL,
	[Salary] [money] NULL,
	[Status] [bit] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](20) NULL,
	[Addr] [nvarchar](100) NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([ID], [Name_], [Birthday], [IdentityNumber], [Passport], [Addr], [PhoneNumber], [Sex], [Nationality], [Note]) VALUES (1, N'Khach le', CAST(N'2000-01-01' AS Date), N'000000000', N'', N'Không', N'0000000000', 0, N'Khong', N'Nhung khach hang vang lai')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 
GO
INSERT [dbo].[Staff] ([ID], [Name_], [Username], [Password], [BirthDay], [Sex], [Addr], [PhoneNumber], [IdentityNumber], [Position], [StartingDate], [Salary], [Status], [Note]) VALUES (1, N'Admin', N'1', N'xMpCOKC5I4INzFCab3WEmw==', CAST(N'2001-01-01' AS Date), 0, N'Quảng Trị', N'0366588558', N'197197197', 0, CAST(N'2020-01-01' AS Date), 50000000.0000, 1, N'Tài khoản được tạo mặc định cho Admin')
GO
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceType] ON 
GO
INSERT [dbo].[ServiceType] ([ID], [Name_], [Note]) VALUES (1, N'Ăn uống', NULL)
GO
INSERT [dbo].[ServiceType] ([ID], [Name_], [Note]) VALUES (2, N'Giặt ủi', NULL)
GO
SET IDENTITY_INSERT [dbo].[ServiceType] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTb] ON 
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (1, 2, N'Giặt sấy', NULL, 30000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (2, 2, N'Là ủi', NULL, 30000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (3, 1, N'Bia', NULL, 15000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (4, 1, N'Coca', NULL, 15000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (5, 1, N'Cơm thường', NULL, 30000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (6, 1, N'Cơm đặt biệt', NULL, 50000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (7, 1, N'Cafe đen', NULL, 20000.0000, 1, NULL)
GO
INSERT [dbo].[ServiceTb] ([ID], [ServiceTypeID], [Name_], [Unit], [Price], [Status], [Note]) VALUES (8, 1, N'Cafe sữa', NULL, 20000.0000, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[ServiceTb] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomType] ON 
GO
INSERT [dbo].[RoomType] ([ID], [Name_], [Price], [Note]) VALUES (1, N'Đơn víp', 400000.0000, NULL)
GO
INSERT [dbo].[RoomType] ([ID], [Name_], [Price], [Note]) VALUES (2, N'Đối víp', 600000.0000, NULL)
GO
INSERT [dbo].[RoomType] ([ID], [Name_], [Price], [Note]) VALUES (3, N'Đơn thường', 200000.0000, NULL)
GO
INSERT [dbo].[RoomType] ([ID], [Name_], [Price], [Note]) VALUES (4, N'Đối thường', 400000.0000, NULL)
GO
SET IDENTITY_INSERT [dbo].[RoomType] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (1, 1, 100, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (2, 2, 200, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (3, 3, 300, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (4, 4, 400, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (5, 1, 100, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (6, 2, 200, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (7, 3, 300, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (8, 4, 400, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (9, 4, 200, 1, NULL)
GO
INSERT [dbo].[Room] ([ID], [RoomTypeID], [Area], [Status_], [Note]) VALUES (10, 2, 300, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[BillDetail] ADD  DEFAULT ((0)) FOR [ServiceCount]
GO
ALTER TABLE [dbo].[BillDetail] ADD  DEFAULT ((0)) FOR [ServicePrice]
GO
ALTER TABLE [dbo].[RoomReservation] ADD  DEFAULT ((0)) FOR [PaymentStatus]
GO
ALTER TABLE [dbo].[ServicesBillOnly] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[ServicesBillOnlyDetail] ADD  DEFAULT ((0)) FOR [ServiceCount]
GO
ALTER TABLE [dbo].[ServicesBillOnlyDetail] ADD  DEFAULT ((0)) FOR [ServicePrice]
GO
ALTER TABLE [dbo].[ServiceTb] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_RoomReservation] FOREIGN KEY([RoomReservationID])
REFERENCES [dbo].[RoomReservation] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_RoomReservation]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Staff]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Bill] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Bill]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_ServiceTb] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[ServiceTb] ([ID])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_ServiceTb]
GO
ALTER TABLE [dbo].[GoodsReceipt]  WITH CHECK ADD  CONSTRAINT [FK_GoodsReceipt_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[GoodsReceipt] CHECK CONSTRAINT [FK_GoodsReceipt_Product]
GO
ALTER TABLE [dbo].[GoodsReceipt]  WITH CHECK ADD  CONSTRAINT [FK_GoodsReceipt_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[GoodsReceipt] CHECK CONSTRAINT [FK_GoodsReceipt_Staff]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_RoomType] FOREIGN KEY([RoomTypeID])
REFERENCES [dbo].[RoomType] ([ID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_RoomType]
GO
ALTER TABLE [dbo].[RoomReservation]  WITH CHECK ADD  CONSTRAINT [FK_RoomReservation_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[RoomReservation] CHECK CONSTRAINT [FK_RoomReservation_Customer]
GO
ALTER TABLE [dbo].[RoomReservation]  WITH CHECK ADD  CONSTRAINT [FK_RoomReservation_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[RoomReservation] CHECK CONSTRAINT [FK_RoomReservation_Staff]
GO
ALTER TABLE [dbo].[RoomReservationDetail]  WITH CHECK ADD  CONSTRAINT [FK_RoomReservationDetail_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[RoomReservationDetail] CHECK CONSTRAINT [FK_RoomReservationDetail_Room]
GO
ALTER TABLE [dbo].[RoomReservationDetail]  WITH CHECK ADD  CONSTRAINT [FK_RoomReservationDetail_RoomReservation] FOREIGN KEY([RoomReservationID])
REFERENCES [dbo].[RoomReservation] ([ID])
GO
ALTER TABLE [dbo].[RoomReservationDetail] CHECK CONSTRAINT [FK_RoomReservationDetail_RoomReservation]
GO
ALTER TABLE [dbo].[ServicesBillOnly]  WITH CHECK ADD  CONSTRAINT [FK_BillServiceOnly_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[ServicesBillOnly] CHECK CONSTRAINT [FK_BillServiceOnly_Staff]
GO
ALTER TABLE [dbo].[ServicesBillOnlyDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillServiceOnlyDetail_BillServiceOnly] FOREIGN KEY([BillServiceOnlyID])
REFERENCES [dbo].[ServicesBillOnly] ([ID])
GO
ALTER TABLE [dbo].[ServicesBillOnlyDetail] CHECK CONSTRAINT [FK_BillServiceOnlyDetail_BillServiceOnly]
GO
ALTER TABLE [dbo].[ServicesBillOnlyDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillServiceOnlyDetail_ServiceTb] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[ServiceTb] ([ID])
GO
ALTER TABLE [dbo].[ServicesBillOnlyDetail] CHECK CONSTRAINT [FK_BillServiceOnlyDetail_ServiceTb]
GO
ALTER TABLE [dbo].[ServiceTb]  WITH CHECK ADD  CONSTRAINT [FK_ServiceTb_ServiceType] FOREIGN KEY([ServiceTypeID])
REFERENCES [dbo].[ServiceType] ([ID])
GO
ALTER TABLE [dbo].[ServiceTb] CHECK CONSTRAINT [FK_ServiceTb_ServiceType]
GO
/****** Object:  StoredProcedure [dbo].[QLKS_AddNewRoom]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_AddNewRoom]
	-- Add the parameters for the stored procedure here
	@RoomTypeID int,
	@Area int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	insert into Room (RoomTypeID, Area, Status_)
	values (@RoomTypeID, @Area, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_AddNewService]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_AddNewService]
	-- Add the parameters for the stored procedure here
	@ServiceTypeID int,
	@Name nvarchar(50),
	@Price money 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;

    -- Insert statements for procedure here
	insert into ServiceTb (ServiceTypeID, Name_, Price)
	values (@ServiceTypeID, @Name, @Price)
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_AddNewStaff]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_AddNewStaff]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@Username nvarchar(25),
	@Password nvarchar(100),
	@Birthday date,
	@Sex bit,
	@Addr nvarchar(100),
	@PhoneNumber varchar(20),
	@IdentityNumber nvarchar(50),
	@Position bit,
	@StartingDate date,
	@Salary money,
	@Note nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	
	insert into Staff (Name_, Username, Password, BirthDay,Sex, Addr, PhoneNumber, IdentityNumber, Position, StartingDate, Salary, Note)
	values (@Name, CONVERT(nvarchar(50),IDENT_CURRENT('Staff')), @Password, @Birthday, @Sex, @Addr, @PhoneNumber, @IdentityNumber, @Position, @StartingDate, @Salary, @Note)
	select IDENT_CURRENT('Staff')
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_ChangePassword]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_ChangePassword]
	@Username nvarchar(25),
	@OldPassword nvarchar(100),
	@NewPassword nvarchar(100)
AS
BEGIN
	SET NOCOUNT OFF;

	update Staff
	set Password = @NewPassword
	where Username = @Username and Password = @OldPassword
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_ChangeReservationInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_ChangeReservationInfo]
	-- Add the parameters for the stored procedure here
	@RoomID INT,
	@Name NVARCHAR(50),
	@Birthday DATE,
	@PhoneNumber NVARCHAR(50),
	@Sex BIT,
	@IdentityNumber NVARCHAR(50),
	@Passport NVARCHAR(50),
	@Addr NVARCHAR(100),
	@Note NVARCHAR(100),
	@ArrivalDate DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	declare @RoomReservationID int,
			@CustomerID int

	set @RoomReservationID = (select distinct RR.ID
								from RoomReservation RR, RoomReservationDetail RRD
								where RRD.RoomID = @RoomID and 
										RR.ID = RRD.RoomReservationID and
										RR.PaymentStatus = 0)
	set @CustomerID = (select distinct CustomerID
					from RoomReservation
					where ID = @RoomReservationID)

	if (@RoomReservationID is not null)
		begin
			update RoomReservation
			set ArrivalDate = @ArrivalDate,
				CustomerID = @CustomerID,
				Note = @Note
			where ID = @RoomReservationID

			update Customer
			set Name_ = @Name,
				Birthday = @Birthday,
				IdentityNumber = @IdentityNumber,
				Passport = @Passport,
				Addr = @Addr,
				PhoneNumber = @PhoneNumber,
				Sex = @Sex
			where ID = @CustomerID
		end

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_ChangeRoomInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_ChangeRoomInfo]
	-- Add the parameters for the stored procedure here
	@RoomID int,
	@Area int,
	@Status_ int,
	@RoomTypeID int,
	@Note nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	
	update Room
	set Area = @Area, Status_ = @Status_, RoomTypeID = @RoomTypeID, Note = @Note
	where ID = @RoomID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_EditRoom]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_EditRoom]
	-- Add the parameters for the stored procedure here
	@RoomID INT,
	@RoomTypeID TINYINT	,
	@Area INT,
	@Price money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	
	update Room
	set RoomTypeID = @RoomTypeID, Area = @Area
	where ID = @RoomID
	update RoomType
	set Price = @Price
	where ID = @RoomTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_EditRoomType]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_EditRoomType]
	-- Add the parameters for the stored procedure here
	@RoomTypeID TINYINT,
	@Name nvarchar(50),
	@Price money,
	@Note nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	
	update RoomType
	set Name_ = @Name, Price = @Price, Note = @Note
	where ID = @RoomTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAdditionalInfoForBillViewing]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAdditionalInfoForBillViewing]
	-- Add the parameters for the stored procedure here
	@BillID int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	select C.ID, C.Name_, C.PhoneNumber, C.Addr, RR.ArrivalDate, B.BillDate, S.Name_
	from Bill B, RoomReservation RR, Customer C, Staff S
	where	B.RoomReservationID = RR.ID and
			RR.CustomerID = C.ID and
			B.StaffID = S.ID and
			B.ID = @BillID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllBillInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAllBillInfo]
	-- Add the parameters for the stored procedure here
	@FromDate date,
	@ToDate date,
	@StaffID int,
	@Sort int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@StaffID <= 0)
		if (@Sort = 0 )
			select B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
			from Bill B, RoomReservation RR, Staff S
			where	B.RoomReservationID = RR.ID and
					B.StaffID = S.ID and
					BillDate >= @FromDate and BillDate <= @ToDate
			order by  B.TotalMoney asc, B.BillDate asc
		else if (@Sort = 1)
			select B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
			from Bill B, RoomReservation RR, Staff S
			where	B.RoomReservationID = RR.ID and
					B.StaffID = S.ID and
					BillDate >= @FromDate and BillDate <= @ToDate
			order by B.TotalMoney desc, B.BillDate asc
		else 
			select B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
			from Bill B, RoomReservation RR, Staff S
			where	B.RoomReservationID = RR.ID and
					B.StaffID = S.ID and
					BillDate >= @FromDate and BillDate <= @ToDate
			order by B.BillDate asc
	else
		if (@Sort = 0 )
			select B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
			from Bill B, RoomReservation RR, Staff S
			where	B.RoomReservationID = RR.ID and
					B.StaffID = S.ID and
					S.ID = @StaffID and
					BillDate >= @FromDate and BillDate <= @ToDate
			order by  B.TotalMoney asc, B.BillDate asc
		else if (@Sort = 1)
			select B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
			from Bill B, RoomReservation RR, Staff S
			where	B.RoomReservationID = RR.ID and
					B.StaffID = S.ID and
					S.ID = @StaffID and
					BillDate >= @FromDate and BillDate <= @ToDate
			order by B.TotalMoney desc, B.BillDate asc
		else 
			select B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
			from Bill B, RoomReservation RR, Staff S
			where	B.RoomReservationID = RR.ID and
					B.StaffID = S.ID and
					S.ID = @StaffID and
					BillDate >= @FromDate and BillDate <= @ToDate
			order by B.BillDate asc
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllCustomer]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAllCustomer]
	-- Add the parameters for the stored procedure here
	@Sort int	--0.All
				--1.Ho ten
				--2.Tuoi
				--3.Gioi tinh
				--4.Doanh thu
				
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@Sort = 1)
		select C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr, SUM(B.TotalMoney) as Revenue
		from Customer C, Bill B, RoomReservation R
		where	B.RoomReservationID = R.ID and
				R.CustomerID = C.ID
		group by C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr
		order by C.Name_ asc, C.ID asc
	if (@Sort = 2)
		select C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr, SUM(B.TotalMoney) as Revenue
		from Customer C, Bill B, RoomReservation R
		where	B.RoomReservationID = R.ID and
				R.CustomerID = C.ID
		group by C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr
		order by C.Birthday, C.ID asc
	if (@Sort = 3)
		select C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr, SUM(B.TotalMoney) as Revenue
		from Customer C, Bill B, RoomReservation R
		where	B.RoomReservationID = R.ID and
				R.CustomerID = C.ID
		group by C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr
		order by C.Sex asc, C.ID asc
	if (@Sort = 4)
		select C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr, SUM(B.TotalMoney) as Revenue
		from Customer C, Bill B, RoomReservation R
		where	B.RoomReservationID = R.ID and
				R.CustomerID = C.ID
		group by C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr
		order by Revenue desc, C.ID asc
	else
		select C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr, SUM(B.TotalMoney) as Revenue
		from Customer C, Bill B, RoomReservation R
		where	B.RoomReservationID = R.ID and
				R.CustomerID = C.ID
		group by C.ID, C.Name_, C.IdentityNumber, C.PhoneNumber, C.Birthday, C.Sex, C.Addr
		order by C.ID asc


END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllCustomerInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAllCustomerInfo]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID, Name_, Birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr
	from Customer
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllRoom]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAllRoom]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select ID, Status_, RoomTypeID, Area
	from Room
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllServicesBillOnlyInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAllServicesBillOnlyInfo]
	-- Add the parameters for the stored procedure here
	@FromDate date,
	@ToDate date,
	@StaffID int,
	@Sort int	--0.Tang
				--1.Giam
				--2.Ngay lap
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@StaffID <= 0)
		if (@Sort = 0 )
			select B.ID, B.BillServiceOnlyDate, 0, S.Name_, 0, B.TotalMoney, B.TotalMoney, B.Discount
			from ServicesBillOnly B,  Staff S
			where	B.StaffID = S.ID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			order by  B.TotalMoney asc, B.BillServiceOnlyDate asc
		else if (@Sort = 1)
			select B.ID, B.BillServiceOnlyDate, 0, S.Name_, 0, B.TotalMoney, B.TotalMoney, B.Discount
			from ServicesBillOnly B,  Staff S
			where	B.StaffID = S.ID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			order by B.TotalMoney desc, B.BillServiceOnlyDate asc
		else 
			select B.ID, B.BillServiceOnlyDate, 0, S.Name_, 0, B.TotalMoney, B.TotalMoney, B.Discount
			from ServicesBillOnly B,  Staff S
			where	B.StaffID = S.ID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			order by B.BillServiceOnlyDate asc
	else
		if (@Sort = 0 )
			select B.ID, B.BillServiceOnlyDate, 0, S.Name_, 0, B.TotalMoney, B.TotalMoney, B.Discount
			from ServicesBillOnly B,  Staff S
			where	B.StaffID = S.ID and
					S.ID = @StaffID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			order by  B.TotalMoney asc, B.BillServiceOnlyDate asc
		else if (@Sort = 1)
			select B.ID, B.BillServiceOnlyDate, 0, S.Name_, 0, B.TotalMoney, B.TotalMoney, B.Discount
			from ServicesBillOnly B,  Staff S
			where	B.StaffID = S.ID and
					S.ID = @StaffID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			order by B.TotalMoney desc, B.BillServiceOnlyDate asc
		else 
			select B.ID, B.BillServiceOnlyDate, 0, S.Name_, 0, B.TotalMoney, B.TotalMoney, B.Discount
			from ServicesBillOnly B,  Staff S
			where	B.StaffID = S.ID and
					S.ID = @StaffID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			order by B.BillServiceOnlyDate asc

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllStaffInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetAllStaffInfo]
	-- Add the parameters for the stored procedure here
	@Sort int	--0.Lương tăng
				--1.Lương giảm
				--2.Thâm niên tăng
				--3.Thâm niên giảm
				--4.Quản lý
				--5.Nhân viên
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@Sort = 0)
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Status = 1
		order by Salary asc, ID asc
	if (@Sort = 1)
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Status = 1
		order by Salary desc, ID asc
	if (@Sort = 2)
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Status = 1
		order by StartingDate desc, ID asc
	if (@Sort = 3)
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Status = 1
		order by StartingDate asc, ID asc
	if (@Sort = 4)
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Position = 0 and Status = 1
		order by ID asc
	if (@Sort = 5)
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Position = 1 and Status = 1
		order by ID asc
	else 
		SELECT ID, Position, Name_,  IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, CONVERT(int, Salary), Username, Password
		FROM Staff
		where Status = 1
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetBillDetailInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetBillDetailInfo]
	-- Add the parameters for the stored procedure here
	@BillID int,
	@RoomReservationID int,
	@RoomID int 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Insert statements for procedure here
	DECLARE 
		@NewBillID int,
		@NewRoomReservationID int,
		@StaffID int,
		@TotalMoney money

	set @NewBillID = @BillID
	if (@BillID <= 0)
		begin
			set @NewRoomReservationID = @RoomReservationID
			if (@RoomReservationID <= 0 )
				begin
					SET @NewRoomReservationID = 
						(SELECT top 1 RR.ID
						FROM RoomReservation RR, RoomReservationDetail RRD
						WHERE	RRD.RoomID = @RoomID and 
								RR.ID = RRD.RoomReservationID and
								RR.PaymentStatus = 0
						order by RR.ID desc)
				end
			set @NewBillID = (select top 1 ID
								from Bill
								where RoomReservationID = @NewRoomReservationID)
		end
	else
		set @NewRoomReservationID = (select RoomReservationID
									from Bill
									where ID = @NewBillID)
	--SET @RoomReservationID = 
	--	(SELECT top 1 RR.ID
	--	FROM RoomReservation RR
	--	WHERE RR.RoomID = @RoomID and RR.Status = 0)
	--SET @StaffID = 
	--	(SELECT top 1 S.ID
	--	FROM Staff S
	--	WHERE S.Username = @Username)
	--SET @BillID = 
	--	(SELECT B.ID
	--	FROM Bill B
	--	WHERE B.RoomReservationID in (SELECT RR.ID
	--									FROM RoomReservation RR
	--									WHERE RR.RoomID = @RoomID))-- and RR.Status = 0)
	--update Bill
	--set StaffID = @StaffID
	--where ID = @NewBillID

	select distinct S.Name_, BD.ServiceCount, BD.ServicePrice, (BD.ServiceCount * BD.ServicePrice) as IntoMoney
	from BillDetail BD, ServiceTb S
	where	BD.BillID = @NewBillID and
			BD.ServiceID = S.ID

	--UPDATE Bill
	--SET StaffID = @StaffID
	--WHERE ID in (SELECT B.ID
	--					FROM Bill B
	--					WHERE B.RoomReservationID in (SELECT RR.ID
	--													FROM RoomReservation RR
	--													WHERE RR.RoomID = @RoomID and RR.Status = 0))		

	--SELECT distinct SV.Name_, BD.ServiceCount, SV.Price
	--FROM BillDetail BD, Bill B, ServiceTb SV
	--WHERE BD.BillID in (SELECT B.ID
	--					FROM Bill B
	--					WHERE B.RoomReservationID in (SELECT RR.ID
	--													FROM RoomReservation RR
	--													WHERE RR.RoomID = @RoomID and RR.Status = 0)) AND
	--					SV.ID = BD.ServiceID
	--update RoomReservation
	--set PaymentStatus = 1
	--where ID = @NewRoomReservationID

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetBillInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[QLKS_GetBillInfo]
	-- Add the parameters for the stored procedure here
	@BillID int,
	@RoomReservationID int,
	@Fromdate date,
	@Todate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here

	if (@BillID > 0)
		begin
			SELECT ID, BillDate, RoomReservationID, StaffID, TotalMoney
			from Bill
			where ID = @BillID
		end
	else
		begin
			if (@RoomReservationID > 0)
				begin
					SELECT ID, BillDate, RoomReservationID, StaffID, TotalMoney
					from Bill
					where RoomReservationID = @RoomReservationID
				end
			else
				begin
					SELECT ID, BillDate, RoomReservationID, StaffID, TotalMoney
					from Bill
					where BillDate >= @Fromdate and BillDate <= @Todate
				end
		end
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetBillInfoOfCustomer]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetBillInfoOfCustomer]
	-- Add the parameters for the stored procedure here
	@CustomerID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here

	select distinct B.ID, B.BillDate, B.RoomReservationID, S.Name_, RR.RoomCharge, B.ServiceTotalMoney, B.TotalMoney, B.Discount
	from Bill B, RoomReservation RR, Staff S
	where	B.RoomReservationID = RR.ID and
			B.StaffID = S.ID and
			RR.CustomerID = @CustomerID and
			B.BillDate IS NOT NULL

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetCustomerInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetCustomerInfo]
	-- Add the parameters for the stored procedure here
	@RoomID INT 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select distinct top 1 C.Name_, C.Birthday, C.PhoneNumber, C.Sex, C.IdentityNumber, C.Passport, C.Addr, RR.Note, RR.ReservationDate
	from Customer C, RoomReservation RR, RoomReservationDetail RRD
	where	C.ID = RR.CustomerID and 
			RR.ID = RRD.RoomReservationID and 
			RR.PaymentStatus = 0 and 
			RRD.RoomID = @RoomID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetEatServiceRevenue]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetEatServiceRevenue] 
	-- Add the parameters for the stored procedure here
	@RevenueType int,
	@FromDate date,
	@ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@RevenueType = 1)
		select T.Day , sum(T.TotalMoney) as TotalMoney
		from
			((select DATEDIFF(DAY, @FromDate, BillDate) as Day, sum(S.Price * BD.ServiceCount) as TotalMoney
			from Bill B, BillDetail BD, ServiceTb S
			where	B.ID = BD.BillID and
					BD.ServiceID = S.ID and
					S.ServiceTypeID = 2 and
					BillDate >= @FromDate and BillDate <= @ToDate
			group by DATEDIFF(DAY, @FromDate, BillDate)
			--order by BillDate asc
			)
			union all
			(select DATEDIFF(DAY, @FromDate, BillServiceOnlyDate) as Day, sum(S.Price * SBD.ServiceCount) as TotalMoney
			from ServicesBillOnly SB, ServicesBillOnlyDetail SBD, ServiceTb S
			where	SB.ID = SBD.BillServiceOnlyID and
					SBD.ServiceID = S.ID and
					BillServiceOnlyDate >= @FromDate and BillServiceOnlyDate <= @ToDate
			group by DATEDIFF(DAY, @FromDate, BillServiceOnlyDate)
			--order by BillServiceOnlyDate asc
			)) as T
			group by Day
			order by Day asc
	else if (@RevenueType = 2)
		select T.Month , sum(T.TotalMoney) as TotalMoney
		from
			((select DATEDIFF(MONTH, @FromDate, BillDate) as Month, sum(S.Price * BD.ServiceCount) as TotalMoney
			from Bill B, BillDetail BD, ServiceTb S
			where	B.ID = BD.BillID and
					BD.ServiceID = S.ID and
					S.ServiceTypeID = 2 and
					MONTH(BillDate) >= MONTH(@FromDate) and MONTH(BillDate) <= MONTH(@ToDate)
			group by DATEDIFF(MONTH, @FromDate, BillDate)
			--order by BillDate asc
			)
			union all
			(select DATEDIFF(MONTH, @FromDate, BillServiceOnlyDate) as Month, sum(S.Price * SBD.ServiceCount) as TotalMoney
			from ServicesBillOnly SB, ServicesBillOnlyDetail SBD, ServiceTb S
			where	SB.ID = SBD.BillServiceOnlyID and
					SBD.ServiceID = S.ID and
					MONTH(BillServiceOnlyDate) >= MONTH(@FromDate) and MONTH(BillServiceOnlyDate) <= MONTH(@ToDate)
			group by DATEDIFF(MONTH, @FromDate, BillServiceOnlyDate)
			--order by BillServiceOnlyDate asc
			)) as T
			group by Month
			order by Month asc
	else if (@RevenueType = 3)
		select T.Quarter , sum(T.TotalMoney) as TotalMoney
		from
			((select DATEDIFF(QUARTER, @FromDate, BillDate) as Quarter, sum(S.Price * BD.ServiceCount) as TotalMoney
			from Bill B, BillDetail BD, ServiceTb S
			where	B.ID = BD.BillID and
					BD.ServiceID = S.ID and
					S.ServiceTypeID = 2 and
					((MONTH(BillDate) - 1 ) / 3 + 1) >= ((MONTH(@FromDate) - 1 ) / 3 + 1) and ((MONTH(BillDate) - 1 ) / 3 + 1) <= ((MONTH(@ToDate) - 1 ) / 3 + 1)
			group by DATEDIFF(QUARTER, @FromDate, BillDate)
			--order by BillDate asc
			)
			union all
			(select DATEDIFF(QUARTER, @FromDate, BillServiceOnlyDate) as Quarter, sum(S.Price * SBD.ServiceCount) as TotalMoney
			from ServicesBillOnly SB, ServicesBillOnlyDetail SBD, ServiceTb S
			where	SB.ID = SBD.BillServiceOnlyID and
					SBD.ServiceID = S.ID and
					((MONTH(BillServiceOnlyDate) - 1 ) / 3 + 1) >= ((MONTH(@FromDate) - 1 ) / 3 + 1) and ((MONTH(BillServiceOnlyDate) - 1 ) / 3 + 1) <= ((MONTH(@ToDate) - 1 ) / 3 + 1)
			group by DATEDIFF(QUARTER, @FromDate, BillServiceOnlyDate)
			--order by BillServiceOnlyDate asc
			)) as T
			group by Quarter
			order by Quarter asc
	else
		select T.Year , sum(T.TotalMoney) as TotalMoney
		from
			((select DATEDIFF(YEAR, @FromDate, BillDate) as Year, sum(S.Price * BD.ServiceCount) as TotalMoney
			from Bill B, BillDetail BD, ServiceTb S
			where	B.ID = BD.BillID and
					BD.ServiceID = S.ID and
					S.ServiceTypeID = 2 and
					YEAR(BillDate) >= YEAR(@FromDate) and YEAR(BillDate) <= YEAR(@ToDate)
			group by DATEDIFF(YEAR, @FromDate, BillDate)
			--order by BillDate asc
			)
			union all
			(select DATEDIFF(YEAR, @FromDate, BillServiceOnlyDate) as Year, sum(S.Price * SBD.ServiceCount) as TotalMoney
			from ServicesBillOnly SB, ServicesBillOnlyDetail SBD, ServiceTb S
			where	SB.ID = SBD.BillServiceOnlyID and
					SBD.ServiceID = S.ID and
					YEAR(BillServiceOnlyDate) >= YEAR(@FromDate) and YEAR(BillServiceOnlyDate) <= YEAR(@ToDate)
			group by DATEDIFF(YEAR, @FromDate, BillServiceOnlyDate)
			--order by BillServiceOnlyDate asc
			)) as T
			group by Year
			order by Year asc

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetLaudryServiceRevenue]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetLaudryServiceRevenue]
	-- Add the parameters for the stored procedure here
	@RevenueType int,
	@FromDate date,
	@ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@RevenueType = 1)
		select DATEDIFF(DAY, @FromDate, BillDate), sum(S.Price * BD.ServiceCount) as TotalMoney
		from Bill B, BillDetail BD, ServiceTb S
		where	B.ID = BD.BillID and
				BD.ServiceID = S.ID and
				S.ServiceTypeID = 2 and
				BillDate >= @FromDate and BillDate <= @ToDate
		group by DATEDIFF(DAY, @FromDate, BillDate)
		order by DATEDIFF(DAY, @FromDate, BillDate) asc
	else if (@RevenueType = 2)
		select DATEDIFF(MONTH, @FromDate, BillDate), sum(S.Price * BD.ServiceCount) as TotalMoney
		from Bill B, BillDetail BD, ServiceTb S
		where	B.ID = BD.BillID and
				BD.ServiceID = S.ID and
				S.ServiceTypeID = 2 and
				MONTH(BillDate) >= MONTH(@FromDate) and MONTH(BillDate) <= MONTH(@ToDate)
		group by DATEDIFF(MONTH, @FromDate, BillDate)
		order by DATEDIFF(MONTH, @FromDate, BillDate) asc
	else if (@RevenueType = 3)
		select DATEDIFF(QUARTER, @FromDate, BillDate), sum(S.Price * BD.ServiceCount) as TotalMoney
		from Bill B, BillDetail BD, ServiceTb S
		where	B.ID = BD.BillID and
				BD.ServiceID = S.ID and
				S.ServiceTypeID = 2 and
				((MONTH(BillDate) - 1 ) / 3 + 1) >= ((MONTH(@FromDate) - 1 ) / 3 + 1) and ((MONTH(BillDate) - 1 ) / 3 + 1) <= ((MONTH(@ToDate) - 1 ) / 3 + 1)
		group by DATEDIFF(QUARTER, @FromDate, BillDate)
		order by DATEDIFF(QUARTER, @FromDate, BillDate) asc
	else
		select DATEDIFF(YEAR, @FromDate, BillDate), sum(S.Price * BD.ServiceCount) as TotalMoney
		from Bill B, BillDetail BD, ServiceTb S
		where	B.ID = BD.BillID and
				BD.ServiceID = S.ID and
				S.ServiceTypeID = 2 and
				YEAR(BillDate) >= YEAR(@FromDate) and YEAR(BillDate) <= YEAR(@ToDate)
		group by DATEDIFF(YEAR, @FromDate, BillDate)
		order by DATEDIFF(YEAR, @FromDate, BillDate) asc

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetRoomIdOfNewRoom]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetRoomIdOfNewRoom]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	select IDENT_CURRENT('Room')
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetRoomInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetRoomInfo]
	-- Add the parameters for the stored procedure here
	@RoomID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT R.RoomTypeID, R.Area, RT.Price, R.Status_
	FROM Room R, RoomType RT
	WHERE R.ID = @RoomID and RT.ID = R.RoomTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetRoomReservationDetailInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetRoomReservationDetailInfo]
	-- Add the parameters for the stored procedure here
	@BillID int,
	@RoomReservationID int,
	@RoomID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @NewBillID int,
			@NewRoomReservationID int,
			@DateCount int

	
	set @NewBillID = @BillID
	if (@BillID <= 0)
		begin
			set @NewRoomReservationID = @RoomReservationID
			if (@RoomReservationID <= 0 )
				begin
					SET @NewRoomReservationID = 
						(SELECT top 1 RR.ID
						FROM RoomReservation RR, RoomReservationDetail RRD
						WHERE	RRD.RoomID = @RoomID and 
								RR.ID = RRD.RoomReservationID and
								RR.PaymentStatus = 0
						order by RR.ID desc)
				end
			set @NewBillID = (select top 1 ID
								from Bill
								where RoomReservationID = @NewRoomReservationID)
		end
	else
		set @NewRoomReservationID = (select RoomReservationID
									from Bill
									where ID = @NewBillID)

	set @DateCount = 1 + datediff(DAY,
							(select ArrivalDate
							from RoomReservation
							where ID = @NewRoomReservationID),
							--(SELECT CAST(GETDATE() as date)))
							(select BillDate
							from Bill
							where RoomReservationID = @NewRoomReservationID))


	select distinct RRD.RoomID, @DateCount as DateCount, RRD.RoomPrice, RRD.RoomPrice * @DateCount as IntoMoney
	from RoomReservationDetail RRD
	where RRD.RoomReservationID = @NewRoomReservationID

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetRoomReservationUnpaid]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetRoomReservationUnpaid]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	from RoomReservation
	where PaymentStatus = 0
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetRoomRevenue]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetRoomRevenue] 
	-- Add the parameters for the stored procedure here
	@RevenueType int,
	@FromDate date,
	@ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@RevenueType = 1)
		select DATEDIFF(DAY, @FromDate, BillDate), sum(TotalMoney - ServiceTotalMoney) as TotalMoney
		from Bill
		where BillDate >= @FromDate and BillDate <= @ToDate
		group by DATEDIFF(DAY, @FromDate, BillDate)
		order by DATEDIFF(DAY, @FromDate, BillDate) asc
	else if (@RevenueType = 2)
		select DATEDIFF(MONTH, @FromDate, BillDate), sum(TotalMoney - ServiceTotalMoney) as TotalMoney
		from Bill
		where MONTH(BillDate) >= MONTH(@FromDate) and MONTH(BillDate) <= MONTH(@ToDate)
		group by DATEDIFF(MONTH, @FromDate, BillDate)
		order by DATEDIFF(MONTH, @FromDate, BillDate) asc
	else if (@RevenueType = 3)
		select DATEDIFF(QUARTER, @FromDate, BillDate), sum(TotalMoney - ServiceTotalMoney) as TotalMoney
		from Bill
		where ((MONTH(BillDate) - 1 ) / 3 + 1) >= ((MONTH(@FromDate) - 1 ) / 3 + 1) and ((MONTH(BillDate) - 1 ) / 3 + 1) <= ((MONTH(@ToDate) - 1 ) / 3 + 1)
		group by DATEDIFF(QUARTER, @FromDate, BillDate)
		order by DATEDIFF(QUARTER, @FromDate, BillDate) asc
	else
		select DATEDIFF(YEAR, @FromDate, BillDate), sum(TotalMoney - ServiceTotalMoney) as TotalMoney
		from Bill
		where YEAR(BillDate) >= YEAR(@FromDate) and YEAR(BillDate) <= YEAR(@ToDate)
		group by DATEDIFF(YEAR, @FromDate, BillDate)
		order by DATEDIFF(YEAR, @FromDate, BillDate) asc

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetServiceIdOfNewService]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetServiceIdOfNewService]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IDENT_CURRENT('Servicetb')
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetServiceInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetServiceInfo]
	-- Add the parameters for the stored procedure here
	@ServiceTypeID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID, Name_, Price
	FROM ServiceTb S
	WHERE	ServiceTypeID = @ServiceTypeID and
			Status = 1
	order by Name_ asc
	
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetServicesBillOnlyDetailInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetServicesBillOnlyDetailInfo]
	-- Add the parameters for the stored procedure here
	@ServicersBillID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select S.Name_,B.ServiceCount, B.ServicePrice, B.ServiceCount * B.ServicePrice as Totalmoney, St.Name_
	from ServicesBillOnlyDetail B, ServiceTb S, ServicesBillOnly SVB, Staff St
	where B.BillServiceOnlyID = @ServicersBillID and
			B.BillServiceOnlyID = SVB.ID and
			SVB.StaffID = St.ID	and
			B.ServiceID = S.ID

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetStaffIdOfNewStaff]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE[dbo].[QLKS_GetStaffIdOfNewStaff]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IDENT_CURRENT('Staff')
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetStaffInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_GetStaffInfo]
	-- Add the parameters for the stored procedure here
	@Username NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID, Name_, Position, Password, IdentityNumber, BirthDay, Sex, Addr, PhoneNumber, StartingDate, Salary
	FROM Staff
	where Username = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertNewBill]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_InsertNewBill]
	-- Add the parameters for the stored procedure here
	@RoomReservationID int,
	--@StaffID int
	@Username nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;
    -- Insert statements for procedure here
	Declare @StaffID int,
			@NewRoomReservationID int,
			@ExistsBill int

	if (@RoomReservationID > 0)
		set @NewRoomReservationID = @RoomReservationID
	else
		set @NewRoomReservationID = IDENT_CURRENT('RoomReservation');

	--INSERT INTO Bill (RoomReservationID, StaffID, TotalMoney)
	--		VALUES (@RoomReservationID, @StaffID, 0)
	set @StaffID = (select top 1 ID
					from Staff
					where Username = @Username)
	set @ExistsBill = (select count (*)
						from Bill
						where RoomReservationID = @NewRoomReservationID and StaffID = @StaffID)

	if (@NewRoomReservationID is not null and 
		@StaffID is not null and
		@ExistsBill = 0)
		begin 
			INSERT INTO Bill (RoomReservationID, StaffID, TotalMoney, ServiceTotalMoney)
			VALUES (@NewRoomReservationID, @StaffID, 0, 0)
		end 
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertNewCustomer]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_InsertNewCustomer]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@Birthday date,
	@IdentityNumber nvarchar(50),
	@Passport nvarchar(50),
	@Addr nvarchar(100),
	@PhoneNumber varchar(20),
	@Sex bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	if (@Birthday = GETDATE())
		set @Birthday = '2000-01-01'
	insert into Customer (Name_, Birthday, IdentityNumber, Passport, Addr, PhoneNumber, Sex)
	values (@Name, @Birthday, @IdentityNumber, @Passport, @Addr, @PhoneNumber, @Sex)
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertNewRoomReservation]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_InsertNewRoomReservation]
	-- Add the parameters for the stored procedure here
	@ArrivalDate date,
	@CustomerID int,
	@Username nvarchar(25),
	@DownPayment money,
	@Note nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;
    -- Insert statements for procedure here
	declare @CustomerIDInsert int,
			@StaffID int

	set @CustomerIDInsert = IDENT_CURRENT('Customer')
	if (@CustomerID > 0) 
		set @CustomerIDInsert = @CustomerID
	set @StaffID = (select top 1 ID	
					from Staff
					where Username = @Username)

	insert into RoomReservation (ReservationDate, ArrivalDate, CustomerID, StaffID, DownPayment, RoomCharge, PaymentStatus, Note)
	values (GETDATE(), @ArrivalDate, @CustomerIDInsert, @StaffID, @DownPayment, 0, 0, @Note)
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertNewServicesBillOnly]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  PROCEDURE [dbo].[QLKS_InsertNewServicesBillOnly]
	-- Add the parameters for the stored procedure here
	@Username nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	declare @StaffID int

	set @StaffID = 	(select ID
					from Staff
					where Username = @Username)
	if (@StaffID is not null)
		insert into ServicesBillOnly(BillServiceOnlyDate, StaffID, TotalMoney, Discount)
		values (Getdate(),	
				(select ID
				from Staff
				where Username = @Username),
				0,0)


END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertRoomReservationDetail]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_InsertRoomReservationDetail]
	-- Add the parameters for the stored procedure here
	@RoomReservationID int,
	@RoomID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	declare @ExistsRRDetail bit,
			@NewRoomReservationID int,
			@RoomPrice money

	select @RoomPrice = Rt.Price
	from Room R, RoomType RT
	where	R.RoomTypeID = RT.ID and
			R.ID = @RoomID


	if (@RoomReservationID > 0)
		set @NewRoomReservationID =	@RoomReservationID
	else
		set @NewRoomReservationID = IDENT_CURRENT('RoomReservation');
								
	set @ExistsRRDetail = (select count(*)
							from RoomReservationDetail
							where RoomReservationID = @NewRoomReservationID and
									RoomID = @RoomID)
    if (@ExistsRRDetail = 0)
		begin
			insert into RoomReservationDetail (RoomReservationID, RoomID, RoomPrice)
			values (@NewRoomReservationID, @RoomID, @RoomPrice)

			update Room
			set Status_ = 2
			where ID = @RoomID
		end

	
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertServiceIntoBillDetail]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_InsertServiceIntoBillDetail]
	-- Add the parameters for the stored procedure here
	@RoomID int,
	@ServiceID int,
	@ServiceCount int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;

    -- Insert statements for procedure here
	declare @BillID int,
			@ExistBillDetail bit,
			@PriceOfServiceID money,
			@ServicePrice money
			

	select @ServicePrice = Price
	from ServiceTb
	where ID = @ServiceID


	set @BillID = (select top 1 B.ID
					from Bill B, RoomReservation RR, RoomReservationDetail RRD
					where B.RoomReservationID = RR.ID and
							RR.ID = RRD.RoomReservationID and
							RRD.RoomID = @RoomID and
							RR.PaymentStatus = 0)
	set @PriceOfServiceID = (select Price
							from ServiceTb
							where ID = @ServiceID)
	if (@PriceOfServiceID is null)
		set @PriceOfServiceID = 0

	if (@BillID is not null and @ServiceCount != 0)
		begin
			if ((select count(*)
				from BillDetail
				where BillID = @BillID and ServiceID = @ServiceID) > 0)
				begin
					update BillDetail
					set ServiceCount = ServiceCount + @ServiceCount
					where BillID = @BillID and ServiceID = @ServiceID
				end
			else
				begin
					insert into BillDetail (BillID, ServiceID, ServiceCount, ServicePrice)
					values (@BillID, @ServiceID, @ServiceCount, @ServicePrice)
				end
			update Bill
			set ServiceTotalMoney = ServiceTotalMoney + @PriceOfServiceID * @ServiceCount
			where ID = @BillID 
		end
	

	--insert into BillDetail
	--values (@BillID, @ServiceID, @ServiceCount)

	--update Bill
	--set TotalMoney = TotalMoney + (select Price
	--								from ServiceTb
	--								where ID = @ServiceID) * @ServiceCount
	--where ID = @BillID
	--if ((select count(*)
	--	from BillDetail
	--	where BillID = @BillID) = 0)
	--	begin
	--		insert into BillDetail
	--		values (@BillID, @ServiceID, @ServiceCount)
	--	end
	--else 
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_InsertServiceIntoServicesBillOnlyDetail]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_InsertServiceIntoServicesBillOnlyDetail]
	-- Add the parameters for the stored procedure here
	@ServiceID int,
	@ServiceCount int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	declare @BillServiceOnlyID int,
			@ServicePrice money

	select @ServicePrice = Price
	from ServiceTb
	where ID = @ServiceID

	set @BillServiceOnlyID = (select IDENT_CURRENT('ServicesBillOnly'))
	if (@BillServiceOnlyID is not null and	(select count(*)
											from ServicesBillOnlyDetail
											where BillServiceOnlyID = @BillServiceOnlyID and ServiceID = @ServiceID) = 0)
		begin
			insert into ServicesBillOnlyDetail(BillServiceOnlyID, ServiceID, ServiceCount, ServicePrice)
			values (@BillServiceOnlyID, @ServiceID, @ServiceCount, @ServicePrice)
		end
	else 
		begin
			update ServicesBillOnlyDetail
			set ServiceCount = ServiceCount + @ServiceCount
			where BillServiceOnlyID = @BillServiceOnlyID and ServiceID = @ServiceID
		end

END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_PayForServices]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_PayForServices]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	declare @BillServiceOnlyID int,
			@Totalmoney money

	set @BillServiceOnlyID = (select IDENT_CURRENT('ServicesBillOnly'))
	set @Totalmoney = (select sum(B.ServiceCount * B.ServicePrice)
						from ServicesBillOnlyDetail B
						where B.BillServiceOnlyID = @BillServiceOnlyID)
	select S.Name_,B.ServiceCount, S.Price, B.ServiceCount * B.ServicePrice
	from ServicesBillOnlyDetail B, ServiceTb S
	where B.BillServiceOnlyID = @BillServiceOnlyID and
			B.ServiceID = S.ID

	update ServicesBillOnly
	set TotalMoney = @Totalmoney
	where ID = @BillServiceOnlyID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_Payment]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_Payment]
	-- Add the parameters for the stored procedure here
	@BillID int,
	@RoomReservationID int,
	@RoomID int,
	@Username nvarchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;
    -- Insert statements for procedure here
	declare @NewRoomReservationID int,
			@NewBillID int,
			--@PriceOfRoom money,
			@DateCount int,
			@TotalMoneyOfServices int,
			@TotalMoneyOfRoom int,
			@StaffID int

	set @NewBillID = @BillID
	if (@BillID <= 0)
		begin
			set @NewRoomReservationID = @RoomReservationID
			if (@RoomReservationID <= 0 )
				begin
					SET @NewRoomReservationID = 
						(SELECT top 1 RR.ID
						FROM RoomReservation RR, RoomReservationDetail RRD
						WHERE	RRD.RoomID = @RoomID and 
								RR.ID = RRD.RoomReservationID and
								RR.PaymentStatus = 0
						order by RR.ID desc)
				end
			set @NewBillID = (select distinct top 1 ID
								from Bill
								where RoomReservationID = @NewRoomReservationID)
		end
	else
		set @NewRoomReservationID = (select RoomReservationID
									from Bill
									where ID = @NewBillID)
	set @DateCount = 1 + datediff(DAY,
							(select ArrivalDate
							from RoomReservation
							where ID = @NewRoomReservationID),
							(SELECT CAST(GETDATE() as date)))


	--select distinct R.ID, @DateCount as DateCount, RT.Price, RT.Price * @DateCount as IntoMoney
	--from RoomReservationDetail RRD, Room R, RoomType RT
	--where R.ID = RRD.RoomID and
	--	R.RoomTypeID = RT.ID and
	--	RRD.RoomReservationID = @NewRoomReservationID	

	set @TotalMoneyOfServices = (select sum(BD.ServicePrice * BD.ServiceCount)
									from Bill B, BillDetail BD, RoomReservationDetail RRD
									where B.ID = BD.BillID and
										B.ID = @NewBillID and
										B.RoomReservationID = RRD.RoomReservationID)
	
	set @TotalMoneyOfRoom =	(select Sum(@DateCount * RRD.RoomPrice)
							from RoomReservationDetail RRD
							where RRD.RoomReservationID = @NewRoomReservationID	)
	SET @StaffID = (SELECT top 1 S.ID
					FROM Staff S
					WHERE S.Username = @Username)
	--update RoomReservation
	--set Status=1
	--where ID = @RoomReservationID

	--exec QLKS_SetRoomStatus @RoomID, 3
	

	if (@TotalMoneyOfServices is null)
		set @TotalMoneyOfServices = 0
	
	if (@TotalMoneyOfRoom is null)
		set @TotalMoneyOfRoom = 0

	update Bill
	set TotalMoney = ServiceTotalMoney + @TotalMoneyOfRoom,
		--ServiceTotalMoney = @TotalMoneyOfServices
		BillDate = (Select GETDATE()), 
		StaffID = @StaffID
	where RoomReservationID = @NewRoomReservationID
	update RoomReservation
	set RoomCharge = @TotalMoneyOfRoom
	where ID = @NewRoomReservationID

	update Room
	set Room.Status_ = 3
	where Room.ID in (select RoomID
						from RoomReservationDetail
						where RoomReservationID = @NewRoomReservationID)
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_RemoveService]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_RemoveService]
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	update ServiceTb
	set Status = 0
	where ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_RemoveStaff]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_RemoveStaff]
	-- Add the parameters for the stored procedure here
	@StaffID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	update Staff 
	set Status = 0
	where ID = @StaffID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_SearchAccount]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_SearchAccount]
	@Username nvarchar(25),
	@Password nvarchar(100)
	
AS
BEGIN
	SET NOCOUNT off;
	select [Username], [Password]
	from QLKS.[dbo].[Staff]
	where Username = @Username and Password = @Password and Status = 1
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_SetRoomReservationStatus]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_SetRoomReservationStatus]
	-- Add the parameters for the stored procedure here
	@BillID int,
	@RoomReservationID int,
	@RoomID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @NewBillID int,
			@NewRoomReservationID int


	set @NewBillID = @BillID
	if (@BillID <= 0)
		begin
			set @NewRoomReservationID = @RoomReservationID
			if (@RoomReservationID <= 0 )
				begin
					SET @NewRoomReservationID = 
						(SELECT top 1 RR.ID
						FROM RoomReservation RR, RoomReservationDetail RRD
						WHERE	RRD.RoomID = @RoomID and 
								RR.ID = RRD.RoomReservationID and
								RR.PaymentStatus = 0
						order by RR.ID desc)
				end
			set @NewBillID = (select top 1 ID
								from Bill
								where RoomReservationID = @NewRoomReservationID)
		end
	else
		set @NewRoomReservationID = (select RoomReservationID
									from Bill
									where ID = @NewBillID)

	update RoomReservation
	set PaymentStatus = 1
	where ID = @NewRoomReservationID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_SetRoomStatus]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_SetRoomStatus] 
	-- Add the parameters for the stored procedure here
	@RoomID int,
	@Status_ tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	update Room
	set Room.Status_= @Status_
	where Room.ID = @RoomID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_SetServiceInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_SetServiceInfo]
	-- Add the parameters for the stored procedure here
	@ID int,
	@Name nvarchar(50),
	@Price money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;

    -- Insert statements for procedure here
	update ServiceTb
	set Name_ = @Name, Price = @Price
	where ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_SetStaffInfo]    Script Date: 12/28/2020 9:11:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_SetStaffInfo]
	-- Add the parameters for the stored procedure here
	@ID int,
	@Name nvarchar(50),
	@Birthday date,
	@Sex bit,
	@Addr nvarchar(100),
	@PhoneNumber varchar(20),
	@IdentityNumber nvarchar(50),
	@Position bit,
	@StartingDate date,
	@Salary money,
	@Note nvarchar(100)AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	update Staff
	set Name_ = @Name,
		BirthDay = @Birthday,
		Sex = @Sex,
		Addr = @Addr,
		PhoneNumber = @PhoneNumber,
		IdentityNumber = @IdentityNumber,
		Position = @Position,
		StartingDate = @StartingDate,
		Salary = @Salary,
		Note = @Note
	where ID = @ID

END
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
