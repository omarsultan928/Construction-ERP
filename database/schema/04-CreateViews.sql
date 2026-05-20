-- =============================================
-- Construction ERP MVP - Views Creation Script
-- =============================================
-- Author: Construction ERP Team
-- Date: 2024
-- Description: Creates views for reporting and data aggregation
-- =============================================

USE [ConstructionERP];
GO

PRINT 'Creating views...';
GO

-- =============================================
-- View: vw_ProjectSummary
-- =============================================
IF OBJECT_ID('dbo.vw_ProjectSummary', 'V') IS NOT NULL
    DROP VIEW dbo.vw_ProjectSummary;
GO

CREATE VIEW dbo.vw_ProjectSummary
AS
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
    ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) AS TotalPaidInvoices,
    ISNULL(SUM(i.Amount), 0) AS TotalInvoices,
    p.Budget - ISNULL(SUM(e.Amount), 0) AS RemainingBudget,
    ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) - ISNULL(SUM(e.Amount), 0) AS EstimatedProfit,
    CASE 
        WHEN p.Budget - ISNULL(SUM(e.Amount), 0) < 0 THEN 'Over Budget'
        WHEN p.Budget - ISNULL(SUM(e.Amount), 0) > 0 THEN 'Under Budget'
        ELSE 'On Budget'
    END AS BudgetStatus
FROM dbo.Project p
LEFT JOIN dbo.Expense e ON p.ProjectID = e.ProjectID
LEFT JOIN dbo.Invoice i ON p.ProjectID = i.ProjectID
GROUP BY p.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName, 
         p.Budget, p.StartDate, p.EndDate, p.Status;
GO

-- =============================================
-- View: vw_ExpenseByCategory
-- =============================================
IF OBJECT_ID('dbo.vw_ExpenseByCategory', 'V') IS NOT NULL
    DROP VIEW dbo.vw_ExpenseByCategory;
GO

CREATE VIEW dbo.vw_ExpenseByCategory
AS
SELECT 
    p.ProjectID,
    p.ProjectCode,
    p.ProjectName,
    e.Category,
    SUM(e.Amount) AS TotalAmount,
    COUNT(e.ExpenseID) AS ExpenseCount,
    CAST(SUM(e.Amount) * 100.0 / SUM(SUM(e.Amount)) OVER (PARTITION BY p.ProjectID) AS DECIMAL(5,2)) AS PercentageOfTotal
FROM dbo.Project p
INNER JOIN dbo.Expense e ON p.ProjectID = e.ProjectID
GROUP BY p.ProjectID, p.ProjectCode, p.ProjectName, e.Category;
GO

-- =============================================
-- View: vw_OutstandingInvoices
-- =============================================
IF OBJECT_ID('dbo.vw_OutstandingInvoices', 'V') IS NOT NULL
    DROP VIEW dbo.vw_OutstandingInvoices;
GO

CREATE VIEW dbo.vw_OutstandingInvoices
AS
SELECT 
    i.InvoiceID,
    i.InvoiceNo,
    i.ProjectID,
    p.ProjectCode,
    p.ProjectName,
    i.Amount,
    i.InvoiceDate,
    i.DueDate,
    i.Status,
    DATEDIFF(DAY, GETDATE(), i.DueDate) AS DaysUntilDue,
    CASE 
        WHEN i.Status = 'Overdue' THEN 'Overdue'
        WHEN DATEDIFF(DAY, GETDATE(), i.DueDate) < 0 THEN 'Overdue'
        WHEN DATEDIFF(DAY, GETDATE(), i.DueDate) <= 7 THEN 'Due Soon'
        ELSE 'Not Due Yet'
    END AS Urgency
FROM dbo.Invoice i
INNER JOIN dbo.Project p ON i.ProjectID = p.ProjectID
WHERE i.Status IN ('Sent', 'Overdue');
GO

