USE [master]
GO
/****** Object:  Database [MostriVsEroi]    Script Date: 17/06/2021 20:28:05 ******/
CREATE DATABASE [MostriVsEroi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MostriVsEroi', FILENAME = N'C:\Users\fradi\MostriVsEroi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MostriVsEroi_log', FILENAME = N'C:\Users\fradi\MostriVsEroi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MostriVsEroi] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MostriVsEroi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MostriVsEroi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MostriVsEroi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MostriVsEroi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MostriVsEroi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MostriVsEroi] SET ARITHABORT OFF 
GO
ALTER DATABASE [MostriVsEroi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MostriVsEroi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MostriVsEroi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MostriVsEroi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MostriVsEroi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MostriVsEroi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MostriVsEroi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MostriVsEroi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MostriVsEroi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MostriVsEroi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MostriVsEroi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MostriVsEroi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MostriVsEroi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MostriVsEroi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MostriVsEroi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MostriVsEroi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MostriVsEroi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MostriVsEroi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MostriVsEroi] SET  MULTI_USER 
GO
ALTER DATABASE [MostriVsEroi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MostriVsEroi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MostriVsEroi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MostriVsEroi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MostriVsEroi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MostriVsEroi] SET QUERY_STORE = OFF
GO
USE [MostriVsEroi]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MostriVsEroi]
GO
/****** Object:  Table [dbo].[Arma]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arma](
	[IDArma] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](30) NOT NULL,
	[PuntiDanno] [int] NOT NULL,
 CONSTRAINT [PK_Arma] PRIMARY KEY CLUSTERED 
(
	[IDArma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giocatore]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giocatore](
	[Username] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[IsAdmin] [nvarchar](30) NOT NULL,
	[IDGiocatore] [int] IDENTITY(1,1) NOT NULL,
	[IDEroe] [int] NOT NULL,
 CONSTRAINT [PK_Giocatore] PRIMARY KEY CLUSTERED 
(
	[IDGiocatore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eroe]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eroe](
	[IDEroe] [int] IDENTITY(1,1) NOT NULL,
	[NomeEroe] [nvarchar](30) NOT NULL,
	[Livello] [int] NOT NULL,
	[IdUtente] [int] NOT NULL,
	[IDCategoria] [int] NOT NULL,
	[IDArma] [nchar](10) NULL,
 CONSTRAINT [PK_Eroe] PRIMARY KEY CLUSTERED 
(
	[IDEroe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IDCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NomeCategoria] [nvarchar](30) NOT NULL,
	[IDTipo] [int] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IDCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_1]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT dbo.Categoria.NomeCategoria, dbo.Eroe.NomeEroe, dbo.Giocatore.Password
FROM   dbo.Eroe INNER JOIN
             dbo.Categoria ON dbo.Eroe.IDCategoria = dbo.Categoria.IDCategoria INNER JOIN
             dbo.Giocatore ON dbo.Eroe.IDEroe = dbo.Giocatore.IDEroe CROSS JOIN
             dbo.Arma
GO
/****** Object:  Table [dbo].[CategoriaMostro]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaMostro](
	[IDCategoriaMostro] [int] NOT NULL,
	[CategoriaMostro] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_CategoriaMostro] PRIMARY KEY CLUSTERED 
(
	[IDCategoriaMostro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mostro]    Script Date: 17/06/2021 20:28:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mostro](
	[IDMostro] [int] IDENTITY(1,1) NOT NULL,
	[IDCategoriaMostro] [nvarchar](30) NOT NULL,
	[IDArma] [int] NOT NULL,
	[Livello] [int] NOT NULL,
	[PuntiVita] [int] NOT NULL,
 CONSTRAINT [PK_Mostro] PRIMARY KEY CLUSTERED 
(
	[IDMostro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[22] 3[11] 2) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Categoria"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Eroe"
            Begin Extent = 
               Top = 9
               Left = 622
               Bottom = 206
               Right = 844
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Giocatore"
            Begin Extent = 
               Top = 9
               Left = 901
               Bottom = 206
               Right = 1123
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Arma"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 179
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 580
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
USE [master]
GO
ALTER DATABASE [MostriVsEroi] SET  READ_WRITE 
GO
