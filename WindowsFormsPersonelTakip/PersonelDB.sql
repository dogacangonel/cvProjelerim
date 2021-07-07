USE [master]
GO
/****** Object:  Database [PersonelDB]    Script Date: 2.07.2021 15:26:28 ******/
CREATE DATABASE [PersonelDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonelDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PersonelDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PersonelDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PersonelDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PersonelDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonelDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonelDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonelDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonelDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonelDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonelDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonelDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonelDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonelDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonelDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonelDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonelDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonelDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonelDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonelDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonelDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PersonelDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonelDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonelDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonelDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonelDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonelDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonelDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonelDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PersonelDB] SET  MULTI_USER 
GO
ALTER DATABASE [PersonelDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonelDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonelDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonelDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PersonelDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PersonelDB]
GO
/****** Object:  Table [dbo].[birim]    Script Date: 2.07.2021 15:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[birim](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[birim] [varchar](20) NULL,
 CONSTRAINT [PK_birim] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personeller]    Script Date: 2.07.2021 15:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personeller](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SicilNo] [int] NULL,
	[isim] [varchar](20) NULL,
	[soyad] [varchar](20) NULL,
	[cinsiyet] [varchar](10) NULL,
	[dogumTarihi] [date] NULL,
	[birim] [varchar](20) NULL,
	[cepTel] [varchar](20) NULL,
	[adres] [varchar](250) NULL,
 CONSTRAINT [PK_personeller] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[birim] ON 

INSERT [dbo].[birim] ([id], [birim]) VALUES (1, N'İdari İşler')
INSERT [dbo].[birim] ([id], [birim]) VALUES (2, N'Evrak Arşiv')
INSERT [dbo].[birim] ([id], [birim]) VALUES (3, N'Bilgi İşlem')
INSERT [dbo].[birim] ([id], [birim]) VALUES (4, N'Muhasebe')
INSERT [dbo].[birim] ([id], [birim]) VALUES (5, N'İnsan Kaynakları')
SET IDENTITY_INSERT [dbo].[birim] OFF
SET IDENTITY_INSERT [dbo].[personeller] ON 

INSERT [dbo].[personeller] ([id], [SicilNo], [isim], [soyad], [cinsiyet], [dogumTarihi], [birim], [cepTel], [adres]) VALUES (1, 123456, N'Doğacan', N'Gönel', N'Erkek', CAST(N'1992-03-09' AS Date), N'Bilgi İşlem', N'(554) 138-7038', N'Sancaktepe/İstanbul')
INSERT [dbo].[personeller] ([id], [SicilNo], [isim], [soyad], [cinsiyet], [dogumTarihi], [birim], [cepTel], [adres]) VALUES (10, 122456, N'Durukan', N'Gönel', N'Erkek', CAST(N'1990-11-13' AS Date), N'Evrak Arşiv', N'(111) 111-1111', N'adasdada')
INSERT [dbo].[personeller] ([id], [SicilNo], [isim], [soyad], [cinsiyet], [dogumTarihi], [birim], [cepTel], [adres]) VALUES (11, 122456, N'Durukan', N'Gönel', N'Erkek', CAST(N'1992-11-13' AS Date), N'Evrak Arşiv', N'(111) 111-1111', N'adasdada')
SET IDENTITY_INSERT [dbo].[personeller] OFF
USE [master]
GO
ALTER DATABASE [PersonelDB] SET  READ_WRITE 
GO
