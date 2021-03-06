USE [Bd_Expedientes_Web]
GO
/****** Object:  StoredProcedure [dbo].[pa_Fecha]    Script Date: 27/10/2015 02:30:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 17 Agosto 2013
-- Description:	Obtiene la fecha configurada del servidor de base de datos
-- =============================================
CREATE PROCEDURE [dbo].[pa_Fecha]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT CONVERT(VARCHAR(8),GETDATE(),101) AS Fecha
END

GO
/****** Object:  StoredProcedure [dbo].[pa_Hora]    Script Date: 27/10/2015 02:30:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 17 Agosto 2013
-- Description:	Obtiene la hora configurada del servidor de base de datos
-- =============================================
CREATE PROCEDURE [dbo].[pa_Hora]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT CONVERT(VARCHAR(8),GETDATE(),108) AS Hora
END

GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_nodo]    Script Date: 27/10/2015 02:30:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 27 Octubre 2015
-- Description:	Obtiene información del nodo
-- =============================================
CREATE PROCEDURE [dbo].[pa_obtener_nodo]
	@id_usuario int,
	@id_nodo int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		dbo.ca_nodos.id, dbo.ca_nodos.nodo, dbo.ca_nodos.url_servicio_rest, dbo.ca_nodos.usuario, dbo.ca_nodos.contrasenia, dbo.ca_nodos.activo
	FROM            
		dbo.ca_nodos 
	INNER JOIN
		dbo.re_nodos_usuarios 
	  ON 
		dbo.ca_nodos.id = dbo.re_nodos_usuarios.id_nodo
	WHERE        
		(dbo.re_nodos_usuarios.id_nodo = @id_nodo) 
	  AND 
		(dbo.re_nodos_usuarios.id_usuario = @id_usuario)
	  AND 
		(dbo.re_nodos_usuarios.activo = 1) 
	  AND 
		(dbo.ca_nodos.activo = 1)
END

GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_nodos]    Script Date: 27/10/2015 02:30:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 27 Octubre 2015
-- Description:	Obtiene información de los nodos
-- =============================================
CREATE PROCEDURE [dbo].[pa_obtener_nodos]
	@id_usuario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		dbo.ca_nodos.id, dbo.ca_nodos.nodo, dbo.ca_nodos.url_servicio_rest, dbo.ca_nodos.usuario, dbo.ca_nodos.contrasenia, dbo.ca_nodos.activo
	FROM            
		dbo.ca_nodos 
	INNER JOIN
		dbo.re_nodos_usuarios 
	  ON 
		dbo.ca_nodos.id = dbo.re_nodos_usuarios.id_nodo
	WHERE        
		(dbo.re_nodos_usuarios.id_usuario = @id_usuario)
	  AND 
		(dbo.re_nodos_usuarios.activo = 1) 
	  AND 
		(dbo.ca_nodos.activo = 1)
END

GO
/****** Object:  StoredProcedure [dbo].[pa_obtener_nodos_no_enlazados]    Script Date: 27/10/2015 02:30:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 27 Octubre 2015
-- Description:	Obtiene los nodos que no tienen relación con el usuario
-- =============================================
CrEATE PROCEDURE [dbo].[pa_obtener_nodos_no_enlazados]
	@id_usuario int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		dbo.ca_nodos.id, dbo.ca_nodos.nodo, dbo.ca_nodos.url_servicio_rest, dbo.ca_nodos.fecha_registro
	FROM            
		dbo.ca_nodos 
	WHERE        
		(dbo.ca_nodos.id NOT IN 
			(SELECT 
				id_nodo 
			 FROM 
				dbo.re_nodos_usuarios
			 WHERE 
				(dbo.re_nodos_usuarios.id_usuario = @id_usuario) 
			  AND 
				(dbo.re_nodos_usuarios.activo = 1)
			)
		)
	  AND
		(dbo.ca_nodos.activo = 1)
END

GO
