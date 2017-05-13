USE [GD1C2017]
GO
/****** Object:  Table [OLA_K_ASE].[Maestra_Stg1]    Script Date: 5/13/2017 2:40:50 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[OLA_K_ASE].[Maestra_Stg1]') AND type in (N'U'))
DROP TABLE [OLA_K_ASE].[Maestra_Stg1]
GO
/****** Object:  Table [OLA_K_ASE].[Maestra_Stg1]    Script Date: 5/13/2017 2:40:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[OLA_K_ASE].[Maestra_Stg1]') AND type in (N'U'))
BEGIN
CREATE TABLE [OLA_K_ASE].[Maestra_Stg1](
	[Auto_Marca] [varchar](255) NULL,
	[Auto_Modelo] [varchar](255) NULL,
	[Auto_Patente] [varchar](10) NULL,
	[Auto_Licencia] [varchar](26) NULL,
	[Auto_Rodado] [varchar](10) NULL,
	[Chofer_Nombre] [varchar](255) NULL,
	[Chofer_Apellido] [varchar](255) NULL,
	[Chofer_Dni] [numeric](18, 0) NULL,
	[Chofer_Direccion] [varchar](255) NULL,
	[Chofer_Telefono] [numeric](18, 0) NULL,
	[Chofer_Mail] [varchar](50) NULL,
	[Chofer_Fecha_Nac] [datetime] NULL,
	[Viaje_Cant_Kilometros] [numeric](18, 0) NULL,
	[Viaje_Fecha] [datetime] NULL,
	[Turno_Hora_Inicio] [numeric](18, 0) NULL,
	[Turno_Hora_Fin] [numeric](18, 0) NULL,
	[Turno_Descripcion] [varchar](255) NULL,
	[Turno_Valor_Kilometro] [numeric](18, 2) NULL,
	[Turno_Precio_Base] [numeric](18, 2) NULL,
	[Cliente_Nombre] [varchar](255) NULL,
	[Cliente_Apellido] [varchar](255) NULL,
	[Cliente_Dni] [numeric](18, 0) NULL,
	[Cliente_Telefono] [numeric](18, 0) NULL,
	[Cliente_Direccion] [varchar](255) NULL,
	[Cliente_Mail] [varchar](255) NULL,
	[Cliente_Fecha_Nac] [datetime] NULL,
	[Rendicion_Nro] [numeric](18, 0) NULL,
	[Rendicion_Fecha] [datetime] NULL,
	[Rendicion_Importe] [numeric](18, 2) NULL,
	[Factura_Fecha_Inicio] [datetime] NULL,
	[Factura_Fecha_Fin] [datetime] NULL,
	[Factura_Nro] [numeric](18, 0) NULL,
	[Factura_Fecha] [datetime] NULL,
	[MARCA_ID] [int] NULL,
	[TURNO_ID] [int] NULL,
	[CHOFER_ID] [int] NULL,
	[CLIENTE_ID] [int] NULL,
	[USUARIO_ID] [int] NULL,
	[RENDICION_ID] [int] NULL,
	[FACTURA_ID] [int] NULL,
	[VIAJE_ID] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
