-- =============================================
-- Construction ERP MVP - Table Creation Script
-- =============================================
-- Author: Construction ERP Team
-- Date: 2024
-- Description: Creates all tables for the ConstructionERP database
-- =============================================

USE [ConstructionERP];
GO

PRINT 'Creating tables...';
GO

-- =============================================
-- Table: User
-- =============================================
IF OBJECT_ID('dbo.User', 'U') IS NOT NULL
    DROP TABLE dbo.[User];
GO

CREATE TABLE dbo.[User]
(
    UserID          INT              IDENTITY(1,1) NOT NULL,
    Email           NVARCHAR(100)    NOT NULL,
    Password        NVARCHAR(255)    NOT NULL,
    FirstName       NVARCHAR(50)     NOT NULL,
    LastName        NVARCHAR(50)     NOT NULL,
    Role            NVARCHAR(20)     NOT NULL,
    IsActive        BIT              NOT NULL DEFAULT 1,
    CreatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    UpdatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_User PRIMARY KEY CLUSTERED (UserID ASC)
);
GO

-- Create unique index on Email
CREATE UNIQUE NONCLUSTERED INDEX IX_User_Email ON dbo.[User] (Email);
GO

-- =============================================
-- Table: Project
-- =============================================
IF OBJECT_ID('dbo.Project', 'U') IS NOT NULL
    DROP TABLE dbo.Project;
GO

CREATE TABLE dbo.Project
(
    ProjectID       INT              IDENTITY(1,1) NOT NULL,
    ProjectCode     NVARCHAR(20)     NOT NULL,
    ProjectName     NVARCHAR(100)    NOT NULL,
    ClientName      NVARCHAR(100)    NOT NULL,
    Budget          DECIMAL(18,2)    NOT NULL DEFAULT 0,
    StartDate       DATE             NOT NULL,
    EndDate         DATE             NULL,
    Status          NVARCHAR(20)     NOT NULL,
    CreatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    UpdatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Project PRIMARY KEY CLUSTERED (ProjectID ASC)
);
GO

-- Create indexes
CREATE UNIQUE NONCLUSTERED INDEX IX_Project_Code ON dbo.Project (ProjectCode);
CREATE NONCLUSTERED INDEX IX_Project_Status ON dbo.Project (Status);
CREATE NONCLUSTERED INDEX IX_Project_Client ON dbo.Project (ClientName);
GO

-- =============================================
-- Table: Vendor
-- =============================================
IF OBJECT_ID('dbo.Vendor', 'U') IS NOT NULL
    DROP TABLE dbo.Vendor;
GO

CREATE TABLE dbo.Vendor
(
    VendorID        INT              IDENTITY(1,1) NOT NULL,
    VendorName      NVARCHAR(100)    NOT NULL,
    ContactPerson   NVARCHAR(100)    NULL,
    Phone           NVARCHAR(20)     NULL,
    Email           NVARCHAR(100)    NULL,
    VendorType      NVARCHAR(20)     NOT NULL,
    CreatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Vendor PRIMARY KEY CLUSTERED (VendorID ASC)
);
GO

-- Create indexes
CREATE NONCLUSTERED INDEX IX_Vendor_Name ON dbo.Vendor (VendorName);
CREATE NONCLUSTERED INDEX IX_Vendor_Type ON dbo.Vendor (VendorType);
GO

-- =============================================
-- Table: Expense
-- =============================================
IF OBJECT_ID('dbo.Expense', 'U') IS NOT NULL
    DROP TABLE dbo.Expense;
GO

CREATE TABLE dbo.Expense
(
    ExpenseID       INT              IDENTITY(1,1) NOT NULL,
    ProjectID       INT              NOT NULL,
    VendorID        INT              NULL,
    Amount          DECIMAL(18,2)    NOT NULL DEFAULT 0,
    ExpenseDate     DATE             NOT NULL,
    Category        NVARCHAR(20)     NOT NULL,
    Description     NVARCHAR(500)    NULL,
    CreatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    UpdatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Expense PRIMARY KEY CLUSTERED (ExpenseID ASC),
    CONSTRAINT FK_Expense_Project FOREIGN KEY (ProjectID) 
        REFERENCES dbo.Project (ProjectID) ON DELETE CASCADE,
    CONSTRAINT FK_Expense_Vendor FOREIGN KEY (VendorID) 
        REFERENCES dbo.Vendor (VendorID) ON DELETE SET NULL
);
GO

