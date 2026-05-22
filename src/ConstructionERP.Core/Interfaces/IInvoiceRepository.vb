Public Interface IInvoiceRepository
    Function GetAll(Optional status As String = Nothing, Optional projectId As Integer? = Nothing) As List(Of Invoice)
    Function GetById(invoiceId As Integer) As Invoice
    Function GetByInvoiceNo(invoiceNo As String) As Invoice
    Function GetOutstanding() As List(Of Invoice)
    Function Insert(invoice As Invoice) As Integer
    Sub Update(invoice As Invoice)
    Sub UpdateStatus(invoiceId As Integer, status As String)
    Sub Delete(invoiceId As Integer)
End Interface
