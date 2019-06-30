Public Class U_Memo
    Private Sub RefreshInfo()
        ' On Error Resume Next
      Dim phyMaxi = Info.Memory.getPhysicalTotal
        Dim phyUsage = phyMaxi - Info.Memory.getPhysicalFree
        PhyProg.Max = phyMaxi / 1048576
        PhyProg.Value = phyUsage / 1048576
        PhyCur.Text = Helper.FixBytes(phyUsage, 2)
        PhyMax.Text = "/ " + Helper.FixBytes(phyMaxi, 1)

        Dim virMaxi = Info.Memory.getVirtualTotal
        Dim virUsage = virMaxi - Info.Memory.getVirtualFree
        VirProg.Max = virMaxi / 1048576
        VirProg.Value = virUsage / 1048576
        VirCur.Text = Helper.FixBytes(virUsage, 2)
        VirMax.Text = "/ " + Helper.FixBytes(virMaxi, 1)

        Dim PagMaxi As ULong = Info.Memory.getPageTotal
        Dim PagUsage As ULong = Info.Memory.getPageUsed
        PagProg.Max = PagMaxi / 1048576
        PagProg.Value = PagUsage / 1048576
        PagCur.Text = Helper.FixBytes(PagUsage, 2)
        PagMax.Text = "/ " + Helper.FixBytes(PagMaxi, 1)
        Dim x = (From p In Process.GetProcesses Where p.ProcessName <> "[System Process]" Order By p.WorkingSet64 Descending).Skip(0).Take(10).ToArray
        For i = 0 To 9
            topList.Items(i).Text = x(i).ProcessName
            topList.Items(i).Tag = x(i).Id
            topList.Items(i).ForeColor = If(x(i).MainWindowTitle <> Nothing, Color.White, Color.Silver)
            topList.Items(i).SubItems(1).Text = Helper.FixBytes(x(i).WorkingSet64)
        Next
    End Sub
    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        RefreshInfo()
    End Sub

    Private Sub U_Memo_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then RefreshInfo()
        Updater.Enabled = Visible
    End Sub

    Private Sub topList_SizeChanged(sender As Object, e As EventArgs) Handles topList.SizeChanged
        ColumnHeader2.Width = topList.Width - ColumnHeader1.Width - SystemInformation.VerticalScrollBarWidth
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i = 0 To 9
            topList.Items.Add("").SubItems.AddRange({""})
        Next
        Splash.AddLoadPoint()
    End Sub
End Class
