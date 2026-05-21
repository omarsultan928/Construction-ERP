Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class ExpenseSummaryForm

    Private ReadOnly _projectId As Integer
    Private ReadOnly _expenseRepo As IExpenseRepository
    Private ReadOnly _projectRepo As IProjectRepository

    Public Sub New(projectId As Integer)
        InitializeComponent()
        _projectId = projectId
        _expenseRepo = New ExpenseRepository()
        _projectRepo = New ProjectRepository()
    End Sub

    Private Sub ExpenseSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSummary()
    End Sub

    Private Sub LoadSummary()
        Try
            ' Load project info + budget figures
            Dim summary = _projectRepo.GetSummary(_projectId)
            If summary Is Nothing Then
                ShowError("Project not found.")
                Return
            End If

            ' Header
            lblProjectTitle.Text = summary.ProjectName
            lblProjectMeta.Text = $"{summary.ProjectCode}  |  {summary.ClientName}  |  {summary.Status}"
            Me.Text = $"Expense Summary — {summary.ProjectCode}"

            ' KPI tiles
            lblBudgetValue.Text = FormatCurrency(summary.Budget)
            lblActualValue.Text = FormatCurrency(summary.TotalExpenses)

            Dim variance = summary.Budget - summary.TotalExpenses
            lblVarianceValue.Text = FormatCurrency(Math.Abs(variance))

            If variance >= 0 Then
                pnlVariance.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
                lblVarianceSub.Text = "Under Budget"
            Else
                pnlVariance.BackColor = System.Drawing.Color.FromArgb(180, 40, 40)
                lblVarianceSub.Text = "Over Budget"
                lblVarianceValue.Text = "(" & FormatCurrency(Math.Abs(variance)) & ")"
            End If

            ' Category breakdown grid
            Dim categories = _expenseRepo.GetSummaryByCategory(_projectId)
            BindGrid(categories, summary.TotalExpenses)

        Catch ex As Exception
            ShowError("Failed to load summary: " & ex.Message)
        End Try
    End Sub

    Private Sub BindGrid(categories As List(Of ExpenseCategorySummary), grandTotal As Decimal)
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("Category", GetType(String))
        dt.Columns.Add("ExpenseCount", GetType(Integer))
        dt.Columns.Add("TotalAmount", GetType(String))
        dt.Columns.Add("PercentageOfTotal", GetType(String))

        For Each cat In categories
            dt.Rows.Add(
                cat.Category,
                cat.ExpenseCount,
                FormatCurrency(cat.TotalAmount),
                cat.PercentageOfTotal.ToString("0.0") & "%")
        Next

        gridControl1.DataSource = dt
        lblTotalExpenses.Text = $"Total Project Cost:   {FormatCurrency(grandTotal)}"
    End Sub

    Private Function FormatCurrency(value As Decimal) As String
        Return "$" & value.ToString("N2")
    End Function

    Private Sub ShowError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
