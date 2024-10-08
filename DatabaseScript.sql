USE [master]
GO
/****** Object:  Database [Kozmeticki salon]    Script Date: 3.4.2024. 17:25:34 ******/
CREATE DATABASE [Kozmeticki salon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kozmeticki salon', FILENAME = N'C:\Users\PC\Kozmeticki salon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kozmeticki salon_log', FILENAME = N'C:\Users\PC\Kozmeticki salon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Kozmeticki salon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kozmeticki salon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kozmeticki salon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kozmeticki salon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kozmeticki salon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kozmeticki salon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kozmeticki salon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kozmeticki salon] SET  MULTI_USER 
GO
ALTER DATABASE [Kozmeticki salon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kozmeticki salon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kozmeticki salon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kozmeticki salon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kozmeticki salon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kozmeticki salon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Kozmeticki salon] SET QUERY_STORE = OFF
GO
USE [Kozmeticki salon]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 3.4.2024. 17:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijent](
	[IDKlijent] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Klijent] PRIMARY KEY CLUSTERED 
(
	[IDKlijent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 3.4.2024. 17:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[IDKlijent] [int] NOT NULL,
	[IDUsluga] [int] NOT NULL,
	[IDRezervacija] [int] IDENTITY(1,1) NOT NULL,
	[Datum] [date] NOT NULL,
	[VremePocetka] [datetime2](7) NOT NULL,
	[VremeZavrsetka] [datetime2](7) NOT NULL,
	[Napomena] [varchar](50) NULL,
	[IDZaposleni] [int] NOT NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[IDKlijent] ASC,
	[IDUsluga] ASC,
	[IDRezervacija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipUsluge]    Script Date: 3.4.2024. 17:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipUsluge](
	[IDTipUsluge] [int] IDENTITY(1,1) NOT NULL,
	[NazivTipa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipUsluge] PRIMARY KEY CLUSTERED 
(
	[IDTipUsluge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usluga]    Script Date: 3.4.2024. 17:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usluga](
	[IDUsluga] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[Cena] [float] NOT NULL,
	[Trajanje] [int] NOT NULL,
	[IDTipUsluge] [int] NOT NULL,
 CONSTRAINT [PK_Usluga] PRIMARY KEY CLUSTERED 
(
	[IDUsluga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposleni]    Script Date: 3.4.2024. 17:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposleni](
	[IDZaposleni] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Zaposleni] PRIMARY KEY CLUSTERED 
(
	[IDZaposleni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZaposleniRadi]    Script Date: 3.4.2024. 17:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZaposleniRadi](
	[IDZaposleni] [int] NOT NULL,
	[IDTipUsluge] [int] NOT NULL,
 CONSTRAINT [PK_ZaposleniRadi] PRIMARY KEY CLUSTERED 
(
	[IDZaposleni] ASC,
	[IDTipUsluge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Klijent] ON 

INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (1, N'Maja', N'Minic', N'4343', N'sdsdmm@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (2, N'Aleksandra', N'Stankovic', N'54', N'nen@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (3, N'Jovana', N'Saric', N'3232', N'aa@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (4, N'Saska', N'Markovic', N'43554', N'ssss@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (5, N'Nemanja', N'Milic', N'6666', N'da@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (6, N'Bojana', N'Matic', N'44444', N'd@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (7, N'sad', N'dsa', N'334', N'sa@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (8, N'Sara', N'Jokic', N'4424', N'a@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (9, N'Mira', N'Miric', N'4343', N'ss@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (1002, N'Marija', N'Carapic', N'444555', N'marijaposlovnicarapic@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (2002, N'Sanja', N'Jovanovic', N'444', N'sjj@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (3002, N'Jovana', N'Matic', N'545353', N'jm@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (3003, N'Milica', N'Jaksic', N'54546436', N'mj@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (3004, N'Marija', N'Lucic', N'765743', N'ml@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (3005, N'Nevena', N'Markovic', N'644343', N'nm@')
INSERT [dbo].[Klijent] ([IDKlijent], [Ime], [Prezime], [Telefon], [Email]) VALUES (4002, N'Jovana', N'Milivojevic', N'065245152', N'jm@')
SET IDENTITY_INSERT [dbo].[Klijent] OFF
GO
SET IDENTITY_INSERT [dbo].[Rezervacija] ON 

INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (4, 3, 8014, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T11:00:00.0000000' AS DateTime2), CAST(N'2024-03-28T11:05:00.0000000' AS DateTime2), N'', 1)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (4, 3007, 8013, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T10:00:00.0000000' AS DateTime2), CAST(N'2024-03-28T10:30:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (4, 3010, 4013, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T11:00:00.0000000' AS DateTime2), CAST(N'2024-04-05T11:50:00.0000000' AS DateTime2), N'', 1003)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (4, 3012, 4014, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T11:01:00.0000000' AS DateTime2), CAST(N'2024-04-05T11:16:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (4, 3012, 4015, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T11:02:00.0000000' AS DateTime2), CAST(N'2024-04-05T11:17:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (5, 3013, 2020, CAST(N'2024-04-05' AS Date), CAST(N'1900-01-01T11:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T11:25:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (5, 3013, 2021, CAST(N'2024-04-05' AS Date), CAST(N'1900-01-01T11:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T11:25:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (6, 3, 10014, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T09:50:00.0000000' AS DateTime2), CAST(N'2024-03-28T09:55:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (6, 1005, 9013, CAST(N'2024-03-29' AS Date), CAST(N'2024-03-29T08:00:00.0000000' AS DateTime2), CAST(N'2024-03-29T08:50:00.0000000' AS DateTime2), N'', 1)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (6, 1005, 9014, CAST(N'2024-03-29' AS Date), CAST(N'2024-03-29T09:00:00.0000000' AS DateTime2), CAST(N'2024-03-29T09:50:00.0000000' AS DateTime2), N'', 3)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (6, 1005, 10013, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T11:05:00.0000000' AS DateTime2), CAST(N'2024-03-28T11:55:00.0000000' AS DateTime2), N'', 1)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (6, 3012, 10015, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T11:58:00.0000000' AS DateTime2), CAST(N'2024-03-28T12:13:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (7, 3002, 6018, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T15:00:00.0000000' AS DateTime2), CAST(N'2024-04-05T15:50:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (7, 3006, 6019, CAST(N'2024-04-06' AS Date), CAST(N'2024-04-06T14:00:00.0000000' AS DateTime2), CAST(N'2024-04-06T16:00:00.0000000' AS DateTime2), N'', 3)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (8, 3, 6017, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T08:00:00.0000000' AS DateTime2), CAST(N'2024-04-05T08:05:00.0000000' AS DateTime2), N'', 1003)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (8, 3002, 6016, CAST(N'2024-04-03' AS Date), CAST(N'2024-04-03T08:00:00.0000000' AS DateTime2), CAST(N'2024-04-03T08:50:00.0000000' AS DateTime2), N'', 3)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (9, 1005, 5013, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T12:20:00.0000000' AS DateTime2), CAST(N'2024-04-05T13:10:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (9, 3007, 11013, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T12:00:00.0000000' AS DateTime2), CAST(N'2024-03-28T12:30:00.0000000' AS DateTime2), N'', 1)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (9, 3010, 5014, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T12:20:00.0000000' AS DateTime2), CAST(N'2024-04-05T13:10:00.0000000' AS DateTime2), N'', 1003)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (9, 3012, 3014, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T11:26:00.0000000' AS DateTime2), CAST(N'2024-04-05T11:41:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (3004, 1005, 6014, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T10:01:00.0000000' AS DateTime2), CAST(N'2024-04-05T10:51:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (3004, 3006, 6013, CAST(N'2024-04-05' AS Date), CAST(N'2024-04-05T09:00:00.0000000' AS DateTime2), CAST(N'2024-04-05T11:00:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (3004, 3006, 7014, CAST(N'2024-03-28' AS Date), CAST(N'2024-03-28T08:00:00.0000000' AS DateTime2), CAST(N'2024-03-28T10:00:00.0000000' AS DateTime2), N'', 5)
INSERT [dbo].[Rezervacija] ([IDKlijent], [IDUsluga], [IDRezervacija], [Datum], [VremePocetka], [VremeZavrsetka], [Napomena], [IDZaposleni]) VALUES (3004, 3010, 6015, CAST(N'2024-04-04' AS Date), CAST(N'2024-04-04T10:01:00.0000000' AS DateTime2), CAST(N'2024-04-04T10:51:00.0000000' AS DateTime2), N'', 1)
SET IDENTITY_INSERT [dbo].[Rezervacija] OFF
GO
SET IDENTITY_INSERT [dbo].[TipUsluge] ON 

INSERT [dbo].[TipUsluge] ([IDTipUsluge], [NazivTipa]) VALUES (1, N'Tretmani lica')
INSERT [dbo].[TipUsluge] ([IDTipUsluge], [NazivTipa]) VALUES (2, N'Frizerske usluge')
INSERT [dbo].[TipUsluge] ([IDTipUsluge], [NazivTipa]) VALUES (3, N'Manikir')
INSERT [dbo].[TipUsluge] ([IDTipUsluge], [NazivTipa]) VALUES (4, N'Depilacija')
INSERT [dbo].[TipUsluge] ([IDTipUsluge], [NazivTipa]) VALUES (5, N'Masaže')
SET IDENTITY_INSERT [dbo].[TipUsluge] OFF
GO
SET IDENTITY_INSERT [dbo].[Usluga] ON 

INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3, N'fdff', 34, 5, 3)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (1005, N'sisanje', 900, 50, 2)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3002, N'Higijenski tretman', 3000, 50, 1)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3003, N'Dermapen', 7000, 45, 1)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3004, N'Hemijski piling', 4000, 35, 1)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3005, N'Mikrodermoabrazija', 4500, 40, 1)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3006, N'Keratinsko ispravljanje', 8000, 120, 2)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3007, N'Sisanje', 1000, 30, 2)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3008, N'Feniranje', 700888, 300, 2)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3009, N'Pramenovi', 5000, 100, 2)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3010, N'Gel lak', 1000, 50, 3)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3011, N'Nadogradnja', 1500, 60, 3)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3012, N'Depilacija ruku', 600, 15, 4)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3013, N'Depilacija nogu', 900, 25, 4)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3014, N'Relax masaza ledja', 1500, 30, 5)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (3015, N'Masaza lica', 1000, 20, 5)
INSERT [dbo].[Usluga] ([IDUsluga], [Naziv], [Cena], [Trajanje], [IDTipUsluge]) VALUES (5002, N'Depilacija celog tela', 2000, 40, 4)
SET IDENTITY_INSERT [dbo].[Usluga] OFF
GO
SET IDENTITY_INSERT [dbo].[Zaposleni] ON 

INSERT [dbo].[Zaposleni] ([IDZaposleni], [Ime], [Prezime], [Telefon], [Adresa], [Username], [Password]) VALUES (1, N'Marija', N'Carapic', N'06562365', N'Bela Zemlja', N'm', N'm')
INSERT [dbo].[Zaposleni] ([IDZaposleni], [Ime], [Prezime], [Telefon], [Adresa], [Username], [Password]) VALUES (3, N'Nemanja', N'Milic', N'063256362', N'Priluzje', N'n', N'n')
INSERT [dbo].[Zaposleni] ([IDZaposleni], [Ime], [Prezime], [Telefon], [Adresa], [Username], [Password]) VALUES (5, N'Aleksandra', N'Markovic', N'064125452', N'Ub', N'a', N'a')
INSERT [dbo].[Zaposleni] ([IDZaposleni], [Ime], [Prezime], [Telefon], [Adresa], [Username], [Password]) VALUES (1003, N'Pera', N'Peric', N'061236632', N'Beograd', N'p', N'p')
INSERT [dbo].[Zaposleni] ([IDZaposleni], [Ime], [Prezime], [Telefon], [Adresa], [Username], [Password]) VALUES (1004, N'Zika', N'Zikic', N'064546564', N'Ub', N'z', N'z')
SET IDENTITY_INSERT [dbo].[Zaposleni] OFF
GO
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1, 1)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1, 2)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (3, 2)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (3, 4)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (3, 5)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (5, 1)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (5, 3)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (5, 4)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1003, 1)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1003, 3)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1003, 5)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1004, 2)
INSERT [dbo].[ZaposleniRadi] ([IDZaposleni], [IDTipUsluge]) VALUES (1004, 5)
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Klijent] FOREIGN KEY([IDKlijent])
REFERENCES [dbo].[Klijent] ([IDKlijent])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Klijent]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Usluga] FOREIGN KEY([IDUsluga])
REFERENCES [dbo].[Usluga] ([IDUsluga])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Usluga]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Zaposleni] FOREIGN KEY([IDZaposleni])
REFERENCES [dbo].[Zaposleni] ([IDZaposleni])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Zaposleni]
GO
ALTER TABLE [dbo].[Usluga]  WITH CHECK ADD  CONSTRAINT [FK_Usluga_TipUsluge] FOREIGN KEY([IDTipUsluge])
REFERENCES [dbo].[TipUsluge] ([IDTipUsluge])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Usluga] CHECK CONSTRAINT [FK_Usluga_TipUsluge]
GO
ALTER TABLE [dbo].[ZaposleniRadi]  WITH CHECK ADD  CONSTRAINT [FK_ZaposleniRadi_TipUsluge] FOREIGN KEY([IDTipUsluge])
REFERENCES [dbo].[TipUsluge] ([IDTipUsluge])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ZaposleniRadi] CHECK CONSTRAINT [FK_ZaposleniRadi_TipUsluge]
GO
ALTER TABLE [dbo].[ZaposleniRadi]  WITH CHECK ADD  CONSTRAINT [FK_ZaposleniRadi_Zaposleni] FOREIGN KEY([IDZaposleni])
REFERENCES [dbo].[Zaposleni] ([IDZaposleni])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ZaposleniRadi] CHECK CONSTRAINT [FK_ZaposleniRadi_Zaposleni]
GO
USE [master]
GO
ALTER DATABASE [Kozmeticki salon] SET  READ_WRITE 
GO
