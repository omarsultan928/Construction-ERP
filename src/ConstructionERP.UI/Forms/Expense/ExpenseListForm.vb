Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class ExpenseListForm

    Private ReadOnly _expenseRepo As IExpenseRepository
    Private ReadOnly _projectRepo As IProjectRepository
    Private ReadOnly _fixedProjectId As Integer
    Private _allExpenses As List(Of Expense)
    Private _projects As List(Of Project)

    Public Sub New()
        InitializeComponent()
        _expenseRepo = New ExpenseRepository()
        _projectRepo = New ProjectRepository()
        _fixedProjectId = 0
    End Sub

    Public Sub New(projectId As Integer)
        InitializeComponent()
        _expenseRepo = New ExpenseRepository()
        _projectRepo = New ProjectRepository()
        _fixedProjectId = projectId
    End Sub

    Private Sub ExpenseListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjects()
        LoadCategoryFilter()
        ApplyRoleVisibility()

        If _fixedProjectId > 0 Then
            LockToProject(_fixedProjectId)
        End If

        LoadExpenses()
    End Sub

    Private Sub ApplyRoleVisibility()
        Dim canEdit = RoleHelper.CanManageExpenses(SessionManager.CurrentUser.Role)
        btnNewExpense.Visible = canEdit
        btnEdit.Visible = canEdit
        btnDelete.Visible = canEdit
    End Sub

    Private Sub LoadProjects()
        Try
            _projects = _projectRepo.GetAll()
            cboProjectFilter.Items.Add("All Projects")
            For Each p In _projects
                cboProjectFilter.Items.Add($"{p.ProjectCode} - {p.ProjectName}")
            Next
            cboProjectFilter.SelectedIndex = 0
        Catch ex As Exception
            lblStatus.Text = "Failed to load projects."
        End Try
    End Sub

    Private Sub LoadCategoryFilter()
        cboCategoryFilter.Items.Add("All Categories")
        cboCategoryFilter.Items.AddRange(New Object() {"Labor", "Material", "Equipment", "Subcontractor", "Miscellaneous"})
        cboCategoryFilter.SelectedIndex = 0
    End Sub

    Private Sub LockToProject(projectId As Integer)
        Dim proj = _projects.FirstOrDefault(Function(p) p.ProjectID = projectId)
        If proj IsNot Nothing Then
            Dim idx = _projects.IndexOf(proj)
            cboProjectFilter.SelectedIndex = idx + 1  ' offset by the "All Projects" item
        End If
        cboProjectFilter.Enabled = False
        Me.Text = $"Expenses"
        If _projects IsNot Nothing Then
            Dim proj2 = _projects.FirstOrDefault(Function(p) p.ProjectID = projectId)
            If proj2 IsNot Nothing Then
                Me.Text = $"Expenses — {proj2.ProjectCode} {proj2.ProjectName}"
            End If
        End If
    End Sub

    Private Sub LoadExpenses()
        lblStatus.Text = ""
        _allExpenses = New List(Of Expense)()

        Try
            If _fixedProjectId > 0 Then
                _allExpenses = _expenseRepo.GetByProject(_fixedProjectId)
            ElseIf cboProjectFilter.SelectedIndex > 0 AndAlso _projects IsNot Nothing Then
                Dim proj = _projects(cboProjectFilter.SelectedIndex - 1)
                _allExpenses = _expenseRepo.GetByProject(proj.ProjectID)
            Else
                For Each p In If(_projects, New List(Of Project)())
                    _allExpenses.AddRange(_expenseRepo.GetByProject(p.ProjectID))
                Next
            End If

            ApplyCategoryFilter()
        Catch ex As Exception
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Failed to load expenses: " & ex.Message
        End Try
    End Sub

    Private Sub ApplyCategoryFilter()
        Dim filtered = _allExpenses.AsEnumerable()

        If cboCategoryFilter.SelectedIndex > 0 Then
            Dim cat = cboCategoryFilter.SelectedItem.ToString()
            filtered = filtered.Where(Function(ex) ex.Category = cat)
        End If

        Dim list = filtered.ToList()
        BindGrid(list)
    End Sub

    Private Sub BindGrid(expenses As List(Of Expense))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("ExpenseID", GetType(Integer))
        dt.Columns.Add("ExpenseDate", GetType(String))
        dt.Columns.Add("ProjectName", GetType(String))
        dt.Columns.Add("Category", GetType(String))
        dt.Columns.Add("Amount", GetType(String))
        dt.Columns.Add("VendorName", GetType(String))
        dt.Columns.Add("Description", GetType(String))

        Dim total As Decimal = 0
        For Each ex In expenses
            Dim projName As String = ex.ProjectName
            If String.IsNullOrWhiteSpace(projName) AndAlso _projects IsNot Nothing Then
                Dim p = _projects.FirstOrDefault(Function(pr) pr.ProjectID = ex.ProjectID)
                If p IsNot Nothing Then projName = $"{p.ProjectCode} - {p.ProjectName}"
            End If
            dt.Rows.Add(
                ex.ExpenseID,
                ex.ExpenseDate.ToString("yyyy-MM-dd"),
                projName,
                ex.Category,
                ex.Amount.ToString("C2"),
                ex.VendorName,
                ex.Description)
            total += ex.Amount
        Next

        gridControl1.DataSource = dt
        lblRecordCount.Text = $"{expenses.Count} record(s)"
        lblTotal.Text = $"Total: {total.ToString("C2")}"
    End Sub

    Private Function GetSelectedExpenseId() As Integer?
        Dim rowHandle = gridView1.FocusedRowHandle
        If rowHandle < 0 Then Return Nothing
        Return Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ExpenseID"))
    End Function

    Private Function GetSelectedExpense() As Expense
        Dim expId = GetSelectedExpenseId()
        If Not expId.HasValue Then Return Nothing
        Return _allExpenses.FirstOrDefault(Function(ex) ex.ExpenseID = expId.Value)
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadExpenses()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If _fixedProjectId = 0 Then
            cboProjectFilter.SelectedIndex = 0
        End If
        cboCategoryFilter.SelectedIndex = 0
        lblStatus.Text = ""
        LoadExpenses()
    End Sub

    Private Sub cboProjectFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProjectFilter.SelectedIndexChanged
        If Not cboProjectFilter.Enabled Then Return
        LoadExpenses()
    End Sub

    Private Sub cboCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoryFilter.SelectedIndexChanged
        ApplyCategoryFilter()
    End Sub

    Private Sub btnNewExpense_Click(sender As Object, e As EventArgs) Handles btnNewExpense.Click
        Using frm As ExpenseForm = If(_fixedProjectId > 0,
                                      New ExpenseForm(_fixedProjectId),
                                      New ExpenseForm())
            If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                LoadExpenses()
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim expense = GetSelectedExpense()
        If expense Is Nothing Then
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Please select an expense to edit."
            Return
        End If

        Using frm As New ExpenseForm(expense)
            If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                LoadExpenses()
            End If
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim expense = GetSelectedExpense()
        If expense Is Nothing Then
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Please select an expense to delete."
            Return
        End If

        Dim confirm = MessageBox.Show(
            $"Delete expense of {expense.Amount.ToString("C2")} ({expense.Category}) on {expense.ExpenseDate:yyyy-MM-dd}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            Try
                _expenseRepo.Delete(expense.ExpenseID)
                LoadExpenses()
            Catch ex As Exception
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
                lblStatus.Text = "Delete failed: " & ex.Message
            End Try
        End If
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim projectId As Integer = ResolveCurrentProjectId()
        If projectId = 0 Then
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Select a specific project to view its expense summary."
            Return
        End If
        lblStatus.Text = ""
        Using frm As New ExpenseSummaryForm(projectId)
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Function ResolveCurrentProjectId() As Integer
        If _fixedProjectId > 0 Then Return _fixedProjectId
        If cboProjectFilter.SelectedIndex > 0 AndAlso _projects IsNot Nothing Then
            Return _projects(cboProjectFilter.SelectedIndex - 1).ProjectID
        End If
        Return 0
    End Function

    Private Sub gridControl1_DoubleClick(sender As Object, e As EventArgs) Handles gridControl1.DoubleClick
        Dim pt = gridControl1.PointToClient(Cursor.Position)
        Dim hitInfo = gridView1.CalcHitInfo(pt)
        If hitInfo.InRow AndAlso RoleHelper.CanManageExpenses(SessionManager.CurrentUser.Role) Then
            btnEdit_Click(sender, e)
        End If
    End Sub

End Class
