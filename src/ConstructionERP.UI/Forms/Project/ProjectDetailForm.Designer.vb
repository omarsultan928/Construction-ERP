<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectDetailForm
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
        Me.lblProjectTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblProjectMeta = New DevExpress.XtraEditors.LabelControl()
        Me.lblBudgetLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblBudgetValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblDateRange = New DevExpress.XtraEditors.LabelControl()
        Me.lblBudgetStatus = New DevExpress.XtraEditors.LabelControl()

        Me.pnlTotalExpenses = New DevExpress.XtraEditors.PanelControl()
        Me.lblTotalExpensesTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalExpensesValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalExpensesSub = New DevExpress.XtraEditors.LabelControl()

        Me.pnlRemainingBudget = New DevExpress.XtraEditors.PanelControl()
        Me.lblRemainingBudgetTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblRemainingBudgetValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblRemainingBudgetSub = New DevExpress.XtraEditors.LabelControl()

        Me.pnlInvoiceTotals = New DevExpress.XtraEditors.PanelControl()
        Me.lblInvoiceTotalsTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblInvoiceTotalsValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblInvoiceTotalsSub = New DevExpress.XtraEditors.LabelControl()

        Me.pnlProfitLoss = New DevExpress.XtraEditors.PanelControl()
        Me.lblProfitLossTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblProfitLossValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblProfitLossSub = New DevExpress.XtraEditors.LabelControl()

        Me.lblError = New DevExpress.XtraEditors.LabelControl()
        Me.btnViewExpenses = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExpenseSummary = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()

        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pnlTotalExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalExpenses.SuspendLayout()
        CType(Me.pnlRemainingBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRemainingBudget.SuspendLayout()
        CType(Me.pnlInvoiceTotals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInvoiceTotals.SuspendLayout()
        CType(Me.pnlProfitLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProfitLoss.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──────────────────────────────────────────────────────────
        Me.pnlHeader.Appearance.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Appearance.Options.UseBackColor = True
        Me.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlHeader.Controls.Add(Me.lblBudgetStatus)
        Me.pnlHeader.Controls.Add(Me.lblDateRange)
        Me.pnlHeader.Controls.Add(Me.lblBudgetValue)
        Me.pnlHeader.Controls.Add(Me.lblBudgetLabel)
        Me.pnlHeader.Controls.Add(Me.lblProjectMeta)
        Me.pnlHeader.Controls.Add(Me.lblProjectTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 88
        Me.pnlHeader.Name = "pnlHeader"

        Me.lblProjectTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblProjectTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblProjectTitle.Appearance.Options.UseFont = True
        Me.lblProjectTitle.Appearance.Options.UseForeColor = True
        Me.lblProjectTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblProjectTitle.Name = "lblProjectTitle"
        Me.lblProjectTitle.Text = "Project Name"

        Me.lblProjectMeta.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProjectMeta.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblProjectMeta.Appearance.Options.UseFont = True
        Me.lblProjectMeta.Appearance.Options.UseForeColor = True
        Me.lblProjectMeta.Location = New System.Drawing.Point(22, 42)
        Me.lblProjectMeta.Name = "lblProjectMeta"
        Me.lblProjectMeta.Text = "Code | Client | Status"

        Me.lblDateRange.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDateRange.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblDateRange.Appearance.Options.UseFont = True
        Me.lblDateRange.Appearance.Options.UseForeColor = True
        Me.lblDateRange.Location = New System.Drawing.Point(22, 62)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Text = "Start to End"

        Me.lblBudgetLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblBudgetLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblBudgetLabel.Appearance.Options.UseFont = True
        Me.lblBudgetLabel.Appearance.Options.UseForeColor = True
        Me.lblBudgetLabel.Location = New System.Drawing.Point(520, 18)
        Me.lblBudgetLabel.Name = "lblBudgetLabel"
        Me.lblBudgetLabel.Text = "BUDGET"

        Me.lblBudgetValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBudgetValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblBudgetValue.Appearance.Options.UseFont = True
        Me.lblBudgetValue.Appearance.Options.UseForeColor = True
        Me.lblBudgetValue.Location = New System.Drawing.Point(518, 36)
        Me.lblBudgetValue.Name = "lblBudgetValue"
        Me.lblBudgetValue.Text = "$0"

        ' BudgetStatus badge
        Me.lblBudgetStatus.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblBudgetStatus.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblBudgetStatus.Appearance.BackColor = System.Drawing.Color.Gray
        Me.lblBudgetStatus.Appearance.Options.UseFont = True
        Me.lblBudgetStatus.Appearance.Options.UseForeColor = True
        Me.lblBudgetStatus.Appearance.Options.UseBackColor = True
        Me.lblBudgetStatus.Location = New System.Drawing.Point(518, 62)
        Me.lblBudgetStatus.Name = "lblBudgetStatus"
        Me.lblBudgetStatus.Text = "On Budget"

        ' ── Widget: Total Expenses ──────────────────────────────────────────────
        Me.pnlTotalExpenses.Appearance.BackColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.pnlTotalExpenses.Appearance.Options.UseBackColor = True
        Me.pnlTotalExpenses.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesSub)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesValue)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesTitle)
        Me.pnlTotalExpenses.Location = New System.Drawing.Point(30, 110)
        Me.pnlTotalExpenses.Name = "pnlTotalExpenses"
        Me.pnlTotalExpenses.Size = New System.Drawing.Size(310, 120)

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
        Me.lblTotalExpensesSub.Text = "All recorded expenses"

        ' ── Widget: Remaining Budget ────────────────────────────────────────────
        Me.pnlRemainingBudget.Appearance.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.pnlRemainingBudget.Appearance.Options.UseBackColor = True
        Me.pnlRemainingBudget.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlRemainingBudget.Controls.Add(Me.lblRemainingBudgetSub)
        Me.pnlRemainingBudget.Controls.Add(Me.lblRemainingBudgetValue)
        Me.pnlRemainingBudget.Controls.Add(Me.lblRemainingBudgetTitle)
        Me.pnlRemainingBudget.Location = New System.Drawing.Point(370, 110)
        Me.pnlRemainingBudget.Name = "pnlRemainingBudget"
        Me.pnlRemainingBudget.Size = New System.Drawing.Size(310, 120)

        Me.lblRemainingBudgetTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRemainingBudgetTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255)
        Me.lblRemainingBudgetTitle.Appearance.Options.UseFont = True
        Me.lblRemainingBudgetTitle.Appearance.Options.UseForeColor = True
        Me.lblRemainingBudgetTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblRemainingBudgetTitle.Name = "lblRemainingBudgetTitle"
        Me.lblRemainingBudgetTitle.Text = "REMAINING BUDGET"

        Me.lblRemainingBudgetValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemainingBudgetValue.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblRemainingBudgetValue.Appearance.Options.UseFont = True
        Me.lblRemainingBudgetValue.Appearance.Options.UseForeColor = True
        Me.lblRemainingBudgetValue.Location = New System.Drawing.Point(12, 38)
        Me.lblRemainingBudgetValue.Name = "lblRemainingBudgetValue"
        Me.lblRemainingBudgetValue.Text = "$0"

        Me.lblRemainingBudgetSub.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblRemainingBudgetSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 215, 255)
        Me.lblRemainingBudgetSub.Appearance.Options.UseFont = True
        Me.lblRemainingBudgetSub.Appearance.Options.UseForeColor = True
        Me.lblRemainingBudgetSub.Location = New System.Drawing.Point(15, 96)
        Me.lblRemainingBudgetSub.Name = "lblRemainingBudgetSub"
        Me.lblRemainingBudgetSub.Text = "Budget minus expenses"

        ' ── Widget: Invoice Totals ──────────────────────────────────────────────
        Me.pnlInvoiceTotals.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 81, 0)
        Me.pnlInvoiceTotals.Appearance.Options.UseBackColor = True
        Me.pnlInvoiceTotals.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlInvoiceTotals.Controls.Add(Me.lblInvoiceTotalsSub)
        Me.pnlInvoiceTotals.Controls.Add(Me.lblInvoiceTotalsValue)
        Me.pnlInvoiceTotals.Controls.Add(Me.lblInvoiceTotalsTitle)
        Me.pnlInvoiceTotals.Location = New System.Drawing.Point(30, 250)
        Me.pnlInvoiceTotals.Name = "pnlInvoiceTotals"
        Me.pnlInvoiceTotals.Size = New System.Drawing.Size(310, 120)

        Me.lblInvoiceTotalsTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInvoiceTotalsTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 220, 180)
        Me.lblInvoiceTotalsTitle.Appearance.Options.UseFont = True
        Me.lblInvoiceTotalsTitle.Appearance.Options.UseForeColor = True
        Me.lblInvoiceTotalsTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblInvoiceTotalsTitle.Name = "lblInvoiceTotalsTitle"
        Me.lblInvoiceTotalsTitle.Text = "INVOICE TOTALS"

        Me.lblInvoiceTotalsValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvoiceTotalsValue.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceTotalsValue.Appearance.Options.UseFont = True
        Me.lblInvoiceTotalsValue.Appearance.Options.UseForeColor = True
        Me.lblInvoiceTotalsValue.Location = New System.Drawing.Point(12, 38)
        Me.lblInvoiceTotalsValue.Name = "lblInvoiceTotalsValue"
        Me.lblInvoiceTotalsValue.Text = "$0"

        Me.lblInvoiceTotalsSub.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblInvoiceTotalsSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 200, 160)
        Me.lblInvoiceTotalsSub.Appearance.Options.UseFont = True
        Me.lblInvoiceTotalsSub.Appearance.Options.UseForeColor = True
        Me.lblInvoiceTotalsSub.Location = New System.Drawing.Point(15, 96)
        Me.lblInvoiceTotalsSub.Name = "lblInvoiceTotalsSub"
        Me.lblInvoiceTotalsSub.Text = "All project invoices"

        ' ── Widget: Profit / Loss ───────────────────────────────────────────────
        Me.pnlProfitLoss.Appearance.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.pnlProfitLoss.Appearance.Options.UseBackColor = True
        Me.pnlProfitLoss.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossSub)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossValue)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossTitle)
        Me.pnlProfitLoss.Location = New System.Drawing.Point(370, 250)
        Me.pnlProfitLoss.Name = "pnlProfitLoss"
        Me.pnlProfitLoss.Size = New System.Drawing.Size(310, 120)

        Me.lblProfitLossTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProfitLossTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 230, 195)
        Me.lblProfitLossTitle.Appearance.Options.UseFont = True
        Me.lblProfitLossTitle.Appearance.Options.UseForeColor = True
        Me.lblProfitLossTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblProfitLossTitle.Name = "lblProfitLossTitle"
        Me.lblProfitLossTitle.Text = "PROFIT / LOSS ESTIMATE"

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
        Me.lblProfitLossSub.Text = "Paid invoices minus expenses"

        ' ── Misc controls ──────────────────────────────────────────────────────
        Me.lblError.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(30, 390)
        Me.lblError.Name = "lblError"
        Me.lblError.Text = ""
        Me.lblError.Visible = False

        Me.btnViewExpenses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewExpenses.Appearance.BackColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.btnViewExpenses.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnViewExpenses.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewExpenses.Appearance.Options.UseBackColor = True
        Me.btnViewExpenses.Appearance.Options.UseForeColor = True
        Me.btnViewExpenses.Appearance.Options.UseFont = True
        Me.btnViewExpenses.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnViewExpenses.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnViewExpenses.Location = New System.Drawing.Point(30, 400)
        Me.btnViewExpenses.Name = "btnViewExpenses"
        Me.btnViewExpenses.Size = New System.Drawing.Size(130, 30)
        Me.btnViewExpenses.Text = "View Expenses"

        Me.btnExpenseSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExpenseSummary.Appearance.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnExpenseSummary.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnExpenseSummary.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExpenseSummary.Appearance.Options.UseBackColor = True
        Me.btnExpenseSummary.Appearance.Options.UseForeColor = True
        Me.btnExpenseSummary.Appearance.Options.UseFont = True
        Me.btnExpenseSummary.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnExpenseSummary.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnExpenseSummary.Location = New System.Drawing.Point(172, 400)
        Me.btnExpenseSummary.Name = "btnExpenseSummary"
        Me.btnExpenseSummary.Size = New System.Drawing.Size(140, 30)
        Me.btnExpenseSummary.Text = "Expense Summary"

        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(600, 400)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 30)
        Me.btnClose.Text = "Close"

        ' ── ProjectDetailForm ───────────────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 242, 247)
        Me.ClientSize = New System.Drawing.Size(720, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExpenseSummary)
        Me.Controls.Add(Me.btnViewExpenses)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.pnlProfitLoss)
        Me.Controls.Add(Me.pnlInvoiceTotals)
        Me.Controls.Add(Me.pnlRemainingBudget)
        Me.Controls.Add(Me.pnlTotalExpenses)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProjectDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Project Details"

        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.pnlTotalExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalExpenses.ResumeLayout(False)
        CType(Me.pnlRemainingBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRemainingBudget.ResumeLayout(False)
        CType(Me.pnlInvoiceTotals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInvoiceTotals.ResumeLayout(False)
        CType(Me.pnlProfitLoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProfitLoss.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblProjectTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProjectMeta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBudgetLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBudgetValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateRange As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBudgetStatus As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlTotalExpenses As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTotalExpensesTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalExpensesValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalExpensesSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlRemainingBudget As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRemainingBudgetTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRemainingBudgetValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRemainingBudgetSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlInvoiceTotals As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblInvoiceTotalsTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblInvoiceTotalsValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblInvoiceTotalsSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlProfitLoss As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblProfitLossTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProfitLossValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProfitLossSub As DevExpress.XtraEditors.LabelControl

    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnViewExpenses As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExpenseSummary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
