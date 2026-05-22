Public Class VendorPayment
    Public Property PaymentID As Integer
    Public Property VendorID As Integer
    Public Property VendorName As String
    Public Property ProjectID As Integer?
    Public Property ProjectCode As String
    Public Property ProjectName As String
    Public Property Description As String
    Public Property AmountDue As Decimal
    Public Property AmountPaid As Decimal
    Public Property DueDate As Date?
    Public Property Notes As String
    Public Property PaymentStatus As String
    Public Property BalanceDue As Decimal
    Public Property CreatedDate As DateTime
    Public Property UpdatedDate As DateTime
End Class
