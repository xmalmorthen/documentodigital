USE [master]
GO
CREATE LOGIN [..BdExpDigital_admin..] WITH PASSWORD=N'21232f297a57a5a743894a0e4a801fc3', DEFAULT_DATABASE=[BdExpDigital], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [BdExpDigital]
GO
CREATE USER [..BdExpDigital_admin..] FOR LOGIN [..BdExpDigital_admin..]
GO
USE [BdExpDigital]
GO
EXEC sp_addrolemember N'db_datareader', N'..BdExpDigital_admin..'
GO
USE [BdExpDigital]
GO
EXEC sp_addrolemember N'db_datawriter', N'..BdExpDigital_admin..'
GO
USE [BdExpDigital]
GO
EXEC sp_addrolemember N'db_owner', N'..BdExpDigital_admin..'
GO
