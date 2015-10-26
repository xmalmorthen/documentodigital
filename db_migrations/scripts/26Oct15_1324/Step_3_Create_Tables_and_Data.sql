USE [BdExpDigital]
GO
/****** Object:  Table [dbo].[ca_acciones]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_acciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_acciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_acciones] ON [dbo].[ca_acciones] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_acciones] ON
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (1, N'Alta')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (2, N'Baja')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (4, N'Consulta')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (3, N'Modificaciòn')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (5, N'Reporte')
SET IDENTITY_INSERT [dbo].[ca_acciones] OFF
/****** Object:  StoredProcedure [dbo].[pa_obtener_hora]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 17 Agosto 2013
-- Description:	Obtiene la hora configurada del servidor de base de datos
-- =============================================
CREATE PROCEDURE [dbo].[pa_obtener_hora]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT CONVERT(VARCHAR(8),GETDATE(),108) AS Hora
END
GO
/****** Object:  Table [dbo].[ca_origenes]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_origenes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_origenes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_origenes] ON [dbo].[ca_origenes] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_origenes] ON
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (2, N'Externo')
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (1, N'Interno')
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (4, N'Proveedor')
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (3, N'Usuario')
SET IDENTITY_INSERT [dbo].[ca_origenes] OFF
/****** Object:  StoredProcedure [dbo].[pa_obtener_fecha]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 17 Agosto 2013
-- Description:	Obtiene la fecha configurada del servidor de base de datos
-- =============================================
CREATE PROCEDURE [dbo].[pa_obtener_fecha]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT CONVERT(VARCHAR(8),GETDATE(),101) AS Fecha
END
GO
/****** Object:  Table [dbo].[ca_clasificaciontramites]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_clasificaciontramites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ca_clasificaciontramites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_clasificaciontramites] ON [dbo].[ca_clasificaciontramites] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_modulos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_modulos] ON [dbo].[ca_modulos] 
(
	[Modulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_modulos] ON
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (1, N'Registro y seguimiento', 2, 1)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (2, N'Deshacer registro', 2, 2)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (3, N'Blquear/Desbloquear', 2, 3)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (4, N'Roles', 3, 1)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (5, N'Usuarios', 3, 2)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (6, N'Preferencias', 3, 3)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (7, N'Expedientes', 1, 1)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (8, N'Campos trazables', 1, 2)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (9, N'Clasificación de trámites', 1, 4)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (10, N'Trámites', 1, 5)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (11, N'Clasificación de documentos', 1, 6)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (12, N'Documentos', 1, 7)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (13, N'Asignar campos trazables a un expediente', 1, 3)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (14, N'Clasificar documentos', 1, 8)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (15, N'Asignar clasificación de documentos a un trámite', 1, 9)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (16, N'Cargo/Puesto', 3, 4)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (17, N'Típo de formatos para documentos', 1, 10)
SET IDENTITY_INSERT [dbo].[ca_modulos] OFF
/****** Object:  Table [dbo].[ca_campostrazables]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_campostrazables](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Tamanio_Caracteres] [int] NOT NULL,
	[Mascara] [varchar](200) NULL,
 CONSTRAINT [PK_ca_campostrazables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_campostrazables] ON [dbo].[ca_campostrazables] 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_fechahora]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 04 Septiembre 2013
-- Description:	Obtiene la fecha y hora configurada del servidor de base de datos
-- =============================================
CREATE PROCEDURE [dbo].[pa_obtener_fechahora]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT GETDATE() AS FechaHora
END
GO
/****** Object:  Table [dbo].[ca_clasificaciondocumentos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_clasificaciondocumentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ca_clasificaciondocumentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_clasificaciondocumentos] ON [dbo].[ca_clasificaciondocumentos] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_formatos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_formatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_formatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_formatos] ON [dbo].[ca_formatos] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[pa_CreateLoginandUser]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pa_CreateLoginandUser](
        @LOGIN VARCHAR(100),
        @PASSWORD VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = 'BdExpDigital'

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)
DECLARE @SAFE_PASSWORD VARCHAR(200)

SET @SAFE_USER = '..BdExpDigital_' + @LOGIN + '..'
SET @SAFE_PASSWORD = @PASSWORD

DECLARE @SQL NVARCHAR(MAX)
SET @SQL =	'USE [master] ' +
			--'GO ' +
			'CREATE LOGIN [' + @SAFE_USER + '] ' +
			'WITH PASSWORD = ''' + @SAFE_PASSWORD + ''', ' +
			'DEFAULT_DATABASE=[' + @DB + '], ' +
			'CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF ' +
			--'GO ' +
			'USE [' + @DB + '] ' +
			--'GO ' +
			'CREATE USER [' + @SAFE_USER + '] FOR LOGIN [' + @SAFE_USER + '] ' +
			--'GO ' +
			'USE [' + @DB +	'] ' +
			--'GO ' +
			'EXEC sp_addrolemember N''db_owner'', N''' + @SAFE_USER + ''' ' +
			--'GO'
			--'USE [' + @DB +	'] ' +
			--'EXEC sp_addrolemember N''db_accessadmin'', N''' + @SAFE_USER + ''' ' +
			'USE [' + @DB +	'] ' +
			'EXEC sp_addrolemember N''db_datareader'', N''' + @SAFE_USER + ''' ' +
			'USE [' + @DB +	'] ' +
			'EXEC sp_addrolemember N''db_datawriter'', N''' + @SAFE_USER + ''' '
						
BEGIN TRY
	EXEC (@SQL)
	EXEC sp_addrolemember N'db_owner', @SAFE_USER
		
	SELECT 1 as StatusCode, 'EXITO' as StatusDescripcion
	RETURN (1)
END TRY
BEGIN CATCH
    SELECT
		0 as StatusCode, 'ERROR' as StatusDescripcion,
        ERROR_NUMBER() as ErrorNumber,
        ERROR_MESSAGE() as ErrorMessage;
    RETURN (0)
END CATCH;
GO
/****** Object:  Table [dbo].[ca_roles]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_roles] ON [dbo].[ca_roles] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_roles] ON
INSERT [dbo].[ca_roles] ([id], [Descripcion]) VALUES (1, N'Administrador')
SET IDENTITY_INSERT [dbo].[ca_roles] OFF
/****** Object:  Table [dbo].[ca_expedientes]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_expedientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ma_expediente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_expedientes] ON [dbo].[ca_expedientes] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_estatus]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_estatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ca_estatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_estatus] ON [dbo].[ca_estatus] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_estatus] ON
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (1, N'Activo')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (4, N'Bloqueado')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (5, N'Desbloqueado')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (9, N'Desechado')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (2, N'Inactivo')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (7, N'Invisible')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (3, N'Suspendido')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (6, N'Visible')
SET IDENTITY_INSERT [dbo].[ca_estatus] OFF
/****** Object:  StoredProcedure [dbo].[pa_ModifyPassUserSQL]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pa_ModifyPassUserSQL](
        @LOGIN VARCHAR(100),
        @PASSWORD VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = 'BdExpDigital'

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)
DECLARE @SAFE_PASSWORD VARCHAR(200)

SET @SAFE_USER = '..BdExpDigital_' + @LOGIN + '..'
SET @SAFE_PASSWORD = @PASSWORD

DECLARE @SQL NVARCHAR(MAX)
SET @SQL =	'USE [master] ' +
			--'GO ' +
			'ALTER LOGIN [' + @SAFE_USER + '] ' +
			'WITH PASSWORD = ''' + @SAFE_PASSWORD + ''';'			
						
BEGIN TRY
	EXEC (@SQL)
	EXEC sp_addrolemember N'db_owner', @SAFE_USER
		
	SELECT 1 as StatusCode, 'EXITO' as StatusDescripcion
	RETURN (1)
END TRY
BEGIN CATCH
    SELECT
		0 as StatusCode, 'ERROR' as StatusDescripcion,
        ERROR_NUMBER() as ErrorNumber,
        ERROR_MESSAGE() as ErrorMessage;
    RETURN (0)
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[pa_DeleteUserSQL]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pa_DeleteUserSQL](
        @LOGIN VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = 'BdExpDigital'

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)

SET @SAFE_USER = '..BdExpDigital_' + @LOGIN + '..'

DECLARE @SQL NVARCHAR(MAX)
SET @SQL =	'USE [' + @DB +'] ' +
			'EXEC sp_dropuser [' + @SAFE_USER + '] ' +
			'USE [master] ' +
			'DROP LOGIN [' + @SAFE_USER + ']'
					
BEGIN TRY
	EXEC (@SQL)		
	SELECT 1 as StatusCode, 'EXITO' as StatusDescripcion
	RETURN (1)
END TRY
BEGIN CATCH
    SELECT
		0 as StatusCode, 'ERROR' as StatusDescripcion,
        ERROR_NUMBER() as ErrorNumber,
        ERROR_MESSAGE() as ErrorMessage;
    RETURN (0)
END CATCH;
GO
/****** Object:  Table [dbo].[ca_tiposbloqueos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_tiposbloqueos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_ca_tiposbloqueos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_tiposbloqueos] ON [dbo].[ca_tiposbloqueos] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_tiposbloqueos] ON
INSERT [dbo].[ca_tiposbloqueos] ([id], [Descripcion]) VALUES (2, N'Bloquear despues de determinado tiempo')
INSERT [dbo].[ca_tiposbloqueos] ([id], [Descripcion]) VALUES (3, N'Bloquear manualmente')
SET IDENTITY_INSERT [dbo].[ca_tiposbloqueos] OFF
/****** Object:  Table [dbo].[ca_tablas]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_tablas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_ca_tablas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_tablas] ON [dbo].[ca_tablas] 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_tablas] ON
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (2, N'ca_acciones', N'catálogo de acciones')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (3, N'ca_campostrazables', N'catálogo de campos trazables')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (4, N'ca_clasificaciondocumentos', N'ca_clasificaciondocumentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (5, N'ca_clasificaciontramites', N'ca_clasificaciontramites')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (6, N'ca_documentos', N'ca_documentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (7, N'ca_estatus', N'ca_estatus')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (8, N'ca_expedientes', N'ca_expedientes')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (9, N'ca_formatos', N'ca_formatos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (10, N'ca_modulos', N'ca_modulos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (11, N'ca_origenes', N'ca_origenes')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (12, N'ca_roles', N'ca_roles')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (13, N'ca_tablas', N'ca_tablas')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (14, N'ca_tiposbloqueos', N'ca_tiposbloqueos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (15, N'ca_tramites', N'ca_tramites')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (16, N'ca_usuarios', N'ca_usuarios')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (17, N'de_acciones_modulo', N'de_acciones_modulo')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (18, N'de_digital', N'de_digital')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (19, N'de_digital_campostrazables', N'de_digital_campostrazables')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (20, N'hco_cambios', N'hco_cambios')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (21, N'ma_digital', N'ma_digital')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (22, N're_clasificaciondocumentos_documentos', N're_clasificaciondocumentos_documentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (23, N're_expedientes_campostrazables', N're_expedientes_campostrazables')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (24, N're_expedientes_tramites', N're_expedientes_tramites')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (25, N're_expedientestramites_tiposbloqueos', N're_expedientestramites_tiposbloqueos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (26, N're_roles_modulos', N're_roles_modulos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (27, N're_tramites_clasificaciondocumentos', N're_tramites_clasificaciondocumentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (28, N're_usuarios_roles_permisos', N're_usuarios_roles_permisos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (29, N'tbl_configuraciones', N'tbl_configuraciones')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (30, N'ca_cargo_puesto', N'ca_cargo_puesto')
SET IDENTITY_INSERT [dbo].[ca_tablas] OFF
/****** Object:  Table [dbo].[tbl_configuraciones]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_configuraciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Valor] [varchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_configuraciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_tbl_configuraciones] ON [dbo].[tbl_configuraciones] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_configuraciones] ON
INSERT [dbo].[tbl_configuraciones] ([id], [Descripcion], [Valor]) VALUES (1, N'Tramite por default', N'1')
SET IDENTITY_INSERT [dbo].[tbl_configuraciones] OFF
/****** Object:  Table [dbo].[ca_cargo_puesto]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_cargo_puesto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ca_cargo_puesto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_cargo_puesto] ON [dbo].[ca_cargo_puesto] 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_cargo_puesto] ON
INSERT [dbo].[ca_cargo_puesto] ([id], [Descripcion]) VALUES (1, N'Administrador del sistema')
SET IDENTITY_INSERT [dbo].[ca_cargo_puesto] OFF
/****** Object:  Table [dbo].[tbl_errorlogs]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_tbl_errorlogs] ON [dbo].[tbl_errorlogs] 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_tbl_errorlogs_1] ON [dbo].[tbl_errorlogs] 
(
	[fechahora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es usuario que pertenece a ca_usuarios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_errorlogs', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
/****** Object:  Table [dbo].[de_acciones_modulo]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[de_acciones_modulo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_re_roles_modulos] [int] NOT NULL,
	[id_acccion] [int] NOT NULL,
 CONSTRAINT [PK_de_acciones_modulo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_acciones_modulo] ON [dbo].[de_acciones_modulo] 
(
	[id_acccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_acciones_modulo_1] ON [dbo].[de_acciones_modulo] 
(
	[id_re_roles_modulos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hco_cambios]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
CREATE NONCLUSTERED INDEX [IX_hco_cambios] ON [dbo].[hco_cambios] 
(
	[id_tabla] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_hco_cambios_1] ON [dbo].[hco_cambios] 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_hco_cambios_2] ON [dbo].[hco_cambios] 
(
	[fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_hco_cambios_3] ON [dbo].[hco_cambios] 
(
	[id_accion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_hco_cambios_4] ON [dbo].[hco_cambios] 
(
	[id_registro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_documentos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
 CONSTRAINT [PK_ca_Documentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_documentos] ON [dbo].[ca_documentos] 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_documentos_1] ON [dbo].[ca_documentos] 
(
	[id_Formato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_documentos_2] ON [dbo].[ca_documentos] 
(
	[Resguardo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_documentos_3] ON [dbo].[ca_documentos] 
(
	[Trazabilidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = Original, 2 = Copia' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = SI, 0 = NO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Resguardo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'En meses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Tiempo_Resguardo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = NO, 1 = SI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_documentos', @level2type=N'COLUMN',@level2name=N'Trazabilidad'
GO
/****** Object:  Table [dbo].[re_clasificaciondocumentos_documentos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_clasificaciondocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_1] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_2] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_3] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[id_origen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_4] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[orden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_clasificaciondocumentos_documentos_5] ON [dbo].[re_clasificaciondocumentos_documentos] 
(
	[obligatorio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N're_clasificaciondocumentos_documentos', @level2type=N'COLUMN',@level2name=N'id_estatus'
GO
/****** Object:  Table [dbo].[ca_tramites]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_tramites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Descripcion_Breve] [varchar](100) NULL,
	[Alcance_Inicial] [varchar](100) NULL,
	[Alcance_Final] [varchar](100) NULL,
	[id_ClasificacionTramite] [int] NOT NULL,
	[id_estatus] [int] NOT NULL,
 CONSTRAINT [PK_ca_tramites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_tramites] ON [dbo].[ca_tramites] 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_tramites_1] ON [dbo].[ca_tramites] 
(
	[id_ClasificacionTramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_tramites_2] ON [dbo].[ca_tramites] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ca_tramites', @level2type=N'COLUMN',@level2name=N'id_estatus'
GO
/****** Object:  Table [dbo].[re_roles_modulos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[re_roles_modulos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_modulo] [int] NOT NULL,
 CONSTRAINT [PK_re_roles_modulos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_roles_modulos] ON [dbo].[re_roles_modulos] 
(
	[id_modulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_roles_modulos_1] ON [dbo].[re_roles_modulos] 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[re_roles_modulos] ON
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (1, 1, 1)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (2, 1, 2)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (3, 1, 3)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (4, 1, 4)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (5, 1, 5)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (6, 1, 6)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (7, 1, 7)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (8, 1, 8)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (9, 1, 9)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (10, 1, 10)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (11, 1, 11)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (12, 1, 12)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (13, 1, 13)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (14, 1, 15)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (15, 1, 14)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (16, 1, 16)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (17, 1, 17)
SET IDENTITY_INSERT [dbo].[re_roles_modulos] OFF
/****** Object:  Table [dbo].[re_expedientes_campostrazables]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables] ON [dbo].[re_expedientes_campostrazables] 
(
	[id_expediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables_1] ON [dbo].[re_expedientes_campostrazables] 
(
	[id_campotrazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables_2] ON [dbo].[re_expedientes_campostrazables] 
(
	[es_principal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientes_campostrazables_3] ON [dbo].[re_expedientes_campostrazables] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_tramites_clasificaciondocumentos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[re_tramites_clasificaciondocumentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tramie] [int] NOT NULL,
	[id_clasificaciondocumento] [int] NOT NULL,
 CONSTRAINT [PK_re_tramites_clasificaciondocumentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_tramites_clasificaciondocumentos] ON [dbo].[re_tramites_clasificaciondocumentos] 
(
	[id_clasificaciondocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_tramites_clasificaciondocumentos_1] ON [dbo].[re_tramites_clasificaciondocumentos] 
(
	[id_tramie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ca_usuarios]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ca_usuarios] ON [dbo].[ca_usuarios] 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_usuarios_1] ON [dbo].[ca_usuarios] 
(
	[CURP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_usuarios_2] ON [dbo].[ca_usuarios] 
(
	[Nombres] ASC,
	[Apellido1] ASC,
	[Apellido2] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ca_usuarios_3] ON [dbo].[ca_usuarios] 
(
	[id_cargo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ca_usuarios] ON
INSERT [dbo].[ca_usuarios] ([id], [usuario], [contrasenia], [CURP], [Nombres], [Apellido1], [Apellido2], [Telefono], [id_cargo]) VALUES (1, N'admin', N'21232f297a57a5a743894a0e4a801fc3', NULL, N'Administrador', N'del Sistema', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[ca_usuarios] OFF
/****** Object:  Table [dbo].[re_usuarios_roles_permisos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[re_usuarios_roles_permisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
 CONSTRAINT [PK_re_usuarios_roles_permisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_usuarios_roles_permisos] ON [dbo].[re_usuarios_roles_permisos] 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_usuarios_roles_permisos_1] ON [dbo].[re_usuarios_roles_permisos] 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[re_usuarios_roles_permisos] ON
INSERT [dbo].[re_usuarios_roles_permisos] ([id], [id_usuario], [id_rol]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[re_usuarios_roles_permisos] OFF
/****** Object:  Table [dbo].[re_expedientes_tramites]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[re_expedientes_tramites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_expediente] [int] NOT NULL,
	[id_tramite] [int] NOT NULL,
 CONSTRAINT [PK_re_expedientes_tramites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientes_tramites] ON [dbo].[re_expedientes_tramites] 
(
	[id_expediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientes_tramites_1] ON [dbo].[re_expedientes_tramites] 
(
	[id_tramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ma_digital]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
CREATE NONCLUSTERED INDEX [IX_ma_digital] ON [dbo].[ma_digital] 
(
	[id_re_expediente_tramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ma_digital_1] ON [dbo].[ma_digital] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ma_digital_2] ON [dbo].[ma_digital] 
(
	[fecha_hora_bloqueo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ma_digital_3] ON [dbo].[ma_digital] 
(
	[fecha_hora_creacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[de_digital]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_de_digital] ON [dbo].[de_digital] 
(
	[id_ma_digital] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_1] ON [dbo].[de_digital] 
(
	[id_re_clasificaciondocumento_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_2] ON [dbo].[de_digital] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_3] ON [dbo].[de_digital] 
(
	[fecha_hora_creacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_4] ON [dbo].[de_digital] 
(
	[valor_trazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[de_digital_campostrazables]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables] ON [dbo].[de_digital_campostrazables] 
(
	[id_ma_digital] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_1] ON [dbo].[de_digital_campostrazables] 
(
	[id_re_expediente_campotrazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_2] ON [dbo].[de_digital_campostrazables] 
(
	[valor_trazable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_3] ON [dbo].[de_digital_campostrazables] 
(
	[id_estatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_de_digital_campostrazables_4] ON [dbo].[de_digital_campostrazables] 
(
	[fecha_hora_creacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[re_expedientestramites_tiposbloqueos]    Script Date: 09/25/2013 10:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[id_re_expediente_tramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos_1] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[id_tipobloqueo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos_2] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[no_dias] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_re_expedientestramites_tiposbloqueos_3] ON [dbo].[re_expedientestramites_tiposbloqueos] 
(
	[no_horas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Trigger [TR_CA_ACCIONES_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_CA_ACCIONES_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_CA_ACCIONES_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_origenes_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_origenes_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_origenes_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  StoredProcedure [dbo].[pa_RegistrosDigitalesRegistradosporId_ma_digital]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 05 Septiembre 2013
-- Description:	Obtiene los registros digitales de un tramite registrado
-- =============================================
CREATE PROCEDURE [dbo].[pa_RegistrosDigitalesRegistradosporId_ma_digital]
	@id_ma_digital int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     dbo.de_digital.id, dbo.de_digital.thumbnail, dbo.de_digital.id_re_clasificaciondocumento_documento, dbo.de_digital.fecha_hora_creacion, dbo.de_digital.valor_trazable, 
                      dbo.ca_clasificaciondocumentos.Descripcion AS clasificaciondocumento, dbo.ca_documentos.Nombre AS Documento, 
                      dbo.re_clasificaciondocumentos_documentos.id_origen, dbo.ca_origenes.Descripcion AS Origen
	FROM         dbo.de_digital INNER JOIN
						  dbo.re_clasificaciondocumentos_documentos ON 
						  dbo.de_digital.id_re_clasificaciondocumento_documento = dbo.re_clasificaciondocumentos_documentos.id INNER JOIN
						  dbo.ca_clasificaciondocumentos ON dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento = dbo.ca_clasificaciondocumentos.id INNER JOIN
						  dbo.ca_documentos ON dbo.re_clasificaciondocumentos_documentos.id_documento = dbo.ca_documentos.id INNER JOIN
						  dbo.ca_origenes ON dbo.re_clasificaciondocumentos_documentos.id_origen = dbo.ca_origenes.id
	WHERE     (dbo.de_digital.id_estatus = 1) AND (dbo.de_digital.id_ma_digital = @id_ma_digital)
END
GO
/****** Object:  StoredProcedure [dbo].[pa_DocumentosporClasificacionDocumento]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 28 Agosto 1023
-- Description:	Obtiene lista de documentos por Clasificacion de documentos
-- =============================================
CREATE PROCEDURE [dbo].[pa_DocumentosporClasificacionDocumento]
	@id_clasificaciondocumento int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT     TOP (100) PERCENT dbo.re_clasificaciondocumentos_documentos.id AS id_re_clasificaciondocumento_documento, 
                      dbo.re_clasificaciondocumentos_documentos.id_documento, dbo.ca_documentos.Nombre, dbo.ca_documentos.id_Formato, 
                      dbo.ca_formatos.Descripcion AS DescripcionFormato, dbo.ca_documentos.No_Hojas, dbo.ca_documentos.No_Caras, dbo.ca_documentos.Estado, 
                      CASE WHEN (DBO.CA_DOCUMENTOS.ESTADO = 1) THEN 'ORIGINAL' WHEN (DBO.CA_DOCUMENTOS.ESTADO = 2) THEN 'COPIA' END AS DESCRIPCIONESTADO, 
                      dbo.ca_documentos.Resguardo, dbo.ca_documentos.Tiempo_Resguardo, dbo.ca_documentos.Trazabilidad, dbo.ca_documentos.Tamanio_Caracteres_Trazables, 
                      dbo.ca_documentos.Mascara_Trazable, dbo.ca_documentos.Politica, dbo.re_clasificaciondocumentos_documentos.id_estatus, 
                      CASE WHEN (dbo.re_clasificaciondocumentos_documentos.id_estatus = 1) THEN 1 WHEN (dbo.re_clasificaciondocumentos_documentos.id_estatus = 2) 
                      THEN 0 END AS estatus, dbo.re_clasificaciondocumentos_documentos.id_origen, dbo.ca_origenes.Descripcion AS origen, 
                      dbo.re_clasificaciondocumentos_documentos.orden, dbo.re_clasificaciondocumentos_documentos.obligatorio
	FROM         dbo.re_clasificaciondocumentos_documentos INNER JOIN
						  dbo.ca_documentos ON dbo.re_clasificaciondocumentos_documentos.id_documento = dbo.ca_documentos.id INNER JOIN
						  dbo.ca_formatos ON dbo.ca_documentos.id_Formato = dbo.ca_formatos.id LEFT OUTER JOIN
						  dbo.ca_origenes ON dbo.re_clasificaciondocumentos_documentos.id_origen = dbo.ca_origenes.id
	WHERE     (dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento = @id_clasificaciondocumento)
	ORDER BY dbo.re_clasificaciondocumentos_documentos.id_origen, dbo.re_clasificaciondocumentos_documentos.orden
	
END
GO
/****** Object:  Trigger [TR_ca_clasificaciontramites_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_clasificaciontramites_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_clasificaciontramites_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  View [dbo].[vw_ListaTramitesActivos]    Script Date: 09/25/2013 10:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ListaTramitesActivos]
AS
SELECT     TOP (100) PERCENT dbo.re_expedientes_tramites.id_expediente, dbo.ca_expedientes.Descripcion AS Descripcion_Expediente, 
                      dbo.ca_clasificaciontramites.id AS id_clasificaciontramite, dbo.ca_clasificaciontramites.Descripcion AS Descripcion_clasificaciontramite, 
                      dbo.ca_tramites.id AS id_tramite, dbo.ca_tramites.Nombre AS Nombre_tramite, dbo.ca_tramites.Descripcion AS Descripcion_tramite, 
                      dbo.ca_tramites.Descripcion_Breve AS Descripcion_Breve_tramite, dbo.ca_tramites.Alcance_Inicial AS Alcance_Inicial_tramite, 
                      dbo.ca_tramites.Alcance_Final AS Alcance_Final_tramite, dbo.ca_tramites.id_estatus AS id_estatus_tramite, 
                      dbo.ca_estatus.Descripcion AS Descripcion_estatus_tramite, dbo.re_expedientes_tramites.id AS id_re_expedientes_tramites, 
                      dbo.re_expedientestramites_tiposbloqueos.id_tipobloqueo, dbo.ca_tiposbloqueos.Descripcion AS descripcion_bloqueo, 
                      dbo.re_expedientestramites_tiposbloqueos.no_horas AS no_horas_bloqueo, dbo.re_expedientestramites_tiposbloqueos.no_dias AS no_dias_bloqueo
FROM         dbo.ca_tiposbloqueos INNER JOIN
                      dbo.re_expedientestramites_tiposbloqueos ON dbo.ca_tiposbloqueos.id = dbo.re_expedientestramites_tiposbloqueos.id_tipobloqueo RIGHT OUTER JOIN
                      dbo.ca_clasificaciontramites INNER JOIN
                      dbo.ca_tramites ON dbo.ca_clasificaciontramites.id = dbo.ca_tramites.id_ClasificacionTramite INNER JOIN
                      dbo.ca_estatus ON dbo.ca_tramites.id_estatus = dbo.ca_estatus.id INNER JOIN
                      dbo.re_expedientes_tramites ON dbo.ca_tramites.id = dbo.re_expedientes_tramites.id_tramite INNER JOIN
                      dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id ON 
                      dbo.re_expedientestramites_tiposbloqueos.id_re_expediente_tramite = dbo.re_expedientes_tramites.id
WHERE     (dbo.ca_tramites.id_estatus = 1)
ORDER BY dbo.ca_tramites.id_ClasificacionTramite, id_tramite
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[34] 2[14] 3) )"
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
         Begin Table = "ca_clasificaciontramites"
            Begin Extent = 
               Top = 183
               Left = 284
               Bottom = 324
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_tramites"
            Begin Extent = 
               Top = 167
               Left = 513
               Bottom = 406
               Right = 711
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_expedientes"
            Begin Extent = 
               Top = 88
               Left = 39
               Bottom = 207
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "re_expedientestramites_tiposbloqueos"
            Begin Extent = 
               Top = 11
               Left = 558
               Bottom = 161
               Right = 771
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_tiposbloqueos"
            Begin Extent = 
               Top = 41
               Left = 857
               Bottom = 130
               Right = 1055
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_estatus"
            Begin Extent = 
               Top = 172
               Left = 741
               Bottom = 291
               Right = 939
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "re_expedientes_tramites"
            Begin Extent = 
               Top = 27
               Left = 285
               Bo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaTramitesActivos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ttom = 169
               Right = 483
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
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 2730
         Width = 1950
         Width = 2445
         Width = 1500
         Width = 1800
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3840
         Alias = 2640
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaTramitesActivos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaTramitesActivos'
GO
/****** Object:  Trigger [TR_ca_modulos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'MODULO~' + Modulo + '|' + 
					'ID_MENU~' + CAST(id_menu AS varchar(MAX))  + '|' + 
					'ID_SUBMENU~' + CAST(id_submenu AS varchar(MAX))
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
GO
/****** Object:  Trigger [TR_ca_modulos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'MODULO~' + Modulo + '|' + 
					'ID_MENU~' + CAST(id_menu AS varchar(MAX))  + '|' + 
					'ID_SUBMENU~' + CAST(id_submenu AS varchar(MAX))
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'MODULO~' + Modulo + '|' + 
					'ID_MENU~' + CAST(id_menu AS varchar(MAX))  + '|' + 
					'ID_SUBMENU~' + CAST(id_submenu AS varchar(MAX))
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
GO
/****** Object:  Trigger [TR_ca_modulos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'MODULO~' + Modulo + '|' + 
					'ID_MENU~' + CAST(id_menu AS varchar(MAX))  + '|' + 
					'ID_SUBMENU~' + CAST(id_submenu AS varchar(MAX))
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
GO
/****** Object:  StoredProcedure [dbo].[pa_ModulosporIdRol]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 03 Septiembre 2013
-- Description:	Obtiene por id de rol, la lista de modulos asignados y no asignados a al mismo
-- =============================================
CREATE PROCEDURE [dbo].[pa_ModulosporIdRol]
	@id_rol int
AS
BEGIN
	SET NOCOUNT ON;
	(SELECT	CA_MODULOS.ID,
		CA_MODULOS.MODULO,
		CA_MODULOS.ID_MENU,
		CA_MODULOS.ID_SUBMENU,
		0 AS ENLAZADO
	FROM
			CA_MODULOS
	WHERE
			ID NOT IN (SELECT ID_MODULO FROM RE_ROLES_MODULOS WHERE ID_ROL = @id_rol)
	UNION
	SELECT  CA_MODULOS.ID,
			CA_MODULOS.MODULO,
			CA_MODULOS.ID_MENU,
			CA_MODULOS.ID_SUBMENU,
			1 AS ENLAZADO
	FROM    
			RE_ROLES_MODULOS 
	INNER JOIN
			CA_MODULOS
		ON 
			RE_ROLES_MODULOS.ID_MODULO = CA_MODULOS.ID
	WHERE     
			RE_ROLES_MODULOS.ID_ROL = @id_rol)
	ORDER BY MODULO
END
GO
/****** Object:  StoredProcedure [dbo].[pa_Permsos_Modulos]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 19 Agosto 2013
-- Description:	Obtiene los modulos permitidos para ejecutar por ususario
-- =============================================
CREATE PROCEDURE [dbo].[pa_Permsos_Modulos]
	@id_usuario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     dbo.re_roles_modulos.id_modulo, dbo.ca_modulos.id_menu, dbo.ca_modulos.id_submenu, dbo.ca_modulos.Modulo
	FROM         dbo.re_usuarios_roles_permisos INNER JOIN
						  dbo.ca_roles ON dbo.re_usuarios_roles_permisos.id_rol = dbo.ca_roles.id INNER JOIN
						  dbo.re_roles_modulos ON dbo.ca_roles.id = dbo.re_roles_modulos.id_rol INNER JOIN
						  dbo.ca_modulos ON dbo.re_roles_modulos.id_modulo = dbo.ca_modulos.id
	WHERE     (dbo.re_usuarios_roles_permisos.id_usuario = @id_usuario)
END
GO
/****** Object:  Trigger [TR_CA_CAMPOSTRAZABLES_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'TAMANIO_CARACTERES~' + CAST(Tamanio_Caracteres AS varchar(MAX))  + '|' + 
					'MASCARA~' + Mascara
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
GO
/****** Object:  Trigger [TR_CA_CAMPOSTRAZABLES_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'TAMANIO_CARACTERES~' + CAST(Tamanio_Caracteres AS varchar(MAX))  + '|' + 
					'MASCARA~' + Mascara
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
GO
/****** Object:  Trigger [TR_CA_CAMPOSTRAZABLES_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'TAMANIO_CARACTERES~' + CAST(Tamanio_Caracteres AS varchar(MAX))  + '|' + 
					'MASCARA~' + Mascara
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'NOMBRE~' + Nombre + '|' + 
								'TAMANIO_CARACTERES~' + CAST(Tamanio_Caracteres AS varchar(MAX))  + '|' + 
								'MASCARA~' + Mascara
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
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesActivosporExpediente]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 16 Agosto 1023
-- Description:	Obtiene lista de campos trazables por Expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_CampostrazablesActivosporExpediente]
	@id_expediente int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT        TOP (100) PERCENT dbo.re_expedientes_campostrazables.id AS id_re_expedientes_campostrazables, dbo.re_expedientes_campostrazables.id_campotrazable, 
                         dbo.ca_campostrazables.Nombre, dbo.ca_campostrazables.Tamanio_Caracteres, dbo.re_expedientes_campostrazables.id_estatus, 
                         dbo.ca_campostrazables.Mascara, dbo.re_expedientes_campostrazables.es_principal
	FROM            dbo.re_expedientes_campostrazables INNER JOIN
							 dbo.ca_campostrazables ON dbo.re_expedientes_campostrazables.id_campotrazable = dbo.ca_campostrazables.id
	WHERE        (dbo.re_expedientes_campostrazables.id_expediente = @id_expediente) AND (dbo.re_expedientes_campostrazables.id_estatus = 1)
	ORDER BY dbo.re_expedientes_campostrazables.es_principal DESC
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesNoEnlazadosporExpediente]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 27 Agosto 1023
-- Description:	Obtiene lista de campos trazables que no se encuentren asignados a un expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_CampostrazablesNoEnlazadosporExpediente]
	@id_expediente int
AS
BEGIN
	SET NOCOUNT ON;
	
	
	SELECT	TOP (100) PERCENT ID, NOMBRE, TAMANIO_CARACTERES,MASCARA
	FROM CA_CAMPOSTRAZABLES
	WHERE ID NOT IN (
		SELECT RE_EXPEDIENTES_CAMPOSTRAZABLES.ID_CAMPOTRAZABLE
		FROM RE_EXPEDIENTES_CAMPOSTRAZABLES
		WHERE RE_EXPEDIENTES_CAMPOSTRAZABLES.ID_EXPEDIENTE = @id_expediente
	)
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesporExpediente]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 27 Agosto 1023
-- Description:	Obtiene lista de campos trazables por Expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_CampostrazablesporExpediente]
	@id_expediente int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     TOP (100) PERCENT dbo.re_expedientes_campostrazables.id AS id_re_expedientes_campostrazables, dbo.re_expedientes_campostrazables.id_campotrazable, 
                      dbo.ca_campostrazables.Nombre, dbo.ca_campostrazables.Tamanio_Caracteres, dbo.re_expedientes_campostrazables.id_estatus, 
                      dbo.ca_campostrazables.Mascara, dbo.re_expedientes_campostrazables.es_principal, 
                      CASE WHEN (dbo.re_expedientes_campostrazables.id_estatus = 1) THEN 1 
						   WHEN (dbo.re_expedientes_campostrazables.id_estatus = 2) THEN 0 
					  END AS estatus
	FROM         dbo.re_expedientes_campostrazables INNER JOIN
						  dbo.ca_campostrazables ON dbo.re_expedientes_campostrazables.id_campotrazable = dbo.ca_campostrazables.id
	WHERE     (dbo.re_expedientes_campostrazables.id_expediente = @id_expediente)
	ORDER BY dbo.re_expedientes_campostrazables.es_principal DESC	
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesRegistradosporId_ma_digital]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 05 Septiembre 2013
-- Description:	Obtiene los campos trazables de un tramite registrado
-- =============================================
CREATE PROCEDURE [dbo].[pa_CampostrazablesRegistradosporId_ma_digital]
	@id_ma_digital int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     dbo.de_digital_campostrazables.id_re_expediente_campotrazable, dbo.re_expedientes_campostrazables.id_campotrazable, dbo.ca_campostrazables.Nombre, 
                      dbo.ca_campostrazables.Tamanio_Caracteres, dbo.re_expedientes_campostrazables.id_estatus, dbo.ca_campostrazables.Mascara, 
                      dbo.re_expedientes_campostrazables.es_principal, dbo.de_digital_campostrazables.valor_trazable
	FROM         dbo.de_digital_campostrazables INNER JOIN
						  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
						  dbo.ca_campostrazables ON dbo.re_expedientes_campostrazables.id_campotrazable = dbo.ca_campostrazables.id
	WHERE     (dbo.de_digital_campostrazables.id_ma_digital = @id_ma_digital) AND (dbo.de_digital_campostrazables.id_estatus = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ClasificacionDocumentosporTramite]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 29 Agosto 1023
-- Description:	Obtiene lista de clasificacion de documentos asociados a determinado tràmite
-- =============================================
CREATE PROCEDURE [dbo].[pa_ClasificacionDocumentosporTramite]
	@id_tramite int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     dbo.re_tramites_clasificaciondocumentos.id, dbo.re_tramites_clasificaciondocumentos.id_clasificaciondocumento, dbo.ca_clasificaciondocumentos.Descripcion
	FROM         dbo.re_tramites_clasificaciondocumentos INNER JOIN
						  dbo.ca_clasificaciondocumentos ON dbo.re_tramites_clasificaciondocumentos.id_clasificaciondocumento = dbo.ca_clasificaciondocumentos.id
	WHERE     (dbo.re_tramites_clasificaciondocumentos.id_tramie = @id_tramite)
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ObtenerDocumentosporTramiteyOrigen]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 16 Agosto 2013
-- Edit date:	29 Agosto 2013
-- Description:	Obtiene la lista de documentos por tramite y origen
-- =============================================
CREATE PROCEDURE [dbo].[pa_ObtenerDocumentosporTramiteyOrigen]
	@id_tramite int,
	@id_origen int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     TOP (100) PERCENT dbo.re_clasificaciondocumentos_documentos.id AS id_re_clasificaciondocumentos_documentos, 
                      dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento, dbo.ca_clasificaciondocumentos.Descripcion AS Descripcion_clasificaciondocumento, 
                      dbo.re_clasificaciondocumentos_documentos.id_documento, dbo.ca_documentos.Nombre, dbo.ca_documentos.Trazabilidad, 
                      dbo.re_clasificaciondocumentos_documentos.obligatorio, dbo.re_clasificaciondocumentos_documentos.orden, dbo.ca_documentos.Tamanio_Caracteres_Trazables, 
                      dbo.ca_documentos.Mascara_Trazable
	FROM         dbo.re_tramites_clasificaciondocumentos INNER JOIN
						  dbo.re_clasificaciondocumentos_documentos ON 
						  dbo.re_tramites_clasificaciondocumentos.id_clasificaciondocumento = dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento INNER JOIN
						  dbo.ca_documentos ON dbo.re_clasificaciondocumentos_documentos.id_documento = dbo.ca_documentos.id INNER JOIN
						  dbo.ca_clasificaciondocumentos ON dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento = dbo.ca_clasificaciondocumentos.id
	WHERE     (dbo.re_tramites_clasificaciondocumentos.id_tramie = @id_tramite) AND (dbo.re_clasificaciondocumentos_documentos.id_origen = @id_origen)
	ORDER BY dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento, dbo.re_clasificaciondocumentos_documentos.id_origen, 
						  dbo.re_clasificaciondocumentos_documentos.orden


	/*SELECT     TOP (100) PERCENT dbo.re_tramites_re_clasificaciondocumentos_documentos.id AS id_re_tramites_re_clasificaciondocumentos_documentos, 
                      dbo.re_tramites_re_clasificaciondocumentos_documentos.id_tramite, dbo.ca_tramites.Nombre AS Tramite, dbo.ca_tramites.id_ClasificacionTramite, 
                      dbo.ca_clasificaciontramites.Descripcion AS clasificaciontramite, dbo.re_tramites_re_clasificaciondocumentos_documentos.re_clasificaciondocumento_documento, 
                      dbo.re_tramites_re_clasificaciondocumentos_documentos.id_origen, dbo.ca_origenes.Descripcion AS Origen, 
                      dbo.re_tramites_re_clasificaciondocumentos_documentos.Orden, dbo.re_tramites_re_clasificaciondocumentos_documentos.Obligatorio, 
                      dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento, dbo.ca_clasificaciondocumentos.Descripcion AS Descripcion_clasificaciondocumento, 
                      dbo.re_clasificaciondocumentos_documentos.id_documento, dbo.ca_documentos.Nombre, dbo.ca_documentos.id_Formato, 
                      dbo.ca_formatos.Descripcion AS Descripcion_formato, dbo.ca_documentos.No_Hojas, dbo.ca_documentos.No_Caras, dbo.ca_documentos.Estado, 
                      CASE WHEN (dbo.ca_documentos.Estado = 0) THEN 'Original' WHEN (dbo.ca_documentos.Estado = 1) THEN 'Copia' END AS Descripcion_Estado, 
                      dbo.ca_documentos.Resguardo, dbo.ca_documentos.Tiempo_Resguardo, dbo.ca_documentos.Trazabilidad, dbo.ca_documentos.Tamanio_Caracteres_Trazables, 
                      dbo.ca_documentos.Mascara_Trazable, dbo.ca_documentos.Politica, dbo.re_clasificaciondocumentos_documentos.id_estatus, 
                      dbo.ca_estatus.Descripcion AS Descripcion_estatus
	FROM         dbo.re_clasificaciondocumentos_documentos INNER JOIN
						  dbo.ca_clasificaciondocumentos ON dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento = dbo.ca_clasificaciondocumentos.id INNER JOIN
						  dbo.ca_formatos INNER JOIN
						  dbo.ca_documentos ON dbo.ca_formatos.id = dbo.ca_documentos.id_Formato ON 
						  dbo.re_clasificaciondocumentos_documentos.id_documento = dbo.ca_documentos.id INNER JOIN
						  dbo.ca_estatus ON dbo.re_clasificaciondocumentos_documentos.id_estatus = dbo.ca_estatus.id INNER JOIN
						  dbo.re_tramites_re_clasificaciondocumentos_documentos ON 
						  dbo.re_clasificaciondocumentos_documentos.id = dbo.re_tramites_re_clasificaciondocumentos_documentos.re_clasificaciondocumento_documento INNER JOIN
						  dbo.ca_tramites ON dbo.ca_estatus.id = dbo.ca_tramites.id_estatus AND 
						  dbo.re_tramites_re_clasificaciondocumentos_documentos.id_tramite = dbo.ca_tramites.id INNER JOIN
						  dbo.ca_clasificaciontramites ON dbo.ca_tramites.id_ClasificacionTramite = dbo.ca_clasificaciontramites.id INNER JOIN
						  dbo.ca_origenes ON dbo.re_tramites_re_clasificaciondocumentos_documentos.id_origen = dbo.ca_origenes.id
	WHERE     (dbo.re_clasificaciondocumentos_documentos.id_estatus = 1) AND (dbo.re_tramites_re_clasificaciondocumentos_documentos.id_tramite = @id_tramite) AND 
						  (dbo.re_tramites_re_clasificaciondocumentos_documentos.id_origen = @id_origen)
	ORDER BY dbo.re_tramites_re_clasificaciondocumentos_documentos.id_tramite, dbo.re_tramites_re_clasificaciondocumentos_documentos.id_origen, 
						  dbo.re_tramites_re_clasificaciondocumentos_documentos.Orden*/
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ClasificacionDocumentosNoEnlazadosporTramite]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 30 Agosto 1023
-- Description:	Obtiene lista de clasificacion de documentos no asociados a determinado tràmite
-- =============================================
CREATE PROCEDURE [dbo].[pa_ClasificacionDocumentosNoEnlazadosporTramite]
	@id_tramite int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     id,Descripcion
	FROM       DBO.CA_CLASIFICACIONDOCUMENTOS
	WHERE ID NOT IN (
		SELECT ID_CLASIFICACIONDOCUMENTO FROM DBO.RE_TRAMITES_CLASIFICACIONDOCUMENTOS
		WHERE ID_TRAMIE = @id_tramite
	)
