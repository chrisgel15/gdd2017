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
select * into [OLA_K_ASE].[Maestra_Stg1] from [gd_esquema].[Maestra]

alter table [OLA_K_ASE].[Maestra_Stg1] add [MARCA_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [TURNO_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [CHOFER_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [CLIENTE_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [USUARIO_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [RENDICION_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [FACTURA_ID] [int] NULL
alter table [OLA_K_ASE].[Maestra_Stg1] add [VIAJE_ID] [int] NULL


END
GO
SET ANSI_PADDING OFF
GO
