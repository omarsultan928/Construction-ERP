<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceForm
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
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        Me.lblInvoiceDate = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHeader.Size = New System.Drawing.Size(500, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(15, 11)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(110, 21)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Create Invoice"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInvoiceNo.Location = New System.Drawing.Point(20, 65)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(95, 15)
        Me.lblInvoiceNo.TabIndex = 1
        Me.lblInvoiceNo.Text = "Invoice Number *"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtInvoiceNo.Location = New System.Drawing.Point(150, 62)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(320, 23)
        Me.txtInvoiceNo.TabIndex = 0
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProject.Location = New System.Drawing.Point(20, 100)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(52, 15)
        Me.lblProject.TabIndex = 2
        Me.lblProject.Text = "Project *"
        '
        'cboProject
        '
        Me.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboProject.Location = New System.Drawing.Point(150, 97)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(320, 23)
        Me.cboProject.TabIndex = 1
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAmount.Location = New System.Drawing.Point(20, 135)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(57, 15)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount *"
        '
        'numAmount
        '
        Me.numAmount.DecimalPlaces = 2
        Me.numAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numAmount.Location = New System.Drawing.Point(150, 132)
        Me.numAmount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(150, 23)
        Me.numAmount.TabIndex = 2
        Me.numAmount.ThousandsSeparator = True
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.AutoSize = True
        Me.lblInvoiceDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInvoiceDate.Location = New System.Drawing.Point(20, 170)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(79, 15)
        Me.lblInvoiceDate.TabIndex = 4
        Me.lblInvoiceDate.Text = "Invoice Date *"
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(150, 167)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(150, 23)
        Me.dtpInvoiceDate.TabIndex = 3
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDueDate.Location = New System.Drawing.Point(20, 205)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(61, 15)
        Me.lblDueDate.TabIndex = 5
        Me.lblDueDate.Text = "Due Date *"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(150, 202)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(150, 23)
        Me.dtpDueDate.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(20, 240)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(46, 15)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status *"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.Location = New System.Drawing.Point(150, 237)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(150, 23)
        Me.cboStatus.TabIndex = 5
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
        Me.txtNotes.Location = New System.Drawing.Point(150, 272)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(320, 55)
        Me.txtNotes.TabIndex = 6
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(20, 335)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 8
        Me.lblError.Visible = False
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 360)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(500, 52)
        Me.pnlButtons.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.Location = New System.Drawing.Point(390, 12)
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
        Me.btnSave.Location = New System.Drawing.Point(290, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 412)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.dtpInvoiceDate)
        Me.Controls.Add(Me.lblInvoiceDate)
        Me.Controls.Add(Me.numAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.cboProject)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InvoiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Invoice"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblProject As System.Windows.Forms.Label
    Friend WithEvents cboProject As System.Windows.Forms.ComboBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents numAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblInvoiceDate As System.Windows.Forms.Label
    Friend WithEvents dtpInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