-- =============================================
-- View: vw_VendorProjectSummary
-- =============================================
IF OBJECT_ID('dbo.vw_VendorProjectSummary', 'V') IS NOT NULL
    DROP VIEW dbo.vw_VendorProjectSummary;
GO

CREATE VIEW dbo.vw_VendorProjectSummary
AS
SELECT 
    vp.VPID,
    vp.ProjectID,
    p.ProjectCode,
    p.ProjectName,
    vp.VendorID,
    v.VendorName,
    v.VendorType,
    vp.AssignedDate,
    ISNULL(SUM(e.Amount), 0) AS TotalExpensesWithVendor,
    COUNT(e.ExpenseID) AS ExpenseCount
FROM dbo.VendorProject vp
INNER JOIN dbo.Project p ON vp.ProjectID = p.ProjectID
INNER JOIN dbo.Vendor v ON vp.VendorID = v.VendorID
LEFT JOIN dbo.Expense e ON vp.ProjectID = e.ProjectID AND vp.VendorID = e.VendorID
GROUP BY vp.VPID, vp.ProjectID, p.ProjectCode, p.ProjectName, 
         vp.VendorID, v.VendorName, v.VendorType, vp.AssignedDate;
GO

-- =============================================
-- View: vw_DashboardOverview
-- =============================================
IF OBJECT_ID('dbo.vw_DashboardOverview', 'V') IS NOT NULL
    DROP VIEW dbo.vw_DashboardOverview;
GO

CREATE VIEW dbo.vw_DashboardOverview
AS
SELECT 
    (SELECT COUNT(*) FROM dbo.Project WHERE Status = 'Active') AS ActiveProjects,
    (SELECT COUNT(*) FROM dbo.Project WHERE Status = 'Completed') AS CompletedProjects,
    (SELECT ISNULL(SUM(Amount), 0) FROM dbo.Expense) AS TotalExpenses,
    (SELECT ISNULL(SUM(Amount), 0) FROM dbo.Invoice WHERE Status = 'Sent') AS OutstandingInvoices,
    (SELECT ISNULL(SUM(Amount), 0) FROM dbo.Invoice WHERE Status = 'Paid') AS PaidInvoices,
    (SELECT COUNT(*) FROM dbo.Vendor) AS TotalVendors,
    (SELECT COUNT(*) FROM dbo.[User] WHERE IsActive = 1) AS ActiveUsers;
GO

-- =============================================
-- View: vw_ProjectProfitability
-- =============================================
IF OBJECT_ID('dbo.vw_ProjectProfitability', 'V') IS NOT NULL
    DROP VIEW dbo.vw_ProjectProfitability;
GO

CREATE VIEW dbo.vw_ProjectProfitability
AS
SELECT 
    p.ProjectID,
    p.ProjectCode,
    p.ProjectName,
    p.ClientName,
    p.Budget,
    ISNULL(SUM(e.Amount), 0) AS TotalExpenses,
    ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) AS TotalRevenue,
    ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) - ISNULL(SUM(e.Amount), 0) AS NetProfit,
    CASE 
        WHEN ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) - ISNULL(SUM(e.Amount), 0) > 0 THEN 'Profitable'
        WHEN ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) - ISNULL(SUM(e.Amount), 0) < 0 THEN 'Loss'
        ELSE 'Break Even'
    END AS ProfitabilityStatus,
    CAST((ISNULL(SUM(CASE WHEN i.Status = 'Paid' THEN i.Amount ELSE 0 END), 0) - ISNULL(SUM(e.Amount), 0)) * 100.0 / NULLIF(p.Budget, 0) AS DECIMAL(5,2)) AS ProfitMarginPercentage
FROM dbo.Project p
LEFT JOIN dbo.Expense e ON p.ProjectID = e.ProjectID
LEFT JOIN dbo.Invoice i ON p.ProjectID = i.ProjectID
GROUP BY p.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName, p.Budget;
GO

PRINT 'All views created successfully.';
GO
