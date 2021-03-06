USE [Bd_Expedientes_Digitales]
GO
/****** Object:  StoredProcedure [dbo].[pa_CreateLoginandUser]    Script Date: 04/12/2015 03:25:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[pa_CreateLoginandUser](
        @LOGIN VARCHAR(100),
        @PASSWORD VARCHAR(100)
        )
AS
DECLARE @DB VARCHAR(100)
SET @DB = 'Bd_Expedientes_Digitales'

DECLARE @SAFE_USER VARCHAR(200)
DECLARE @SAFE_LOGIN VARCHAR(200)
DECLARE @SAFE_PASSWORD VARCHAR(200)

SET @SAFE_USER = '..Bd_Expedientes_Digitales_' + @LOGIN + '..'
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
