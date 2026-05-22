<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceListForm
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
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.gridAll = New DevExpress.XtraGrid.GridControl()
        Me.gridViewAll = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAllInvoiceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllProjectCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllClientName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlAllFilter = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblStatusFilter = New System.Windows.Forms.Label()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlAllBottom = New System.Windows.Forms.Panel()
        Me.lblAllCount = New System.Windows.Forms.Label()
        Me.btnUpdateStatus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tabOutstanding = New System.Windows.Forms.TabPage()
        Me.gridOutstanding = New DevExpress.XtraGrid.GridControl()
        Me.gridViewOutstanding = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOutInvoiceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutProjectCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutDaysUntilDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutUrgency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlOutstandingHeader = New System.Windows.Forms.Panel()
        Me.lblOutstandingTotal = New System.Windows.Forms.Label()
        Me.btnOutstandingRefresh = New System.Windows.Forms.Button()
        Me.pnlOutstandingBottom = New System.Windows.Forms.Panel()
        Me.lblOutstandingCount = New System.Windows.Forms.Label()
        Me.btnOutstandingUpdateStatus = New System.Windows.Forms.Button()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tabMain.SuspendLayout()
        Me.tabAll.SuspendLayout()
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAllFilter.SuspendLayout()
        Me.pnlAllBottom.SuspendLayout()
        Me.tabOutstanding.SuspendLayout()
        CType(Me.gridOutstanding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewOutstanding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOutstandingHeader.SuspendLayout()
        Me.pnlOutstandingBottom.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabAll)
        Me.tabMain.Controls.Add(Me.tabOutstanding)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(940, 492)
        Me.tabMain.TabIndex = 0
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.gridAll)
        Me.tabAll.Controls.Add(Me.pnlAllBottom)
        Me.tabAll.Controls.Add(Me.pnlAllFilter)
        Me.tabAll.Location = New System.Drawing.Point(4, 24)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAll.Size = New System.Drawing.Size(932, 464)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "All Invoices"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'pnlAllFilter
        '
        Me.pnlAllFilter.BackColor = System.Drawing.Color.White
        Me.pnlAllFilter.Controls.Add(Me.btnAdd)
        Me.pnlAllFilter.Controls.Add(Me.btnClear)
        Me.pnlAllFilter.Controls.Add(Me.btnSearch)
        Me.pnlAllFilter.Controls.Add(Me.cboStatusFilter)
        Me.pnlAllFilter.Controls.Add(Me.lblStatusFilter)
        Me.pnlAllFilter.Controls.Add(Me.txtSearch)
        Me.pnlAllFilter.Controls.Add(Me.lblSearch)
        Me.pnlAllFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAllFilter.Location = New System.Drawing.Point(3, 3)
        Me.pnlAllFilter.Name = "pnlAllFilter"
        Me.pnlAllFilter.Size = New System.Drawing.Size(926, 48)
        Me.pnlAllFilter.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(10, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(45, 15)
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(60, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(160, 23)
        Me.txtSearch.TabIndex = 0
        '
        'lblStatusFilter
        '
        Me.lblStatusFilter.AutoSize = True
        Me.lblStatusFilter.Location = New System.Drawing.Point(232, 15)
        Me.lblStatusFilter.Name = "lblStatusFilter"
        Me.lblStatusFilter.Size = New System.Drawing.Size(42, 15)
        Me.lblStatusFilter.Text = "Status:"
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFilter.Location = New System.Drawing.Point(280, 11)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(120, 23)
        Me.cboStatusFilter.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(414, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(497, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 26)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(800, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 26)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+ Create Invoice"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gridViewAll
        '
        Me.gridViewAll.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAllInvoiceID, Me.colAllInvoiceNo, Me.colAllProjectCode, Me.colAllProjectName, Me.colAllClientName, Me.colAllAmount, Me.colAllInvoiceDate, Me.colAllDueDate, Me.colAllStatus})
        Me.gridViewAll.GridControl = Me.gridAll
        Me.gridViewAll.Name = "gridViewAll"
        Me.gridViewAll.OptionsCustomization.AllowColumnMoving = False
        Me.gridViewAll.OptionsCustomization.AllowGroup = False
        Me.gridViewAll.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewAll.OptionsView.ColumnAutoWidth = False
        Me.gridViewAll.OptionsView.ShowGroupPanel = False
        Me.gridViewAll.RowHeight = 28
        '
        'colAllInvoiceID
        '
        Me.colAllInvoiceID.FieldName = "InvoiceID"
        Me.colAllInvoiceID.Name = "colAllInvoiceID"
        Me.colAllInvoiceID.Visible = False
        '
        'colAllInvoiceNo
        '
        Me.colAllInvoiceNo.Caption = "Invoice #"
        Me.colAllInvoiceNo.FieldName = "InvoiceNo"
        Me.colAllInvoiceNo.Name = "colAllInvoiceNo"
        Me.colAllInvoiceNo.OptionsColumn.AllowEdit = False
        Me.colAllInvoiceNo.Visible = True
        Me.colAllInvoiceNo.VisibleIndex = 0
        Me.colAllInvoiceNo.Width = 110
        '
        'colAllProjectCode
        '
        Me.colAllProjectCode.Caption = "Code"
        Me.colAllProjectCode.FieldName = "ProjectCode"
        Me.colAllProjectCode.Name = "colAllProjectCode"
        Me.colAllProjectCode.OptionsColumn.AllowEdit = False
        Me.colAllProjectCode.Visible = True
        Me.colAllProjectCode.VisibleIndex = 1
        Me.colAllProjectCode.Width = 90
        '
        'colAllProjectName
        '
        Me.colAllProjectName.Caption = "Project"
        Me.colAllProjectName.FieldName = "ProjectName"
        Me.colAllProjectName.Name = "colAllProjectName"
        Me.colAllProjectName.OptionsColumn.AllowEdit = False
        Me.colAllProjectName.Visible = True
        Me.colAllProjectName.VisibleIndex = 2
        Me.colAllProjectName.Width = 160
        '
        'colAllClientName
        '
        Me.colAllClientName.Caption = "Client"
        Me.colAllClientName.FieldName = "ClientName"
        Me.colAllClientName.Name = "colAllClientName"
        Me.colAllClientName.OptionsColumn.AllowEdit = False
        Me.colAllClientName.Visible = True
        Me.colAllClientName.VisibleIndex = 3
        Me.colAllClientName.Width = 130
        '
        'colAllAmount
        '
        Me.colAllAmount.Caption = "Amount"
        Me.colAllAmount.FieldName = "Amount"
        Me.colAllAmount.Name = "colAllAmount"
        Me.colAllAmount.OptionsColumn.AllowEdit = False
        Me.colAllAmount.Visible = True
        Me.colAllAmount.VisibleIndex = 4
        Me.colAllAmount.Width = 95
        '
        'colAllInvoiceDate
        '
        Me.colAllInvoiceDate.Caption = "Invoice Date"
        Me.colAllInvoiceDate.FieldName = "InvoiceDate"
        Me.colAllInvoiceDate.Name = "colAllInvoiceDate"
        Me.colAllInvoiceDate.OptionsColumn.AllowEdit = False
        Me.colAllInvoiceDate.Visible = True
        Me.colAllInvoiceDate.VisibleIndex = 5
        Me.colAllInvoiceDate.Width = 95
        '
        'colAllDueDate
        '
        Me.colAllDueDate.Caption = "Due Date"
        Me.colAllDueDate.FieldName = "DueDate"
        Me.colAllDueDate.Name = "colAllDueDate"
        Me.colAllDueDate.OptionsColumn.AllowEdit = False
        Me.colAllDueDate.Visible = True
        Me.colAllDueDate.VisibleIndex = 6
        Me.colAllDueDate.Width = 95
        '
        'colAllStatus
        '
        Me.colAllStatus.Caption = "Status"
        Me.colAllStatus.FieldName = "Status"
        Me.colAllStatus.Name = "colAllStatus"
        Me.colAllStatus.OptionsColumn.AllowEdit = False
        Me.colAllStatus.Visible = True
        Me.colAllStatus.VisibleIndex = 7
        Me.colAllStatus.Width = 80
        '
        'gridAll
        '
        Me.gridAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAll.Location = New System.Drawing.Point(3, 51)
        Me.gridAll.MainView = Me.gridViewAll
        Me.gridAll.Name = "gridAll"
        Me.gridAll.Size = New System.Drawing.Size(926, 361)
        Me.gridAll.TabIndex = 1
        Me.gridAll.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewAll})
        '
        'pnlAllBottom
        '
        Me.pnlAllBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlAllBottom.Controls.Add(Me.lblAllCount)
        Me.pnlAllBottom.Controls.Add(Me.btnUpdateStatus)
        Me.pnlAllBottom.Controls.Add(Me.btnEdit)
        Me.pnlAllBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAllBottom.Location = New System.Drawing.Point(3, 412)
        Me.pnlAllBottom.Name = "pnlAllBottom"
        Me.pnlAllBottom.Size = New System.Drawing.Size(926, 49)
        Me.pnlAllBottom.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(10, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 26)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateStatus.Location = New System.Drawing.Point(95, 11)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(110, 26)
        Me.btnUpdateStatus.TabIndex = 1
        Me.btnUpdateStatus.Text = "Update Status"
        '
        'lblAllCount
        '
        Me.lblAllCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAllCount.ForeColor = System.Drawing.Color.Gray
        Me.lblAllCount.Location = New System.Drawing.Point(760, 16)
        Me.lblAllCount.Name = "lblAllCount"
        Me.lblAllCount.Size = New System.Drawing.Size(155, 15)
        Me.lblAllCount.TabIndex = 2
        Me.lblAllCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabOutstanding
        '
        Me.tabOutstanding.Controls.Add(Me.gridOutstanding)
        Me.tabOutstanding.Controls.Add(Me.pnlOutstandingBottom)
        Me.tabOutstanding.Controls.Add(Me.pnlOutstandingHeader)
        Me.tabOutstanding.Location = New System.Drawing.Point(4, 24)
        Me.tabOutstanding.Name = "tabOutstanding"
        Me.tabOutstanding.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutstanding.Size = New System.Drawing.Size(932, 464)
        Me.tabOutstanding.TabIndex = 1
        Me.tabOutstanding.Text = "Outstanding Invoices"
        Me.tabOutstanding.UseVisualStyleBackColor = True
        '
        'pnlOutstandingHeader
        '
        Me.pnlOutstandingHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlOutstandingHeader.Controls.Add(Me.btnOutstandingRefresh)
        Me.pnlOutstandingHeader.Controls.Add(Me.lblOutstandingTotal)
        Me.pnlOutstandingHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOutstandingHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlOutstandingHeader.Name = "pnlOutstandingHeader"
        Me.pnlOutstandingHeader.Size = New System.Drawing.Size(926, 40)
        Me.pnlOutstandingHeader.TabIndex = 0
        '
        'lblOutstandingTotal
        '
        Me.lblOutstandingTotal.AutoSize = True
        Me.lblOutstandingTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblOutstandingTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblOutstandingTotal.Location = New System.Drawing.Point(12, 10)
        Me.lblOutstandingTotal.Name = "lblOutstandingTotal"
        Me.lblOutstandingTotal.Size = New System.Drawing.Size(150, 17)
        Me.lblOutstandingTotal.Text = "Total outstanding: $0"
        '
        'btnOutstandingRefresh
        '
        Me.btnOutstandingRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutstandingRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnOutstandingRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutstandingRefresh.Location = New System.Drawing.Point(820, 7)
        Me.btnOutstandingRefresh.Name = "btnOutstandingRefresh"
        Me.btnOutstandingRefresh.Size = New System.Drawing.Size(95, 26)
        Me.btnOutstandingRefresh.TabIndex = 1
        Me.btnOutstandingRefresh.Text = "Refresh"
        '
        'gridViewOutstanding
        '
        Me.gridViewOutstanding.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOutInvoiceID, Me.colOutInvoiceNo, Me.colOutProjectCode, Me.colOutProjectName, Me.colOutAmount, Me.colOutDueDate, Me.colOutStatus, Me.colOutDaysUntilDue, Me.colOutUrgency})
        Me.gridViewOutstanding.GridControl = Me.gridOutstanding
        Me.gridViewOutstanding.Name = "gridViewOutstanding"
        Me.gridViewOutstanding.OptionsCustomization.AllowColumnMoving = False
        Me.gridViewOutstanding.OptionsCustomization.AllowGroup = False
        Me.gridViewOutstanding.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewOutstanding.OptionsView.ColumnAutoWidth = False
        Me.gridViewOutstanding.OptionsView.ShowGroupPanel = False
        Me.gridViewOutstanding.RowHeight = 28
        '
        'colOutInvoiceID
        '
        Me.colOutInvoiceID.FieldName = "InvoiceID"
        Me.colOutInvoiceID.Name = "colOutInvoiceID"
        Me.colOutInvoiceID.Visible = False
        '
        'colOutInvoiceNo
        '
        Me.colOutInvoiceNo.Caption = "Invoice #"
        Me.colOutInvoiceNo.FieldName = "InvoiceNo"
        Me.colOutInvoiceNo.Name = "colOutInvoiceNo"
        Me.colOutInvoiceNo.OptionsColumn.AllowEdit = False
        Me.colOutInvoiceNo.Visible = True
        Me.colOutInvoiceNo.VisibleIndex = 0
        Me.colOutInvoiceNo.Width = 110
        '
        'colOutProjectCode
        '
        Me.colOutProjectCode.Caption = "Code"
        Me.colOutProjectCode.FieldName = "ProjectCode"
        Me.colOutProjectCode.Name = "colOutProjectCode"
        Me.colOutProjectCode.OptionsColumn.AllowEdit = False
        Me.colOutProjectCode.Visible = True
        Me.colOutProjectCode.VisibleIndex = 1
        Me.colOutProjectCode.Width = 90
        '
        'colOutProjectName
        '
        Me.colOutProjectName.Caption = "Project"
        Me.colOutProjectName.FieldName = "ProjectName"
        Me.colOutProjectName.Name = "colOutProjectName"
        Me.colOutProjectName.OptionsColumn.AllowEdit = False
        Me.colOutProjectName.Visible = True
        Me.colOutProjectName.VisibleIndex = 2
        Me.colOutProjectName.Width = 180
        '
        'colOutAmount
        '
        Me.colOutAmount.Caption = "Amount"
        Me.colOutAmount.FieldName = "Amount"
        Me.colOutAmount.Name = "colOutAmount"
        Me.colOutAmount.OptionsColumn.AllowEdit = False
        Me.colOutAmount.Visible = True
        Me.colOutAmount.VisibleIndex = 3
        Me.colOutAmount.Width = 100
        '
        'colOutDueDate
        '
        Me.colOutDueDate.Caption = "Due Date"
        Me.colOutDueDate.FieldName = "DueDate"
        Me.colOutDueDate.Name = "colOutDueDate"
        Me.colOutDueDate.OptionsColumn.AllowEdit = False
        Me.colOutDueDate.Visible = True
        Me.colOutDueDate.VisibleIndex = 4
        Me.colOutDueDate.Width = 95
        '
        'colOutStatus
        '
        Me.colOutStatus.Caption = "Status"
        Me.colOutStatus.FieldName = "Status"
        Me.colOutStatus.Name = "colOutStatus"
        Me.colOutStatus.OptionsColumn.AllowEdit = False
        Me.colOutStatus.Visible = True
        Me.colOutStatus.VisibleIndex = 5
        Me.colOutStatus.Width = 80
        '
        'colOutDaysUntilDue
        '
        Me.colOutDaysUntilDue.Caption = "Days"
        Me.colOutDaysUntilDue.FieldName = "DaysUntilDue"
        Me.colOutDaysUntilDue.Name = "colOutDaysUntilDue"
        Me.colOutDaysUntilDue.OptionsColumn.AllowEdit = False
        Me.colOutDaysUntilDue.Visible = True
        Me.colOutDaysUntilDue.VisibleIndex = 6
        Me.colOutDaysUntilDue.Width = 55
        '
        'colOutUrgency
        '
        Me.colOutUrgency.Caption = "Urgency"
        Me.colOutUrgency.FieldName = "Urgency"
        Me.colOutUrgency.Name = "colOutUrgency"
        Me.colOutUrgency.OptionsColumn.AllowEdit = False
        Me.colOutUrgency.Visible = True
        Me.colOutUrgency.VisibleIndex = 7
        Me.colOutUrgency.Width = 100
        '
        'gridOutstanding
        '
        Me.gridOutstanding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOutstanding.Location = New System.Drawing.Point(3, 43)
        Me.gridOutstanding.MainView = Me.gridViewOutstanding
        Me.gridOutstanding.Name = "gridOutstanding"
        Me.gridOutstanding.Size = New System.Drawing.Size(926, 369)
        Me.gridOutstanding.TabIndex = 1
        Me.gridOutstanding.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewOutstanding})
        '
        'pnlOutstandingBottom
        '
        Me.pnlOutstandingBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlOutstandingBottom.Controls.Add(Me.lblOutstandingCount)
        Me.pnlOutstandingBottom.Controls.Add(Me.btnOutstandingUpdateStatus)
        Me.pnlOutstandingBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlOutstandingBottom.Location = New System.Drawing.Point(3, 412)
        Me.pnlOutstandingBottom.Name = "pnlOutstandingBottom"
        Me.pnlOutstandingBottom.Size = New System.Drawing.Size(926, 49)
        Me.pnlOutstandingBottom.TabIndex = 2
        '
        'btnOutstandingUpdateStatus
        '
        Me.btnOutstandingUpdateStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOutstandingUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutstandingUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOutstandingUpdateStatus.Location = New System.Drawing.Point(10, 11)
        Me.btnOutstandingUpdateStatus.Name = "btnOutstandingUpdateStatus"
        Me.btnOutstandingUpdateStatus.Size = New System.Drawing.Size(130, 26)
        Me.btnOutstandingUpdateStatus.TabIndex = 0
        Me.btnOutstandingUpdateStatus.Text = "Update Status"
        '
        'lblOutstandingCount
        '
        Me.lblOutstandingCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutstandingCount.ForeColor = System.Drawing.Color.Gray
        Me.lblOutstandingCount.Location = New System.Drawing.Point(700, 16)
        Me.lblOutstandingCount.Name = "lblOutstandingCount"
        Me.lblOutstandingCount.Size = New System.Drawing.Size(215, 15)
        Me.lblOutstandingCount.TabIndex = 1
        Me.lblOutstandingCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlStatus
        '
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 492)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(940, 28)
        Me.pnlStatus.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 0
        '
        'InvoiceListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(940, 520)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlStatus)
        Me.Name = "InvoiceListForm"
        Me.Text = "Invoice & Billing"
        Me.tabMain.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAllFilter.ResumeLayout(False)
        Me.pnlAllFilter.PerformLayout()
        Me.pnlAllBottom.ResumeLayout(False)
        Me.tabOutstanding.ResumeLayout(False)
        CType(Me.gridOutstanding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewOutstanding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOutstandingHeader.ResumeLayout(False)
        Me.pnlOutstandingHeader.PerformLayout()
        Me.pnlOutstandingBottom.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabAll As System.Windows.Forms.TabPage
    Friend WithEvents tabOutstanding As System.Windows.Forms.TabPage
    Friend WithEvents pnlAllFilter As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusFilter As System.Windows.Forms.Label
    Friend WithEvents cboStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gridAll As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewAll As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAllInvoiceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllProjectCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllClientName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlAllBottom As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdateStatus As System.Windows.Forms.Button
    Friend WithEvents lblAllCount As System.Windows.Forms.Label
    Friend WithEvents pnlOutstandingHeader As System.Windows.Forms.Panel
    Friend WithEvents lblOutstandingTotal As System.Windows.Forms.Label
    Friend WithEvents btnOutstandingRefresh As System.Windows.Forms.Button
    Friend WithEvents gridOutstanding As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewOutstanding As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOutInvoiceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutProjectCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutDaysUntilDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutUrgency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlOutstandingBottom As System.Windows.Forms.Panel
    Friend WithEvents btnOutstandingUpdateStatus As System.Windows.Forms.Button
    Friend WithEvents lblOutstandingCount As System.Windows.Forms.Label
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
