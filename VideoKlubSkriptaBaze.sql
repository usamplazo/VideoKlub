USE [VideoKlub]
GO
ALTER TABLE [dbo].[Kazne] DROP CONSTRAINT [FK_Kazne_Clanovi]
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova] DROP CONSTRAINT [FK_Iznajmljivanje_Filmova_Radnici]
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova] DROP CONSTRAINT [FK_Iznajmljivanje_Filmova_Filmovi]
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova] DROP CONSTRAINT [FK_Iznajmljivanje_Filmova_Clanovi]
GO
ALTER TABLE [dbo].[Clanovi] DROP CONSTRAINT [FK_Clanovi_KredKartice]
GO
/****** Object:  Table [dbo].[Radnici]    Script Date: 7/28/2021 10:03:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Radnici]') AND type in (N'U'))
DROP TABLE [dbo].[Radnici]
GO
/****** Object:  Table [dbo].[KredKartice]    Script Date: 7/28/2021 10:03:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KredKartice]') AND type in (N'U'))
DROP TABLE [dbo].[KredKartice]
GO
/****** Object:  Table [dbo].[Kazne]    Script Date: 7/28/2021 10:03:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kazne]') AND type in (N'U'))
DROP TABLE [dbo].[Kazne]
GO
/****** Object:  Table [dbo].[Iznajmljivanje_Filmova]    Script Date: 7/28/2021 10:03:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Iznajmljivanje_Filmova]') AND type in (N'U'))
DROP TABLE [dbo].[Iznajmljivanje_Filmova]
GO
/****** Object:  Table [dbo].[Filmovi]    Script Date: 7/28/2021 10:03:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Filmovi]') AND type in (N'U'))
DROP TABLE [dbo].[Filmovi]
GO
/****** Object:  Table [dbo].[Clanovi]    Script Date: 7/28/2021 10:03:32 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clanovi]') AND type in (N'U'))
DROP TABLE [dbo].[Clanovi]
GO
USE [master]
GO
/****** Object:  Database [VideoKlub]    Script Date: 7/28/2021 10:03:32 PM ******/
DROP DATABASE [VideoKlub]
GO
/****** Object:  Database [VideoKlub]    Script Date: 7/28/2021 10:03:32 PM ******/
CREATE DATABASE [VideoKlub]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoKlub', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VideoKlub.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideoKlub_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VideoKlub_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoKlub].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoKlub] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoKlub] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoKlub] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoKlub] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoKlub] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoKlub] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoKlub] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoKlub] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoKlub] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoKlub] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoKlub] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoKlub] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoKlub] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoKlub] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoKlub] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoKlub] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoKlub] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoKlub] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoKlub] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoKlub] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoKlub] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoKlub] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoKlub] SET RECOVERY FULL 
GO
ALTER DATABASE [VideoKlub] SET  MULTI_USER 
GO
ALTER DATABASE [VideoKlub] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoKlub] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoKlub] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoKlub] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoKlub] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VideoKlub', N'ON'
GO
USE [VideoKlub]
GO
/****** Object:  Table [dbo].[Clanovi]    Script Date: 7/28/2021 10:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clanovi](
	[ClanID] [nvarchar](10) NOT NULL,
	[JMBG] [nvarchar](13) NOT NULL,
	[Ime] [nvarchar](30) NOT NULL,
	[Prezime] [nvarchar](30) NOT NULL,
	[Pol] [nvarchar](10) NOT NULL,
	[Telefon] [nvarchar](18) NULL,
	[ClanOD] [date] NOT NULL,
	[CalnDO] [date] NULL,
	[KredKarID] [int] NULL,
 CONSTRAINT [PK_Clanovi] PRIMARY KEY CLUSTERED 
(
	[ClanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filmovi]    Script Date: 7/28/2021 10:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filmovi](
	[FilmID] [nvarchar](10) NOT NULL,
	[Naziv] [nvarchar](30) NOT NULL,
	[Reziser] [nvarchar](30) NOT NULL,
	[Zanr] [nvarchar](20) NOT NULL,
	[GodinaIzdanja] [int] NOT NULL,
	[Ocena] [float] NULL,
	[BrojPrimeraka] [int] NOT NULL,
 CONSTRAINT [PK_Filmovi] PRIMARY KEY CLUSTERED 
(
	[FilmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iznajmljivanje_Filmova]    Script Date: 7/28/2021 10:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iznajmljivanje_Filmova](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FilmID] [nvarchar](10) NOT NULL,
	[ClanID] [nvarchar](10) NOT NULL,
	[DatumIznajmljivanja] [date] NOT NULL,
	[DatumVracanja] [date] NULL,
	[Radnik] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Iznajmljivanje_Filmova] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kazne]    Script Date: 7/28/2021 10:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kazne](
	[KaznaID] [int] NOT NULL,
	[ClanID] [nvarchar](10) NOT NULL,
	[DatumPisanja] [date] NOT NULL,
	[VisinaNadoknade] [float] NOT NULL,
	[TipKazne] [nvarchar](30) NOT NULL,
	[Placena] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_Kazne] PRIMARY KEY CLUSTERED 
(
	[KaznaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KredKartice]    Script Date: 7/28/2021 10:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KredKartice](
	[ID] [int] IDENTITY(100,1) NOT NULL,
	[BrojKartice] [nvarchar](20) NULL,
	[DatumIsteka] [nvarchar](6) NOT NULL,
	[CVC] [nvarchar](4) NOT NULL,
	[Tip] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_KredKartice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnici]    Script Date: 7/28/2021 10:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnici](
	[RadnikID] [nvarchar](10) NOT NULL,
	[Ime] [nvarchar](30) NOT NULL,
	[Prezime] [nchar](10) NOT NULL,
	[JMBG] [nvarchar](13) NOT NULL,
	[Plata] [float] NOT NULL,
	[DatOD] [date] NOT NULL,
	[DatDo] [date] NULL,
 CONSTRAINT [PK_Radnici] PRIMARY KEY CLUSTERED 
(
	[RadnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11001', N'1502987625847', N'Nikola', N'Tesla', N'muskarac', N'0641111111', CAST(N'2020-12-10' AS Date), NULL, NULL)
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11002', N'2505986021436', N'Djordje', N'Vajfert', N'muskarac', N'0631110011', CAST(N'2020-05-08' AS Date), CAST(N'2021-07-24' AS Date), NULL)
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11003', N'0202988457896', N'Nadezda', N'Petrovic', N'Zena', N'0640001111', CAST(N'2021-07-24' AS Date), NULL, 101)
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11004', N'1005969654895', N'Petar', N'Petrovic', N'Muskarac', N'063 5553 330', CAST(N'2021-07-24' AS Date), NULL, 102)
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11006', N'0502959020014', N'Jovan', N'Cvijic', N'Muskarac', N'066 2222 222', CAST(N'2021-07-24' AS Date), CAST(N'2021-07-24' AS Date), NULL)
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11009', N'0812965340512', N'Stojanovic', N'Stojanovic', N'Muskarac', N'062 3333 333', CAST(N'2021-07-24' AS Date), CAST(N'2021-07-28' AS Date), NULL)
INSERT [dbo].[Clanovi] ([ClanID], [JMBG], [Ime], [Prezime], [Pol], [Telefon], [ClanOD], [CalnDO], [KredKarID]) VALUES (N'11010', N'2211977654728', N'Ivo', N'Andric', N'Muskarac', N'064 0011 001', CAST(N'2021-07-28' AS Date), NULL, NULL)
GO
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'111', N'Efekat leptira', N'Eric Bress', N'Triler', 2004, 7.6, 3)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'222', N'Tajna besprekornog uma', N'Michael Gondry', N'Drama', 2004, 8.3, 2)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'333', N'Baby driver', N'Edgar Wirgiht', N'Akcija', 2017, 7.6, 1)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'444', N'El Camino', N'Vince Giligan', N'Krimi', 2019, 7.3, 3)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'555', N'Hangover 1', N'Todd Philips', N'Komedija', 2009, 7.7, 4)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'666', N'Hangover 2', N'Todd Philips', N'Komedija', 2011, 6.4, 3)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'777', N'Hangover 3', N'Todd Philips', N'Komedija', 2013, 5.8, 1)
INSERT [dbo].[Filmovi] ([FilmID], [Naziv], [Reziser], [Zanr], [GodinaIzdanja], [Ocena], [BrojPrimeraka]) VALUES (N'888', N'Svemocni Brus', N'Naucna fantastika', N'2003', 2003, 6.7, 2)
GO
SET IDENTITY_INSERT [dbo].[Iznajmljivanje_Filmova] ON 

INSERT [dbo].[Iznajmljivanje_Filmova] ([ID], [FilmID], [ClanID], [DatumIznajmljivanja], [DatumVracanja], [Radnik]) VALUES (1, N'111', N'11006', CAST(N'2021-07-28' AS Date), NULL, N'1003')
INSERT [dbo].[Iznajmljivanje_Filmova] ([ID], [FilmID], [ClanID], [DatumIznajmljivanja], [DatumVracanja], [Radnik]) VALUES (2, N'111', N'11002', CAST(N'2021-07-28' AS Date), CAST(N'2021-08-11' AS Date), N'1003')
INSERT [dbo].[Iznajmljivanje_Filmova] ([ID], [FilmID], [ClanID], [DatumIznajmljivanja], [DatumVracanja], [Radnik]) VALUES (3, N'888', N'11009', CAST(N'2021-07-28' AS Date), CAST(N'2021-07-27' AS Date), N'1003')
INSERT [dbo].[Iznajmljivanje_Filmova] ([ID], [FilmID], [ClanID], [DatumIznajmljivanja], [DatumVracanja], [Radnik]) VALUES (4, N'444', N'11006', CAST(N'2021-07-28' AS Date), CAST(N'2021-08-12' AS Date), N'1003')
SET IDENTITY_INSERT [dbo].[Iznajmljivanje_Filmova] OFF
GO
INSERT [dbo].[Kazne] ([KaznaID], [ClanID], [DatumPisanja], [VisinaNadoknade], [TipKazne], [Placena]) VALUES (633889, N'11006', CAST(N'2021-07-28' AS Date), 1000, N'Film je vracen nakon
15 dana 
', N'da')
INSERT [dbo].[Kazne] ([KaznaID], [ClanID], [DatumPisanja], [VisinaNadoknade], [TipKazne], [Placena]) VALUES (688670, N'11002', CAST(N'2021-07-28' AS Date), 1000, N'Film je vracen nakon
14 dana 
', N'da')
GO
SET IDENTITY_INSERT [dbo].[KredKartice] ON 

INSERT [dbo].[KredKartice] ([ID], [BrojKartice], [DatumIsteka], [CVC], [Tip]) VALUES (101, N'1234 5678 9101 1121', N'12/12', N'132', N'Visa')
INSERT [dbo].[KredKartice] ([ID], [BrojKartice], [DatumIsteka], [CVC], [Tip]) VALUES (102, N'1111 1111 1111 1111', N'10/05', N'222', N'Master Card')
SET IDENTITY_INSERT [dbo].[KredKartice] OFF
GO
INSERT [dbo].[Radnici] ([RadnikID], [Ime], [Prezime], [JMBG], [Plata], [DatOD], [DatDo]) VALUES (N'1001', N'Marko', N'Markovic  ', N'0305998152657', 35000, CAST(N'2020-01-02' AS Date), NULL)
INSERT [dbo].[Radnici] ([RadnikID], [Ime], [Prezime], [JMBG], [Plata], [DatOD], [DatDo]) VALUES (N'1002', N'Luka', N'Lukic     ', N'1501985165425', 35000, CAST(N'2019-12-05' AS Date), NULL)
INSERT [dbo].[Radnici] ([RadnikID], [Ime], [Prezime], [JMBG], [Plata], [DatOD], [DatDo]) VALUES (N'1003', N'Milica', N'Milicic   ', N'2510000542518', 38000, CAST(N'2021-03-03' AS Date), NULL)
INSERT [dbo].[Radnici] ([RadnikID], [Ime], [Prezime], [JMBG], [Plata], [DatOD], [DatDo]) VALUES (N'1004', N'Vuk', N'Vukovic   ', N'2908999256897', 35000, CAST(N'2018-05-06' AS Date), CAST(N'2019-01-09' AS Date))
GO
ALTER TABLE [dbo].[Clanovi]  WITH CHECK ADD  CONSTRAINT [FK_Clanovi_KredKartice] FOREIGN KEY([KredKarID])
REFERENCES [dbo].[KredKartice] ([ID])
GO
ALTER TABLE [dbo].[Clanovi] CHECK CONSTRAINT [FK_Clanovi_KredKartice]
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova]  WITH CHECK ADD  CONSTRAINT [FK_Iznajmljivanje_Filmova_Clanovi] FOREIGN KEY([ClanID])
REFERENCES [dbo].[Clanovi] ([ClanID])
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova] CHECK CONSTRAINT [FK_Iznajmljivanje_Filmova_Clanovi]
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova]  WITH CHECK ADD  CONSTRAINT [FK_Iznajmljivanje_Filmova_Filmovi] FOREIGN KEY([FilmID])
REFERENCES [dbo].[Filmovi] ([FilmID])
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova] CHECK CONSTRAINT [FK_Iznajmljivanje_Filmova_Filmovi]
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova]  WITH CHECK ADD  CONSTRAINT [FK_Iznajmljivanje_Filmova_Radnici] FOREIGN KEY([Radnik])
REFERENCES [dbo].[Radnici] ([RadnikID])
GO
ALTER TABLE [dbo].[Iznajmljivanje_Filmova] CHECK CONSTRAINT [FK_Iznajmljivanje_Filmova_Radnici]
GO
ALTER TABLE [dbo].[Kazne]  WITH CHECK ADD  CONSTRAINT [FK_Kazne_Clanovi] FOREIGN KEY([ClanID])
REFERENCES [dbo].[Clanovi] ([ClanID])
GO
ALTER TABLE [dbo].[Kazne] CHECK CONSTRAINT [FK_Kazne_Clanovi]
GO
USE [master]
GO
ALTER DATABASE [VideoKlub] SET  READ_WRITE 
GO
