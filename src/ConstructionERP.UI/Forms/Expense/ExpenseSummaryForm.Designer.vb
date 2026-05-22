<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpenseSummaryForm
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
        ' --- Header panel ---
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblProjectTitle = New System.Windows.Forms.Label()
        Me.lblProjectMeta = New System.Windows.Forms.Label()

        ' --- Budget vs Actual KPI tiles ---
        Me.pnlKpis = New System.Windows.Forms.Panel()

        Me.pnlBudget = New System.Windows.Forms.Panel()
        Me.lblBudgetTitle = New System.Windows.Forms.Label()
        Me.lblBudgetValue = New System.Windows.Forms.Label()
        Me.lblBudgetSub = New System.Windows.Forms.Label()

        Me.pnlActual = New System.Windows.Forms.Panel()
        Me.lblActualTitle = New System.Windows.Forms.Label()
        Me.lblActualValue = New System.Windows.Forms.Label()
        Me.lblActualSub = New System.Windows.Forms.Label()

        Me.pnlVariance = New System.Windows.Forms.Panel()
        Me.lblVarianceTitle = New System.Windows.Forms.Label()
        Me.lblVarianceValue = New System.Windows.Forms.Label()
        Me.lblVarianceSub = New System.Windows.Forms.Label()

        ' --- Category grid ---
        Me.lblCategoryTitle = New System.Windows.Forms.Label()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpenseCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentage = New DevExpress.XtraGrid.Columns.GridColumn()

        ' --- Footer ---
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlKpis.SuspendLayout()
        Me.pnlBudget.SuspendLayout()
        Me.pnlActual.SuspendLayout()
        Me.pnlVariance.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()

        ' -----------------------------------------------
        ' pnlHeader
        ' -----------------------------------------------
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.pnlHeader.Controls.Add(Me.lblProjectMeta)
        Me.pnlHeader.Controls.Add(Me.lblProjectTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(760, 64)
        Me.pnlHeader.TabIndex = 0

        Me.lblProjectTitle.AutoSize = True
        Me.lblProjectTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblProjectTitle.ForeColor = System.Drawing.Color.White
        Me.lblProjectTitle.Location = New System.Drawing.Point(16, 10)
        Me.lblProjectTitle.Name = "lblProjectTitle"
        Me.lblProjectTitle.Text = "Project Name"

        Me.lblProjectMeta.AutoSize = True
        Me.lblProjectMeta.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblProjectMeta.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblProjectMeta.Location = New System.Drawing.Point(18, 40)
        Me.lblProjectMeta.Name = "lblProjectMeta"
        Me.lblProjectMeta.Text = "Code  |  Client  |  Status"

        ' -----------------------------------------------
        ' pnlKpis  (Budget / Actual / Variance)
        ' -----------------------------------------------
        Me.pnlKpis.BackColor = System.Drawing.Color.FromArgb(240, 242, 247)
        Me.pnlKpis.Controls.Add(Me.pnlBudget)
        Me.pnlKpis.Controls.Add(Me.pnlActual)
        Me.pnlKpis.Controls.Add(Me.pnlVariance)
        Me.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKpis.Name = "pnlKpis"
        Me.pnlKpis.Padding = New System.Windows.Forms.Padding(16, 12, 16, 12)
        Me.pnlKpis.Size = New System.Drawing.Size(760, 110)
        Me.pnlKpis.TabIndex = 1

        ' Budget tile
        Me.pnlBudget.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.pnlBudget.Controls.Add(Me.lblBudgetSub)
        Me.pnlBudget.Controls.Add(Me.lblBudgetValue)
        Me.pnlBudget.Controls.Add(Me.lblBudgetTitle)
        Me.pnlBudget.Location = New System.Drawing.Point(16, 12)
        Me.pnlBudget.Name = "pnlBudget"
        Me.pnlBudget.Size = New System.Drawing.Size(220, 86)

        Me.lblBudgetTitle.AutoSize = True
        Me.lblBudgetTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblBudgetTitle.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255)
        Me.lblBudgetTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblBudgetTitle.Name = "lblBudgetTitle"
        Me.lblBudgetTitle.Text = "PROJECT BUDGET"

        Me.lblBudgetValue.AutoSize = True
        Me.lblBudgetValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblBudgetValue.ForeColor = System.Drawing.Color.White
        Me.lblBudgetValue.Location = New System.Drawing.Point(10, 30)
        Me.lblBudgetValue.Name = "lblBudgetValue"
        Me.lblBudgetValue.Text = "$0"

        Me.lblBudgetSub.AutoSize = True
        Me.lblBudgetSub.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblBudgetSub.ForeColor = System.Drawing.Color.FromArgb(170, 210, 255)
        Me.lblBudgetSub.Location = New System.Drawing.Point(12, 68)
        Me.lblBudgetSub.Name = "lblBudgetSub"
        Me.lblBudgetSub.Text = "Approved project budget"

        ' Actual tile
        Me.pnlActual.BackColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.pnlActual.Controls.Add(Me.lblActualSub)
        Me.pnlActual.Controls.Add(Me.lblActualValue)
        Me.pnlActual.Controls.Add(Me.lblActualTitle)
        Me.pnlActual.Location = New System.Drawing.Point(252, 12)
        Me.pnlActual.Name = "pnlActual"
        Me.pnlActual.Size = New System.Drawing.Size(220, 86)

        Me.lblActualTitle.AutoSize = True
        Me.lblActualTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblActualTitle.ForeColor = System.Drawing.Color.FromArgb(255, 210, 190)
        Me.lblActualTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblActualTitle.Name = "lblActualTitle"
        Me.lblActualTitle.Text = "ACTUAL SPEND"

        Me.lblActualValue.AutoSize = True
        Me.lblActualValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblActualValue.ForeColor = System.Drawing.Color.White
        Me.lblActualValue.Location = New System.Drawing.Point(10, 30)
        Me.lblActualValue.Name = "lblActualValue"
        Me.lblActualValue.Text = "$0"

        Me.lblActualSub.AutoSize = True
        Me.lblActualSub.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblActualSub.ForeColor = System.Drawing.Color.FromArgb(255, 190, 160)
        Me.lblActualSub.Location = New System.Drawing.Point(12, 68)
        Me.lblActualSub.Name = "lblActualSub"
        Me.lblActualSub.Text = "Total recorded expenses"

        ' Variance tile
        Me.pnlVariance.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.pnlVariance.Controls.Add(Me.lblVarianceSub)
        Me.pnlVariance.Controls.Add(Me.lblVarianceValue)
        Me.pnlVariance.Controls.Add(Me.lblVarianceTitle)
        Me.pnlVariance.Location = New System.Drawing.Point(488, 12)
        Me.pnlVariance.Name = "pnlVariance"
        Me.pnlVariance.Size = New System.Drawing.Size(220, 86)

        Me.lblVarianceTitle.AutoSize = True
        Me.lblVarianceTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblVarianceTitle.ForeColor = System.Drawing.Color.FromArgb(180, 230, 195)
        Me.lblVarianceTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblVarianceTitle.Name = "lblVarianceTitle"
        Me.lblVarianceTitle.Text = "VARIANCE"

        Me.lblVarianceValue.AutoSize = True
        Me.lblVarianceValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblVarianceValue.ForeColor = System.Drawing.Color.White
        Me.lblVarianceValue.Location = New System.Drawing.Point(10, 30)
        Me.lblVarianceValue.Name = "lblVarianceValue"
        Me.lblVarianceValue.Text = "$0"

        Me.lblVarianceSub.AutoSize = True
        Me.lblVarianceSub.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblVarianceSub.ForeColor = System.Drawing.Color.FromArgb(170, 225, 185)
        Me.lblVarianceSub.Location = New System.Drawing.Point(12, 68)
        Me.lblVarianceSub.Name = "lblVarianceSub"
        Me.lblVarianceSub.Text = "Under Budget"

        ' -----------------------------------------------
        ' Category breakdown section label
        ' -----------------------------------------------
        Me.lblCategoryTitle.AutoSize = True
        Me.lblCategoryTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblCategoryTitle.Location = New System.Drawing.Point(16, 190)
        Me.lblCategoryTitle.Name = "lblCategoryTitle"
        Me.lblCategoryTitle.Text = "EXPENSE BREAKDOWN BY CATEGORY"

        ' -----------------------------------------------
        ' Grid
        ' -----------------------------------------------
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {
            Me.colCategory, Me.colExpenseCount, Me.colTotalAmount, Me.colPercentage})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowGroup = False
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView1.OptionsView.EnableAppearanceOddRow = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.OptionsView.ShowFooter = True
        Me.gridView1.RowHeight = 30

        Me.colCategory.Caption = "Category"
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.OptionsColumn.AllowEdit = False
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 0
        Me.colCategory.Width = 200

        Me.colExpenseCount.Caption = "# Expenses"
        Me.colExpenseCount.FieldName = "ExpenseCount"
        Me.colExpenseCount.Name = "colExpenseCount"
        Me.colExpenseCount.OptionsColumn.AllowEdit = False
        Me.colExpenseCount.Visible = True
        Me.colExpenseCount.VisibleIndex = 1
        Me.colExpenseCount.Width = 100

        Me.colTotalAmount.Caption = "Total Amount"
        Me.colTotalAmount.FieldName = "TotalAmount"
        Me.colTotalAmount.Name = "colTotalAmount"
        Me.colTotalAmount.OptionsColumn.AllowEdit = False
        Me.colTotalAmount.Visible = True
        Me.colTotalAmount.VisibleIndex = 2
        Me.colTotalAmount.Width = 160

        Me.colPercentage.Caption = "% of Total"
        Me.colPercentage.FieldName = "PercentageOfTotal"
        Me.colPercentage.Name = "colPercentage"
        Me.colPercentage.OptionsColumn.AllowEdit = False
        Me.colPercentage.Visible = True
        Me.colPercentage.VisibleIndex = 3
        Me.colPercentage.Width = 100

        Me.gridControl1.Location = New System.Drawing.Point(16, 212)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(726, 220)
        Me.gridControl1.TabIndex = 2
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})

        ' -----------------------------------------------
        ' Footer panel
        ' -----------------------------------------------
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(248, 249, 252)
        Me.pnlFooter.Controls.Add(Me.btnClose)
        Me.pnlFooter.Controls.Add(Me.lblError)
        Me.pnlFooter.Controls.Add(Me.lblTotalExpenses)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(760, 48)
        Me.pnlFooter.TabIndex = 3

        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblTotalExpenses.Location = New System.Drawing.Point(16, 14)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Text = "Total Project Cost:  $0"

        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.lblError.Location = New System.Drawing.Point(280, 16)
        Me.lblError.Name = "lblError"
        Me.lblError.Text = ""
        Me.lblError.Visible = False

        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(644, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"

        ' -----------------------------------------------
        ' ExpenseSummaryForm
        ' -----------------------------------------------
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 540)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.lblCategoryTitle)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlKpis)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExpenseSummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expense Summary"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlKpis.ResumeLayout(False)
        Me.pnlBudget.ResumeLayout(False)
        Me.pnlBudget.PerformLayout()
        Me.pnlActual.ResumeLayout(False)
        Me.pnlActual.PerformLayout()
        Me.pnlVariance.ResumeLayout(False)
        Me.pnlVariance.PerformLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblProjectTitle As System.Windows.Forms.Label
    Friend WithEvents lblProjectMeta As System.Windows.Forms.Label
    Friend WithEvents pnlKpis As System.Windows.Forms.Panel
    Friend WithEvents pnlBudget As System.Windows.Forms.Panel
    Friend WithEvents lblBudgetTitle As System.Windows.Forms.Label
    Friend WithEvents lblBudgetValue As System.Windows.Forms.Label
    Friend WithEvents lblBudgetSub As System.Windows.Forms.Label
    Friend WithEvents pnlActual As System.Windows.Forms.Panel
    Friend WithEvents lblActualTitle As System.Windows.Forms.Label
    Friend WithEvents lblActualValue As System.Windows.Forms.Label
    Friend WithEvents lblActualSub As System.Windows.Forms.Label
    Friend WithEvents pnlVariance As System.Windows.Forms.Panel
    Friend WithEvents lblVarianceTitle As System.Windows.Forms.Label
    Friend WithEvents lblVarianceValue As System.Windows.Forms.Label
    Friend WithEvents lblVarianceSub As System.Windows.Forms.Label
    Friend WithEvents lblCategoryTitle As System.Windows.Forms.Label
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpenseCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
