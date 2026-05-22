Public Class Invoice
    Public Property InvoiceID As Integer
    Public Property ProjectID As Integer
    Public Property ProjectCode As String
    Public Property ProjectName As String
    Public Property ClientName As String
    Public Property InvoiceNo As String
    Public Property Amount As Decimal
    Public Property InvoiceDate As Date
    Public Property DueDate As Date
    Public Property Status As String
    Public Property Notes As String
    Public Property CreatedDate As DateTime
    Public Property UpdatedDate As DateTime
    Public Property DaysUntilDue As Integer?
    Public Property Urgency As String
End Class
