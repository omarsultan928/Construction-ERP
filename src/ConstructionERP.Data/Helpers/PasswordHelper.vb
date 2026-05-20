Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHelper
    Public Shared Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim stringBuilder As New StringBuilder()
            
            For Each b As Byte In hash
                stringBuilder.Append(b.ToString("x2"))
            Next
            
            Return stringBuilder.ToString()
        End Using
    End Function

    Public Shared Function VerifyPassword(plainPassword As String, hashedPassword As String) As Boolean
        Dim hashedInput As String = HashPassword(plainPassword)
        Return hashedInput.Equals(hashedPassword, StringComparison.OrdinalIgnoreCase)
    End Function
End Class
