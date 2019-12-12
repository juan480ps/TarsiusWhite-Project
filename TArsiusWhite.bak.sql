USE [master]
GO
/****** Object:  Database [TarsiusWhite]    Script Date: 12/12/2019 11:37:14 a. m. ******/
CREATE DATABASE [TarsiusWhite]
GO
ALTER DATABASE [TarsiusWhite] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TarsiusWhite].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TarsiusWhite] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TarsiusWhite] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TarsiusWhite] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TarsiusWhite] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TarsiusWhite] SET ARITHABORT OFF 
GO
ALTER DATABASE [TarsiusWhite] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TarsiusWhite] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TarsiusWhite] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TarsiusWhite] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TarsiusWhite] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TarsiusWhite] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TarsiusWhite] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TarsiusWhite] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TarsiusWhite] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TarsiusWhite] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TarsiusWhite] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TarsiusWhite] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TarsiusWhite] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TarsiusWhite] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TarsiusWhite] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TarsiusWhite] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TarsiusWhite] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TarsiusWhite] SET RECOVERY FULL 
GO
ALTER DATABASE [TarsiusWhite] SET  MULTI_USER 
GO
ALTER DATABASE [TarsiusWhite] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TarsiusWhite] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TarsiusWhite] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TarsiusWhite] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TarsiusWhite] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TarsiusWhite] SET QUERY_STORE = OFF
GO
USE [TarsiusWhite]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[IdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Categoria] [int] NULL,
	[Presentacion] [int] NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](50) NULL,
	[DescripcionCategoria] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Sexo] [int] NULL,
	[FechaNacimiento] [date] NULL,
	[TipoDocumento] [int] NULL,
	[NroDocumento] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[Cantidad] [int] NULL,
	[Categoria] [int] NULL,
	[PrecioVenta] [money] NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Sexo] [char](1) NULL,
	[FechaNacimiento] [date] NULL,
	[NroDocumento] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Acceso] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingreso](
	[IdIngreso] [int] IDENTITY(1,1) NOT NULL,
	[FechaIngreso] [date] NULL,
	[TipoComprobante] [char](10) NULL,
	[Serie] [varchar](50) NULL,
	[Correlativo] [int] NULL,
	[Igv] [nchar](10) NULL,
	[Estado] [char](10) NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[IdIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presentacion]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentacion](
	[IdPresentacion] [int] IDENTITY(1,1) NOT NULL,
	[NombrePresentacion] [varchar](50) NULL,
	[DescripcionPresentacion] [varchar](50) NULL,
 CONSTRAINT [PK_Presentacion] PRIMARY KEY CLUSTERED 
(
	[IdPresentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [varchar](50) NULL,
	[SectorComercial] [varchar](50) NULL,
	[TipoDocumento] [varchar](50) NULL,
	[NroDocumento] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/12/2019 11:37:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaPedido] [nchar](10) NULL,
	[Cliente] [nchar](10) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [TarsiusWhite] SET  READ_WRITE 
GO
