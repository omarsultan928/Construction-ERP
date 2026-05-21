<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectDetailForm
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
        Me.lblProjectTitle = New System.Windows.Forms.Label()
        Me.lblProjectMeta = New System.Windows.Forms.Label()
        Me.lblBudgetLabel = New System.Windows.Forms.Label()
        Me.lblBudgetValue = New System.Windows.Forms.Label()
        Me.lblDateRange = New System.Windows.Forms.Label()
        Me.pnlTotalExpenses = New System.Windows.Forms.Panel()
        Me.lblTotalExpensesTitle = New System.Windows.Forms.Label()
        Me.lblTotalExpensesValue = New System.Windows.Forms.Label()
        Me.lblTotalExpensesSub = New System.Windows.Forms.Label()
        Me.pnlRemainingBudget = New System.Windows.Forms.Panel()
        Me.lblRemainingBudgetTitle = New System.Windows.Forms.Label()
        Me.lblRemainingBudgetValue = New System.Windows.Forms.Label()
        Me.lblRemainingBudgetSub = New System.Windows.Forms.Label()
        Me.pnlInvoiceTotals = New System.Windows.Forms.Panel()
        Me.lblInvoiceTotalsTitle = New System.Windows.Forms.Label()
        Me.lblInvoiceTotalsValue = New System.Windows.Forms.Label()
        Me.lblInvoiceTotalsSub = New System.Windows.Forms.Label()
        Me.pnlProfitLoss = New System.Windows.Forms.Panel()
        Me.lblProfitLossTitle = New System.Windows.Forms.Label()
        Me.lblProfitLossValue = New System.Windows.Forms.Label()
        Me.lblProfitLossSub = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTotalExpenses.SuspendLayout()
        Me.pnlRemainingBudget.SuspendLayout()
        Me.pnlInvoiceTotals.SuspendLayout()
        Me.pnlProfitLoss.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblDateRange)
        Me.pnlHeader.Controls.Add(Me.lblBudgetValue)
        Me.pnlHeader.Controls.Add(Me.lblBudgetLabel)
        Me.pnlHeader.Controls.Add(Me.lblProjectMeta)
        Me.pnlHeader.Controls.Add(Me.lblProjectTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(720, 88)
        Me.pnlHeader.TabIndex = 0
        '
        'lblProjectTitle
        '
        Me.lblProjectTitle.AutoSize = True
        Me.lblProjectTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblProjectTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblProjectTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblProjectTitle.Name = "lblProjectTitle"
        Me.lblProjectTitle.Size = New System.Drawing.Size(120, 25)
        Me.lblProjectTitle.TabIndex = 0
        Me.lblProjectTitle.Text = "Project Name"
        '
        'lblProjectMeta
        '
        Me.lblProjectMeta.AutoSize = True
        Me.lblProjectMeta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProjectMeta.ForeColor = System.Drawing.Color.Gray
        Me.lblProjectMeta.Location = New System.Drawing.Point(22, 42)
        Me.lblProjectMeta.Name = "lblProjectMeta"
        Me.lblProjectMeta.Size = New System.Drawing.Size(120, 15)
        Me.lblProjectMeta.TabIndex = 1
        Me.lblProjectMeta.Text = "Code | Client | Status"
        '
        'lblBudgetLabel
        '
        Me.lblBudgetLabel.AutoSize = True
        Me.lblBudgetLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblBudgetLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblBudgetLabel.Location = New System.Drawing.Point(520, 18)
        Me.lblBudgetLabel.Name = "lblBudgetLabel"
        Me.lblBudgetLabel.Size = New System.Drawing.Size(45, 13)
        Me.lblBudgetLabel.TabIndex = 2
        Me.lblBudgetLabel.Text = "BUDGET"
        '
        'lblBudgetValue
        '
        Me.lblBudgetValue.AutoSize = True
        Me.lblBudgetValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBudgetValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblBudgetValue.Location = New System.Drawing.Point(518, 36)
        Me.lblBudgetValue.Name = "lblBudgetValue"
        Me.lblBudgetValue.Size = New System.Drawing.Size(50, 21)
        Me.lblBudgetValue.TabIndex = 3
        Me.lblBudgetValue.Text = "$0"
        '
        'lblDateRange
        '
        Me.lblDateRange.AutoSize = True
        Me.lblDateRange.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDateRange.ForeColor = System.Drawing.Color.Gray
        Me.lblDateRange.Location = New System.Drawing.Point(22, 62)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Size = New System.Drawing.Size(100, 15)
        Me.lblDateRange.TabIndex = 4
        Me.lblDateRange.Text = "Start to End"
        '
        'pnlTotalExpenses
        '
        Me.pnlTotalExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesSub)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesValue)
        Me.pnlTotalExpenses.Controls.Add(Me.lblTotalExpensesTitle)
        Me.pnlTotalExpenses.Location = New System.Drawing.Point(30, 110)
        Me.pnlTotalExpenses.Name = "pnlTotalExpenses"
        Me.pnlTotalExpenses.Size = New System.Drawing.Size(310, 120)
        Me.pnlTotalExpenses.TabIndex = 1
        '
        'lblTotalExpensesTitle
        '
        Me.lblTotalExpensesTitle.AutoSize = True
        Me.lblTotalExpensesTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalExpensesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblTotalExpensesTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTotalExpensesTitle.Name = "lblTotalExpensesTitle"
        Me.lblTotalExpensesTitle.Size = New System.Drawing.Size(103, 15)
        Me.lblTotalExpensesTitle.TabIndex = 0
        Me.lblTotalExpensesTitle.Text = "TOTAL EXPENSES"
        '
        'lblTotalExpensesValue
        '
        Me.lblTotalExpensesValue.AutoSize = True
        Me.lblTotalExpensesValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalExpensesValue.ForeColor = System.Drawing.Color.White
        Me.lblTotalExpensesValue.Location = New System.Drawing.Point(12, 38)
        Me.lblTotalExpensesValue.Name = "lblTotalExpensesValue"
        Me.lblTotalExpensesValue.Size = New System.Drawing.Size(50, 41)
        Me.lblTotalExpensesValue.TabIndex = 1
        Me.lblTotalExpensesValue.Text = "$0"
        '
        'lblTotalExpensesSub
        '
        Me.lblTotalExpensesSub.AutoSize = True
        Me.lblTotalExpensesSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTotalExpensesSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblTotalExpensesSub.Location = New System.Drawing.Point(15, 96)
        Me.lblTotalExpensesSub.Name = "lblTotalExpensesSub"
        Me.lblTotalExpensesSub.Size = New System.Drawing.Size(114, 13)
        Me.lblTotalExpensesSub.TabIndex = 2
        Me.lblTotalExpensesSub.Text = "All recorded expenses"
        '
        'pnlRemainingBudget
        '
        Me.pnlRemainingBudget.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlRemainingBudget.Controls.Add(Me.lblRemainingBudgetSub)
        Me.pnlRemainingBudget.Controls.Add(Me.lblRemainingBudgetValue)
        Me.pnlRemainingBudget.Controls.Add(Me.lblRemainingBudgetTitle)
        Me.pnlRemainingBudget.Location = New System.Drawing.Point(370, 110)
        Me.pnlRemainingBudget.Name = "pnlRemainingBudget"
        Me.pnlRemainingBudget.Size = New System.Drawing.Size(310, 120)
        Me.pnlRemainingBudget.TabIndex = 2
        '
        'lblRemainingBudgetTitle
        '
        Me.lblRemainingBudgetTitle.AutoSize = True
        Me.lblRemainingBudgetTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRemainingBudgetTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRemainingBudgetTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblRemainingBudgetTitle.Name = "lblRemainingBudgetTitle"
        Me.lblRemainingBudgetTitle.Size = New System.Drawing.Size(124, 15)
        Me.lblRemainingBudgetTitle.TabIndex = 0
        Me.lblRemainingBudgetTitle.Text = "REMAINING BUDGET"
        '
        'lblRemainingBudgetValue
        '
        Me.lblRemainingBudgetValue.AutoSize = True
        Me.lblRemainingBudgetValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemainingBudgetValue.ForeColor = System.Drawing.Color.White
        Me.lblRemainingBudgetValue.Location = New System.Drawing.Point(12, 38)
        Me.lblRemainingBudgetValue.Name = "lblRemainingBudgetValue"
        Me.lblRemainingBudgetValue.Size = New System.Drawing.Size(50, 41)
        Me.lblRemainingBudgetValue.TabIndex = 1
        Me.lblRemainingBudgetValue.Text = "$0"
        '
        'lblRemainingBudgetSub
        '
        Me.lblRemainingBudgetSub.AutoSize = True
        Me.lblRemainingBudgetSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblRemainingBudgetSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRemainingBudgetSub.Location = New System.Drawing.Point(15, 96)
        Me.lblRemainingBudgetSub.Name = "lblRemainingBudgetSub"
        Me.lblRemainingBudgetSub.Size = New System.Drawing.Size(108, 13)
        Me.lblRemainingBudgetSub.TabIndex = 2
        Me.lblRemainingBudgetSub.Text = "Budget minus expenses"
        '
        'pnlInvoiceTotals
        '
        Me.pnlInvoiceTotals.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlInvoiceTotals.Controls.Add(Me.lblInvoiceTotalsSub)
        Me.pnlInvoiceTotals.Controls.Add(Me.lblInvoiceTotalsValue)
        Me.pnlInvoiceTotals.Controls.Add(Me.lblInvoiceTotalsTitle)
        Me.pnlInvoiceTotals.Location = New System.Drawing.Point(30, 250)
        Me.pnlInvoiceTotals.Name = "pnlInvoiceTotals"
        Me.pnlInvoiceTotals.Size = New System.Drawing.Size(310, 120)
        Me.pnlInvoiceTotals.TabIndex = 3
        '
        'lblInvoiceTotalsTitle
        '
        Me.lblInvoiceTotalsTitle.AutoSize = True
        Me.lblInvoiceTotalsTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInvoiceTotalsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblInvoiceTotalsTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblInvoiceTotalsTitle.Name = "lblInvoiceTotalsTitle"
        Me.lblInvoiceTotalsTitle.Size = New System.Drawing.Size(102, 15)
        Me.lblInvoiceTotalsTitle.TabIndex = 0
        Me.lblInvoiceTotalsTitle.Text = "INVOICE TOTALS"
        '
        'lblInvoiceTotalsValue
        '
        Me.lblInvoiceTotalsValue.AutoSize = True
        Me.lblInvoiceTotalsValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvoiceTotalsValue.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceTotalsValue.Location = New System.Drawing.Point(12, 38)
        Me.lblInvoiceTotalsValue.Name = "lblInvoiceTotalsValue"
        Me.lblInvoiceTotalsValue.Size = New System.Drawing.Size(50, 41)
        Me.lblInvoiceTotalsValue.TabIndex = 1
        Me.lblInvoiceTotalsValue.Text = "$0"
        '
        'lblInvoiceTotalsSub
        '
        Me.lblInvoiceTotalsSub.AutoSize = True
        Me.lblInvoiceTotalsSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblInvoiceTotalsSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblInvoiceTotalsSub.Location = New System.Drawing.Point(15, 96)
        Me.lblInvoiceTotalsSub.Name = "lblInvoiceTotalsSub"
        Me.lblInvoiceTotalsSub.Size = New System.Drawing.Size(99, 13)
        Me.lblInvoiceTotalsSub.TabIndex = 2
        Me.lblInvoiceTotalsSub.Text = "All project invoices"
        '
        'pnlProfitLoss
        '
        Me.pnlProfitLoss.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossSub)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossValue)
        Me.pnlProfitLoss.Controls.Add(Me.lblProfitLossTitle)
        Me.pnlProfitLoss.Location = New System.Drawing.Point(370, 250)
        Me.pnlProfitLoss.Name = "pnlProfitLoss"
        Me.pnlProfitLoss.Size = New System.Drawing.Size(310, 120)
        Me.pnlProfitLoss.TabIndex = 4
        '
        'lblProfitLossTitle
        '
        Me.lblProfitLossTitle.AutoSize = True
        Me.lblProfitLossTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProfitLossTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.lblProfitLossTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblProfitLossTitle.Name = "lblProfitLossTitle"
        Me.lblProfitLossTitle.Size = New System.Drawing.Size(128, 15)
        Me.lblProfitLossTitle.TabIndex = 0
        Me.lblProfitLossTitle.Text = "PROFIT / LOSS ESTIMATE"
        '
        'lblProfitLossValue
        '
        Me.lblProfitLossValue.AutoSize = True
        Me.lblProfitLossValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfitLossValue.ForeColor = System.Drawing.Color.White
        Me.lblProfitLossValue.Location = New System.Drawing.Point(12, 38)
        Me.lblProfitLossValue.Name = "lblProfitLossValue"
        Me.lblProfitLossValue.Size = New System.Drawing.Size(50, 41)
        Me.lblProfitLossValue.TabIndex = 1
        Me.lblProfitLossValue.Text = "$0"
        '
        'lblProfitLossSub
        '
        Me.lblProfitLossSub.AutoSize = True
        Me.lblProfitLossSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblProfitLossSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblProfitLossSub.Location = New System.Drawing.Point(15, 96)
        Me.lblProfitLossSub.Name = "lblProfitLossSub"
        Me.lblProfitLossSub.Size = New System.Drawing.Size(155, 13)
        Me.lblProfitLossSub.TabIndex = 2
        Me.lblProfitLossSub.Text = "Paid invoices minus expenses"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(30, 390)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 5
        Me.lblError.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(600, 400)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        '
        'ProjectDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 450)
        Me.Controls.Add(Me.btnClose)
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
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlTotalExpenses.ResumeLayout(False)
        Me.pnlTotalExpenses.PerformLayout()
        Me.pnlRemainingBudget.ResumeLayout(False)
        Me.pnlRemainingBudget.PerformLayout()
        Me.pnlInvoiceTotals.ResumeLayout(False)
        Me.pnlInvoiceTotals.PerformLayout()
        Me.pnlProfitLoss.ResumeLayout(False)
        Me.pnlProfitLoss.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblProjectTitle As System.Windows.Forms.Label
    Friend WithEvents lblProjectMeta As System.Windows.Forms.Label
    Friend WithEvents lblBudgetLabel As System.Windows.Forms.Label
    Friend WithEvents lblBudgetValue As System.Windows.Forms.Label
    Friend WithEvents lblDateRange As System.Windows.Forms.Label
    Friend WithEvents pnlTotalExpenses As System.Windows.Forms.Panel
    Friend WithEvents lblTotalExpensesTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpensesValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpensesSub As System.Windows.Forms.Label
    Friend WithEvents pnlRemainingBudget As System.Windows.Forms.Panel
    Friend WithEvents lblRemainingBudgetTitle As System.Windows.Forms.Label
    Friend WithEvents lblRemainingBudgetValue As System.Windows.Forms.Label
    Friend WithEvents lblRemainingBudgetSub As System.Windows.Forms.Label
    Friend WithEvents pnlInvoiceTotals As System.Windows.Forms.Panel
    Friend WithEvents lblInvoiceTotalsTitle As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceTotalsValue As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceTotalsSub As System.Windows.Forms.Label
    Friend WithEvents pnlProfitLoss As System.Windows.Forms.Panel
    Friend WithEvents lblProfitLossTitle As System.Windows.Forms.Label
    Friend WithEvents lblProfitLossValue As System.Windows.Forms.Label
    Friend WithEvents lblProfitLossSub As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
