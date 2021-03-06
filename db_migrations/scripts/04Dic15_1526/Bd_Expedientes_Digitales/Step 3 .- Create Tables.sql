/*
	Pasos para crear las tablas
	1.- Iniciar sesión con el usuario DIGITALDOCS
	2.- Ejecutar scripts
*/

USE [Bd_Expedientes_Digitales]
GO
/****** Object:  Table [dbo].[ca_acciones]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_acciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_acciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_acciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_acciones]') AND name = N'IX_ca_acciones')
CREATE NONCLUSTERED INDEX [IX_ca_acciones] ON [dbo].[ca_acciones] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_origenes]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_origenes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_origenes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_origenes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_origenes]') AND name = N'IX_ca_origenes')
CREATE NONCLUSTERED INDEX [IX_ca_origenes] ON [dbo].[ca_origenes] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_clasificaciontramites]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_clasificaciontramites]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_clasificaciontramites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ca_clasificaciontramites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_clasificaciontramites]') AND name = N'IX_ca_clasificaciontramites')
CREATE NONCLUSTERED INDEX [IX_ca_clasificaciontramites] ON [dbo].[ca_clasificaciontramites] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_modulos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_modulos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_modulos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Modulo] [varchar](50) NOT NULL,
	[id_menu] [int] NULL,
	[id_submenu] [int] NULL,
 CONSTRAINT [PK_ca_modulos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_modulos]') AND name = N'IX_ca_modulos')
CREATE NONCLUSTERED INDEX [IX_ca_modulos] ON [dbo].[ca_modulos] 
(
	[Modulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_campostrazables]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_campostrazables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_campostrazables](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Tamanio_Caracteres] [int] NOT NULL,
	[Mascara] [varchar](200) NULL,
	[Mask] [varchar](200) NULL,
 CONSTRAINT [PK_ca_campostrazables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_campostrazables]') AND name = N'IX_ca_campostrazables')
CREATE NONCLUSTERED INDEX [IX_ca_campostrazables] ON [dbo].[ca_campostrazables] 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_clasificaciondocumentos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_clasificaciondocumentos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_clasificaciondocumentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ca_clasificaciondocumentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_clasificaciondocumentos]') AND name = N'IX_ca_clasificaciondocumentos')
CREATE NONCLUSTERED INDEX [IX_ca_clasificaciondocumentos] ON [dbo].[ca_clasificaciondocumentos] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_formatos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_formatos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_formatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_formatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_formatos]') AND name = N'IX_ca_formatos')
CREATE NONCLUSTERED INDEX [IX_ca_formatos] ON [dbo].[ca_formatos] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_roles]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_roles]') AND name = N'IX_ca_roles')
CREATE NONCLUSTERED INDEX [IX_ca_roles] ON [dbo].[ca_roles] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_expedientes]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_expedientes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_expedientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ma_expediente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_expedientes]') AND name = N'IX_ca_expedientes')
CREATE NONCLUSTERED INDEX [IX_ca_expedientes] ON [dbo].[ca_expedientes] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_estatus]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_estatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_estatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_estatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_estatus]') AND name = N'IX_ca_estatus')
CREATE NONCLUSTERED INDEX [IX_ca_estatus] ON [dbo].[ca_estatus] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_tiposbloqueos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_tiposbloqueos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_tiposbloqueos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ca_tiposbloqueos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_tiposbloqueos]') AND name = N'IX_ca_tiposbloqueos')
CREATE NONCLUSTERED INDEX [IX_ca_tiposbloqueos] ON [dbo].[ca_tiposbloqueos] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_tablas]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_tablas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_tablas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_ca_tablas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_tablas]') AND name = N'IX_ca_tablas')
CREATE NONCLUSTERED INDEX [IX_ca_tablas] ON [dbo].[ca_tablas] 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_configuraciones]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_configuraciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_configuraciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Valor] [varchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_configuraciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[tbl_configuraciones]') AND name = N'IX_tbl_configuraciones')
CREATE NONCLUSTERED INDEX [IX_tbl_configuraciones] ON [dbo].[tbl_configuraciones] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_cargo_puesto]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_cargo_puesto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_cargo_puesto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ca_cargo_puesto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_cargo_puesto]') AND name = N'IX_ca_cargo_puesto')
CREATE NONCLUSTERED INDEX [IX_ca_cargo_puesto] ON [dbo].[ca_cargo_puesto] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_errorlogs]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_errorlogs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_errorlogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fechahora] [datetime] NOT NULL,
	[code] [varchar](50) NOT NULL,
	[message] [text] NOT NULL,
	[trace] [text] NOT NULL,
	[host] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
 CONSTRAINT [PK_tbl_errorlogs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[tbl_errorlogs]') AND name = N'IX_tbl_errorlogs')
CREATE NONCLUSTERED INDEX [IX_tbl_errorlogs] ON [dbo].[tbl_errorlogs] 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[tbl_errorlogs]') AND name = N'IX_tbl_errorlogs_1')
CREATE NONCLUSTERED INDEX [IX_tbl_errorlogs_1] ON [dbo].[tbl_errorlogs] 
(
	[fechahora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tbl_errorlogs', N'COLUMN',N'id_usuario'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es usuario que pertenece a ca_usuarios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_errorlogs', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
/****** Object:  Table [dbo].[de_acciones_modulo]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[de_acciones_modulo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[de_acciones_modulo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_re_roles_modulos] [int] NOT NULL,
	[id_acccion] [int] NOT NULL,
 CONSTRAINT [PK_de_acciones_modulo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_acciones_modulo]') AND name = N'IX_de_acciones_modulo')
CREATE NONCLUSTERED INDEX [IX_de_acciones_modulo] ON [dbo].[de_acciones_modulo] 
(
	[id_acccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_acciones_modulo]') AND name = N'IX_de_acciones_modulo_1')
CREATE NONCLUSTERED INDEX [IX_de_acciones_modulo_1] ON [dbo].[de_acciones_modulo] 
(
	[id_re_roles_modulos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hco_cambios]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hco_cambios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hco_cambios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tabla] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_accion] [int] NULL,
	[id_registro] [int] NULL,
	[valores] [text] NULL,
	[valores_anteriores] [text] NULL,
 CONSTRAINT [PK_hco_cambios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[hco_cambios]') AND name = N'IX_hco_cambios')
CREATE NONCLUSTERED INDEX [IX_hco_cambios] ON [dbo].[hco_cambios] 
(
	[id_tabla] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[hco_cambios]') AND name = N'IX_hco_cambios_1')
CREATE NONCLUSTERED INDEX [IX_hco_cambios_1] ON [dbo].[hco_cambios] 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[hco_cambios]') AND name = N'IX_hco_cambios_2')
CREATE NONCLUSTERED INDEX [IX_hco_cambios_2] ON [dbo].[hco_cambios] 
(
	[fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[hco_cambios]') AND name = N'IX_hco_cambios_3')
CREATE NONCLUSTERED INDEX [IX_hco_cambios_3] ON [dbo].[hco_cambios] 
(
	[id_accion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[hco_cambios]') AND name = N'IX_hco_cambios_4')
CREATE NONCLUSTERED INDEX [IX_hco_cambios_4] ON [dbo].[hco_cambios] 
(
	[id_registro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_documentos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_documentos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_documentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[id_Formato] [int] NOT NULL,
	[No_Hojas] [smallint] NOT NULL,
	[No_Caras] [smallint] NOT NULL,
	[Estado] [smallint] NOT NULL,
	[Resguardo] [bit] NOT NULL,
	[Tiempo_Resguardo] [smallint] NULL,
	[Trazabilidad] [bit] NOT NULL,
	[Tamanio_Caracteres_Trazables] [smallint] NULL,
	[Mascara_Trazable] [varchar](200) NULL,
	[Politica] [varchar](max) NULL,
	[Mask] [varchar](200) NULL,
 CONSTRAINT [PK_ca_Documentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_documentos]') AND name = N'IX_ca_documentos')
CREATE NONCLUSTERED INDEX [IX_ca_documentos] ON [dbo].[ca_documentos] 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_documentos]') AND name = N'IX_ca_documentos_1')
CREATE NONCLUSTERED INDEX [IX_ca_documentos_1] ON [dbo].[ca_documentos] 
(
	[id_Formato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_documentos]') AND name = N'IX_ca_documentos_2')
CREATE NONCLUSTERED INDEX [IX_ca_documentos_2] ON [dbo].[ca_documentos] 
(
	[Resguardo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_documentos]') AND name = N'IX_ca_documentos_3')
CREATE NONCLUSTERED INDEX [IX_ca_documentos_3] ON [dbo].[ca_documentos] 
(
	[Trazabilidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'ca_documentos', N'COLUMN',N'Estado'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = Original, 2 = Copia' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Estado'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'ca_documentos', N'COLUMN',N'Resguardo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = SI, 0 = NO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Resguardo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'ca_documentos', N'COLUMN',N'Tiempo_Resguardo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'En meses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Tiempo_Resguardo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'ca_documentos', N'COLUMN',N'Trazabilidad'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = NO, 1 = SI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Trazabilidad'
GO
/****** Object:  Table [dbo].[re_clasificaciondocumentos_documentos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_clasificaciondocumentos_documentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_clasificaciondocumento] [int] NOT NULL,
	[id_documento] [int] NOT NULL,
	[id_estatus] [int] NOT NULL,
	[id_origen] [int] NULL,
	[orden] [smallint] NOT NULL,
	[obligatorio] [bit] NOT NULL,
 CONSTRAINT [PK_re_clasificaciondocumentos_documentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND name = N'IX_re_clasificaciondocumentos_documentos')
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_clasificaciondocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND name = N'IX_re_clasificaciondocumentos_documentos_1')
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_1] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND name = N'IX_re_clasificaciondocumentos_documentos_2')
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_2] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND name = N'IX_re_clasificaciondocumentos_documentos_3')
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_3] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_origen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND name = N'IX_re_clasificaciondocumentos_documentos_4')
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_4] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[orden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]') AND name = N'IX_re_clasificaciondocumentos_documentos_5')
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_5] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[obligatorio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N're_clasificaciondocumentos_documentos', N'COLUMN',N'id_estatus'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N're_clasificaciondocumentos_documentos', @level2type=N'COLUMN',@level2name=N'id_estatus'
GO
/****** Object:  Table [dbo].[ca_tramites]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_tramites]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_tramites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Descripcion_Breve] [varchar](200) NULL,
	[Alcance_Inicial] [varchar](max) NULL,
	[Alcance_Final] [varchar](max) NULL,
	[id_ClasificacionTramite] [int] NOT NULL,
	[id_estatus] [int] NOT NULL,
 CONSTRAINT [PK_ca_tramites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_tramites]') AND name = N'IX_ca_tramites')
CREATE NONCLUSTERED INDEX [IX_ca_tramites] ON [dbo].[ca_tramites] 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_tramites]') AND name = N'IX_ca_tramites_1')
CREATE NONCLUSTERED INDEX [IX_ca_tramites_1] ON [dbo].[ca_tramites] 
(
	[id_ClasificacionTramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_tramites]') AND name = N'IX_ca_tramites_2')
CREATE NONCLUSTERED INDEX [IX_ca_tramites_2] ON [dbo].[ca_tramites] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'ca_tramites', N'COLUMN',N'id_estatus'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_tramites', @level2type=N'COLUMN',@level2name=N'id_estatus'
GO
/****** Object:  Table [dbo].[re_roles_modulos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_roles_modulos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_modulo] [int] NOT NULL,
 CONSTRAINT [PK_re_roles_modulos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]') AND name = N'IX_re_roles_modulos')
CREATE NONCLUSTERED INDEX [IX_re_roles_modulos] ON [dbo].[re_roles_modulos] 
(
	[id_modulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]') AND name = N'IX_re_roles_modulos_1')
CREATE NONCLUSTERED INDEX [IX_re_roles_modulos_1] ON [dbo].[re_roles_modulos] 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_expedientes_campostrazables]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_expedientes_campostrazables](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_expediente] [int] NOT NULL,
	[id_campotrazable] [int] NOT NULL,
	[es_principal] [bit] NOT NULL,
	[id_estatus] [int] NOT NULL,
 CONSTRAINT [PK_re_expedientes_campostrazables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]') AND name = N'IX_re_expedientes_campostrazables')
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables] ON [dbo].[re_expedientes_campostrazables] 
(
	[id_expediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]') AND name = N'IX_re_expedientes_campostrazables_1')
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables_1] ON [dbo].[re_expedientes_campostrazables] 
(
	[id_campotrazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]') AND name = N'IX_re_expedientes_campostrazables_2')
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables_2] ON [dbo].[re_expedientes_campostrazables] 
(
	[es_principal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]') AND name = N'IX_re_expedientes_campostrazables_3')
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables_3] ON [dbo].[re_expedientes_campostrazables] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_tramites_clasificaciondocumentos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_tramites_clasificaciondocumentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tramie] [int] NOT NULL,
	[id_clasificaciondocumento] [int] NOT NULL,
 CONSTRAINT [PK_re_tramites_clasificaciondocumentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]') AND name = N'IX_re_tramites_clasificaciondocumentos')
CREATE NONCLUSTERED INDEX [IX_re_tramites_clasificaciondocumentos] ON [dbo].[re_tramites_clasificaciondocumentos] 
(
	[id_clasificaciondocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]') AND name = N'IX_re_tramites_clasificaciondocumentos_1')
CREATE NONCLUSTERED INDEX [IX_re_tramites_clasificaciondocumentos_1] ON [dbo].[re_tramites_clasificaciondocumentos] 
(
	[id_tramie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_usuarios]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ca_usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ca_usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
	[CURP] [varchar](18) NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[id_cargo] [int] NULL,
 CONSTRAINT [PK_ca_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_usuarios]') AND name = N'IX_ca_usuarios')
CREATE NONCLUSTERED INDEX [IX_ca_usuarios] ON [dbo].[ca_usuarios] 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_usuarios]') AND name = N'IX_ca_usuarios_1')
CREATE NONCLUSTERED INDEX [IX_ca_usuarios_1] ON [dbo].[ca_usuarios] 
(
	[CURP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_usuarios]') AND name = N'IX_ca_usuarios_2')
CREATE NONCLUSTERED INDEX [IX_ca_usuarios_2] ON [dbo].[ca_usuarios] 
(
	[Nombres] ASC,
	[Apellido1] ASC,
	[Apellido2] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ca_usuarios]') AND name = N'IX_ca_usuarios_3')
CREATE NONCLUSTERED INDEX [IX_ca_usuarios_3] ON [dbo].[ca_usuarios] 
(
	[id_cargo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_usuarios_roles_permisos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_usuarios_roles_permisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
 CONSTRAINT [PK_re_usuarios_roles_permisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]') AND name = N'IX_re_usuarios_roles_permisos')
CREATE NONCLUSTERED INDEX [IX_re_usuarios_roles_permisos] ON [dbo].[re_usuarios_roles_permisos] 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]') AND name = N'IX_re_usuarios_roles_permisos_1')
CREATE NONCLUSTERED INDEX [IX_re_usuarios_roles_permisos_1] ON [dbo].[re_usuarios_roles_permisos] 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_expedientes_tramites]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_expedientes_tramites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_expediente] [int] NOT NULL,
	[id_tramite] [int] NOT NULL,
 CONSTRAINT [PK_re_expedientes_tramites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]') AND name = N'IX_re_expedientes_tramites')
CREATE NONCLUSTERED INDEX [IX_re_expedientes_tramites] ON [dbo].[re_expedientes_tramites] 
(
	[id_expediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]') AND name = N'IX_re_expedientes_tramites_1')
CREATE NONCLUSTERED INDEX [IX_re_expedientes_tramites_1] ON [dbo].[re_expedientes_tramites] 
(
	[id_tramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ma_digital]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ma_digital]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ma_digital](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_re_expediente_tramite] [int] NOT NULL,
	[fecha_hora_creacion] [datetime] NOT NULL,
	[nota] [text] NULL,
	[fecha_hora_bloqueo] [datetime] NULL,
	[id_estatus] [int] NOT NULL,
 CONSTRAINT [PK_de_expedientedocumentodigital] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ma_digital]') AND name = N'IX_ma_digital')
CREATE NONCLUSTERED INDEX [IX_ma_digital] ON [dbo].[ma_digital] 
(
	[id_re_expediente_tramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ma_digital]') AND name = N'IX_ma_digital_1')
CREATE NONCLUSTERED INDEX [IX_ma_digital_1] ON [dbo].[ma_digital] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ma_digital]') AND name = N'IX_ma_digital_2')
CREATE NONCLUSTERED INDEX [IX_ma_digital_2] ON [dbo].[ma_digital] 
(
	[fecha_hora_bloqueo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ma_digital]') AND name = N'IX_ma_digital_3')
CREATE NONCLUSTERED INDEX [IX_ma_digital_3] ON [dbo].[ma_digital] 
(
	[fecha_hora_creacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[de_digital]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[de_digital]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[de_digital](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ma_digital] [int] NOT NULL,
	[thumbnail] [image] NOT NULL,
	[id_re_clasificaciondocumento_documento] [int] NOT NULL,
	[imagen] [image] NOT NULL,
	[fecha_hora_creacion] [datetime] NOT NULL,
	[valor_trazable] [varchar](200) NULL,
	[id_estatus] [int] NOT NULL,
 CONSTRAINT [PK_de_digital] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital]') AND name = N'IX_de_digital')
CREATE NONCLUSTERED INDEX [IX_de_digital] ON [dbo].[de_digital] 
(
	[id_ma_digital] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital]') AND name = N'IX_de_digital_1')
CREATE NONCLUSTERED INDEX [IX_de_digital_1] ON [dbo].[de_digital] 
(
	[id_re_clasificaciondocumento_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital]') AND name = N'IX_de_digital_2')
CREATE NONCLUSTERED INDEX [IX_de_digital_2] ON [dbo].[de_digital] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital]') AND name = N'IX_de_digital_3')
CREATE NONCLUSTERED INDEX [IX_de_digital_3] ON [dbo].[de_digital] 
(
	[fecha_hora_creacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital]') AND name = N'IX_de_digital_4')
CREATE NONCLUSTERED INDEX [IX_de_digital_4] ON [dbo].[de_digital] 
(
	[valor_trazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[de_digital_campostrazables]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[de_digital_campostrazables](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ma_digital] [int] NOT NULL,
	[id_re_expediente_campotrazable] [int] NOT NULL,
	[valor_trazable] [varchar](200) NOT NULL,
	[fecha_hora_creacion] [datetime] NOT NULL,
	[id_estatus] [int] NULL,
 CONSTRAINT [PK_de_expedientestrazable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]') AND name = N'IX_de_digital_campostrazables')
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables] ON [dbo].[de_digital_campostrazables] 
(
	[id_ma_digital] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]') AND name = N'IX_de_digital_campostrazables_1')
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_1] ON [dbo].[de_digital_campostrazables] 
(
	[id_re_expediente_campotrazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]') AND name = N'IX_de_digital_campostrazables_2')
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_2] ON [dbo].[de_digital_campostrazables] 
(
	[valor_trazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]') AND name = N'IX_de_digital_campostrazables_3')
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_3] ON [dbo].[de_digital_campostrazables] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]') AND name = N'IX_de_digital_campostrazables_4')
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_4] ON [dbo].[de_digital_campostrazables] 
(
	[fecha_hora_creacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_expedientestramites_tiposbloqueos]    Script Date: 01/22/2014 10:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[re_expedientestramites_tiposbloqueos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_re_expediente_tramite] [int] NOT NULL,
	[id_tipobloqueo] [int] NULL,
	[no_horas] [smallint] NULL,
	[no_dias] [smallint] NULL,
 CONSTRAINT [PK_re_expedientestramites_tiposbloqueos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]') AND name = N'IX_re_expedientestramites_tiposbloqueos')
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[id_re_expediente_tramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]') AND name = N'IX_re_expedientestramites_tiposbloqueos_1')
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos_1] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[id_tipobloqueo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]') AND name = N'IX_re_expedientestramites_tiposbloqueos_2')
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos_2] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[no_dias] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]') AND name = N'IX_re_expedientestramites_tiposbloqueos_3')
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos_3] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[no_horas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Trigger [TR_CA_ACCIONES_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_ACCIONES_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 12 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_ACCIONES_UPDATE] ON [dbo].[ca_acciones]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 2
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_CA_ACCIONES_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_ACCIONES_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 12 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_ACCIONES_INSERT] ON [dbo].[ca_acciones]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 2
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_CA_ACCIONES_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_ACCIONES_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 12 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_ACCIONES_DELETE] ON [dbo].[ca_acciones]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 2
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_origenes_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_origenes_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_origenes_UPDATE] ON [dbo].[ca_origenes]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 11
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_origenes_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_origenes_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_origenes_DELETE] ON [dbo].[ca_origenes]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 11
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_origenes_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_origenes_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_origenes_INSERT] ON [dbo].[ca_origenes]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 11
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_clasificaciontramites_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_clasificaciontramites_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_clasificaciontramites_UPDATE] ON [dbo].[ca_clasificaciontramites]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 5
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_clasificaciontramites_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_clasificaciontramites_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_clasificaciontramites_INSERT] ON [dbo].[ca_clasificaciontramites]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 5
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_clasificaciontramites_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_clasificaciontramites_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_clasificaciontramites_DELETE] ON [dbo].[ca_clasificaciontramites]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 5
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_modulos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_modulos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_modulos_INSERT] ON [dbo].[ca_modulos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 10
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''MODULO~'' + Modulo + ''|'' + 
					''ID_MENU~'' + CAST(id_menu AS varchar(MAX))  + ''|'' + 
					''ID_SUBMENU~'' + CAST(id_submenu AS varchar(MAX))
	FROM INSERTED			
	
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);
END
'
GO
/****** Object:  Trigger [TR_ca_modulos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_modulos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_modulos_UPDATE] ON [dbo].[ca_modulos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 10
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''MODULO~'' + Modulo + ''|'' + 
					''ID_MENU~'' + CAST(id_menu AS varchar(MAX))  + ''|'' + 
					''ID_SUBMENU~'' + CAST(id_submenu AS varchar(MAX))
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''MODULO~'' + Modulo + ''|'' + 
					''ID_MENU~'' + CAST(id_menu AS varchar(MAX))  + ''|'' + 
					''ID_SUBMENU~'' + CAST(id_submenu AS varchar(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_modulos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_modulos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_modulos_DELETE] ON [dbo].[ca_modulos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 10
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''MODULO~'' + Modulo + ''|'' + 
					''ID_MENU~'' + CAST(id_menu AS varchar(MAX))  + ''|'' + 
					''ID_SUBMENU~'' + CAST(id_submenu AS varchar(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_CA_CAMPOSTRAZABLES_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_CAMPOSTRAZABLES_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_CAMPOSTRAZABLES_INSERT] ON [dbo].[ca_campostrazables]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 3
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''TAMANIO_CARACTERES~'' + CAST(Tamanio_Caracteres AS varchar(MAX))  + ''|'' + 
					''MASCARA~'' + Mascara
	FROM INSERTED			
	
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);
END
'
GO
/****** Object:  Trigger [TR_CA_CAMPOSTRAZABLES_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_CAMPOSTRAZABLES_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_CAMPOSTRAZABLES_DELETE] ON [dbo].[ca_campostrazables]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 3
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''TAMANIO_CARACTERES~'' + CAST(Tamanio_Caracteres AS varchar(MAX))  + ''|'' + 
					''MASCARA~'' + Mascara
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_CA_CAMPOSTRAZABLES_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_CAMPOSTRAZABLES_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_CAMPOSTRAZABLES_UPDATE] ON [dbo].[ca_campostrazables]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 3
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''TAMANIO_CARACTERES~'' + CAST(Tamanio_Caracteres AS varchar(MAX))  + ''|'' + 
					''MASCARA~'' + Mascara
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''NOMBRE~'' + Nombre + ''|'' + 
								''TAMANIO_CARACTERES~'' + CAST(Tamanio_Caracteres AS varchar(MAX))  + ''|'' + 
								''MASCARA~'' + Mascara
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_clasificaciondocumentos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_clasificaciondocumentos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_clasificaciondocumentos_UPDATE] ON [dbo].[ca_clasificaciondocumentos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 4
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_clasificaciondocumentos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_clasificaciondocumentos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_clasificaciondocumentos_INSERT] ON [dbo].[ca_clasificaciondocumentos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 4
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_clasificaciondocumentos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_clasificaciondocumentos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_clasificaciondocumentos_DELETE] ON [dbo].[ca_clasificaciondocumentos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 4
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_formatos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_formatos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_formatos_INSERT] ON [dbo].[ca_formatos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 9
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_formatos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_formatos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_formatos_DELETE] ON [dbo].[ca_formatos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 9
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_formatos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_formatos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_formatos_UPDATE] ON [dbo].[ca_formatos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 9
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_roles_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_roles_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_roles_DELETE] ON [dbo].[ca_roles]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 12
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_roles_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_roles_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_roles_INSERT] ON [dbo].[ca_roles]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 12
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_roles_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_roles_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_roles_UPDATE] ON [dbo].[ca_roles]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 12
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_expedientes_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_expedientes_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_expedientes_UPDATE] ON [dbo].[ca_expedientes]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 8
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_expedientes_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_expedientes_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_expedientes_DELETE] ON [dbo].[ca_expedientes]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 8
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_expedientes_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_expedientes_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_expedientes_INSERT] ON [dbo].[ca_expedientes]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 8
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_estatus_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_estatus_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_estatus_UPDATE] ON [dbo].[ca_estatus]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 7
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_estatus_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_estatus_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_estatus_DELETE] ON [dbo].[ca_estatus]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 7
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_estatus_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_estatus_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_estatus_INSERT] ON [dbo].[ca_estatus]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 7
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_tiposbloqueos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tiposbloqueos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tiposbloqueos_UPDATE] ON [dbo].[ca_tiposbloqueos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 14
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_tiposbloqueos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tiposbloqueos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tiposbloqueos_DELETE] ON [dbo].[ca_tiposbloqueos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 14
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_tiposbloqueos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tiposbloqueos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tiposbloqueos_INSERT] ON [dbo].[ca_tiposbloqueos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 14
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_tablas_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tablas_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tablas_INSERT] ON [dbo].[ca_tablas]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 13
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + nombre + ''|'' + 
					''DESCRIPCION~'' + descripcion
	FROM INSERTED			
	
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);
END
'
GO
/****** Object:  Trigger [TR_ca_tablas_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tablas_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tablas_UPDATE] ON [dbo].[ca_tablas]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 13
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + nombre + ''|'' + 
					''DESCRIPCION~'' + descripcion
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''NOMBRE~'' + nombre + ''|'' + 
					''DESCRIPCION~'' + descripcion
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_tablas_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tablas_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tablas_DELETE] ON [dbo].[ca_tablas]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 13
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + nombre + ''|'' + 
					''DESCRIPCION~'' + descripcion
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_usuarios_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_usuarios_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_usuarios_UPDATE] ON [dbo].[ca_usuarios]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 16
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''USUARIO~'' + USUARIO + ''|'' +
					''CURP~'' + CURP + ''|'' +
					''NOMBRES~'' + NOMBRES + ''|'' +
					''APELLIDO1~'' + APELLIDO1 + ''|'' +
					''APELLIDO2~'' + APELLIDO2 + ''|'' +
					''ID_CARGO~'' + CAST (id_cargo AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''USUARIO~'' + USUARIO + ''|'' +
					''CURP~'' + CURP + ''|'' +
					''NOMBRES~'' + NOMBRES + ''|'' +
					''APELLIDO1~'' + APELLIDO1 + ''|'' +
					''APELLIDO2~'' + APELLIDO2 + ''|'' +
					''ID_CARGO~'' + CAST (id_cargo AS VARCHAR(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_usuarios_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_usuarios_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_usuarios_DELETE] ON [dbo].[ca_usuarios]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 16
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''USUARIO~'' + USUARIO + ''|'' +
					''CURP~'' + CURP + ''|'' +
					''NOMBRES~'' + NOMBRES + ''|'' +
					''APELLIDO1~'' + APELLIDO1 + ''|'' +
					''APELLIDO2~'' + APELLIDO2 + ''|'' +
					''ID_CARGO~'' + CAST (id_cargo AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_CA_USUARIOS_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_USUARIOS_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 12 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_USUARIOS_INSERT] ON [dbo].[ca_usuarios]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 16
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''USUARIO~'' + USUARIO + ''|'' +
					''CURP~'' + CURP + ''|'' +
					''NOMBRES~'' + NOMBRES + ''|'' +
					''APELLIDO1~'' + APELLIDO1 + ''|'' +
					''APELLIDO2~'' + APELLIDO2 + ''|'' +
					''ID_CARGO~'' + CAST (id_cargo AS VARCHAR(MAX))
	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_de_acciones_modulo_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_acciones_modulo_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_acciones_modulo_DELETE] ON [dbo].[de_acciones_modulo]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 17
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_RE_ROLES_MODULOS~'' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + ''|'' +
					''ID_ACCCION~'' + CAST (id_acccion AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_de_acciones_modulo_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_acciones_modulo_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_acciones_modulo_INSERT] ON [dbo].[de_acciones_modulo]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 17
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_RE_ROLES_MODULOS~'' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + ''|'' +
					''ID_ACCCION~'' + CAST (id_acccion AS VARCHAR(MAX))
	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_de_acciones_modulo_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_acciones_modulo_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_acciones_modulo_UPDATE] ON [dbo].[de_acciones_modulo]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 17
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_RE_ROLES_MODULOS~'' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + ''|'' +
					''ID_ACCCION~'' + CAST (id_acccion AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_RE_ROLES_MODULOS~'' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + ''|'' +
					''ID_ACCCION~'' + CAST (id_acccion AS VARCHAR(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_de_digital_campostrazables_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_digital_campostrazables_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_digital_campostrazables_UPDATE] ON [dbo].[de_digital_campostrazables]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 19
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_EXPEDIENTE_CAMPOTRAZABLE~'' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))	
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_EXPEDIENTE_CAMPOTRAZABLE~'' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))	
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_de_digital_campostrazables_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_digital_campostrazables_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
create TRIGGER [dbo].[TR_de_digital_campostrazables_INSERT] ON [dbo].[de_digital_campostrazables]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 19
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_EXPEDIENTE_CAMPOTRAZABLE~'' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_de_digital_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_digital_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_digital_DELETE] ON [dbo].[de_digital]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 17
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~'' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_de_digital_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_digital_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_digital_INSERT] ON [dbo].[de_digital]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 18
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~'' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_de_digital_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_digital_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_digital_UPDATE] ON [dbo].[de_digital]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 18
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~'' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))	
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~'' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))	
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_de_digital_campostrazables_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_de_digital_campostrazables_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_digital_campostrazables_DELETE] ON [dbo].[de_digital_campostrazables]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 19
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_MA_DIGITAL~'' + CAST (id_ma_digital AS VARCHAR(MAX)) + ''|'' +
					''ID_RE_EXPEDIENTE_CAMPOTRAZABLE~'' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''VALOR_TRAZABLE~'' + valor_trazable + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ma_digital_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ma_digital_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ma_digital_UPDATE] ON [dbo].[ma_digital]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 21
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_BLOQUEO~'' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_BLOQUEO~'' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))	
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ma_digital_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ma_digital_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ma_digital_DELETE] ON [dbo].[ma_digital]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 21
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_BLOQUEO~'' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_clasificaciondocumentos_documentos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_clasificaciondocumentos_documentos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_clasificaciondocumentos_documentos_INSERT] ON [dbo].[re_clasificaciondocumentos_documentos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 22
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + ''|'' +
					''ID_DOCUMENTO~'' + CAST (id_documento AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX)) + ''|'' +
					''ID_ORIGEN~'' + CAST (id_origen AS VARCHAR(MAX)) + ''|'' +
					''ORDEN~'' + CAST (orden AS VARCHAR(MAX)) + ''|'' +
					''OBLIGATORIO~'' + CAST (obligatorio AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ma_digital_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ma_digital_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ma_digital_INSERT] ON [dbo].[ma_digital]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 21
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_CREACION~'' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + ''|'' +
					''FECHA_HORA_BLOQUEO~'' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_documentos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_documentos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_documentos_DELETE] ON [dbo].[ca_documentos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 6
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''ID_FORMATO~'' + CAST(id_Formato AS varchar(MAX))  + ''|'' + 
					''NO_HOJAS~'' + CAST(No_Hojas AS varchar(MAX))  + ''|'' + 
					''NO_CARAS~'' + CAST(No_Caras AS varchar(MAX))  + ''|'' + 
					''ESTADO~'' + CAST(Estado AS varchar(MAX))  + ''|'' + 
					''RESGUARDO~'' + CAST(Resguardo AS varchar(MAX))  + ''|'' + 
					''TIEMPO_RESGUARDO~'' + CAST(Tiempo_Resguardo AS varchar(MAX))  + ''|'' + 
					''TRAZABILIDAD~'' + CAST(Trazabilidad AS varchar(MAX))  + ''|'' + 
					''TAMANIO_CARACTERES_TRAZABLES~'' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + ''|'' + 
					''MASCARA_TRAZABLE~'' + Mascara_Trazable +''|'' + 
					''POLITICA~'' + Politica
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_documentos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_documentos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_documentos_INSERT] ON [dbo].[ca_documentos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 6
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''ID_FORMATO~'' + CAST(id_Formato AS varchar(MAX))  + ''|'' + 
					''NO_HOJAS~'' + CAST(No_Hojas AS varchar(MAX))  + ''|'' + 
					''NO_CARAS~'' + CAST(No_Caras AS varchar(MAX))  + ''|'' + 
					''ESTADO~'' + CAST(Estado AS varchar(MAX))  + ''|'' + 
					''RESGUARDO~'' + CAST(Resguardo AS varchar(MAX))  + ''|'' + 
					''TIEMPO_RESGUARDO~'' + CAST(Tiempo_Resguardo AS varchar(MAX))  + ''|'' + 
					''TRAZABILIDAD~'' + CAST(Trazabilidad AS varchar(MAX))  + ''|'' + 
					''TAMANIO_CARACTERES_TRAZABLES~'' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + ''|'' + 
					''MASCARA_TRAZABLE~'' + Mascara_Trazable +''|'' + 
					''POLITICA~'' + Politica
	FROM INSERTED			
	
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);
END
'
GO
/****** Object:  Trigger [TR_ca_documentos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_documentos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_documentos_UPDATE] ON [dbo].[ca_documentos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 6
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''ID_FORMATO~'' + CAST(id_Formato AS varchar(MAX))  + ''|'' + 
					''NO_HOJAS~'' + CAST(No_Hojas AS varchar(MAX))  + ''|'' + 
					''NO_CARAS~'' + CAST(No_Caras AS varchar(MAX))  + ''|'' + 
					''ESTADO~'' + CAST(Estado AS varchar(MAX))  + ''|'' + 
					''RESGUARDO~'' + CAST(Resguardo AS varchar(MAX))  + ''|'' + 
					''TIEMPO_RESGUARDO~'' + CAST(Tiempo_Resguardo AS varchar(MAX))  + ''|'' + 
					''TRAZABILIDAD~'' + CAST(Trazabilidad AS varchar(MAX))  + ''|'' + 
					''TAMANIO_CARACTERES_TRAZABLES~'' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + ''|'' + 
					''MASCARA_TRAZABLE~'' + Mascara_Trazable +''|'' + 
					''POLITICA~'' + Politica
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''ID_FORMATO~'' + CAST(id_Formato AS varchar(MAX))  + ''|'' + 
					''NO_HOJAS~'' + CAST(No_Hojas AS varchar(MAX))  + ''|'' + 
					''NO_CARAS~'' + CAST(No_Caras AS varchar(MAX))  + ''|'' + 
					''ESTADO~'' + CAST(Estado AS varchar(MAX))  + ''|'' + 
					''RESGUARDO~'' + CAST(Resguardo AS varchar(MAX))  + ''|'' + 
					''TIEMPO_RESGUARDO~'' + CAST(Tiempo_Resguardo AS varchar(MAX))  + ''|'' + 
					''TRAZABILIDAD~'' + CAST(Trazabilidad AS varchar(MAX))  + ''|'' + 
					''TAMANIO_CARACTERES_TRAZABLES~'' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + ''|'' + 
					''MASCARA_TRAZABLE~'' + Mascara_Trazable +''|'' + 
					''POLITICA~'' + Politica
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_usuarios_roles_permisos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_usuarios_roles_permisos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_usuarios_roles_permisos_DELETE] ON [dbo].[re_usuarios_roles_permisos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 28
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_USUARIO~'' + CAST (id_usuario AS VARCHAR(MAX)) + ''|'' +
					''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_usuarios_roles_permisos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_usuarios_roles_permisos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_usuarios_roles_permisos_UPDATE] ON [dbo].[re_usuarios_roles_permisos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 28
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_USUARIO~'' + CAST (id_usuario AS VARCHAR(MAX)) + ''|'' +
					''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_USUARIO~'' + CAST (id_usuario AS VARCHAR(MAX)) + ''|'' +
					''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_tramites_clasificaciondocumentos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_tramites_clasificaciondocumentos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_tramites_clasificaciondocumentos_DELETE] ON [dbo].[re_tramites_clasificaciondocumentos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 27
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_TRAMIE~'' + CAST (id_tramie AS VARCHAR(MAX)) + ''|'' +
					''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_tramites_clasificaciondocumentos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_tramites_clasificaciondocumentos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_tramites_clasificaciondocumentos_INSERT] ON [dbo].[re_tramites_clasificaciondocumentos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 27
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_TRAMIE~'' + CAST (id_tramie AS VARCHAR(MAX)) + ''|'' +
					''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_re_usuarios_roles_permisos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_usuarios_roles_permisos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_usuarios_roles_permisos_INSERT] ON [dbo].[re_usuarios_roles_permisos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 28
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_USUARIO~'' + CAST (id_usuario AS VARCHAR(MAX)) + ''|'' +
					''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_re_tramites_clasificaciondocumentos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_tramites_clasificaciondocumentos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_tramites_clasificaciondocumentos_UPDATE] ON [dbo].[re_tramites_clasificaciondocumentos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 27
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_TRAMIE~'' + CAST (id_tramie AS VARCHAR(MAX)) + ''|'' +
					''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_TRAMIE~'' + CAST (id_tramie AS VARCHAR(MAX)) + ''|'' +
					''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_tbl_configuraciones_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_tbl_configuraciones_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_tbl_configuraciones_DELETE] ON [dbo].[tbl_configuraciones]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 29
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''DESCRIPCION~'' + Descripcion + ''|'' +
					''VALOR~'' + Valor
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_tbl_configuraciones_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_tbl_configuraciones_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_tbl_configuraciones_INSERT] ON [dbo].[tbl_configuraciones]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 29
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''DESCRIPCION~'' + Descripcion + ''|'' +
					''VALOR~'' + Valor

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_tbl_configuraciones_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_tbl_configuraciones_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_tbl_configuraciones_UPDATE] ON [dbo].[tbl_configuraciones]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 29
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''DESCRIPCION~'' + Descripcion + ''|'' +
					''VALOR~'' + Valor
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''DESCRIPCION~'' + Descripcion + ''|'' +
					''VALOR~'' + Valor
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_CA_CARGO_PUESTO_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_CARGO_PUESTO_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_CARGO_PUESTO_INSERT] ON [dbo].[ca_cargo_puesto]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 30
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_CA_CARGO_PUESTO_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_CARGO_PUESTO_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_CARGO_PUESTO_DELETE] ON [dbo].[ca_cargo_puesto]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 30
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED					
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_CA_CARGO_PUESTO_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_CA_CARGO_PUESTO_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 19 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_CA_CARGO_PUESTO_UPDATE] ON [dbo].[ca_cargo_puesto]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 30
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = ''DESCRIPCION~'' + DESCRIPCION
	FROM DELETED
		
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);

END
'
GO
/****** Object:  Trigger [TR_re_roles_modulos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_roles_modulos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_roles_modulos_INSERT] ON [dbo].[re_roles_modulos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 26
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX)) + ''|'' +
					''ID_MODULO~'' + CAST (id_modulo AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_re_expedientestramites_tiposbloqueos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientestramites_tiposbloqueos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientestramites_tiposbloqueos_UPDATE] ON [dbo].[re_expedientestramites_tiposbloqueos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 25
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''ID_TIPOBLOQUEO~'' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + ''|'' +
					''NO_HORAS~'' + CAST (no_horas AS VARCHAR(MAX)) + ''|'' +
					''NO_DIAS~'' + CAST (no_dias AS VARCHAR(MAX))		
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''ID_TIPOBLOQUEO~'' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + ''|'' +
					''NO_HORAS~'' + CAST (no_horas AS VARCHAR(MAX)) + ''|'' +
					''NO_DIAS~'' + CAST (no_dias AS VARCHAR(MAX))		
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientestramites_tiposbloqueos_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientestramites_tiposbloqueos_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientestramites_tiposbloqueos_INSERT] ON [dbo].[re_expedientestramites_tiposbloqueos]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 25
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''ID_TIPOBLOQUEO~'' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + ''|'' +
					''NO_HORAS~'' + CAST (no_horas AS VARCHAR(MAX)) + ''|'' +
					''NO_DIAS~'' + CAST (no_dias AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_ca_tramites_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tramites_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tramites_UPDATE] ON [dbo].[ca_tramites]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 13
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''DESCRIPCION~'' + Descripcion + ''|'' + 
					''DESCRIPCION_BREVE~'' + Descripcion_Breve + ''|'' + 
					''ALCANCE_INICIAL~'' + Alcance_Inicial + ''|'' + 
					''ALCANCE_FINAL~'' + Alcance_Final + ''|'' + 
					''ID_CLASIFICACIONTRAMITE~'' + CAST(id_ClasificacionTramite AS varchar(MAX))  + ''|'' + 
					''ID_ESTATUS~'' + CAST(id_estatus AS varchar(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''DESCRIPCION~'' + Descripcion + ''|'' + 
					''DESCRIPCION_BREVE~'' + Descripcion_Breve + ''|'' + 
					''ALCANCE_INICIAL~'' + Alcance_Inicial + ''|'' + 
					''ALCANCE_FINAL~'' + Alcance_Final + ''|'' + 
					''ID_CLASIFICACIONTRAMITE~'' + CAST(id_ClasificacionTramite AS varchar(MAX))  + ''|'' + 
					''ID_ESTATUS~'' + CAST(id_estatus AS varchar(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientes_tramites_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientes_tramites_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientes_tramites_DELETE] ON [dbo].[re_expedientes_tramites]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 24
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_TRAMITE~'' + CAST (id_tramite AS VARCHAR(MAX))		
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientes_tramites_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientes_tramites_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientes_tramites_UPDATE] ON [dbo].[re_expedientes_tramites]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 24
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_TRAMITE~'' + CAST (id_tramite AS VARCHAR(MAX))		
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_TRAMITE~'' + CAST (id_tramite AS VARCHAR(MAX))		
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientes_tramites_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientes_tramites_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientes_tramites_INSERT] ON [dbo].[re_expedientes_tramites]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 24
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_TRAMITE~'' + CAST (id_tramite AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Trigger [TR_re_expedientes_campostrazables_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientes_campostrazables_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientes_campostrazables_UPDATE] ON [dbo].[re_expedientes_campostrazables]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 23
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_CAMPOTRAZABLE~'' + CAST (id_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''ES_PRINCIPAL~'' + CAST (es_principal AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_CAMPOTRAZABLE~'' + CAST (id_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''ES_PRINCIPAL~'' + CAST (es_principal AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientestramites_tiposbloqueos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientestramites_tiposbloqueos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientestramites_tiposbloqueos_DELETE] ON [dbo].[re_expedientestramites_tiposbloqueos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 25
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_RE_EXPEDIENTE_TRAMITE~'' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + ''|'' +
					''ID_TIPOBLOQUEO~'' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + ''|'' +
					''NO_HORAS~'' + CAST (no_horas AS VARCHAR(MAX)) + ''|'' +
					''NO_DIAS~'' + CAST (no_dias AS VARCHAR(MAX))		
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_roles_modulos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_roles_modulos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_roles_modulos_UPDATE] ON [dbo].[re_roles_modulos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 26
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX)) + ''|'' +
					''ID_MODULO~'' + CAST (id_modulo AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX)) + ''|'' +
					''ID_MODULO~'' + CAST (id_modulo AS VARCHAR(MAX))
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_roles_modulos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_roles_modulos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_roles_modulos_DELETE] ON [dbo].[re_roles_modulos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 26
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_ROL~'' + CAST (id_rol AS VARCHAR(MAX)) + ''|'' +
					''ID_MODULO~'' + CAST (id_modulo AS VARCHAR(MAX))	
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientes_campostrazables_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientes_campostrazables_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientes_campostrazables_DELETE] ON [dbo].[re_expedientes_campostrazables]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 23
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_CAMPOTRAZABLE~'' + CAST (id_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''ES_PRINCIPAL~'' + CAST (es_principal AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_clasificaciondocumentos_documentos_UPDATE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_clasificaciondocumentos_documentos_UPDATE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_clasificaciondocumentos_documentos_UPDATE] ON [dbo].[re_clasificaciondocumentos_documentos]
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	DECLARE @VALORES_ANTERIORES VARCHAR(MAX)
	
	SET @ID_TABLA = 22
	SET @ID_ACCION = 3
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + ''|'' +
					''ID_DOCUMENTO~'' + CAST (id_documento AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX)) + ''|'' +
					''ID_ORIGEN~'' + CAST (id_origen AS VARCHAR(MAX)) + ''|'' +
					''ORDEN~'' + CAST (orden AS VARCHAR(MAX)) + ''|'' +
					''OBLIGATORIO~'' + CAST (obligatorio AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + ''|'' +
					''ID_DOCUMENTO~'' + CAST (id_documento AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX)) + ''|'' +
					''ID_ORIGEN~'' + CAST (id_origen AS VARCHAR(MAX)) + ''|'' +
					''ORDEN~'' + CAST (orden AS VARCHAR(MAX)) + ''|'' +
					''OBLIGATORIO~'' + CAST (obligatorio AS VARCHAR(MAX))	
	FROM DELETED

	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES,
		@VALORES_ANTERIORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_tramites_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tramites_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tramites_DELETE] ON [dbo].[ca_tramites]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 13
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''DESCRIPCION~'' + Descripcion + ''|'' + 
					''DESCRIPCION_BREVE~'' + Descripcion_Breve + ''|'' + 
					''ALCANCE_INICIAL~'' + Alcance_Inicial + ''|'' + 
					''ALCANCE_FINAL~'' + Alcance_Final + ''|'' + 
					''ID_CLASIFICACIONTRAMITE~'' + CAST(id_ClasificacionTramite AS varchar(MAX))  + ''|'' + 
					''ID_ESTATUS~'' + CAST(id_estatus AS varchar(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_ca_tramites_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_ca_tramites_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ca_tramites_INSERT] ON [dbo].[ca_tramites]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 13
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''NOMBRE~'' + Nombre + ''|'' + 
					''DESCRIPCION~'' + Descripcion + ''|'' + 
					''DESCRIPCION_BREVE~'' + Descripcion_Breve + ''|'' + 
					''ALCANCE_INICIAL~'' + Alcance_Inicial + ''|'' + 
					''ALCANCE_FINAL~'' + Alcance_Final + ''|'' + 
					''ID_CLASIFICACIONTRAMITE~'' + CAST(id_ClasificacionTramite AS varchar(MAX))  + ''|'' + 
					''ID_ESTATUS~'' + CAST(id_estatus AS varchar(MAX))
	FROM INSERTED			
	
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);
END
'
GO
/****** Object:  Trigger [TR_re_clasificaciondocumentos_documentos_DELETE]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_clasificaciondocumentos_documentos_DELETE]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_clasificaciondocumentos_documentos_DELETE] ON [dbo].[re_clasificaciondocumentos_documentos]
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 22
	SET @ID_ACCION = 2
		
	SELECT 
		@ID_REGISTRO = id,
		@VALORES =	''ID_CLASIFICACIONDOCUMENTO~'' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + ''|'' +
					''ID_DOCUMENTO~'' + CAST (id_documento AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX)) + ''|'' +
					''ID_ORIGEN~'' + CAST (id_origen AS VARCHAR(MAX)) + ''|'' +
					''ORDEN~'' + CAST (orden AS VARCHAR(MAX)) + ''|'' +
					''OBLIGATORIO~'' + CAST (obligatorio AS VARCHAR(MAX))
	FROM DELETED			
		
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES_ANTERIORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);	
END
'
GO
/****** Object:  Trigger [TR_re_expedientes_campostrazables_INSERT]    Script Date: 01/22/2014 10:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TR_re_expedientes_campostrazables_INSERT]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_re_expedientes_campostrazables_INSERT] ON [dbo].[re_expedientes_campostrazables]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
			
	DECLARE @ID_TABLA INT	
	DECLARE @ID_ACCION INT	
	DECLARE @ID_REGISTRO INT
	DECLARE @VALORES VARCHAR(MAX)
	
	SET @ID_TABLA = 23
	SET @ID_ACCION = 1
		
	SELECT 
		@ID_REGISTRO = ID,
		@VALORES =	''ID_EXPEDIENTE~'' + CAST (id_expediente AS VARCHAR(MAX)) + ''|'' +
					''ID_CAMPOTRAZABLE~'' + CAST (id_campotrazable AS VARCHAR(MAX)) + ''|'' +
					''ES_PRINCIPAL~'' + CAST (es_principal AS VARCHAR(MAX)) + ''|'' +
					''ID_ESTATUS~'' + CAST (id_estatus AS VARCHAR(MAX))		

	FROM INSERTED
				
	INSERT INTO HCO_CAMBIOS
	(	
		ID_TABLA,
		ID_ACCION,
		ID_REGISTRO,
		VALORES
	)
	VALUES 
	(
		@ID_TABLA,
		@ID_ACCION,
		@ID_REGISTRO,
		@VALORES
	);

END
'
GO
/****** Object:  Default [DF_de_digital_fecha_hora_creacion]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_de_digital_fecha_hora_creacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_de_digital_fecha_hora_creacion]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[de_digital] ADD  CONSTRAINT [DF_de_digital_fecha_hora_creacion]  DEFAULT (getdate()) FOR [fecha_hora_creacion]
END


End
GO
/****** Object:  Default [DF_de_digital_campostrazables_fecha_hora_creacion]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_de_digital_campostrazables_fecha_hora_creacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_de_digital_campostrazables_fecha_hora_creacion]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[de_digital_campostrazables] ADD  CONSTRAINT [DF_de_digital_campostrazables_fecha_hora_creacion]  DEFAULT (getdate()) FOR [fecha_hora_creacion]
END


End
GO
/****** Object:  Default [DF_hco_cambios_id_usuario]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_hco_cambios_id_usuario]') AND parent_object_id = OBJECT_ID(N'[dbo].[hco_cambios]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_hco_cambios_id_usuario]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[hco_cambios] ADD  CONSTRAINT [DF_hco_cambios_id_usuario]  DEFAULT (user_id(user_name())) FOR [id_usuario]
END


End
GO
/****** Object:  Default [DF_hco_cambios_fecha]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_hco_cambios_fecha]') AND parent_object_id = OBJECT_ID(N'[dbo].[hco_cambios]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_hco_cambios_fecha]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[hco_cambios] ADD  CONSTRAINT [DF_hco_cambios_fecha]  DEFAULT (getdate()) FOR [fecha]
END


End
GO
/****** Object:  Default [DF_ma_digital_fecha_hora_creacion]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ma_digital_fecha_hora_creacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[ma_digital]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ma_digital_fecha_hora_creacion]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ma_digital] ADD  CONSTRAINT [DF_ma_digital_fecha_hora_creacion]  DEFAULT (getdate()) FOR [fecha_hora_creacion]
END


End
GO
/****** Object:  Default [DF_re_clasificaciondocumentos_documentos_orden]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_re_clasificaciondocumentos_documentos_orden]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_re_clasificaciondocumentos_documentos_orden]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] ADD  CONSTRAINT [DF_re_clasificaciondocumentos_documentos_orden]  DEFAULT ((0)) FOR [orden]
END


End
GO
/****** Object:  Default [DF_re_expedientes_campostrazables_es_principal]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_re_expedientes_campostrazables_es_principal]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_re_expedientes_campostrazables_es_principal]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[re_expedientes_campostrazables] ADD  CONSTRAINT [DF_re_expedientes_campostrazables_es_principal]  DEFAULT ((0)) FOR [es_principal]
END


End
GO
/****** Object:  Default [DF_tbl_errorlogs_fechahora]    Script Date: 01/22/2014 10:57:55 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_errorlogs_fechahora]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_errorlogs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_errorlogs_fechahora]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_errorlogs] ADD  CONSTRAINT [DF_tbl_errorlogs_fechahora]  DEFAULT (getdate()) FOR [fechahora]
END


End
GO
/****** Object:  ForeignKey [FK_ca_documentos_ca_formatos]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_documentos_ca_formatos]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_documentos]'))
ALTER TABLE [dbo].[ca_documentos]  WITH CHECK ADD  CONSTRAINT [FK_ca_documentos_ca_formatos] FOREIGN KEY([id_Formato])
REFERENCES [dbo].[ca_formatos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_documentos_ca_formatos]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_documentos]'))
ALTER TABLE [dbo].[ca_documentos] CHECK CONSTRAINT [FK_ca_documentos_ca_formatos]
GO
/****** Object:  ForeignKey [FK_ca_tramites_ca_clasificaciontramites]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_tramites_ca_clasificaciontramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_tramites]'))
ALTER TABLE [dbo].[ca_tramites]  WITH CHECK ADD  CONSTRAINT [FK_ca_tramites_ca_clasificaciontramites] FOREIGN KEY([id_ClasificacionTramite])
REFERENCES [dbo].[ca_clasificaciontramites] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_tramites_ca_clasificaciontramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_tramites]'))
ALTER TABLE [dbo].[ca_tramites] CHECK CONSTRAINT [FK_ca_tramites_ca_clasificaciontramites]
GO
/****** Object:  ForeignKey [FK_ca_tramites_ca_estatus]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_tramites_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_tramites]'))
ALTER TABLE [dbo].[ca_tramites]  WITH CHECK ADD  CONSTRAINT [FK_ca_tramites_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_tramites_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_tramites]'))
ALTER TABLE [dbo].[ca_tramites] CHECK CONSTRAINT [FK_ca_tramites_ca_estatus]
GO
/****** Object:  ForeignKey [FK_ca_usuarios_ca_cargo_puesto]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_usuarios_ca_cargo_puesto]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_usuarios]'))
ALTER TABLE [dbo].[ca_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_ca_usuarios_ca_cargo_puesto] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[ca_cargo_puesto] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ca_usuarios_ca_cargo_puesto]') AND parent_object_id = OBJECT_ID(N'[dbo].[ca_usuarios]'))
ALTER TABLE [dbo].[ca_usuarios] CHECK CONSTRAINT [FK_ca_usuarios_ca_cargo_puesto]
GO
/****** Object:  ForeignKey [FK_de_acciones_modulo_ca_acciones]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_acciones_modulo_ca_acciones]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_acciones_modulo]'))
ALTER TABLE [dbo].[de_acciones_modulo]  WITH CHECK ADD  CONSTRAINT [FK_de_acciones_modulo_ca_acciones] FOREIGN KEY([id_acccion])
REFERENCES [dbo].[ca_acciones] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_acciones_modulo_ca_acciones]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_acciones_modulo]'))
ALTER TABLE [dbo].[de_acciones_modulo] CHECK CONSTRAINT [FK_de_acciones_modulo_ca_acciones]
GO
/****** Object:  ForeignKey [FK_de_digital_ca_estatus]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
ALTER TABLE [dbo].[de_digital]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
ALTER TABLE [dbo].[de_digital] CHECK CONSTRAINT [FK_de_digital_ca_estatus]
GO
/****** Object:  ForeignKey [FK_de_digital_ma_digital1]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_ma_digital1]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
ALTER TABLE [dbo].[de_digital]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_ma_digital1] FOREIGN KEY([id_ma_digital])
REFERENCES [dbo].[ma_digital] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_ma_digital1]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
ALTER TABLE [dbo].[de_digital] CHECK CONSTRAINT [FK_de_digital_ma_digital1]
GO
/****** Object:  ForeignKey [FK_de_digital_re_clasificaciondocumentos_documentos]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_re_clasificaciondocumentos_documentos]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
ALTER TABLE [dbo].[de_digital]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_re_clasificaciondocumentos_documentos] FOREIGN KEY([id_re_clasificaciondocumento_documento])
REFERENCES [dbo].[re_clasificaciondocumentos_documentos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_re_clasificaciondocumentos_documentos]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital]'))
ALTER TABLE [dbo].[de_digital] CHECK CONSTRAINT [FK_de_digital_re_clasificaciondocumentos_documentos]
GO
/****** Object:  ForeignKey [FK_de_digital_campostrazables_ca_estatus]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_campostrazables_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
ALTER TABLE [dbo].[de_digital_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_campostrazables_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_campostrazables_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
ALTER TABLE [dbo].[de_digital_campostrazables] CHECK CONSTRAINT [FK_de_digital_campostrazables_ca_estatus]
GO
/****** Object:  ForeignKey [FK_de_digital_campostrazables_ma_digital]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_campostrazables_ma_digital]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
ALTER TABLE [dbo].[de_digital_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_campostrazables_ma_digital] FOREIGN KEY([id_ma_digital])
REFERENCES [dbo].[ma_digital] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_campostrazables_ma_digital]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
ALTER TABLE [dbo].[de_digital_campostrazables] CHECK CONSTRAINT [FK_de_digital_campostrazables_ma_digital]
GO
/****** Object:  ForeignKey [FK_de_digital_campostrazables_re_expedientes_campostrazables]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_campostrazables_re_expedientes_campostrazables]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
ALTER TABLE [dbo].[de_digital_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_campostrazables_re_expedientes_campostrazables] FOREIGN KEY([id_re_expediente_campotrazable])
REFERENCES [dbo].[re_expedientes_campostrazables] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_de_digital_campostrazables_re_expedientes_campostrazables]') AND parent_object_id = OBJECT_ID(N'[dbo].[de_digital_campostrazables]'))
ALTER TABLE [dbo].[de_digital_campostrazables] CHECK CONSTRAINT [FK_de_digital_campostrazables_re_expedientes_campostrazables]
GO
/****** Object:  ForeignKey [FK_hco_cambios_ca_acciones]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_hco_cambios_ca_acciones]') AND parent_object_id = OBJECT_ID(N'[dbo].[hco_cambios]'))
ALTER TABLE [dbo].[hco_cambios]  WITH CHECK ADD  CONSTRAINT [FK_hco_cambios_ca_acciones] FOREIGN KEY([id_accion])
REFERENCES [dbo].[ca_acciones] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_hco_cambios_ca_acciones]') AND parent_object_id = OBJECT_ID(N'[dbo].[hco_cambios]'))
ALTER TABLE [dbo].[hco_cambios] CHECK CONSTRAINT [FK_hco_cambios_ca_acciones]
GO
/****** Object:  ForeignKey [FK_hco_cambios_ca_tablas]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_hco_cambios_ca_tablas]') AND parent_object_id = OBJECT_ID(N'[dbo].[hco_cambios]'))
ALTER TABLE [dbo].[hco_cambios]  WITH CHECK ADD  CONSTRAINT [FK_hco_cambios_ca_tablas] FOREIGN KEY([id_tabla])
REFERENCES [dbo].[ca_tablas] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_hco_cambios_ca_tablas]') AND parent_object_id = OBJECT_ID(N'[dbo].[hco_cambios]'))
ALTER TABLE [dbo].[hco_cambios] CHECK CONSTRAINT [FK_hco_cambios_ca_tablas]
GO
/****** Object:  ForeignKey [FK_ma_digital_ca_estatus]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ma_digital_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[ma_digital]'))
ALTER TABLE [dbo].[ma_digital]  WITH CHECK ADD  CONSTRAINT [FK_ma_digital_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ma_digital_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[ma_digital]'))
ALTER TABLE [dbo].[ma_digital] CHECK CONSTRAINT [FK_ma_digital_ca_estatus]
GO
/****** Object:  ForeignKey [FK_ma_digital_re_expedientes_tramites]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ma_digital_re_expedientes_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[ma_digital]'))
ALTER TABLE [dbo].[ma_digital]  WITH CHECK ADD  CONSTRAINT [FK_ma_digital_re_expedientes_tramites] FOREIGN KEY([id_re_expediente_tramite])
REFERENCES [dbo].[re_expedientes_tramites] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ma_digital_re_expedientes_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[ma_digital]'))
ALTER TABLE [dbo].[ma_digital] CHECK CONSTRAINT [FK_ma_digital_re_expedientes_tramites]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1] FOREIGN KEY([id_clasificaciondocumento])
REFERENCES [dbo].[ca_clasificaciondocumentos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_documentos1]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_documentos1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_documentos1] FOREIGN KEY([id_documento])
REFERENCES [dbo].[ca_documentos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_documentos1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_documentos1]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_estatus1]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_estatus1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_estatus1] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_estatus1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_estatus1]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_origenes]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_origenes]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_origenes] FOREIGN KEY([id_origen])
REFERENCES [dbo].[ca_origenes] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_clasificaciondocumentos_documentos_ca_origenes]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_clasificaciondocumentos_documentos]'))
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_origenes]
GO
/****** Object:  ForeignKey [FK_re_expedientes_campostrazables_ca_campostrazables]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_campostrazables_ca_campostrazables]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
ALTER TABLE [dbo].[re_expedientes_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_campostrazables_ca_campostrazables] FOREIGN KEY([id_campotrazable])
REFERENCES [dbo].[ca_campostrazables] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_campostrazables_ca_campostrazables]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
ALTER TABLE [dbo].[re_expedientes_campostrazables] CHECK CONSTRAINT [FK_re_expedientes_campostrazables_ca_campostrazables]
GO
/****** Object:  ForeignKey [FK_re_expedientes_campostrazables_ca_estatus]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_campostrazables_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
ALTER TABLE [dbo].[re_expedientes_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_campostrazables_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_campostrazables_ca_estatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
ALTER TABLE [dbo].[re_expedientes_campostrazables] CHECK CONSTRAINT [FK_re_expedientes_campostrazables_ca_estatus]
GO
/****** Object:  ForeignKey [FK_re_expedientes_campostrazables_ca_expedientes]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_campostrazables_ca_expedientes]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
ALTER TABLE [dbo].[re_expedientes_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_campostrazables_ca_expedientes] FOREIGN KEY([id_expediente])
REFERENCES [dbo].[ca_expedientes] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_campostrazables_ca_expedientes]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_campostrazables]'))
ALTER TABLE [dbo].[re_expedientes_campostrazables] CHECK CONSTRAINT [FK_re_expedientes_campostrazables_ca_expedientes]
GO
/****** Object:  ForeignKey [FK_re_expedientes_tramites_ca_expedientes]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_tramites_ca_expedientes]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]'))
ALTER TABLE [dbo].[re_expedientes_tramites]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_tramites_ca_expedientes] FOREIGN KEY([id_expediente])
REFERENCES [dbo].[ca_expedientes] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_tramites_ca_expedientes]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]'))
ALTER TABLE [dbo].[re_expedientes_tramites] CHECK CONSTRAINT [FK_re_expedientes_tramites_ca_expedientes]
GO
/****** Object:  ForeignKey [FK_re_expedientes_tramites_ca_tramites]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_tramites_ca_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]'))
ALTER TABLE [dbo].[re_expedientes_tramites]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_tramites_ca_tramites] FOREIGN KEY([id_tramite])
REFERENCES [dbo].[ca_tramites] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientes_tramites_ca_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientes_tramites]'))
ALTER TABLE [dbo].[re_expedientes_tramites] CHECK CONSTRAINT [FK_re_expedientes_tramites_ca_tramites]
GO
/****** Object:  ForeignKey [FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]'))
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos] FOREIGN KEY([id_tipobloqueo])
REFERENCES [dbo].[ca_tiposbloqueos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]'))
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos] CHECK CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos]
GO
/****** Object:  ForeignKey [FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]'))
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites] FOREIGN KEY([id_re_expediente_tramite])
REFERENCES [dbo].[re_expedientes_tramites] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_expedientestramites_tiposbloqueos]'))
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos] CHECK CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites]
GO
/****** Object:  ForeignKey [FK_re_roles_modulos_ca_modulos]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_roles_modulos_ca_modulos]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]'))
ALTER TABLE [dbo].[re_roles_modulos]  WITH CHECK ADD  CONSTRAINT [FK_re_roles_modulos_ca_modulos] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[ca_modulos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_roles_modulos_ca_modulos]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]'))
ALTER TABLE [dbo].[re_roles_modulos] CHECK CONSTRAINT [FK_re_roles_modulos_ca_modulos]
GO
/****** Object:  ForeignKey [FK_re_roles_modulos_ca_roles]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_roles_modulos_ca_roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]'))
ALTER TABLE [dbo].[re_roles_modulos]  WITH CHECK ADD  CONSTRAINT [FK_re_roles_modulos_ca_roles] FOREIGN KEY([id_rol])
REFERENCES [dbo].[ca_roles] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_roles_modulos_ca_roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_roles_modulos]'))
ALTER TABLE [dbo].[re_roles_modulos] CHECK CONSTRAINT [FK_re_roles_modulos_ca_roles]
GO
/****** Object:  ForeignKey [FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]'))
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos]  WITH CHECK ADD  CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos] FOREIGN KEY([id_clasificaciondocumento])
REFERENCES [dbo].[ca_clasificaciondocumentos] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]'))
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos] CHECK CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos]
GO
/****** Object:  ForeignKey [FK_re_tramites_clasificaciondocumentos_ca_tramites]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_tramites_clasificaciondocumentos_ca_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]'))
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos]  WITH CHECK ADD  CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_tramites] FOREIGN KEY([id_tramie])
REFERENCES [dbo].[ca_tramites] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_tramites_clasificaciondocumentos_ca_tramites]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_tramites_clasificaciondocumentos]'))
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos] CHECK CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_tramites]
GO
/****** Object:  ForeignKey [FK_re_usuarios_roles_permisos_ca_roles1]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_usuarios_roles_permisos_ca_roles1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]'))
ALTER TABLE [dbo].[re_usuarios_roles_permisos]  WITH CHECK ADD  CONSTRAINT [FK_re_usuarios_roles_permisos_ca_roles1] FOREIGN KEY([id_rol])
REFERENCES [dbo].[ca_roles] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_usuarios_roles_permisos_ca_roles1]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]'))
ALTER TABLE [dbo].[re_usuarios_roles_permisos] CHECK CONSTRAINT [FK_re_usuarios_roles_permisos_ca_roles1]
GO
/****** Object:  ForeignKey [FK_re_usuarios_roles_permisos_ca_usuarios]    Script Date: 01/22/2014 10:57:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_usuarios_roles_permisos_ca_usuarios]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]'))
ALTER TABLE [dbo].[re_usuarios_roles_permisos]  WITH CHECK ADD  CONSTRAINT [FK_re_usuarios_roles_permisos_ca_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[ca_usuarios] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_re_usuarios_roles_permisos_ca_usuarios]') AND parent_object_id = OBJECT_ID(N'[dbo].[re_usuarios_roles_permisos]'))
ALTER TABLE [dbo].[re_usuarios_roles_permisos] CHECK CONSTRAINT [FK_re_usuarios_roles_permisos_ca_usuarios]
GO
