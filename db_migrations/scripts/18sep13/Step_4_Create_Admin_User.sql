USE [master]
GO
CREATE LOGIN [..Bd_Exp_Transportes_admin..] WITH PASSWORD=N'21232f297a57a5a743894a0e4a801fc3', DEFAULT_DATABASE=[Bd_Exp_Transportes], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [Bd_Exp_Transportes]
GO
CREATE USER [..Bd_Exp_Transportes_admin..] FOR LOGIN [..Bd_Exp_Transportes_admin..]
GO
USE [Bd_Exp_Transportes]
GO
EXEC sp_addrolemember N'db_datareader', N'..Bd_Exp_Transportes_admin..'
GO
USE [Bd_Exp_Transportes]
GO
EXEC sp_addrolemember N'db_datawriter', N'..Bd_Exp_Transportes_admin..'
GO
USE [Bd_Exp_Transportes]
GO
EXEC sp_addrolemember N'db_owner', N'..Bd_Exp_Transportes_admin..'
GO
