USE [Bd_Expedientes_Web]
GO
/****** Object:  User [digitaldocs]    Script Date: 27/10/2015 01:54:44 p. m. ******/
CREATE USER [digitaldocs] FOR LOGIN [digitaldocs] WITH DEFAULT_SCHEMA=[dbo]
GO
sys.sp_addrolemember @rolename = N'db_owner', @membername = N'digitaldocs'
GO
sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'digitaldocs'
GO
sys.sp_addrolemember @rolename = N'db_datawriter', @membername = N'digitaldocs'
GO
