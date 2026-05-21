Public Interface IVendorRepository
    Function GetAll(Optional vendorType As String = Nothing) As List(Of Vendor)
    Function GetById(vendorId As Integer) As Vendor
    Function Insert(vendor As Vendor) As Integer
    Sub Update(vendor As Vendor)
    Sub Delete(vendorId As Integer)
    Sub AssignToProject(projectId As Integer, vendorId As Integer)
    Function GetProjectAssignments(Optional projectId As Integer? = Nothing, Optional vendorId As Integer? = Nothing) As List(Of VendorProjectAssignment)
    Function IsAssigned(projectId As Integer, vendorId As Integer) As Boolean
    Function GetPayments(Optional vendorId As Integer? = Nothing, Optional paymentStatus As String = Nothing) As List(Of VendorPayment)
    Function InsertPayment(payment As VendorPayment) As Integer
    Sub UpdatePayment(payment As VendorPayment)
    Sub DeletePayment(paymentId As Integer)
End Interface
