Imports ConstructionERP.Core

Public Class UserForm

    Private ReadOnly _isEditMode As Boolean
    Private ReadOnly _originalUser As User

    Public Sub New(userToEdit As User)
        InitializeComponent()
        _isEditMode = (userToEdit IsNot Nothing)
        If _isEditMode Then _originalUser = userToEdit
    End Sub

    Public ReadOnly Property UserToSave As User
        Get
            Dim u As New User()
            If _isEditMode Then u.UserID = _originalUser.UserID
            u.FirstName = txtFirstName.Text.Trim()
            u.LastName = txtLastName.Text.Trim()
            u.Email = txtEmail.Text.Trim()
            If Not _isEditMode Then u.Password = txtPassword.Text
            u.Role = cboRole.SelectedItem?.ToString()
            u.IsActive = chkIsActive.Checked
            Return u
        End Get
    End Property

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.AddRange(New String() {
            RoleHelper.Admin, RoleHelper.Accountant, RoleHelper.ProjectManager})

        If _isEditMode Then
            lblFormTitle.Text = "Edit User"
            lblPassword.Visible = False
            txtPassword.Visible = False
            ' Shift Role and IsActive up to fill password row gap
            lblRole.Top = lblPassword.Top
            cboRole.Top = txtPassword.Top
            chkIsActive.Top = chkIsActive.Top - (txtPassword.Top - cboRole.Top + cboRole.Height + 8)
            ' Pre-fill fields
            txtFirstName.Text = _originalUser.FirstName
            txtLastName.Text = _originalUser.LastName
            txtEmail.Text = _originalUser.Email
            cboRole.SelectedItem = _originalUser.Role
            chkIsActive.Checked = _originalUser.IsActive
        Else
            lblFormTitle.Text = "Add New User"
            chkIsActive.Checked = True
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

        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            ShowValidationError("First name is required.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            ShowValidationError("Last name is required.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse Not txtEmail.Text.Contains("@") Then
            ShowValidationError("A valid email address is required.")
            Return False
        End If
        If Not _isEditMode AndAlso String.IsNullOrWhiteSpace(txtPassword.Text) Then
            ShowValidationError("Password is required.")
            Return False
        End If
        If cboRole.SelectedIndex < 0 Then
            ShowValidationError("Please select a role.")
            Return False
        End If
        Return True
    End Function

    Private Sub ShowValidationError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub

End Class
