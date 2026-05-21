<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorListForm
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
        Me.lblTypeFilter = New System.Windows.Forms.Label()
        Me.cboTypeFilter = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddVendor = New System.Windows.Forms.Button()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVendorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnEditVendor = New System.Windows.Forms.Button()
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
        Me.pnlFilter.Controls.Add(Me.btnAddVendor)
        Me.pnlFilter.Controls.Add(Me.btnClear)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Controls.Add(Me.cboTypeFilter)
        Me.pnlFilter.Controls.Add(Me.lblTypeFilter)
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
        'lblTypeFilter
        '
        Me.lblTypeFilter.AutoSize = True
        Me.lblTypeFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTypeFilter.Location = New System.Drawing.Point(238, 15)
        Me.lblTypeFilter.Name = "lblTypeFilter"
        Me.lblTypeFilter.Size = New System.Drawing.Size(35, 15)
        Me.lblTypeFilter.TabIndex = 2
        Me.lblTypeFilter.Text = "Type:"
        '
        'cboTypeFilter
        '
        Me.cboTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTypeFilter.Location = New System.Drawing.Point(279, 11)
        Me.cboTypeFilter.Name = "cboTypeFilter"
        Me.cboTypeFilter.Size = New System.Drawing.Size(155, 23)
        Me.cboTypeFilter.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(448, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.Location = New System.Drawing.Point(531, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 26)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'btnAddVendor
        '
        Me.btnAddVendor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAddVendor.FlatAppearance.BorderSize = 0
        Me.btnAddVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddVendor.ForeColor = System.Drawing.Color.White
        Me.btnAddVendor.Location = New System.Drawing.Point(770, 10)
        Me.btnAddVendor.Name = "btnAddVendor"
        Me.btnAddVendor.Size = New System.Drawing.Size(115, 26)
        Me.btnAddVendor.TabIndex = 6
        Me.btnAddVendor.Text = "+ Add Vendor"
        Me.btnAddVendor.UseVisualStyleBackColor = False
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVendorID, Me.colVendorName, Me.colContactPerson, Me.colPhone, Me.colEmail, Me.colVendorType})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowGroup = False
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.RowHeight = 28
        '
        'colVendorID
        '
        Me.colVendorID.FieldName = "VendorID"
        Me.colVendorID.Name = "colVendorID"
        Me.colVendorID.OptionsColumn.AllowEdit = False
        Me.colVendorID.Visible = False
        '
        'colVendorName
        '
        Me.colVendorName.Caption = "Vendor Name"
        Me.colVendorName.FieldName = "VendorName"
        Me.colVendorName.Name = "colVendorName"
        Me.colVendorName.OptionsColumn.AllowEdit = False
        Me.colVendorName.Visible = True
        Me.colVendorName.VisibleIndex = 0
        Me.colVendorName.Width = 200
        '
        'colContactPerson
        '
        Me.colContactPerson.Caption = "Contact"
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        Me.colContactPerson.OptionsColumn.AllowEdit = False
        Me.colContactPerson.Visible = True
        Me.colContactPerson.VisibleIndex = 1
        Me.colContactPerson.Width = 140
        '
        'colPhone
        '
        Me.colPhone.Caption = "Phone"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.AllowEdit = False
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 2
        Me.colPhone.Width = 110
        '
        'colEmail
        '
        Me.colEmail.Caption = "Email"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.AllowEdit = False
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 3
        Me.colEmail.Width = 180
        '
        'colVendorType
        '
        Me.colVendorType.Caption = "Type"
        Me.colVendorType.FieldName = "VendorType"
        Me.colVendorType.Name = "colVendorType"
        Me.colVendorType.OptionsColumn.AllowEdit = False
        Me.colVendorType.Visible = True
        Me.colVendorType.VisibleIndex = 4
        Me.colVendorType.Width = 130
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
        Me.pnlBottom.Controls.Add(Me.btnEditVendor)
        Me.pnlBottom.Controls.Add(Me.btnAssign)
        Me.pnlBottom.Controls.Add(Me.btnPayments)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 472)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(900, 48)
        Me.pnlBottom.TabIndex = 2
        '
        'btnPayments
        '
        Me.btnPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPayments.Location = New System.Drawing.Point(220, 11)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(120, 26)
        Me.btnPayments.TabIndex = 2
        Me.btnPayments.Text = "Track Payments"
        '
        'btnAssign
        '
        Me.btnAssign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAssign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAssign.Location = New System.Drawing.Point(105, 11)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(105, 26)
        Me.btnAssign.TabIndex = 1
        Me.btnAssign.Text = "Assign to Project"
        '
        'btnEditVendor
        '
        Me.btnEditVendor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditVendor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditVendor.Location = New System.Drawing.Point(10, 11)
        Me.btnEditVendor.Name = "btnEditVendor"
        Me.btnEditVendor.Size = New System.Drawing.Size(85, 26)
        Me.btnEditVendor.TabIndex = 0
        Me.btnEditVendor.Text = "Edit"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(360, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 3
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.Gray
        Me.lblRecordCount.Location = New System.Drawing.Point(760, 16)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(130, 15)
        Me.lblRecordCount.TabIndex = 4
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'VendorListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 520)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "VendorListForm"
        Me.Text = "Vendor Management"
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
    Friend WithEvents lblTypeFilter As System.Windows.Forms.Label
    Friend WithEvents cboTypeFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddVendor As System.Windows.Forms.Button
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVendorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnEditVendor As System.Windows.Forms.Button
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
End Class
