USE [master]
GO
/****** Object:  Database [Pitch]    Script Date: 1/28/2019 7:11:51 PM ******/
CREATE DATABASE [Pitch]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pitch', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Pitch.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pitch_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Pitch_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Pitch] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pitch].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pitch] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pitch] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pitch] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pitch] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pitch] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pitch] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pitch] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pitch] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pitch] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pitch] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pitch] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pitch] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pitch] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pitch] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pitch] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pitch] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pitch] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pitch] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pitch] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pitch] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pitch] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pitch] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pitch] SET RECOVERY FULL 
GO
ALTER DATABASE [Pitch] SET  MULTI_USER 
GO
ALTER DATABASE [Pitch] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pitch] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pitch] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pitch] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pitch] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Pitch', N'ON'
GO
ALTER DATABASE [Pitch] SET QUERY_STORE = OFF
GO
USE [Pitch]
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
USE [Pitch]
GO
/****** Object:  Table [dbo].[campingType]    Script Date: 1/28/2019 7:11:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[campingType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[location_id] [int] NULL,
	[glamping] [bit] NULL,
	[backcountry] [bit] NULL,
	[modern_camping] [bit] NULL,
	[tent_only] [bit] NULL,
	[electricalHookUp] [bit] NULL,
	[rvOnly] [bit] NULL,
	[state_nationl_park] [bit] NULL,
	[internetConnectivity] [bit] NULL,
	[campStore] [bit] NULL,
	[showers] [bit] NULL,
	[toilets] [bit] NULL,
	[cell_phone_reception] [bit] NULL,
	[laundry] [bit] NULL,
	[dumpStation] [bit] NULL,
	[staffOnSite] [bit] NULL,
	[fireStovePolicy] [bit] NULL,
	[wheelchairacces] [bit] NULL,
	[adaInfo] [bit] NULL,
	[accessRoad] [bit] NULL,
	[potableWater] [bit] NULL,
	[firewood_for_sale] [bit] NULL,
	[food_storage_locker] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[locations]    Script Date: 1/28/2019 7:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[locations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[campingTypeId] [int] NULL,
	[reveiewId] [int] NULL,
	[name] [varchar](255) NULL,
	[city] [varchar](255) NULL,
	[state] [varchar](255) NULL,
	[description] [varchar](255) NULL,
	[img] [varchar](255) NULL,
	[glamping] [bit] NULL,
	[backcountry] [bit] NULL,
	[modern_camping] [bit] NULL,
	[latLong] [varchar](255) NULL,
	[parkCode] [varchar](255) NULL,
	[hourOfOperation] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviews]    Script Date: 1/28/2019 7:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviews](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[location_id] [int] NULL,
	[rating] [varchar](255) NULL,
	[comment] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 1/28/2019 7:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](255) NOT NULL,
	[last_name] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[age] [int] NULL,
	[experienced_camper] [bit] NULL,
	[wishList_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wishItem]    Script Date: 1/28/2019 7:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wishItem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[wishList_id] [int] NULL,
	[location_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wishLists]    Script Date: 1/28/2019 7:11:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wishLists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[name] [varchar](255) NULL,
	[description] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[campingType] ON 
GO
INSERT [dbo].[campingType] ([id], [location_id], [glamping], [backcountry], [modern_camping], [tent_only], [electricalHookUp], [rvOnly], [state_nationl_park], [internetConnectivity], [campStore], [showers], [toilets], [cell_phone_reception], [laundry], [dumpStation], [staffOnSite], [fireStovePolicy], [wheelchairacces], [adaInfo], [accessRoad], [potableWater], [firewood_for_sale], [food_storage_locker]) VALUES (4, 1, 0, 1, 0, 1, 0, NULL, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[campingType] OFF
GO
SET IDENTITY_INSERT [dbo].[locations] ON 
GO
INSERT [dbo].[locations] ([id], [campingTypeId], [reveiewId], [name], [city], [state], [description], [img], [glamping], [backcountry], [modern_camping], [latLong], [parkCode], [hourOfOperation]) VALUES (1, 4, NULL, N'Woods', N'Nashville', N'TN', N'lots of trees', NULL, 0, 1, 0, N'1.990', N'23.109', NULL)
GO
SET IDENTITY_INSERT [dbo].[locations] OFF
GO
SET IDENTITY_INSERT [dbo].[reviews] ON 
GO
INSERT [dbo].[reviews] ([id], [user_id], [location_id], [rating], [comment]) VALUES (2, 1, 1, NULL, N'awesome!!!')
GO
SET IDENTITY_INSERT [dbo].[reviews] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 
GO
INSERT [dbo].[users] ([id], [first_name], [last_name], [email], [age], [experienced_camper], [wishList_id]) VALUES (1, N'Test', N'Test', N'test@test.com', 20, NULL, 1)
GO
INSERT [dbo].[users] ([id], [first_name], [last_name], [email], [age], [experienced_camper], [wishList_id]) VALUES (3, N'Ted', N'Zanner', N'ted@gmail.com', 23, NULL, 2)
GO
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET IDENTITY_INSERT [dbo].[wishItem] ON 
GO
INSERT [dbo].[wishItem] ([id], [wishList_id], [location_id]) VALUES (3, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[wishItem] OFF
GO
SET IDENTITY_INSERT [dbo].[wishLists] ON 
GO
INSERT [dbo].[wishLists] ([id], [user_id], [name], [description]) VALUES (1, 1, N'Why should you go?', N'Nothing short of amazing.')
GO
SET IDENTITY_INSERT [dbo].[wishLists] OFF
GO
ALTER TABLE [dbo].[campingType]  WITH CHECK ADD FOREIGN KEY([location_id])
REFERENCES [dbo].[locations] ([id])
GO
ALTER TABLE [dbo].[reviews]  WITH CHECK ADD FOREIGN KEY([location_id])
REFERENCES [dbo].[locations] ([id])
GO
ALTER TABLE [dbo].[reviews]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[wishItem]  WITH CHECK ADD FOREIGN KEY([location_id])
REFERENCES [dbo].[locations] ([id])
GO
ALTER TABLE [dbo].[wishItem]  WITH CHECK ADD FOREIGN KEY([wishList_id])
REFERENCES [dbo].[wishLists] ([id])
GO
ALTER TABLE [dbo].[wishLists]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
GO
USE [master]
GO
ALTER DATABASE [Pitch] SET  READ_WRITE 
GO
