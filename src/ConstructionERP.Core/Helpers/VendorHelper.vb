Public Class VendorHelper
    Public Const StatusPending As String = "Pending"
    Public Const StatusPartial As String = "Partial"
    Public Const StatusPaid As String = "Paid"

    Public Const TypeMaterialSupplier As String = "MaterialSupplier"
    Public Const TypeSubcontractor As String = "Subcontractor"
    Public Const TypeEquipmentRental As String = "EquipmentRental"
    Public Const TypeService As String = "Service"

    Public Shared Function GetVendorTypes() As String()
        Return New String() {TypeMaterialSupplier, TypeSubcontractor, TypeEquipmentRental, TypeService}
    End Function

    Public Shared Function FormatVendorType(vendorType As String) As String
        Select Case vendorType
            Case TypeMaterialSupplier : Return "Material Supplier"
            Case TypeSubcontractor : Return "Subcontractor"
            Case TypeEquipmentRental : Return "Equipment Rental"
            Case TypeService : Return "Service"
            Case Else : Return vendorType
        End Select
    End Function

    Public Shared Function ComputePaymentStatus(amountDue As Decimal, amountPaid As Decimal) As String
        If amountPaid <= 0 Then Return StatusPending
        If amountPaid < amountDue Then Return StatusPartial
        Return StatusPaid
    End Function
End Class
