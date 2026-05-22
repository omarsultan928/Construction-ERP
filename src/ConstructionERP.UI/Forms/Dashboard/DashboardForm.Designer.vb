<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.pnlHeader = New DevExpress.XtraEditors.PanelControl()
        Me.btnCreateProject = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDashTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubtitle = New DevExpress.XtraEditors.LabelControl()

        Me.pnlActiveProjects = New DevExpress.XtraEditors.PanelControl()
        Me.lblActiveProjectsTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblActiveProjectsValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblActiveProjectsSub = New DevExpress.XtraEditors.LabelControl()

        Me.pnlTotalExpenses = New DevExpress.XtraEditors.PanelControl()
        Me.lblTotalExpensesTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalExpensesValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalExpensesSub = New DevExpress.XtraEditors.LabelControl()

        Me.pnlOutstandingInv = New DevExpress.XtraEditors.PanelControl()
        Me.lblOutstandingInvTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblOutstandingInvValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblOutstandingInvSub = New DevExpress.XtraEditors.LabelControl()

        Me.pnlProfitLoss = New DevExpress.XtraEditors.PanelControl()
        Me.lblProfitLossTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblProfitLossValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblProfitLossSub = New DevExpress.XtraEditors.LabelControl()

        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pnlActiveProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActiveProjects.SuspendLayout()
        CType(Me.pnlTotalExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalExpenses.SuspendLayout()
        CType(Me.pnlOutstandingInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOutstandingInv.SuspendLayout()
        CType(Me.pnlProfitLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProfitLoss.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──────────────────────────────────────────────────────────
        Me.pnlHeader.Appearance.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Appearance.Options.UseBackColor = True
        Me.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlHeader.Controls.Add(Me.btnCreateProject)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblDashTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 64
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)

        ' btnCreateProject
        Me.btnCreateProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateProject.Appearance.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.btnCreateProject.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCreateProject.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreateProject.Appearance.Options.UseBackColor = True
        Me.btnCreateProject.Appearance.Options.UseForeColor = True
        Me.btnCreateProject.Appearance.Options.UseFont = True
        Me.btnCreateProject.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCreateProject.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnCreateProject.Location = New System.Drawing.Point(560, 16)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(150, 32)
        Me.btnCreateProject.Text = "+ Create New Project"
        Me.btnCreateProject.Visible = False

        ' lblDashTitle
        Me.lblDashTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblDashTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblDashTitle.Appearance.Options.UseFont = True
        Me.lblDashTitle.Appearance.Options.UseForeColor = True
        Me.lblDashTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblDashTitle.Name = "lblDashTitle"
        Me.lblDashTitle.Text = "Dashboard Overview"

        ' lblSubtitle
        Me.lblSubtitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Appearance.Options.UseFont = True
        Me.lblSubtitle.Appearance.Options.UseForeColor = True
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Text = "Key business metrics at a glance"

        ' ── Widget: Active Projects ─────────────────────────────────────────────
        Me.pnlActiveProjects.Appearance.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.pnlActiveProjects.Appearance.Options.UseBackColor = True
        Me.pnlActiveProjects.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlActiveProjects.Controls.Add(Me.lblActiveProjectsSub)
        Me.pnlActiveProjects.Controls.Add(Me.lblActiveProjectsValue)
        Me.pnlActiveProjects.Controls.Add(Me.lblActiveProjectsTitle)
        Me.pnlActiveProjects.Location = New System.Drawing.Point(30, 90)
        Me.pnlActiveProjects.Name = "pnlActiveProjects"
        Me.pnlActiveProjects.Size = New System.Drawing.Size(260, 120)

        Me.lblActiveProjectsTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblActiveProjectsTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255)
        Me.lblActiveProjectsTitle.Appearance.Options.UseFont = True
        Me.lblActiveProjectsTitle.Appearance.Options.UseForeColor = True
        Me.lblActiveProjectsTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblActiveProjectsTitle.Name = "lblActiveProjectsTitle"
        Me.lblActiveProjectsTitle.Text = "ACTIVE PROJECTS"

        Me.lblActiveProjectsValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblActiveProjectsValue.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblActiveProjectsValue.Appearance.Options.UseFont = True
        Me.lblActiveProjectsValue.Appearance.Options.UseForeColor = True
        Me.lblActiveProjectsValue.Location = New System.Drawing.Point(12, 38)
        Me.lblActiveProjectsValue.Name = "lblActiveProjectsValue"
        Me.lblActiveProjectsValue.Text = "0"

        Me.lblActiveProjectsSub.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblActiveProjectsSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 215, 255)
        Me.lblActiveProjectsSub.Appearance.Options.UseFont = True
        Me.lblActiveProjectsSub.Appearance.Options.UseForeColor = True
        Me.lblActiveProjectsSub.Location = New System.Drawing.Point(15, 96)
        Me.lblActiveProjectsSub.Name = "lblActiveProjectsSub"
        Me.lblActiveProjectsSub.Text = "In Progress / Planning"

        ' ── Widget: Total Expenses ──────────────────────────────────────────────
        Me.pnlTotalExpenses.Appearance.BackColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.pnlTotalExpenses.Appearance.Options.UseBackColor = True
        Me.pnlTotalExpenses.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesSub)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesValue)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesTitle)
        Me.pnlTotalExpenses.Location = New System.Drawing.Point(320, 90)
        Me.pnlTotalExpenses.Name = "pnlTotalExpenses"
        Me.pnlTotalExpenses.Size = New System.Drawing.Size(260, 120)

        Me.lblTotalExpensesTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalExpensesTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 210, 190)
        Me.lblTotalExpensesTitle.Appearance.Options.UseFont = True
        Me.lblTotalExpensesTitle.Appearance.Options.UseForeColor = True
        Me.lblTotalExpensesTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTotalExpensesTitle.Name = "lblTotalExpensesTitle"
        Me.lblTotalExpensesTitle.Text = "TOTAL EXPENSES"

        Me.lblTotalExpensesValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalExpensesValue.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTotalExpensesValue.Appearance.Options.UseFont = True
        Me.lblTotalExpensesValue.Appearance.Options.UseForeColor = True
        Me.lblTotalExpensesValue.Location = New System.Drawing.Point(12, 38)
        Me.lblTotalExpensesValue.Name = "lblTotalExpensesValue"
        Me.lblTotalExpensesValue.Text = "$0"

        Me.lblTotalExpensesSub.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTotalExpensesSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 190, 160)
        Me.lblTotalExpensesSub.Appearance.Options.UseFont = True
        Me.lblTotalExpensesSub.Appearance.Options.UseForeColor = True
        Me.lblTotalExpensesSub.Location = New System.Drawing.Point(15, 96)
        Me.lblTotalExpensesSub.Name = "lblTotalExpensesSub"
        Me.lblTotalExpensesSub.Text = "All projects combined"

        ' ── Widget: Outstanding Invoices ────────────────────────────────────────
        Me.pnlOutstandingInv.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 81, 0)
        Me.pnlOutstandingInv.Appearance.Options.UseBackColor = True
        Me.pnlOutstandingInv.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlOutstandingInv.Controls.Add(Me.lblOutstandingInvSub)
        Me.pnlOutstandingInv.Controls.Add(Me.lblOutstandingInvValue)
        Me.pnlOutstandingInv.Controls.Add(Me.lblOutstandingInvTitle)
        Me.pnlOutstandingInv.Location = New System.Drawing.Point(30, 240)
        Me.pnlOutstandingInv.Name = "pnlOutstandingInv"
        Me.pnlOutstandingInv.Size = New System.Drawing.Size(260, 120)

        Me.lblOutstandingInvTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOutstandingInvTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 220, 180)
        Me.lblOutstandingInvTitle.Appearance.Options.UseFont = True
        Me.lblOutstandingInvTitle.Appearance.Options.UseForeColor = True
        Me.lblOutstandingInvTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblOutstandingInvTitle.Name = "lblOutstandingInvTitle"
        Me.lblOutstandingInvTitle.Text = "OUTSTANDING INVOICES"

        Me.lblOutstandingInvValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutstandingInvValue.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblOutstandingInvValue.Appearance.Options.UseFont = True
        Me.lblOutstandingInvValue.Appearance.Options.UseForeColor = True
        Me.lblOutstandingInvValue.Location = New System.Drawing.Point(12, 38)
        Me.lblOutstandingInvValue.Name = "lblOutstandingInvValue"
        Me.lblOutstandingInvValue.Text = "$0"

        Me.lblOutstandingInvSub.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblOutstandingInvSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 200, 160)
        Me.lblOutstandingInvSub.Appearance.Options.UseFont = True
        Me.lblOutstandingInvSub.Appearance.Options.UseForeColor = True
        Me.lblOutstandingInvSub.Location = New System.Drawing.Point(15, 96)
        Me.lblOutstandingInvSub.Name = "lblOutstandingInvSub"
        Me.lblOutstandingInvSub.Text = "Sent + Overdue"

        ' ── Widget: Profit / Loss ───────────────────────────────────────────────
        Me.pnlProfitLoss.Appearance.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.pnlProfitLoss.Appearance.Options.UseBackColor = True
        Me.pnlProfitLoss.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossSub)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossValue)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossTitle)
        Me.pnlProfitLoss.Location = New System.Drawing.Point(320, 240)
        Me.pnlProfitLoss.Name = "pnlProfitLoss"
        Me.pnlProfitLoss.Size = New System.Drawing.Size(260, 120)

        Me.lblProfitLossTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProfitLossTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 230, 195)
        Me.lblProfitLossTitle.Appearance.Options.UseFont = True
        Me.lblProfitLossTitle.Appearance.Options.UseForeColor = True
        Me.lblProfitLossTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblProfitLossTitle.Name = "lblProfitLossTitle"
        Me.lblProfitLossTitle.Text = "PROFIT / LOSS"

        Me.lblProfitLossValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfitLossValue.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblProfitLossValue.Appearance.Options.UseFont = True
        Me.lblProfitLossValue.Appearance.Options.UseForeColor = True
        Me.lblProfitLossValue.Location = New System.Drawing.Point(12, 38)
        Me.lblProfitLossValue.Name = "lblProfitLossValue"
        Me.lblProfitLossValue.Text = "$0"

        Me.lblProfitLossSub.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblProfitLossSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(170, 225, 185)
        Me.lblProfitLossSub.Appearance.Options.UseFont = True
        Me.lblProfitLossSub.Appearance.Options.UseForeColor = True
        Me.lblProfitLossSub.Location = New System.Drawing.Point(15, 96)
        Me.lblProfitLossSub.Name = "lblProfitLossSub"
        Me.lblProfitLossSub.Text = "Paid Invoices minus Expenses"

        ' ── DashboardForm ───────────────────────────────────────────────────────
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

        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.pnlActiveProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActiveProjects.ResumeLayout(False)
        CType(Me.pnlTotalExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalExpenses.ResumeLayout(False)
        CType(Me.pnlOutstandingInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOutstandingInv.ResumeLayout(False)
        CType(Me.pnlProfitLoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProfitLoss.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCreateProject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDashTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSubtitle As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlActiveProjects As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblActiveProjectsTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblActiveProjectsValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblActiveProjectsSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlTotalExpenses As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTotalExpensesTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalExpensesValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalExpensesSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlOutstandingInv As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblOutstandingInvTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOutstandingInvValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOutstandingInvSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlProfitLoss As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblProfitLossTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProfitLossValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProfitLossSub As DevExpress.XtraEditors.LabelControl
End Class
