USE [master]
GO
/****** Object:  Database [FactoryMMDb]    Script Date: 23/08/2019 3:07:26 PM ******/
CREATE DATABASE [FactoryMMDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FactoryMMDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FactoryMMDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FactoryMMDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FactoryMMDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FactoryMMDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FactoryMMDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FactoryMMDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FactoryMMDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FactoryMMDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FactoryMMDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FactoryMMDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [FactoryMMDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FactoryMMDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FactoryMMDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FactoryMMDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FactoryMMDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FactoryMMDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FactoryMMDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FactoryMMDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FactoryMMDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FactoryMMDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FactoryMMDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FactoryMMDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FactoryMMDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FactoryMMDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FactoryMMDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FactoryMMDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FactoryMMDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FactoryMMDb] SET RECOVERY FULL 
GO
ALTER DATABASE [FactoryMMDb] SET  MULTI_USER 
GO
ALTER DATABASE [FactoryMMDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FactoryMMDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FactoryMMDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FactoryMMDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FactoryMMDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FactoryMMDb', N'ON'
GO
ALTER DATABASE [FactoryMMDb] SET QUERY_STORE = OFF
GO
USE [FactoryMMDb]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[City] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyPurchases]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyPurchases](
	[PurchaseId] [int] IDENTITY(1,1) NOT NULL,
	[MatInvId] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Paid] [decimal](18, 2) NOT NULL,
	[Due] [decimal](18, 2) NOT NULL,
	[PurchaseDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CompanyPurchases] PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerOrders]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerOrders](
	[CustOrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustId] [int] NOT NULL,
	[ProdInvId] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[DeliveryTakeDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CustomerOrders] PRIMARY KEY CLUSTERED 
(
	[CustOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustId] [int] IDENTITY(1,1) NOT NULL,
	[CustName] [nvarchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[OrgName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeCategorys]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeCategorys](
	[EmpCatId] [int] IDENTITY(1,1) NOT NULL,
	[EmpCatName] [nvarchar](50) NOT NULL,
	[BasicSalary] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_EmployeeCategorys] PRIMARY KEY CLUSTERED 
(
	[EmpCatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Address] [nvarchar](150) NOT NULL,
	[EmpCatId] [int] NOT NULL,
	[JoiningDate] [datetime2](7) NOT NULL,
	[BloodGroup] [int] NULL,
	[PhotoPath] [nvarchar](max) NULL,
	[Increament] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialInventorys]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialInventorys](
	[MatInvId] [int] IDENTITY(1,1) NOT NULL,
	[MatInvName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[SupId] [int] NOT NULL,
 CONSTRAINT [PK_MaterialInventorys] PRIMARY KEY CLUSTERED 
(
	[MatInvId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productions]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productions](
	[ProductionId] [int] IDENTITY(1,1) NOT NULL,
	[ProdInvId] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[HDPE] [decimal](18, 2) NOT NULL,
	[LDPE] [decimal](18, 2) NOT NULL,
	[PP] [decimal](18, 2) NOT NULL,
	[ProdHour] [decimal](18, 2) NOT NULL,
	[ProdQuantity] [decimal](18, 2) NOT NULL,
	[T2OB] [decimal](18, 2) NOT NULL,
	[T2OR] [decimal](18, 2) NOT NULL,
	[T2OY] [decimal](18, 2) NOT NULL,
	[Thinner] [decimal](18, 2) NOT NULL,
	[Wastage] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Productions] PRIMARY KEY CLUSTERED 
(
	[ProductionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsInventorys]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInventorys](
	[ProdInvId] [int] IDENTITY(1,1) NOT NULL,
	[ProdInvName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_ProductsInventorys] PRIMARY KEY CLUSTERED 
(
	[ProdInvId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnSelses]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnSelses](
	[SaleReturnId] [int] IDENTITY(1,1) NOT NULL,
	[ProdInvId] [int] NOT NULL,
	[CustId] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[ErturnDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ReturnSelses] PRIMARY KEY CLUSTERED 
(
	[SaleReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Saleses]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saleses](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NOT NULL,
	[CustOrderId] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Paid] [decimal](18, 2) NOT NULL,
	[Due] [decimal](18, 2) NOT NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Saleses] PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 23/08/2019 3:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupId] [int] IDENTITY(1,1) NOT NULL,
	[SupName] [nvarchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[OrgName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'3db3d1fb-497f-4ead-bb6d-8fdd4d6a8025', N'farhan@f.com', N'FARHAN@F.COM', N'farhan@f.com', N'FARHAN@F.COM', 0, N'AQAAAAEAACcQAAAAEB7uAJccCndJjByi2GhdvRlgnD44SuYeJyzNxgmbcI+w74doe1J3wLhCumrrFpM64g==', N'BCKZTWX3BK46YMXZFUA455AAWVXA4MX3', N'5aaed12d-d46e-452e-9657-d0e3e6c897a4', NULL, 0, 0, NULL, 1, 0, N'Dhaka')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'8ee40aed-41dd-41b4-a75d-f1bca8816c9c', N'faizul@f.com', N'FAIZUL@F.COM', N'faizul@f.com', N'FAIZUL@F.COM', 0, N'AQAAAAEAACcQAAAAEP5F4ifKMBBZjU/ZmJSu3pWRcI9EjYBPi46VranF9sZNMPydWc6glZke8bStNuTBPw==', N'4YMLE3FRFUIKDLOKBT25DMIAVFNGZUKL', N'6bd1c90f-61ab-4faa-953e-747a9a9a469d', NULL, 0, 0, NULL, 1, 0, N'Dhaka')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'a880f0ea-1e20-4a9e-baa5-8bc31de85311', N'rajib@f.com', N'RAJIB@F.COM', N'rajib@f.com', N'RAJIB@F.COM', 0, N'AQAAAAEAACcQAAAAEI8UZgY9S7lX0prRUaFYmhaj9haFAHV1gHqTjuU2aJokzrYcV8aPP87ggY7O7Re0pg==', N'S76N3BBFNSWGAB7FQRJHSNQDNDA7N6VC', N'cd631464-92ee-43a3-bd2a-215c1cb95b0a', NULL, 0, 0, NULL, 1, 0, N'Dhaka')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'dd81d4b0-e374-44e8-acab-68e78bf07ef0', N'adnan@f.com', N'ADNAN@F.COM', N'adnan@f.com', N'ADNAN@F.COM', 0, N'AQAAAAEAACcQAAAAEGDYNWZR2wdBLK28l4dIzGbvAQfmB7LrE/qtByQjdzFndTU+Frd4tH3aF2DHuaeCZA==', N'275MUCHZ3TUQFVTLI5L6PXXVHGG3ZTEJ', N'63d8cf73-ba4b-4da0-8f55-c3b582ded908', NULL, 0, 0, NULL, 1, 0, N'Dhaka')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'fed9b8f0-26c4-4860-8af0-5abd1396339c', N'farhana@f.com', N'FARHANA@F.COM', N'farhana@f.com', N'FARHANA@F.COM', 0, N'AQAAAAEAACcQAAAAEDf0CgjOqiWi78UkMveuCF5pVhgSWMIJGtzfT9FFCxMqTfKda5dOfuvXliDkYwecrw==', N'XYCXJB7DXJV4HTX2DSKAE7H4TAFJEPGB', N'6a2a90cb-36ff-472b-8b08-235d05d4237a', NULL, 0, 0, NULL, 1, 0, N'Dhaka')
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmpId], [EmpName], [Phone], [Address], [EmpCatId], [JoiningDate], [BloodGroup], [PhotoPath], [Increament]) VALUES (1, N'Farhan', 1796729090, N'Uttara, Dhaka', 0, CAST(N'2019-08-23T10:30:35.0000000' AS DateTime2), 0, N'249b358f-9042-4414-976a-a04bf02a122e_Blue_morpho_butterfly.jpg', 5555)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 23/08/2019 3:07:27 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CompanyPurchases]  WITH CHECK ADD  CONSTRAINT [FK_CompanyPurchases_MaterialInventorys] FOREIGN KEY([MatInvId])
REFERENCES [dbo].[MaterialInventorys] ([MatInvId])
GO
ALTER TABLE [dbo].[CompanyPurchases] CHECK CONSTRAINT [FK_CompanyPurchases_MaterialInventorys]
GO
ALTER TABLE [dbo].[CustomerOrders]  WITH CHECK ADD  CONSTRAINT [FK_CustomerOrders_Customers] FOREIGN KEY([CustId])
REFERENCES [dbo].[Customers] ([CustId])
GO
ALTER TABLE [dbo].[CustomerOrders] CHECK CONSTRAINT [FK_CustomerOrders_Customers]
GO
ALTER TABLE [dbo].[CustomerOrders]  WITH CHECK ADD  CONSTRAINT [FK_CustomerOrders_ProductsInventorys] FOREIGN KEY([ProdInvId])
REFERENCES [dbo].[ProductsInventorys] ([ProdInvId])
GO
ALTER TABLE [dbo].[CustomerOrders] CHECK CONSTRAINT [FK_CustomerOrders_ProductsInventorys]
GO
ALTER TABLE [dbo].[MaterialInventorys]  WITH CHECK ADD  CONSTRAINT [FK_MaterialInventorys_Suppliers] FOREIGN KEY([SupId])
REFERENCES [dbo].[Suppliers] ([SupId])
GO
ALTER TABLE [dbo].[MaterialInventorys] CHECK CONSTRAINT [FK_MaterialInventorys_Suppliers]
GO
ALTER TABLE [dbo].[Productions]  WITH CHECK ADD  CONSTRAINT [FK_Productions_ProductsInventorys] FOREIGN KEY([ProdInvId])
REFERENCES [dbo].[ProductsInventorys] ([ProdInvId])
GO
ALTER TABLE [dbo].[Productions] CHECK CONSTRAINT [FK_Productions_ProductsInventorys]
GO
ALTER TABLE [dbo].[ReturnSelses]  WITH CHECK ADD  CONSTRAINT [FK_ReturnSelses_Customers] FOREIGN KEY([CustId])
REFERENCES [dbo].[Customers] ([CustId])
GO
ALTER TABLE [dbo].[ReturnSelses] CHECK CONSTRAINT [FK_ReturnSelses_Customers]
GO
ALTER TABLE [dbo].[ReturnSelses]  WITH CHECK ADD  CONSTRAINT [FK_ReturnSelses_ProductsInventorys] FOREIGN KEY([ProdInvId])
REFERENCES [dbo].[ProductsInventorys] ([ProdInvId])
GO
ALTER TABLE [dbo].[ReturnSelses] CHECK CONSTRAINT [FK_ReturnSelses_ProductsInventorys]
GO
ALTER TABLE [dbo].[Saleses]  WITH CHECK ADD  CONSTRAINT [FK_Saleses_CustomerOrders] FOREIGN KEY([CustOrderId])
REFERENCES [dbo].[CustomerOrders] ([CustOrderId])
GO
ALTER TABLE [dbo].[Saleses] CHECK CONSTRAINT [FK_Saleses_CustomerOrders]
GO
ALTER TABLE [dbo].[Saleses]  WITH CHECK ADD  CONSTRAINT [FK_Saleses_Employees] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employees] ([EmpId])
GO
ALTER TABLE [dbo].[Saleses] CHECK CONSTRAINT [FK_Saleses_Employees]
GO
USE [master]
GO
ALTER DATABASE [FactoryMMDb] SET  READ_WRITE 
GO
