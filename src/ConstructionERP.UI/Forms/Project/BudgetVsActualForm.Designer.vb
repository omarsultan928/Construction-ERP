<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BudgetVsActualForm
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
        Me.lblSumBudgetLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumBudgetValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumActualLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumActualValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumVarianceLabel = New DevExpress.XtraEditors.LabelControl()
        Me.lblSumVarianceValue = New DevExpress.XtraEditors.LabelControl()

        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBudgetAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBudgetStatus = New DevExpress.XtraGrid.Columns.GridColumn()

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
        Me.lblTitle.Text = "Budget vs Actual Analysis"

        Me.lblSubtitle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Appearance.Options.UseFont = True
        Me.lblSubtitle.Appearance.Options.UseForeColor = True
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Text = "Identify overspending across all projects"

        ' ── pnlSummary ─────────────────────────────────────────────────────────
        Me.pnlSummary.Appearance.BackColor = System.Drawing.Color.FromArgb(240, 242, 247)
        Me.pnlSummary.Appearance.Options.UseBackColor = True
        Me.pnlSummary.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlSummary.Controls.Add(Me.lblSumVarianceValue)
        Me.pnlSummary.Controls.Add(Me.lblSumVarianceLabel)
        Me.pnlSummary.Controls.Add(Me.lblSumActualValue)
        Me.pnlSummary.Controls.Add(Me.lblSumActualLabel)
        Me.pnlSummary.Controls.Add(Me.lblSumBudgetValue)
        Me.pnlSummary.Controls.Add(Me.lblSumBudgetLabel)
        Me.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummary.Height = 72
        Me.pnlSummary.Name = "pnlSummary"

        ' Total Budget group
        Me.lblSumBudgetLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSumBudgetLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSumBudgetLabel.Appearance.Options.UseFont = True
        Me.lblSumBudgetLabel.Appearance.Options.UseForeColor = True
        Me.lblSumBudgetLabel.Location = New System.Drawing.Point(30, 12)
        Me.lblSumBudgetLabel.Name = "lblSumBudgetLabel"
        Me.lblSumBudgetLabel.Text = "TOTAL BUDGET"

        Me.lblSumBudgetValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumBudgetValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.lblSumBudgetValue.Appearance.Options.UseFont = True
        Me.lblSumBudgetValue.Appearance.Options.UseForeColor = True
        Me.lblSumBudgetValue.Location = New System.Drawing.Point(30, 34)
        Me.lblSumBudgetValue.Name = "lblSumBudgetValue"
        Me.lblSumBudgetValue.Text = "$0"

        ' Total Actual group
        Me.lblSumActualLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSumActualLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSumActualLabel.Appearance.Options.UseFont = True
        Me.lblSumActualLabel.Appearance.Options.UseForeColor = True
        Me.lblSumActualLabel.Location = New System.Drawing.Point(330, 12)
        Me.lblSumActualLabel.Name = "lblSumActualLabel"
        Me.lblSumActualLabel.Text = "TOTAL ACTUAL COST"

        Me.lblSumActualValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumActualValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(191, 54, 12)
        Me.lblSumActualValue.Appearance.Options.UseFont = True
        Me.lblSumActualValue.Appearance.Options.UseForeColor = True
        Me.lblSumActualValue.Location = New System.Drawing.Point(330, 34)
        Me.lblSumActualValue.Name = "lblSumActualValue"
        Me.lblSumActualValue.Text = "$0"

        ' Total Variance group
        Me.lblSumVarianceLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSumVarianceLabel.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblSumVarianceLabel.Appearance.Options.UseFont = True
        Me.lblSumVarianceLabel.Appearance.Options.UseForeColor = True
        Me.lblSumVarianceLabel.Location = New System.Drawing.Point(630, 12)
        Me.lblSumVarianceLabel.Name = "lblSumVarianceLabel"
        Me.lblSumVarianceLabel.Text = "TOTAL VARIANCE"

        Me.lblSumVarianceValue.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumVarianceValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.lblSumVarianceValue.Appearance.Options.UseFont = True
        Me.lblSumVarianceValue.Appearance.Options.UseForeColor = True
        Me.lblSumVarianceValue.Location = New System.Drawing.Point(630, 34)
        Me.lblSumVarianceValue.Name = "lblSumVarianceValue"
        Me.lblSumVarianceValue.Text = "$0"

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
            Me.colProjectID, Me.colProjectCode, Me.colProjectName,
            Me.colBudgetAmount, Me.colActualAmount, Me.colVariance,
            Me.colPercentUsed, Me.colBudgetStatus})
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
        Me.colProjectCode.Width = 100

        Me.colProjectName.Caption = "Project Name"
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.OptionsColumn.AllowEdit = False
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        Me.colProjectName.Width = 200

        Me.colBudgetAmount.Caption = "Budget"
        Me.colBudgetAmount.DisplayFormat.FormatString = "C0"
        Me.colBudgetAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBudgetAmount.FieldName = "BudgetAmount"
        Me.colBudgetAmount.Name = "colBudgetAmount"
        Me.colBudgetAmount.OptionsColumn.AllowEdit = False
        Me.colBudgetAmount.Visible = True
        Me.colBudgetAmount.VisibleIndex = 2
        Me.colBudgetAmount.Width = 120

        Me.colActualAmount.Caption = "Actual Cost"
        Me.colActualAmount.DisplayFormat.FormatString = "C0"
        Me.colActualAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colActualAmount.FieldName = "ActualAmount"
        Me.colActualAmount.Name = "colActualAmount"
        Me.colActualAmount.OptionsColumn.AllowEdit = False
        Me.colActualAmount.Visible = True
        Me.colActualAmount.VisibleIndex = 3
        Me.colActualAmount.Width = 120

        Me.colVariance.Caption = "Variance"
        Me.colVariance.DisplayFormat.FormatString = "C0"
        Me.colVariance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVariance.FieldName = "Variance"
        Me.colVariance.Name = "colVariance"
        Me.colVariance.OptionsColumn.AllowEdit = False
        Me.colVariance.Visible = True
        Me.colVariance.VisibleIndex = 4
        Me.colVariance.Width = 120

        Me.colPercentUsed.Caption = "% Used"
        Me.colPercentUsed.DisplayFormat.FormatString = "N1"
        Me.colPercentUsed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPercentUsed.FieldName = "PercentUsed"
        Me.colPercentUsed.Name = "colPercentUsed"
        Me.colPercentUsed.OptionsColumn.AllowEdit = False
        Me.colPercentUsed.Visible = True
        Me.colPercentUsed.VisibleIndex = 5
        Me.colPercentUsed.Width = 80

        Me.colBudgetStatus.Caption = "Status"
        Me.colBudgetStatus.FieldName = "BudgetStatus"
        Me.colBudgetStatus.Name = "colBudgetStatus"
        Me.colBudgetStatus.OptionsColumn.AllowEdit = False
        Me.colBudgetStatus.Visible = True
        Me.colBudgetStatus.VisibleIndex = 6
        Me.colBudgetStatus.Width = 120

        ' ── gridControl1 ───────────────────────────────────────────────────────
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})

        ' ── BudgetVsActualForm ─────────────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 560)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlActions)
        Me.Name = "BudgetVsActualForm"
        Me.Text = "Budget vs Actual"

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
    Friend WithEvents lblSumBudgetLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumBudgetValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumActualLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumActualValue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumVarianceLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSumVarianceValue As DevExpress.XtraEditors.LabelControl

    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProjectID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBudgetAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBudgetStatus As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents pnlActions As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
