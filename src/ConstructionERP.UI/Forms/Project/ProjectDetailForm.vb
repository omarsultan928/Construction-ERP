Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class ProjectDetailForm

    Private ReadOnly _projectId As Integer
    Private ReadOnly _projectRepo As New ProjectRepository()

    Public Sub New(projectId As Integer)
        _projectId = projectId
        InitializeComponent()
    End Sub

    Private Sub ProjectDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoleVisibility()
        LoadSummary()
    End Sub

    Private Sub ApplyRoleVisibility()
        Dim role = SessionManager.CurrentUser.Role
        btnViewExpenses.Visible = RoleHelper.CanViewExpenses(role)
        btnExpenseSummary.Visible = RoleHelper.CanViewExpenseSummary(role)
    End Sub

    Private Sub LoadSummary()
        Try
            Dim summary = _projectRepo.GetSummary(_projectId)
            If summary Is Nothing Then
                lblError.Text = "Project summary not found."
                lblError.Visible = True
                Return
            End If

            lblError.Visible = False
            Me.Text = $"Project Details - {summary.ProjectCode}"
            lblProjectTitle.Text = summary.ProjectName
            lblProjectMeta.Text = $"{summary.ProjectCode}  |  {summary.ClientName}  |  {summary.Status}"
            lblBudgetValue.Text = FormatCurrency(summary.Budget)
            lblDateRange.Text = $"{summary.StartDate:yyyy-MM-dd} to {If(summary.EndDate.HasValue, summary.EndDate.Value.ToString("yyyy-MM-dd"), "Ongoing")}"

            lblTotalExpensesValue.Text = FormatCurrency(summary.TotalExpenses)
            lblRemainingBudgetValue.Text = FormatCurrency(summary.RemainingBudget)
            lblInvoiceTotalsValue.Text = FormatCurrency(summary.TotalInvoices)

            If summary.EstimatedProfit >= 0 Then
                lblProfitLossValue.Text = FormatCurrency(summary.EstimatedProfit)
                pnlProfitLoss.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
            Else
                lblProfitLossValue.Text = "(" & FormatCurrency(Math.Abs(summary.EstimatedProfit)) & ")"
                pnlProfitLoss.BackColor = System.Drawing.Color.FromArgb(180, 40, 40)
            End If

            If summary.RemainingBudget < 0 Then
                pnlRemainingBudget.BackColor = System.Drawing.Color.FromArgb(180, 40, 40)
            Else
                pnlRemainingBudget.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
            End If
        Catch ex As Exception
            lblError.Text = "Failed to load project summary: " & ex.Message
            lblError.Visible = True
        End Try
    End Sub

    Private Function FormatCurrency(value As Decimal) As String
        Return "$" & value.ToString("N0")
    End Function

    Private Sub btnViewExpenses_Click(sender As Object, e As EventArgs) Handles btnViewExpenses.Click
        Using frm As New ExpenseListForm(_projectId)
            frm.ShowDialog(Me)
        End Using
        LoadSummary()
    End Sub

    Private Sub btnExpenseSummary_Click(sender As Object, e As EventArgs) Handles btnExpenseSummary.Click
        Using frm As New ExpenseSummaryForm(_projectId)
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
