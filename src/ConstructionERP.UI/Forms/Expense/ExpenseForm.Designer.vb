<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpenseForm
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
        Me.grpExpense = New DevExpress.XtraEditors.GroupControl()
        Me.lblProject = New DevExpress.XtraEditors.LabelControl()
        Me.lkpProject = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblExpenseDate = New DevExpress.XtraEditors.LabelControl()
        Me.dtpExpenseDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblCategory = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblAmount = New DevExpress.XtraEditors.LabelControl()
        Me.spinAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.lblVendor = New DevExpress.XtraEditors.LabelControl()
        Me.lkpVendor = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
        Me.memoDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grpExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExpense.SuspendLayout()
        CType(Me.lkpProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpExpenseDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpExpenseDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' grpExpense
        Me.grpExpense.Controls.Add(Me.memoDescription)
        Me.grpExpense.Controls.Add(Me.lblDescription)
        Me.grpExpense.Controls.Add(Me.lkpVendor)
        Me.grpExpense.Controls.Add(Me.lblVendor)
        Me.grpExpense.Controls.Add(Me.spinAmount)
        Me.grpExpense.Controls.Add(Me.lblAmount)
        Me.grpExpense.Controls.Add(Me.cmbCategory)
        Me.grpExpense.Controls.Add(Me.lblCategory)
        Me.grpExpense.Controls.Add(Me.dtpExpenseDate)
        Me.grpExpense.Controls.Add(Me.lblExpenseDate)
        Me.grpExpense.Controls.Add(Me.lkpProject)
        Me.grpExpense.Controls.Add(Me.lblProject)
        Me.grpExpense.Location = New System.Drawing.Point(12, 12)
        Me.grpExpense.Name = "grpExpense"
        Me.grpExpense.Size = New System.Drawing.Size(526, 330)
        Me.grpExpense.TabIndex = 0
        Me.grpExpense.Text = "Expense Details"

        ' lblProject
        Me.lblProject.Location = New System.Drawing.Point(16, 38)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(47, 13)
        Me.lblProject.TabIndex = 0
        Me.lblProject.Text = "Project: *"

        ' lkpProject
        Me.lkpProject.Location = New System.Drawing.Point(120, 35)
        Me.lkpProject.Name = "lkpProject"
        Me.lkpProject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpProject.Properties.NullText = "-- Select Project --"
        Me.lkpProject.Size = New System.Drawing.Size(390, 20)
        Me.lkpProject.TabIndex = 1

        ' lblExpenseDate
        Me.lblExpenseDate.Location = New System.Drawing.Point(16, 76)
        Me.lblExpenseDate.Name = "lblExpenseDate"
        Me.lblExpenseDate.Size = New System.Drawing.Size(59, 13)
        Me.lblExpenseDate.TabIndex = 2
        Me.lblExpenseDate.Text = "Exp. Date: *"

        ' dtpExpenseDate
        Me.dtpExpenseDate.Location = New System.Drawing.Point(120, 73)
        Me.dtpExpenseDate.Name = "dtpExpenseDate"
        Me.dtpExpenseDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpExpenseDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpExpenseDate.Size = New System.Drawing.Size(180, 20)
        Me.dtpExpenseDate.TabIndex = 3

        ' lblCategory
        Me.lblCategory.Location = New System.Drawing.Point(16, 114)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(56, 13)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Category: *"

        ' cmbCategory
        Me.cmbCategory.Location = New System.Drawing.Point(120, 111)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategory.Properties.Items.AddRange(New Object() {"Labor", "Material", "Equipment", "Subcontractor", "Miscellaneous"})
        Me.cmbCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbCategory.Size = New System.Drawing.Size(180, 20)
        Me.cmbCategory.TabIndex = 5

        ' lblAmount
        Me.lblAmount.Location = New System.Drawing.Point(16, 152)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(52, 13)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Amount: *"

        ' spinAmount
        Me.spinAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinAmount.Location = New System.Drawing.Point(120, 149)
        Me.spinAmount.Name = "spinAmount"
        Me.spinAmount.Properties.DisplayFormat.FormatString = "C2"
        Me.spinAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinAmount.Properties.EditFormat.FormatString = "C2"
        Me.spinAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spinAmount.Properties.Mask.EditMask = "n2"
        Me.spinAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.spinAmount.Properties.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spinAmount.Size = New System.Drawing.Size(180, 20)
        Me.spinAmount.TabIndex = 7

        ' lblVendor
        Me.lblVendor.Location = New System.Drawing.Point(16, 190)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(40, 13)
        Me.lblVendor.TabIndex = 8
        Me.lblVendor.Text = "Vendor:"

        ' lkpVendor
        Me.lkpVendor.Location = New System.Drawing.Point(120, 187)
        Me.lkpVendor.Name = "lkpVendor"
        Me.lkpVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpVendor.Properties.NullText = "-- None --"
        Me.lkpVendor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Me.lkpVendor.Size = New System.Drawing.Size(390, 20)
        Me.lkpVendor.TabIndex = 9

        ' lblDescription
        Me.lblDescription.Location = New System.Drawing.Point(16, 228)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(61, 13)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "Description:"

        ' memoDescription
        Me.memoDescription.Location = New System.Drawing.Point(120, 225)
        Me.memoDescription.Name = "memoDescription"
        Me.memoDescription.Size = New System.Drawing.Size(390, 80)
        Me.memoDescription.TabIndex = 11

        ' btnSave
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(248, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 35)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save Expense"

        ' btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(394, 355)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"

        ' ExpenseForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 405)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpExpense)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExpenseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Expense"

        CType(Me.grpExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExpense.ResumeLayout(False)
        Me.grpExpense.PerformLayout()
        CType(Me.lkpProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpExpenseDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpExpenseDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents grpExpense As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblProject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpProject As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblExpenseDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpExpenseDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblCategory As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblAmount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spinAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblVendor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpVendor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memoDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
