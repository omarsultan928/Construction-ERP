Imports ConstructionERP.Core

Public Class VendorForm

    Private ReadOnly _isEditMode As Boolean
    Private ReadOnly _originalVendor As Vendor

    Public Sub New(vendorToEdit As Vendor)
        InitializeComponent()
        _isEditMode = (vendorToEdit IsNot Nothing)
        If _isEditMode Then _originalVendor = vendorToEdit
    End Sub

    Public ReadOnly Property VendorToSave As Vendor
        Get
            Dim v As New Vendor()
            If _isEditMode Then v.VendorID = _originalVendor.VendorID
            v.VendorName = txtVendorName.Text.Trim()
            v.ContactPerson = txtContactPerson.Text.Trim()
            v.Phone = txtPhone.Text.Trim()
            v.Email = txtEmail.Text.Trim()
            v.VendorType = cboVendorType.SelectedItem?.ToString()
            Return v
        End Get
    End Property

    Private Sub VendorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each vendorType In VendorHelper.GetVendorTypes()
            cboVendorType.Items.Add(vendorType)
        Next

        If _isEditMode Then
            lblFormTitle.Text = "Edit Vendor"
            txtVendorName.Text = _originalVendor.VendorName
            txtContactPerson.Text = _originalVendor.ContactPerson
            txtPhone.Text = _originalVendor.Phone
            txtEmail.Text = _originalVendor.Email
            cboVendorType.SelectedItem = _originalVendor.VendorType
        Else
            lblFormTitle.Text = "Register Vendor"
            If cboVendorType.Items.Count > 0 Then cboVendorType.SelectedIndex = 0
        End If
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

        If String.IsNullOrWhiteSpace(txtVendorName.Text) Then
            ShowValidationError("Vendor name is required.")
            Return False
        End If
        If cboVendorType.SelectedItem Is Nothing Then
            ShowValidationError("Vendor type is required.")
            Return False
        End If
        If Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso Not txtEmail.Text.Contains("@") Then
            ShowValidationError("Please enter a valid email address.")
            Return False
        End If

        Return True
    End Function

    Private Sub ShowValidationError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub

End Class
