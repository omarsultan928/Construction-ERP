Imports ConstructionERP.Core.Helpers

Public Class LoginPresenter
    Private ReadOnly _view As ILoginView
    Private ReadOnly _userRepository As IUserRepository
    Private Shared ReadOnly _log As log4net.ILog = log4net.LogManager.GetLogger(GetType(LoginPresenter))

    Public Sub New(view As ILoginView, userRepository As IUserRepository)
        _view = view
        _userRepository = userRepository
    End Sub

    Public Sub Login()
        _log.Debug($"Login attempt for email: {_view.Email}")

        If String.IsNullOrWhiteSpace(_view.Email) OrElse String.IsNullOrWhiteSpace(_view.Password) Then
            _log.Warn("Login failed: email or password was empty.")
            _view.ShowError("Email and password are required.")
            Return
        End If

        Dim user = _userRepository.GetByCredentials(_view.Email, _view.Password)
        If user Is Nothing Then
            _log.Warn($"Login failed: invalid credentials for email: {_view.Email}")
            _view.ShowError("Invalid email or password.")
            Return
        End If

        If Not user.IsActive Then
            _log.Warn($"Login failed: user account is inactive for email: {_view.Email}")
            _view.ShowError("Your account has been deactivated. Please contact the administrator.")
            Return
        End If

        _log.Info($"Login successful for email: {_view.Email}")
        SessionManager.CurrentUser = user
        _view.NavigateToDashboard()
    End Sub
End Class
