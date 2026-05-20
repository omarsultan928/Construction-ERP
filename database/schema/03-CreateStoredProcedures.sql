-- =============================================
-- Construction ERP MVP - Stored Procedures
-- =============================================
-- Author: Construction ERP Team
-- Date: 2024
-- Description: Creates all stored procedures for the ConstructionERP database
-- =============================================

USE [ConstructionERP];
GO

PRINT 'Creating stored procedures...';
GO

-- =============================================
-- User Management Stored Procedures
-- =============================================

-- sp_User_Insert
IF OBJECT_ID('dbo.sp_User_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_User_Insert;
GO

CREATE PROCEDURE dbo.sp_User_Insert
    @Email           NVARCHAR(100),
    @Password        NVARCHAR(255),
    @FirstName       NVARCHAR(50),
    @LastName        NVARCHAR(50),
    @Role            NVARCHAR(20),
    @UserID          INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO dbo.[User] (Email, Password, FirstName, LastName, Role)
    VALUES (@Email, @Password, @FirstName, @LastName, @Role);
    
    SET @UserID = SCOPE_IDENTITY();
END
GO

-- sp_User_Update
IF OBJECT_ID('dbo.sp_User_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_User_Update;
GO

CREATE PROCEDURE dbo.sp_User_Update
    @UserID          INT,
    @Email           NVARCHAR(100),
    @FirstName       NVARCHAR(50),
    @LastName        NVARCHAR(50),
    @Role            NVARCHAR(20),
    @IsActive        BIT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.[User]
    SET Email = @Email,
        FirstName = @FirstName,
        LastName = @LastName,
        Role = @Role,
        IsActive = @IsActive
    WHERE UserID = @UserID;
END
GO

-- sp_User_Delete (Soft Delete)
IF OBJECT_ID('dbo.sp_User_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_User_Delete;
GO

CREATE PROCEDURE dbo.sp_User_Delete
    @UserID          INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.[User]
    SET IsActive = 0
    WHERE UserID = @UserID;
END
GO

-- sp_User_GetByEmail
IF OBJECT_ID('dbo.sp_User_GetByEmail', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_User_GetByEmail;
GO

CREATE PROCEDURE dbo.sp_User_GetByEmail
    @Email           NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT UserID, Email, Password, FirstName, LastName, Role, IsActive, CreatedDate, UpdatedDate
    FROM dbo.[User]
    WHERE Email = @Email AND IsActive = 1;
END
GO

-- sp_User_GetAll
IF OBJECT_ID('dbo.sp_User_GetAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_User_GetAll;
GO

CREATE PROCEDURE dbo.sp_User_GetAll
    @Role            NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT UserID, Email, FirstName, LastName, Role, IsActive, CreatedDate, UpdatedDate
    FROM dbo.[User]
    WHERE (@Role IS NULL OR Role = @Role)
    ORDER BY CreatedDate DESC;
END
GO

-- =============================================
-- Project Management Stored Procedures
-- =============================================

-- sp_Project_Insert
IF OBJECT_ID('dbo.sp_Project_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Project_Insert;
GO

CREATE PROCEDURE dbo.sp_Project_Insert
    @ProjectCode     NVARCHAR(20),
    @ProjectName     NVARCHAR(100),
    @ClientName      NVARCHAR(100),
    @Budget          DECIMAL(18,2),
    @StartDate       DATE,
    @EndDate         DATE = NULL,
    @Status          NVARCHAR(20),
    @ProjectID       INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO dbo.Project (ProjectCode, ProjectName, ClientName, Budget, StartDate, EndDate, Status)
    VALUES (@ProjectCode, @ProjectName, @ClientName, @Budget, @StartDate, @EndDate, @Status);
    
    SET @ProjectID = SCOPE_IDENTITY();
END
GO

-- sp_Project_Update
IF OBJECT_ID('dbo.sp_Project_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Project_Update;
GO

CREATE PROCEDURE dbo.sp_Project_Update
    @ProjectID       INT,
    @ProjectCode     NVARCHAR(20),
    @ProjectName     NVARCHAR(100),
    @ClientName      NVARCHAR(100),
    @Budget          DECIMAL(18,2),
    @StartDate       DATE,
    @EndDate         DATE = NULL,
    @Status          NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Project
    SET ProjectCode = @ProjectCode,
        ProjectName = @ProjectName,
        ClientName = @ClientName,
        Budget = @Budget,
        StartDate = @StartDate,
        EndDate = @EndDate,
        Status = @Status
    WHERE ProjectID = @ProjectID;
END
GO

-- sp_Project_Delete (Soft Delete - Set status to Cancelled)
IF OBJECT_ID('dbo.sp_Project_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Project_Delete;
GO

CREATE PROCEDURE dbo.sp_Project_Delete
    @ProjectID       INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Project
    SET Status = 'Cancelled'
    WHERE ProjectID = @ProjectID;
END
GO

-- sp_Project_GetByCode
IF OBJECT_ID('dbo.sp_Project_GetByCode', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Project_GetByCode;
GO

CREATE PROCEDURE dbo.sp_Project_GetByCode
    @ProjectCode     NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT ProjectID, ProjectCode, ProjectName, ClientName, Budget, StartDate, EndDate, Status, CreatedDate, UpdatedDate
    FROM dbo.Project
    WHERE ProjectCode = @ProjectCode;
END
GO

-- sp_Project_GetAll
IF OBJECT_ID('dbo.sp_Project_GetAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Project_GetAll;
GO

CREATE PROCEDURE dbo.sp_Project_GetAll
    @Status          NVARCHAR(20) = NULL,
    @ClientName      NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT ProjectID, ProjectCode, ProjectName, ClientName, Budget, StartDate, EndDate, Status, CreatedDate, UpdatedDate
    FROM dbo.Project
    WHERE (@Status IS NULL OR Status = @Status)
      AND (@ClientName IS NULL OR ClientName LIKE '%' + @ClientName + '%')
    ORDER BY CreatedDate DESC;
END
GO

-- sp_Project_GetSummary
IF OBJECT_ID('dbo.sp_Project_GetSummary', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Project_GetSummary;
GO

CREATE PROCEDURE dbo.sp_Project_GetSummary
    @ProjectID       INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.ProjectID,
        p.ProjectCode,
        p.ProjectName,
        p.ClientName,
        p.Budget,
        p.StartDate,
        p.EndDate,
        p.Status,
        ISNULL(SUM(e.Amount), 0) AS TotalExpenses,
        ISNULL(SUM(i.Amount), 0) AS TotalInvoices,
        p.Budget - ISNULL(SUM(e.Amount), 0) AS RemainingBudget,
        ISNULL(SUM(i.Amount), 0) - ISNULL(SUM(e.Amount), 0) AS EstimatedProfit
    FROM dbo.Project p
    LEFT JOIN dbo.Expense e ON p.ProjectID = e.ProjectID
    LEFT JOIN dbo.Invoice i ON p.ProjectID = i.ProjectID AND i.Status = 'Paid'
    WHERE p.ProjectID = @ProjectID
    GROUP BY p.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName, 
             p.Budget, p.StartDate, p.EndDate, p.Status;
END
GO

-- =============================================
-- Expense Management Stored Procedures
-- =============================================

-- sp_Expense_Insert
IF OBJECT_ID('dbo.sp_Expense_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Expense_Insert;
GO

CREATE PROCEDURE dbo.sp_Expense_Insert
    @ProjectID       INT,
    @VendorID        INT = NULL,
    @Amount          DECIMAL(18,2),
    @ExpenseDate     DATE,
    @Category        NVARCHAR(20),
    @Description     NVARCHAR(500) = NULL,
    @ExpenseID       INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO dbo.Expense (ProjectID, VendorID, Amount, ExpenseDate, Category, Description)
    VALUES (@ProjectID, @VendorID, @Amount, @ExpenseDate, @Category, @Description);
    
    SET @ExpenseID = SCOPE_IDENTITY();
END
GO

-- sp_Expense_Update
IF OBJECT_ID('dbo.sp_Expense_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Expense_Update;
GO

CREATE PROCEDURE dbo.sp_Expense_Update
    @ExpenseID       INT,
    @ProjectID       INT,
    @VendorID        INT = NULL,
    @Amount          DECIMAL(18,2),
    @ExpenseDate     DATE,
    @Category        NVARCHAR(20),
    @Description     NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Expense
    SET ProjectID = @ProjectID,
        VendorID = @VendorID,
        Amount = @Amount,
        ExpenseDate = @ExpenseDate,
        Category = @Category,
        Description = @Description
    WHERE ExpenseID = @ExpenseID;
END
GO

-- sp_Expense_Delete
IF OBJECT_ID('dbo.sp_Expense_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Expense_Delete;
GO

CREATE PROCEDURE dbo.sp_Expense_Delete
    @ExpenseID       INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE FROM dbo.Expense
    WHERE ExpenseID = @ExpenseID;
END
GO

-- sp_Expense_GetByProject
IF OBJECT_ID('dbo.sp_Expense_GetByProject', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Expense_GetByProject;
GO

CREATE PROCEDURE dbo.sp_Expense_GetByProject
    @ProjectID       INT,
    @Category        NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT e.ExpenseID, e.ProjectID, e.VendorID, e.Amount, e.ExpenseDate, e.Category, 
           e.Description, e.CreatedDate, e.UpdatedDate,
           v.VendorName
    FROM dbo.Expense e
    LEFT JOIN dbo.Vendor v ON e.VendorID = v.VendorID
    WHERE e.ProjectID = @ProjectID
      AND (@Category IS NULL OR e.Category = @Category)
    ORDER BY e.ExpenseDate DESC;
END
GO

-- sp_Expense_GetSummaryByCategory
IF OBJECT_ID('dbo.sp_Expense_GetSummaryByCategory', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Expense_GetSummaryByCategory;
GO

CREATE PROCEDURE dbo.sp_Expense_GetSummaryByCategory
    @ProjectID       INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        Category,
        SUM(Amount) AS TotalAmount,
        COUNT(ExpenseID) AS ExpenseCount
    FROM dbo.Expense
    WHERE ProjectID = @ProjectID
    GROUP BY Category
    ORDER BY TotalAmount DESC;
END
GO

-- =============================================
-- Vendor Management Stored Procedures
-- =============================================

-- sp_Vendor_Insert
IF OBJECT_ID('dbo.sp_Vendor_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Vendor_Insert;
GO

CREATE PROCEDURE dbo.sp_Vendor_Insert
    @VendorName      NVARCHAR(100),
    @ContactPerson   NVARCHAR(100) = NULL,
    @Phone           NVARCHAR(20) = NULL,
    @Email           NVARCHAR(100) = NULL,
    @VendorType      NVARCHAR(20),
    @VendorID        INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO dbo.Vendor (VendorName, ContactPerson, Phone, Email, VendorType)
    VALUES (@VendorName, @ContactPerson, @Phone, @Email, @VendorType);
    
    SET @VendorID = SCOPE_IDENTITY();
END
GO

-- sp_Vendor_Update
IF OBJECT_ID('dbo.sp_Vendor_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Vendor_Update;
GO

CREATE PROCEDURE dbo.sp_Vendor_Update
    @VendorID        INT,
    @VendorName      NVARCHAR(100),
    @ContactPerson   NVARCHAR(100) = NULL,
    @Phone           NVARCHAR(20) = NULL,
    @Email           NVARCHAR(100) = NULL,
    @VendorType      NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Vendor
    SET VendorName = @VendorName,
        ContactPerson = @ContactPerson,
        Phone = @Phone,
        Email = @Email,
        VendorType = @VendorType
    WHERE VendorID = @VendorID;
END
GO

-- sp_Vendor_Delete
IF OBJECT_ID('dbo.sp_Vendor_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Vendor_Delete;
GO

CREATE PROCEDURE dbo.sp_Vendor_Delete
    @VendorID        INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE FROM dbo.Vendor
    WHERE VendorID = @VendorID;
END
GO

-- sp_Vendor_GetAll
IF OBJECT_ID('dbo.sp_Vendor_GetAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Vendor_GetAll;
GO

CREATE PROCEDURE dbo.sp_Vendor_GetAll
    @VendorType      NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT VendorID, VendorName, ContactPerson, Phone, Email, VendorType, CreatedDate
    FROM dbo.Vendor
    WHERE (@VendorType IS NULL OR VendorType = @VendorType)
    ORDER BY VendorName;
END
GO

-- sp_Vendor_AssignToProject
IF OBJECT_ID('dbo.sp_Vendor_AssignToProject', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Vendor_AssignToProject;
GO

CREATE PROCEDURE dbo.sp_Vendor_AssignToProject
    @ProjectID       INT,
    @VendorID        INT
AS
BEGIN
    SET NOCOUNT ON;
    
    IF NOT EXISTS (SELECT 1 FROM dbo.VendorProject WHERE ProjectID = @ProjectID AND VendorID = @VendorID)
    BEGIN
        INSERT INTO dbo.VendorProject (ProjectID, VendorID)
        VALUES (@ProjectID, @VendorID);
    END
END
GO

-- =============================================
-- Invoice Management Stored Procedures
-- =============================================

-- sp_Invoice_Insert
IF OBJECT_ID('dbo.sp_Invoice_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_Insert;
GO

CREATE PROCEDURE dbo.sp_Invoice_Insert
    @ProjectID       INT,
    @InvoiceNo       NVARCHAR(50),
    @Amount          DECIMAL(18,2),
    @InvoiceDate     DATE,
    @DueDate         DATE,
    @Status          NVARCHAR(20),
    @Notes           NVARCHAR(1000) = NULL,
    @InvoiceID       INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO dbo.Invoice (ProjectID, InvoiceNo, Amount, InvoiceDate, DueDate, Status, Notes)
    VALUES (@ProjectID, @InvoiceNo, @Amount, @InvoiceDate, @DueDate, @Status, @Notes);
    
    SET @InvoiceID = SCOPE_IDENTITY();
END
GO

-- sp_Invoice_Update
IF OBJECT_ID('dbo.sp_Invoice_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_Update;
GO

CREATE PROCEDURE dbo.sp_Invoice_Update
    @InvoiceID       INT,
    @ProjectID       INT,
    @InvoiceNo       NVARCHAR(50),
    @Amount          DECIMAL(18,2),
    @InvoiceDate     DATE,
    @DueDate         DATE,
    @Status          NVARCHAR(20),
    @Notes           NVARCHAR(1000) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Invoice
    SET ProjectID = @ProjectID,
        InvoiceNo = @InvoiceNo,
        Amount = @Amount,
        InvoiceDate = @InvoiceDate,
        DueDate = @DueDate,
        Status = @Status,
        Notes = @Notes
    WHERE InvoiceID = @InvoiceID;
END
GO

-- sp_Invoice_Delete
IF OBJECT_ID('dbo.sp_Invoice_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_Delete;
GO

CREATE PROCEDURE dbo.sp_Invoice_Delete
    @InvoiceID       INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE FROM dbo.Invoice
    WHERE InvoiceID = @InvoiceID;
END
GO

-- sp_Invoice_GetByProject
IF OBJECT_ID('dbo.sp_Invoice_GetByProject', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_GetByProject;
GO

CREATE PROCEDURE dbo.sp_Invoice_GetByProject
    @ProjectID       INT,
    @Status          NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT InvoiceID, ProjectID, InvoiceNo, Amount, InvoiceDate, DueDate, Status, Notes, CreatedDate, UpdatedDate
    FROM dbo.Invoice
    WHERE ProjectID = @ProjectID
      AND (@Status IS NULL OR Status = @Status)
    ORDER BY InvoiceDate DESC;
END
GO

-- sp_Invoice_UpdateStatus
IF OBJECT_ID('dbo.sp_Invoice_UpdateStatus', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_UpdateStatus;
GO

CREATE PROCEDURE dbo.sp_Invoice_UpdateStatus
    @InvoiceID       INT,
    @Status          NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Invoice
    SET Status = @Status
    WHERE InvoiceID = @InvoiceID;
END
GO

-- =============================================
-- Reporting Stored Procedures
-- =============================================

-- sp_Report_BudgetVsActual
IF OBJECT_ID('dbo.sp_Report_BudgetVsActual', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Report_BudgetVsActual;
GO

CREATE PROCEDURE dbo.sp_Report_BudgetVsActual
    @ProjectID       INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.ProjectID,
        p.ProjectCode,
        p.ProjectName,
        p.Budget AS BudgetAmount,
        ISNULL(SUM(e.Amount), 0) AS ActualAmount,
        p.Budget - ISNULL(SUM(e.Amount), 0) AS Variance,
        CASE 
            WHEN p.Budget > ISNULL(SUM(e.Amount), 0) THEN 'Under Budget'
            WHEN p.Budget < ISNULL(SUM(e.Amount), 0) THEN 'Over Budget'
            ELSE 'On Budget'
        END AS BudgetStatus
    FROM dbo.Project p
    LEFT JOIN dbo.Expense e ON p.ProjectID = e.ProjectID
    WHERE (@ProjectID IS NULL OR p.ProjectID = @ProjectID)
    GROUP BY p.ProjectID, p.ProjectCode, p.ProjectName, p.Budget
    ORDER BY p.ProjectCode;
END
GO

-- sp_Report_ProjectProfitability
IF OBJECT_ID('dbo.sp_Report_ProjectProfitability', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Report_ProjectProfitability;
GO

CREATE PROCEDURE dbo.sp_Report_ProjectProfitability
    @ProjectID       INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.ProjectID,
        p.ProjectCode,
        p.ProjectName,
        p.Budget,
        ISNULL(SUM(e.Amount), 0) AS TotalExpenses,
        ISNULL(SUM(i.Amount), 0) AS TotalInvoices,
        ISNULL(SUM(i.Amount), 0) - ISNULL(SUM(e.Amount), 0) AS Profit,
        CASE 
            WHEN ISNULL(SUM(i.Amount), 0) - ISNULL(SUM(e.Amount), 0) > 0 THEN 'Profitable'
            WHEN ISNULL(SUM(i.Amount), 0) - ISNULL(SUM(e.Amount), 0) < 0 THEN 'Loss'
            ELSE 'Break Even'
        END AS ProfitabilityStatus
    FROM dbo.Project p
    LEFT JOIN dbo.Expense e ON p.ProjectID = e.ProjectID
    LEFT JOIN dbo.Invoice i ON p.ProjectID = i.ProjectID AND i.Status = 'Paid'
    WHERE (@ProjectID IS NULL OR p.ProjectID = @ProjectID)
    GROUP BY p.ProjectID, p.ProjectCode, p.ProjectName, p.Budget
    ORDER BY Profit DESC;
END
GO

-- sp_Report_OutstandingInvoices
IF OBJECT_ID('dbo.sp_Report_OutstandingInvoices', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Report_OutstandingInvoices;
GO

CREATE PROCEDURE dbo.sp_Report_OutstandingInvoices
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        i.InvoiceID,
        i.InvoiceNo,
        p.ProjectCode,
        p.ProjectName,
        i.Amount,
        i.InvoiceDate,
        i.DueDate,
        i.Status,
        DATEDIFF(DAY, GETDATE(), i.DueDate) AS DaysUntilDue,
        CASE 
            WHEN DATEDIFF(DAY, GETDATE(), i.DueDate) < 0 THEN 'Overdue'
            WHEN DATEDIFF(DAY, GETDATE(), i.DueDate) <= 7 THEN 'Due Soon'
            ELSE 'Not Due Yet'
        END AS Urgency
    FROM dbo.Invoice i
    INNER JOIN dbo.Project p ON i.ProjectID = p.ProjectID
    WHERE i.Status IN ('Sent', 'Overdue')
    ORDER BY i.DueDate ASC;
END
GO

-- sp_Report_VendorPayments
IF OBJECT_ID('dbo.sp_Report_VendorPayments', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Report_VendorPayments;
GO

CREATE PROCEDURE dbo.sp_Report_VendorPayments
    @VendorID        INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        v.VendorID,
        v.VendorName,
        v.VendorType,
        COUNT(e.ExpenseID) AS TotalExpenses,
        SUM(e.Amount) AS TotalAmount,
        MAX(e.ExpenseDate) AS LastExpenseDate
    FROM dbo.Vendor v
    LEFT JOIN dbo.Expense e ON v.VendorID = e.VendorID
    WHERE (@VendorID IS NULL OR v.VendorID = @VendorID)
    GROUP BY v.VendorID, v.VendorName, v.VendorType
    ORDER BY TotalAmount DESC;
END
GO

PRINT 'All stored procedures created successfully.';
GO
