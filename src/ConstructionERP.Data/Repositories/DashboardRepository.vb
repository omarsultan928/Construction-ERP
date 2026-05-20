Imports ConstructionERP.Core

Public Class DashboardRepository

    Public Function GetSummary() As DashboardSummary
        Dim summary As New DashboardSummary()
        Try
            Dim sql As String =
                "SELECT " &
                "(SELECT COUNT(*) FROM dbo.Project WHERE Status NOT IN ('Completed', 'Cancelled')) AS ActiveProjects, " &
                "(SELECT ISNULL(SUM(Amount), 0) FROM dbo.Expense) AS TotalExpenses, " &
                "(SELECT ISNULL(SUM(Amount), 0) FROM dbo.Invoice WHERE Status IN ('Sent', 'Overdue')) AS OutstandingInvoices, " &
                "ISNULL((SELECT ISNULL(SUM(Amount), 0) FROM dbo.Invoice WHERE Status = 'Paid'), 0) - " &
                "ISNULL((SELECT ISNULL(SUM(Amount), 0) FROM dbo.Expense), 0) AS ProfitLoss"

            Dim dt = DatabaseHelper.ExecuteQuery(sql)
            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                summary.ActiveProjects = Convert.ToInt32(row("ActiveProjects"))
                summary.TotalExpenses = Convert.ToDecimal(row("TotalExpenses"))
                summary.OutstandingInvoices = Convert.ToDecimal(row("OutstandingInvoices"))
                summary.ProfitLoss = Convert.ToDecimal(row("ProfitLoss"))
            End If
        Catch ex As Exception
            ' Return zeroed summary if DB is unavailable
        End Try
        Return summary
    End Function

End Class
