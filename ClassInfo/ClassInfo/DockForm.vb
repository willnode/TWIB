Imports System.Runtime.InteropServices

Public Class DockForm

    Public Sub ReLayout()
        With SystemInformation.WorkingArea
            Width = 30
            Height = .Height
            Top = .Top
            Left = .Right - Width + MainForm.WorkModified
        End With
    End Sub
    Private Sub S_Click(sender As Object, e As EventArgs) Handles S_WiFi.Click, S_Temp.Click, S_Memo.Click, S_Light.Click, S_CPU.Click, S_Batt.Click, S_Audio.Click, L_WiFi.Click, L_Temp.Click, L_Memo.Click, L_Light.Click, L_CPU.Click, L_Batt.Click, L_Audio.Click
        MainForm.FlyOutMode()
        MainForm.Focus()
    End Sub

    Private Sub DockForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub
   
 
    Private Sub DockForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BackColor = My.Settings.ToolBarColor
        ReLayout()
        If Not Splash.IsDisposed Then
            Splash.Tim.Start()
        End If
    End Sub
    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        Dim x = Info.Display.isCurrentWindowFullScreen
        If Me.Tag <> x Then
            Visible = Not x
            Tag = x
        End If
    End Sub

End Class