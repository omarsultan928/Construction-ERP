Public Class BudgetVsActualRow
    Public Property ProjectID As Integer
    Public Property ProjectCode As String
    Public Property ProjectName As String
    Public Property BudgetAmount As Decimal
    Public Property ActualAmount As Decimal
    Public Property Variance As Decimal
    Public Property BudgetStatus As String

    Public ReadOnly Property PercentUsed As Decimal
        Get
            If BudgetAmount = 0 Then Return 0
            Return Math.Round(ActualAmount / BudgetAmount * 100, 1)
        End Get
    End Property
End Class
