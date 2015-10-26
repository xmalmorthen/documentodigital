USE [master]
GO
CREATE LOGIN [digitaldocs] WITH PASSWORD=N'..121212qw', DEFAULT_DATABASE=[BdExpDigital], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [BdExpDigital]
GO
CREATE USER [digitaldocs] FOR LOGIN [digitaldocs]
GO
USE [BdExpDigital]
GO
EXEC sp_addrolemember N'db_datareader', N'digitaldocs'
GO
USE [BdExpDigital]
GO
EXEC sp_addrolemember N'db_datawriter', N'digitaldocs'
GO
USE [BdExpDigital]
GO
EXEC sp_addrolemember N'db_owner', N'digitaldocs'
GO
