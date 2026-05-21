Imports System.Configuration
Imports ConstructionERP.Core

Public Class MainShellForm

    Private _sessionStart As DateTime

    Private Sub MainShellForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _sessionStart = DateTime.Now

        Dim user = SessionManager.CurrentUser
        lblUserInfo.Text = $"{user.FullName}  |  {user.Role}"

        ApplyRoleVisibility(user.Role)

        Dim timeoutMinutes As Integer = 30
        Dim configValue As String = ConfigurationManager.AppSettings("SessionTimeoutMinutes")
        If Not String.IsNullOrWhiteSpace(configValue) Then
            Integer.TryParse(configValue, timeoutMinutes)
        End If
        tmrSession.Interval = 60000
        tmrSession.Start()

        OpenDashboard()
    End Sub

    Private Sub ApplyRoleVisibility(role As String)
        btnNavUsers.Visible = RoleHelper.CanManageUsers(role)
        btnNavExpenses.Visible = RoleHelper.CanManageExpenses(role)
        btnNavVendors.Visible = RoleHelper.CanManageVendors(role)
        btnNavInvoices.Visible = RoleHelper.CanManageInvoices(role)
        btnNavReports.Visible = RoleHelper.CanViewReports(role)
    End Sub

    Private Sub OpenDashboard()
        For Each child As Form In Me.MdiChildren
            If TypeOf child Is DashboardForm Then
                child.Activate()
                Return
            End If
        Next
        Dim frm As New DashboardForm()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ShowChildForm(frm As Form)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub tmrSession_Tick(sender As Object, e As EventArgs) Handles tmrSession.Tick
        Dim timeoutMinutes As Integer = 30
        Dim configValue As String = ConfigurationManager.AppSettings("SessionTimeoutMinutes")
        If Not String.IsNullOrWhiteSpace(configValue) Then
            Integer.TryParse(configValue, timeoutMinutes)
        End If

        If DateTime.Now.Subtract(_sessionStart).TotalMinutes >= timeoutMinutes Then
            tmrSession.Stop()
            MessageBox.Show("Your session has expired. Please log in again.", "Session Expired",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LogOut()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogOut()
    End Sub

    Private Sub LogOut()
        tmrSession.Stop()
        SessionManager.CurrentUser = Nothing
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    ' --- Navigation handlers ---

    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        OpenDashboard()
    End Sub

    Private Sub btnNavProjects_Click(sender As Object, e As EventArgs) Handles btnNavProjects.Click
        For Each child As Form In Me.MdiChildren
            If TypeOf child Is ProjectListForm Then
                child.Activate()
                Return
            End If
        Next
        ShowChildForm(New ProjectListForm())
    End Sub

    Private Sub btnNavExpenses_Click(sender As Object, e As EventArgs) Handles btnNavExpenses.Click
        MessageBox.Show("Expenses module coming in Phase 4.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNavVendors_Click(sender As Object, e As EventArgs) Handles btnNavVendors.Click
        MessageBox.Show("Vendors module coming in Phase 5.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNavInvoices_Click(sender As Object, e As EventArgs) Handles btnNavInvoices.Click
        MessageBox.Show("Invoices module coming in Phase 6.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNavReports_Click(sender As Object, e As EventArgs) Handles btnNavReports.Click
        MessageBox.Show("Reports module coming in Phase 7.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNavUsers_Click(sender As Object, e As EventArgs) Handles btnNavUsers.Click
        For Each child As Form In Me.MdiChildren
            If TypeOf child Is UserListForm Then
                child.Activate()
                Return
            End If
        Next
        ShowChildForm(New UserListForm())
    End Sub

End Class
