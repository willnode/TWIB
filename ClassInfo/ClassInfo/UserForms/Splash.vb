Public Class Splash
    Public Sub AddLoadPoint()
        ldPntGrp.Value += 1
        My.Application.DoEvents()
    End Sub
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        V.Text = "Ver. " & My.Application.Info.Version.ToString
        Left = SystemInformation.WorkingArea.Left
        Top = SystemInformation.WorkingArea.Bottom - Height
    End Sub

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles Tim.Tick
        Opacity -= 0.02
        If Opacity <= 0 Then
            Close()
        End If
    End Sub
End Class