-- =============================================
-- Construction ERP MVP - Database Creation Script
-- =============================================
-- Author: Construction ERP Team
-- Date: 2024
-- Description: Creates the ConstructionERP database
-- =============================================

USE master;
GO

-- Drop database if exists (for development only)
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'ConstructionERP')
BEGIN
    ALTER DATABASE [ConstructionERP] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [ConstructionERP];
END
GO

-- Create the database
CREATE DATABASE [ConstructionERP]
COLLATE SQL_Latin1_General_CP1_CI_AS;
GO

-- Set database options
ALTER DATABASE [ConstructionERP] SET COMPATIBILITY_LEVEL = 150;
GO

ALTER DATABASE [ConstructionERP] SET RECOVERY SIMPLE;
GO

ALTER DATABASE [ConstructionERP] SET AUTO_CLOSE OFF;
GO

ALTER DATABASE [ConstructionERP] SET AUTO_SHRINK OFF;
GO

ALTER DATABASE [ConstructionERP] SET AUTO_UPDATE_STATISTICS ON;
GO

-- Switch to the new database
USE [ConstructionERP];
GO

PRINT 'Database ConstructionERP created successfully.';
GO
