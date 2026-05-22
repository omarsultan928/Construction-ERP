Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class DashboardForm

    Private ReadOnly _dashRepo As IDashboardRepository = New DashboardRepository()

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user = SessionManager.CurrentUser
        btnCreateProject.Visible = user IsNot Nothing AndAlso user.Role = RoleHelper.ProjectManager
        LoadWidgets()
    End Sub

    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Using frm As New ProjectForm()
            frm.ShowDialog(Me)
        End Using
        LoadWidgets()
    End Sub

    Private Sub LoadWidgets()
        Try
            Dim summary = _dashRepo.GetSummary()

            lblActiveProjectsValue.Text = summary.ActiveProjects.ToString()
            lblTotalExpensesValue.Text = FormatCurrency(summary.TotalExpenses)
            lblOutstandingInvValue.Text = FormatCurrency(summary.OutstandingInvoices)

            If summary.ProfitLoss >= 0 Then
                lblProfitLossValue.Text = FormatCurrency(summary.ProfitLoss)
                pnlProfitLoss.Appearance.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
            Else
                lblProfitLossValue.Text = "(" & FormatCurrency(Math.Abs(summary.ProfitLoss)) & ")"
                pnlProfitLoss.Appearance.BackColor = System.Drawing.Color.FromArgb(180, 40, 40)
            End If
            pnlProfitLoss.Appearance.Options.UseBackColor = True
        Catch ex As Exception
            ' Leave widget values as default if data load fails
        End Try
    End Sub

    Private Function FormatCurrency(value As Decimal) As String
        Return "$" & value.ToString("N0")
    End Function

End Class
