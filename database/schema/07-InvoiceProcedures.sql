-- =============================================
-- Additional Invoice procedures
-- Run on existing databases after 02-05 scripts
-- =============================================

USE [ConstructionERP];
GO

IF OBJECT_ID('dbo.sp_Invoice_GetAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_GetAll;
GO

CREATE PROCEDURE dbo.sp_Invoice_GetAll
    @Status NVARCHAR(20) = NULL,
    @ProjectID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT i.InvoiceID, i.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName,
           i.InvoiceNo, i.Amount, i.InvoiceDate, i.DueDate, i.Status, i.Notes,
           i.CreatedDate, i.UpdatedDate
    FROM dbo.Invoice i
    INNER JOIN dbo.Project p ON i.ProjectID = p.ProjectID
    WHERE (@Status IS NULL OR i.Status = @Status)
      AND (@ProjectID IS NULL OR i.ProjectID = @ProjectID)
    ORDER BY i.InvoiceDate DESC, i.InvoiceNo;
END
GO

IF OBJECT_ID('dbo.sp_Invoice_GetByNo', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_GetByNo;
GO

CREATE PROCEDURE dbo.sp_Invoice_GetByNo
    @InvoiceNo NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT i.InvoiceID, i.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName,
           i.InvoiceNo, i.Amount, i.InvoiceDate, i.DueDate, i.Status, i.Notes,
           i.CreatedDate, i.UpdatedDate
    FROM dbo.Invoice i
    INNER JOIN dbo.Project p ON i.ProjectID = p.ProjectID
    WHERE i.InvoiceNo = @InvoiceNo;
END
GO

IF OBJECT_ID('dbo.sp_Invoice_GetById', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Invoice_GetById;
GO

CREATE PROCEDURE dbo.sp_Invoice_GetById
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT i.InvoiceID, i.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName,
           i.InvoiceNo, i.Amount, i.InvoiceDate, i.DueDate, i.Status, i.Notes,
           i.CreatedDate, i.UpdatedDate
    FROM dbo.Invoice i
    INNER JOIN dbo.Project p ON i.ProjectID = p.ProjectID
    WHERE i.InvoiceID = @InvoiceID;
END
GO

PRINT 'Invoice procedures created.';
GO
