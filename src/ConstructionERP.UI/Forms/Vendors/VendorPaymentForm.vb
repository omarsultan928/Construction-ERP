Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class VendorPaymentForm

    Private ReadOnly _isEditMode As Boolean
    Private ReadOnly _originalPayment As VendorPayment
    Private ReadOnly _vendorRepo As New VendorRepository()
    Private ReadOnly _projectRepo As New ProjectRepository()
    Private ReadOnly _presetVendorId As Integer?

    Public Sub New(paymentToEdit As VendorPayment, Optional presetVendorId As Integer? = Nothing)
        InitializeComponent()
        _isEditMode = (paymentToEdit IsNot Nothing)
        If _isEditMode Then _originalPayment = paymentToEdit
        _presetVendorId = presetVendorId
    End Sub

    Public ReadOnly Property PaymentToSave As VendorPayment
        Get
            Dim p As New VendorPayment()
            If _isEditMode Then p.PaymentID = _originalPayment.PaymentID
            p.VendorID = DirectCast(cboVendor.SelectedItem, VendorComboItem).VendorID
            If cboProject.SelectedIndex > 0 Then
                p.ProjectID = DirectCast(cboProject.SelectedItem, ProjectComboItem).ProjectID
            End If
            p.Description = txtDescription.Text.Trim()
            p.AmountDue = numAmountDue.Value
            p.AmountPaid = numAmountPaid.Value
            p.DueDate = If(dtpDueDate.Checked, dtpDueDate.Value.Date, CType(Nothing, Date?))
            p.Notes = txtNotes.Text.Trim()
            p.PaymentStatus = VendorHelper.ComputePaymentStatus(p.AmountDue, p.AmountPaid)
            Return p
        End Get
    End Property

    Private Sub VendorPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVendors()
        LoadProjects()

        If _isEditMode Then
            lblFormTitle.Text = "Edit Payment"
            SelectVendor(_originalPayment.VendorID)
            If _originalPayment.ProjectID.HasValue Then
                SelectProject(_originalPayment.ProjectID.Value)
            End If
            txtDescription.Text = _originalPayment.Description
            numAmountDue.Value = _originalPayment.AmountDue
            numAmountPaid.Value = _originalPayment.AmountPaid
            If _originalPayment.DueDate.HasValue Then
                dtpDueDate.Checked = True
                dtpDueDate.Value = _originalPayment.DueDate.Value
            End If
            txtNotes.Text = _originalPayment.Notes
        Else
            lblFormTitle.Text = "Record Payment"
            If _presetVendorId.HasValue Then SelectVendor(_presetVendorId.Value)
        End If

        UpdateStatusPreview()
    End Sub

    Private Sub LoadVendors()
        cboVendor.Items.Clear()
        For Each v In _vendorRepo.GetAll().OrderBy(Function(x) x.VendorName)
            cboVendor.Items.Add(New VendorComboItem(v.VendorID, v.VendorName))
        Next
    End Sub

    Private Sub LoadProjects()
        cboProject.Items.Clear()
        cboProject.Items.Add(New ProjectComboItem(Nothing, "(None)"))
        For Each p In _projectRepo.GetAll().OrderBy(Function(x) x.ProjectName)
            cboProject.Items.Add(New ProjectComboItem(p.ProjectID, $"{p.ProjectCode} - {p.ProjectName}"))
        Next
        cboProject.SelectedIndex = 0
    End Sub

    Private Sub SelectVendor(vendorId As Integer)
        For i = 0 To cboVendor.Items.Count - 1
            If DirectCast(cboVendor.Items(i), VendorComboItem).VendorID = vendorId Then
                cboVendor.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub SelectProject(projectId As Integer)
        For i = 0 To cboProject.Items.Count - 1
            Dim item = DirectCast(cboProject.Items(i), ProjectComboItem)
            If item.ProjectID.HasValue AndAlso item.ProjectID.Value = projectId Then
                cboProject.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub numAmount_ValueChanged(sender As Object, e As EventArgs) Handles numAmountDue.ValueChanged, numAmountPaid.ValueChanged
        UpdateStatusPreview()
    End Sub

    Private Sub UpdateStatusPreview()
        lblStatusPreview.Text = "Status: " & VendorHelper.ComputePaymentStatus(numAmountDue.Value, numAmountPaid.Value)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidateInputs() As Boolean
        lblError.Visible = False
        If cboVendor.SelectedItem Is Nothing Then
            ShowValidationError("Vendor is required.")
            Return False
        End If
        If numAmountDue.Value <= 0 Then
            ShowValidationError("Amount due must be greater than zero.")
            Return False
        End If
        If numAmountPaid.Value < 0 Then
            ShowValidationError("Amount paid cannot be negative.")
            Return False
        End If
        If numAmountPaid.Value > numAmountDue.Value Then
            ShowValidationError("Amount paid cannot exceed amount due.")
            Return False
        End If
        Return True
    End Function

    Private Sub ShowValidationError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub

    Private Class VendorComboItem
        Public ReadOnly Property VendorID As Integer
        Private ReadOnly _name As String
        Public Sub New(vendorId As Integer, name As String)
            Me.VendorID = vendorId
            _name = name
        End Sub
        Public Overrides Function ToString() As String
            Return _name
        End Function
    End Class

    Private Class ProjectComboItem
        Public ReadOnly Property ProjectID As Integer?
        Private ReadOnly _display As String
        Public Sub New(projectId As Integer?, display As String)
            Me.ProjectID = projectId
            _display = display
        End Sub
        Public Overrides Function ToString() As String
            Return _display
        End Function
    End Class

End Class
