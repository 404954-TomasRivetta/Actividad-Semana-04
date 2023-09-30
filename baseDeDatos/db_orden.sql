--create database db_ordenes
--USE [db_ordenes]
GO
/****** Object:  Table [dbo].[T_ORDENES_RETIRO]    Script Date: 12/19/2022 09:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_ORDENES_RETIRO](
	[nro] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[responsable] [varchar](100) NOT NULL,
 CONSTRAINT [PK__T_FACT__33BEB70E03317E3D] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_ORDENES_RETIRO] ON
INSERT [dbo].[T_ORDENES_RETIRO] ([nro], [fecha], [responsable]) VALUES (1, CAST(0xCB440B00 AS Date), N'Juan')
SET IDENTITY_INSERT [dbo].[T_ORDENES_RETIRO] OFF
/****** Object:  Table [dbo].[T_MATERIALES]    Script Date: 12/19/2022 09:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_MATERIALES](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[stock] [numeric](8, 2) NOT NULL,
 CONSTRAINT [PK__T_PRODUC__FF341C0D7F60ED59] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_MATERIALES] ON
INSERT [dbo].[T_MATERIALES] ([codigo], [nombre], [stock]) VALUES (1, N'Producto A', CAST(999.00 AS Numeric(8, 2)))
INSERT [dbo].[T_MATERIALES] ([codigo], [nombre], [stock]) VALUES (2, N'Producto B', CAST(111.00 AS Numeric(8, 2)))
SET IDENTITY_INSERT [dbo].[T_MATERIALES] OFF
/****** Object:  Table [dbo].[T_DETALLES_ORDEN]    Script Date: 12/19/2022 09:13:13 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[T_DETALLES_ORDEN] ([nro_orden], [detalle_nro], [codigo], [cantidad]) VALUES (1, 1, 1, 10)
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_ORDEN]    Script Date: 12/19/2022 09:13:12 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLES]    Script Date: 12/19/2022 09:13:12 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_MATERIALES]    Script Date: 12/19/2022 09:13:12 ******/
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

