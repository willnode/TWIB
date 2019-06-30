Public Class U_Temp
    Public Sub ShowInfo(ByVal txt As String)
        WarnInfo.Visible = True
        WarnInfo.Text = txt
    End Sub
    Private Sub RefreshInfo(Optional ByVal Quick As Boolean = False)
        If Not Quick Then
            tempCritic.Text = Helper.FixDegree(Info.CPUCore.GetTempDataCritical, tempDegree.Checked)
            tempThrot.Text = Helper.FixDegree(Info.CPUCore.GetTempDataThrottle, tempDegree.Checked)
            tempUpdate.Text = Info.CPUCore.GetTempDataRefresh.ToString("0") & " Seconds"
        End If
        tempCur.Text = Helper.FixDegree(Info.CPUCore.GetTempDataLast, tempDegree.Checked)
        tempProg.Value = Info.CPUCore.GetTempDataLast - 273
    End Sub
    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        RefreshInfo(True)
    End Sub

    Private Sub U_Temp_Load(sender As Object, e As EventArgs) Handles Me.Load
        '   Updater.Interval = Info.CPUCore.GetTempDataRefresh * 500
    End Sub

    Private Sub U_Temp_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Updater.Enabled = Visible
        RefreshInfo()
    End Sub

    Private Sub tempDegree_CheckedChanged(sender As Object, e As EventArgs) Handles tempDegree.CheckedChanged
        RefreshInfo()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Splash.AddLoadPoint()
    End Sub
End Class
