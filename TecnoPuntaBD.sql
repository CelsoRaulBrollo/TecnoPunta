USE [master]
GO
/****** Object:  Database [TecnoPuntaBD]    Script Date: 12/11/2024 22:55:34 ******/
CREATE DATABASE [TecnoPuntaBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TecnoPuntaBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\TecnoPuntaBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TecnoPuntaBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\TecnoPuntaBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TecnoPuntaBD] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TecnoPuntaBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TecnoPuntaBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TecnoPuntaBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TecnoPuntaBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TecnoPuntaBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TecnoPuntaBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET RECOVERY FULL 
GO
ALTER DATABASE [TecnoPuntaBD] SET  MULTI_USER 
GO
ALTER DATABASE [TecnoPuntaBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TecnoPuntaBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TecnoPuntaBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TecnoPuntaBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TecnoPuntaBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TecnoPuntaBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TecnoPuntaBD', N'ON'
GO
ALTER DATABASE [TecnoPuntaBD] SET QUERY_STORE = ON
GO
ALTER DATABASE [TecnoPuntaBD] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TecnoPuntaBD]
GO
/****** Object:  Table [dbo].[Carrito]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito](
	[DNI_Vendedor] [int] NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_id_carrito] PRIMARY KEY CLUSTERED 
(
	[DNI_Vendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarritoDetalle]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarritoDetalle](
	[id_CarritoDetalle] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[SubTotal] [decimal](10, 2) NOT NULL,
	[DNI_Vendedor] [int] NOT NULL,
	[FechaUltimaModificacion] [datetime] NOT NULL,
	[Producto] [varchar](100) NOT NULL,
 CONSTRAINT [PK_id_CarritoDetalle] PRIMARY KEY CLUSTERED 
(
	[id_CarritoDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[DNI_Cliente] [int] NOT NULL,
	[Nombre_Cliente] [varchar](100) NOT NULL,
	[Apellido_Cliente] [varchar](100) NOT NULL,
	[Telefono_Cliente] [varchar](20) NOT NULL,
	[Correo_Cliente] [varchar](150) NOT NULL,
	[Direccion_Cliente] [varchar](150) NOT NULL,
	[Estado_Cliente] [varchar](10) NULL,
	[genero] [varchar](10) NULL,
	[fechaCreacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[DNI_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Condicion]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Condicion](
	[Id_Condicion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Estado] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Condicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[Id_Estado] [int] NOT NULL,
	[Descripcion_Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Id_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Marca] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodoDePago]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodoDePago](
	[Id_MetodoDePago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_MetodoDePago] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_MetodoDePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Modelo_Producto] [varchar](100) NOT NULL,
	[Nombre_Producto] [varchar](100) NOT NULL,
	[SistemaOperativo_Producto] [varchar](100) NOT NULL,
	[Almacenamiento_Producto] [varchar](100) NOT NULL,
	[Ram_Producto] [varchar](100) NOT NULL,
	[Stock_Producto] [int] NOT NULL,
	[Precio_Producto] [decimal](10, 2) NOT NULL,
	[Id_Marca] [int] NULL,
	[Id_Condicion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Modelo_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_Rol] [int] NOT NULL,
	[Descripcion_Rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[Id_Sexo] [int] NOT NULL,
	[Descripcion_Sexo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[Id_Sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[DNI_Usuario] [int] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[Nombre_Usuario] [varchar](100) NOT NULL,
	[Apellido_Usuario] [varchar](100) NOT NULL,
	[Correo_Usuario] [varchar](150) NOT NULL,
	[Sueldo_Usuario] [decimal](10, 2) NOT NULL,
	[Telefono_Usuario] [varchar](100) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[Sexo_Usuario] [int] NOT NULL,
	[Rol_Usuario] [int] NOT NULL,
	[Estado_Usuarios] [varchar](10) NULL,
	[fechaDeRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[DNI_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[DNI_Vendedor] [int] NOT NULL,
	[DNI_Cliente] [int] NOT NULL,
	[Id_MetodoDePago] [int] NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
 CONSTRAINT [PK_id_idVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[idVenta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[SubTotal] [decimal](10, 2) NOT NULL,
	[Producto] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Carrito] ([DNI_Vendedor], [Total]) VALUES (23445594, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Carrito] ([DNI_Vendedor], [Total]) VALUES (34567890, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Carrito] ([DNI_Vendedor], [Total]) VALUES (41008590, CAST(0.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (11223344, N'Carlos', N'López', N'555-8765', N'carlos.lopez@example.com', N'Boulevard de los Sueños 789', N'ACTIVO', N'Masculino', CAST(N'2024-01-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (12345678, N'Juan', N'Pérez', N'555-1234', N'juan.perez@example.com', N'Calle Falsa 123', N'BAJA', N'Masculino', CAST(N'2024-02-02T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (17000123, N'Sofía', N'Mendoza', N'555-2001', N'sofia.mendoza@example.com', N'Calle Nueva 1', N'BAJA', N'Femenino', CAST(N'2024-02-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (18000234, N'Diego', N'Hernández', N'555-2002', N'diego.hernandez@example.com', N'Avenida Central 2', N'ACTIVO', N'Masculino', CAST(N'2024-03-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (19000345, N'Clara', N'Sánchez', N'555-2003', N'clara.sanchez@example.com', N'Calle de la Paz 3', N'ACTIVO', N'Otro', CAST(N'2024-03-22T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (20000456, N'Javier', N'Torres', N'555-2004', N'javier.torres@example.com', N'Calle Sol 4', N'ACTIVO', N'Masculino', CAST(N'2024-03-22T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (21000567, N'Elena', N'González', N'555-2005', N'elena.gonzalez@example.com', N'Calle Luna 5', N'ACTIVO', N'Otro', CAST(N'2024-03-22T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (22000678, N'Andrés', N'Cruz', N'555-2006', N'andres.cruz@example.com', N'Boulevard 6', N'ACTIVO', N'Masculino', CAST(N'2024-04-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (23000789, N'Lucía', N'Reyes', N'555-2007', N'lucia.reyes@example.com', N'Plaza 7', N'ACTIVO', N'Otro', CAST(N'2024-04-14T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (24000890, N'Fernando', N'Martínez', N'555-2008', N'fernando.martinez@example.com', N'Avenida del Río 8', N'ACTIVO', N'Masculino', CAST(N'2024-04-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (25000901, N'Carmen', N'Salas', N'555-2009', N'carmen.salas@example.com', N'Calle del Jardín 9', N'ACTIVO', N'Otro', CAST(N'2024-05-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (26001012, N'Victor', N'Pérez', N'555-2010', N'victor.perez@example.com', N'Calle de los Sueños 10', N'ACTIVO', N'Masculino', CAST(N'2024-06-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (27001123, N'María', N'Alonso', N'555-2011', N'maria.alonso@example.com', N'Calle de la Esperanza 11', N'ACTIVO', N'Femenino', CAST(N'2024-06-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (28001234, N'Ricardo', N'López', N'555-2012', N'ricardo.lopez@example.com', N'Avenida de la Libertad 12', N'ACTIVO', N'Masculino', CAST(N'2024-06-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (29001345, N'Ana', N'Vega', N'555-2013', N'ana.vega@example.com', N'Calle de la Historia 13', N'ACTIVO', N'Femenino', CAST(N'2024-06-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (30001456, N'Pedro', N'Maldonado', N'555-2014', N'pedro.maldonado@example.com', N'Calle de la Vida 14', N'ACTIVO', N'Masculino', CAST(N'2024-07-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (31001567, N'Nicolás', N'Jiménez', N'555-2015', N'nicolas.jimenez@example.com', N'Avenida del Amor 15', N'ACTIVO', N'Femenino', CAST(N'2024-07-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (32001678, N'Teresa', N'Cordero', N'555-2016', N'teresa.cordero@example.com', N'Calle de los Recuerdos 16', N'ACTIVO', N'Femenino', CAST(N'2024-08-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (33001789, N'Roberto', N'Fernández', N'555-2017', N'roberto.fernandez@example.com', N'Calle de la Luz 17', N'ACTIVO', N'Masculino', CAST(N'2024-08-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (34001890, N'Isabel', N'García', N'555-2018', N'isabel.garcia@example.com', N'Calle del Futuro 18', N'ACTIVO', N'Femenino', CAST(N'2024-09-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (35001901, N'Laura', N'Hernández', N'555-2019', N'laura.hernandez@example.com', N'Calle del Sol 19', N'ACTIVO', N'Otro', CAST(N'2024-09-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (36002012, N'Carlos', N'Torres', N'555-2020', N'carlos.torres@example.com', N'Avenida de la Paz 20', N'ACTIVO', N'Masculino', CAST(N'2024-10-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (37002123, N'Marta', N'Sánchez', N'555-2021', N'marta.sanchez@example.com', N'Calle de la Libertad 21', N'ACTIVO', N'Otro', CAST(N'2024-10-11T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (38002234, N'Joaquín', N'Reyes', N'555-2022', N'joaquin.reyes@example.com', N'Calle Nueva 22', N'ACTIVO', N'Masculino', CAST(N'2024-10-23T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (39002345, N'Gabriela', N'Cruz', N'555-2023', N'gabriela.cruz@example.com', N'Avenida del Jardín 23', N'ACTIVO', N'Masculino', CAST(N'2024-10-27T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (40002456, N'Diego', N'Mendoza', N'555-2024', N'diego.mendoza@example.com', N'Calle de los Sueños 24', N'ACTIVO', N'Masculino', CAST(N'2024-10-30T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (41002567, N'Patricia', N'Alonso', N'555-2025', N'patricia.alonso@example.com', N'Calle del Río 25', N'ACTIVO', N'Otro', CAST(N'2024-11-01T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (41008590, N'Gabriel', N'Capay', N'3794090344', N'Capay@gmail.com', N'Calle Falsa 123', N'ACTIVO', N'Masculino', CAST(N'2024-11-02T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (42002678, N'Julio', N'Vega', N'555-2026', N'julio.vega@example.com', N'Calle de la Vida 26', N'ACTIVO', N'Masculino', CAST(N'2024-11-10T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (42733217, N'Raul Brollo', N'Brollo', N'3624274989', N'celsobrollo@gmail.com', N'Leon Zorrilla 4567', N'ACTIVO', N'Masculino', CAST(N'2024-11-10T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (43002789, N'Claudia', N'Martínez', N'555-2027', N'claudia.martinez@example.com', N'Calle del Amor 27', N'BAJA', N'Otro', CAST(N'2024-11-11T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (44002890, N'Fernando', N'Salas', N'555-2028', N'fernando.salas@example.com', N'Calle de la Esperanza 28', N'ACTIVO', N'Masculino', CAST(N'2024-11-11T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (45002901, N'Luciana', N'Pérez', N'555-2029', N'luciana.perez@example.com', N'Avenida del Futuro 29', N'ACTIVO', N'Femenino', CAST(N'2024-08-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (46003012, N'Sergio', N'Maldonado', N'555-2030', N'sergio.maldonado@example.com', N'Calle de la Luz 30', N'ACTIVO', N'Masculino', CAST(N'2024-07-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (47003123, N'Esteban', N'González', N'555-2031', N'esteban.gonzalez@example.com', N'Avenida de la Paz 31', N'ACTIVO', N'Masculino', CAST(N'2024-05-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (48003234, N'Monica', N'Cordero', N'555-2032', N'monica.cordero@example.com', N'Calle de los Recuerdos 32', N'ACTIVO', N'Femenino', CAST(N'2024-05-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (49003345, N'Raúl', N'Reyes', N'555-2033', N'raul.reyes@example.com', N'Calle de la Historia 33', N'ACTIVO', N'Masculino', CAST(N'2024-01-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (50003456, N'Patricia', N'Hernández', N'555-2034', N'patricia.hernandez@example.com', N'Calle del Jardín 34', N'ACTIVO', N'Femenino', CAST(N'2024-01-12T21:39:35.350' AS DateTime))
INSERT [dbo].[Clientes] ([DNI_Cliente], [Nombre_Cliente], [Apellido_Cliente], [Telefono_Cliente], [Correo_Cliente], [Direccion_Cliente], [Estado_Cliente], [genero], [fechaCreacion]) VALUES (87654321, N'Ana', N'Gómez', N'555-5678', N'ana.gomez@example.com', N'Avenida Siempre Viva 456', N'ACTIVO', N'Femenino', CAST(N'2024-11-12T21:39:35.350' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Condicion] ON 

INSERT [dbo].[Condicion] ([Id_Condicion], [Descripcion_Estado]) VALUES (1, N'ACTIVO')
INSERT [dbo].[Condicion] ([Id_Condicion], [Descripcion_Estado]) VALUES (2, N'BAJA')
SET IDENTITY_INSERT [dbo].[Condicion] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (1, N'Samsung')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (2, N'Apple')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (3, N'Xiaomi')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (4, N'Oppo')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (5, N'Motorola')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (6, N'Huawei')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (7, N'Realme')
INSERT [dbo].[Marcas] ([Id_Marca], [Nombre_Marca]) VALUES (8, N'Honor')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[MetodoDePago] ON 

INSERT [dbo].[MetodoDePago] ([Id_MetodoDePago], [Descripcion_MetodoDePago]) VALUES (1, N'Tarjeta De Credito')
INSERT [dbo].[MetodoDePago] ([Id_MetodoDePago], [Descripcion_MetodoDePago]) VALUES (2, N'Tarjeta De Debito')
INSERT [dbo].[MetodoDePago] ([Id_MetodoDePago], [Descripcion_MetodoDePago]) VALUES (3, N'Billetera Virtual')
INSERT [dbo].[MetodoDePago] ([Id_MetodoDePago], [Descripcion_MetodoDePago]) VALUES (4, N'Efectivo')
SET IDENTITY_INSERT [dbo].[MetodoDePago] OFF
GO
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'A2633', N'Apple iPhone 14 Pro', N'iOS', N'128GB', N'6GB', 25, CAST(1099.99 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'COR-L29', N'Honor View 20', N'Android', N'128GB', N'6GB', 22, CAST(399.99 AS Decimal(10, 2)), 8, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'COR-L29-U', N'Honor 50', N'Android', N'256GB', N'8GB', 15, CAST(499.99 AS Decimal(10, 2)), 8, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'CPH2159', N'Oppo Reno 5', N'Android', N'128GB', N'8GB', 20, CAST(299.99 AS Decimal(10, 2)), 4, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'CPH2173', N'Oppo Find X3 Pro', N'Android', N'256GB', N'12GB', 14, CAST(1149.99 AS Decimal(10, 2)), 4, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'CPH2197', N'Oppo A74', N'Android', N'128GB', N'6GB', 60, CAST(249.99 AS Decimal(10, 2)), 4, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'ELS-NX9', N'Huawei P40', N'Android', N'128GB', N'8GB', 40, CAST(499.99 AS Decimal(10, 2)), 6, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'HUAWEI P40 Lite', N'Huawei P40 Lite', N'Android', N'128GB', N'6GB', 45, CAST(299.99 AS Decimal(10, 2)), 6, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'LIO-L29', N'Huawei P50 Pro', N'Android', N'256GB', N'8GB', 20, CAST(1099.99 AS Decimal(10, 2)), 6, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'M2101K7AG', N'Xiaomi Redmi Note 10', N'Android', N'64GB', N'4GB', 100, CAST(199.99 AS Decimal(10, 2)), 3, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'M2102J20SG', N'Xiaomi Redmi Note 11', N'Android', N'128GB', N'6GB', 80, CAST(249.99 AS Decimal(10, 2)), 3, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'M2103K19G', N'Xiaomi Mi 11', N'Android', N'256GB', N'8GB', 40, CAST(749.99 AS Decimal(10, 2)), 3, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'MGH03LL/A', N'Apple iPhone 13', N'iOS', N'256GB', N'6GB', 30, CAST(999.99 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'MGH03LL/A-S', N'Apple iPhone 13 Mini', N'iOS', N'256GB', N'4GB', 20, CAST(899.99 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'MGH03LL/A-U', N'Apple iPhone 12', N'iOS', N'128GB', N'4GB', 10, CAST(699.99 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'RMX3085', N'Realme 8', N'Android', N'128GB', N'8GB', 60, CAST(199.99 AS Decimal(10, 2)), 7, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'RMX3313', N'Realme 9 Pro', N'Android', N'128GB', N'6GB', 35, CAST(299.99 AS Decimal(10, 2)), 7, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'RMX3371', N'Realme GT Master Edition', N'Android', N'128GB', N'8GB', 45, CAST(399.99 AS Decimal(10, 2)), 7, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'SM-A525F', N'Samsung Galaxy A52', N'Android', N'128GB', N'6GB', 55, CAST(349.99 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'SM-G980F-U', N'Samsung Galaxy S20', N'Android', N'128GB', N'8GB', 5, CAST(599.99 AS Decimal(10, 2)), 1, 2)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'SM-G991B', N'Samsung Galaxy S21', N'Android', N'128GB', N'8GB', 50, CAST(799.99 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'SM-G996B', N'Samsung Galaxy S21 Ultra', N'Android', N'256GB', N'12GB', 30, CAST(1199.99 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'XT2041-4', N'Motorola Moto G Power', N'Android', N'64GB', N'4GB', 75, CAST(249.99 AS Decimal(10, 2)), 5, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'XT2113-3', N'Motorola Moto G Stylus 5G', N'Android', N'128GB', N'6GB', 50, CAST(399.99 AS Decimal(10, 2)), 5, 1)
INSERT [dbo].[Productos] ([Modelo_Producto], [Nombre_Producto], [SistemaOperativo_Producto], [Almacenamiento_Producto], [Ram_Producto], [Stock_Producto], [Precio_Producto], [Id_Marca], [Id_Condicion]) VALUES (N'XT2155-1', N'Motorola Moto G60', N'Android', N'128GB', N'6GB', 70, CAST(299.99 AS Decimal(10, 2)), 5, 1)
GO
INSERT [dbo].[Roles] ([Id_Rol], [Descripcion_Rol]) VALUES (1, N'Administrador')
INSERT [dbo].[Roles] ([Id_Rol], [Descripcion_Rol]) VALUES (2, N'Gerente')
INSERT [dbo].[Roles] ([Id_Rol], [Descripcion_Rol]) VALUES (3, N'Vendedor')
GO
INSERT [dbo].[Sexo] ([Id_Sexo], [Descripcion_Sexo]) VALUES (1, N'Masculino')
INSERT [dbo].[Sexo] ([Id_Sexo], [Descripcion_Sexo]) VALUES (2, N'Femenino')
INSERT [dbo].[Sexo] ([Id_Sexo], [Descripcion_Sexo]) VALUES (3, N'Otro')
GO
INSERT [dbo].[Usuarios] ([DNI_Usuario], [Usuario], [Nombre_Usuario], [Apellido_Usuario], [Correo_Usuario], [Sueldo_Usuario], [Telefono_Usuario], [Contraseña], [Sexo_Usuario], [Rol_Usuario], [Estado_Usuarios], [fechaDeRegistro]) VALUES (23445594, N'Messi', N'Leonel', N'Messi', N'Leo10@outlook.com', CAST(30000.00 AS Decimal(10, 2)), N'3794859433', N'leoleo12', 1, 3, N'ACTIVO', CAST(N'2024-10-30T04:51:32.393' AS DateTime))
INSERT [dbo].[Usuarios] ([DNI_Usuario], [Usuario], [Nombre_Usuario], [Apellido_Usuario], [Correo_Usuario], [Sueldo_Usuario], [Telefono_Usuario], [Contraseña], [Sexo_Usuario], [Rol_Usuario], [Estado_Usuarios], [fechaDeRegistro]) VALUES (23456789, N'juanito', N'juanito', N'Pérez', N'juan.perez@example.com', CAST(3000.00 AS Decimal(10, 2)), N'555123433', N'password123', 1, 1, N'ACTIVO', CAST(N'2024-10-30T04:38:21.903' AS DateTime))
INSERT [dbo].[Usuarios] ([DNI_Usuario], [Usuario], [Nombre_Usuario], [Apellido_Usuario], [Correo_Usuario], [Sueldo_Usuario], [Telefono_Usuario], [Contraseña], [Sexo_Usuario], [Rol_Usuario], [Estado_Usuarios], [fechaDeRegistro]) VALUES (34567890, N'anita', N'Ana', N'Gómez', N'ana.gomez@example.com', CAST(2000.00 AS Decimal(10, 2)), N'5555678', N'password456', 2, 3, N'ACTIVO', CAST(N'2024-10-30T04:38:21.903' AS DateTime))
INSERT [dbo].[Usuarios] ([DNI_Usuario], [Usuario], [Nombre_Usuario], [Apellido_Usuario], [Correo_Usuario], [Sueldo_Usuario], [Telefono_Usuario], [Contraseña], [Sexo_Usuario], [Rol_Usuario], [Estado_Usuarios], [fechaDeRegistro]) VALUES (41008590, N'Capay', N'Gabriel', N'Capay', N'capay@gmail.com', CAST(233333.00 AS Decimal(10, 2)), N'3794090344', N'1234567', 1, 3, N'ACTIVO', CAST(N'2024-10-30T04:38:21.903' AS DateTime))
INSERT [dbo].[Usuarios] ([DNI_Usuario], [Usuario], [Nombre_Usuario], [Apellido_Usuario], [Correo_Usuario], [Sueldo_Usuario], [Telefono_Usuario], [Contraseña], [Sexo_Usuario], [Rol_Usuario], [Estado_Usuarios], [fechaDeRegistro]) VALUES (41008591, N'prueba', N'jsjsj', N'askldkjlasd', N'skdakasdj@gmail.com', CAST(38383.00 AS Decimal(10, 2)), N'3794090355', N'1234567', 1, 3, N'ACTIVO', CAST(N'2024-10-30T04:38:21.903' AS DateTime))
INSERT [dbo].[Usuarios] ([DNI_Usuario], [Usuario], [Nombre_Usuario], [Apellido_Usuario], [Correo_Usuario], [Sueldo_Usuario], [Telefono_Usuario], [Contraseña], [Sexo_Usuario], [Rol_Usuario], [Estado_Usuarios], [fechaDeRegistro]) VALUES (45678901, N'carlitos', N'Carlos', N'López', N'carlos.lopez@example.com', CAST(1500.00 AS Decimal(10, 2)), N'5558765', N'password789', 1, 2, N'ACTIVO', CAST(N'2024-10-30T04:38:21.903' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (4, 41008590, 44002890, 1, CAST(1199.99 AS Decimal(10, 2)), CAST(N'2024-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (5, 34567890, 19000345, 2, CAST(1099.99 AS Decimal(10, 2)), CAST(N'2024-01-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (6, 23445594, 26001012, 4, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-01-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (7, 41008590, 33001789, 4, CAST(2749.97 AS Decimal(10, 2)), CAST(N'2024-01-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (8, 34567890, 46003012, 3, CAST(649.98 AS Decimal(10, 2)), CAST(N'2024-01-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (9, 41008590, 49003345, 4, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-02-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (10, 34567890, 11223344, 4, CAST(2599.97 AS Decimal(10, 2)), CAST(N'2024-02-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (11, 41008590, 23000789, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (12, 41008590, 18000234, 3, CAST(2999.95 AS Decimal(10, 2)), CAST(N'2024-02-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (13, 34567890, 31001567, 2, CAST(899.99 AS Decimal(10, 2)), CAST(N'2024-02-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (14, 34567890, 44002890, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (15, 34567890, 19000345, 2, CAST(1099.99 AS Decimal(10, 2)), CAST(N'2024-03-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (16, 23445594, 26001012, 4, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-03-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (19, 23445594, 23000789, 1, CAST(1199.99 AS Decimal(10, 2)), CAST(N'2024-03-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (20, 34567890, 26001012, 2, CAST(1099.99 AS Decimal(10, 2)), CAST(N'2024-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (21, 23445594, 11223344, 3, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (22, 23445594, 45002901, 1, CAST(799.98 AS Decimal(10, 2)), CAST(N'2024-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (23, 41008590, 42002678, 2, CAST(899.99 AS Decimal(10, 2)), CAST(N'2024-03-23T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (24, 41008590, 33001789, 1, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-03-27T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (25, 23445594, 17000123, 1, CAST(1199.99 AS Decimal(10, 2)), CAST(N'2024-04-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (26, 34567890, 18000234, 2, CAST(1099.99 AS Decimal(10, 2)), CAST(N'2024-04-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (27, 41008590, 19000345, 3, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-04-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (28, 23445594, 20000456, 1, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-04-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (29, 34567890, 21000567, 2, CAST(899.99 AS Decimal(10, 2)), CAST(N'2024-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (30, 41008590, 22000678, 1, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-04-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (31, 23445594, 23000789, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-04-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (32, 34567890, 24000890, 2, CAST(1199.99 AS Decimal(10, 2)), CAST(N'2024-04-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (33, 41008590, 25000901, 3, CAST(1099.99 AS Decimal(10, 2)), CAST(N'2024-04-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (34, 23445594, 26001012, 1, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (35, 34567890, 27001123, 2, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-04-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (36, 41008590, 28001234, 1, CAST(199.98 AS Decimal(10, 2)), CAST(N'2024-04-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (37, 23445594, 29001345, 1, CAST(1099.99 AS Decimal(10, 2)), CAST(N'2024-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (38, 34567890, 30001456, 2, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-04-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (39, 41008590, 31001567, 3, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-04-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (40, 23445594, 32001678, 1, CAST(899.98 AS Decimal(10, 2)), CAST(N'2024-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (41, 34567890, 33001789, 2, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-04-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (42, 41008590, 34001890, 1, CAST(749.97 AS Decimal(10, 2)), CAST(N'2024-04-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (43, 23445594, 35001901, 3, CAST(749.97 AS Decimal(10, 2)), CAST(N'2024-04-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (44, 23445594, 35001901, 1, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (45, 34567890, 36002012, 2, CAST(1799.98 AS Decimal(10, 2)), CAST(N'2024-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (46, 41008590, 37002123, 3, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (47, 23445594, 38002234, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-05-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (48, 34567890, 39002345, 2, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (49, 41008590, 40002456, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-05-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (50, 23445594, 41002567, 1, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-05-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (51, 34567890, 36002012, 2, CAST(2199.98 AS Decimal(10, 2)), CAST(N'2024-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (52, 41008590, 37002123, 1, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-05-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (53, 23445594, 35001901, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-05-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (54, 34567890, 36002012, 3, CAST(899.97 AS Decimal(10, 2)), CAST(N'2024-05-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (55, 41008590, 37002123, 2, CAST(1599.98 AS Decimal(10, 2)), CAST(N'2024-05-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (56, 23445594, 38002234, 1, CAST(199.99 AS Decimal(10, 2)), CAST(N'2024-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (57, 34567890, 39002345, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-05-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (58, 41008590, 40002456, 2, CAST(999.98 AS Decimal(10, 2)), CAST(N'2024-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (59, 23445594, 41002567, 1, CAST(199.99 AS Decimal(10, 2)), CAST(N'2024-05-23T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (60, 34567890, 36002012, 2, CAST(1799.98 AS Decimal(10, 2)), CAST(N'2024-05-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (61, 41008590, 37002123, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-05-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (62, 23445594, 35001901, 2, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (63, 34567890, 36002012, 1, CAST(1299.99 AS Decimal(10, 2)), CAST(N'2024-05-27T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (64, 23445594, 35001901, 1, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (65, 34567890, 36002012, 2, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-06-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (66, 41008590, 37002123, 3, CAST(1299.99 AS Decimal(10, 2)), CAST(N'2024-06-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (67, 23445594, 38002234, 1, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-06-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (68, 34567890, 39002345, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-06-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (69, 41008590, 40002456, 2, CAST(999.98 AS Decimal(10, 2)), CAST(N'2024-06-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (70, 23445594, 41002567, 3, CAST(899.97 AS Decimal(10, 2)), CAST(N'2024-06-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (71, 34567890, 35001901, 1, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-06-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (72, 41008590, 36002012, 2, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (73, 23445594, 37002123, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (74, 34567890, 38002234, 2, CAST(1799.98 AS Decimal(10, 2)), CAST(N'2024-06-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (75, 41008590, 39002345, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (76, 23445594, 40002456, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-06-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (77, 34567890, 41002567, 2, CAST(999.98 AS Decimal(10, 2)), CAST(N'2024-06-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (78, 41008590, 35001901, 1, CAST(199.99 AS Decimal(10, 2)), CAST(N'2024-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (79, 23445594, 36002012, 2, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-06-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (80, 34567890, 37002123, 1, CAST(599.99 AS Decimal(10, 2)), CAST(N'2024-06-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (81, 41008590, 38002234, 1, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-06-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (82, 23445594, 39002345, 2, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-06-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (83, 34567890, 40002456, 1, CAST(1299.99 AS Decimal(10, 2)), CAST(N'2024-06-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (84, 23445594, 35001901, 1, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-07-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (85, 34567890, 36002012, 2, CAST(749.97 AS Decimal(10, 2)), CAST(N'2024-07-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (86, 41008590, 37002123, 3, CAST(1149.99 AS Decimal(10, 2)), CAST(N'2024-07-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (87, 23445594, 38002234, 1, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-07-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (88, 34567890, 39002345, 2, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-07-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (89, 41008590, 40002456, 2, CAST(599.98 AS Decimal(10, 2)), CAST(N'2024-07-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (90, 23445594, 41002567, 1, CAST(1299.99 AS Decimal(10, 2)), CAST(N'2024-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (91, 34567890, 35001901, 2, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-07-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (92, 41008590, 36002012, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-07-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (93, 23445594, 37002123, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-07-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (94, 34567890, 38002234, 3, CAST(899.97 AS Decimal(10, 2)), CAST(N'2024-07-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (95, 41008590, 39002345, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-07-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (96, 23445594, 40002456, 2, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-07-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (97, 34567890, 41002567, 1, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-07-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (98, 41008590, 35001901, 2, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-07-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (99, 23445594, 36002012, 1, CAST(199.99 AS Decimal(10, 2)), CAST(N'2024-07-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (100, 34567890, 37002123, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-07-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (101, 41008590, 38002234, 2, CAST(599.98 AS Decimal(10, 2)), CAST(N'2024-07-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (102, 23445594, 39002345, 1, CAST(1299.99 AS Decimal(10, 2)), CAST(N'2024-07-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (103, 34567890, 40002456, 2, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-07-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (104, 23445594, 35001901, 4, CAST(1399.99 AS Decimal(10, 2)), CAST(N'2024-08-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (105, 34567890, 36002012, 2, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-08-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (106, 41008590, 37002123, 3, CAST(1149.99 AS Decimal(10, 2)), CAST(N'2024-08-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (107, 23445594, 38002234, 1, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (108, 34567890, 39002345, 4, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-08-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (109, 41008590, 40002456, 4, CAST(1299.99 AS Decimal(10, 2)), CAST(N'2024-08-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (110, 23445594, 41002567, 4, CAST(299.98 AS Decimal(10, 2)), CAST(N'2024-08-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (111, 34567890, 35001901, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-08-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (112, 23445594, 35001901, 1, CAST(799.99 AS Decimal(10, 2)), CAST(N'2024-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (113, 34567890, 36002012, 2, CAST(1199.98 AS Decimal(10, 2)), CAST(N'2024-09-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (114, 41008590, 37002123, 3, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-09-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (115, 23445594, 38002234, 1, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-09-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (116, 34567890, 39002345, 2, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-09-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (117, 41008590, 40002456, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-09-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (118, 23445594, 41002567, 3, CAST(1799.97 AS Decimal(10, 2)), CAST(N'2024-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (119, 34567890, 35001901, 1, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-09-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (120, 23445594, 35001901, 1, CAST(499.98 AS Decimal(10, 2)), CAST(N'2024-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (121, 34567890, 36002012, 2, CAST(1149.99 AS Decimal(10, 2)), CAST(N'2024-09-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (122, 41008590, 37002123, 3, CAST(899.97 AS Decimal(10, 2)), CAST(N'2024-09-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (123, 23445594, 38002234, 1, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-09-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (124, 34567890, 39002345, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-09-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (125, 41008590, 40002456, 2, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-09-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (126, 23445594, 41002567, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-09-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (127, 34567890, 35001901, 1, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-09-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (128, 23445594, 35001901, 1, CAST(799.98 AS Decimal(10, 2)), CAST(N'2024-10-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (129, 34567890, 36002012, 2, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-10-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (130, 41008590, 37002123, 3, CAST(1049.97 AS Decimal(10, 2)), CAST(N'2024-10-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (131, 23445594, 38002234, 2, CAST(599.98 AS Decimal(10, 2)), CAST(N'2024-10-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (132, 34567890, 39002345, 4, CAST(349.99 AS Decimal(10, 2)), CAST(N'2024-10-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (133, 41008590, 40002456, 4, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-10-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (134, 23445594, 41002567, 4, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-10-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (135, 34567890, 35001901, 2, CAST(699.98 AS Decimal(10, 2)), CAST(N'2024-10-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (136, 41008590, 36002012, 2, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-10-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (137, 23445594, 37002123, 2, CAST(199.98 AS Decimal(10, 2)), CAST(N'2024-10-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (138, 34567890, 38002234, 1, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-10-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (139, 41008590, 39002345, 3, CAST(899.97 AS Decimal(10, 2)), CAST(N'2024-10-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (140, 23445594, 40002456, 4, CAST(299.99 AS Decimal(10, 2)), CAST(N'2024-10-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (141, 34567890, 41002567, 4, CAST(1399.98 AS Decimal(10, 2)), CAST(N'2024-10-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (142, 41008590, 35001901, 1, CAST(499.99 AS Decimal(10, 2)), CAST(N'2024-10-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (143, 23445594, 36002012, 1, CAST(999.99 AS Decimal(10, 2)), CAST(N'2024-10-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (144, 34567890, 37002123, 2, CAST(799.98 AS Decimal(10, 2)), CAST(N'2024-10-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (145, 41008590, 38002234, 1, CAST(249.99 AS Decimal(10, 2)), CAST(N'2024-10-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (146, 23445594, 39002345, 4, CAST(899.97 AS Decimal(10, 2)), CAST(N'2024-10-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (147, 34567890, 40002456, 4, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (148, 41008590, 41002567, 3, CAST(599.98 AS Decimal(10, 2)), CAST(N'2024-10-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (150, 41008590, 12345678, 4, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-10-30T07:16:12.967' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (151, 41008590, 11223344, 4, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-10-30T10:16:06.883' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (152, 41008590, 41008590, 2, CAST(399.99 AS Decimal(10, 2)), CAST(N'2024-11-01T11:06:15.900' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [DNI_Vendedor], [DNI_Cliente], [Id_MetodoDePago], [Total], [FechaVenta]) VALUES (153, 34567890, 41008590, 4, CAST(1149.99 AS Decimal(10, 2)), CAST(N'2024-11-08T09:53:23.593' AS DateTime))
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (4, 1, CAST(1199.99 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (5, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (6, 1, CAST(249.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (7, 1, CAST(1199.99 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (7, 1, CAST(899.99 AS Decimal(10, 2)), N'MGH03LL/A-S')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (7, 1, CAST(649.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (8, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (8, 1, CAST(299.99 AS Decimal(10, 2)), N'XT2155-1')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (9, 1, CAST(999.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (9, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (10, 2, CAST(799.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (10, 1, CAST(999.99 AS Decimal(10, 2)), N'LIO-L29')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (11, 1, CAST(299.99 AS Decimal(10, 2)), N'XT2113-3')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (12, 1, CAST(1199.99 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (12, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (12, 1, CAST(699.97 AS Decimal(10, 2)), N'MGH03LL/A-U')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (12, 1, CAST(899.99 AS Decimal(10, 2)), N'MGH03LL/A-S')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (14, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (15, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (16, 1, CAST(749.99 AS Decimal(10, 2)), N'M2103K19G')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (16, 1, CAST(299.99 AS Decimal(10, 2)), N'CPH2159')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (19, 1, CAST(1199.99 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (20, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (21, 1, CAST(249.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (22, 2, CAST(399.98 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (23, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (24, 1, CAST(899.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (25, 1, CAST(1199.99 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (26, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (27, 1, CAST(249.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (28, 2, CAST(399.98 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (28, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (29, 1, CAST(899.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (30, 1, CAST(499.99 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (31, 1, CAST(249.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (32, 1, CAST(1199.99 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (33, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (34, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (35, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (36, 2, CAST(199.98 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (37, 1, CAST(1099.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (38, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (39, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (40, 2, CAST(899.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (41, 1, CAST(399.99 AS Decimal(10, 2)), N'COR-L29')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (42, 3, CAST(749.97 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (43, 1, CAST(749.97 AS Decimal(10, 2)), N'SM-G996B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (44, 2, CAST(499.98 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (45, 2, CAST(1799.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (46, 1, CAST(499.99 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (47, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (48, 2, CAST(699.98 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (49, 1, CAST(299.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (50, 1, CAST(499.99 AS Decimal(10, 2)), N'HUAWEI P40 Lite')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (51, 2, CAST(2199.98 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (52, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (53, 1, CAST(999.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (54, 3, CAST(899.97 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (55, 2, CAST(1599.98 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (56, 1, CAST(199.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (57, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (58, 2, CAST(999.98 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (59, 1, CAST(199.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (60, 2, CAST(1799.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (61, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (62, 2, CAST(499.98 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (63, 1, CAST(1299.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (64, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (65, 2, CAST(499.98 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (66, 1, CAST(1299.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (67, 1, CAST(499.99 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (68, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (69, 2, CAST(999.98 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (70, 3, CAST(899.97 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (71, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (72, 2, CAST(699.98 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (73, 1, CAST(999.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (74, 2, CAST(1799.98 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (75, 1, CAST(299.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (76, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (77, 2, CAST(999.98 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (78, 1, CAST(199.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (79, 2, CAST(499.98 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (80, 1, CAST(599.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (81, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (82, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (83, 1, CAST(1299.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (84, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (85, 3, CAST(749.97 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (86, 1, CAST(1149.99 AS Decimal(10, 2)), N'CPH2173')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (87, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (88, 2, CAST(699.98 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (89, 2, CAST(599.98 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (90, 1, CAST(1299.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (91, 2, CAST(499.98 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (92, 1, CAST(299.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (93, 1, CAST(999.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (94, 3, CAST(899.97 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (95, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (96, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
GO
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (97, 1, CAST(499.99 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (98, 2, CAST(699.98 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (99, 1, CAST(199.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (100, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (101, 2, CAST(599.98 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (102, 1, CAST(1299.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (103, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (104, 1, CAST(1399.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (105, 2, CAST(499.98 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (106, 1, CAST(1149.99 AS Decimal(10, 2)), N'CPH2173')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (107, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (108, 2, CAST(699.98 AS Decimal(10, 2)), N'ELS-NX9')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (109, 1, CAST(1299.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (110, 2, CAST(299.98 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (111, 1, CAST(999.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (112, 1, CAST(799.99 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (113, 2, CAST(1199.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (114, 1, CAST(299.99 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (115, 1, CAST(399.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (116, 2, CAST(699.98 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (117, 1, CAST(999.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (118, 3, CAST(1799.97 AS Decimal(10, 2)), N'CPH2197')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (119, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (120, 2, CAST(499.98 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (121, 1, CAST(1149.99 AS Decimal(10, 2)), N'CPH2173')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (122, 3, CAST(899.97 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (123, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (124, 1, CAST(299.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (125, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (126, 1, CAST(999.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (127, 1, CAST(399.99 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (128, 2, CAST(799.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (129, 1, CAST(399.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (130, 3, CAST(1049.97 AS Decimal(10, 2)), N'CPH2173')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (131, 2, CAST(599.98 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (132, 1, CAST(349.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (133, 1, CAST(999.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (134, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (135, 2, CAST(699.98 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (136, 1, CAST(399.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (137, 2, CAST(199.98 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (138, 1, CAST(299.99 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (139, 3, CAST(899.97 AS Decimal(10, 2)), N'CPH2197')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (140, 1, CAST(299.99 AS Decimal(10, 2)), N'M2102J20SG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (141, 2, CAST(1399.98 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (142, 1, CAST(499.99 AS Decimal(10, 2)), N'SM-A525F')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (143, 1, CAST(999.99 AS Decimal(10, 2)), N'A2633')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (144, 2, CAST(799.98 AS Decimal(10, 2)), N'SM-G991B')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (145, 1, CAST(249.99 AS Decimal(10, 2)), N'RMX3313')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (146, 3, CAST(899.97 AS Decimal(10, 2)), N'XT2041-4')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (147, 1, CAST(399.99 AS Decimal(10, 2)), N'MGH03LL/A')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (148, 2, CAST(599.98 AS Decimal(10, 2)), N'M2101K7AG')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (150, 1, CAST(399.99 AS Decimal(10, 2)), N'COR-L29')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (151, 1, CAST(399.99 AS Decimal(10, 2)), N'COR-L29')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (152, 1, CAST(399.99 AS Decimal(10, 2)), N'COR-L29')
INSERT [dbo].[VentaDetalle] ([idVenta], [Cantidad], [SubTotal], [Producto]) VALUES (153, 1, CAST(1149.99 AS Decimal(10, 2)), N'CPH2173')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Cliente_Correo]    Script Date: 12/11/2024 22:55:35 ******/
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [UQ_Cliente_Correo] UNIQUE NONCLUSTERED 
(
	[Correo_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Usuario_Email]    Script Date: 12/11/2024 22:55:35 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [UQ_Usuario_Email] UNIQUE NONCLUSTERED 
(
	[Correo_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Usuario_Name]    Script Date: 12/11/2024 22:55:35 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [UQ_Usuario_Name] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CarritoDetalle] ADD  DEFAULT (getdate()) FOR [FechaUltimaModificacion]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Estado_Cliente]  DEFAULT ('ACTIVO') FOR [Estado_Cliente]