END
GO
/****** Object:  Trigger [TR_ca_clasificaciondocumentos_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_clasificaciondocumentos_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_clasificaciondocumentos_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_formatos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_formatos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_formatos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  StoredProcedure [dbo].[pa_DocumentosNoEnlazadosporClasificacionDocumento]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 28 Agosto 1023
-- Description:	Obtiene lista de documentos que no se encuentren asignados a una clasificacion de documento
-- =============================================
CREATE PROCEDURE [dbo].[pa_DocumentosNoEnlazadosporClasificacionDocumento]
	@id_clasificacion int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT     DBO.CA_DOCUMENTOS.ID, DBO.CA_DOCUMENTOS.NOMBRE, DBO.CA_DOCUMENTOS.ID_FORMATO, DBO.CA_FORMATOS.DESCRIPCION AS FORMATO, DBO.CA_DOCUMENTOS.NO_HOJAS, 
                      DBO.CA_DOCUMENTOS.NO_CARAS, DBO.CA_DOCUMENTOS.ESTADO, 
                      CASE WHEN (DBO.CA_DOCUMENTOS.ESTADO = 1) THEN 'ORIGINAL'
						   WHEN (DBO.CA_DOCUMENTOS.ESTADO = 2) THEN 'COPIA'
					  END AS DESCRIPCIONESTADO,
                      DBO.CA_DOCUMENTOS.RESGUARDO, DBO.CA_DOCUMENTOS.TIEMPO_RESGUARDO, 
                      DBO.CA_DOCUMENTOS.TRAZABILIDAD, DBO.CA_DOCUMENTOS.TAMANIO_CARACTERES_TRAZABLES, DBO.CA_DOCUMENTOS.MASCARA_TRAZABLE, DBO.CA_DOCUMENTOS.POLITICA                      
	FROM       DBO.CA_DOCUMENTOS INNER JOIN
               DBO.CA_FORMATOS ON DBO.CA_DOCUMENTOS.ID_FORMATO = DBO.CA_FORMATOS.ID	
	WHERE DBO.CA_DOCUMENTOS.ID NOT IN (
		SELECT RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS.ID_DOCUMENTO
		FROM RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
		WHERE RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS.ID_CLASIFICACIONDOCUMENTO = @id_clasificacion
	)
END
GO
/****** Object:  StoredProcedure [dbo].[pa_RolesporIdUsuario]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 02 Septiembre 2013
-- Description:	Obtiene por id de usuario, la lista de roles asignados y no asignados a al mismo
-- =============================================
CREATE PROCEDURE [dbo].[pa_RolesporIdUsuario]
	@id_usuario int
AS
BEGIN
	SET NOCOUNT ON;
	(SELECT	CA_ROLES.ID,
		CA_ROLES.DESCRIPCION,
		0 AS ENLAZADO
	FROM
			CA_ROLES
	WHERE
			ID NOT IN (SELECT ID_ROL FROM RE_USUARIOS_ROLES_PERMISOS WHERE ID_USUARIO = @id_usuario)
	UNION
	SELECT  dbo.ca_roles.id AS id, 
			dbo.ca_roles.Descripcion,
			1 AS ENLAZADO
	FROM    
			RE_USUARIOS_ROLES_PERMISOS 
	INNER JOIN
			CA_ROLES
		ON 
			RE_USUARIOS_ROLES_PERMISOS.ID_ROL = CA_ROLES.ID
	WHERE     
			RE_USUARIOS_ROLES_PERMISOS.ID_USUARIO = @id_usuario)
	ORDER BY DESCRIPCION
END
GO
/****** Object:  Trigger [TR_ca_roles_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_roles_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_roles_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  StoredProcedure [dbo].[pa_ReferenciaExpedientesparaBloquearDesbloquear]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 13 Septiembre 2013
-- Description:	Obtiene el/los expedientes
-- =============================================
CREATE PROCEDURE [dbo].[pa_ReferenciaExpedientesparaBloquearDesbloquear]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT        TOP (100) PERCENT dbo.ma_digital.id, dbo.ma_digital.nota, dbo.ma_digital.fecha_hora_bloqueo, dbo.ma_digital.fecha_hora_creacion, dbo.ma_digital.id_estatus, 
                         dbo.ca_estatus.Descripcion AS estatus, dbo.de_digital_campostrazables.valor_trazable, dbo.re_expedientes_tramites.id_tramite, 
                         dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente
	FROM            dbo.de_digital_campostrazables INNER JOIN
							 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
							 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
							 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
							 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
							 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id INNER JOIN
							 dbo.ca_estatus ON dbo.ma_digital.id_estatus = dbo.ca_estatus.id
	WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (dbo.ma_digital.id_estatus <> 9)
	ORDER BY dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_bloqueo, dbo.ma_digital.fecha_hora_creacion
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ReferenciaExpedientesporValorTrazable]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 03 Septiembre 2013
-- Description:	Obtiene el/los expedientes a partir del valor trazable principal
-- =============================================
CREATE PROCEDURE [dbo].[pa_ReferenciaExpedientesporValorTrazable]
	@valor_trazable varchar(200)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.de_digital_campostrazables.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                         dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
	FROM            dbo.de_digital_campostrazables INNER JOIN
							 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
							 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
							 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
							 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
							 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
	WHERE     (dbo.re_expedientes_campostrazables.es_principal = 1) AND (dbo.de_digital_campostrazables.id_estatus = 1) AND 
						  (lower(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus = 5)
	ORDER BY dbo.de_digital_campostrazables.fecha_hora_creacion DESC
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ReferenciaExpedientesporValorTrazableparaDeshacer]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 13 Septiembre 2013
-- Description:	Obtiene el/los expedientes a partir del valor trazable principal
-- =============================================
CREATE PROCEDURE [dbo].[pa_ReferenciaExpedientesporValorTrazableparaDeshacer]
	@valor_trazable varchar(200)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.de_digital_campostrazables.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                         dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
	FROM            dbo.de_digital_campostrazables INNER JOIN
							 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
							 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
							 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
							 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
							 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
	WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
	ORDER BY dbo.de_digital_campostrazables.fecha_hora_creacion DESC
END
GO
/****** Object:  Trigger [TR_ca_expedientes_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_expedientes_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_expedientes_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  View [dbo].[vw_ListaExpedientes]    Script Date: 09/25/2013 10:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ListaExpedientes]
AS
SELECT     id, Descripcion
FROM         dbo.ca_expedientes
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "ca_expedientes"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 95
               Right = 236
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
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaExpedientes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaExpedientes'
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporExpedienteyValorTrazable]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 20 Septiembre 2013
-- Description:	Obtiene el/los expedientes a partir del valor trazable principal
-- =============================================
CREATE PROCEDURE [dbo].[pa_ConsultaTramitesporExpedienteyValorTrazable]
	@id_expediente int,
	@valor_trazable varchar(200)	
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.de_digital_campostrazables.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                      dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
	FROM         dbo.de_digital_campostrazables INNER JOIN
						  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
						  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
						  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
						  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
						  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
	WHERE     (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
						  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
	ORDER BY dbo.de_digital_campostrazables.fecha_hora_creacion DESC
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporValorTrazable]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 20 Septiembre 2013
-- Description:	Obtiene el/los expedientes a partir del valor trazable principal
-- =============================================
CREATE PROCEDURE [dbo].[pa_ConsultaTramitesporValorTrazable]
	@valor_trazable varchar(200)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.de_digital_campostrazables.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                         dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
	FROM            dbo.de_digital_campostrazables INNER JOIN
							 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
							 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
							 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
							 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
							 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
	WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
	ORDER BY dbo.de_digital_campostrazables.fecha_hora_creacion DESC
END
GO
/****** Object:  Trigger [TR_ca_estatus_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_estatus_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_estatus_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_tiposbloqueos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_tiposbloqueos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_tiposbloqueos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_ca_tablas_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + nombre + '|' + 
					'DESCRIPCION~' + descripcion
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'NOMBRE~' + nombre + '|' + 
					'DESCRIPCION~' + descripcion
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
GO
/****** Object:  Trigger [TR_ca_tablas_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + nombre + '|' + 
					'DESCRIPCION~' + descripcion
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
GO
/****** Object:  Trigger [TR_ca_tablas_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + nombre + '|' + 
					'DESCRIPCION~' + descripcion
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
GO
/****** Object:  Trigger [TR_ca_usuarios_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'USUARIO~' + USUARIO + '|' +
					'CURP~' + CURP + '|' +
					'NOMBRES~' + NOMBRES + '|' +
					'APELLIDO1~' + APELLIDO1 + '|' +
					'APELLIDO2~' + APELLIDO2 + '|' +
					'ID_CARGO~' + CAST (id_cargo AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_ca_usuarios_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'USUARIO~' + USUARIO + '|' +
					'CURP~' + CURP + '|' +
					'NOMBRES~' + NOMBRES + '|' +
					'APELLIDO1~' + APELLIDO1 + '|' +
					'APELLIDO2~' + APELLIDO2 + '|' +
					'ID_CARGO~' + CAST (id_cargo AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'USUARIO~' + USUARIO + '|' +
					'CURP~' + CURP + '|' +
					'NOMBRES~' + NOMBRES + '|' +
					'APELLIDO1~' + APELLIDO1 + '|' +
					'APELLIDO2~' + APELLIDO2 + '|' +
					'ID_CARGO~' + CAST (id_cargo AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_CA_USUARIOS_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'USUARIO~' + USUARIO + '|' +
					'CURP~' + CURP + '|' +
					'NOMBRES~' + NOMBRES + '|' +
					'APELLIDO1~' + APELLIDO1 + '|' +
					'APELLIDO2~' + APELLIDO2 + '|' +
					'ID_CARGO~' + CAST (id_cargo AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_de_acciones_modulo_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_ROLES_MODULOS~' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + '|' +
					'ID_ACCCION~' + CAST (id_acccion AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_de_acciones_modulo_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_ROLES_MODULOS~' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + '|' +
					'ID_ACCCION~' + CAST (id_acccion AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_de_acciones_modulo_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_ROLES_MODULOS~' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + '|' +
					'ID_ACCCION~' + CAST (id_acccion AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_RE_ROLES_MODULOS~' + CAST (id_re_roles_modulos AS VARCHAR(MAX)) + '|' +
					'ID_ACCCION~' + CAST (id_acccion AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_de_digital_campostrazables_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_EXPEDIENTE_CAMPOTRAZABLE~' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))	
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_EXPEDIENTE_CAMPOTRAZABLE~' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))	
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
GO
/****** Object:  Trigger [TR_de_digital_campostrazables_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_EXPEDIENTE_CAMPOTRAZABLE~' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_de_digital_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_de_digital_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))	
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))	
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
GO
/****** Object:  Trigger [TR_de_digital_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_CLASIFICACIONDOCUMENTO_DOCUMENTO~' + CAST (id_re_clasificaciondocumento_documento AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_de_digital_campostrazables_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_MA_DIGITAL~' + CAST (id_ma_digital AS VARCHAR(MAX)) + '|' +
					'ID_RE_EXPEDIENTE_CAMPOTRAZABLE~' + CAST (id_re_expediente_campotrazable AS VARCHAR(MAX)) + '|' +
					'VALOR_TRAZABLE~' + valor_trazable + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_ma_digital_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_BLOQUEO~' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_BLOQUEO~' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))	
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
GO
/****** Object:  Trigger [TR_ma_digital_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_BLOQUEO~' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_clasificaciondocumentos_documentos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + '|' +
					'ID_DOCUMENTO~' + CAST (id_documento AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX)) + '|' +
					'ID_ORIGEN~' + CAST (id_origen AS VARCHAR(MAX)) + '|' +
					'ORDEN~' + CAST (orden AS VARCHAR(MAX)) + '|' +
					'OBLIGATORIO~' + CAST (obligatorio AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_ma_digital_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_CREACION~' + CAST (fecha_hora_creacion AS VARCHAR(MAX)) + '|' +
					'FECHA_HORA_BLOQUEO~' + CAST (fecha_hora_bloqueo AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_ca_documentos_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'ID_FORMATO~' + CAST(id_Formato AS varchar(MAX))  + '|' + 
					'NO_HOJAS~' + CAST(No_Hojas AS varchar(MAX))  + '|' + 
					'NO_CARAS~' + CAST(No_Caras AS varchar(MAX))  + '|' + 
					'ESTADO~' + CAST(Estado AS varchar(MAX))  + '|' + 
					'RESGUARDO~' + CAST(Resguardo AS varchar(MAX))  + '|' + 
					'TIEMPO_RESGUARDO~' + CAST(Tiempo_Resguardo AS varchar(MAX))  + '|' + 
					'TRAZABILIDAD~' + CAST(Trazabilidad AS varchar(MAX))  + '|' + 
					'TAMANIO_CARACTERES_TRAZABLES~' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + '|' + 
					'MASCARA_TRAZABLE~' + Mascara_Trazable +'|' + 
					'POLITICA~' + Politica
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
GO
/****** Object:  Trigger [TR_ca_documentos_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'ID_FORMATO~' + CAST(id_Formato AS varchar(MAX))  + '|' + 
					'NO_HOJAS~' + CAST(No_Hojas AS varchar(MAX))  + '|' + 
					'NO_CARAS~' + CAST(No_Caras AS varchar(MAX))  + '|' + 
					'ESTADO~' + CAST(Estado AS varchar(MAX))  + '|' + 
					'RESGUARDO~' + CAST(Resguardo AS varchar(MAX))  + '|' + 
					'TIEMPO_RESGUARDO~' + CAST(Tiempo_Resguardo AS varchar(MAX))  + '|' + 
					'TRAZABILIDAD~' + CAST(Trazabilidad AS varchar(MAX))  + '|' + 
					'TAMANIO_CARACTERES_TRAZABLES~' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + '|' + 
					'MASCARA_TRAZABLE~' + Mascara_Trazable +'|' + 
					'POLITICA~' + Politica
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'NOMBRE~' + Nombre + '|' + 
					'ID_FORMATO~' + CAST(id_Formato AS varchar(MAX))  + '|' + 
					'NO_HOJAS~' + CAST(No_Hojas AS varchar(MAX))  + '|' + 
					'NO_CARAS~' + CAST(No_Caras AS varchar(MAX))  + '|' + 
					'ESTADO~' + CAST(Estado AS varchar(MAX))  + '|' + 
					'RESGUARDO~' + CAST(Resguardo AS varchar(MAX))  + '|' + 
					'TIEMPO_RESGUARDO~' + CAST(Tiempo_Resguardo AS varchar(MAX))  + '|' + 
					'TRAZABILIDAD~' + CAST(Trazabilidad AS varchar(MAX))  + '|' + 
					'TAMANIO_CARACTERES_TRAZABLES~' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + '|' + 
					'MASCARA_TRAZABLE~' + Mascara_Trazable +'|' + 
					'POLITICA~' + Politica
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
GO
/****** Object:  Trigger [TR_ca_documentos_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'ID_FORMATO~' + CAST(id_Formato AS varchar(MAX))  + '|' + 
					'NO_HOJAS~' + CAST(No_Hojas AS varchar(MAX))  + '|' + 
					'NO_CARAS~' + CAST(No_Caras AS varchar(MAX))  + '|' + 
					'ESTADO~' + CAST(Estado AS varchar(MAX))  + '|' + 
					'RESGUARDO~' + CAST(Resguardo AS varchar(MAX))  + '|' + 
					'TIEMPO_RESGUARDO~' + CAST(Tiempo_Resguardo AS varchar(MAX))  + '|' + 
					'TRAZABILIDAD~' + CAST(Trazabilidad AS varchar(MAX))  + '|' + 
					'TAMANIO_CARACTERES_TRAZABLES~' + CAST(Tamanio_Caracteres_Trazables AS varchar(MAX))  + '|' + 
					'MASCARA_TRAZABLE~' + Mascara_Trazable +'|' + 
					'POLITICA~' + Politica
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
GO
/****** Object:  Trigger [TR_re_usuarios_roles_permisos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_USUARIO~' + CAST (id_usuario AS VARCHAR(MAX)) + '|' +
					'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_USUARIO~' + CAST (id_usuario AS VARCHAR(MAX)) + '|' +
					'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_usuarios_roles_permisos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_USUARIO~' + CAST (id_usuario AS VARCHAR(MAX)) + '|' +
					'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_tramites_clasificaciondocumentos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_TRAMIE~' + CAST (id_tramie AS VARCHAR(MAX)) + '|' +
					'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_tramites_clasificaciondocumentos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_TRAMIE~' + CAST (id_tramie AS VARCHAR(MAX)) + '|' +
					'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_re_usuarios_roles_permisos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_USUARIO~' + CAST (id_usuario AS VARCHAR(MAX)) + '|' +
					'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_re_tramites_clasificaciondocumentos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_TRAMIE~' + CAST (id_tramie AS VARCHAR(MAX)) + '|' +
					'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_TRAMIE~' + CAST (id_tramie AS VARCHAR(MAX)) + '|' +
					'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_CA_CARGO_PUESTO_DELETE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_CA_CARGO_PUESTO_UPDATE]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_tbl_configuraciones_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'DESCRIPCION~' + Descripcion + '|' +
					'VALOR~' + Valor
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
GO
/****** Object:  Trigger [TR_tbl_configuraciones_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'DESCRIPCION~' + Descripcion + '|' +
					'VALOR~' + Valor
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'DESCRIPCION~' + Descripcion + '|' +
					'VALOR~' + Valor
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
GO
/****** Object:  Trigger [TR_CA_CARGO_PUESTO_INSERT]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES = 'DESCRIPCION~' + DESCRIPCION
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
GO
/****** Object:  Trigger [TR_tbl_configuraciones_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'DESCRIPCION~' + Descripcion + '|' +
					'VALOR~' + Valor

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
GO
/****** Object:  Trigger [TR_re_roles_modulos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX)) + '|' +
					'ID_MODULO~' + CAST (id_modulo AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_re_expedientestramites_tiposbloqueos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'ID_TIPOBLOQUEO~' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + '|' +
					'NO_HORAS~' + CAST (no_horas AS VARCHAR(MAX)) + '|' +
					'NO_DIAS~' + CAST (no_dias AS VARCHAR(MAX))		
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'ID_TIPOBLOQUEO~' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + '|' +
					'NO_HORAS~' + CAST (no_horas AS VARCHAR(MAX)) + '|' +
					'NO_DIAS~' + CAST (no_dias AS VARCHAR(MAX))		
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
GO
/****** Object:  Trigger [TR_re_expedientestramites_tiposbloqueos_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'ID_TIPOBLOQUEO~' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + '|' +
					'NO_HORAS~' + CAST (no_horas AS VARCHAR(MAX)) + '|' +
					'NO_DIAS~' + CAST (no_dias AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_ca_tramites_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'DESCRIPCION~' + Descripcion + '|' + 
					'DESCRIPCION_BREVE~' + Descripcion_Breve + '|' + 
					'ALCANCE_INICIAL~' + Alcance_Inicial + '|' + 
					'ALCANCE_FINAL~' + Alcance_Final + '|' + 
					'ID_CLASIFICACIONTRAMITE~' + CAST(id_ClasificacionTramite AS varchar(MAX))  + '|' + 
					'ID_ESTATUS~' + CAST(id_estatus AS varchar(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'NOMBRE~' + Nombre + '|' + 
					'DESCRIPCION~' + Descripcion + '|' + 
					'DESCRIPCION_BREVE~' + Descripcion_Breve + '|' + 
					'ALCANCE_INICIAL~' + Alcance_Inicial + '|' + 
					'ALCANCE_FINAL~' + Alcance_Final + '|' + 
					'ID_CLASIFICACIONTRAMITE~' + CAST(id_ClasificacionTramite AS varchar(MAX))  + '|' + 
					'ID_ESTATUS~' + CAST(id_estatus AS varchar(MAX))
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
GO
/****** Object:  Trigger [TR_re_expedientes_tramites_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_TRAMITE~' + CAST (id_tramite AS VARCHAR(MAX))		
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
GO
/****** Object:  Trigger [TR_re_expedientes_tramites_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_TRAMITE~' + CAST (id_tramite AS VARCHAR(MAX))		
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_TRAMITE~' + CAST (id_tramite AS VARCHAR(MAX))		
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
GO
/****** Object:  Trigger [TR_re_expedientes_tramites_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_TRAMITE~' + CAST (id_tramite AS VARCHAR(MAX))		

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
GO
/****** Object:  Trigger [TR_re_expedientes_campostrazables_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_CAMPOTRAZABLE~' + CAST (id_campotrazable AS VARCHAR(MAX)) + '|' +
					'ES_PRINCIPAL~' + CAST (es_principal AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_CAMPOTRAZABLE~' + CAST (id_campotrazable AS VARCHAR(MAX)) + '|' +
					'ES_PRINCIPAL~' + CAST (es_principal AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_expedientestramites_tiposbloqueos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_RE_EXPEDIENTE_TRAMITE~' + CAST (id_re_expediente_tramite AS VARCHAR(MAX)) + '|' +
					'ID_TIPOBLOQUEO~' + CAST (id_tipobloqueo AS VARCHAR(MAX)) + '|' +
					'NO_HORAS~' + CAST (no_horas AS VARCHAR(MAX)) + '|' +
					'NO_DIAS~' + CAST (no_dias AS VARCHAR(MAX))		
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
GO
/****** Object:  Trigger [TR_re_roles_modulos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX)) + '|' +
					'ID_MODULO~' + CAST (id_modulo AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX)) + '|' +
					'ID_MODULO~' + CAST (id_modulo AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_roles_modulos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_ROL~' + CAST (id_rol AS VARCHAR(MAX)) + '|' +
					'ID_MODULO~' + CAST (id_modulo AS VARCHAR(MAX))	
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
GO
/****** Object:  Trigger [TR_re_expedientes_campostrazables_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_CAMPOTRAZABLE~' + CAST (id_campotrazable AS VARCHAR(MAX)) + '|' +
					'ES_PRINCIPAL~' + CAST (es_principal AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_clasificaciondocumentos_documentos_UPDATE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + '|' +
					'ID_DOCUMENTO~' + CAST (id_documento AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX)) + '|' +
					'ID_ORIGEN~' + CAST (id_origen AS VARCHAR(MAX)) + '|' +
					'ORDEN~' + CAST (orden AS VARCHAR(MAX)) + '|' +
					'OBLIGATORIO~' + CAST (obligatorio AS VARCHAR(MAX))
					
	FROM INSERTED			
	
	SELECT 
		@VALORES_ANTERIORES =	'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + '|' +
					'ID_DOCUMENTO~' + CAST (id_documento AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX)) + '|' +
					'ID_ORIGEN~' + CAST (id_origen AS VARCHAR(MAX)) + '|' +
					'ORDEN~' + CAST (orden AS VARCHAR(MAX)) + '|' +
					'OBLIGATORIO~' + CAST (obligatorio AS VARCHAR(MAX))	
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
GO
/****** Object:  Trigger [TR_ca_tramites_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'DESCRIPCION~' + Descripcion + '|' + 
					'DESCRIPCION_BREVE~' + Descripcion_Breve + '|' + 
					'ALCANCE_INICIAL~' + Alcance_Inicial + '|' + 
					'ALCANCE_FINAL~' + Alcance_Final + '|' + 
					'ID_CLASIFICACIONTRAMITE~' + CAST(id_ClasificacionTramite AS varchar(MAX))  + '|' + 
					'ID_ESTATUS~' + CAST(id_estatus AS varchar(MAX))
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
GO
/****** Object:  Trigger [TR_ca_tramites_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'NOMBRE~' + Nombre + '|' + 
					'DESCRIPCION~' + Descripcion + '|' + 
					'DESCRIPCION_BREVE~' + Descripcion_Breve + '|' + 
					'ALCANCE_INICIAL~' + Alcance_Inicial + '|' + 
					'ALCANCE_FINAL~' + Alcance_Final + '|' + 
					'ID_CLASIFICACIONTRAMITE~' + CAST(id_ClasificacionTramite AS varchar(MAX))  + '|' + 
					'ID_ESTATUS~' + CAST(id_estatus AS varchar(MAX))
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
GO
/****** Object:  Trigger [TR_re_clasificaciondocumentos_documentos_DELETE]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_CLASIFICACIONDOCUMENTO~' + CAST (id_clasificaciondocumento AS VARCHAR(MAX)) + '|' +
					'ID_DOCUMENTO~' + CAST (id_documento AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX)) + '|' +
					'ID_ORIGEN~' + CAST (id_origen AS VARCHAR(MAX)) + '|' +
					'ORDEN~' + CAST (orden AS VARCHAR(MAX)) + '|' +
					'OBLIGATORIO~' + CAST (obligatorio AS VARCHAR(MAX))
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
GO
/****** Object:  Trigger [TR_re_expedientes_campostrazables_INSERT]    Script Date: 09/25/2013 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
		@VALORES =	'ID_EXPEDIENTE~' + CAST (id_expediente AS VARCHAR(MAX)) + '|' +
					'ID_CAMPOTRAZABLE~' + CAST (id_campotrazable AS VARCHAR(MAX)) + '|' +
					'ES_PRINCIPAL~' + CAST (es_principal AS VARCHAR(MAX)) + '|' +
					'ID_ESTATUS~' + CAST (id_estatus AS VARCHAR(MAX))		

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
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporordenmenor]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 30 Agosto 2013
-- Description:	Reacomoda orden de documentos por su clasificacion cuando un documento ha sido cambiado de orden a uno menor
-- =============================================
CREATE PROCEDURE [dbo].[pa_ordenaporordenmenor]
	@ID_CLASIFICACIONDOCUMENTO INT,
	@ID_ORIGEN INT,
	@ORDENDEPARTIDA INT,
	@ORDENDEFIN INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRY
    BEGIN TRANSACTION
		    DECLARE @ID INT
			SELECT @ID = ID FROM DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS WHERE ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO AND ID_ORIGEN = @ID_ORIGEN AND ORDEN = @ORDENDEFIN
    
			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET ORDEN = ORDEN + 1
			WHERE ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO
			AND ID_ORIGEN = @ID_ORIGEN
			AND ORDEN >= @ORDENDEPARTIDA AND ORDEN < @ORDENDEFIN

			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET ORDEN = @ORDENDEPARTIDA
			WHERE ID = @ID
		COMMIT
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
	END CATCH			
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporborrado]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 09 Septiembre 2013
-- Description:	Reacomoda orden de documentos por su clasificacion cuando un documento ha sido borrado
-- =============================================
CREATE PROCEDURE [dbo].[pa_ordenaporborrado]
	@ID INT	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	BEGIN TRY
    BEGIN TRANSACTION     
			DECLARE @ID_CLASIFICACIONDOCUMENTO INT
			DECLARE @ID_ORIGEN INT
			DECLARE @ORDEN INT
			SELECT 
				@ID_CLASIFICACIONDOCUMENTO = ID_CLASIFICACIONDOCUMENTO, 
				@ID_ORIGEN =ID_ORIGEN,
				@ORDEN = ORDEN
			FROM 
				DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS 
			WHERE 
				ID = @ID

			DELETE FROM 
				DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			WHERE 
				ID = @ID

			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET 
				ORDEN = ORDEN - 1
			WHERE 
				ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO
			  AND 
				ID_ORIGEN = @ID_ORIGEN
			  AND 
				ORDEN > @ORDEN
		COMMIT
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
	END CATCH	
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporcambiodeorigen]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 30 Agosto 2013
-- Description:	Reacomoda orden de documentos por su clasificacion cuando un documento ha sido cambiado de origen
-- =============================================
CREATE PROCEDURE [dbo].[pa_ordenaporcambiodeorigen]
	@ID_CLASIFICACIONDOCUMENTO INT,
	@ID_ORIGEN INT,
	@ORDENDEPARTIDA INT,
	@ID_NUEVOORIGEN INT	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	BEGIN TRY
    BEGIN TRANSACTION 
			DECLARE @ORDENDEORIGEN SMALLINT
			SELECT @ORDENDEORIGEN = MAX (ORDEN) FROM RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS WHERE (ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO) AND (ID_ORIGEN = @ID_NUEVOORIGEN)
			IF @ORDENDEORIGEN IS NULL BEGIN
				SET @ORDENDEORIGEN = 1
			END
			ELSE BEGIN
				SET @ORDENDEORIGEN = @ORDENDEORIGEN + 1
			END
								
			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET ORDEN = @ORDENDEORIGEN,
				ID_ORIGEN = @ID_NUEVOORIGEN	
			WHERE ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO
			AND ID_ORIGEN = @ID_ORIGEN
			AND ORDEN = @ORDENDEPARTIDA


			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET ORDEN = ORDEN - 1
			WHERE ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO
			AND ID_ORIGEN = @ID_ORIGEN
			AND ORDEN > @ORDENDEPARTIDA
		COMMIT
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
	END CATCH	
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporordenmayor]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 30 Agosto 2013
-- Description:	Reacomoda orden de documentos por su clasificacion cuando un documento ha sido cambiado de orden a uno mayor
-- =============================================
CREATE PROCEDURE [dbo].[pa_ordenaporordenmayor]
	@ID_CLASIFICACIONDOCUMENTO INT,
	@ID_ORIGEN INT,
	@ORDENDEPARTIDA INT,
	@ORDENDEFIN INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRY
    BEGIN TRANSACTION 
			DECLARE @ID INT
			SELECT @ID = ID FROM DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS WHERE ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO AND ID_ORIGEN = @ID_ORIGEN AND ORDEN = @ORDENDEPARTIDA

			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET ORDEN = ORDEN - 1
			WHERE ID_CLASIFICACIONDOCUMENTO = @ID_CLASIFICACIONDOCUMENTO
			AND ID_ORIGEN = @ID_ORIGEN
			AND ORDEN > @ORDENDEPARTIDA AND ORDEN <= @ORDENDEFIN

			UPDATE DBO.RE_CLASIFICACIONDOCUMENTOS_DOCUMENTOS
			SET ORDEN = @ORDENDEFIN
			WHERE ID = @ID
		COMMIT
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
	END CATCH	
END
GO
/****** Object:  StoredProcedure [dbo].[pa_InactivaDe_DigitalporId]    Script Date: 09/25/2013 10:36:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 10 Septiembre 2013
-- Description:	Inactiva un archivo digital a partir del id
-- =============================================
CREATE PROCEDURE [dbo].[pa_InactivaDe_DigitalporId]
	@id int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [DBO].[DE_DIGITAL]
	SET [ID_ESTATUS] = 2
	WHERE [ID] = @ID
END
GO
/****** Object:  Default [DF_de_digital_fecha_hora_creacion]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital] ADD  CONSTRAINT [DF_de_digital_fecha_hora_creacion]  DEFAULT (getdate()) FOR [fecha_hora_creacion]
GO
/****** Object:  Default [DF_de_digital_campostrazables_fecha_hora_creacion]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital_campostrazables] ADD  CONSTRAINT [DF_de_digital_campostrazables_fecha_hora_creacion]  DEFAULT (getdate()) FOR [fecha_hora_creacion]
GO
/****** Object:  Default [DF_hco_cambios_id_usuario]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[hco_cambios] ADD  CONSTRAINT [DF_hco_cambios_id_usuario]  DEFAULT (user_id(user_name())) FOR [id_usuario]
GO
/****** Object:  Default [DF_hco_cambios_fecha]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[hco_cambios] ADD  CONSTRAINT [DF_hco_cambios_fecha]  DEFAULT (getdate()) FOR [fecha]
GO
/****** Object:  Default [DF_ma_digital_fecha_hora_creacion]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ma_digital] ADD  CONSTRAINT [DF_ma_digital_fecha_hora_creacion]  DEFAULT (getdate()) FOR [fecha_hora_creacion]
GO
/****** Object:  Default [DF_re_clasificaciondocumentos_documentos_orden]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] ADD  CONSTRAINT [DF_re_clasificaciondocumentos_documentos_orden]  DEFAULT ((0)) FOR [orden]
GO
/****** Object:  Default [DF_re_expedientes_campostrazables_es_principal]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientes_campostrazables] ADD  CONSTRAINT [DF_re_expedientes_campostrazables_es_principal]  DEFAULT ((0)) FOR [es_principal]
GO
/****** Object:  Default [DF_tbl_errorlogs_fechahora]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[tbl_errorlogs] ADD  CONSTRAINT [DF_tbl_errorlogs_fechahora]  DEFAULT (getdate()) FOR [fechahora]
GO
/****** Object:  ForeignKey [FK_ca_documentos_ca_formatos]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ca_documentos]  WITH CHECK ADD  CONSTRAINT [FK_ca_documentos_ca_formatos] FOREIGN KEY([id_Formato])
REFERENCES [dbo].[ca_formatos] ([id])
GO
ALTER TABLE [dbo].[ca_documentos] CHECK CONSTRAINT [FK_ca_documentos_ca_formatos]
GO
/****** Object:  ForeignKey [FK_ca_tramites_ca_clasificaciontramites]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ca_tramites]  WITH CHECK ADD  CONSTRAINT [FK_ca_tramites_ca_clasificaciontramites] FOREIGN KEY([id_ClasificacionTramite])
REFERENCES [dbo].[ca_clasificaciontramites] ([id])
GO
ALTER TABLE [dbo].[ca_tramites] CHECK CONSTRAINT [FK_ca_tramites_ca_clasificaciontramites]
GO
/****** Object:  ForeignKey [FK_ca_tramites_ca_estatus]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ca_tramites]  WITH CHECK ADD  CONSTRAINT [FK_ca_tramites_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
ALTER TABLE [dbo].[ca_tramites] CHECK CONSTRAINT [FK_ca_tramites_ca_estatus]
GO
/****** Object:  ForeignKey [FK_ca_usuarios_ca_cargo_puesto]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ca_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_ca_usuarios_ca_cargo_puesto] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[ca_cargo_puesto] ([id])
GO
ALTER TABLE [dbo].[ca_usuarios] CHECK CONSTRAINT [FK_ca_usuarios_ca_cargo_puesto]
GO
/****** Object:  ForeignKey [FK_de_acciones_modulo_ca_acciones]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_acciones_modulo]  WITH CHECK ADD  CONSTRAINT [FK_de_acciones_modulo_ca_acciones] FOREIGN KEY([id_acccion])
REFERENCES [dbo].[ca_acciones] ([id])
GO
ALTER TABLE [dbo].[de_acciones_modulo] CHECK CONSTRAINT [FK_de_acciones_modulo_ca_acciones]
GO
/****** Object:  ForeignKey [FK_de_digital_ca_estatus]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
ALTER TABLE [dbo].[de_digital] CHECK CONSTRAINT [FK_de_digital_ca_estatus]
GO
/****** Object:  ForeignKey [FK_de_digital_ma_digital1]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_ma_digital1] FOREIGN KEY([id_ma_digital])
REFERENCES [dbo].[ma_digital] ([id])
GO
ALTER TABLE [dbo].[de_digital] CHECK CONSTRAINT [FK_de_digital_ma_digital1]
GO
/****** Object:  ForeignKey [FK_de_digital_re_clasificaciondocumentos_documentos]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_re_clasificaciondocumentos_documentos] FOREIGN KEY([id_re_clasificaciondocumento_documento])
REFERENCES [dbo].[re_clasificaciondocumentos_documentos] ([id])
GO
ALTER TABLE [dbo].[de_digital] CHECK CONSTRAINT [FK_de_digital_re_clasificaciondocumentos_documentos]
GO
/****** Object:  ForeignKey [FK_de_digital_campostrazables_ca_estatus]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_campostrazables_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
ALTER TABLE [dbo].[de_digital_campostrazables] CHECK CONSTRAINT [FK_de_digital_campostrazables_ca_estatus]
GO
/****** Object:  ForeignKey [FK_de_digital_campostrazables_ma_digital]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_campostrazables_ma_digital] FOREIGN KEY([id_ma_digital])
REFERENCES [dbo].[ma_digital] ([id])
GO
ALTER TABLE [dbo].[de_digital_campostrazables] CHECK CONSTRAINT [FK_de_digital_campostrazables_ma_digital]
GO
/****** Object:  ForeignKey [FK_de_digital_campostrazables_re_expedientes_campostrazables]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[de_digital_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_de_digital_campostrazables_re_expedientes_campostrazables] FOREIGN KEY([id_re_expediente_campotrazable])
REFERENCES [dbo].[re_expedientes_campostrazables] ([id])
GO
ALTER TABLE [dbo].[de_digital_campostrazables] CHECK CONSTRAINT [FK_de_digital_campostrazables_re_expedientes_campostrazables]
GO
/****** Object:  ForeignKey [FK_hco_cambios_ca_acciones]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[hco_cambios]  WITH CHECK ADD  CONSTRAINT [FK_hco_cambios_ca_acciones] FOREIGN KEY([id_accion])
REFERENCES [dbo].[ca_acciones] ([id])
GO
ALTER TABLE [dbo].[hco_cambios] CHECK CONSTRAINT [FK_hco_cambios_ca_acciones]
GO
/****** Object:  ForeignKey [FK_hco_cambios_ca_tablas]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[hco_cambios]  WITH CHECK ADD  CONSTRAINT [FK_hco_cambios_ca_tablas] FOREIGN KEY([id_tabla])
REFERENCES [dbo].[ca_tablas] ([id])
GO
ALTER TABLE [dbo].[hco_cambios] CHECK CONSTRAINT [FK_hco_cambios_ca_tablas]
GO
/****** Object:  ForeignKey [FK_ma_digital_ca_estatus]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ma_digital]  WITH CHECK ADD  CONSTRAINT [FK_ma_digital_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
ALTER TABLE [dbo].[ma_digital] CHECK CONSTRAINT [FK_ma_digital_ca_estatus]
GO
/****** Object:  ForeignKey [FK_ma_digital_re_expedientes_tramites]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[ma_digital]  WITH CHECK ADD  CONSTRAINT [FK_ma_digital_re_expedientes_tramites] FOREIGN KEY([id_re_expediente_tramite])
REFERENCES [dbo].[re_expedientes_tramites] ([id])
GO
ALTER TABLE [dbo].[ma_digital] CHECK CONSTRAINT [FK_ma_digital_re_expedientes_tramites]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1] FOREIGN KEY([id_clasificaciondocumento])
REFERENCES [dbo].[ca_clasificaciondocumentos] ([id])
GO
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_clasificaciondocumentos1]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_documentos1]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_documentos1] FOREIGN KEY([id_documento])
REFERENCES [dbo].[ca_documentos] ([id])
GO
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_documentos1]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_estatus1]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_estatus1] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_estatus1]
GO
/****** Object:  ForeignKey [FK_re_clasificaciondocumentos_documentos_ca_origenes]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos]  WITH CHECK ADD  CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_origenes] FOREIGN KEY([id_origen])
REFERENCES [dbo].[ca_origenes] ([id])
GO
ALTER TABLE [dbo].[re_clasificaciondocumentos_documentos] CHECK CONSTRAINT [FK_re_clasificaciondocumentos_documentos_ca_origenes]
GO
/****** Object:  ForeignKey [FK_re_expedientes_campostrazables_ca_campostrazables]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientes_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_campostrazables_ca_campostrazables] FOREIGN KEY([id_campotrazable])
REFERENCES [dbo].[ca_campostrazables] ([id])
GO
ALTER TABLE [dbo].[re_expedientes_campostrazables] CHECK CONSTRAINT [FK_re_expedientes_campostrazables_ca_campostrazables]
GO
/****** Object:  ForeignKey [FK_re_expedientes_campostrazables_ca_estatus]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientes_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_campostrazables_ca_estatus] FOREIGN KEY([id_estatus])
REFERENCES [dbo].[ca_estatus] ([id])
GO
ALTER TABLE [dbo].[re_expedientes_campostrazables] CHECK CONSTRAINT [FK_re_expedientes_campostrazables_ca_estatus]
GO
/****** Object:  ForeignKey [FK_re_expedientes_campostrazables_ca_expedientes]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientes_campostrazables]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_campostrazables_ca_expedientes] FOREIGN KEY([id_expediente])
REFERENCES [dbo].[ca_expedientes] ([id])
GO
ALTER TABLE [dbo].[re_expedientes_campostrazables] CHECK CONSTRAINT [FK_re_expedientes_campostrazables_ca_expedientes]
GO
/****** Object:  ForeignKey [FK_re_expedientes_tramites_ca_expedientes]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientes_tramites]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_tramites_ca_expedientes] FOREIGN KEY([id_expediente])
REFERENCES [dbo].[ca_expedientes] ([id])
GO
ALTER TABLE [dbo].[re_expedientes_tramites] CHECK CONSTRAINT [FK_re_expedientes_tramites_ca_expedientes]
GO
/****** Object:  ForeignKey [FK_re_expedientes_tramites_ca_tramites]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientes_tramites]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientes_tramites_ca_tramites] FOREIGN KEY([id_tramite])
REFERENCES [dbo].[ca_tramites] ([id])
GO
ALTER TABLE [dbo].[re_expedientes_tramites] CHECK CONSTRAINT [FK_re_expedientes_tramites_ca_tramites]
GO
/****** Object:  ForeignKey [FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos] FOREIGN KEY([id_tipobloqueo])
REFERENCES [dbo].[ca_tiposbloqueos] ([id])
GO
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos] CHECK CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_ca_tiposbloqueos]
GO
/****** Object:  ForeignKey [FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos]  WITH CHECK ADD  CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites] FOREIGN KEY([id_re_expediente_tramite])
REFERENCES [dbo].[re_expedientes_tramites] ([id])
GO
ALTER TABLE [dbo].[re_expedientestramites_tiposbloqueos] CHECK CONSTRAINT [FK_re_expedientestramites_tiposbloqueos_re_expedientes_tramites]
GO
/****** Object:  ForeignKey [FK_re_roles_modulos_ca_modulos]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_roles_modulos]  WITH CHECK ADD  CONSTRAINT [FK_re_roles_modulos_ca_modulos] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[ca_modulos] ([id])
GO
ALTER TABLE [dbo].[re_roles_modulos] CHECK CONSTRAINT [FK_re_roles_modulos_ca_modulos]
GO
/****** Object:  ForeignKey [FK_re_roles_modulos_ca_roles]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_roles_modulos]  WITH CHECK ADD  CONSTRAINT [FK_re_roles_modulos_ca_roles] FOREIGN KEY([id_rol])
REFERENCES [dbo].[ca_roles] ([id])
GO
ALTER TABLE [dbo].[re_roles_modulos] CHECK CONSTRAINT [FK_re_roles_modulos_ca_roles]
GO
/****** Object:  ForeignKey [FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos]  WITH CHECK ADD  CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos] FOREIGN KEY([id_clasificaciondocumento])
REFERENCES [dbo].[ca_clasificaciondocumentos] ([id])
GO
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos] CHECK CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_clasificaciondocumentos]
GO
/****** Object:  ForeignKey [FK_re_tramites_clasificaciondocumentos_ca_tramites]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos]  WITH CHECK ADD  CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_tramites] FOREIGN KEY([id_tramie])
REFERENCES [dbo].[ca_tramites] ([id])
GO
ALTER TABLE [dbo].[re_tramites_clasificaciondocumentos] CHECK CONSTRAINT [FK_re_tramites_clasificaciondocumentos_ca_tramites]
GO
/****** Object:  ForeignKey [FK_re_usuarios_roles_permisos_ca_roles1]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_usuarios_roles_permisos]  WITH CHECK ADD  CONSTRAINT [FK_re_usuarios_roles_permisos_ca_roles1] FOREIGN KEY([id_rol])
REFERENCES [dbo].[ca_roles] ([id])
GO
ALTER TABLE [dbo].[re_usuarios_roles_permisos] CHECK CONSTRAINT [FK_re_usuarios_roles_permisos_ca_roles1]
GO
/****** Object:  ForeignKey [FK_re_usuarios_roles_permisos_ca_usuarios]    Script Date: 09/25/2013 10:36:22 ******/
ALTER TABLE [dbo].[re_usuarios_roles_permisos]  WITH CHECK ADD  CONSTRAINT [FK_re_usuarios_roles_permisos_ca_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[ca_usuarios] ([id])
GO
ALTER TABLE [dbo].[re_usuarios_roles_permisos] CHECK CONSTRAINT [FK_re_usuarios_roles_permisos_ca_usuarios]
GO
