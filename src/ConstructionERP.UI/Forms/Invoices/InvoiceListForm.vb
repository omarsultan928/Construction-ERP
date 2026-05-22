Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class InvoiceListForm

    Private ReadOnly _invoiceRepo As New InvoiceRepository()
    Private _allInvoices As List(Of Invoice)
    Private _displayedInvoices As List(Of Invoice)
    Private _outstandingInvoices As List(Of Invoice)

    Private Sub InvoiceListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatusFilter.Items.Add("All Statuses")
        For Each status In InvoiceHelper.GetStatuses()
            cboStatusFilter.Items.Add(status)
        Next
        cboStatusFilter.SelectedIndex = 0

        LoadAllInvoices()
        LoadOutstandingInvoices()
    End Sub

    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        lblStatus.Text = ""
    End Sub

    ' --- All Invoices (US-13) ---

    Private Sub LoadAllInvoices()
        Try
            Dim statusFilter As String = Nothing
            If cboStatusFilter.SelectedIndex > 0 Then
                statusFilter = cboStatusFilter.SelectedItem.ToString()
            End If

            _allInvoices = _invoiceRepo.GetAll(statusFilter)
            ApplyAllInvoicesFilter()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ApplyAllInvoicesFilter()
        If _allInvoices Is Nothing Then Return

        Dim filtered = _allInvoices.AsEnumerable()
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            Dim term = txtSearch.Text.Trim().ToLower()
            filtered = filtered.Where(Function(i) i.InvoiceNo.ToLower().Contains(term) OrElse
                                                  i.ProjectName.ToLower().Contains(term) OrElse
                                                  i.ProjectCode.ToLower().Contains(term) OrElse
                                                  i.ClientName.ToLower().Contains(term))
        End If

        _displayedInvoices = filtered.ToList()
        BindAllGrid(_displayedInvoices)
    End Sub

    Private Sub BindAllGrid(invoices As List(Of Invoice))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("InvoiceID", GetType(Integer))
        dt.Columns.Add("InvoiceNo", GetType(String))
        dt.Columns.Add("ProjectCode", GetType(String))
        dt.Columns.Add("ProjectName", GetType(String))
        dt.Columns.Add("ClientName", GetType(String))
        dt.Columns.Add("Amount", GetType(String))
        dt.Columns.Add("InvoiceDate", GetType(String))
        dt.Columns.Add("DueDate", GetType(String))
        dt.Columns.Add("Status", GetType(String))

        For Each inv In invoices
            dt.Rows.Add(inv.InvoiceID, inv.InvoiceNo, inv.ProjectCode, inv.ProjectName, inv.ClientName,
                        inv.Amount.ToString("C2"), inv.InvoiceDate.ToString("yyyy-MM-dd"),
                        inv.DueDate.ToString("yyyy-MM-dd"), inv.Status)
        Next

        gridAll.DataSource = dt
        lblAllCount.Text = $"{invoices.Count} invoice(s)"
    End Sub

    Private Function GetSelectedAllInvoice() As Invoice
        Dim rowHandle = gridViewAll.FocusedRowHandle
        If rowHandle < 0 OrElse _displayedInvoices Is Nothing Then Return Nothing
        Dim invoiceId = Convert.ToInt32(gridViewAll.GetRowCellValue(rowHandle, "InvoiceID"))
        Return _displayedInvoices.FirstOrDefault(Function(i) i.InvoiceID = invoiceId)
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadAllInvoices()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then LoadAllInvoices()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        LoadAllInvoices()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cboStatusFilter.SelectedIndex = 0
        lblStatus.Text = ""
        LoadAllInvoices()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using frm As New InvoiceForm(Nothing)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _invoiceRepo.Insert(frm.InvoiceToSave)
                    ShowSuccess("Invoice created successfully.")
                    LoadAllInvoices()
                    LoadOutstandingInvoices()
                Catch ex As Exception
                    ShowError("Failed to create invoice: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim invoice = GetSelectedAllInvoice()
        If invoice Is Nothing Then
            ShowError("Please select an invoice to edit.")
            Return
        End If

        Using frm As New InvoiceForm(invoice)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _invoiceRepo.Update(frm.InvoiceToSave)
                    ShowSuccess("Invoice updated successfully.")
                    LoadAllInvoices()
                    LoadOutstandingInvoices()
                Catch ex As Exception
                    ShowError("Failed to update invoice: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        Dim invoice = GetSelectedAllInvoice()
        If invoice Is Nothing Then
            ShowError("Please select an invoice to update.")
            Return
        End If
        UpdateInvoiceStatus(invoice)
    End Sub

    Private Sub gridAll_DoubleClick(sender As Object, e As EventArgs) Handles gridAll.DoubleClick
        Dim pt = gridAll.PointToClient(Cursor.Position)
        Dim hitInfo = gridViewAll.CalcHitInfo(pt)
        If hitInfo.InRow Then btnEdit_Click(sender, e)
    End Sub

    Private Sub gridViewAll_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridViewAll.RowStyle
        ApplyStatusRowStyle(e)
    End Sub

    ' --- Outstanding Invoices (US-15) ---

    Private Sub LoadOutstandingInvoices()
        Try
            _outstandingInvoices = _invoiceRepo.GetOutstanding()
            BindOutstandingGrid(_outstandingInvoices)

            Dim totalOutstanding = _outstandingInvoices.Sum(Function(i) i.Amount)
            lblOutstandingTotal.Text = $"Total outstanding: {totalOutstanding:C2}"
        Catch ex As Exception
            lblOutstandingTotal.Text = "Total outstanding: —"
            ShowError("Failed to load outstanding invoices: " & ex.Message)
        End Try
    End Sub

    Private Sub BindOutstandingGrid(invoices As List(Of Invoice))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("InvoiceID", GetType(Integer))
        dt.Columns.Add("InvoiceNo", GetType(String))
        dt.Columns.Add("ProjectCode", GetType(String))
        dt.Columns.Add("ProjectName", GetType(String))
        dt.Columns.Add("Amount", GetType(String))
        dt.Columns.Add("DueDate", GetType(String))
        dt.Columns.Add("Status", GetType(String))
        dt.Columns.Add("DaysUntilDue", GetType(String))
        dt.Columns.Add("Urgency", GetType(String))

        For Each inv In invoices
            dt.Rows.Add(inv.InvoiceID, inv.InvoiceNo, inv.ProjectCode, inv.ProjectName,
                        inv.Amount.ToString("C2"), inv.DueDate.ToString("yyyy-MM-dd"),
                        inv.Status, inv.DaysUntilDue.ToString(), inv.Urgency)
        Next

        gridOutstanding.DataSource = dt
        lblOutstandingCount.Text = $"{invoices.Count} unpaid invoice(s)"
    End Sub

    Private Function GetSelectedOutstandingInvoice() As Invoice
        Dim rowHandle = gridViewOutstanding.FocusedRowHandle
        If rowHandle < 0 OrElse _outstandingInvoices Is Nothing Then Return Nothing
        Dim invoiceId = Convert.ToInt32(gridViewOutstanding.GetRowCellValue(rowHandle, "InvoiceID"))
        Return _outstandingInvoices.FirstOrDefault(Function(i) i.InvoiceID = invoiceId)
    End Function

    Private Sub btnOutstandingUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnOutstandingUpdateStatus.Click
        Dim invoice = GetSelectedOutstandingInvoice()
        If invoice Is Nothing Then
            ShowError("Please select an outstanding invoice.")
            Return
        End If

        Dim fullInvoice = _invoiceRepo.GetById(invoice.InvoiceID)
        If fullInvoice IsNot Nothing Then UpdateInvoiceStatus(fullInvoice)
    End Sub

    Private Sub btnOutstandingRefresh_Click(sender As Object, e As EventArgs) Handles btnOutstandingRefresh.Click
        LoadOutstandingInvoices()
        ShowSuccess("Outstanding invoices refreshed.")
    End Sub

    Private Sub gridViewOutstanding_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridViewOutstanding.RowStyle
        If e.RowHandle < 0 Then Return
        Dim urgency = gridViewOutstanding.GetRowCellValue(e.RowHandle, "Urgency")?.ToString()
        Select Case urgency
            Case "Overdue"
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            Case "Due Soon"
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0)
            Case Else
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192)
        End Select
        e.Appearance.Options.UseForeColor = True
    End Sub

    ' --- Shared (US-14) ---

    Private Sub UpdateInvoiceStatus(invoice As Invoice)
        Using frm As New InvoiceStatusForm(invoice)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _invoiceRepo.UpdateStatus(invoice.InvoiceID, frm.SelectedStatus)
                    ShowSuccess($"Invoice status updated to '{frm.SelectedStatus}'.")
                    LoadAllInvoices()
                    LoadOutstandingInvoices()
                Catch ex As Exception
                    ShowError("Failed to update status: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub ApplyStatusRowStyle(e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        If e.RowHandle < 0 Then Return
        Dim status = gridViewAll.GetRowCellValue(e.RowHandle, "Status")?.ToString()
        Select Case status
            Case InvoiceHelper.StatusDraft
                e.Appearance.ForeColor = System.Drawing.Color.Gray
            Case InvoiceHelper.StatusSent
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192)
            Case InvoiceHelper.StatusPaid
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
            Case InvoiceHelper.StatusOverdue
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        End Select
        e.Appearance.Options.UseForeColor = True
    End Sub

    Private Sub ShowError(message As String)
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        lblStatus.Text = message
    End Sub

    Private Sub ShowSuccess(message As String)
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
        lblStatus.Text = message
    End Sub

End Class
