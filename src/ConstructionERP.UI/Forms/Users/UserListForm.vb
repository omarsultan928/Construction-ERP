Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class UserListForm
    Implements IUserManagementView

    Private ReadOnly _presenter As UserManagementPresenter
    Private ReadOnly _userRepo As New UserRepository()
    Private _allUsers As List(Of User)

    Public Sub New()
        InitializeComponent()
        _presenter = New UserManagementPresenter(Me, _userRepo)
    End Sub

    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRoleFilter.Items.Add("All Roles")
        cboRoleFilter.Items.Add(RoleHelper.Admin)
        cboRoleFilter.Items.Add(RoleHelper.Accountant)
        cboRoleFilter.Items.Add(RoleHelper.ProjectManager)
        cboRoleFilter.SelectedIndex = 0

        _presenter.LoadUsers()
    End Sub

    ' --- IUserManagementView ---

    Public Sub ShowUsers(users As List(Of User)) Implements IUserManagementView.ShowUsers
        _allUsers = users
        BindGrid(users)
    End Sub

    Public Sub ShowError(message As String) Implements IUserManagementView.ShowError
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        lblStatus.Text = message
    End Sub

    Public Sub ShowSuccess(message As String) Implements IUserManagementView.ShowSuccess
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
        lblStatus.Text = message
    End Sub

    ' --- Grid binding ---

    Private Sub BindGrid(users As List(Of User))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("UserID", GetType(Integer))
        dt.Columns.Add("FullName", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Role", GetType(String))
        dt.Columns.Add("Status", GetType(String))
        dt.Columns.Add("CreatedDate", GetType(String))

        For Each u In users
            dt.Rows.Add(u.UserID, u.FullName, u.Email, u.Role,
                        If(u.IsActive, "Active", "Inactive"),
                        u.CreatedDate.ToString("yyyy-MM-dd"))
        Next

        gridControl1.DataSource = dt
        lblRecordCount.Text = $"{users.Count} user(s)"
    End Sub

    ' --- Row appearance: grey out inactive users ---

    Private Sub gridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView1.RowStyle
        If e.RowHandle < 0 Then Return
        Dim status = gridView1.GetRowCellValue(e.RowHandle, "Status")
        If status IsNot Nothing AndAlso status.ToString() = "Inactive" Then
            e.Appearance.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
            e.Appearance.Options.UseForeColor = True
        End If
    End Sub

    ' --- Selection helper ---

    Private Function GetSelectedUser() As User
        Dim rowHandle = gridView1.FocusedRowHandle
        If rowHandle < 0 Then Return Nothing
        Dim userId = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "UserID"))
        Return _allUsers.FirstOrDefault(Function(u) u.UserID = userId)
    End Function

    ' --- Search / Filter ---

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ApplyFilter()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        lblStatus.Text = ""
        Dim roleFilter As String = Nothing
        If cboRoleFilter.SelectedIndex > 0 Then
            roleFilter = cboRoleFilter.SelectedItem.ToString()
        End If

        _presenter.LoadUsers(roleFilter)

        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            Dim term = txtSearch.Text.Trim().ToLower()
            Dim filtered = _allUsers.Where(Function(u) u.FullName.ToLower().Contains(term) OrElse u.Email.ToLower().Contains(term)).ToList()
            BindGrid(filtered)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cboRoleFilter.SelectedIndex = 0
        lblStatus.Text = ""
        _presenter.LoadUsers()
    End Sub

    ' --- Add ---

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Using frm As New UserForm(Nothing)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Dim userToSave = frm.UserToSave
                Try
                    _userRepo.Insert(userToSave)
                    ShowSuccess("User created successfully.")
                    _presenter.LoadUsers()
                Catch ex As Exception
                    ShowError("Failed to create user: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' --- Edit ---

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditSelected()
    End Sub

    Private Sub gridControl1_DoubleClick(sender As Object, e As EventArgs) Handles gridControl1.DoubleClick
        Dim pt = gridControl1.PointToClient(System.Windows.Forms.Cursor.Position)
        Dim hitInfo = gridView1.CalcHitInfo(pt)
        If hitInfo.InRow Then EditSelected()
    End Sub

    Private Sub EditSelected()
        Dim user = GetSelectedUser()
        If user Is Nothing Then
            ShowError("Please select a user to edit.")
            Return
        End If
        Using frm As New UserForm(user)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Dim userToSave = frm.UserToSave
                Try
                    _userRepo.Update(userToSave)
                    ShowSuccess("User updated successfully.")
                    _presenter.LoadUsers()
                Catch ex As Exception
                    ShowError("Failed to update user: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' --- Disable ---

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        Dim user = GetSelectedUser()
        If user Is Nothing Then
            ShowError("Please select a user to disable.")
            Return
        End If
        If user.UserID = SessionManager.CurrentUser.UserID Then
            ShowError("You cannot disable your own account.")
            Return
        End If
        If Not user.IsActive Then
            ShowError("This user is already inactive.")
            Return
        End If
        Dim confirm = MessageBox.Show(
            $"Disable account for '{user.FullName}'? They will no longer be able to log in.",
            "Confirm Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.Yes Then
            _presenter.DisableUser(user.UserID)
            _presenter.LoadUsers()
        End If
    End Sub

End Class
