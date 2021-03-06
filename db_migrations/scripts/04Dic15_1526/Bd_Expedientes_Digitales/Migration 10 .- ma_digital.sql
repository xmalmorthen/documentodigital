/*
   viernes, 07 de febrero de 201401:34:37 p.m.
   Usuario: digitaldocs
   Servidor: xmalmorthen.dyndns.org
   Base de datos: Bd_Expedientes_Digitales
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ma_digital
	DROP CONSTRAINT FK_ma_digital_re_expedientes_tramites
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ma_digital
	DROP CONSTRAINT FK_ma_digital_ca_estatus
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ma_digital
	DROP CONSTRAINT DF_ma_digital_fecha_hora_creacion
GO
ALTER TABLE dbo.ma_digital
	DROP CONSTRAINT DF_ma_digital_fecha_hora_bloqueo
GO
CREATE TABLE dbo.Tmp_ma_digital
	(
	id int NOT NULL IDENTITY (1, 1),
	id_re_expediente_tramite int NOT NULL,
	fecha_hora_creacion datetime NOT NULL,
	nota varchar(MAX) NULL,
	fecha_hora_bloqueo datetime NULL,
	id_estatus int NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ma_digital ADD CONSTRAINT
	DF_ma_digital_fecha_hora_creacion DEFAULT (getdate()) FOR fecha_hora_creacion
GO
ALTER TABLE dbo.Tmp_ma_digital ADD CONSTRAINT
	DF_ma_digital_fecha_hora_bloqueo DEFAULT (NULL) FOR fecha_hora_bloqueo
GO
SET IDENTITY_INSERT dbo.Tmp_ma_digital ON
GO
IF EXISTS(SELECT * FROM dbo.ma_digital)
	 EXEC('INSERT INTO dbo.Tmp_ma_digital (id, id_re_expediente_tramite, fecha_hora_creacion, nota, fecha_hora_bloqueo, id_estatus)
		SELECT id, id_re_expediente_tramite, fecha_hora_creacion, CONVERT(varchar(MAX), nota), fecha_hora_bloqueo, id_estatus FROM dbo.ma_digital WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_ma_digital OFF
GO
ALTER TABLE dbo.de_digital_campostrazables
	DROP CONSTRAINT FK_de_digital_campostrazables_ma_digital
GO
ALTER TABLE dbo.de_digital
	DROP CONSTRAINT FK_de_digital_ma_digital1
GO
DROP TABLE dbo.ma_digital
GO
EXECUTE sp_rename N'dbo.Tmp_ma_digital', N'ma_digital', 'OBJECT' 
GO
ALTER TABLE dbo.ma_digital ADD CONSTRAINT
	PK_de_expedientedocumentodigital PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX IX_ma_digital ON dbo.ma_digital
	(
	id_re_expediente_tramite
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_ma_digital_1 ON dbo.ma_digital
	(
	id_estatus
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_ma_digital_2 ON dbo.ma_digital
	(
	fecha_hora_bloqueo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_ma_digital_3 ON dbo.ma_digital
	(
	fecha_hora_creacion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.ma_digital WITH NOCHECK ADD CONSTRAINT
	FK_ma_digital_ca_estatus FOREIGN KEY
	(
	id_estatus
	) REFERENCES dbo.ca_estatus
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ma_digital WITH NOCHECK ADD CONSTRAINT
	FK_ma_digital_re_expedientes_tramites FOREIGN KEY
	(
	id_re_expediente_tramite
	) REFERENCES dbo.re_expedientes_tramites
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger modificacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ma_digital_UPDATE] ON dbo.ma_digital
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
-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_ma_digital_DELETE] ON dbo.ma_digital
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
-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
CREATE TRIGGER [dbo].[TR_ma_digital_INSERT] ON dbo.ma_digital
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
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.de_digital WITH NOCHECK ADD CONSTRAINT
	FK_de_digital_ma_digital1 FOREIGN KEY
	(
	id_ma_digital
	) REFERENCES dbo.ma_digital
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.de_digital
	NOCHECK CONSTRAINT FK_de_digital_ma_digital1
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.de_digital_campostrazables ADD CONSTRAINT
	FK_de_digital_campostrazables_ma_digital FOREIGN KEY
	(
	id_ma_digital
	) REFERENCES dbo.ma_digital
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
