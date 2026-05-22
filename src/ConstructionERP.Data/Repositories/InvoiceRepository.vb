Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports ConstructionERP.Core

Public Class InvoiceRepository
    Implements IInvoiceRepository

    Public Function GetAll(Optional status As String = Nothing, Optional projectId As Integer? = Nothing) As List(Of Invoice) Implements IInvoiceRepository.GetAll
        Dim parameters As SqlParameter() = {
            New SqlParameter("@Status", If(String.IsNullOrWhiteSpace(status), DBNull.Value, status)),
            New SqlParameter("@ProjectID", If(projectId.HasValue, projectId.Value, DBNull.Value))
        }

        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Invoice_GetAll", parameters)
        Return MapInvoiceRows(dataTable)
    End Function

    Public Function GetById(invoiceId As Integer) As Invoice Implements IInvoiceRepository.GetById
        Dim parameters As SqlParameter() = {New SqlParameter("@InvoiceID", invoiceId)}
        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Invoice_GetById", parameters)
        If dataTable.Rows.Count = 0 Then Return Nothing
        Return MapInvoiceRow(dataTable.Rows(0))
    End Function

    Public Function GetByInvoiceNo(invoiceNo As String) As Invoice Implements IInvoiceRepository.GetByInvoiceNo
        Dim parameters As SqlParameter() = {New SqlParameter("@InvoiceNo", invoiceNo)}
        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Invoice_GetByNo", parameters)
        If dataTable.Rows.Count = 0 Then Return Nothing
        Return MapInvoiceRow(dataTable.Rows(0))
    End Function

    Public Function GetOutstanding() As List(Of Invoice) Implements IInvoiceRepository.GetOutstanding
        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Report_OutstandingInvoices")
        Dim invoices As New List(Of Invoice)

        For Each row As DataRow In dataTable.Rows
            invoices.Add(New Invoice With {
                .InvoiceID = Convert.ToInt32(row("InvoiceID")),
                .InvoiceNo = row("InvoiceNo").ToString(),
                .ProjectCode = row("ProjectCode").ToString(),
                .ProjectName = row("ProjectName").ToString(),
                .Amount = Convert.ToDecimal(row("Amount")),
                .InvoiceDate = Convert.ToDateTime(row("InvoiceDate")),
                .DueDate = Convert.ToDateTime(row("DueDate")),
                .Status = row("Status").ToString(),
                .DaysUntilDue = Convert.ToInt32(row("DaysUntilDue")),
                .Urgency = row("Urgency").ToString()
            })
        Next

        Return invoices
    End Function

    Public Function Insert(invoice As Invoice) As Integer Implements IInvoiceRepository.Insert
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", invoice.ProjectID),
            New SqlParameter("@InvoiceNo", invoice.InvoiceNo),
            New SqlParameter("@Amount", invoice.Amount),
            New SqlParameter("@InvoiceDate", invoice.InvoiceDate),
            New SqlParameter("@DueDate", invoice.DueDate),
            New SqlParameter("@Status", invoice.Status),
            New SqlParameter("@Notes", If(String.IsNullOrWhiteSpace(invoice.Notes), DBNull.Value, invoice.Notes)),
            New SqlParameter("@InvoiceID", SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Invoice_Insert", parameters)
        Return Convert.ToInt32(parameters(parameters.Length - 1).Value)
    End Function

    Public Sub Update(invoice As Invoice) Implements IInvoiceRepository.Update
        Dim parameters As SqlParameter() = {
            New SqlParameter("@InvoiceID", invoice.InvoiceID),
            New SqlParameter("@ProjectID", invoice.ProjectID),
            New SqlParameter("@InvoiceNo", invoice.InvoiceNo),
            New SqlParameter("@Amount", invoice.Amount),
            New SqlParameter("@InvoiceDate", invoice.InvoiceDate),
            New SqlParameter("@DueDate", invoice.DueDate),
            New SqlParameter("@Status", invoice.Status),
            New SqlParameter("@Notes", If(String.IsNullOrWhiteSpace(invoice.Notes), DBNull.Value, invoice.Notes))
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Invoice_Update", parameters)
    End Sub

    Public Sub UpdateStatus(invoiceId As Integer, status As String) Implements IInvoiceRepository.UpdateStatus
        Dim parameters As SqlParameter() = {
            New SqlParameter("@InvoiceID", invoiceId),
            New SqlParameter("@Status", status)
        }
        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Invoice_UpdateStatus", parameters)
    End Sub

    Public Sub Delete(invoiceId As Integer) Implements IInvoiceRepository.Delete
        Dim parameters As SqlParameter() = {New SqlParameter("@InvoiceID", invoiceId)}
        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Invoice_Delete", parameters)
    End Sub

    Private Shared Function MapInvoiceRows(dataTable As DataTable) As List(Of Invoice)
        Dim invoices As New List(Of Invoice)
        For Each row As DataRow In dataTable.Rows
            invoices.Add(MapInvoiceRow(row))
        Next
        Return invoices
    End Function

    Private Shared Function MapInvoiceRow(row As DataRow) As Invoice
        Return New Invoice With {
            .InvoiceID = Convert.ToInt32(row("InvoiceID")),
            .ProjectID = Convert.ToInt32(row("ProjectID")),
            .ProjectCode = row("ProjectCode").ToString(),
            .ProjectName = row("ProjectName").ToString(),
            .ClientName = row("ClientName").ToString(),
            .InvoiceNo = row("InvoiceNo").ToString(),
            .Amount = Convert.ToDecimal(row("Amount")),
            .InvoiceDate = Convert.ToDateTime(row("InvoiceDate")),
            .DueDate = Convert.ToDateTime(row("DueDate")),
            .Status = row("Status").ToString(),
            .Notes = If(row("Notes") Is DBNull.Value, Nothing, row("Notes").ToString()),
            .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
            .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
        }
    End Function
End Class
