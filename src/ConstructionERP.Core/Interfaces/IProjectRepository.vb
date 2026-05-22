Public Interface IProjectRepository
    Function GetByCode(projectCode As String) As Project
    Function GetById(projectId As Integer) As Project
    Function GetAll() As List(Of Project)
    Function GetSummary(projectId As Integer) As ProjectSummary
    Function GetBudgetVsActual() As List(Of BudgetVsActualRow)
    Function GetProfitability() As List(Of ProfitabilityRow)
    Function Insert(project As Project) As Integer
    Sub Update(project As Project)
    Sub Delete(projectId As Integer)
End Interface
