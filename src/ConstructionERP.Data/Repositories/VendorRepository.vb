Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports ConstructionERP.Core

Public Class VendorRepository
    Implements IVendorRepository

    Public Function GetAll(Optional vendorType As String = Nothing) As List(Of Vendor) Implements IVendorRepository.GetAll
        Dim parameters As SqlParameter() = {
            New SqlParameter("@VendorType", If(String.IsNullOrWhiteSpace(vendorType), DBNull.Value, vendorType))
        }

        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Vendor_GetAll", parameters)
        Dim vendors As New List(Of Vendor)

        For Each row As DataRow In dataTable.Rows
            vendors.Add(MapVendorRow(row))
        Next

        Return vendors
    End Function

    Public Function GetById(vendorId As Integer) As Vendor Implements IVendorRepository.GetById
        Dim vendors = GetAll()
        Return vendors.FirstOrDefault(Function(v) v.VendorID = vendorId)
    End Function

    Public Function Insert(vendor As Vendor) As Integer Implements IVendorRepository.Insert
        Dim parameters As SqlParameter() = {
            New SqlParameter("@VendorName", vendor.VendorName),
            New SqlParameter("@ContactPerson", If(String.IsNullOrWhiteSpace(vendor.ContactPerson), DBNull.Value, vendor.ContactPerson)),
            New SqlParameter("@Phone", If(String.IsNullOrWhiteSpace(vendor.Phone), DBNull.Value, vendor.Phone)),
            New SqlParameter("@Email", If(String.IsNullOrWhiteSpace(vendor.Email), DBNull.Value, vendor.Email)),
            New SqlParameter("@VendorType", vendor.VendorType),
            New SqlParameter("@VendorID", SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Vendor_Insert", parameters)
        Return Convert.ToInt32(parameters(parameters.Length - 1).Value)
    End Function

    Public Sub Update(vendor As Vendor) Implements IVendorRepository.Update
        Dim parameters As SqlParameter() = {
            New SqlParameter("@VendorID", vendor.VendorID),
            New SqlParameter("@VendorName", vendor.VendorName),
            New SqlParameter("@ContactPerson", If(String.IsNullOrWhiteSpace(vendor.ContactPerson), DBNull.Value, vendor.ContactPerson)),
            New SqlParameter("@Phone", If(String.IsNullOrWhiteSpace(vendor.Phone), DBNull.Value, vendor.Phone)),
            New SqlParameter("@Email", If(String.IsNullOrWhiteSpace(vendor.Email), DBNull.Value, vendor.Email)),
            New SqlParameter("@VendorType", vendor.VendorType)
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Vendor_Update", parameters)
    End Sub

    Public Sub Delete(vendorId As Integer) Implements IVendorRepository.Delete
        Dim parameters As SqlParameter() = {New SqlParameter("@VendorID", vendorId)}
        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Vendor_Delete", parameters)
    End Sub

    Public Sub AssignToProject(projectId As Integer, vendorId As Integer) Implements IVendorRepository.AssignToProject
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", projectId),
            New SqlParameter("@VendorID", vendorId)
        }
        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_Vendor_AssignToProject", parameters)
    End Sub

    Public Function GetProjectAssignments(Optional projectId As Integer? = Nothing, Optional vendorId As Integer? = Nothing) As List(Of VendorProjectAssignment) Implements IVendorRepository.GetProjectAssignments
        Dim parameters As SqlParameter() = {
            New SqlParameter("@ProjectID", If(projectId.HasValue, projectId.Value, DBNull.Value)),
            New SqlParameter("@VendorID", If(vendorId.HasValue, vendorId.Value, DBNull.Value))
        }

        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Vendor_GetProjectAssignments", parameters)
        Dim assignments As New List(Of VendorProjectAssignment)

        For Each row As DataRow In dataTable.Rows
            assignments.Add(New VendorProjectAssignment With {
                .VPID = Convert.ToInt32(row("VPID")),
                .ProjectID = Convert.ToInt32(row("ProjectID")),
                .ProjectCode = row("ProjectCode").ToString(),
                .ProjectName = row("ProjectName").ToString(),
                .VendorID = Convert.ToInt32(row("VendorID")),
                .VendorName = row("VendorName").ToString(),
                .VendorType = row("VendorType").ToString(),
                .AssignedDate = Convert.ToDateTime(row("AssignedDate"))
            })
        Next

        Return assignments
    End Function

    Public Function IsAssigned(projectId As Integer, vendorId As Integer) As Boolean Implements IVendorRepository.IsAssigned
        Return GetProjectAssignments(projectId, vendorId).Count > 0
    End Function

    Public Function GetPayments(Optional vendorId As Integer? = Nothing, Optional paymentStatus As String = Nothing) As List(Of VendorPayment) Implements IVendorRepository.GetPayments
        Dim parameters As SqlParameter() = {
            New SqlParameter("@VendorID", If(vendorId.HasValue, vendorId.Value, DBNull.Value)),
            New SqlParameter("@PaymentStatus", If(String.IsNullOrWhiteSpace(paymentStatus), DBNull.Value, paymentStatus))
        }

        Dim dataTable = DatabaseHelper.ExecuteStoredProcedure("sp_VendorPayment_GetAll", parameters)
        Return MapPaymentRows(dataTable)
    End Function

    Public Function InsertPayment(payment As VendorPayment) As Integer Implements IVendorRepository.InsertPayment
        Dim parameters As SqlParameter() = {
            New SqlParameter("@VendorID", payment.VendorID),
            New SqlParameter("@ProjectID", If(payment.ProjectID.HasValue, payment.ProjectID.Value, DBNull.Value)),
            New SqlParameter("@Description", If(String.IsNullOrWhiteSpace(payment.Description), DBNull.Value, payment.Description)),
            New SqlParameter("@AmountDue", payment.AmountDue),
            New SqlParameter("@AmountPaid", payment.AmountPaid),
            New SqlParameter("@DueDate", If(payment.DueDate.HasValue, payment.DueDate.Value, DBNull.Value)),
            New SqlParameter("@Notes", If(String.IsNullOrWhiteSpace(payment.Notes), DBNull.Value, payment.Notes)),
            New SqlParameter("@PaymentID", SqlDbType.Int) With {.Direction = ParameterDirection.Output}
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_VendorPayment_Insert", parameters)
        Return Convert.ToInt32(parameters(parameters.Length - 1).Value)
    End Function

    Public Sub UpdatePayment(payment As VendorPayment) Implements IVendorRepository.UpdatePayment
        Dim parameters As SqlParameter() = {
            New SqlParameter("@PaymentID", payment.PaymentID),
            New SqlParameter("@VendorID", payment.VendorID),
            New SqlParameter("@ProjectID", If(payment.ProjectID.HasValue, payment.ProjectID.Value, DBNull.Value)),
            New SqlParameter("@Description", If(String.IsNullOrWhiteSpace(payment.Description), DBNull.Value, payment.Description)),
            New SqlParameter("@AmountDue", payment.AmountDue),
            New SqlParameter("@AmountPaid", payment.AmountPaid),
            New SqlParameter("@DueDate", If(payment.DueDate.HasValue, payment.DueDate.Value, DBNull.Value)),
            New SqlParameter("@Notes", If(String.IsNullOrWhiteSpace(payment.Notes), DBNull.Value, payment.Notes))
        }

        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_VendorPayment_Update", parameters)
    End Sub

    Public Sub DeletePayment(paymentId As Integer) Implements IVendorRepository.DeletePayment
        Dim parameters As SqlParameter() = {New SqlParameter("@PaymentID", paymentId)}
        DatabaseHelper.ExecuteStoredProcedureNonQuery("sp_VendorPayment_Delete", parameters)
    End Sub

    Private Shared Function MapVendorRow(row As DataRow) As Vendor
        Return New Vendor With {
            .VendorID = Convert.ToInt32(row("VendorID")),
            .VendorName = row("VendorName").ToString(),
            .ContactPerson = If(row("ContactPerson") Is DBNull.Value, Nothing, row("ContactPerson").ToString()),
            .Phone = If(row("Phone") Is DBNull.Value, Nothing, row("Phone").ToString()),
            .Email = If(row("Email") Is DBNull.Value, Nothing, row("Email").ToString()),
            .VendorType = row("VendorType").ToString(),
            .CreatedDate = Convert.ToDateTime(row("CreatedDate"))
        }
    End Function

    Private Shared Function MapPaymentRows(dataTable As DataTable) As List(Of VendorPayment)
        Dim payments As New List(Of VendorPayment)

        For Each row As DataRow In dataTable.Rows
            payments.Add(New VendorPayment With {
                .PaymentID = Convert.ToInt32(row("PaymentID")),
                .VendorID = Convert.ToInt32(row("VendorID")),
                .VendorName = row("VendorName").ToString(),
                .ProjectID = If(row("ProjectID") Is DBNull.Value, Nothing, Convert.ToInt32(row("ProjectID"))),
                .ProjectCode = If(row("ProjectCode") Is DBNull.Value, Nothing, row("ProjectCode").ToString()),
                .ProjectName = If(row("ProjectName") Is DBNull.Value, Nothing, row("ProjectName").ToString()),
                .Description = If(row("Description") Is DBNull.Value, Nothing, row("Description").ToString()),
                .AmountDue = Convert.ToDecimal(row("AmountDue")),
                .AmountPaid = Convert.ToDecimal(row("AmountPaid")),
                .DueDate = If(row("DueDate") Is DBNull.Value, Nothing, Convert.ToDateTime(row("DueDate"))),
                .Notes = If(row("Notes") Is DBNull.Value, Nothing, row("Notes").ToString()),
                .PaymentStatus = row("PaymentStatus").ToString(),
                .BalanceDue = Convert.ToDecimal(row("BalanceDue")),
                .CreatedDate = Convert.ToDateTime(row("CreatedDate")),
                .UpdatedDate = Convert.ToDateTime(row("UpdatedDate"))
            })
        Next

        Return payments
    End Function
End Class
