Public Class ErrorForm

    Private Sub Titl_MouseMove(sender As Object, e As MouseEventArgs) Handles Titl.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.None Then
            If Titl.Tag IsNot Nothing Then Location = Location + (e.Location - Titl.Tag)
            Titl.Tag = e.Location
        End If
    End Sub

    Public Sub New(ByVal Exc As Exception)
        InitializeComponent()
        If Exc.InnerException IsNot Nothing Then
            Titl2.Text = Exc.InnerException.Message
        Else
            Titl2.Text = Exc.Message
        End If
        Txt.Text = Exc.ToString()
    End Sub

    Private Sub B_Close_Click(sender As Object, e As EventArgs) Handles B_Close.Click
        Application.Exit()
    End Sub

    Private Sub B_Restart_Click(sender As Object, e As EventArgs) Handles B_Restart.Click
        Application.Restart()
    End Sub
End Class