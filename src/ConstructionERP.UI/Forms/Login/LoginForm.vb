Imports System.Configuration
Imports ConstructionERP.Core
Imports ConstructionERP.Data

Public Class LoginForm
    Implements ILoginView

    Private ReadOnly _presenter As LoginPresenter

    Public Sub New()
        InitializeComponent()
        _presenter = New LoginPresenter(Me, New UserRepository())
    End Sub

    Public Property Email As String Implements ILoginView.Email
        Get
            Return txtEmail.Text.Trim()
        End Get
        Set(value As String)
            txtEmail.Text = value
        End Set
    End Property

    Public Property Password As String Implements ILoginView.Password
        Get
            Return txtPassword.Text
        End Get
        Set(value As String)
            txtPassword.Text = value
        End Set
    End Property

    Public Sub ShowError(message As String) Implements ILoginView.ShowError
        lblError.Text = message
        lblError.Visible = True
    End Sub

    Public Sub NavigateToDashboard() Implements ILoginView.NavigateToDashboard
        Dim dashboard As New DashboardForm()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblError.Visible = False
        _presenter.Login()
    End Sub
End Class
