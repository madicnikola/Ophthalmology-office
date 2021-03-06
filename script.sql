USE [master]
GO
/****** Object:  Database [oft-office-db]    Script Date: 28-Jun-21 02:32:03 ******/
CREATE DATABASE [oft-office-db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'oft-office-db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\oft-office-db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'oft-office-db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\oft-office-db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [oft-office-db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [oft-office-db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [oft-office-db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [oft-office-db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [oft-office-db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [oft-office-db] SET ARITHABORT OFF 
GO
ALTER DATABASE [oft-office-db] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [oft-office-db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [oft-office-db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [oft-office-db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [oft-office-db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [oft-office-db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [oft-office-db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [oft-office-db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [oft-office-db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [oft-office-db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [oft-office-db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [oft-office-db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [oft-office-db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [oft-office-db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [oft-office-db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [oft-office-db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [oft-office-db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [oft-office-db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [oft-office-db] SET  MULTI_USER 
GO
ALTER DATABASE [oft-office-db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [oft-office-db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [oft-office-db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [oft-office-db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [oft-office-db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [oft-office-db] SET QUERY_STORE = OFF
GO
USE [oft-office-db]
GO
/****** Object:  Table [dbo].[korisnikSistema]    Script Date: 28-Jun-21 02:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnikSistema](
	[KorisnikId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](255) NULL,
 CONSTRAINT [PK_korisnikSistema] PRIMARY KEY CLUSTERED 
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lekar]    Script Date: 28-Jun-21 02:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lekar](
	[lekarId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[Specijalizacija] [varchar](255) NULL,
 CONSTRAINT [PK_lekar] PRIMARY KEY CLUSTERED 
(
	[lekarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pacijent]    Script Date: 28-Jun-21 02:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pacijent](
	[BrojKartonaId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[DatumRodjenja] [datetime] NULL,
	[Telefon] [varchar](50) NULL,
	[Oboljenja] [varchar](1023) NULL,
	[Dioptrija] [bit] NULL,
	[Opis] [varchar](1023) NULL,
PRIMARY KEY CLUSTERED 
(
	[BrojKartonaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pregled]    Script Date: 28-Jun-21 02:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pregled](
	[PregledId] [int] IDENTITY(1,1) NOT NULL,
	[LekarId] [int] NOT NULL,
	[BrojKartonaId] [int] NOT NULL,
	[DatumPregleda] [datetime] NULL,
	[BrojPregleda] [int] NULL,
 CONSTRAINT [PK_pregled] PRIMARY KEY CLUSTERED 
(
	[PregledId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stavkaPregleda]    Script Date: 28-Jun-21 02:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stavkaPregleda](
	[PregledId] [int] NOT NULL,
	[StavkaPregledaId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NULL,
	[TipIntervId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PregledId] ASC,
	[StavkaPregledaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipIntervencije]    Script Date: 28-Jun-21 02:32:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipIntervencije](
	[TipIntervId] [int] IDENTITY(1,1) NOT NULL,
	[Opis] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TipIntervId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[pregled]  WITH CHECK ADD  CONSTRAINT [FK_pregled_Lekar] FOREIGN KEY([LekarId])
REFERENCES [dbo].[lekar] ([lekarId])
GO
ALTER TABLE [dbo].[pregled] CHECK CONSTRAINT [FK_pregled_Lekar]
GO
ALTER TABLE [dbo].[pregled]  WITH CHECK ADD  CONSTRAINT [FK_pregled_Pacijent] FOREIGN KEY([BrojKartonaId])
REFERENCES [dbo].[pacijent] ([BrojKartonaId])
GO
ALTER TABLE [dbo].[pregled] CHECK CONSTRAINT [FK_pregled_Pacijent]
GO
ALTER TABLE [dbo].[stavkaPregleda]  WITH CHECK ADD  CONSTRAINT [FK_stavkaPregleda_Pregled] FOREIGN KEY([PregledId])
REFERENCES [dbo].[pregled] ([PregledId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stavkaPregleda] CHECK CONSTRAINT [FK_stavkaPregleda_Pregled]
GO
ALTER TABLE [dbo].[stavkaPregleda]  WITH CHECK ADD  CONSTRAINT [FK_stavkaPregleda_TipIntrv] FOREIGN KEY([TipIntervId])
REFERENCES [dbo].[tipIntervencije] ([TipIntervId])
GO
ALTER TABLE [dbo].[stavkaPregleda] CHECK CONSTRAINT [FK_stavkaPregleda_TipIntrv]
GO
USE [master]
GO
ALTER DATABASE [oft-office-db] SET  READ_WRITE 
GO
