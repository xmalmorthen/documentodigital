USE [master]
GO
CREATE LOGIN [digitaldocs] WITH PASSWORD=N'..121212qw', DEFAULT_DATABASE=[Bd_Exp_Transportes], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [Bd_Exp_Transportes]
GO
CREATE USER [digitaldocs] FOR LOGIN [digitaldocs]
GO
USE [Bd_Exp_Transportes]
GO
EXEC sp_addrolemember N'db_datareader', N'digitaldocs'
GO
USE [Bd_Exp_Transportes]
GO
EXEC sp_addrolemember N'db_datawriter', N'digitaldocs'
GO
USE [Bd_Exp_Transportes]
GO
EXEC sp_addrolemember N'db_owner', N'digitaldocs'
GO
