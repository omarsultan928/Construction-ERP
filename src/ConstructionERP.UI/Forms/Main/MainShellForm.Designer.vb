<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainShellForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.btnNavUsers = New System.Windows.Forms.Button()
        Me.btnNavReports = New System.Windows.Forms.Button()
        Me.btnNavInvoices = New System.Windows.Forms.Button()
        Me.btnNavVendors = New System.Windows.Forms.Button()
        Me.btnNavExpenses = New System.Windows.Forms.Button()
        Me.btnNavProjects = New System.Windows.Forms.Button()
        Me.btnNavDashboard = New System.Windows.Forms.Button()
        Me.lblNavHeader = New System.Windows.Forms.Label()
        Me.tmrSession = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblUserInfo)
        Me.pnlTop.Controls.Add(Me.lblAppTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Height = 52
        Me.pnlTop.Name = "pnlTop"

        ' lblAppTitle
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.White
        Me.lblAppTitle.Location = New System.Drawing.Point(14, 12)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Text = "Construction ERP"

        ' lblUserInfo
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblUserInfo.Location = New System.Drawing.Point(820, 17)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Text = "User Name  |  Role"

        ' btnLogout
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1090, 11)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 30)
        Me.btnLogout.Text = "Logout"

        ' pnlLeft
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(38, 50, 80)
        Me.pnlLeft.Controls.Add(Me.btnNavUsers)
        Me.pnlLeft.Controls.Add(Me.btnNavReports)
        Me.pnlLeft.Controls.Add(Me.btnNavInvoices)
        Me.pnlLeft.Controls.Add(Me.btnNavVendors)
        Me.pnlLeft.Controls.Add(Me.btnNavExpenses)
        Me.pnlLeft.Controls.Add(Me.btnNavProjects)
        Me.pnlLeft.Controls.Add(Me.btnNavDashboard)
        Me.pnlLeft.Controls.Add(Me.lblNavHeader)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Width = 185

        ' lblNavHeader
        Me.lblNavHeader.AutoSize = True
        Me.lblNavHeader.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular)
        Me.lblNavHeader.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180)
        Me.lblNavHeader.Location = New System.Drawing.Point(10, 12)
        Me.lblNavHeader.Name = "lblNavHeader"
        Me.lblNavHeader.Text = "NAVIGATION"

        ' Nav button shared style applied individually below
        ' btnNavDashboard
        Me.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(50, 65, 100)
        Me.btnNavDashboard.FlatAppearance.BorderSize = 0
        Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.White
        Me.btnNavDashboard.Location = New System.Drawing.Point(5, 35)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Size = New System.Drawing.Size(175, 36)
        Me.btnNavDashboard.Text = "  Dashboard"
        Me.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' btnNavProjects
        Me.btnNavProjects.BackColor = System.Drawing.Color.Transparent
        Me.btnNavProjects.FlatAppearance.BorderSize = 0
        Me.btnNavProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavProjects.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavProjects.ForeColor = System.Drawing.Color.FromArgb(200, 215, 240)
        Me.btnNavProjects.Location = New System.Drawing.Point(5, 78)
        Me.btnNavProjects.Name = "btnNavProjects"
        Me.btnNavProjects.Size = New System.Drawing.Size(175, 36)
        Me.btnNavProjects.Text = "  Projects"
        Me.btnNavProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' btnNavExpenses
        Me.btnNavExpenses.BackColor = System.Drawing.Color.Transparent
        Me.btnNavExpenses.FlatAppearance.BorderSize = 0
        Me.btnNavExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavExpenses.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavExpenses.ForeColor = System.Drawing.Color.FromArgb(200, 215, 240)
        Me.btnNavExpenses.Location = New System.Drawing.Point(5, 121)
        Me.btnNavExpenses.Name = "btnNavExpenses"
        Me.btnNavExpenses.Size = New System.Drawing.Size(175, 36)
        Me.btnNavExpenses.Text = "  Expenses"
        Me.btnNavExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' btnNavVendors
        Me.btnNavVendors.BackColor = System.Drawing.Color.Transparent
        Me.btnNavVendors.FlatAppearance.BorderSize = 0
        Me.btnNavVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavVendors.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavVendors.ForeColor = System.Drawing.Color.FromArgb(200, 215, 240)
        Me.btnNavVendors.Location = New System.Drawing.Point(5, 164)
        Me.btnNavVendors.Name = "btnNavVendors"
        Me.btnNavVendors.Size = New System.Drawing.Size(175, 36)
        Me.btnNavVendors.Text = "  Vendors"
        Me.btnNavVendors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' btnNavInvoices
        Me.btnNavInvoices.BackColor = System.Drawing.Color.Transparent
        Me.btnNavInvoices.FlatAppearance.BorderSize = 0
        Me.btnNavInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavInvoices.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavInvoices.ForeColor = System.Drawing.Color.FromArgb(200, 215, 240)
        Me.btnNavInvoices.Location = New System.Drawing.Point(5, 207)
        Me.btnNavInvoices.Name = "btnNavInvoices"
        Me.btnNavInvoices.Size = New System.Drawing.Size(175, 36)
        Me.btnNavInvoices.Text = "  Invoices"
        Me.btnNavInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' btnNavReports
        Me.btnNavReports.BackColor = System.Drawing.Color.Transparent
        Me.btnNavReports.FlatAppearance.BorderSize = 0
        Me.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavReports.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(200, 215, 240)
        Me.btnNavReports.Location = New System.Drawing.Point(5, 250)
        Me.btnNavReports.Name = "btnNavReports"
        Me.btnNavReports.Size = New System.Drawing.Size(175, 36)
        Me.btnNavReports.Text = "  Reports"
        Me.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' btnNavUsers
        Me.btnNavUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnNavUsers.FlatAppearance.BorderSize = 0
        Me.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavUsers.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(200, 215, 240)
        Me.btnNavUsers.Location = New System.Drawing.Point(5, 293)
        Me.btnNavUsers.Name = "btnNavUsers"
        Me.btnNavUsers.Size = New System.Drawing.Size(175, 36)
        Me.btnNavUsers.Text = "  User Management"
        Me.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        ' tmrSession
        Me.tmrSession.Enabled = False

        ' MainShellForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 242, 247)
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "MainShellForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Construction ERP — Hardhunt Inc"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblAppTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblNavHeader As System.Windows.Forms.Label
    Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
    Friend WithEvents btnNavProjects As System.Windows.Forms.Button
    Friend WithEvents btnNavExpenses As System.Windows.Forms.Button
    Friend WithEvents btnNavVendors As System.Windows.Forms.Button
    Friend WithEvents btnNavInvoices As System.Windows.Forms.Button
    Friend WithEvents btnNavReports As System.Windows.Forms.Button
    Friend WithEvents btnNavUsers As System.Windows.Forms.Button
    Friend WithEvents tmrSession As System.Windows.Forms.Timer
End Class
