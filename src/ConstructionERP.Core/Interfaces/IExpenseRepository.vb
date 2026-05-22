Public Interface IExpenseRepository
    Function GetByProject(projectId As Integer, Optional category As String = Nothing) As List(Of Expense)
    Function GetSummaryByCategory(projectId As Integer) As List(Of ExpenseCategorySummary)
    Function Insert(expense As Expense) As Integer
    Sub Update(expense As Expense)
    Sub Delete(expenseId As Integer)
End Interface
