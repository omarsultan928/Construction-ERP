Imports ConstructionERP.Core

Public Class InvoiceStatusForm

    Private ReadOnly _invoice As Invoice

    Public Sub New(invoice As Invoice)
        InitializeComponent()
        _invoice = invoice
    End Sub

    Public ReadOnly Property SelectedStatus As String
        Get
            Return cboStatus.SelectedItem.ToString()
        End Get
    End Property

    Private Sub InvoiceStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInvoiceInfo.Text = $"{_invoice.InvoiceNo}  |  {_invoice.ProjectName}  |  {_invoice.Amount:C2}"

        For Each status In InvoiceHelper.GetStatuses()
            cboStatus.Items.Add(status)
        Next
        cboStatus.SelectedItem = _invoice.Status
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboStatus.SelectedItem Is Nothing Then
            lblError.Text = "Please select a status."
            lblError.Visible = True
            Return
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
