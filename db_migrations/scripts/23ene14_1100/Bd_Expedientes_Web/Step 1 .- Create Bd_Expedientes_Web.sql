/*
	Pasos para crear base de datos
	1.- Crear carpeta fisica en disco duro ej. C:\Bd_Expedientes_Web
	2.- Actualizar ruta donde se guardará base de datos en el script
*/

CREATE DATABASE [Bd_Expedientes_Web] ON  PRIMARY 
( NAME = N'Bd_Expedientes_Web', FILENAME = N'C:\Expedientes_Digitales\Bd_Expedientes_Web.mdf' , SIZE = 3072KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bd_Expedientes_Web_log', FILENAME = N'C:\Expedientes_Digitales\Bd_Expedientes_Web_log.ldf' , SIZE = 1024KB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'Bd_Expedientes_Web', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bd_Expedientes_Web].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [Bd_Expedientes_Web] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET  READ_WRITE 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET RECOVERY FULL 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET  MULTI_USER 
GO
ALTER DATABASE [Bd_Expedientes_Web] SET PAGE_VERIFY CHECKSUM  
GO
USE [Bd_Expedientes_Web]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [Bd_Expedientes_Web] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
