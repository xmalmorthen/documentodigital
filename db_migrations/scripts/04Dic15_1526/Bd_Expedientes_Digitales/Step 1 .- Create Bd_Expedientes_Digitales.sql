/*
	Pasos para crear base de datos
	1.- Crear carpeta fisica en disco duro ej. C:\Expedientes_Digitales
	2.- Actualizar ruta donde se guardará base de datos en el script
*/

CREATE DATABASE [Bd_Expedientes_Digitales] ON  PRIMARY 
( NAME = N'Bd_Expedientes_Digitales', FILENAME = N'C:\Expedientes_Digitales\Bd_Expedientes_Digitales.mdf' , SIZE = 3072KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bd_Expedientes_Digitales_log', FILENAME = N'C:\Expedientes_Digitales\Bd_Expedientes_Digitales_log.ldf' , SIZE = 1024KB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'Bd_Expedientes_Digitales', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bd_Expedientes_Digitales].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET  READ_WRITE 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET RECOVERY FULL 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET  MULTI_USER 
GO
ALTER DATABASE [Bd_Expedientes_Digitales] SET PAGE_VERIFY CHECKSUM  
GO
USE [Bd_Expedientes_Digitales]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [Bd_Expedientes_Digitales] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
