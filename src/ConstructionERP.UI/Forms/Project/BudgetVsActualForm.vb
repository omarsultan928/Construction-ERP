Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class BudgetVsActualForm

    Private ReadOnly _projectRepo As IProjectRepository = New ProjectRepository()

    Private Sub BudgetVsActualForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim rows = _projectRepo.GetBudgetVsActual()

            Dim dt As New System.Data.DataTable()
            dt.Columns.Add("ProjectID", GetType(Integer))
            dt.Columns.Add("ProjectCode", GetType(String))
            dt.Columns.Add("ProjectName", GetType(String))
            dt.Columns.Add("BudgetAmount", GetType(Decimal))
            dt.Columns.Add("ActualAmount", GetType(Decimal))
            dt.Columns.Add("Variance", GetType(Decimal))
            dt.Columns.Add("PercentUsed", GetType(Decimal))
            dt.Columns.Add("BudgetStatus", GetType(String))

            For Each r In rows
                dt.Rows.Add(r.ProjectID, r.ProjectCode, r.ProjectName,
                            r.BudgetAmount, r.ActualAmount, r.Variance,
                            r.PercentUsed, r.BudgetStatus)
            Next

            gridControl1.DataSource = dt

            UpdateSummaryBar(rows)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(
                "Failed to load data: " & ex.Message,
                "Error", System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateSummaryBar(rows As List(Of BudgetVsActualRow))
        Dim totalBudget = rows.Sum(Function(r) r.BudgetAmount)
        Dim totalActual = rows.Sum(Function(r) r.ActualAmount)
        Dim totalVariance = totalBudget - totalActual

        lblSumBudgetValue.Text = FormatCurrency(totalBudget)
        lblSumActualValue.Text = FormatCurrency(totalActual)
        lblSumVarianceValue.Text = FormatCurrency(Math.Abs(totalVariance))

        If totalVariance < 0 Then
            lblSumVarianceValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblSumVarianceLabel.Text = "TOTAL OVERSPEND"
        Else
            lblSumVarianceValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
            lblSumVarianceLabel.Text = "TOTAL VARIANCE"
        End If
        lblSumVarianceValue.Appearance.Options.UseForeColor = True
    End Sub

    Private Sub gridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView1.RowStyle
        If e.RowHandle < 0 Then Return
        Dim status = gridView1.GetRowCellValue(e.RowHandle, "BudgetStatus")?.ToString()
        Select Case status
            Case "Over Budget"
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 235, 238)
                e.Appearance.Options.UseBackColor = True
            Case "Under Budget"
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
                e.Appearance.Options.UseBackColor = True
        End Select
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function FormatCurrency(value As Decimal) As String
        Return "$" & value.ToString("N0")
    End Function

End Class
