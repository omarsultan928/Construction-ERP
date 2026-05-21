<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnCreateProject = New System.Windows.Forms.Button()
        Me.lblDashTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()

        Me.pnlActiveProjects = New System.Windows.Forms.Panel()
        Me.lblActiveProjectsTitle = New System.Windows.Forms.Label()
        Me.lblActiveProjectsValue = New System.Windows.Forms.Label()
        Me.lblActiveProjectsSub = New System.Windows.Forms.Label()

        Me.pnlTotalExpenses = New System.Windows.Forms.Panel()
        Me.lblTotalExpensesTitle = New System.Windows.Forms.Label()
        Me.lblTotalExpensesValue = New System.Windows.Forms.Label()
        Me.lblTotalExpensesSub = New System.Windows.Forms.Label()

        Me.pnlOutstandingInv = New System.Windows.Forms.Panel()
        Me.lblOutstandingInvTitle = New System.Windows.Forms.Label()
        Me.lblOutstandingInvValue = New System.Windows.Forms.Label()
        Me.lblOutstandingInvSub = New System.Windows.Forms.Label()

        Me.pnlProfitLoss = New System.Windows.Forms.Panel()
        Me.lblProfitLossTitle = New System.Windows.Forms.Label()
        Me.lblProfitLossValue = New System.Windows.Forms.Label()
        Me.lblProfitLossSub = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlActiveProjects.SuspendLayout()
        Me.pnlTotalExpenses.SuspendLayout()
        Me.pnlOutstandingInv.SuspendLayout()
        Me.pnlProfitLoss.SuspendLayout()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnCreateProject)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblDashTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 64
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)

        ' btnCreateProject
        Me.btnCreateProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateProject.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.btnCreateProject.FlatAppearance.BorderSize = 0
        Me.btnCreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateProject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreateProject.ForeColor = System.Drawing.Color.White
        Me.btnCreateProject.Location = New System.Drawing.Point(560, 16)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(150, 32)
        Me.btnCreateProject.Text = "+ Create New Project"
        Me.btnCreateProject.UseVisualStyleBackColor = False
        Me.btnCreateProject.Visible = False

        ' lblDashTitle
        Me.lblDashTitle.AutoSize = True
        Me.lblDashTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblDashTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblDashTitle.Name = "lblDashTitle"
        Me.lblDashTitle.Text = "Dashboard Overview"

        ' lblSubtitle
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Text = "Key business metrics at a glance"

        ' --- Widget: Active Projects ---
        Me.pnlActiveProjects.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.pnlActiveProjects.Controls.Add(Me.lblActiveProjectsSub)
        Me.pnlActiveProjects.Controls.Add(Me.lblActiveProjectsValue)
        Me.pnlActiveProjects.Controls.Add(Me.lblActiveProjectsTitle)
        Me.pnlActiveProjects.Location = New System.Drawing.Point(30, 90)
        Me.pnlActiveProjects.Name = "pnlActiveProjects"
        Me.pnlActiveProjects.Size = New System.Drawing.Size(260, 120)

        Me.lblActiveProjectsTitle.AutoSize = True
        Me.lblActiveProjectsTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblActiveProjectsTitle.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255)
        Me.lblActiveProjectsTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblActiveProjectsTitle.Name = "lblActiveProjectsTitle"
        Me.lblActiveProjectsTitle.Text = "ACTIVE PROJECTS"

        Me.lblActiveProjectsValue.AutoSize = True
        Me.lblActiveProjectsValue.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblActiveProjectsValue.ForeColor = System.Drawing.Color.White
        Me.lblActiveProjectsValue.Location = New System.Drawing.Point(12, 38)
        Me.lblActiveProjectsValue.Name = "lblActiveProjectsValue"
        Me.lblActiveProjectsValue.Text = "0"

        Me.lblActiveProjectsSub.AutoSize = True
        Me.lblActiveProjectsSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblActiveProjectsSub.ForeColor = System.Drawing.Color.FromArgb(180, 215, 255)
        Me.lblActiveProjectsSub.Location = New System.Drawing.Point(15, 96)
        Me.lblActiveProjectsSub.Name = "lblActiveProjectsSub"
        Me.lblActiveProjectsSub.Text = "In Progress / Planning"

        ' --- Widget: Total Expenses ---
        Me.pnlTotalExpenses.BackColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesSub)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesValue)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesTitle)
        Me.pnlTotalExpenses.Location = New System.Drawing.Point(320, 90)
        Me.pnlTotalExpenses.Name = "pnlTotalExpenses"
        Me.pnlTotalExpenses.Size = New System.Drawing.Size(260, 120)

        Me.lblTotalExpensesTitle.AutoSize = True
        Me.lblTotalExpensesTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalExpensesTitle.ForeColor = System.Drawing.Color.FromArgb(255, 210, 190)
        Me.lblTotalExpensesTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTotalExpensesTitle.Name = "lblTotalExpensesTitle"
        Me.lblTotalExpensesTitle.Text = "TOTAL EXPENSES"

        Me.lblTotalExpensesValue.AutoSize = True
        Me.lblTotalExpensesValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalExpensesValue.ForeColor = System.Drawing.Color.White
        Me.lblTotalExpensesValue.Location = New System.Drawing.Point(12, 38)
        Me.lblTotalExpensesValue.Name = "lblTotalExpensesValue"
        Me.lblTotalExpensesValue.Text = "$0"

        Me.lblTotalExpensesSub.AutoSize = True
        Me.lblTotalExpensesSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTotalExpensesSub.ForeColor = System.Drawing.Color.FromArgb(255, 190, 160)
        Me.lblTotalExpensesSub.Location = New System.Drawing.Point(15, 96)
        Me.lblTotalExpensesSub.Name = "lblTotalExpensesSub"
        Me.lblTotalExpensesSub.Text = "All projects combined"

        ' --- Widget: Outstanding Invoices ---
        Me.pnlOutstandingInv.BackColor = System.Drawing.Color.FromArgb(230, 81, 0)
        Me.pnlOutstandingInv.Controls.Add(Me.lblOutstandingInvSub)
        Me.pnlOutstandingInv.Controls.Add(Me.lblOutstandingInvValue)
        Me.pnlOutstandingInv.Controls.Add(Me.lblOutstandingInvTitle)
        Me.pnlOutstandingInv.Location = New System.Drawing.Point(30, 240)
        Me.pnlOutstandingInv.Name = "pnlOutstandingInv"
        Me.pnlOutstandingInv.Size = New System.Drawing.Size(260, 120)

        Me.lblOutstandingInvTitle.AutoSize = True
        Me.lblOutstandingInvTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOutstandingInvTitle.ForeColor = System.Drawing.Color.FromArgb(255, 220, 180)
        Me.lblOutstandingInvTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblOutstandingInvTitle.Name = "lblOutstandingInvTitle"
        Me.lblOutstandingInvTitle.Text = "OUTSTANDING INVOICES"

        Me.lblOutstandingInvValue.AutoSize = True
        Me.lblOutstandingInvValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutstandingInvValue.ForeColor = System.Drawing.Color.White
        Me.lblOutstandingInvValue.Location = New System.Drawing.Point(12, 38)
        Me.lblOutstandingInvValue.Name = "lblOutstandingInvValue"
        Me.lblOutstandingInvValue.Text = "$0"

        Me.lblOutstandingInvSub.AutoSize = True
        Me.lblOutstandingInvSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblOutstandingInvSub.ForeColor = System.Drawing.Color.FromArgb(255, 200, 160)
        Me.lblOutstandingInvSub.Location = New System.Drawing.Point(15, 96)
        Me.lblOutstandingInvSub.Name = "lblOutstandingInvSub"
        Me.lblOutstandingInvSub.Text = "Sent + Overdue"

        ' --- Widget: Profit / Loss ---
        Me.pnlProfitLoss.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossSub)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossValue)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossTitle)
        Me.pnlProfitLoss.Location = New System.Drawing.Point(320, 240)
        Me.pnlProfitLoss.Name = "pnlProfitLoss"
        Me.pnlProfitLoss.Size = New System.Drawing.Size(260, 120)

        Me.lblProfitLossTitle.AutoSize = True
        Me.lblProfitLossTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProfitLossTitle.ForeColor = System.Drawing.Color.FromArgb(180, 230, 195)
        Me.lblProfitLossTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblProfitLossTitle.Name = "lblProfitLossTitle"
        Me.lblProfitLossTitle.Text = "PROFIT / LOSS"

        Me.lblProfitLossValue.AutoSize = True
        Me.lblProfitLossValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfitLossValue.ForeColor = System.Drawing.Color.White
        Me.lblProfitLossValue.Location = New System.Drawing.Point(12, 38)
        Me.lblProfitLossValue.Name = "lblProfitLossValue"
        Me.lblProfitLossValue.Text = "$0"

        Me.lblProfitLossSub.AutoSize = True
        Me.lblProfitLossSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblProfitLossSub.ForeColor = System.Drawing.Color.FromArgb(170, 225, 185)
        Me.lblProfitLossSub.Location = New System.Drawing.Point(15, 96)
        Me.lblProfitLossSub.Name = "lblProfitLossSub"
        Me.lblProfitLossSub.Text = "Paid Invoices minus Expenses"

        ' DashboardForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 242, 247)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlProfitLoss)
        Me.Controls.Add(Me.pnlOutstandingInv)
        Me.Controls.Add(Me.pnlTotalExpenses)
        Me.Controls.Add(Me.pnlActiveProjects)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "DashboardForm"
        Me.Text = "Dashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlActiveProjects.ResumeLayout(False)
        Me.pnlActiveProjects.PerformLayout()
        Me.pnlTotalExpenses.ResumeLayout(False)
        Me.pnlTotalExpenses.PerformLayout()
        Me.pnlOutstandingInv.ResumeLayout(False)
        Me.pnlOutstandingInv.PerformLayout()
        Me.pnlProfitLoss.ResumeLayout(False)
        Me.pnlProfitLoss.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents btnCreateProject As System.Windows.Forms.Button
    Friend WithEvents lblDashTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label

    Friend WithEvents pnlActiveProjects As System.Windows.Forms.Panel
    Friend WithEvents lblActiveProjectsTitle As System.Windows.Forms.Label
    Friend WithEvents lblActiveProjectsValue As System.Windows.Forms.Label
    Friend WithEvents lblActiveProjectsSub As System.Windows.Forms.Label

    Friend WithEvents pnlTotalExpenses As System.Windows.Forms.Panel
    Friend WithEvents lblTotalExpensesTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpensesValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpensesSub As System.Windows.Forms.Label

    Friend WithEvents pnlOutstandingInv As System.Windows.Forms.Panel
    Friend WithEvents lblOutstandingInvTitle As System.Windows.Forms.Label
    Friend WithEvents lblOutstandingInvValue As System.Windows.Forms.Label
    Friend WithEvents lblOutstandingInvSub As System.Windows.Forms.Label

    Friend WithEvents pnlProfitLoss As System.Windows.Forms.Panel
    Friend WithEvents lblProfitLossTitle As System.Windows.Forms.Label
    Friend WithEvents lblProfitLossValue As System.Windows.Forms.Label
    Friend WithEvents lblProfitLossSub As System.Windows.Forms.Label
End Class
