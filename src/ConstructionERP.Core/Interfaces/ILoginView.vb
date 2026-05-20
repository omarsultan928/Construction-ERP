Public Interface ILoginView
    Property Email As String
    Property Password As String
    Sub ShowError(message As String)
    Sub NavigateToDashboard()
End Interface
