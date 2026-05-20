Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports ConstructionERP.Core
Imports ConstructionERP.Data.Helpers

Public Class UserRepository
    Implements IUserRepository

    Public Sub New()
        ' Connection string is managed by DatabaseHelper
    End Sub

    Public Function GetByCredentials(email As String, password As String) As User Implements IUserRepository.GetByCredentials
        Dim parameters As SqlParameter() = {
            New SqlParameter("@Email", email)
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_User_GetByEmail", parameters)

        If dataTable.Rows.Count > 0 Then
            Dim row As DataRow = dataTable.Rows(0)
            Dim user As New User With {
                .UserID = Convert.ToInt32(row("UserID")),
                .email = row("Email").ToString(),
                .password = row("Password").ToString(),
                .FirstName = row("FirstName").ToString(),
                .LastName = row("LastName").ToString(),
                .Role = row("Role").ToString(),
                .IsActive = Convert.ToBoolean(row("IsActive")),
                .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
                .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
            }

            ' Verify password using SHA256 hash
            If user.Password = PasswordHelper.HashPassword(password) Then
                Return user
            End If
        End If

        Return Nothing
    End Function

    Public Function GetByEmail(email As String) As User Implements IUserRepository.GetByEmail
        Dim parameters As SqlParameter() = {
            New SqlParameter("@Email", email)
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_User_GetByEmail", parameters)

        If dataTable.Rows.Count > 0 Then
            Dim row As DataRow = dataTable.Rows(0)
            Return New User With {
                .UserID = Convert.ToInt32(row("UserID")),
                .email = row("Email").ToString(),
                .Password = row("Password").ToString(),
                .FirstName = row("FirstName").ToString(),
                .LastName = row("LastName").ToString(),
                .Role = row("Role").ToString(),
                .IsActive = Convert.ToBoolean(row("IsActive")),
                .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
                .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
            }
        End If

        Return Nothing
    End Function

    Public Function GetAll() As List(Of User) Implements IUserRepository.GetAll
        Dim users As New List(Of User)
        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_User_GetAll")

        For Each row As DataRow In dataTable.Rows
            users.Add(New User With {
                .UserID = Convert.ToInt32(row("UserID")),
                .Email = row("Email").ToString(),
                .Password = row("Password").ToString(),
                .FirstName = row("FirstName").ToString(),
                .LastName = row("LastName").ToString(),
                .Role = row("Role").ToString(),
                .IsActive = Convert.ToBoolean(row("IsActive")),
                .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
                .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
            })
        Next

        Return users
    End Function

    Public Function Insert(user As User) As Integer Implements IUserRepository.Insert
        ' Hash password before storing
        user.Password = PasswordHelper.HashPassword(user.Password)

        Dim parameters As SqlParameter() = {
            New SqlParameter("@Email", user.Email),
            New SqlParameter("@Password", user.Password),
            New SqlParameter("@FirstName", user.FirstName),
            New SqlParameter("@LastName", user.LastName),
            New SqlParameter("@Role", user.Role),
            New SqlParameter("@UserID", SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_User_Insert", parameters)
        Return Convert.ToInt32(parameters(parameters.Length - 1).Value)
    End Function

    Public Sub Update(user As User) Implements IUserRepository.Update
        Dim parameters As SqlParameter() = {
            New SqlParameter("@UserID", user.UserID),
            New SqlParameter("@Email", user.Email),
            New SqlParameter("@FirstName", user.FirstName),
            New SqlParameter("@LastName", user.LastName),
            New SqlParameter("@Role", user.Role),
            New SqlParameter("@IsActive", user.IsActive)
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_User_Update", parameters)
    End Sub

    Public Sub Delete(userId As Integer) Implements IUserRepository.Delete
        Dim parameters As SqlParameter() = {
            New SqlParameter("@UserID", userId)
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_User_Delete", parameters)
    End Sub
End Class
