<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorAssignForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.cboVendor = New System.Windows.Forms.ComboBox()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVPID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssignedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(760, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Assign Vendor to Project"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProject.Location = New System.Drawing.Point(20, 65)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(50, 15)
        Me.lblProject.TabIndex = 1
        Me.lblProject.Text = "Project *"
        '
        'cboProject
        '
        Me.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboProject.Location = New System.Drawing.Point(90, 62)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(300, 23)
        Me.cboProject.TabIndex = 0
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVendor.Location = New System.Drawing.Point(410, 65)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(52, 15)
        Me.lblVendor.TabIndex = 2
        Me.lblVendor.Text = "Vendor *"
        '
        'cboVendor
        '
        Me.cboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboVendor.Location = New System.Drawing.Point(475, 62)
        Me.cboVendor.Name = "cboVendor"
        Me.cboVendor.Size = New System.Drawing.Size(260, 23)
        Me.cboVendor.TabIndex = 1
        '
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAssign.FlatAppearance.BorderSize = 0
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAssign.ForeColor = System.Drawing.Color.White
        Me.btnAssign.Location = New System.Drawing.Point(20, 98)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(120, 28)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "Assign Vendor"
        Me.btnAssign.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(155, 104)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 3
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVPID, Me.colProjectCode, Me.colProjectName, Me.colVendorName, Me.colVendorType, Me.colAssignedDate})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowGroup = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'colVPID
        '
        Me.colVPID.FieldName = "VPID"
        Me.colVPID.Name = "colVPID"
        Me.colVPID.Visible = False
        '
        'colProjectCode
        '
        Me.colProjectCode.Caption = "Project Code"
        Me.colProjectCode.FieldName = "ProjectCode"
        Me.colProjectCode.Name = "colProjectCode"
        Me.colProjectCode.OptionsColumn.AllowEdit = False
        Me.colProjectCode.Visible = True
        Me.colProjectCode.VisibleIndex = 0
        Me.colProjectCode.Width = 110
        '
        'colProjectName
        '
        Me.colProjectName.Caption = "Project"
        Me.colProjectName.FieldName = "ProjectName"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.OptionsColumn.AllowEdit = False
        Me.colProjectName.Visible = True
        Me.colProjectName.VisibleIndex = 1
        Me.colProjectName.Width = 200
        '
        'colVendorName
        '
        Me.colVendorName.Caption = "Vendor"
        Me.colVendorName.FieldName = "VendorName"
        Me.colVendorName.Name = "colVendorName"
        Me.colVendorName.OptionsColumn.AllowEdit = False
        Me.colVendorName.Visible = True
        Me.colVendorName.VisibleIndex = 2
        Me.colVendorName.Width = 200
        '
        'colVendorType
        '
        Me.colVendorType.Caption = "Type"
        Me.colVendorType.FieldName = "VendorType"
        Me.colVendorType.Name = "colVendorType"
        Me.colVendorType.OptionsColumn.AllowEdit = False
        Me.colVendorType.Visible = True
        Me.colVendorType.VisibleIndex = 3
        Me.colVendorType.Width = 120
        '
        'colAssignedDate
        '
        Me.colAssignedDate.Caption = "Assigned"
        Me.colAssignedDate.FieldName = "AssignedDate"
        Me.colAssignedDate.Name = "colAssignedDate"
        Me.colAssignedDate.OptionsColumn.AllowEdit = False
        Me.colAssignedDate.Visible = True
        Me.colAssignedDate.VisibleIndex = 4
        Me.colAssignedDate.Width = 90
        '
        'gridControl1
        '
        Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl1.Location = New System.Drawing.Point(20, 140)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(720, 280)
        Me.gridControl1.TabIndex = 4
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.lblRecordCount)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 430)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(760, 48)
        Me.pnlBottom.TabIndex = 5
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.Gray
        Me.lblRecordCount.Location = New System.Drawing.Point(20, 16)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(0, 15)
        Me.lblRecordCount.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(650, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        '
        'VendorAssignForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 478)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.cboVendor)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.cboProject)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendorAssignForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assign Vendor to Project"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblProject As System.Windows.Forms.Label
    Friend WithEvents cboProject As System.Windows.Forms.ComboBox
    Friend WithEvents lblVendor As System.Windows.Forms.Label
    Friend WithEvents cboVendor As System.Windows.Forms.ComboBox
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVPID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssignedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
