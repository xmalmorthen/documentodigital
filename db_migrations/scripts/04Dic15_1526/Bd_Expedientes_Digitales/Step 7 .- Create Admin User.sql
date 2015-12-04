USE [master]
GO
CREATE LOGIN [..Bd_Expedientes_Digitales_admin..] WITH PASSWORD=N'21232f297a57a5a743894a0e4a801fc3', DEFAULT_DATABASE=[Bd_Expedientes_Digitales], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [Bd_Expedientes_Digitales]
GO
CREATE USER [..Bd_Expedientes_Digitales_admin..] FOR LOGIN [..Bd_Expedientes_Digitales_admin..]
GO
USE [Bd_Expedientes_Digitales]
GO
EXEC sp_addrolemember N'db_datareader', N'..Bd_Expedientes_Digitales_admin..'
GO
USE [Bd_Expedientes_Digitales]
GO
EXEC sp_addrolemember N'db_datawriter', N'..Bd_Expedientes_Digitales_admin..'
GO
USE [Bd_Expedientes_Digitales]
GO
EXEC sp_addrolemember N'db_owner', N'..Bd_Expedientes_Digitales_admin..'
GO