-- Create indexes
CREATE NONCLUSTERED INDEX IX_Expense_Project ON dbo.Expense (ProjectID);
CREATE NONCLUSTERED INDEX IX_Expense_Category ON dbo.Expense (Category);
CREATE NONCLUSTERED INDEX IX_Expense_Date ON dbo.Expense (ExpenseDate);
GO

-- =============================================
-- Table: VendorProject (Junction Table)
-- =============================================
IF OBJECT_ID('dbo.VendorProject', 'U') IS NOT NULL
    DROP TABLE dbo.VendorProject;
GO

CREATE TABLE dbo.VendorProject
(
    VPID            INT              IDENTITY(1,1) NOT NULL,
    ProjectID       INT              NOT NULL,
    VendorID        INT              NOT NULL,
    AssignedDate    DATE             NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_VendorProject PRIMARY KEY CLUSTERED (VPID ASC),
    CONSTRAINT FK_VendorProject_Project FOREIGN KEY (ProjectID) 
        REFERENCES dbo.Project (ProjectID) ON DELETE CASCADE,
    CONSTRAINT FK_VendorProject_Vendor FOREIGN KEY (VendorID) 
        REFERENCES dbo.Vendor (VendorID) ON DELETE CASCADE
);
GO

-- Create unique constraint
CREATE UNIQUE NONCLUSTERED INDEX UC_VendorProject ON dbo.VendorProject (ProjectID, VendorID);
GO

-- Create indexes
CREATE NONCLUSTERED INDEX IX_VendorProject_Project ON dbo.VendorProject (ProjectID);
CREATE NONCLUSTERED INDEX IX_VendorProject_Vendor ON dbo.VendorProject (VendorID);
GO

-- =============================================
-- Table: Invoice
-- =============================================
IF OBJECT_ID('dbo.Invoice', 'U') IS NOT NULL
    DROP TABLE dbo.Invoice;
GO

CREATE TABLE dbo.Invoice
(
    InvoiceID       INT              IDENTITY(1,1) NOT NULL,
    ProjectID       INT              NOT NULL,
    InvoiceNo       NVARCHAR(50)     NOT NULL,
    Amount          DECIMAL(18,2)    NOT NULL DEFAULT 0,
    InvoiceDate     DATE             NOT NULL,
    DueDate         DATE             NOT NULL,
    Status          NVARCHAR(20)     NOT NULL,
    Notes           NVARCHAR(1000)   NULL,
    CreatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    UpdatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Invoice PRIMARY KEY CLUSTERED (InvoiceID ASC),
    CONSTRAINT FK_Invoice_Project FOREIGN KEY (ProjectID) 
        REFERENCES dbo.Project (ProjectID) ON DELETE CASCADE
);
GO

-- Create indexes
CREATE UNIQUE NONCLUSTERED INDEX IX_Invoice_No ON dbo.Invoice (InvoiceNo);
CREATE NONCLUSTERED INDEX IX_Invoice_Project ON dbo.Invoice (ProjectID);
CREATE NONCLUSTERED INDEX IX_Invoice_Status ON dbo.Invoice (Status);
CREATE NONCLUSTERED INDEX IX_Invoice_DueDate ON dbo.Invoice (DueDate);
GO

-- =============================================
-- Create trigger for UpdatedDate
-- =============================================
CREATE TRIGGER tr_User_UpdateDate
ON dbo.[User]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.[User]
    SET UpdatedDate = GETDATE()
    WHERE UserID IN (SELECT UserID FROM inserted);
END
GO

CREATE TRIGGER tr_Project_UpdateDate
ON dbo.Project
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Project
    SET UpdatedDate = GETDATE()
    WHERE ProjectID IN (SELECT ProjectID FROM inserted);
END
GO

CREATE TRIGGER tr_Expense_UpdateDate
ON dbo.Expense
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Expense
    SET UpdatedDate = GETDATE()
    WHERE ExpenseID IN (SELECT ExpenseID FROM inserted);
END
GO

CREATE TRIGGER tr_Invoice_UpdateDate
ON dbo.Invoice
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Invoice
    SET UpdatedDate = GETDATE()
    WHERE InvoiceID IN (SELECT InvoiceID FROM inserted);
END
GO

PRINT 'All tables created successfully.';
GO
