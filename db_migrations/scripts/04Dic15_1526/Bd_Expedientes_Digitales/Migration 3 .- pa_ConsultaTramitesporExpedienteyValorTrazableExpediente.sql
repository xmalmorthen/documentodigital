USE [Bd_Expedientes_Digitales]
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporExpedienteyValorTrazable]    Script Date: 02/06/2014 15:46:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 06 Febrero 2014
-- Description:	Obtiene el/los expedientes a partir del valor trazable del expediente, no del valor trazable principal, si no, de los otros valores trazables registrados en el expediente
-- =============================================
CREATE PROCEDURE [dbo].[pa_ConsultaTramitesporExpedienteyValorTrazableExpediente]
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
	WHERE     (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
						  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
	ORDER BY dbo.de_digital_campostrazables.fecha_hora_creacion DESC
END
