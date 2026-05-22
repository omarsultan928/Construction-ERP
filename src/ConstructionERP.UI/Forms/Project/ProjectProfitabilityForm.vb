Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class ProjectProfitabilityForm

    Private ReadOnly _projectRepo As IProjectRepository = New ProjectRepository()

    Private Sub ProjectProfitabilityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim rows = _projectRepo.GetProfitability()

            Dim dt As New System.Data.DataTable()
            dt.Columns.Add("ProjectID", GetType(Integer))
            dt.Columns.Add("ProjectCode", GetType(String))
            dt.Columns.Add("ProjectName", GetType(String))
            dt.Columns.Add("ClientName", GetType(String))
            dt.Columns.Add("Status", GetType(String))
            dt.Columns.Add("InvoiceAmount", GetType(Decimal))
            dt.Columns.Add("TotalExpenses", GetType(Decimal))
            dt.Columns.Add("EstimatedProfit", GetType(Decimal))
            dt.Columns.Add("ProfitMarginPct", GetType(Decimal))
            dt.Columns.Add("ProfitStatus", GetType(String))

            For Each r In rows
                dt.Rows.Add(r.ProjectID, r.ProjectCode, r.ProjectName, r.ClientName,
                            r.Status, r.InvoiceAmount, r.TotalExpenses,
                            r.EstimatedProfit, r.ProfitMarginPct, r.ProfitStatus)
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

    Private Sub UpdateSummaryBar(rows As List(Of ProfitabilityRow))
        Dim totalInvoiced = rows.Sum(Function(r) r.InvoiceAmount)
        Dim totalExpenses = rows.Sum(Function(r) r.TotalExpenses)
        Dim netProfit = totalInvoiced - totalExpenses

        lblSumInvoicedValue.Text = FormatCurrency(totalInvoiced)
        lblSumExpensesValue.Text = FormatCurrency(totalExpenses)
        lblSumProfitValue.Text = FormatCurrency(Math.Abs(netProfit))

        If netProfit >= 0 Then
            lblSumProfitValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
            lblSumProfitLabel.Text = "NET PROFIT"
        Else
            lblSumProfitValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblSumProfitLabel.Text = "NET LOSS"
        End If
        lblSumProfitValue.Appearance.Options.UseForeColor = True
    End Sub

    Private Sub gridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView1.RowStyle
        If e.RowHandle < 0 Then Return
        Dim status = gridView1.GetRowCellValue(e.RowHandle, "ProfitStatus")?.ToString()
        Select Case status
            Case "Profit"
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
                e.Appearance.Options.UseBackColor = True
            Case "Loss"
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 235, 238)
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
