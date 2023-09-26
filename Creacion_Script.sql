USE [master]
GO
/****** Object:  Database [ordenes]    Script Date: 26/9/2023 19:59:06 ******/
CREATE DATABASE [ordenes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ordenes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ordenes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ordenes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ordenes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ordenes] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ordenes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ordenes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ordenes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ordenes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ordenes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ordenes] SET ARITHABORT OFF 
GO
ALTER DATABASE [ordenes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ordenes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ordenes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ordenes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ordenes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ordenes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ordenes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ordenes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ordenes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ordenes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ordenes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ordenes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ordenes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ordenes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ordenes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ordenes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ordenes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ordenes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ordenes] SET  MULTI_USER 
GO
ALTER DATABASE [ordenes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ordenes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ordenes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ordenes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ordenes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ordenes] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ordenes] SET QUERY_STORE = ON
GO
ALTER DATABASE [ordenes] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ordenes]
GO
/****** Object:  Table [dbo].[T_DETALLES_ORDEN]    Script Date: 26/9/2023 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_DETALLES_ORDEN](
	[nro_orden] [int] NOT NULL,
	[detalle_nro] [int] NOT NULL,
	[codigo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_orden] ASC,
	[detalle_nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_MATERIALES]    Script Date: 26/9/2023 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_MATERIALES](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[stock] [numeric](8, 2) NOT NULL,
 CONSTRAINT [PK__T_PRODUC__FF341C0D7F60ED59] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_ORDENES_RETIRO]    Script Date: 26/9/2023 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ORDENES_RETIRO](
	[nro] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[responsable] [varchar](100) NOT NULL,
 CONSTRAINT [PK__T_FACT__33BEB70E03317E3D] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_MATERIALES]    Script Date: 26/9/2023 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_MATERIALES]
AS
BEGIN
	
	SELECT * from T_MATERIALES ORDER BY 2;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLES]    Script Date: 26/9/2023 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLES] 
	@nro_orden int,
	@detalle int, 
	@codigo int, 
	@cantidad int
AS
BEGIN
	INSERT INTO T_DETALLES_ORDEN(nro_orden,detalle_nro, codigo, cantidad)
    VALUES (@nro_orden, @detalle, @codigo, @cantidad);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_ORDEN]    Script Date: 26/9/2023 19:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_ORDEN] 
	@responsable varchar(255), 
	@nro int output
AS
BEGIN
	INSERT INTO T_ORDENES_RETIRO(fecha, responsable)
    VALUES (GETDATE(), @responsable);
	SET @nro = SCOPE_IDENTITY();
END
GO
USE [master]
GO
ALTER DATABASE [ordenes] SET  READ_WRITE 
GO