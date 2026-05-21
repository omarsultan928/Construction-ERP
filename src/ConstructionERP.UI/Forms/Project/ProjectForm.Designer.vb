<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectForm
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
        Me.lblProjectCode = New DevExpress.XtraEditors.LabelControl()
        Me.txtProjectCode = New DevExpress.XtraEditors.TextEdit()
        Me.lblProjectName = New DevExpress.XtraEditors.LabelControl()
        Me.txtProjectName = New DevExpress.XtraEditors.TextEdit()
        Me.lblClientName = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientName = New DevExpress.XtraEditors.TextEdit()
        Me.lblBudget = New DevExpress.XtraEditors.LabelControl()
        Me.spinBudget = New DevExpress.XtraEditors.SpinEdit()
        Me.lblStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.dtpStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblEndDate = New DevExpress.XtraEditors.LabelControl()
        Me.dtpEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.cmbStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.grpProjectDetails = New DevExpress.XtraEditors.GroupControl()
        CType(Me.txtProjectCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinBudget.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProjectDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProjectDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(20, 38)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(72, 13)
        Me.lblProjectCode.TabIndex = 0
        Me.lblProjectCode.Text = "Project Code:"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(120, 35)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(200, 20)
        Me.txtProjectCode.TabIndex = 1
        '
        'lblProjectName
        '
        Me.lblProjectName.Location = New System.Drawing.Point(20, 74)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(74, 13)
        Me.lblProjectName.TabIndex = 2
        Me.lblProjectName.Text = "Project Name:"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(120, 71)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(350, 20)
        Me.txtProjectName.TabIndex = 3
        '
        'lblClientName
        '
        Me.lblClientName.Location = New System.Drawing.Point(20, 110)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(62, 13)
        Me.lblClientName.TabIndex = 4
        Me.lblClientName.Text = "Client Name:"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(120, 107)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(350, 20)
        Me.txtClientName.TabIndex = 5
        '
        'lblBudget
        '
        Me.lblBudget.Location = New System.Drawing.Point(20, 146)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(38, 13)
        Me.lblBudget.TabIndex = 6
        Me.lblBudget.Text = "Budget:"
        '
        'spinBudget
        '
        Me.spinBudget.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinBudget.Location = New System.Drawing.Point(120, 143)
        Me.spinBudget.Name = "spinBudget"
        Me.spinBudget.Properties.DisplayFormat.FormatString = "C2"
        Me.spinBudget.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinBudget.Properties.EditFormat.FormatString = "C2"
        Me.spinBudget.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinBudget.Properties.Mask.EditMask = "n2"
        Me.spinBudget.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.spinBudget.Size = New System.Drawing.Size(150, 20)
        Me.spinBudget.TabIndex = 7
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(20, 182)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(54, 13)
        Me.lblStartDate.TabIndex = 8
        Me.lblStartDate.Text = "Start Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.EditValue = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Location = New System.Drawing.Point(120, 179)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpStartDate.Size = New System.Drawing.Size(150, 20)
        Me.dtpStartDate.TabIndex = 9
        '
        'lblEndDate
        '
        Me.lblEndDate.Location = New System.Drawing.Point(20, 218)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(48, 13)
        Me.lblEndDate.TabIndex = 10
        Me.lblEndDate.Text = "End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.EditValue = Nothing
        Me.dtpEndDate.Location = New System.Drawing.Point(120, 215)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Me.dtpEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpEndDate.Size = New System.Drawing.Size(150, 20)
        Me.dtpEndDate.TabIndex = 11
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(20, 254)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(35, 13)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(120, 251)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.Items.AddRange(New Object() {"Active", "On Hold", "Completed", "Cancelled"})
        Me.cmbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbStatus.Size = New System.Drawing.Size(150, 20)
        Me.cmbStatus.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(120, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(240, 320)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        '
        'grpProjectDetails
        '
        Me.grpProjectDetails.Controls.Add(Me.cmbStatus)
        Me.grpProjectDetails.Controls.Add(Me.lblStatus)
        Me.grpProjectDetails.Controls.Add(Me.dtpEndDate)
        Me.grpProjectDetails.Controls.Add(Me.lblEndDate)
        Me.grpProjectDetails.Controls.Add(Me.dtpStartDate)
        Me.grpProjectDetails.Controls.Add(Me.lblStartDate)
        Me.grpProjectDetails.Controls.Add(Me.spinBudget)
        Me.grpProjectDetails.Controls.Add(Me.lblBudget)
        Me.grpProjectDetails.Controls.Add(Me.txtClientName)
        Me.grpProjectDetails.Controls.Add(Me.lblClientName)
        Me.grpProjectDetails.Controls.Add(Me.txtProjectName)
        Me.grpProjectDetails.Controls.Add(Me.lblProjectName)
        Me.grpProjectDetails.Controls.Add(Me.txtProjectCode)
        Me.grpProjectDetails.Controls.Add(Me.lblProjectCode)
        Me.grpProjectDetails.Location = New System.Drawing.Point(20, 20)
        Me.grpProjectDetails.Name = "grpProjectDetails"
        Me.grpProjectDetails.Size = New System.Drawing.Size(500, 290)
        Me.grpProjectDetails.TabIndex = 16
        Me.grpProjectDetails.Text = "Project Details"
        '
        'ProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 400)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpProjectDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New Project"
        CType(Me.txtProjectCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinBudget.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProjectDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProjectDetails.ResumeLayout(False)
        Me.grpProjectDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblProjectCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProjectCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProjectName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProjectName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblClientName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClientName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBudget As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinBudget As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpProjectDetails As DevExpress.XtraEditors.GroupControl
End Class
