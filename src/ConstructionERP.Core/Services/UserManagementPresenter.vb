Public Class UserManagementPresenter
    Private ReadOnly _view As IUserManagementView
    Private ReadOnly _userRepository As IUserRepository

    Public Sub New(view As IUserManagementView, userRepository As IUserRepository)
        _view = view
        _userRepository = userRepository
    End Sub

    Public Sub LoadUsers(Optional roleFilter As String = Nothing)
        Try
            Dim users = _userRepository.GetAll()
            If Not String.IsNullOrWhiteSpace(roleFilter) Then
                users = users.Where(Function(u) u.Role = roleFilter).ToList()
            End If
            _view.ShowUsers(users)
        Catch ex As Exception
            _view.ShowError("Failed to load users: " & ex.Message)
        End Try
    End Sub

    Public Sub DisableUser(userId As Integer)
        Try
            _userRepository.Delete(userId)
            _view.ShowSuccess("User disabled successfully.")
        Catch ex As Exception
            _view.ShowError("Failed to disable user: " & ex.Message)
        End Try
    End Sub
End Class
