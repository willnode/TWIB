Imports ClassInfo.C_WiFi
Imports System.Runtime.InteropServices

Public Class U_WiFi
    Public NetList() As NetworkAdapter = {}

    Public Sub OpenNetwork()
        Shell("rundll32.exe " & Environment.SystemDirectory & "\van.dll, RunVAN")
    End Sub
    Public Sub RefreshNetList()
        For Each i As NetworkAdapter In NetList
            i.stopMonitoring() : Next
        Dim x = New NetworkMonitor
        NetList = x.getAdapters.ToArray
        For Each i As NetworkAdapter In NetList
            i.startMonitoring()
        Next
        '
        NetSelect.Items.Clear()
        If NetList.Length > 0 Then
            NetSelect.Items.Add("Total Usage on All Active Networks")
            For Each i As NetworkAdapter In NetList
                NetSelect.Items.Add("Usage on " & i.Name.ToArray)
            Next
        Else
            NetSelect.Items.Add("No Active Networks detected")
        End If
        NetSelect.SelectedIndex = 0
    End Sub
    Public Function GetTotalUsage() As Single
        Dim x As Single = 0
        For Each i As NetworkAdapter In NetList
            x += i.SpeedUp + i.SpeedDown
        Next
        Return x
    End Function
    Public Sub RefreshNet()
        If NetSelect.Items.Count > 1 Then
            If TabC.SelectedIndex = 0 Then
                RefreshNet_Summary()
            Else
                RefreshNet_Detail()
            End If
        Else
            NetDown.Text = "----" : NetUpSpd.Text = "0 B/s"
            NetDownSpd.Text = "0 B/s" : NetUp.Text = "----"
            NetPacket.Text = "----" : NetPacketSpd.Text = "0 B/s"
        End If
    End Sub
    Private Sub RefreshNet_Summary()
        Dim y = (NetType.SelectedIndex = 1)
        If NetSelect.SelectedIndex = 0 Then
            Dim up = 0.0F, down = 0.0F, upspd = 0.0F, downspd = 0.0F, packet = 0.0F, packetspd = 0.0F
            For Each i As NetworkAdapter In NetList
                up += i.TotalUp : down += i.TotalDown : upspd += i.SpeedUp : downspd += i.SpeedDown
                packet = i.PacketNU_TotalDown + i.PacketNU_TotalUp + i.PacketU_TotalDown + i.PacketU_TotalUp
                packetspd = i.PacketNU_SpeedDown + i.PacketNU_SpeedUp + i.PacketU_SpeedDown + i.PacketU_SpeedUp
            Next
            NetDown.Text = Helper.FixBytes(down, 2, y) : NetUpSpd.Text = Helper.FixBytes(upspd, 2, y) & "/s"
            NetDownSpd.Text = Helper.FixBytes(downspd, 2, y) & "/s" : NetUp.Text = Helper.FixBytes(up, 2, y)
            NetPacket.Text = packet.ToString("#,#0") : NetPacketSpd.Text = packetspd.ToString("#,#0") & If(packetspd > 1, " Packets/s", " Packet/s")
        Else
            With NetList(NetSelect.SelectedIndex - 1)
                NetDown.Text = Helper.FixBytes(.TotalDown, 2, y) : NetUpSpd.Text = Helper.FixBytes(.SpeedUp, 2, y) & "/s"
                NetDownSpd.Text = Helper.FixBytes(.SpeedDown, 2, y) & "/s" : NetUp.Text = Helper.FixBytes(.TotalUp, 2, y)
                NetPacket.Text = (.PacketNU_TotalDown + .PacketNU_TotalUp + .PacketU_TotalDown + .PacketU_TotalUp).ToString("#,#0")
                Dim packetspd = .PacketNU_SpeedDown + .PacketNU_SpeedUp + .PacketU_SpeedDown + .PacketU_SpeedUp
                NetPacketSpd.Text = (packetspd).ToString("#,#0") & If(packetspd > 1, " Packets/s", " Packet/s")
            End With
        End If
    End Sub
    Private Sub RefreshNet_Detail()
        If NetSelect.SelectedIndex = 0 Then
            'Dim up = 0.0F, down = 0.0F, upspd = 0.0F, downspd = 0.0F, packet = 0.0F, packetspd = 0.0F
            'For Each i As NetworkAdapter In NetList
            '    up += i.TotalUp : down += i.TotalDown : upspd += i.SpeedUp : downspd += i.SpeedDown
            '    packet = i.PacketNU_TotalDown + i.PacketNU_TotalUp + i.PacketU_TotalDown + i.PacketU_TotalUp
            '    packetspd = i.PacketNU_SpeedDown + i.PacketNU_SpeedUp + i.PacketU_SpeedDown + i.PacketU_SpeedUp
            'Next
  
        Else
            With NetList(NetSelect.SelectedIndex - 1)
                Net.Items(0).SubItems(1).Text = .TotalUp.ToString("#,#0") : Net.Items(0).SubItems(2).Text = .SpeedUp.ToString("#,#0")
                Net.Items(1).SubItems(1).Text = .TotalDown.ToString("#,#0") : Net.Items(1).SubItems(2).Text = .SpeedDown.ToString("#,#0")
                Net.Items(2).SubItems(1).Text = (.TotalDown + .TotalUp).ToString("#,#0") : Net.Items(2).SubItems(2).Text = (.SpeedDown + .SpeedUp).ToString("#,#0")

                Net.Items(3).SubItems(1).Text = .PacketU_TotalUp.ToString("#,#0") : Net.Items(3).SubItems(2).Text = .PacketU_SpeedUp.ToString("#,#0")
                Net.Items(4).SubItems(1).Text = .PacketU_TotalDown.ToString("#,#0") : Net.Items(4).SubItems(2).Text = .PacketU_SpeedDown.ToString("#,#0")
                Net.Items(5).SubItems(1).Text = (.PacketU_TotalDown + .PacketU_TotalUp).ToString("#,#0") : Net.Items(5).SubItems(2).Text = (.PacketU_SpeedDown + .PacketU_SpeedUp).ToString("#,#0")

                Net.Items(6).SubItems(1).Text = .PacketNU_TotalUp.ToString("#,#0") : Net.Items(6).SubItems(2).Text = .PacketNU_SpeedUp.ToString("#,#0")
                Net.Items(7).SubItems(1).Text = .PacketNU_TotalDown.ToString("#,#0") : Net.Items(7).SubItems(2).Text = .PacketNU_SpeedDown.ToString("#,#0")
                Net.Items(8).SubItems(1).Text = (.PacketNU_TotalDown + .PacketNU_TotalUp).ToString("#,#0") : Net.Items(8).SubItems(2).Text = (.PacketNU_SpeedDown + .PacketNU_SpeedUp).ToString("#,#0")
            End With
        End If
        Net.Visible = NetSelect.SelectedIndex > 0
    End Sub
    Private Sub U_WiFi_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Updater.Enabled = Visible
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        RefreshNet()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshNetList()
        NetType.SelectedIndex = 0
        Splash.AddLoadPoint()
    End Sub

    Private Sub DisSet_Click(sender As Object, e As EventArgs) Handles DisSet.Click
        OpenNetwork()
    End Sub
End Class
