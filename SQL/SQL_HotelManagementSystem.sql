﻿USE [master]
GO
/****** Object:  Database [qlks_update2]    Script Date: 10/19/2020 12:35:55 PM ******/
CREATE DATABASE [qlks_update2]
GO
ALTER DATABASE [qlks_update2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlks_update2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlks_update2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlks_update2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlks_update2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlks_update2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlks_update2] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlks_update2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qlks_update2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlks_update2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlks_update2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlks_update2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlks_update2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlks_update2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlks_update2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlks_update2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlks_update2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [qlks_update2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlks_update2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlks_update2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlks_update2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlks_update2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlks_update2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlks_update2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlks_update2] SET RECOVERY FULL 
GO
ALTER DATABASE [qlks_update2] SET  MULTI_USER 
GO
ALTER DATABASE [qlks_update2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlks_update2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlks_update2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlks_update2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlks_update2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'qlks_update2', N'ON'
GO
ALTER DATABASE [qlks_update2] SET QUERY_STORE = OFF
GO
USE [qlks_update2]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[ServiceBillID] [int] NOT NULL,
	[TotalMoney] [money] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
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
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodsReceipt]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodsReceipt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Product]    Script Date: 10/19/2020 12:35:55 PM ******/
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
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type_] [tinyint] NOT NULL,
	[Area] [int] NULL,
	[Status_] [tinyint] NOT NULL,
	[Price] [money] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomReservation]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomReservation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ConstitutiveDate] [date] NOT NULL,
	[ClientID] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
	[DownPayment] [money] NULL,
	[Request] [nvarchar](100) NULL,
 CONSTRAINT [PK_RoomReservation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceBill]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceBill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ServiceBill_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceBillDetail]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceBillDetail](
	[ServiceBillID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[Total] [int] NULL,
	[TotalMoney] [money] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_ServiceBill] PRIMARY KEY CLUSTERED 
(
	[ServiceBillID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTb]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTb](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceTypeID] [int] NOT NULL,
	[Name_] [nvarchar](50) NULL,
	[Price] [money] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_ServiceTb] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 10/19/2020 12:35:55 PM ******/
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
/****** Object:  Table [dbo].[Staff]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[BirthDay] [date] NULL,
	[Sex] [bit] NOT NULL,
	[Addr] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[IdentityNumber] [nvarchar](50) NULL,
	[Position] [bit] NOT NULL,
	[StartingDate] [date] NULL,
	[Salary] [money] NULL,
	[Note] [nvarchar](500) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 10/19/2020 12:35:55 PM ******/
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
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Client]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Room]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_ServiceBill] FOREIGN KEY([ServiceBillID])
REFERENCES [dbo].[ServiceBill] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_ServiceBill]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Staff]
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
ALTER TABLE [dbo].[GoodsReceipt]  WITH CHECK ADD  CONSTRAINT [FK_GoodsReceipt_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[GoodsReceipt] CHECK CONSTRAINT [FK_GoodsReceipt_Supplier]
GO
ALTER TABLE [dbo].[RoomReservation]  WITH CHECK ADD  CONSTRAINT [FK_RoomReservation_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[RoomReservation] CHECK CONSTRAINT [FK_RoomReservation_Client]
GO
ALTER TABLE [dbo].[RoomReservation]  WITH CHECK ADD  CONSTRAINT [FK_RoomReservation_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[RoomReservation] CHECK CONSTRAINT [FK_RoomReservation_Room]
GO
ALTER TABLE [dbo].[ServiceBillDetail]  WITH CHECK ADD  CONSTRAINT [FK_ServiceBillDetail_ServiceBill] FOREIGN KEY([ServiceBillID])
REFERENCES [dbo].[ServiceBill] ([ID])
GO
ALTER TABLE [dbo].[ServiceBillDetail] CHECK CONSTRAINT [FK_ServiceBillDetail_ServiceBill]
GO
ALTER TABLE [dbo].[ServiceBillDetail]  WITH CHECK ADD  CONSTRAINT [FK_ServiceBillDetail_ServiceTb] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[ServiceTb] ([ID])
GO
ALTER TABLE [dbo].[ServiceBillDetail] CHECK CONSTRAINT [FK_ServiceBillDetail_ServiceTb]
GO
ALTER TABLE [dbo].[ServiceTb]  WITH CHECK ADD  CONSTRAINT [FK_ServiceTb_ServiceType] FOREIGN KEY([ServiceTypeID])
REFERENCES [dbo].[ServiceType] ([ID])
GO
ALTER TABLE [dbo].[ServiceTb] CHECK CONSTRAINT [FK_ServiceTb_ServiceType]
GO
/****** Object:  StoredProcedure [dbo].[QLKS_AddReservation]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QLKS_AddReservation] 
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
	@ConstitutiveDate DATE

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Client
	(
	    Name_,
	    Birthday,
	    IdentityNumber,
	    Passport,
	    Addr,
	    PhoneNumber,
	    Sex,
	    Nationality,
	    Note
	)
	VALUES
	(   @Name,                   -- Name_ - nvarchar(50)
	    @Birthday, -- Birthday - date
	    @IdentityNumber,                   -- IdentityNumber - nvarchar(50)
	    @Passport,                   -- Passport - nvarchar(50)
	    @Addr,                   -- Addr - nvarchar(100)
	    @PhoneNumber,                    -- PhoneNumber - varchar(20)
	    @Sex,                  -- Sex - bit
	    N'',                   -- Nationality - nvarchar(50)
	    N''                    -- Note - nvarchar(100)
	    )
	DECLARE  @NewID_  INT  
	SET @NewID_ = SCOPE_IDENTITY()
	INSERT INTO dbo.RoomReservation
	(
	    ConstitutiveDate,
	    ClientID,
	    RoomID,
	    DownPayment,
	    Request
	)
	VALUES
	(   @ConstitutiveDate, -- ConstitutiveDate - date
	    @NewID_,         -- ClientID - int
	    @RoomID,         -- RoomID - int
	    NULL,      -- DownPayment - money
	    @Note        -- Request - nvarchar(100)
	    )
	UPDATE dbo.Room
		SET Status_=2
		WHERE ID=@RoomID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_ChangePassword]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[QLKS_ChangePassword]
	@Username nvarchar(25),
	@Password nvarchar(100)
AS
BEGIN
	SET NOCOUNT OFF;

    update [Staff]
	set [Password] = @Password
	where [Username] = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_EditRoom]    Script Date: 10/19/2020 12:35:55 PM ******/
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
	@ID INT,
	@Type TINYINT	,
	@Area INT,
	@Price MONEY

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	UPDATE dbo.Room
		SET Type_=@Type, Area=@Area, Price=@Price
		WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetAllRoom]    Script Date: 10/19/2020 12:35:55 PM ******/
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
	SELECT [ID],[Status_],[Type_] FROM Room
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetCustomerInfo]    Script Date: 10/19/2020 12:35:55 PM ******/
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
	SELECT dbo.Client.Name_, dbo.Client.Birthday, dbo.Client.PhoneNumber,  dbo.Client.Sex,  dbo.Client.IdentityNumber,
				dbo.Client.Passport, dbo.Client.Addr, dbo.Client.Note, dbo.RoomReservation.ConstitutiveDate
	FROM dbo.Client INNER JOIN dbo.RoomReservation ON RoomReservation.ClientID = Client.ID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetRoomInfo]    Script Date: 10/19/2020 12:35:55 PM ******/
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
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Type_],[Area],[Price],[Status_] FROM Room
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_GetStaffInfo]    Script Date: 10/19/2020 12:35:55 PM ******/
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
	SELECT [dbo].[Staff].Name_,dbo.Staff.Position FROM dbo.Staff
END
GO
/****** Object:  StoredProcedure [dbo].[QLKS_SearchAccount]    Script Date: 10/19/2020 12:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[QLKS_SearchAccount]
	@Username nvarchar(25),
	@Password nvarchar(100)
	
AS
BEGIN
	SET NOCOUNT ON;
	select [Username], [Password]
	from qlks_update2.[dbo].[Staff]
	where Username = @Username and Password = @Password
END
GO
USE [master]
GO
ALTER DATABASE [qlks_update2] SET  READ_WRITE 
GO