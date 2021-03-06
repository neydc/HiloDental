USE [master]
GO
/****** Object:  Database [ProyDentoWeb]    Script Date: 28/10/2020 17:54:58 ******/
CREATE DATABASE [ProyDentoWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyDentoWeb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL\MSSQL\DATA\ProyDentoWeb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyDentoWeb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL\MSSQL\DATA\ProyDentoWeb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProyDentoWeb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyDentoWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyDentoWeb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyDentoWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyDentoWeb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyDentoWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyDentoWeb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyDentoWeb] SET  MULTI_USER 
GO
ALTER DATABASE [ProyDentoWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyDentoWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyDentoWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyDentoWeb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProyDentoWeb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ProyDentoWeb]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 28/10/2020 17:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[idHorario] [int] NULL,
	[estado] [varchar](10) NULL,
	[idCliente] [int] NULL,
	[idDoctor] [int] NULL,
	[monto] [decimal](8, 4) NULL,
	[idHistorial] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/10/2020 17:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NULL,
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[dni] [nvarchar](8) NULL,
	[fechaNac] [date] NULL,
	[correo] [varchar](100) NULL,
	[telefono] [varchar](20) NULL,
	[usuario] [varchar](50) NULL,
	[passwd] [varchar](200) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 28/10/2020 17:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[idDoctor] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[codigoCol] [varchar](50) NULL,
	[casaEstudio] [varchar](100) NULL,
	[titulo] [varchar](100) NULL,
	[dni] [nvarchar](8) NULL,
	[correo] [varchar](100) NULL,
	[telefono] [varchar](20) NULL,
	[usuario] [varchar](50) NULL,
	[passwd] [varchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 28/10/2020 17:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Historial](
	[idHistorial] [int] IDENTITY(1,1) NOT NULL,
	[numeroHistoria] [int] NULL,
	[observacion] [varchar](500) NULL,
	[motivo] [varchar](500) NULL,
	[fecha] [datetime] NULL,
	[edad] [int] NULL,
	[descripcion] [varchar](500) NULL,
	[examenes] [varchar](500) NULL,
	[diagnostico] [varchar](800) NULL,
	[tratamiento] [varchar](800) NULL,
	[idDoctor] [int] NULL,
	[idCliente] [int] NULL,
	[idCita] [int] NULL,
 CONSTRAINT [PK_Historial] PRIMARY KEY CLUSTERED 
(
	[idHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 28/10/2020 17:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Horario](
	[idHorario] [int] IDENTITY(1,1) NOT NULL,
	[horaInicio] [varchar](10) NULL,
	[horaFin] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 28/10/2020 17:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](50) NULL,
	[password] [nvarchar](250) NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [ProyDentoWeb] SET  READ_WRITE 
GO
