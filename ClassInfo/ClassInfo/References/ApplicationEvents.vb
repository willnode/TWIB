Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Control.CheckForIllegalCrossThreadCalls = False
             If Environment.OSVersion.Version.Major < 6 Then
                MsgBox("This App are work for Windows Vista and Later. And Your Computer doesn't meet System Requirements for This App." & vbNewLine _
                        & " This App will Silently Accept all error without any Notifications", MsgBoxStyle.Exclamation, "Windows Requirements")
            End If
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            Dim x = New ClassInfo.ErrorForm(e.Exception)
            If Environment.OSVersion.Version.Major > 5 Then x.ShowDialog()
        End Sub
    End Class


End Namespace

