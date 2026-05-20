Public Class User
    Public Property UserID As Integer
    Public Property Email As String
    Public Property Password As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Role As String
    Public Property IsActive As Boolean
    Public Property CreatedDate As DateTime
    Public Property UpdatedDate As DateTime

    Public ReadOnly Property FullName As String
        Get
            Return $"{FirstName} {LastName}"
        End Get
    End Property
End Class
