/*
   martes, 04 de febrero de 201412:29:27 p.m.
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
ALTER TABLE dbo.de_digital_campostrazables
	DROP CONSTRAINT FK_de_digital_campostrazables_re_expedientes_campostrazables
GO
COMMIT
select Has_Perms_By_Name(N'dbo.re_expedientes_campostrazables', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.re_expedientes_campostrazables', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.re_expedientes_campostrazables', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.de_digital_campostrazables
	DROP CONSTRAINT FK_de_digital_campostrazables_ma_digital
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ma_digital', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ma_digital', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ma_digital', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.de_digital_campostrazables
	DROP CONSTRAINT FK_de_digital_campostrazables_ca_estatus
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ca_estatus', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ca_estatus', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ca_estatus', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.de_digital_campostrazables
	DROP CONSTRAINT DF_de_digital_campostrazables_fecha_hora_creacion
GO
CREATE TABLE dbo.Tmp_de_digital_campostrazables
	(
	id int NOT NULL IDENTITY (1, 1),
	id_ma_digital int NOT NULL,
	id_re_expediente_campotrazable int NOT NULL,
	valor_trazable varchar(200) NULL,
	fecha_hora_creacion datetime NOT NULL,
	id_estatus int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_de_digital_campostrazables ADD CONSTRAINT
	DF_de_digital_campostrazables_fecha_hora_creacion DEFAULT (getdate()) FOR fecha_hora_creacion
GO
SET IDENTITY_INSERT dbo.Tmp_de_digital_campostrazables ON
GO
IF EXISTS(SELECT * FROM dbo.de_digital_campostrazables)
	 EXEC('INSERT INTO dbo.Tmp_de_digital_campostrazables (id, id_ma_digital, id_re_expediente_campotrazable, valor_trazable, fecha_hora_creacion, id_estatus)
		SELECT id, id_ma_digital, id_re_expediente_campotrazable, valor_trazable, fecha_hora_creacion, id_estatus FROM dbo.de_digital_campostrazables WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_de_digital_campostrazables OFF
GO
DROP TABLE dbo.de_digital_campostrazables
GO
EXECUTE sp_rename N'dbo.Tmp_de_digital_campostrazables', N'de_digital_campostrazables', 'OBJECT' 
GO
ALTER TABLE dbo.de_digital_campostrazables ADD CONSTRAINT
	PK_de_expedientestrazable PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX IX_de_digital_campostrazables ON dbo.de_digital_campostrazables
	(
	id_ma_digital
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_de_digital_campostrazables_1 ON dbo.de_digital_campostrazables
	(
	id_re_expediente_campotrazable
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_de_digital_campostrazables_2 ON dbo.de_digital_campostrazables
	(
	valor_trazable
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_de_digital_campostrazables_3 ON dbo.de_digital_campostrazables
	(
	id_estatus
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_de_digital_campostrazables_4 ON dbo.de_digital_campostrazables
	(
	fecha_hora_creacion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.de_digital_campostrazables ADD CONSTRAINT
	FK_de_digital_campostrazables_ca_estatus FOREIGN KEY
	(
	id_estatus
	) REFERENCES dbo.ca_estatus
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
ALTER TABLE dbo.de_digital_campostrazables ADD CONSTRAINT
	FK_de_digital_campostrazables_re_expedientes_campostrazables FOREIGN KEY
	(
	id_re_expediente_campotrazable
	) REFERENCES dbo.re_expedientes_campostrazables
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
CREATE TRIGGER [dbo].[TR_de_digital_campostrazables_UPDATE] ON dbo.de_digital_campostrazables
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
-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger insercion
-- =============================================
create TRIGGER [dbo].[TR_de_digital_campostrazables_INSERT] ON dbo.de_digital_campostrazables
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
-- =============================================
-- Author:		Miguel Angel Rueda Aguilar
-- Create date: 20 Septiembre 2013
-- Description:	Trigger eliminacion
-- =============================================
CREATE TRIGGER [dbo].[TR_de_digital_campostrazables_DELETE] ON dbo.de_digital_campostrazables
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
COMMIT
select Has_Perms_By_Name(N'dbo.de_digital_campostrazables', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.de_digital_campostrazables', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.de_digital_campostrazables', 'Object', 'CONTROL') as Contr_Per 