Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class VendorAssignForm

    Private ReadOnly _vendorRepo As New VendorRepository()
    Private ReadOnly _projectRepo As New ProjectRepository()

    Private Sub VendorAssignForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjects()
        LoadVendors()
        LoadAssignments()
    End Sub

    Private Sub LoadProjects()
        cboProject.Items.Clear()
        For Each p In _projectRepo.GetAll().OrderBy(Function(x) x.ProjectName)
            cboProject.Items.Add(New ProjectListItem(p.ProjectID, $"{p.ProjectCode} - {p.ProjectName}"))
        Next
        If cboProject.Items.Count > 0 Then cboProject.SelectedIndex = 0
    End Sub

    Private Sub LoadVendors()
        cboVendor.Items.Clear()
        For Each v In _vendorRepo.GetAll().OrderBy(Function(x) x.VendorName)
            cboVendor.Items.Add(New VendorListItem(v.VendorID, $"{v.VendorName} ({VendorHelper.FormatVendorType(v.VendorType)})"))
        Next
        If cboVendor.Items.Count > 0 Then cboVendor.SelectedIndex = 0
    End Sub

    Private Sub LoadAssignments()
        Try
            Dim assignments = _vendorRepo.GetProjectAssignments()
            Dim dt As New System.Data.DataTable()
            dt.Columns.Add("VPID", GetType(Integer))
            dt.Columns.Add("ProjectCode", GetType(String))
            dt.Columns.Add("ProjectName", GetType(String))
            dt.Columns.Add("VendorName", GetType(String))
            dt.Columns.Add("VendorType", GetType(String))
            dt.Columns.Add("AssignedDate", GetType(String))

            For Each a In assignments
                dt.Rows.Add(a.VPID, a.ProjectCode, a.ProjectName, a.VendorName,
                            VendorHelper.FormatVendorType(a.VendorType),
                            a.AssignedDate.ToString("yyyy-MM-dd"))
            Next

            gridControl1.DataSource = dt
            lblRecordCount.Text = $"{assignments.Count} assignment(s)"
        Catch ex As Exception
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Failed to load assignments: " & ex.Message
        End Try
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If cboProject.SelectedItem Is Nothing OrElse cboVendor.SelectedItem Is Nothing Then
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Please select both a project and a vendor."
            Return
        End If

        Dim projectId = DirectCast(cboProject.SelectedItem, ProjectListItem).ProjectID
        Dim vendorId = DirectCast(cboVendor.SelectedItem, VendorListItem).VendorID

        If _vendorRepo.IsAssigned(projectId, vendorId) Then
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "This vendor is already assigned to the selected project."
            Return
        End If

        Try
            _vendorRepo.AssignToProject(projectId, vendorId)
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
            lblStatus.Text = "Vendor assigned to project successfully."
            LoadAssignments()
        Catch ex As Exception
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
            lblStatus.Text = "Failed to assign vendor: " & ex.Message
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Class ProjectListItem
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

    Private Class VendorListItem
        Public ReadOnly Property VendorID As Integer
        Private ReadOnly _display As String

        Public Sub New(vendorId As Integer, display As String)
            Me.VendorID = vendorId
            _display = display
        End Sub

        Public Overrides Function ToString() As String
            Return _display
        End Function
    End Class

End Class
