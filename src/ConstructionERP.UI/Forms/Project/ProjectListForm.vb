Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class ProjectListForm

    Private ReadOnly _projectRepo As New ProjectRepository()
    Private _allProjects As List(Of Project)

    Private Sub ProjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatusFilter.Items.Add("All Statuses")
        cboStatusFilter.Items.AddRange(New Object() {"Active", "On Hold", "Completed", "Cancelled"})
        cboStatusFilter.SelectedIndex = 0

        cboSort.Items.Add("Start Date (Newest)")
        cboSort.Items.Add("Start Date (Oldest)")
        cboSort.Items.Add("Name (A-Z)")
        cboSort.Items.Add("Name (Z-A)")
        cboSort.SelectedIndex = 0

        btnNewProject.Visible = RoleHelper.CanManageProjects(SessionManager.CurrentUser.Role)
        LoadProjects()
    End Sub

    Private Sub LoadProjects()
        Try
            _allProjects = _projectRepo.GetAll()
            ApplyFilter()
        Catch ex As Exception
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Failed to load projects: " & ex.Message
        End Try
    End Sub

    Private Sub ApplyFilter()
        lblStatus.Text = ""
        If _allProjects Is Nothing Then Return

        Dim filtered = _allProjects.AsEnumerable()

        If cboStatusFilter.SelectedIndex > 0 Then
            Dim status = cboStatusFilter.SelectedItem.ToString()
            filtered = filtered.Where(Function(p) p.Status = status)
        End If

        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            Dim term = txtSearch.Text.Trim().ToLower()
            filtered = filtered.Where(Function(p) p.ProjectCode.ToLower().Contains(term) OrElse
                                                  p.ProjectName.ToLower().Contains(term) OrElse
                                                  p.ClientName.ToLower().Contains(term))
        End If

        Select Case cboSort.SelectedIndex
            Case 1
                filtered = filtered.OrderBy(Function(p) p.StartDate)
            Case 2
                filtered = filtered.OrderBy(Function(p) p.ProjectName)
            Case 3
                filtered = filtered.OrderByDescending(Function(p) p.ProjectName)
            Case Else
                filtered = filtered.OrderByDescending(Function(p) p.StartDate)
        End Select

        BindGrid(filtered.ToList())
    End Sub

    Private Sub BindGrid(projects As List(Of Project))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("ProjectID", GetType(Integer))
        dt.Columns.Add("ProjectCode", GetType(String))
        dt.Columns.Add("ProjectName", GetType(String))
        dt.Columns.Add("ClientName", GetType(String))
        dt.Columns.Add("Budget", GetType(String))
        dt.Columns.Add("StartDate", GetType(String))
        dt.Columns.Add("Status", GetType(String))

        For Each p In projects
            dt.Rows.Add(p.ProjectID, p.ProjectCode, p.ProjectName, p.ClientName,
                        p.Budget.ToString("C0"), p.StartDate.ToString("yyyy-MM-dd"), p.Status)
        Next

        gridControl1.DataSource = dt
        lblRecordCount.Text = $"{projects.Count} project(s)"
    End Sub

    Private Function GetSelectedProjectId() As Integer?
        Dim rowHandle = gridView1.FocusedRowHandle
        If rowHandle < 0 Then Return Nothing
        Return Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ProjectID"))
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ApplyFilter()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cboStatusFilter.SelectedIndex = 0
        cboSort.SelectedIndex = 0
        lblStatus.Text = ""
        ApplyFilter()
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        OpenSelectedDetails()
    End Sub

    Private Sub gridControl1_DoubleClick(sender As Object, e As EventArgs) Handles gridControl1.DoubleClick
        Dim pt = gridControl1.PointToClient(Cursor.Position)
        Dim hitInfo = gridView1.CalcHitInfo(pt)
        If hitInfo.InRow Then OpenSelectedDetails()
    End Sub

    Private Sub OpenSelectedDetails()
        Dim projectId = GetSelectedProjectId()
        If Not projectId.HasValue Then
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Please select a project to view details."
            Return
        End If

        Using frm As New ProjectDetailForm(projectId.Value)
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click
        Using frm As New ProjectForm()
            frm.ShowDialog(Me)
        End Using
        LoadProjects()
    End Sub

End Class
