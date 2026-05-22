Imports ConstructionERP.Core

Public Class DashboardRepository
    Implements IDashboardRepository

    Public Function GetSummary() As DashboardSummary Implements IDashboardRepository.GetSummary
        Dim summary As New DashboardSummary()
        Try
            Dim dt = DatabaseHelper.ExecuteStoredProcedure("sp_Dashboard_GetSummary")
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
