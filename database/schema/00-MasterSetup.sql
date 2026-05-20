-- =============================================
-- Construction ERP MVP - Master Setup Script
-- =============================================
-- Author: Construction ERP Team
-- Date: 2024
-- Description: Master script to run all database setup scripts in order
-- =============================================

PRINT 'Starting Construction ERP MVP Database Setup...';
PRINT '===============================================';
GO

-- Step 1: Create Database (Added double quotes around the path)
:r "D:\Hardhunt Inc\database\schema\01-CreateDatabase.sql"
GO

PRINT '===============================================';
PRINT 'Step 1: Database created successfully.';
GO

-- Step 2: Create Tables
:r "D:\Hardhunt Inc\database\schema\02-CreateTables.sql"
GO

PRINT '===============================================';
PRINT 'Step 2: Tables created successfully.';
GO

-- Step 3: Create Stored Procedures
:r "D:\Hardhunt Inc\database\schema\03-CreateStoredProcedures.sql"
GO

PRINT '===============================================';
PRINT 'Step 3: Stored procedures created successfully.';
GO

-- Step 4: Create Views
:r "D:\Hardhunt Inc\database\schema\04-CreateViews.sql"
GO

PRINT '===============================================';
PRINT 'Step 4: Views created successfully.';
GO

-- Step 5: Insert Seed Data
:r "D:\Hardhunt Inc\database\schema\05-SeedData.sql"
GO

PRINT '===============================================';
PRINT 'Step 5: Seed data inserted successfully.';
GO

PRINT '===============================================';
PRINT 'Construction ERP MVP Database Setup Complete!';
PRINT '===============================================';
GO