<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpenseListForm
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
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblProjectFilter = New System.Windows.Forms.Label()
        Me.cboProjectFilter = New System.Windows.Forms.ComboBox()
        Me.lblCategoryFilter = New System.Windows.Forms.Label()
        Me.cboCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNewExpense = New System.Windows.Forms.Button()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExpenseID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpenseDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.pnlFilter.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlFilter
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.Controls.Add(Me.btnNewExpense)
        Me.pnlFilter.Controls.Add(Me.btnClear)
        Me.pnlFilter.Controls.Add(Me.btnRefresh)
        Me.pnlFilter.Controls.Add(Me.cboCategoryFilter)
        Me.pnlFilter.Controls.Add(Me.lblCategoryFilter)
        Me.pnlFilter.Controls.Add(Me.cboProjectFilter)
        Me.pnlFilter.Controls.Add(Me.lblProjectFilter)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(980, 48)
        Me.pnlFilter.TabIndex = 0

        ' lblProjectFilter
        Me.lblProjectFilter.AutoSize = True
        Me.lblProjectFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProjectFilter.Location = New System.Drawing.Point(12, 15)
        Me.lblProjectFilter.Name = "lblProjectFilter"
        Me.lblProjectFilter.Text = "Project:"

        ' cboProjectFilter
        Me.cboProjectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProjectFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboProjectFilter.Location = New System.Drawing.Point(65, 11)
        Me.cboProjectFilter.Name = "cboProjectFilter"
        Me.cboProjectFilter.Size = New System.Drawing.Size(220, 23)
        Me.cboProjectFilter.TabIndex = 0

        ' lblCategoryFilter
        Me.lblCategoryFilter.AutoSize = True
        Me.lblCategoryFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCategoryFilter.Location = New System.Drawing.Point(298, 15)
        Me.lblCategoryFilter.Name = "lblCategoryFilter"
        Me.lblCategoryFilter.Text = "Category:"

        ' cboCategoryFilter
        Me.cboCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoryFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboCategoryFilter.Location = New System.Drawing.Point(362, 11)
        Me.cboCategoryFilter.Name = "cboCategoryFilter"
        Me.cboCategoryFilter.Size = New System.Drawing.Size(150, 23)
        Me.cboCategoryFilter.TabIndex = 1

        ' btnRefresh
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(524, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 26)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Filter"
        Me.btnRefresh.UseVisualStyleBackColor = False

        ' btnClear
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.Location = New System.Drawing.Point(607, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 26)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"

        ' btnNewExpense
        Me.btnNewExpense.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.btnNewExpense.FlatAppearance.BorderSize = 0
        Me.btnNewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewExpense.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewExpense.ForeColor = System.Drawing.Color.White
        Me.btnNewExpense.Location = New System.Drawing.Point(860, 10)
        Me.btnNewExpense.Name = "btnNewExpense"
        Me.btnNewExpense.Size = New System.Drawing.Size(110, 26)
        Me.btnNewExpense.TabIndex = 4
        Me.btnNewExpense.Text = "+ Add Expense"
        Me.btnNewExpense.UseVisualStyleBackColor = False

        ' gridView1
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {
            Me.colExpenseID, Me.colExpenseDate, Me.colProjectName,
            Me.colCategory, Me.colAmount, Me.colVendorName, Me.colDescription})
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

        ' colExpenseID (hidden)
        Me.colExpenseID.FieldName = "ExpenseID"
        Me.colExpenseID.Name = "colExpenseID"
        Me.colExpenseID.Visible = False

        ' colExpenseDate
        Me.colExpenseDate.Caption = "Date"
        Me.colExpenseDate.FieldName = "ExpenseDate"
        Me.colExpenseDate.Name = "colExpenseDate"
        Me.colExpenseDate.OptionsColumn.AllowEdit = False
        Me.colExpenseDate.Visible = True
        Me.colExpenseDate.VisibleIndex = 0
        Me.colExpenseDate.Width = 100

        ' colProjectName
        Me.colProjectName.Caption = "Project"
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.OptionsColumn.AllowEdit = False
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        Me.colProjectName.Width = 200

        ' colCategory
        Me.colCategory.Caption = "Category"
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.OptionsColumn.AllowEdit = False
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 2
        Me.colCategory.Width = 120

        ' colAmount
        Me.colAmount.Caption = "Amount"
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.OptionsColumn.AllowEdit = False
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 3
        Me.colAmount.Width = 120

        ' colVendorName
        Me.colVendorName.Caption = "Vendor"
        Me.colVendorName.FieldName = "VendorName"
        Me.colVendorName.Name = "colVendorName"
        Me.colVendorName.OptionsColumn.AllowEdit = False
        Me.colVendorName.Visible = True
        Me.colVendorName.VisibleIndex = 4
        Me.colVendorName.Width = 160

        ' colDescription
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        Me.colDescription.Width = 240

        ' gridControl1
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.TabIndex = 1
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 252)
        Me.pnlBottom.Controls.Add(Me.lblRecordCount)
        Me.pnlBottom.Controls.Add(Me.lblTotal)
        Me.pnlBottom.Controls.Add(Me.lblStatus)
        Me.pnlBottom.Controls.Add(Me.btnSummary)
        Me.pnlBottom.Controls.Add(Me.btnDelete)
        Me.pnlBottom.Controls.Add(Me.btnEdit)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(980, 48)
        Me.pnlBottom.TabIndex = 2

        ' btnEdit
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnEdit.Location = New System.Drawing.Point(10, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 26)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"

        ' btnDelete
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.btnDelete.Location = New System.Drawing.Point(100, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 26)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"

        ' btnSummary
        Me.btnSummary.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnSummary.FlatAppearance.BorderSize = 0
        Me.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSummary.ForeColor = System.Drawing.Color.White
        Me.btnSummary.Location = New System.Drawing.Point(190, 11)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(130, 26)
        Me.btnSummary.TabIndex = 5
        Me.btnSummary.Text = "Expense Summary"
        Me.btnSummary.UseVisualStyleBackColor = False

        ' lblStatus
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(335, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 2

        ' lblTotal
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(580, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 15)
        Me.lblTotal.TabIndex = 3

        ' lblRecordCount
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.Gray
        Me.lblRecordCount.Location = New System.Drawing.Point(840, 16)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(130, 15)
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblRecordCount.TabIndex = 4

        ' ExpenseListForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 580)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "ExpenseListForm"
        Me.Text = "Expenses"

        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblProjectFilter As System.Windows.Forms.Label
    Friend WithEvents cboProjectFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategoryFilter As System.Windows.Forms.Label
    Friend WithEvents cboCategoryFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnNewExpense As System.Windows.Forms.Button
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colExpenseID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpenseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
End Class
