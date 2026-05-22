Imports DevExpress.XtraEditors
Imports ConstructionERP.Core
Imports ConstructionERP.Data
Imports System.Data.SqlClient

Public Class ExpenseForm

    Private ReadOnly _expenseRepository As IExpenseRepository
    Private ReadOnly _projectRepository As IProjectRepository
    Private ReadOnly _editingExpense As Expense
    Private ReadOnly _preselectedProjectId As Integer

    Public Sub New()
        InitializeComponent()
        _expenseRepository = New ExpenseRepository()
        _projectRepository = New ProjectRepository()
        _preselectedProjectId = 0
    End Sub

    Public Sub New(preselectedProjectId As Integer)
        InitializeComponent()
        _expenseRepository = New ExpenseRepository()
        _projectRepository = New ProjectRepository()
        _preselectedProjectId = preselectedProjectId
    End Sub

    Public Sub New(expense As Expense)
        InitializeComponent()
        _expenseRepository = New ExpenseRepository()
        _projectRepository = New ProjectRepository()
        _editingExpense = expense
        _preselectedProjectId = expense.ProjectID
        Me.Text = "Edit Expense"
    End Sub

    Private Sub ExpenseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjects()
        LoadVendors()
        dtpExpenseDate.EditValue = DateTime.Today

        If _editingExpense IsNot Nothing Then
            PopulateForEdit()
        ElseIf _preselectedProjectId > 0 Then
            lkpProject.EditValue = _preselectedProjectId
            lkpProject.Enabled = False
        End If
    End Sub

    Private Sub LoadProjects()
        Try
            Dim projects = _projectRepository.GetAll()
            Dim dt As New System.Data.DataTable()
            dt.Columns.Add("ProjectID", GetType(Integer))
            dt.Columns.Add("DisplayName", GetType(String))

            For Each p In projects
                dt.Rows.Add(p.ProjectID, $"{p.ProjectCode} - {p.ProjectName}")
            Next

            lkpProject.Properties.DataSource = dt
            lkpProject.Properties.ValueMember = "ProjectID"
            lkpProject.Properties.DisplayMember = "DisplayName"
            lkpProject.Properties.ShowHeader = False
            lkpProject.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Project"))
        Catch ex As Exception
            XtraMessageBox.Show("Failed to load projects: " & ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadVendors()
        Try
            Dim dt As System.Data.DataTable = DatabaseHelper.ExecuteStoredProcedure("sp_Vendor_GetAll")
            Dim bindDt As New System.Data.DataTable()
            bindDt.Columns.Add("VendorID", GetType(Integer))
            bindDt.Columns.Add("VendorName", GetType(String))

            For Each row As System.Data.DataRow In dt.Rows
                bindDt.Rows.Add(Convert.ToInt32(row("VendorID")), row("VendorName").ToString())
            Next

            lkpVendor.Properties.DataSource = bindDt
            lkpVendor.Properties.ValueMember = "VendorID"
            lkpVendor.Properties.DisplayMember = "VendorName"
            lkpVendor.Properties.ShowHeader = False
            lkpVendor.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VendorName", "Vendor"))
        Catch ex As Exception
            ' Vendors are optional — silently degrade if not available
        End Try
    End Sub

    Private Sub PopulateForEdit()
        lkpProject.EditValue = _editingExpense.ProjectID
        lkpProject.Enabled = False
        dtpExpenseDate.EditValue = _editingExpense.ExpenseDate
        cmbCategory.EditValue = _editingExpense.Category
        spinAmount.Value = _editingExpense.Amount
        If _editingExpense.VendorID.HasValue Then
            lkpVendor.EditValue = _editingExpense.VendorID.Value
        End If
        memoDescription.EditValue = _editingExpense.Description
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return

        Dim expense As New Expense With {
            .ProjectID = Convert.ToInt32(lkpProject.EditValue),
            .ExpenseDate = Convert.ToDateTime(dtpExpenseDate.EditValue),
            .Category = cmbCategory.EditValue.ToString(),
            .Amount = spinAmount.Value,
            .VendorID = If(lkpVendor.EditValue IsNot Nothing AndAlso lkpVendor.EditValue IsNot DBNull.Value,
                           CType(Convert.ToInt32(lkpVendor.EditValue), Integer?),
                           Nothing),
            .Description = If(memoDescription.EditValue IsNot Nothing, memoDescription.EditValue.ToString().Trim(), String.Empty)
        }

        Try
            If _editingExpense IsNot Nothing Then
                expense.ExpenseID = _editingExpense.ExpenseID
                _expenseRepository.Update(expense)
                XtraMessageBox.Show("Expense updated successfully.", "Success", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            Else
                Dim newId = _expenseRepository.Insert(expense)
                XtraMessageBox.Show($"Expense saved successfully. ID: {newId}", "Success", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            End If

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show("Error saving expense: " & ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If lkpProject.EditValue Is Nothing OrElse lkpProject.EditValue Is DBNull.Value Then
            XtraMessageBox.Show("Please select a project.", "Validation", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            lkpProject.Focus()
            Return False
        End If

        If dtpExpenseDate.EditValue Is Nothing OrElse IsDBNull(dtpExpenseDate.EditValue) Then
            XtraMessageBox.Show("Expense date is required.", "Validation", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            dtpExpenseDate.Focus()
            Return False
        End If

        If cmbCategory.EditValue Is Nothing OrElse String.IsNullOrWhiteSpace(cmbCategory.EditValue.ToString()) Then
            XtraMessageBox.Show("Please select a category.", "Validation", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            cmbCategory.Focus()
            Return False
        End If

        If spinAmount.Value <= 0 Then
            XtraMessageBox.Show("Amount must be greater than zero.", "Validation", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            spinAmount.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
