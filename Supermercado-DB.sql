USE [master]
GO
/****** Object:  Database [Supermercado-LUG]    Script Date: 16/9/2023 19:02:40 ******/
CREATE DATABASE [Supermercado-LUG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Supermercado-LUG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Supermercado-LUG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Supermercado-LUG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Supermercado-LUG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Supermercado-LUG] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Supermercado-LUG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ARITHABORT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Supermercado-LUG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Supermercado-LUG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Supermercado-LUG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET RECOVERY FULL 
GO
ALTER DATABASE [Supermercado-LUG] SET  MULTI_USER 
GO
ALTER DATABASE [Supermercado-LUG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Supermercado-LUG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Supermercado-LUG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Supermercado-LUG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Supermercado-LUG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Supermercado-LUG', N'ON'
GO
ALTER DATABASE [Supermercado-LUG] SET QUERY_STORE = ON
GO
ALTER DATABASE [Supermercado-LUG] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Supermercado-LUG]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
	[id_medio_de_pago] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[nro_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cant_producto] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[nro_venta] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedioDePago]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedioDePago](
	[id_cliente] [int] NOT NULL,
	[id] [int] NOT NULL,
	[id_tipo_tarjeta] [int] NOT NULL,
	[nro_tarjeta] [int] NOT NULL,
	[fecha_caducidad] [datetime] NOT NULL,
	[cvv] [int] NOT NULL,
 CONSTRAINT [PK_MedioDePago] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](150) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[id] [int] NOT NULL,
	[nombre_sucursal] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](150) NULL,
	[direccion] [nvarchar](100) NOT NULL,
	[localidad] [nvarchar](50) NOT NULL,
	[provincia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarjeta]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarjeta](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoTarjeta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[nro_venta] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[total] [money] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[nro_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TipoTarjeta] ([id], [nombre]) VALUES (1, N'MasterCard')
INSERT [dbo].[TipoTarjeta] ([id], [nombre]) VALUES (2, N'Visa')
INSERT [dbo].[TipoTarjeta] ([id], [nombre]) VALUES (3, N'American Express')
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Producto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([nro_venta])
REFERENCES [dbo].[Venta] ([nro_venta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[MedioDePago]  WITH CHECK ADD  CONSTRAINT [FK_MedioDePago_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[MedioDePago] CHECK CONSTRAINT [FK_MedioDePago_Cliente]
GO
ALTER TABLE [dbo].[MedioDePago]  WITH CHECK ADD  CONSTRAINT [FK_MedioDePago_TipoTarjeta] FOREIGN KEY([id_tipo_tarjeta])
REFERENCES [dbo].[TipoTarjeta] ([id])
GO
ALTER TABLE [dbo].[MedioDePago] CHECK CONSTRAINT [FK_MedioDePago_TipoTarjeta]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Sucursal] FOREIGN KEY([id_sucursal])
REFERENCES [dbo].[Sucursal] ([id])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Sucursal]
GO
/****** Object:  StoredProcedure [dbo].[insert_producto]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_producto]
(
	@In_nombre nvarchar(50),
	@In_descripcion nvarchar(150),
	@In_id_categoria int,
	@In_precio money,
	@In_stock int
)
AS 
BEGIN

	DECLARE @last_id int;
	SET @last_id = (SELECT COALESCE(MAX(id), 0) + 1 FROM Producto)
	INSERT INTO Producto (id, nombre, descripcion, id_categoria, precio, stock)
	VALUES (@last_id, @In_nombre, @In_descripcion, @In_id_categoria, @In_precio, @In_stock)

END
GO
/****** Object:  StoredProcedure [dbo].[select_productos]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[select_productos]
(
	@In_id int = NULL
)
AS 
BEGIN
	SELECT * FROM Producto WHERE id = @In_id OR @In_id IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[select_tipos_tarjetas]    Script Date: 16/9/2023 19:02:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[select_tipos_tarjetas]

AS 
BEGIN
	SELECT * FROM TipoTarjeta
END
GO
USE [master]
GO
ALTER DATABASE [Supermercado-LUG] SET  READ_WRITE 
GO
