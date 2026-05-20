Public Interface IUserManagementView
    Sub ShowUsers(users As List(Of User))
    Sub ShowError(message As String)
    Sub ShowSuccess(message As String)
End Interface
