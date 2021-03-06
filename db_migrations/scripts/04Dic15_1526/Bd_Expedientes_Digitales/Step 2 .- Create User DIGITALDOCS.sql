USE [master]
GO
CREATE LOGIN [digitaldocs] WITH PASSWORD=N'..121212qw', DEFAULT_DATABASE=[Bd_Expedientes_Digitales], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
EXEC master..sp_addsrvrolemember @loginame = N'digitaldocs', @rolename = N'securityadmin'
GO
USE [Bd_Expedientes_Digitales]
GO
CREATE USER [digitaldocs] FOR LOGIN [digitaldocs]
GO
USE [Bd_Expedientes_Digitales]
GO
EXEC sp_addrolemember N'db_datareader', N'digitaldocs'
GO
USE [Bd_Expedientes_Digitales]
GO
EXEC sp_addrolemember N'db_datawriter', N'digitaldocs'
GO
USE [Bd_Expedientes_Digitales]
GO
EXEC sp_addrolemember N'db_owner', N'digitaldocs'
GO
