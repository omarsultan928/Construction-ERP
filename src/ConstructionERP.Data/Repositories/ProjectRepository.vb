Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports ConstructionERP.Core
Public Class ProjectRepository
    Implements IProjectRepository

    Public Sub New()
        ' Connection string is managed by DatabaseHelper
    End Sub

    Public Function GetByCode(projectCode As String) As Project Implements IProjectRepository.GetByCode
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectCode", projectCode)
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Project_GetByCode", parameters)

        If dataTable.Rows.Count > 0 Then
            Return MapProjectRow(dataTable.Rows(0))
        End If

        Return Nothing
    End Function

    Public Function GetById(projectId As Integer) As Project Implements IProjectRepository.GetById
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", projectId)
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery(
            "SELECT ProjectID, ProjectCode, ProjectName, ClientName, Budget, StartDate, EndDate, Status, CreatedDate, UpdatedDate FROM dbo.Project WHERE ProjectID = @ProjectID",
            parameters)

        If dataTable.Rows.Count > 0 Then
            Return MapProjectRow(dataTable.Rows(0))
        End If

        Return Nothing
    End Function

    Public Function GetSummary(projectId As Integer) As ProjectSummary Implements IProjectRepository.GetSummary
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", projectId)
        }

        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery(
            "SELECT ProjectID, ProjectCode, ProjectName, ClientName, Budget, StartDate, EndDate, Status, " &
            "TotalExpenses, RemainingBudget, TotalInvoices, EstimatedProfit " &
            "FROM dbo.vw_ProjectSummary WHERE ProjectID = @ProjectID",
            parameters)

        If dataTable.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim row As DataRow = dataTable.Rows(0)
        Return New ProjectSummary With {
            .ProjectID = Convert.ToInt32(row("ProjectID")),
            .ProjectCode = row("ProjectCode").ToString(),
            .ProjectName = row("ProjectName").ToString(),
            .ClientName = row("ClientName").ToString(),
            .Budget = Convert.ToDecimal(row("Budget")),
            .StartDate = Convert.ToDateTime(row("StartDate")),
            .EndDate = If(row("EndDate") Is DBNull.Value, Nothing, Convert.ToDateTime(row("EndDate"))),
            .Status = row("Status").ToString(),
            .TotalExpenses = Convert.ToDecimal(row("TotalExpenses")),
            .RemainingBudget = Convert.ToDecimal(row("RemainingBudget")),
            .TotalInvoices = Convert.ToDecimal(row("TotalInvoices")),
            .EstimatedProfit = Convert.ToDecimal(row("EstimatedProfit"))
        }
    End Function

    Public Function GetAll() As List(Of Project) Implements IProjectRepository.GetAll
        Dim projects As New List(Of Project)
        Dim dataTable As DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Project_GetAll")

        For Each row As DataRow In dataTable.Rows
            projects.Add(MapProjectRow(row))
        Next

        Return projects
    End Function

    Private Shared Function MapProjectRow(row As DataRow) As Project
        Return New Project With {
            .ProjectID = Convert.ToInt32(row("ProjectID")),
            .ProjectCode = row("ProjectCode").ToString(),
            .ProjectName = row("ProjectName").ToString(),
            .ClientName = row("ClientName").ToString(),
            .Budget = Convert.ToDecimal(row("Budget")),
            .StartDate = Convert.ToDateTime(row("StartDate")),
            .EndDate = If(row("EndDate") Is DBNull.Value, Nothing, Convert.ToDateTime(row("EndDate"))),
            .Status = row("Status").ToString(),
            .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
            .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
        }
    End Function

    Public Function Insert(project As Project) As Integer Implements IProjectRepository.Insert
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectCode", project.ProjectCode),
            New SqlParameter("@ProjectName", project.ProjectName),
            New SqlParameter("@ClientName", project.ClientName),
            New SqlParameter("@Budget", project.Budget),
            New SqlParameter("@StartDate", project.StartDate),
            New SqlParameter("@EndDate", If(project.EndDate.HasValue, project.EndDate.Value, DBNull.Value)),
            New SqlParameter("@Status", project.Status),
            New SqlParameter("@ProjectID", SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Project_Insert", parameters)
        Return Convert.ToInt32(parameters(parameters.Length - 1).Value)
    End Function

    Public Sub Update(project As Project) Implements IProjectRepository.Update
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", project.ProjectID),
            New SqlParameter("@ProjectCode", project.ProjectCode),
            New SqlParameter("@ProjectName", project.ProjectName),
            New SqlParameter("@ClientName", project.ClientName),
            New SqlParameter("@Budget", project.Budget),
            New SqlParameter("@StartDate", project.StartDate),
            New SqlParameter("@EndDate", If(project.EndDate.HasValue, project.EndDate.Value, DBNull.Value)),
            New SqlParameter("@Status", project.Status)
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Project_Update", parameters)
    End Sub

    Public Sub Delete(projectId As Integer) Implements IProjectRepository.Delete
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", projectId)
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Project_Delete", parameters)
    End Sub
End Class
