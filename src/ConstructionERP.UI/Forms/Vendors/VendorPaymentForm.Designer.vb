<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorPaymentForm
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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.cboVendor = New System.Windows.Forms.ComboBox()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.numAmountDue = New System.Windows.Forms.NumericUpDown()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.numAmountPaid = New System.Windows.Forms.NumericUpDown()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblStatusPreview = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.numAmountDue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmountPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblFormTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(480, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(15, 11)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(130, 21)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Record Payment"
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVendor.Location = New System.Drawing.Point(20, 65)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(52, 15)
        Me.lblVendor.TabIndex = 1
        Me.lblVendor.Text = "Vendor *"
        '
        'cboVendor
        '
        Me.cboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboVendor.Location = New System.Drawing.Point(130, 62)
        Me.cboVendor.Name = "cboVendor"
        Me.cboVendor.Size = New System.Drawing.Size(320, 23)
        Me.cboVendor.TabIndex = 0
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProject.Location = New System.Drawing.Point(20, 100)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(44, 15)
        Me.lblProject.TabIndex = 2
        Me.lblProject.Text = "Project"
        '
        'cboProject
        '
        Me.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboProject.Location = New System.Drawing.Point(130, 97)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(320, 23)
        Me.cboProject.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDescription.Location = New System.Drawing.Point(20, 135)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(70, 15)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Location = New System.Drawing.Point(130, 132)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(320, 23)
        Me.txtDescription.TabIndex = 2
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAmountDue.Location = New System.Drawing.Point(20, 170)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(78, 15)
        Me.lblAmountDue.TabIndex = 4
        Me.lblAmountDue.Text = "Amount Due *"
        '
        'numAmountDue
        '
        Me.numAmountDue.DecimalPlaces = 2
        Me.numAmountDue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numAmountDue.Location = New System.Drawing.Point(130, 167)
        Me.numAmountDue.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numAmountDue.Name = "numAmountDue"
        Me.numAmountDue.Size = New System.Drawing.Size(140, 23)
        Me.numAmountDue.TabIndex = 3
        Me.numAmountDue.ThousandsSeparator = True
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAmountPaid.Location = New System.Drawing.Point(20, 205)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(76, 15)
        Me.lblAmountPaid.TabIndex = 5
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'numAmountPaid
        '
        Me.numAmountPaid.DecimalPlaces = 2
        Me.numAmountPaid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numAmountPaid.Location = New System.Drawing.Point(130, 202)
        Me.numAmountPaid.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numAmountPaid.Name = "numAmountPaid"
        Me.numAmountPaid.Size = New System.Drawing.Size(140, 23)
        Me.numAmountPaid.TabIndex = 4
        Me.numAmountPaid.ThousandsSeparator = True
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDueDate.Location = New System.Drawing.Point(20, 240)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(56, 15)
        Me.lblDueDate.TabIndex = 6
        Me.lblDueDate.Text = "Due Date"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(130, 237)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.ShowCheckBox = True
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpDueDate.TabIndex = 5
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNotes.Location = New System.Drawing.Point(20, 275)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(38, 15)
        Me.lblNotes.TabIndex = 7
        Me.lblNotes.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNotes.Location = New System.Drawing.Point(130, 272)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(320, 50)
        Me.txtNotes.TabIndex = 6
        '
        'lblStatusPreview
        '
        Me.lblStatusPreview.AutoSize = True
        Me.lblStatusPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblStatusPreview.Location = New System.Drawing.Point(290, 170)
        Me.lblStatusPreview.Name = "lblStatusPreview"
        Me.lblStatusPreview.Size = New System.Drawing.Size(95, 15)
        Me.lblStatusPreview.TabIndex = 8
        Me.lblStatusPreview.Text = "Status: Pending"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(20, 330)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 9
        Me.lblError.Visible = False
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 355)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(480, 52)
        Me.pnlButtons.TabIndex = 10
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.Location = New System.Drawing.Point(370, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(270, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'VendorPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 407)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblStatusPreview)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.numAmountPaid)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.numAmountDue)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.cboProject)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.cboVendor)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendorPaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendor Payment"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.numAmountDue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmountPaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblVendor As System.Windows.Forms.Label
    Friend WithEvents cboVendor As System.Windows.Forms.ComboBox
    Friend WithEvents lblProject As System.Windows.Forms.Label
    Friend WithEvents cboProject As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents numAmountDue As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents numAmountPaid As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusPreview As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
