/*
	Agregar valor por default a la columna
	
	
*/

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
ALTER TABLE dbo.ma_digital ADD CONSTRAINT
	DF_ma_digital_fecha_hora_bloqueo DEFAULT NULL FOR fecha_hora_bloqueo
GO
COMMIT
