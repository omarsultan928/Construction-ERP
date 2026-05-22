Public Class RoleHelper
    Public Const Admin As String = "Admin"
    Public Const Accountant As String = "Accountant"
    Public Const ProjectManager As String = "ProjectManager"

    Public Shared Function CanManageUsers(role As String) As Boolean
        Return role = Admin
    End Function

    Public Shared Function CanManageProjects(role As String) As Boolean
        Return role = Admin OrElse role = ProjectManager
    End Function

    Public Shared Function CanManageExpenses(role As String) As Boolean
        Return role = Admin OrElse role = Accountant
    End Function

    Public Shared Function CanViewVendors(role As String) As Boolean
        Return role = Admin OrElse role = Accountant OrElse role = ProjectManager
    End Function

    Public Shared Function CanManageVendors(role As String) As Boolean
        Return role = Admin OrElse role = Accountant
    End Function

    Public Shared Function CanAssignVendorsToProject(role As String) As Boolean
        Return role = Admin OrElse role = ProjectManager
    End Function

    Public Shared Function CanTrackVendorPayments(role As String) As Boolean
        Return role = Admin OrElse role = Accountant
    End Function

    Public Shared Function CanManageInvoices(role As String) As Boolean
        Return role = Admin OrElse role = Accountant
    End Function

    Public Shared Function CanViewExpenses(role As String) As Boolean
        Return role = Admin OrElse role = Accountant OrElse role = ProjectManager
    End Function

    Public Shared Function CanViewExpenseSummary(role As String) As Boolean
        Return role = Admin OrElse role = Accountant OrElse role = ProjectManager
    End Function

    Public Shared Function CanViewReports(role As String) As Boolean
        Return role = Admin OrElse role = Accountant OrElse role = ProjectManager
    End Function
End Class
