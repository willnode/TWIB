
Public Class U_Info

    Private Sub DisSet_Click(sender As Object, e As EventArgs)
        If Not SysInfo.IsDisposed Then SysInfo.Show()
    End Sub

    Private Sub btn_donate_Click(sender As Object, e As EventArgs) Handles btn_donate.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=T7TZ4JW5YXQ7J")
    End Sub

    Private Sub btn_home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_home.LinkClicked
        Process.Start("http://twibtool.wordpress.com")
    End Sub

    Private Sub O_Close_Click(sender As Object, e As EventArgs) Handles O_Close.Click
        Application.Exit()
    End Sub

    Private Sub O_ClrPck_Click(sender As Object, e As EventArgs) Handles O_ClrPck.Click
        Dim dlg As New ClrDialog
        dlg.Colour = O_ClrPck.BackColor
        dlg.isToolBarChange = True
       If dlg.ShowDialog() = DialogResult.OK Then
            O_ClrPck.BackColor = dlg.Colour
            DockForm.BackColor = dlg.Colour
            My.Settings.Save()
        Else
            DockForm.BackColor = O_ClrPck.BackColor
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        V.Text = "Ver. " & My.Application.Info.Version.ToString
        Splash.AddLoadPoint()
    End Sub
End Class
