Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class VendorPaymentListForm

    Private ReadOnly _vendorRepo As New VendorRepository()
    Private ReadOnly _filterVendorId As Integer?
    Private _allPayments As List(Of VendorPayment)

    Public Sub New(Optional filterVendorId As Integer? = Nothing)
        _filterVendorId = filterVendorId
        InitializeComponent()
    End Sub

    Private Sub VendorPaymentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatusFilter.Items.Add("All Statuses")
        cboStatusFilter.Items.Add(VendorHelper.StatusPending)
        cboStatusFilter.Items.Add(VendorHelper.StatusPartial)
        cboStatusFilter.Items.Add(VendorHelper.StatusPaid)
        cboStatusFilter.SelectedIndex = 0

        If _filterVendorId.HasValue Then
            Me.Text = "Vendor Payments (Filtered)"
        End If

        LoadPayments()
    End Sub

    Private Sub LoadPayments()
        Try
            Dim statusFilter As String = Nothing
            If cboStatusFilter.SelectedIndex > 0 Then
                statusFilter = cboStatusFilter.SelectedItem.ToString()
            End If

            _allPayments = _vendorRepo.GetPayments(_filterVendorId, statusFilter)

            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                Dim term = txtSearch.Text.Trim().ToLower()
                _allPayments = _allPayments.Where(Function(p) p.VendorName.ToLower().Contains(term) OrElse
                                                              (p.ProjectName IsNot Nothing AndAlso p.ProjectName.ToLower().Contains(term)) OrElse
                                                              (p.Description IsNot Nothing AndAlso p.Description.ToLower().Contains(term))).ToList()
            End If

            BindGrid(_allPayments)
        Catch ex As Exception
            ShowError("Failed to load payments: " & ex.Message)
        End Try
    End Sub

    Private Sub BindGrid(payments As List(Of VendorPayment))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("PaymentID", GetType(Integer))
        dt.Columns.Add("VendorName", GetType(String))
        dt.Columns.Add("ProjectName", GetType(String))
        dt.Columns.Add("Description", GetType(String))
        dt.Columns.Add("AmountDue", GetType(String))
        dt.Columns.Add("AmountPaid", GetType(String))
        dt.Columns.Add("BalanceDue", GetType(String))
        dt.Columns.Add("PaymentStatus", GetType(String))
        dt.Columns.Add("DueDate", GetType(String))

        For Each p In payments
            dt.Rows.Add(p.PaymentID, p.VendorName,
                        If(p.ProjectName, ""),
                        If(p.Description, ""),
                        p.AmountDue.ToString("C2"),
                        p.AmountPaid.ToString("C2"),
                        p.BalanceDue.ToString("C2"),
                        p.PaymentStatus,
                        If(p.DueDate.HasValue, p.DueDate.Value.ToString("yyyy-MM-dd"), ""))
        Next

        gridControl1.DataSource = dt
        lblRecordCount.Text = $"{payments.Count} payment(s)"

        Dim outstanding = payments.Sum(Function(p) p.BalanceDue)
        lblOutstanding.Text = $"Outstanding balance: {outstanding:C2}"
    End Sub

    Private Function GetSelectedPayment() As VendorPayment
        Dim rowHandle = gridView1.FocusedRowHandle
        If rowHandle < 0 OrElse _allPayments Is Nothing Then Return Nothing
        Dim paymentId = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "PaymentID"))
        Return _allPayments.FirstOrDefault(Function(p) p.PaymentID = paymentId)
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadPayments()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        LoadPayments()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cboStatusFilter.SelectedIndex = 0
        lblStatus.Text = ""
        LoadPayments()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using frm As New VendorPaymentForm(Nothing, _filterVendorId)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _vendorRepo.InsertPayment(frm.PaymentToSave)
                    ShowSuccess("Payment record created.")
                    LoadPayments()
                Catch ex As Exception
                    ShowError("Failed to save payment: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim payment = GetSelectedPayment()
        If payment Is Nothing Then
            ShowError("Please select a payment to edit.")
            Return
        End If

        Using frm As New VendorPaymentForm(payment)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _vendorRepo.UpdatePayment(frm.PaymentToSave)
                    ShowSuccess("Payment record updated.")
                    LoadPayments()
                Catch ex As Exception
                    ShowError("Failed to update payment: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub gridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView1.RowStyle
        If e.RowHandle < 0 Then Return
        Dim status = gridView1.GetRowCellValue(e.RowHandle, "PaymentStatus")?.ToString()
        Select Case status
            Case VendorHelper.StatusPending
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            Case VendorHelper.StatusPartial
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0)
            Case VendorHelper.StatusPaid
                e.Appearance.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
        End Select
        e.Appearance.Options.UseForeColor = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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
