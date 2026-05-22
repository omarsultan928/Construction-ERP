-- =============================================
-- Vendor Payment Tracking (US-12)
-- Run after 02-05 scripts on existing databases
-- =============================================

USE [ConstructionERP];
GO

IF OBJECT_ID('dbo.VendorPayment', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.VendorPayment
    (
        PaymentID       INT              IDENTITY(1,1) NOT NULL,
        VendorID        INT              NOT NULL,
        ProjectID       INT              NULL,
        Description     NVARCHAR(200)    NULL,
        AmountDue       DECIMAL(18,2)    NOT NULL,
        AmountPaid      DECIMAL(18,2)    NOT NULL DEFAULT 0,
        DueDate         DATE             NULL,
        Notes           NVARCHAR(500)    NULL,
        CreatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
        UpdatedDate     DATETIME         NOT NULL DEFAULT GETDATE(),
        CONSTRAINT PK_VendorPayment PRIMARY KEY CLUSTERED (PaymentID ASC),
        CONSTRAINT FK_VendorPayment_Vendor FOREIGN KEY (VendorID)
            REFERENCES dbo.Vendor (VendorID) ON DELETE CASCADE,
        CONSTRAINT FK_VendorPayment_Project FOREIGN KEY (ProjectID)
            REFERENCES dbo.Project (ProjectID) ON DELETE SET NULL
    );

    CREATE NONCLUSTERED INDEX IX_VendorPayment_Vendor ON dbo.VendorPayment (VendorID);
    CREATE NONCLUSTERED INDEX IX_VendorPayment_Project ON dbo.VendorPayment (ProjectID);
END
GO

IF OBJECT_ID('dbo.sp_Vendor_GetProjectAssignments', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_Vendor_GetProjectAssignments;
GO

CREATE PROCEDURE dbo.sp_Vendor_GetProjectAssignments
    @ProjectID INT = NULL,
    @VendorID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT vp.VPID, vp.ProjectID, p.ProjectCode, p.ProjectName,
           vp.VendorID, v.VendorName, v.VendorType, vp.AssignedDate
    FROM dbo.VendorProject vp
    INNER JOIN dbo.Project p ON vp.ProjectID = p.ProjectID
    INNER JOIN dbo.Vendor v ON vp.VendorID = v.VendorID
    WHERE (@ProjectID IS NULL OR vp.ProjectID = @ProjectID)
      AND (@VendorID IS NULL OR vp.VendorID = @VendorID)
    ORDER BY vp.AssignedDate DESC;
END
GO

IF OBJECT_ID('dbo.sp_VendorPayment_GetAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_VendorPayment_GetAll;
GO

CREATE PROCEDURE dbo.sp_VendorPayment_GetAll
    @VendorID INT = NULL,
    @PaymentStatus NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT vp.PaymentID, vp.VendorID, v.VendorName, vp.ProjectID,
           p.ProjectCode, p.ProjectName, vp.Description, vp.AmountDue,
           vp.AmountPaid, vp.DueDate, vp.Notes, vp.CreatedDate, vp.UpdatedDate,
           CASE
               WHEN vp.AmountPaid <= 0 THEN 'Pending'
               WHEN vp.AmountPaid < vp.AmountDue THEN 'Partial'
               ELSE 'Paid'
           END AS PaymentStatus,
           vp.AmountDue - vp.AmountPaid AS BalanceDue
    FROM dbo.VendorPayment vp
    INNER JOIN dbo.Vendor v ON vp.VendorID = v.VendorID
    LEFT JOIN dbo.Project p ON vp.ProjectID = p.ProjectID
    WHERE (@VendorID IS NULL OR vp.VendorID = @VendorID)
      AND (@PaymentStatus IS NULL OR
           CASE
               WHEN vp.AmountPaid <= 0 THEN 'Pending'
               WHEN vp.AmountPaid < vp.AmountDue THEN 'Partial'
               ELSE 'Paid'
           END = @PaymentStatus)
    ORDER BY vp.DueDate DESC, v.VendorName;
END
GO

IF OBJECT_ID('dbo.sp_VendorPayment_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_VendorPayment_Insert;
GO

CREATE PROCEDURE dbo.sp_VendorPayment_Insert
    @VendorID INT,
    @ProjectID INT = NULL,
    @Description NVARCHAR(200) = NULL,
    @AmountDue DECIMAL(18,2),
    @AmountPaid DECIMAL(18,2) = 0,
    @DueDate DATE = NULL,
    @Notes NVARCHAR(500) = NULL,
    @PaymentID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.VendorPayment (VendorID, ProjectID, Description, AmountDue, AmountPaid, DueDate, Notes)
    VALUES (@VendorID, @ProjectID, @Description, @AmountDue, @AmountPaid, @DueDate, @Notes);

    SET @PaymentID = SCOPE_IDENTITY();
END
GO

IF OBJECT_ID('dbo.sp_VendorPayment_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_VendorPayment_Update;
GO

CREATE PROCEDURE dbo.sp_VendorPayment_Update
    @PaymentID INT,
    @VendorID INT,
    @ProjectID INT = NULL,
    @Description NVARCHAR(200) = NULL,
    @AmountDue DECIMAL(18,2),
    @AmountPaid DECIMAL(18,2),
    @DueDate DATE = NULL,
    @Notes NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.VendorPayment
    SET VendorID = @VendorID,
        ProjectID = @ProjectID,
        Description = @Description,
        AmountDue = @AmountDue,
        AmountPaid = @AmountPaid,
        DueDate = @DueDate,
        Notes = @Notes,
        UpdatedDate = GETDATE()
    WHERE PaymentID = @PaymentID;
END
GO

IF OBJECT_ID('dbo.sp_VendorPayment_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_VendorPayment_Delete;
GO

CREATE PROCEDURE dbo.sp_VendorPayment_Delete
    @PaymentID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.VendorPayment WHERE PaymentID = @PaymentID;
END
GO

PRINT 'Vendor payment schema and procedures created.';
GO
