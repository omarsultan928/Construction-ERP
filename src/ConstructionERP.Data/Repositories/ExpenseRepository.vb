Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports ConstructionERP.Core

Public Class ExpenseRepository
    Implements IExpenseRepository

    Public Function GetByProject(projectId As Integer, Optional category As String = Nothing) As List(Of Expense) Implements IExpenseRepository.GetByProject
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", projectId),
            New SqlParameter("@Category", If(String.IsNullOrWhiteSpace(category), DBNull.Value, CObj(category)))
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Expense_GetByProject", parameters)
        Dim expenses As New List(Of Expense)

        For Each row As DataRow In dataTable.Rows
            expenses.Add(MapExpenseRow(row))
        Next

        Return expenses
    End Function

    Public Function GetSummaryByCategory(projectId As Integer) As List(Of ExpenseCategorySummary) Implements IExpenseRepository.GetSummaryByCategory
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", projectId)
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Expense_GetSummaryByCategory", parameters)
        Dim summaries As New List(Of ExpenseCategorySummary)

        Dim grandTotal As Decimal = 0
        For Each row As DataRow In dataTable.Rows
            grandTotal += Convert.ToDecimal(row("TotalAmount"))
        Next

        For Each row As DataRow In dataTable.Rows
            Dim amount = Convert.ToDecimal(row("TotalAmount"))
            summaries.Add(New ExpenseCategorySummary With {
                .Category = row("Category").ToString(),
                .TotalAmount = amount,
                .ExpenseCount = Convert.ToInt32(row("ExpenseCount")),
                .PercentageOfTotal = If(grandTotal > 0, Math.Round(amount / grandTotal * 100, 1), 0)
            })
        Next

        Return summaries
    End Function

    Public Function Insert(expense As Expense) As Integer Implements IExpenseRepository.Insert
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", expense.ProjectID),
            New SqlParameter("@VendorID", If(expense.VendorID.HasValue, expense.VendorID.Value, DBNull.Value)),
            New SqlParameter("@Amount", expense.Amount),
            New SqlParameter("@ExpenseDate", expense.ExpenseDate),
            New SqlParameter("@Category", expense.Category),
            New SqlParameter("@Description", If(String.IsNullOrWhiteSpace(expense.Description), DBNull.Value, CObj(expense.Description))),
            New SqlParameter("@ExpenseID", SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Expense_Insert", parameters)
        Return Convert.ToInt32(parameters(parameters.Length - 1).Value)
    End Function

    Public Sub Update(expense As Expense) Implements IExpenseRepository.Update
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ExpenseID", expense.ExpenseID),
            New SqlParameter("@ProjectID", expense.ProjectID),
            New SqlParameter("@VendorID", If(expense.VendorID.HasValue, expense.VendorID.Value, DBNull.Value)),
            New SqlParameter("@Amount", expense.Amount),
            New SqlParameter("@ExpenseDate", expense.ExpenseDate),
            New SqlParameter("@Category", expense.Category),
            New SqlParameter("@Description", If(String.IsNullOrWhiteSpace(expense.Description), DBNull.Value, CObj(expense.Description)))
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Expense_Update", parameters)
    End Sub

    Public Sub Delete(expenseId As Integer) Implements IExpenseRepository.Delete
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ExpenseID", expenseId)
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Expense_Delete", parameters)
    End Sub

    Private Shared Function MapExpenseRow(row As DataRow) As Expense
        Return New Expense With {
            .ExpenseID = Convert.ToInt32(row("ExpenseID")),
            .ProjectID = Convert.ToInt32(row("ProjectID")),
            .VendorID = If(row("VendorID") Is DBNull.Value, Nothing, Convert.ToInt32(row("VendorID"))),
            .VendorName = If(row("VendorName") Is DBNull.Value, String.Empty, row("VendorName").ToString()),
            .Amount = Convert.ToDecimal(row("Amount")),
            .ExpenseDate = Convert.ToDateTime(row("ExpenseDate")),
            .Category = row("Category").ToString(),
            .Description = If(row("Description") Is DBNull.Value, String.Empty, row("Description").ToString()),
            .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
            .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
        }
    End Function

End Class
