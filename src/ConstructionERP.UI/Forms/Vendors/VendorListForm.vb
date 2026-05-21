Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class VendorListForm

    Private ReadOnly _vendorRepo As New VendorRepository()
    Private _allVendors As List(Of Vendor)
    Private _currentRole As String

    Private Sub VendorListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _currentRole = SessionManager.CurrentUser.Role

        cboTypeFilter.Items.Add("All Types")
        For Each vendorType In VendorHelper.GetVendorTypes()
            cboTypeFilter.Items.Add(vendorType)
        Next
        cboTypeFilter.SelectedIndex = 0

        btnAddVendor.Visible = RoleHelper.CanManageVendors(_currentRole)
        btnEditVendor.Visible = RoleHelper.CanManageVendors(_currentRole)
        btnAssign.Visible = RoleHelper.CanAssignVendorsToProject(_currentRole)
        btnPayments.Visible = RoleHelper.CanTrackVendorPayments(_currentRole)

        LoadVendors()
    End Sub

    Private Sub LoadVendors()
        Try
            Dim typeFilter As String = Nothing
            If cboTypeFilter.SelectedIndex > 0 Then
                typeFilter = cboTypeFilter.SelectedItem.ToString()
            End If
            _allVendors = _vendorRepo.GetAll(typeFilter)
            ApplySearchFilter()
        Catch ex As Exception
            ShowError("Failed to load vendors: " & ex.Message)
        End Try
    End Sub

    Private Sub ApplySearchFilter()
        If _allVendors Is Nothing Then Return

        Dim filtered = _allVendors.AsEnumerable()
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            Dim term = txtSearch.Text.Trim().ToLower()
            filtered = filtered.Where(Function(v) v.VendorName.ToLower().Contains(term) OrElse
                                                  (v.ContactPerson IsNot Nothing AndAlso v.ContactPerson.ToLower().Contains(term)) OrElse
                                                  (v.Email IsNot Nothing AndAlso v.Email.ToLower().Contains(term)))
        End If

        BindGrid(filtered.ToList())
    End Sub

    Private Sub BindGrid(vendors As List(Of Vendor))
        Dim dt As New System.Data.DataTable()
        dt.Columns.Add("VendorID", GetType(Integer))
        dt.Columns.Add("VendorName", GetType(String))
        dt.Columns.Add("ContactPerson", GetType(String))
        dt.Columns.Add("Phone", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("VendorType", GetType(String))

        For Each v In vendors
            dt.Rows.Add(v.VendorID, v.VendorName,
                        If(v.ContactPerson, ""),
                        If(v.Phone, ""),
                        If(v.Email, ""),
                        VendorHelper.FormatVendorType(v.VendorType))
        Next

        gridControl1.DataSource = dt
        lblRecordCount.Text = $"{vendors.Count} vendor(s)"
    End Sub

    Private Function GetSelectedVendor() As Vendor
        Dim rowHandle = gridView1.FocusedRowHandle
        If rowHandle < 0 OrElse _allVendors Is Nothing Then Return Nothing
        Dim vendorId = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "VendorID"))
        Return _allVendors.FirstOrDefault(Function(v) v.VendorID = vendorId)
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadVendors()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then LoadVendors()
    End Sub

    Private Sub cboTypeFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypeFilter.SelectedIndexChanged
        LoadVendors()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cboTypeFilter.SelectedIndex = 0
        lblStatus.Text = ""
        LoadVendors()
    End Sub

    Private Sub btnAddVendor_Click(sender As Object, e As EventArgs) Handles btnAddVendor.Click
        Using frm As New VendorForm(Nothing)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _vendorRepo.Insert(frm.VendorToSave)
                    ShowSuccess("Vendor registered successfully.")
                    LoadVendors()
                Catch ex As Exception
                    ShowError("Failed to create vendor: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnEditVendor_Click(sender As Object, e As EventArgs) Handles btnEditVendor.Click
        Dim vendor = GetSelectedVendor()
        If vendor Is Nothing Then
            ShowError("Please select a vendor to edit.")
            Return
        End If

        Using frm As New VendorForm(vendor)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                Try
                    _vendorRepo.Update(frm.VendorToSave)
                    ShowSuccess("Vendor updated successfully.")
                    LoadVendors()
                Catch ex As Exception
                    ShowError("Failed to update vendor: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Using frm As New VendorAssignForm()
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim vendor = GetSelectedVendor()
        Dim vendorId As Integer? = If(vendor IsNot Nothing, vendor.VendorID, Nothing)
        Using frm As New VendorPaymentListForm(vendorId)
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub gridControl1_DoubleClick(sender As Object, e As EventArgs) Handles gridControl1.DoubleClick
        If RoleHelper.CanManageVendors(_currentRole) Then btnEditVendor_Click(sender, e)
    End Sub

    Private Sub ShowError(message As String)
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40)
        lblStatus.Text = message
    End Sub

    Private Sub ShowSuccess(message As String)
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(39, 119, 63)
        lblStatus.Text = message
    End Sub

End Class
