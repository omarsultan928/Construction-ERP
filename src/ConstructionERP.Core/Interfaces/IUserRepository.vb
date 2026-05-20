Public Interface IUserRepository
    Function GetByCredentials(email As String, password As String) As User
    Function GetByEmail(email As String) As User
    Function GetAll() As List(Of User)
    Function Insert(user As User) As Integer
    Sub Update(user As User)
    Sub Delete(userId As Integer)
End Interface
