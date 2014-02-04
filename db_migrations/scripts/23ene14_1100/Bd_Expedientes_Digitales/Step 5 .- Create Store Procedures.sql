USE [Bd_Expedientes_Digitales]
GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_fecha]    Script Date: 01/28/2014 11:16:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_obtener_fecha]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_fechahora]    Script Date: 01/28/2014 11:16:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_obtener_fechahora]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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

	SELECT CONVERT(VARCHAR(30),GETDATE()) AS FechaHora
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CreateLoginandUser]    Script Date: 01/28/2014 11:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CreateLoginandUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_CreateLoginandUser](
        @LOGIN VARCHAR(100),
        @PASSWORD VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = ''Bd_Exp_Transportes''

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)
DECLARE @SAFE_PASSWORD VARCHAR(200)

SET @SAFE_USER = ''..Bd_Exp_Transportes_'' + @LOGIN + ''..''
SET @SAFE_PASSWORD = @PASSWORD

DECLARE @SQL NVARCHAR(MAX)
SET @SQL =	''USE [master] '' +
			--''GO '' +
			''CREATE LOGIN ['' + @SAFE_USER + ''] '' +
			''WITH PASSWORD = '''''' + @SAFE_PASSWORD + '''''', '' +
			''DEFAULT_DATABASE=['' + @DB + ''], '' +
			''CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF '' +
			--''GO '' +
			''USE ['' + @DB + ''] '' +
			--''GO '' +
			''CREATE USER ['' + @SAFE_USER + ''] FOR LOGIN ['' + @SAFE_USER + ''] '' +
			--''GO '' +
			''USE ['' + @DB +	''] '' +
			--''GO '' +
			''EXEC sp_addrolemember N''''db_owner'''', N'''''' + @SAFE_USER + '''''' '' +
			--''GO''
			--''USE ['' + @DB +	''] '' +
			--''EXEC sp_addrolemember N''''db_accessadmin'''', N'''''' + @SAFE_USER + '''''' '' +
			''USE ['' + @DB +	''] '' +
			''EXEC sp_addrolemember N''''db_datareader'''', N'''''' + @SAFE_USER + '''''' '' +
			''USE ['' + @DB +	''] '' +
			''EXEC sp_addrolemember N''''db_datawriter'''', N'''''' + @SAFE_USER + '''''' ''
						
BEGIN TRY
	EXEC (@SQL)
	EXEC sp_addrolemember N''db_owner'', @SAFE_USER
		
	SELECT 1 as StatusCode, ''EXITO'' as StatusDescripcion
	RETURN (1)
END TRY
BEGIN CATCH
    SELECT
		0 as StatusCode, ''ERROR'' as StatusDescripcion,
        ERROR_NUMBER() as ErrorNumber,
        ERROR_MESSAGE() as ErrorMessage;
    RETURN (0)
END CATCH;
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ModifyPassUserSQL]    Script Date: 01/28/2014 11:16:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ModifyPassUserSQL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_ModifyPassUserSQL](
        @LOGIN VARCHAR(100),
        @PASSWORD VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = ''Bd_Exp_Transportes''

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)
DECLARE @SAFE_PASSWORD VARCHAR(200)

SET @SAFE_USER = ''..Bd_Exp_Transportes_'' + @LOGIN + ''..''
SET @SAFE_PASSWORD = @PASSWORD

DECLARE @SQL NVARCHAR(MAX)
SET @SQL =	''USE [master] '' +
			--''GO '' +
			''ALTER LOGIN ['' + @SAFE_USER + ''] '' +
			''WITH PASSWORD = '''''' + @SAFE_PASSWORD + '''''';''			
						
BEGIN TRY
	EXEC (@SQL)
	EXEC sp_addrolemember N''db_owner'', @SAFE_USER
		
	SELECT 1 as StatusCode, ''EXITO'' as StatusDescripcion
	RETURN (1)
END TRY
BEGIN CATCH
    SELECT
		0 as StatusCode, ''ERROR'' as StatusDescripcion,
        ERROR_NUMBER() as ErrorNumber,
        ERROR_MESSAGE() as ErrorMessage;
    RETURN (0)
END CATCH;
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_DeleteUserSQL]    Script Date: 01/28/2014 11:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_DeleteUserSQL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_DeleteUserSQL](
        @LOGIN VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = ''Bd_Exp_Transportes''

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)

SET @SAFE_USER = ''..Bd_Exp_Transportes_'' + @LOGIN + ''..''

DECLARE @SQL NVARCHAR(MAX)
SET @SQL =	''USE ['' + @DB +''] '' +
			''EXEC sp_dropuser ['' + @SAFE_USER + ''] '' +
			''USE [master] '' +
			''DROP LOGIN ['' + @SAFE_USER + '']''
					
BEGIN TRY
	EXEC (@SQL)		
	SELECT 1 as StatusCode, ''EXITO'' as StatusDescripcion
	RETURN (1)
END TRY
BEGIN CATCH
    SELECT
		0 as StatusCode, ''ERROR'' as StatusDescripcion,
        ERROR_NUMBER() as ErrorNumber,
        ERROR_MESSAGE() as ErrorMessage;
    RETURN (0)
END CATCH;
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_hora]    Script Date: 01/28/2014 11:16:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_obtener_hora]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ModulosporIdRol]    Script Date: 01/28/2014 11:16:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ModulosporIdRol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_Permsos_Modulos]    Script Date: 01/28/2014 11:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_Permsos_Modulos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesActivosporExpediente]    Script Date: 01/28/2014 11:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CampostrazablesActivosporExpediente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
                         dbo.ca_campostrazables.Mascara, dbo.ca_campostrazables.Mask, dbo.re_expedientes_campostrazables.es_principal
	FROM            dbo.re_expedientes_campostrazables INNER JOIN
							 dbo.ca_campostrazables ON dbo.re_expedientes_campostrazables.id_campotrazable = dbo.ca_campostrazables.id
	WHERE        (dbo.re_expedientes_campostrazables.id_expediente = @id_expediente) AND (dbo.re_expedientes_campostrazables.id_estatus = 1)
	ORDER BY dbo.re_expedientes_campostrazables.es_principal DESC
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesNoEnlazadosporExpediente]    Script Date: 01/28/2014 11:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CampostrazablesNoEnlazadosporExpediente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesporExpediente]    Script Date: 01/28/2014 11:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CampostrazablesporExpediente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_CampostrazablesRegistradosporId_ma_digital]    Script Date: 01/28/2014 11:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CampostrazablesRegistradosporId_ma_digital]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_RegistrosDigitalesRegistradosporId_ma_digital]    Script Date: 01/28/2014 11:17:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_RegistrosDigitalesRegistradosporId_ma_digital]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ClasificacionDocumentosporTramite]    Script Date: 01/28/2014 11:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ClasificacionDocumentosporTramite]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ObtenerDocumentosporTramiteyOrigen]    Script Date: 01/28/2014 11:16:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ObtenerDocumentosporTramiteyOrigen]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
                      dbo.ca_documentos.Mascara_Trazable, dbo.ca_documentos.Mask
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
                      CASE WHEN (dbo.ca_documentos.Estado = 0) THEN ''Original'' WHEN (dbo.ca_documentos.Estado = 1) THEN ''Copia'' END AS Descripcion_Estado, 
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ClasificacionDocumentosNoEnlazadosporTramite]    Script Date: 01/28/2014 11:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ClasificacionDocumentosNoEnlazadosporTramite]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ImagenDigitalporId_de_digital]    Script Date: 01/28/2014 11:16:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ImagenDigitalporId_de_digital]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Rueda
-- Create date: 21 Nomviembre 2013
-- Description:	Obtiene la imagen a partir del id de la tabla detalle digitalizacion
-- =============================================
CREATE PROCEDURE [dbo].[pa_ImagenDigitalporId_de_digital]
	@Id_de_digital int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     dbo.de_digital.id_re_clasificaciondocumento_documento, dbo.de_digital.fecha_hora_creacion, dbo.de_digital.valor_trazable, 
                      dbo.ca_clasificaciondocumentos.Descripcion AS clasificaciondocumento, dbo.ca_documentos.Nombre AS Documento, 
                      dbo.re_clasificaciondocumentos_documentos.id_origen, dbo.ca_origenes.Descripcion AS Origen, dbo.de_digital.imagen
	FROM         dbo.de_digital INNER JOIN
						  dbo.re_clasificaciondocumentos_documentos ON 
						  dbo.de_digital.id_re_clasificaciondocumento_documento = dbo.re_clasificaciondocumentos_documentos.id INNER JOIN
						  dbo.ca_clasificaciondocumentos ON dbo.re_clasificaciondocumentos_documentos.id_clasificaciondocumento = dbo.ca_clasificaciondocumentos.id INNER JOIN
						  dbo.ca_documentos ON dbo.re_clasificaciondocumentos_documentos.id_documento = dbo.ca_documentos.id INNER JOIN
						  dbo.ca_origenes ON dbo.re_clasificaciondocumentos_documentos.id_origen = dbo.ca_origenes.id
	WHERE     (dbo.de_digital.id_estatus = 1) AND (dbo.de_digital.id = @Id_de_digital)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_DocumentosNoEnlazadosporClasificacionDocumento]    Script Date: 01/28/2014 11:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_DocumentosNoEnlazadosporClasificacionDocumento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
                      CASE WHEN (DBO.CA_DOCUMENTOS.ESTADO = 1) THEN ''ORIGINAL''
						   WHEN (DBO.CA_DOCUMENTOS.ESTADO = 2) THEN ''COPIA''
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_DocumentosporClasificacionDocumento]    Script Date: 01/28/2014 11:16:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_DocumentosporClasificacionDocumento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
                      CASE WHEN (DBO.CA_DOCUMENTOS.ESTADO = 1) THEN ''ORIGINAL'' WHEN (DBO.CA_DOCUMENTOS.ESTADO = 2) THEN ''COPIA'' END AS DESCRIPCIONESTADO, 
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_RolesporIdUsuario]    Script Date: 01/28/2014 11:17:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_RolesporIdUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ReferenciaExpedientesparaBloquearDesbloquear]    Script Date: 01/28/2014 11:17:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ReferenciaExpedientesparaBloquearDesbloquear]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ReferenciaExpedientesporValorTrazable]    Script Date: 01/28/2014 11:17:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ReferenciaExpedientesporValorTrazable]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ReferenciaExpedientesporValorTrazableparaDeshacer]    Script Date: 01/28/2014 11:17:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ReferenciaExpedientesporValorTrazableparaDeshacer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_TramitesporExpediente]    Script Date: 01/28/2014 11:17:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_TramitesporExpediente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Rueda
-- Create date: 19 Octubre 2013
-- Description:	Obtiene lista de trámites asociados a determinado expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_TramitesporExpediente]
	@id_expediente int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT        dbo.re_expedientes_tramites.id,dbo.re_expedientes_tramites.id_tramite, dbo.ca_tramites.Nombre, dbo.ca_tramites.Descripcion_Breve
	FROM            dbo.re_expedientes_tramites INNER JOIN
							 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id INNER JOIN
							 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id
	WHERE        (dbo.re_expedientes_tramites.id_expediente = @id_expediente) AND (dbo.ca_tramites.id_estatus = 1)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporExpedienteyValorTrazable]    Script Date: 01/28/2014 11:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ConsultaTramitesporExpedienteyValorTrazable]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporValorTrazable]    Script Date: 01/28/2014 11:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ConsultaTramitesporValorTrazable]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporordenmenor]    Script Date: 01/28/2014 11:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ordenaporordenmenor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporborrado]    Script Date: 01/28/2014 11:16:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ordenaporborrado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporcambiodeorigen]    Script Date: 01/28/2014 11:16:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ordenaporcambiodeorigen]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_ordenaporordenmayor]    Script Date: 01/28/2014 11:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ordenaporordenmayor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_TramitesNoEnlazadosporExpediente]    Script Date: 01/28/2014 11:17:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_TramitesNoEnlazadosporExpediente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Miguel Rueda
-- Create date: 19 Octubre 2013
-- Description:	Obtiene lista de trámites no asociados a determinado expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_TramitesNoEnlazadosporExpediente]
	@id_expediente int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     id,Nombre,[Descripcion_Breve]
	FROM       [dbo].[ca_tramites]
	WHERE ID NOT IN (
		SELECT [id_tramite] FROM [dbo].[re_expedientes_tramites]
		--WHERE [id_expediente] = @id_expediente
	)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[pa_InactivaDe_DigitalporId]    Script Date: 01/28/2014 11:16:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_InactivaDe_DigitalporId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
