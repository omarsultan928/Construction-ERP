Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class DatabaseHelper
    Private Shared ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("ERPConnection").ConnectionString

    Public Shared Function GetConnectionString() As String
        Return ConnectionString
    End Function

    Public Shared Function CreateConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

    Public Shared Function ExecuteNonQuery(query As String, ParamArray parameters As SqlParameter()) As Integer
        Using connection As SqlConnection = CreateConnection()
            Using command As New SqlCommand(query, connection)
                If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                    command.Parameters.AddRange(parameters)
                End If
                connection.Open()
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Shared Function ExecuteQuery(query As String, ParamArray parameters As SqlParameter()) As DataTable
        Using connection As SqlConnection = CreateConnection()
            Using command As New SqlCommand(query, connection)
                If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                    command.Parameters.AddRange(parameters)
                End If
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ExecuteScalar(query As String, ParamArray parameters As SqlParameter()) As Object
        Using connection As SqlConnection = CreateConnection()
            Using command As New SqlCommand(query, connection)
                If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                    command.Parameters.AddRange(parameters)
                End If
                connection.Open()
                Return command.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Shared Function ExecuteStoredProcedure(procedureName As String, ParamArray parameters As SqlParameter()) As DataTable
        Using connection As SqlConnection = CreateConnection()
            Using command As New SqlCommand(procedureName, connection)
                command.CommandType = CommandType.StoredProcedure
                If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                    command.Parameters.AddRange(parameters)
                End If
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ExecuteStoredProcedureNonQuery(procedureName As String, ParamArray parameters As SqlParameter()) As Integer
        Using connection As SqlConnection = CreateConnection()
            Using command As New SqlCommand(procedureName, connection)
                command.CommandType = CommandType.StoredProcedure
                If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
                    command.Parameters.AddRange(parameters)
                End If
                connection.Open()
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Shared Function TestConnection() As Boolean
        Try
            Using connection As SqlConnection = CreateConnection()
                connection.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function
End Class
