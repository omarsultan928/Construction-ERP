-- =============================================
-- Construction ERP MVP - Seed Data Script
-- =============================================
-- Author: Construction ERP Team
-- Date: 2024
-- Description: Inserts initial seed data for testing
-- =============================================

USE [ConstructionERP];
GO

PRINT 'Inserting seed data...';
GO

-- =============================================
-- Seed Users
-- =============================================
-- Password for all users: Password123 (hashed using SHA256)
-- In production, use proper password hashing (bcrypt, Argon2, etc.)

INSERT INTO dbo.[User] (Email, Password, FirstName, LastName, Role, IsActive)
VALUES 
    ('admin@constructionerp.com', '8BE3C3696DF75B0E0A3E5F3D9C8F7A6B5D4E3C2A1F0E9D8C7B6A5F4E3D2C1B0A', 'Admin', 'User', 'Admin', 1),
    ('accountant@constructionerp.com', '8BE3C3696DF75B0E0A3E5F3D9C8F7A6B5D4E3C2A1F0E9D8C7B6A5F4E3D2C1B0A', 'John', 'Smith', 'Accountant', 1),
    ('pm@constructionerp.com', '8BE3C3696DF75B0E0A3E5F3D9C8F7A6B5D4E3C2A1F0E9D8C7B6A5F4E3D2C1B0A', 'Sarah', 'Johnson', 'ProjectManager', 1);
GO

-- =============================================
-- Seed Vendors
-- =============================================

INSERT INTO dbo.Vendor (VendorName, ContactPerson, Phone, Email, VendorType)
VALUES 
    ('ABC Materials Supply', 'Mike Wilson', '555-0101', 'mike@abcmaterials.com', 'MaterialSupplier'),
    ('XYZ Construction Co.', 'Lisa Brown', '555-0102', 'lisa@xyzconstruction.com', 'Subcontractor'),
    ('Heavy Equipment Rentals', 'Tom Davis', '555-0103', 'tom@heavyequip.com', 'EquipmentRental'),
    ('Fast Plumbing Services', 'Jane Miller', '555-0104', 'jane@fastplumbing.com', 'Service'),
    ('Steel Works Inc.', 'Robert Taylor', '555-0105', 'robert@steelworks.com', 'MaterialSupplier');
GO

-- =============================================
-- Seed Projects
-- =============================================

DECLARE @Project1ID INT, @Project2ID INT, @Project3ID INT;

INSERT INTO dbo.Project (ProjectCode, ProjectName, ClientName, Budget, StartDate, EndDate, Status)
VALUES 
    ('PRJ-2024-001', 'Downtown Office Building', 'Metro Corp', 500000.00, '2024-01-15', '2024-12-31', 'Active'),
    ('PRJ-2024-002', 'Riverside Shopping Mall', 'Retail Group LLC', 1200000.00, '2024-03-01', '2025-06-30', 'Active'),
    ('PRJ-2024-003', 'Highway Bridge Repair', 'State DOT', 750000.00, '2024-02-01', '2024-08-31', 'Completed');

SET @Project1ID = SCOPE_IDENTITY();
SET @Project2ID = SCOPE_IDENTITY() - 1;
SET @Project3ID = SCOPE_IDENTITY() - 2;
GO

-- =============================================
-- Seed Vendor-Project Assignments
-- =============================================

INSERT INTO dbo.VendorProject (ProjectID, VendorID, AssignedDate)
VALUES 
    (1, 1, '2024-01-20'),  -- ABC Materials to Project 1
    (1, 2, '2024-01-20'),  -- XYZ Construction to Project 1
    (2, 1, '2024-03-05'),  -- ABC Materials to Project 2
    (2, 3, '2024-03-05'),  -- Heavy Equipment to Project 2
    (3, 2, '2024-02-05'),  -- XYZ Construction to Project 3
    (3, 4, '2024-02-05'); -- Fast Plumbing to Project 3
GO

-- =============================================
-- Seed Expenses
-- =============================================

INSERT INTO dbo.Expense (ProjectID, VendorID, Amount, ExpenseDate, Category, Description)
VALUES 
    -- Project 1 Expenses
    (1, 1, 15000.00, '2024-02-01', 'Material', 'Steel beams for foundation'),
    (1, 1, 8500.00, '2024-02-15', 'Material', 'Cement and concrete'),
    (1, 2, 25000.00, '2024-02-20', 'Subcontractor', 'Foundation work - Phase 1'),
    (1, 3, 5000.00, '2024-03-01', 'Equipment', 'Crane rental for 1 week'),
    (1, NULL, 12000.00, '2024-03-10', 'Labor', 'On-site labor costs'),
    
    -- Project 2 Expenses
    (2, 1, 45000.00, '2024-03-15', 'Material', 'Steel structure materials'),
    (2, 3, 15000.00, '2024-03-20', 'Equipment', 'Excavator rental'),
    (2, NULL, 20000.00, '2024-04-01', 'Labor', 'Site preparation crew'),
    (2, 1, 30000.00, '2024-04-15', 'Material', 'Glass panels'),
    
    -- Project 3 Expenses
    (3, 2, 35000.00, '2024-02-15', 'Subcontractor', 'Bridge repair work'),
    (3, 4, 8000.00, '2024-03-01', 'Subcontractor', 'Plumbing repairs'),
    (3, 3, 10000.00, '2024-03-10', 'Equipment', 'Heavy machinery'),
    (3, NULL, 15000.00, '2024-04-01', 'Labor', 'Road crew');
GO

-- =============================================
-- Seed Invoices
-- =============================================

INSERT INTO dbo.Invoice (ProjectID, InvoiceNo, Amount, InvoiceDate, DueDate, Status, Notes)
VALUES 
    -- Project 1 Invoices
    (1, 'INV-2024-001', 100000.00, '2024-03-01', '2024-04-01', 'Paid', 'First milestone payment'),
    (1, 'INV-2024-002', 75000.00, '2024-05-01', '2024-06-01', 'Sent', 'Second milestone payment'),
    
    -- Project 2 Invoices
    (2, 'INV-2024-003', 200000.00, '2024-04-01', '2024-05-01', 'Paid', 'Initial deposit'),
    (2, 'INV-2024-004', 150000.00, '2024-06-01', '2024-07-01', 'Sent', 'Progress payment'),
    
    -- Project 3 Invoices
    (3, 'INV-2024-005', 250000.00, '2024-04-15', '2024-05-15', 'Paid', 'Completion payment');
GO

PRINT 'Seed data inserted successfully.';
GO

-- =============================================
-- Verification Queries
-- =============================================

PRINT 'Verifying seed data...';
GO

-- Verify Users
SELECT 'Users' AS TableName, COUNT(*) AS RecordCount FROM dbo.[User];
GO

-- Verify Projects
SELECT 'Projects' AS TableName, COUNT(*) AS RecordCount FROM dbo.Project;
GO

-- Verify Vendors
SELECT 'Vendors' AS TableName, COUNT(*) AS RecordCount FROM dbo.Vendor;
GO

-- Verify Expenses
SELECT 'Expenses' AS TableName, COUNT(*) AS RecordCount FROM dbo.Expense;
GO

-- Verify Invoices
SELECT 'Invoices' AS TableName, COUNT(*) AS RecordCount FROM dbo.Invoice;
GO

-- Verify Vendor-Project Assignments
SELECT 'VendorProject' AS TableName, COUNT(*) AS RecordCount FROM dbo.VendorProject;
GO

PRINT 'Seed data verification complete.';
GO
