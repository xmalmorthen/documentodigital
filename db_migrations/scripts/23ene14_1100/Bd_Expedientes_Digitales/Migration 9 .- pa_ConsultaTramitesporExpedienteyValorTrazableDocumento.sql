USE [Bd_Expedientes_Digitales]
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporValorTrazableDocumento]    Script Date: 02/07/2014 10:25:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 07 Febrero 2014
-- Description:	Obtiene el/los expedientes a partir del valor trazable de los documentos por expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_ConsultaTramitesporExpedienteyValorTrazableDocumento]					   
	@id_expediente int,
	@valor_trazable varchar(200)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT     TOP (100) PERCENT dbo.ma_digital.id AS id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, dbo.ma_digital.nota, 
                      dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
	FROM         dbo.ma_digital INNER JOIN
						  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
						  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
						  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
	WHERE     (dbo.ma_digital.id_estatus <> 9) AND (dbo.ma_digital.id IN
							  (SELECT DISTINCT id_ma_digital
								FROM          dbo.de_digital
								WHERE      (LOWER(valor_trazable) = @valor_trazable))) AND (dbo.re_expedientes_tramites.id_tramite = @id_expediente)
	ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
END
