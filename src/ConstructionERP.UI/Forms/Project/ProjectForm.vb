Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class ProjectForm

    Private ReadOnly _projectRepository As IProjectRepository
    Private ReadOnly _errorProvider As DXErrorProvider

    Public Sub New()
        InitializeComponent()
        _projectRepository = New ProjectRepository()
        _errorProvider = New DXErrorProvider(Me)
        
        ' Set default values
        dtpStartDate.EditValue = DateTime.Today
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Clear previous errors
        _errorProvider.ClearErrors()

        ' Validate required fields
        If String.IsNullOrWhiteSpace(txtProjectCode.Text) Then
            _errorProvider.SetError(txtProjectCode, "Project Code is required")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtProjectName.Text) Then
            _errorProvider.SetError(txtProjectName, "Project Name is required")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtClientName.Text) Then
            _errorProvider.SetError(txtClientName, "Client Name is required")
            Return
        End If

        If spinBudget.Value <= 0 Then
            _errorProvider.SetError(spinBudget, "Budget must be greater than 0")
            Return
        End If

        If dtpStartDate.EditValue Is Nothing OrElse IsDBNull(dtpStartDate.EditValue) Then
            _errorProvider.SetError(dtpStartDate, "Start Date is required")
            Return
        End If

        ' Validate Status Selection (Prevents NullReferenceException)
        If cmbStatus.SelectedItem Is Nothing Then
            _errorProvider.SetError(cmbStatus, "Please select a Project Status")
            Return
        End If

        ' Validate unique project code
        Dim existingProject = _projectRepository.GetByCode(txtProjectCode.Text.Trim())
        If existingProject IsNot Nothing Then
            _errorProvider.SetError(txtProjectCode, "Project Code already exists")
            Return
        End If

        ' Create project object
        Dim project As New Project With {
            .ProjectCode = txtProjectCode.Text.Trim(),
            .ProjectName = txtProjectName.Text.Trim(),
            .ClientName = txtClientName.Text.Trim(),
            .Budget = spinBudget.Value,
            .StartDate = Convert.ToDateTime(dtpStartDate.EditValue),
            .EndDate = If(dtpEndDate.EditValue Is Nothing OrElse IsDBNull(dtpEndDate.EditValue),
                      CType(Nothing, DateTime?),
                      Convert.ToDateTime(dtpEndDate.EditValue)),
            .Status = cmbStatus.SelectedItem.ToString()
        }

        ' Save to database
        Try
            Dim projectId = _projectRepository.Insert(project)
            XtraMessageBox.Show($"Project saved successfully! Project ID: {projectId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Clear form
            ClearForm()
        Catch ex As Exception
            XtraMessageBox.Show($"Error saving project: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ClearForm()
        txtProjectCode.Text = ""
        txtProjectName.Text = ""
        txtClientName.Text = ""
        spinBudget.Value = 0
        dtpStartDate.EditValue = DateTime.Today
        dtpEndDate.EditValue = Nothing
        cmbStatus.SelectedIndex = 0
        _errorProvider.ClearErrors()
    End Sub

    Private Sub txtProjectCode_EditValueChanged(sender As Object, e As EventArgs) Handles txtProjectCode.EditValueChanged
        _errorProvider.ClearErrors()
    End Sub
End Class
