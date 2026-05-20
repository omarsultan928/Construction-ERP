<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserListForm
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
        Me.lblRoleFilter = New System.Windows.Forms.Label()
        Me.cboRoleFilter = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRole = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.pnlFilter.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' -------------------------------------------------------
        ' pnlFilter
        ' -------------------------------------------------------
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.Controls.Add(Me.btnAddUser)
        Me.pnlFilter.Controls.Add(Me.btnClear)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Controls.Add(Me.cboRoleFilter)
        Me.pnlFilter.Controls.Add(Me.lblRoleFilter)
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Controls.Add(Me.lblSearch)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Height = 48
        Me.pnlFilter.Name = "pnlFilter"

        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.Location = New System.Drawing.Point(12, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Text = "Search:"

        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(65, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(175, 23)

        Me.lblRoleFilter.AutoSize = True
        Me.lblRoleFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRoleFilter.Location = New System.Drawing.Point(254, 15)
        Me.lblRoleFilter.Name = "lblRoleFilter"
        Me.lblRoleFilter.Text = "Role:"

        Me.cboRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoleFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboRoleFilter.Location = New System.Drawing.Point(292, 11)
        Me.cboRoleFilter.Name = "cboRoleFilter"
        Me.cboRoleFilter.Size = New System.Drawing.Size(155, 23)

        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(460, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.Text = "Search"

        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.Location = New System.Drawing.Point(543, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 26)
        Me.btnClear.Text = "Clear"

        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(39, 119, 63)
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(660, 10)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(100, 26)
        Me.btnAddUser.Text = "+ Add User"

        ' -------------------------------------------------------
        ' gridView1 — the view that controls how data is displayed
        ' -------------------------------------------------------
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {
            Me.colUserID, Me.colFullName, Me.colEmail, Me.colRole, Me.colStatus, Me.colCreated})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"

        ' Display options
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.OptionsView.ColumnAutoWidth = False
        Me.gridView1.OptionsView.ShowAutoFilterRow = True
        Me.gridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView1.OptionsView.EnableAppearanceOddRow = True
        Me.gridView1.OptionsView.RowAutoHeight = False

        ' Selection — highlight full row, not just active cell
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsSelection.MultiSelect = False

        ' Customization
        Me.gridView1.OptionsCustomization.AllowFilter = True
        Me.gridView1.OptionsCustomization.AllowSort = True
        Me.gridView1.OptionsCustomization.AllowGroup = False
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False

        ' Appearance — alternating row shading
        Me.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.gridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.gridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gridView1.Appearance.Row.Options.UseFont = True
        Me.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(210, 225, 245)
        Me.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridView1.Appearance.FocusedRow.Options.UseForeColor = True

        ' Row height
        Me.gridView1.RowHeight = 28

        ' -------------------------------------------------------
        ' Column definitions
        ' -------------------------------------------------------
        Me.colUserID.FieldName = "UserID"
        Me.colUserID.Name = "colUserID"
        Me.colUserID.Visible = False
        Me.colUserID.VisibleIndex = -1

        Me.colFullName.Caption = "Full Name"
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.VisibleIndex = 0
        Me.colFullName.Width = 185
        Me.colFullName.OptionsColumn.AllowEdit = False

        Me.colEmail.Caption = "Email"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.VisibleIndex = 1
        Me.colEmail.Width = 225
        Me.colEmail.OptionsColumn.AllowEdit = False

        Me.colRole.Caption = "Role"
        Me.colRole.FieldName = "Role"
        Me.colRole.Name = "colRole"
        Me.colRole.VisibleIndex = 2
        Me.colRole.Width = 145
        Me.colRole.OptionsColumn.AllowEdit = False

        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 85
        Me.colStatus.OptionsColumn.AllowEdit = False

        Me.colCreated.Caption = "Created"
        Me.colCreated.FieldName = "CreatedDate"
        Me.colCreated.Name = "colCreated"
        Me.colCreated.VisibleIndex = 4
        Me.colCreated.Width = 105
        Me.colCreated.OptionsColumn.AllowEdit = False

        ' -------------------------------------------------------
        ' gridControl1 — the container control placed on the form
        ' -------------------------------------------------------
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})

        ' -------------------------------------------------------
        ' pnlBottom
        ' -------------------------------------------------------
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 252)
        Me.pnlBottom.Controls.Add(Me.lblRecordCount)
        Me.pnlBottom.Controls.Add(Me.lblStatus)
        Me.pnlBottom.Controls.Add(Me.btnDisable)
        Me.pnlBottom.Controls.Add(Me.btnEdit)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Height = 48
        Me.pnlBottom.Name = "pnlBottom"

        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192)
        Me.btnEdit.Location = New System.Drawing.Point(10, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 26)
        Me.btnEdit.Text = "Edit"

        Me.btnDisable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisable.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDisable.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.btnDisable.Location = New System.Drawing.Point(105, 11)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(85, 26)
        Me.btnDisable.Text = "Disable"

        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(205, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Text = ""

        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.Gray
        Me.lblRecordCount.Location = New System.Drawing.Point(650, 16)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Text = ""

        ' -------------------------------------------------------
        ' UserListForm
        ' -------------------------------------------------------
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 520)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlFilter)
        Me.Name = "UserListForm"
        Me.Text = "User Management"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblRoleFilter As System.Windows.Forms.Label
    Friend WithEvents cboRoleFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRole As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
End Class
