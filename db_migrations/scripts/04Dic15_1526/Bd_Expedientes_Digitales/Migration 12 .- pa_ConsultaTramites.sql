USE [Bd_Expedientes_Digitales]
GO
/****** Object:  StoredProcedure [dbo].[pa_ConsultaTramitesporValorTrazable]    Script Date: 02/07/2014 12:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Rueda
-- Create date: 07 Febrero 2014
-- Description:	Lanza consulta dependiendo el tipo de consulta
-- =============================================
CREATE PROCEDURE [dbo].[pa_ConsultaTramites]
	@tipo_busqueda int,
	@valor_trazable varchar(200),	
	@id_expediente int = null
AS
BEGIN
	SET NOCOUNT ON;
	
	IF @id_expediente is null 
	BEGIN
		IF @tipo_busqueda = 1 BEGIN
		--ConsultaTramitesporValorTrazable
			SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                         dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
			FROM            dbo.de_digital_campostrazables INNER JOIN
									 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
			WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END ELSE IF @tipo_busqueda = 2 BEGIN
		--ConsultaTramitesporValorTrazableExpediente
			SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                         dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
			FROM            dbo.de_digital_campostrazables INNER JOIN
									 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
			WHERE        (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC			
		END	ELSE IF @tipo_busqueda = 3 BEGIN
		--ConsultaTramitesporValorTrazableDocumento
			SELECT     TOP (100) PERCENT dbo.ma_digital.id AS id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, dbo.ma_digital.nota, 
                      dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
			FROM         dbo.ma_digital INNER JOIN
								  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
								  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
								  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
			WHERE     (dbo.ma_digital.id_estatus <> 9) AND (dbo.ma_digital.id IN
									  (SELECT DISTINCT id_ma_digital
										FROM          dbo.de_digital
										WHERE      (LOWER(valor_trazable) = @valor_trazable)))	
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END	ELSE IF @tipo_busqueda = 4 BEGIN
		--ConsultaTramitesporValorTrazable + ConsultaTramitesporValorTrazableExpediente
			(
				SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
										 dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM            dbo.de_digital_campostrazables INNER JOIN
										 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
										 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
										 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
										 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
										 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			)
			UNION
			(
				SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
										 dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM            dbo.de_digital_campostrazables INNER JOIN
										 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
										 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
										 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
										 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
										 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE        (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END	ELSE IF @tipo_busqueda = 5 BEGIN
		--ConsultaTramitesporValorTrazable + ConsultaTramitesporValorTrazableDocumento
			(
				SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
										 dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM            dbo.de_digital_campostrazables INNER JOIN
										 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
										 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
										 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
										 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
										 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			)
			UNION
			(
				SELECT     TOP (100) PERCENT dbo.ma_digital.id AS id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, dbo.ma_digital.nota, 
						  dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.ma_digital INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.ma_digital.id_estatus <> 9) AND (dbo.ma_digital.id IN
										  (SELECT DISTINCT id_ma_digital
											FROM          dbo.de_digital
											WHERE      (LOWER(valor_trazable) = @valor_trazable)))			
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END	ELSE IF @tipo_busqueda = 6 BEGIN
		--ConsultaTramitesporValorTrazableExpediente + ConsultaTramitesporValorTrazableDocumento
			(
				SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
							 dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM            dbo.de_digital_campostrazables INNER JOIN
										 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
										 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
										 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
										 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
										 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE        (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			)
			UNION
			(			
				SELECT     TOP (100) PERCENT dbo.ma_digital.id AS id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, dbo.ma_digital.nota, 
						  dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.ma_digital INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.ma_digital.id_estatus <> 9) AND (dbo.ma_digital.id IN
										  (SELECT DISTINCT id_ma_digital
											FROM          dbo.de_digital
											WHERE      (LOWER(valor_trazable) = @valor_trazable)))	
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC			
		END	ELSE IF @tipo_busqueda = 7 BEGIN
		--ConsultaTramitesporValorTrazable + ConsultaTramitesporValorTrazableExpediente + ConsultaTramitesporValorTrazableDocumento
			(
				SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
										 dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM            dbo.de_digital_campostrazables INNER JOIN
										 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
										 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
										 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
										 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
										 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE        (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			)
			UNION
			(
				SELECT        TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
										 dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM            dbo.de_digital_campostrazables INNER JOIN
										 dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
										 dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
										 dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
										 dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
										 dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE        (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9)
			)
			UNION
			(
				SELECT     TOP (100) PERCENT dbo.ma_digital.id AS id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, dbo.ma_digital.nota, 
						  dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.ma_digital INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.ma_digital.id_estatus <> 9) AND (dbo.ma_digital.id IN
										  (SELECT DISTINCT id_ma_digital
											FROM          dbo.de_digital
											WHERE      (LOWER(valor_trazable) = @valor_trazable)))
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END			
	END
	ELSE BEGIN
		IF @tipo_busqueda = 1 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazable
			SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                      dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
			FROM         dbo.de_digital_campostrazables INNER JOIN
								  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
								  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
								  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
								  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
								  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
			WHERE     (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
								  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END ELSE IF @tipo_busqueda = 2 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazableExpediente
			SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
                      dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
			FROM         dbo.de_digital_campostrazables INNER JOIN
								  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
								  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
								  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
								  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
								  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
			WHERE     (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
								  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END ELSE IF @tipo_busqueda = 3 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazableDocumento
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
		END ELSE IF @tipo_busqueda = 4 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazable + ConsultaTramitesporExpedienteyValorTrazableExpediente
			(
				SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
						  dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.de_digital_campostrazables INNER JOIN
									  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
									  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			)
			UNION
			(
				SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
						  dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.de_digital_campostrazables INNER JOIN
									  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
									  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC		
		END ELSE IF @tipo_busqueda = 5 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazable + ConsultaTramitesporExpedienteyValorTrazableDocumento
			(
				SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
						  dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.de_digital_campostrazables INNER JOIN
									  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
									  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			)
			UNION
			(
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
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC	
		END ELSE IF @tipo_busqueda = 6 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazableExpediente + ConsultaTramitesporExpedienteyValorTrazableDocumento
			(
				SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
						  dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.de_digital_campostrazables INNER JOIN
									  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
									  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			)
			UNION
			(			
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
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END ELSE IF @tipo_busqueda = 7 BEGIN
		--ConsultaTramitesporExpedienteyValorTrazable + ConsultaTramitesporExpedienteyValorTrazableExpediente + ConsultaTramitesporExpedienteyValorTrazableDocumento
			(
				SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
						  dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.de_digital_campostrazables INNER JOIN
									  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.re_expedientes_campostrazables.es_principal = 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
									  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			)
			UNION
			(
				SELECT     TOP (100) PERCENT dbo.de_digital_campostrazables.id_ma_digital, dbo.ma_digital.id_estatus, dbo.ma_digital.fecha_hora_creacion, 
						  dbo.ma_digital.nota, dbo.ca_tramites.Nombre AS tramite, dbo.ca_expedientes.Descripcion AS expediente, dbo.re_expedientes_tramites.id_tramite
				FROM         dbo.de_digital_campostrazables INNER JOIN
									  dbo.re_expedientes_campostrazables ON dbo.de_digital_campostrazables.id_re_expediente_campotrazable = dbo.re_expedientes_campostrazables.id INNER JOIN
									  dbo.ma_digital ON dbo.de_digital_campostrazables.id_ma_digital = dbo.ma_digital.id INNER JOIN
									  dbo.re_expedientes_tramites ON dbo.ma_digital.id_re_expediente_tramite = dbo.re_expedientes_tramites.id INNER JOIN
									  dbo.ca_tramites ON dbo.re_expedientes_tramites.id_tramite = dbo.ca_tramites.id INNER JOIN
									  dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id
				WHERE     (dbo.re_expedientes_campostrazables.es_principal <> 1) AND (LOWER(dbo.de_digital_campostrazables.valor_trazable) = @valor_trazable) AND (dbo.ma_digital.id_estatus <> 9) 
									  AND (dbo.re_expedientes_tramites.id_expediente = @id_expediente)
			)
			UNION
			(
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
			)
			ORDER BY dbo.ma_digital.fecha_hora_creacion DESC
		END
	END
	
END
