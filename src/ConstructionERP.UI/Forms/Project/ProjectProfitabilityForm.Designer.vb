<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectProfitabilityForm
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
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubtitle = New DevExpress.XtraEditors.LabelControl()

        Me.pnlSummary = New DevExpress.XtraEditors.PanelControl()
        Me.lblSumInvoicedLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumInvoicedValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumExpensesLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumExpensesValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumProfitLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumProfitValue = New DevExpress.XtraEditors.LabelControl()

        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalExpenses = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedProfit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProfitMarginPct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProfitStatus = New DevExpress.XtraGrid.Columns.GridColumn()

        Me.pnlActions = New DevExpress.XtraEditors.PanelControl()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()

        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pnlSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSummary.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlActions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()

        ' ── pnlHeader ──────────────────────────────────────────────────────────
        Me.pnlHeader.Appearance.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Appearance.Options.UseBackColor = True
        Me.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 64
        Me.pnlHeader.Name = "pnlHeader"

        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(28, 40, 65)
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseForeColor = True
        Me.lblTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "Project Profitability"

        Me.lblSubtitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Appearance.Options.UseFont = True
        Me.lblSubtitle.Appearance.Options.UseForeColor = True
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Text = "Profit = Invoice Amount  −  Total Expenses"

        ' ── pnlSummary ─────────────────────────────────────────────────────────
        Me.pnlSummary.Appearance.BackColor = System.Drawing.Color.FromArgb(240, 242, 247)
        Me.pnlSummary.Appearance.Options.UseBackColor = True
        Me.pnlSummary.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlSummary.Controls.Add(Me.lblSumProfitValue)
        Me.pnlSummary.Controls.Add(Me.lblSumProfitLabel)
        Me.pnlSummary.Controls.Add(Me.lblSumExpensesValue)
        Me.pnlSummary.Controls.Add(Me.lblSumExpensesLabel)
        Me.pnlSummary.Controls.Add(Me.lblSumInvoicedValue)
        Me.pnlSummary.Controls.Add(Me.lblSumInvoicedLabel)
        Me.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummary.Height = 72
        Me.pnlSummary.Name = "pnlSummary"

        ' Total Invoiced group
        Me.lblSumInvoicedLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSumInvoicedLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSumInvoicedLabel.Appearance.Options.UseFont = True
        Me.lblSumInvoicedLabel.Appearance.Options.UseForeColor = True
        Me.lblSumInvoicedLabel.Location = New System.Drawing.Point(30, 12)
        Me.lblSumInvoicedLabel.Name = "lblSumInvoicedLabel"
        Me.lblSumInvoicedLabel.Text = "TOTAL INVOICED"

        Me.lblSumInvoicedValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumInvoicedValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.lblSumInvoicedValue.Appearance.Options.UseFont = True
        Me.lblSumInvoicedValue.Appearance.Options.UseForeColor = True
        Me.lblSumInvoicedValue.Location = New System.Drawing.Point(30, 34)
        Me.lblSumInvoicedValue.Name = "lblSumInvoicedValue"
        Me.lblSumInvoicedValue.Text = "$0"

        ' Total Expenses group
        Me.lblSumExpensesLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSumExpensesLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSumExpensesLabel.Appearance.Options.UseFont = True
        Me.lblSumExpensesLabel.Appearance.Options.UseForeColor = True
        Me.lblSumExpensesLabel.Location = New System.Drawing.Point(330, 12)
        Me.lblSumExpensesLabel.Name = "lblSumExpensesLabel"
        Me.lblSumExpensesLabel.Text = "TOTAL EXPENSES"

        Me.lblSumExpensesValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumExpensesValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.lblSumExpensesValue.Appearance.Options.UseFont = True
        Me.lblSumExpensesValue.Appearance.Options.UseForeColor = True
        Me.lblSumExpensesValue.Location = New System.Drawing.Point(330, 34)
        Me.lblSumExpensesValue.Name = "lblSumExpensesValue"
        Me.lblSumExpensesValue.Text = "$0"

        ' Net Profit group
        Me.lblSumProfitLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSumProfitLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSumProfitLabel.Appearance.Options.UseFont = True
        Me.lblSumProfitLabel.Appearance.Options.UseForeColor = True
        Me.lblSumProfitLabel.Location = New System.Drawing.Point(630, 12)
        Me.lblSumProfitLabel.Name = "lblSumProfitLabel"
        Me.lblSumProfitLabel.Text = "NET PROFIT / LOSS"

        Me.lblSumProfitValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumProfitValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.lblSumProfitValue.Appearance.Options.UseFont = True
        Me.lblSumProfitValue.Appearance.Options.UseForeColor = True
        Me.lblSumProfitValue.Location = New System.Drawing.Point(630, 34)
        Me.lblSumProfitValue.Name = "lblSumProfitValue"
        Me.lblSumProfitValue.Text = "$0"

        ' ── pnlActions ─────────────────────────────────────────────────────────
        Me.pnlActions.Appearance.BackColor = System.Drawing.Color.FromArgb(248, 249, 252)
        Me.pnlActions.Appearance.Options.UseBackColor = True
        Me.pnlActions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlActions.Controls.Add(Me.btnClose)
        Me.pnlActions.Controls.Add(Me.btnRefresh)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Height = 48
        Me.pnlActions.Name = "pnlActions"

        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Location = New System.Drawing.Point(10, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 28)
        Me.btnRefresh.Text = "Refresh"

        Me.btnClose.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(790, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 28)
        Me.btnClose.Text = "Close"

        ' ── gridView1 ──────────────────────────────────────────────────────────
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {
            Me.colProjectID, Me.colProjectCode, Me.colProjectName, Me.colClientName,
            Me.colStatus, Me.colInvoiceAmount, Me.colTotalExpenses,
            Me.colEstimatedProfit, Me.colProfitMarginPct, Me.colProfitStatus})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowGroup = False
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView1.OptionsView.EnableAppearanceOddRow = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.RowHeight = 28

        Me.colProjectID.FieldName = "ProjectID"
        Me.colProjectID.Name = "colProjectID"
        Me.colProjectID.OptionsColumn.AllowEdit = False
        Me.colProjectID.Visible = False

        Me.colProjectCode.Caption = "Code"
        Me.colProjectCode.FieldName = "ProjectCode"
        Me.colProjectCode.Name = "colProjectCode"
        Me.colProjectCode.OptionsColumn.AllowEdit = False
        Me.colProjectCode.Visible = True
        Me.colProjectCode.VisibleIndex = 0
        Me.colProjectCode.Width = 90

        Me.colProjectName.Caption = "Project Name"
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.OptionsColumn.AllowEdit = False
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        Me.colProjectName.Width = 190

        Me.colClientName.Caption = "Client"
        Me.colClientName.FieldName = "ClientName"
        Me.colClientName.Name = "colClientName"
        Me.colClientName.OptionsColumn.AllowEdit = False
        Me.colClientName.Visible = True
        Me.colClientName.VisibleIndex = 2
        Me.colClientName.Width = 140

        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 90

        Me.colInvoiceAmount.Caption = "Invoice Amount"
        Me.colInvoiceAmount.DisplayFormat.FormatString = "C0"
        Me.colInvoiceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInvoiceAmount.FieldName = "InvoiceAmount"
        Me.colInvoiceAmount.Name = "colInvoiceAmount"
        Me.colInvoiceAmount.OptionsColumn.AllowEdit = False
        Me.colInvoiceAmount.Visible = True
        Me.colInvoiceAmount.VisibleIndex = 4
        Me.colInvoiceAmount.Width = 120

        Me.colTotalExpenses.Caption = "Total Expenses"
        Me.colTotalExpenses.DisplayFormat.FormatString = "C0"
        Me.colTotalExpenses.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalExpenses.FieldName = "TotalExpenses"
        Me.colTotalExpenses.Name = "colTotalExpenses"
        Me.colTotalExpenses.OptionsColumn.AllowEdit = False
        Me.colTotalExpenses.Visible = True
        Me.colTotalExpenses.VisibleIndex = 5
        Me.colTotalExpenses.Width = 120

        Me.colEstimatedProfit.Caption = "Profit / Loss"
        Me.colEstimatedProfit.DisplayFormat.FormatString = "C0"
        Me.colEstimatedProfit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatedProfit.FieldName = "EstimatedProfit"
        Me.colEstimatedProfit.Name = "colEstimatedProfit"
        Me.colEstimatedProfit.OptionsColumn.AllowEdit = False
        Me.colEstimatedProfit.Visible = True
        Me.colEstimatedProfit.VisibleIndex = 6
        Me.colEstimatedProfit.Width = 110

        Me.colProfitMarginPct.Caption = "Margin %"
        Me.colProfitMarginPct.DisplayFormat.FormatString = "N1"
        Me.colProfitMarginPct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProfitMarginPct.FieldName = "ProfitMarginPct"
        Me.colProfitMarginPct.Name = "colProfitMarginPct"
        Me.colProfitMarginPct.OptionsColumn.AllowEdit = False
        Me.colProfitMarginPct.Visible = True
        Me.colProfitMarginPct.VisibleIndex = 7
        Me.colProfitMarginPct.Width = 80

        Me.colProfitStatus.Caption = "Result"
        Me.colProfitStatus.FieldName = "ProfitStatus"
        Me.colProfitStatus.Name = "colProfitStatus"
        Me.colProfitStatus.OptionsColumn.AllowEdit = False
        Me.colProfitStatus.Visible = True
        Me.colProfitStatus.VisibleIndex = 8
        Me.colProfitStatus.Width = 100

        ' ── gridControl1 ───────────────────────────────────────────────────────
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})

        ' ── ProjectProfitabilityForm ────────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 560)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlActions)
        Me.Name = "ProjectProfitabilityForm"
        Me.Text = "Project Profitability"

        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.pnlSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSummary.ResumeLayout(False)
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlActions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSubtitle As DevExpress.XtraEditors.LabelControl

    Friend WithEvents pnlSummary As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblSumInvoicedLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumInvoicedValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumExpensesLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumExpensesValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumProfitLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumProfitValue As DevExpress.XtraEditors.LabelControl

    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProjectID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalExpenses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedProfit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProfitMarginPct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProfitStatus As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents pnlActions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
