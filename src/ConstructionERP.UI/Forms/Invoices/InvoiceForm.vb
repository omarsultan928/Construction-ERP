Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class InvoiceForm

    Private ReadOnly _isEditMode As Boolean
    Private ReadOnly _originalInvoice As Invoice
    Private ReadOnly _invoiceRepo As New InvoiceRepository()
    Private ReadOnly _projectRepo As New ProjectRepository()

    Public Sub New(invoiceToEdit As Invoice)
        InitializeComponent()
        _isEditMode = (invoiceToEdit IsNot Nothing)
        If _isEditMode Then _originalInvoice = invoiceToEdit
    End Sub

    Public ReadOnly Property InvoiceToSave As Invoice
        Get
            Dim inv As New Invoice()
            If _isEditMode Then inv.InvoiceID = _originalInvoice.InvoiceID
            inv.ProjectID = DirectCast(cboProject.SelectedItem, ProjectComboItem).ProjectID
            inv.InvoiceNo = txtInvoiceNo.Text.Trim()
            inv.Amount = numAmount.Value
            inv.InvoiceDate = dtpInvoiceDate.Value.Date
            inv.DueDate = dtpDueDate.Value.Date
            inv.Status = cboStatus.SelectedItem.ToString()
            inv.Notes = txtNotes.Text.Trim()
            Return inv
        End Get
    End Property

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjects()

        For Each status In InvoiceHelper.GetStatuses()
            cboStatus.Items.Add(status)
        Next

        If _isEditMode Then
            lblFormTitle.Text = "Edit Invoice"
            txtInvoiceNo.Text = _originalInvoice.InvoiceNo
            SelectProject(_originalInvoice.ProjectID)
            numAmount.Value = _originalInvoice.Amount
            dtpInvoiceDate.Value = _originalInvoice.InvoiceDate
            dtpDueDate.Value = _originalInvoice.DueDate
            cboStatus.SelectedItem = _originalInvoice.Status
            txtNotes.Text = _originalInvoice.Notes
        Else
            lblFormTitle.Text = "Create Invoice"
            dtpInvoiceDate.Value = DateTime.Today
            dtpDueDate.Value = DateTime.Today.AddDays(30)
            If cboStatus.Items.Count > 0 Then cboStatus.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadProjects()
        cboProject.Items.Clear()
        For Each p In _projectRepo.GetAll().OrderBy(Function(x) x.ProjectName)
            cboProject.Items.Add(New ProjectComboItem(p.ProjectID, $"{p.ProjectCode} - {p.ProjectName} ({p.ClientName})"))
        Next
        If cboProject.Items.Count > 0 Then cboProject.SelectedIndex = 0
    End Sub

    Private Sub SelectProject(projectId As Integer)
        For i = 0 To cboProject.Items.Count - 1
            If DirectCast(cboProject.Items(i), ProjectComboItem).ProjectID = projectId Then
                cboProject.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidateInputs() As Boolean
        lblError.Visible = False

        If String.IsNullOrWhiteSpace(txtInvoiceNo.Text) Then
            ShowValidationError("Invoice number is required.")
            Return False
        End If
        If cboProject.SelectedItem Is Nothing Then
            ShowValidationError("Project is required.")
            Return False
        End If
        If numAmount.Value <= 0 Then
            ShowValidationError("Amount must be greater than zero.")
            Return False
        End If
        If dtpDueDate.Value.Date < dtpInvoiceDate.Value.Date Then
            ShowValidationError("Due date cannot be before invoice date.")
            Return False
        End If
        If cboStatus.SelectedItem Is Nothing Then
            ShowValidationError("Status is required.")
            Return False
        End If

        Dim existing = _invoiceRepo.GetByInvoiceNo(txtInvoiceNo.Text.Trim())
        If existing IsNot Nothing AndAlso (Not _isEditMode OrElse existing.InvoiceID <> _originalInvoice.InvoiceID) Then
            ShowValidationError("Invoice number already exists.")
            Return False
        End If

        Return True
    End Function

    Private Sub ShowValidationError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub

    Private Class ProjectComboItem
        Public ReadOnly Property ProjectID As Integer
        Private ReadOnly _display As String

        Public Sub New(projectId As Integer, display As String)
            Me.ProjectID = projectId
            _display = display
        End Sub

        Public Overrides Function ToString() As String
            Return _display
        End Function
    End Class

End Class
