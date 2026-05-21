<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectListForm
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblStatusFilter = New System.Windows.Forms.Label()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBudget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.pnlFilter.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.Controls.Add(Me.btnNewProject)
        Me.pnlFilter.Controls.Add(Me.btnClear)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Controls.Add(Me.cboSort)
        Me.pnlFilter.Controls.Add(Me.lblSort)
        Me.pnlFilter.Controls.Add(Me.cboStatusFilter)
        Me.pnlFilter.Controls.Add(Me.lblStatusFilter)
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Controls.Add(Me.lblSearch)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(900, 48)
        Me.pnlFilter.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.Location = New System.Drawing.Point(12, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(45, 15)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(65, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(160, 23)
        Me.txtSearch.TabIndex = 1
        '
        'lblStatusFilter
        '
        Me.lblStatusFilter.AutoSize = True
        Me.lblStatusFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusFilter.Location = New System.Drawing.Point(238, 15)
        Me.lblStatusFilter.Name = "lblStatusFilter"
        Me.lblStatusFilter.Size = New System.Drawing.Size(42, 15)
        Me.lblStatusFilter.TabIndex = 2
        Me.lblStatusFilter.Text = "Status:"
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatusFilter.Location = New System.Drawing.Point(286, 11)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(130, 23)
        Me.cboStatusFilter.TabIndex = 3
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSort.Location = New System.Drawing.Point(428, 15)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(32, 15)
        Me.lblSort.TabIndex = 4
        Me.lblSort.Text = "Sort:"
        '
        'cboSort
        '
        Me.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboSort.Location = New System.Drawing.Point(466, 11)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(155, 23)
        Me.cboSort.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(632, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.Location = New System.Drawing.Point(715, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 26)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        '
        'btnNewProject
        '
        Me.btnNewProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnNewProject.FlatAppearance.BorderSize = 0
        Me.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewProject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewProject.ForeColor = System.Drawing.Color.White
        Me.btnNewProject.Location = New System.Drawing.Point(785, 10)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(110, 26)
        Me.btnNewProject.TabIndex = 8
        Me.btnNewProject.Text = "+ New Project"
        Me.btnNewProject.UseVisualStyleBackColor = False
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProjectID, Me.colProjectCode, Me.colProjectName, Me.colClientName, Me.colBudget, Me.colStartDate, Me.colStatus})
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
        '
        'colProjectID
        '
        Me.colProjectID.FieldName = "ProjectID"
        Me.colProjectID.Name = "colProjectID"
        Me.colProjectID.OptionsColumn.AllowEdit = False
        Me.colProjectID.Visible = False
        '
        'colProjectCode
        '
        Me.colProjectCode.Caption = "Code"
        Me.colProjectCode.FieldName = "ProjectCode"
        Me.colProjectCode.Name = "colProjectCode"
        Me.colProjectCode.OptionsColumn.AllowEdit = False
        Me.colProjectCode.Visible = True
        Me.colProjectCode.VisibleIndex = 0
        Me.colProjectCode.Width = 100
        '
        'colProjectName
        '
        Me.colProjectName.Caption = "Project Name"
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.OptionsColumn.AllowEdit = False
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        Me.colProjectName.Width = 200
        '
        'colClientName
        '
        Me.colClientName.Caption = "Client"
        Me.colClientName.FieldName = "ClientName"
        Me.colClientName.Name = "colClientName"
        Me.colClientName.OptionsColumn.AllowEdit = False
        Me.colClientName.Visible = True
        Me.colClientName.VisibleIndex = 2
        Me.colClientName.Width = 170
        '
        'colBudget
        '
        Me.colBudget.Caption = "Budget"
        Me.colBudget.FieldName = "Budget"
        Me.colBudget.Name = "colBudget"
        Me.colBudget.OptionsColumn.AllowEdit = False
        Me.colBudget.Visible = True
        Me.colBudget.VisibleIndex = 3
        Me.colBudget.Width = 110
        '
        'colStartDate
        '
        Me.colStartDate.Caption = "Start Date"
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.OptionsColumn.AllowEdit = False
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 4
        Me.colStartDate.Width = 100
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 5
        Me.colStatus.Width = 100
        '
        'gridControl1
        '
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.Location = New System.Drawing.Point(0, 48)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(900, 424)
        Me.gridControl1.TabIndex = 1
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.lblRecordCount)
        Me.pnlBottom.Controls.Add(Me.lblStatus)
        Me.pnlBottom.Controls.Add(Me.btnViewDetails)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 472)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(900, 48)
        Me.pnlBottom.TabIndex = 2
        '
        'btnViewDetails
        '
        Me.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnViewDetails.Location = New System.Drawing.Point(10, 11)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(110, 26)
        Me.btnViewDetails.TabIndex = 0
        Me.btnViewDetails.Text = "View Details"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(135, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 1
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.Gray
        Me.lblRecordCount.Location = New System.Drawing.Point(760, 16)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(130, 15)
        Me.lblRecordCount.TabIndex = 2
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ProjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 520)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "ProjectListForm"
        Me.Text = "Projects"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusFilter As System.Windows.Forms.Label
    Friend WithEvents cboStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblSort As System.Windows.Forms.Label
    Friend WithEvents cboSort As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProjectID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBudget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
End Class
