Public Class InvoiceHelper
    Public Const StatusDraft As String = "Draft"
    Public Const StatusSent As String = "Sent"
    Public Const StatusPaid As String = "Paid"
    Public Const StatusOverdue As String = "Overdue"

    Public Shared Function GetStatuses() As String()
        Return New String() {StatusDraft, StatusSent, StatusPaid, StatusOverdue}
    End Function

    Public Shared Function GetOutstandingStatuses() As String()
        Return New String() {StatusSent, StatusOverdue}
    End Function

    Public Shared Function IsOutstanding(status As String) As Boolean
        Return status = StatusSent OrElse status = StatusOverdue
    End Function
End Class