GO
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Estado_Usuarios]  DEFAULT ('ACTIVO') FOR [Estado_Usuarios]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [fechaDeRegistro]
GO
ALTER TABLE [dbo].[Venta] ADD  CONSTRAINT [DF_FechaVenta]  DEFAULT (getdate()) FOR [FechaVenta]
GO
ALTER TABLE [dbo].[Carrito]  WITH CHECK ADD  CONSTRAINT [FK_DNI_Vendedor] FOREIGN KEY([DNI_Vendedor])
REFERENCES [dbo].[Usuarios] ([DNI_Usuario])
GO
ALTER TABLE [dbo].[Carrito] CHECK CONSTRAINT [FK_DNI_Vendedor]
GO
ALTER TABLE [dbo].[CarritoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_DNI_id_carrito] FOREIGN KEY([DNI_Vendedor])
REFERENCES [dbo].[Carrito] ([DNI_Vendedor])
GO
ALTER TABLE [dbo].[CarritoDetalle] CHECK CONSTRAINT [FK_DNI_id_carrito]
GO
ALTER TABLE [dbo].[CarritoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_Producto] FOREIGN KEY([Producto])
REFERENCES [dbo].[Productos] ([Modelo_Producto])
GO
ALTER TABLE [dbo].[CarritoDetalle] CHECK CONSTRAINT [FK_Producto]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Condicion] FOREIGN KEY([Id_Condicion])
REFERENCES [dbo].[Condicion] ([Id_Condicion])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Condicion]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Marca] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[Marcas] ([Id_Marca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Marca]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Rol] FOREIGN KEY([Rol_Usuario])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Rol]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Sexo] FOREIGN KEY([Sexo_Usuario])
REFERENCES [dbo].[Sexo] ([Id_Sexo])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Sexo]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_DNI_DNI_Cliente] FOREIGN KEY([DNI_Cliente])
REFERENCES [dbo].[Clientes] ([DNI_Cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_DNI_DNI_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_DNI_Vendedorr] FOREIGN KEY([DNI_Vendedor])
REFERENCES [dbo].[Usuarios] ([DNI_Usuario])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_DNI_Vendedorr]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Id_MetodoDePago] FOREIGN KEY([Id_MetodoDePago])
REFERENCES [dbo].[MetodoDePago] ([Id_MetodoDePago])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Id_MetodoDePago]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_idVenta] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_idVenta]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_Productoo] FOREIGN KEY([Producto])
REFERENCES [dbo].[Productos] ([Modelo_Producto])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_Productoo]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CHK_Genero] CHECK  (([genero]='Otro' OR [genero]='Femenino' OR [genero]='Masculino'))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CHK_Genero]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CK_Estado] CHECK  (([Estado_Cliente]='ACTIVO' OR [Estado_Cliente]='BAJA'))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CK_Estado]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD CHECK  (([Stock_Producto]>=(0)))
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CK_EstadoUsuarios] CHECK  (([Estado_Usuarios]='ACTIVO' OR [Estado_Usuarios]='BAJA'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CK_EstadoUsuarios]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarStockSiExcede10Minutos]    Script Date: 12/11/2024 22:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarStockSiExcede10Minutos]
AS
BEGIN
    -- Actualizar el stock en Productos y eliminar los registros de CarritoDetalle
    UPDATE p
    SET Stock_Producto = Stock_Producto + cd.Cantidad
    FROM Productos p
    JOIN CarritoDetalle cd ON p.Modelo_Producto = cd.Producto
    WHERE DATEDIFF(MINUTE, cd.FechaUltimaModificacion, GETDATE()) > 1;

    DELETE FROM CarritoDetalle
    WHERE DATEDIFF(MINUTE, FechaUltimaModificacion, GETDATE()) > 1;
END;
GO
USE [master]
GO
ALTER DATABASE [TecnoPuntaBD] SET  READ_WRITE 
GO
