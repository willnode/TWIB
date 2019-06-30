Imports ClassInfo.Watchers
Public Class MainForm
    Public WithEvents KeyHooker As New WindowsHookLib.KeyboardHook
    Public WithEvents AudioHooker As CoreAudioApi.AudioEndpointVolume
    Public WithEvents LightHooker As New Watchers.LightWatcher
    Public WithEvents DeviceHooker As New Watchers.DeviceWatcher
    Public DiskWatcher As New C_Disk.PerfDisk
    Public WorkModified As Integer = 0
    Public WorkLastRect As Rectangle
    Private Docked As TriState = TriState.UseDefault
#Region "FormHandles"
    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles UpdaterFlyOut.Tick
        Dim tim = Date.Now
        If Visible Then
            Refresh_CPU()
            If (L_Temp.Tag <> 0) Then Refresh_Temp()
            Refresh_RAM()
            Refresh_Disk()
            If (L_Audio.Tag = 1) Or (L_Audio.Tag = 2) Then Refresh_Audio(True)
            If (L_WiFi.Tag = 1) Or (L_WiFi.Tag = 2) Then Refresh_WiFi(True)
        Else
            Refresh_Dock_CPU()
            If (L_Temp.Tag <> 0) Then Refresh_Dock_Temp()
            Refresh_Dock_RAM()
            Refresh_Dock_Disk()
            If (DockForm.L_Audio.Tag = 1) Or (DockForm.L_Audio.Tag = 2) Then Refresh_Dock_Audio(True)
            If (DockForm.L_WiFi.Tag = 1) Or (DockForm.L_WiFi.Tag = 2) Then Refresh_Dock_WiFi(True)
        End If
        Info.Battery.BatteryHook.Check()
        Refresh_WorkArea()
        Text = (Date.Now - tim).TotalMilliseconds
    End Sub
    
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        S_Batt.Tag = F_Batt
        S_Audio.Tag = F_Audio
        S_Memo.Tag = F_Memo
        S_CPU.Tag = F_CPU
        S_Temp.Tag = F_Temp
        S_Light.Tag = F_Display
        S_Info.Tag = F_Info
        S_WiFi.Tag = F_WiFi
        S_Disk.Tag = F_Disk
        '-----
        KeyHooker.InstallHook()
        AudioHooker = F_Audio.AudioHook
        AddHandler Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged, AddressOf Hooker_WiFi
        AddHandler Info.Battery.BatteryHook.BatteryChange, AddressOf BatteryHooker_BatteryChange
        AddHandler Microsoft.Win32.SystemEvents.DisplaySettingsChanged, AddressOf Refresh_ScreenRes
        Refresh_Audio() : Refresh_Battery() : Refresh_Temp()
        Refresh_Light() : Refresh_WiFi() : Refresh_Key()
        Refresh_Dock_Audio() : Refresh_Dock_Battery() : Refresh_Dock_Temp()
        Refresh_Dock_Light() : Refresh_Dock_WiFi()
        SetDocked(TriState.False)
        DockForm.Show()
        UpdaterFlyOut.Start()
    End Sub
    Private Sub ReLayout()
        With SystemInformation.WorkingArea
            Height = .Height
            Top = .Top
            Left = .Right - Width + WorkModified
        End With
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LightHooker.Dispose()
        SetDocked(TriState.UseDefault)
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Docked <> TriState.True Then SnapMode()
    End Sub

    Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
        If Not Me.IsHandleCreated Then
            Me.CreateHandle()
            value = False
        End If
        MyBase.SetVisibleCore(value)
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ReLayout()

    End Sub
#End Region
#Region "DetailForm"
    Private VisibledForm As UserControl
    Private Sub ItemChange(sender As Object, e As EventArgs) Handles S_WiFi.Click, S_Temp.Click, S_Memo.Click, S_Light.Click, S_Disk.Click, S_CPU.Click, S_Batt.Click, S_Audio.Click, S_Info.Click
        Dim x As RadioButton = CType(sender, RadioButton)
        If x.Checked AndAlso TypeOf sender.tag Is UserControl Then
            If x.Tag Is VisibledForm Then
                x.Checked = False
                x.Tag.Visible = False
                VisibledForm = Nothing
            ElseIf (VisibledForm IsNot Nothing) Then
                VisibledForm.Visible = False
                VisibledForm = sender.tag
                VisibledForm.Visible = True
            Else
                VisibledForm = sender.tag
                VisibledForm.Visible = True
            End If
        End If
    End Sub
#End Region
#Region "Hooker"
    Private Sub Hooker_Audio(data As CoreAudioApi.AudioVolumeNotificationData) Handles AudioHooker.OnVolumeNotification
        On Error Resume Next
        If Me.InvokeRequired Then
            Dim Params() = New Object(0) {}
            Params(0) = data
            Me.Invoke(New CoreAudioApi.AudioEndpointVolumeNotificationDelegate(AddressOf Hooker_Audio), Params)
        Else
            Refresh_Audio()
            Refresh_Dock_Audio()
        End If
    End Sub
    Private Sub Hooker_Device(sender As Object, e As EventArrivedEventArgs) Handles DeviceHooker.DeviceChange
        If InvokeRequired Then
            Dim Params() = New Object(1) {}
            Params(0) = sender
            Params(1) = e
            Invoke(New Management.EventArrivedEventHandler(AddressOf Hooker_Device), Params)
        Else
            F_Audio.InitDevices()
            AudioHooker = F_Audio.AudioHook
            My.Application.DoEvents()
            Refresh_Audio() : Refresh_Dock_Audio()
            F_Disk.RefreshDisk()

        End If
    End Sub
    Private Sub Hooker_Light(sender As Object, e As EventArrivedEventArgs) Handles LightHooker.LightChange
        If InvokeRequired Then
            Dim Params() = New Object(1) {}
            Params(0) = sender
            Params(1) = e
            Invoke(New Management.EventArrivedEventHandler(AddressOf Hooker_Light), Params)
        Else
            Refresh_Light()
            Refresh_Dock_Light()
        End If
    End Sub
    Private Sub Hooker_WiFi(sender As Object, e As System.Net.NetworkInformation.NetworkAvailabilityEventArgs)
        If InvokeRequired Then
            Dim Params() = New Object(1) {}
            Params(0) = sender
            Params(1) = e
            Invoke(New Net.NetworkInformation.NetworkAvailabilityChangedEventHandler(AddressOf Hooker_WiFi), Params)
        Else
            Refresh_WiFi()
            Refresh_Dock_WiFi()
            F_WiFi.RefreshNetList()
        End If
    End Sub
    Private Sub KeyHooker_KeyDown(sender As Object, e As WindowsHookLib.KeyboardEventArgs) Handles KeyHooker.KeyDown, KeyHooker.KeyUp
        If (e.VirtualKeyCode = Keys.CapsLock) Or (e.VirtualKeyCode = Keys.Scroll) Or (e.VirtualKeyCode = Keys.NumLock) Then Refresh_Key()
    End Sub
    Private Sub BatteryHooker_BatteryChange(ByVal WithPower As Boolean)
        If InvokeRequired Then
            Dim param(0) As Object
            param(0) = WithPower
            Invoke(New BatteryChangeEventHandler(AddressOf BatteryHooker_BatteryChange), param)
        Else

            Refresh_Battery()
            Refresh_Dock_Battery()
        End If
    End Sub
#End Region
#Region "Refresh"
    Private Sub Refresh_Audio(Optional ByVal Quick As Boolean = False)
        'Audio
        Dim Audio = 2
        If Not Quick Then
            If AudioHooker Is Nothing Then : Audio = 3 : L_Audio.Text = "Disabled"
            ElseIf AudioHooker.MasterVolumeLevelScalar = 0 Then : Audio = 0 : L_Audio.Text = "0 %"
            ElseIf AudioHooker.Mute Then : Audio = 0 : L_Audio.Text = "Muted"
            ElseIf L_Audio.Tag <> 2 Then : Audio = 1 : L_Audio.Text = (AudioHooker.MasterVolumeLevelScalar * 100).ToString("0") & " %"
            Else : L_Audio.Text = (AudioHooker.MasterVolumeLevelScalar * 100).ToString("0") & " %" : End If
        Else
            Try : Audio = If(F_Audio.AudioDevice.AudioMeterInformation.MasterPeakValue < 0.005, 1, 2)
            Catch ex As Exception
                Audio = 1 : End Try
        End If

        If Not (L_Audio.Tag = Audio) Then S_Audio.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Audio, Audio) : L_Audio.Tag = Audio
    End Sub
    Private Sub Refresh_Battery()
        'Battery
        Dim Batt = 0
        Dim x = Info.Battery.GetBatterySummary
        L_Batt.Text = Replace(Replace(x, "+", ""), "!", "")
        If x = "----" Then : Batt = 3 : L_Batt.Text = "No Battery"
        ElseIf Not (x.Contains("+") Or x.Contains("!")) Then : Batt = 0
        ElseIf x.Contains("!") Then : Batt = 2
        Else : Batt = 1 : End If

        If Not (L_Batt.Tag = Batt) Then S_Batt.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Batt, Batt) : L_Batt.Tag = Batt

    End Sub
    Private Sub Refresh_Light()
        'Light
        Try
            Dim Light_ = C_Display.Tuning.GetBrightness
            Dim Light = 0
            L_Light.Text = Light_ & " %"
            If Light_ < 20 Then : Light = 0
            ElseIf Light_ < 60 Then : Light = 1
            Else : Light = 2 : End If

            If Not (L_Light.Tag = Light) Then S_Light.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Light, Light) : L_Light.Tag = Light
        Catch ex As Exception
            L_Light.Text = "Disabled"
            If Not (L_Light.Tag = 3) Then S_Light.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Light, 3) : L_Light.Tag = 3
        End Try
    End Sub
    Private Sub Refresh_WiFi(Optional ByVal Quick As Boolean = False)
        'WiFi
        Dim Wifi = 0
        If Not Quick Then
            '  If Info.WiFi.WiFiCount <= 0 Then : Wifi = 3 : L_WiFi.Text = "Off"
            If Not My.Computer.Network.IsAvailable Then : Wifi = 0 : L_WiFi.Text = "Idle"
            Else : Wifi = 1 : L_WiFi.Text = "Ready" : End If
        Else
            Wifi = If(F_WiFi.GetTotalUsage < 10, 1, 2)
            L_WiFi.Text = If(Wifi = 1, "Ready", Helper.FixBytes(F_WiFi.GetTotalUsage) & "/s")
        End If
        If Not (L_WiFi.Tag = Wifi) Then S_WiFi.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.WiFi, Wifi) : L_WiFi.Tag = Wifi
    End Sub
    Private Sub Refresh_Temp()
        'Temp
        Dim Temp = 0 : Dim Temp_ = Info.CPUCore.GetTempData
        If Not Info.CPUCore.GetTempAccessible Then : Temp = 0 : L_Temp.Text = "No Sensors"
        ElseIf Temp_ < 318 Then : Temp = 2 : L_Temp.Text = Helper.FixDegree(Temp_)
        ElseIf Temp_ > 338 Then : Temp = 3 : L_Temp.Text = Helper.FixDegree(Temp_)
        Else : Temp = 1 : L_Temp.Text = Helper.FixDegree(Temp_) : End If

        If Not (L_Temp.Tag = Temp) Then S_Temp.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Temp, Temp) : L_Temp.Tag = Temp
    End Sub
    Private Sub Refresh_CPU()
        'CPU
        Dim Cpu_ = Info.CPUCore.GetCoreUsage
        Dim CPU = 0 : L_CPU.Text = Cpu_.ToString("0") & " %"
        If Cpu_ < 10 Then : CPU = 0
        ElseIf Cpu_ > 90 Then : CPU = 3
        ElseIf Cpu_ > 50 Then : CPU = 2
        Else : CPU = 1 : End If

        If Not (L_CPU.Tag = CPU) Then S_CPU.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Core, CPU) : L_CPU.Tag = CPU
    End Sub
    Public Sub Refresh_Disk()
        On Error Resume Next
        Dim disk_ = DiskWatcher.DiskTimes(0)
        Dim disk = 0 : L_Disk.Text = disk_.ToString("0") & " %"
        If disk_ < 1 Then : disk = 0
        ElseIf disk_ > 90 Then : disk = 3
        ElseIf disk_ > 50 Then : disk = 2
        Else : disk = 1 : End If

        If Not (L_Disk.Tag = disk) Then S_Disk.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Disk, disk) : L_Disk.Tag = disk
    End Sub
    Private Sub Refresh_RAM()
        'RAM
        Dim Ram_ = 100 - (Info.Memory.getPhysicalFree / Info.Memory.getPhysicalTotal * 100)
        Dim RAM = 0 : L_Memo.Text = FormatNumber(Ram_, 1, -1, 0, 0) & " %"
        If Ram_ < 10 Then : RAM = 0
        ElseIf Ram_ > 90 Then : RAM = 3
        ElseIf Ram_ > 50 Then : RAM = 2
        Else : RAM = 1 : End If

        If Not (L_Memo.Tag = RAM) Then S_Memo.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Memo, RAM) : L_Memo.Tag = RAM
    End Sub

    Private Sub Refresh_Key()
        'Key
        My.Application.DoEvents()
        Key_Caps.Image = Helper.GetIconResource(Helper.IconTypes.Key_Caps, IIf(Info.KeyBoard.isCapsLock, 1, 0))
        Key_Scroll.Image = Helper.GetIconResource(Helper.IconTypes.Key_Scroll, IIf(Info.KeyBoard.isScrollLock, 1, 0))
        Key_Num.Image = Helper.GetIconResource(Helper.IconTypes.Key_Num, IIf(Info.KeyBoard.isNumLock, 1, 0))
    End Sub
#End Region
#Region "Refresh_Dock"
    Private Sub Refresh_Dock_Audio(Optional ByVal Quick As Boolean = False)
        'Audio
        Dim Audio = 2
        If Not Quick Then
            If AudioHooker Is Nothing Then : Audio = 3 : DockForm.L_Audio.Text = "Disabled"
            ElseIf AudioHooker.MasterVolumeLevelScalar = 0 Then : Audio = 0 : DockForm.L_Audio.Text = "0 %"
            ElseIf AudioHooker.Mute Then : Audio = 0 : DockForm.L_Audio.Text = "Muted"
            ElseIf DockForm.L_Audio.Tag <> 2 Then : Audio = 1 : DockForm.L_Audio.Text = (AudioHooker.MasterVolumeLevelScalar * 100).ToString("0") & " %"
            Else : DockForm.L_Audio.Text = (AudioHooker.MasterVolumeLevelScalar * 100).ToString("0") & " %" : End If
        Else
            Try : Audio = If(F_Audio.AudioDevice.AudioMeterInformation.MasterPeakValue < 0.005, 1, 2)
            Catch ex As Exception
                Audio = 1 : End Try
        End If


        If Not (DockForm.L_Audio.Tag = Audio) Then DockForm.S_Audio.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Audio, Audio) : DockForm.L_Audio.Tag = Audio
    End Sub
    Private Sub Refresh_Dock_Battery()
        'Battery
        Dim Batt = 0
        Dim x = Info.Battery.GetBatterySummary
        DockForm.L_Batt.Text = Replace(Replace(x, "+", ""), "!", "")
        If x = "----" Then : Batt = 3 : L_Batt.Text = "No Battery"
        ElseIf Not (x.Contains("+") Or x.Contains("!")) Then : Batt = 0
        ElseIf x.Contains("!") Then : Batt = 2
        Else : Batt = 1 : End If

        If Not (DockForm.L_Batt.Tag = Batt) Then DockForm.S_Batt.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Batt, Batt) : DockForm.L_Batt.Tag = Batt
    End Sub
    Private Sub Refresh_Dock_Light()
        'Light
        Try
            Dim Light_ = C_Display.Tuning.GetBrightness
            Dim Light = 0
            DockForm.L_Light.Text = Light_ & " %"
            If Light_ < 20 Then : Light = 0
            ElseIf Light_ < 60 Then : Light = 1
            Else : Light = 2 : End If

            If Not (DockForm.L_Light.Tag = Light) Then DockForm.S_Light.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Light, Light) : DockForm.L_Light.Tag = Light
        Catch ex As Exception
            DockForm.L_Light.Text = "Disabled"
            If Not (DockForm.L_Light.Tag = 3) Then DockForm.S_Light.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Light, 3) : DockForm.L_Light.Tag = 3
        End Try
    End Sub
    Private Sub Refresh_Dock_WiFi(Optional ByVal Quick As Boolean = False)
        'WiFi
        Dim Wifi = 0
        If Not Quick Then
            ' If Info.WiFi.WiFiCount <= 0 Then : Wifi = 3 : DockForm.L_WiFi.Text = "Off"
            If Not My.Computer.Network.IsAvailable Then : Wifi = 0 : DockForm.L_WiFi.Text = "Idle"
            Else : Wifi = 1 : DockForm.L_WiFi.Text = "Ready" : End If
        Else
            Wifi = If(F_WiFi.GetTotalUsage < 10, 1, 2)
            DockForm.L_WiFi.Text = If(Wifi = 1, "Ready", Helper.FixBytes(F_WiFi.GetTotalUsage) & "/s")
        End If
        If Not (DockForm.L_WiFi.Tag = Wifi) Then DockForm.S_WiFi.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.WiFi, Wifi) : DockForm.L_WiFi.Tag = Wifi
    End Sub
    Private Sub Refresh_Dock_Temp()
        'Temp
        Dim Temp = 0 : Dim Temp_ = Info.CPUCore.GetTempData
        If Not Info.CPUCore.GetTempAccessible Then : Temp = 0 : DockForm.L_Temp.Text = "No Sensors"
        ElseIf Temp_ < 318 Then : Temp = 2 : DockForm.L_Temp.Text = Helper.FixDegree(Temp_)
        ElseIf Temp_ > 338 Then : Temp = 3 : DockForm.L_Temp.Text = Helper.FixDegree(Temp_)
        Else : Temp = 1 : DockForm.L_Temp.Text = Helper.FixDegree(Temp_) : End If

        If Not (DockForm.L_Temp.Tag = Temp) Then DockForm.S_Temp.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Temp, Temp) : DockForm.L_Temp.Tag = Temp
    End Sub
    Private Sub Refresh_Dock_CPU()
        'CPU
        Dim Cpu_ = Info.CPUCore.GetCoreUsage
        Dim CPU = 0 : DockForm.L_CPU.Text = Cpu_.ToString("0") & " %"
        If Cpu_ < 10 Then : CPU = 0
        ElseIf Cpu_ > 90 Then : CPU = 3
        ElseIf Cpu_ > 50 Then : CPU = 2
        Else : CPU = 1 : End If

        If Not (DockForm.L_CPU.Tag = CPU) Then DockForm.S_CPU.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Core, CPU) : DockForm.L_CPU.Tag = CPU
    End Sub
    Public Sub Refresh_Dock_Disk()
        On Error Resume Next
        Dim disk_ = DiskWatcher.DiskTimes(0)
        Dim disk = 0 : DockForm.L_Disk.Text = disk_.ToString("0") & " %"
        If disk_ < 1 Then : disk = 0
        ElseIf disk_ > 90 Then : disk = 3
        ElseIf disk_ > 50 Then : disk = 2
        Else : disk = 1 : End If

        If Not (DockForm.L_Disk.Tag = disk) Then DockForm.S_Disk.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Disk, disk) : DockForm.L_Disk.Tag = disk
    End Sub
    Private Sub Refresh_Dock_RAM()
        'RAM
        Dim Ram_ = 100 - (Info.Memory.getPhysicalFree / Info.Memory.getPhysicalTotal * 100)
        Dim RAM = 0 : DockForm.L_Memo.Text = FormatNumber(Ram_, 1, -1, 0, 0) & " %"
        If Ram_ < 10 Then : RAM = 0
        ElseIf Ram_ > 90 Then : RAM = 3
        ElseIf Ram_ > 50 Then : RAM = 2
        Else : RAM = 1 : End If

        If Not (DockForm.L_Memo.Tag = RAM) Then DockForm.S_Memo.BackgroundImage = Helper.GetIconResource(Helper.IconTypes.Memo, RAM) : DockForm.L_Memo.Tag = RAM
    End Sub

#End Region
#Region "FormSnapIn"
    ''' <summary>
    ''' False=DockForm;True=MainForm;Default=None
    ''' </summary>
    Public Sub SetDocked(ByVal isDocked As TriState)
        Dim inval = 0
        If (isDocked = TriState.True) Then
            inval = WorkModified - Width
            WorkModified = Width
        ElseIf isDocked = False Then
            inval = WorkModified - DockForm.Width
            WorkModified = DockForm.Width
        Else
            inval = WorkModified
            WorkModified = 0
        End If
        Dim oldarea = SystemInformation.WorkingArea
        Dim newarea = New Rectangle(oldarea.Location, New Size(oldarea.Width + inval, oldarea.Height))
        Info.Display.SetWorkspace(Info.Display.rectToRect(newarea))
        Docked = isDocked
        WorkLastRect = SystemInformation.WorkingArea
    End Sub

    Private Sub F_Pin_CheckedChanged(sender As Object, e As EventArgs) Handles F_Pin.CheckedChanged
        If F_Pin.Checked Then
            F_Pin.BackgroundImage = My.Resources.Pin_1
            SetDocked(TriState.True)
        Else
            F_Pin.BackgroundImage = My.Resources.Pin_0
            SetDocked(TriState.False)
        End If
    End Sub
    Public Sub RestoreArea()
        Dim inval = WorkModified - DockForm.Width
        Dim oldarea = SystemInformation.WorkingArea
        Dim newarea = New Rectangle(oldarea.Location, New Size(oldarea.Width + inval, oldarea.Height))
        Info.Display.SetWorkspace(Info.Display.rectToRect(newarea))
        WorkModified = 0
    End Sub
    Public Sub SnapMode()
        Visible = False : DockForm.Visible = True
        If VisibledForm IsNot Nothing Then VisibledForm.Visible = False

    End Sub
    Public Sub FlyOutMode()
        Visible = True : DockForm.Visible = False
        If VisibledForm IsNot Nothing Then VisibledForm.Visible = True
        Refresh_Key()
    End Sub
    Public Sub Refresh_WorkArea()
        If WorkLastRect <> SystemInformation.WorkingArea Then
            WorkModified = 0
            SetDocked(Docked)
            ReLayout() : DockForm.ReLayout()
        End If
    End Sub
    Public Sub Refresh_ScreenRes(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReLayout() : DockForm.ReLayout()
        F_Display.Refresh_Res()
    End Sub
#End Region

    Private Sub SplitContainer1_DoubleClick(sender As Object, e As EventArgs) Handles SplitContainer1.DoubleClick
        SplitContainer1.SplitterDistance = 250
    End Sub

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Private Sub Key_Click(sender As Object, e As EventArgs) Handles Key_Scroll.Click, Key_Num.Click, Key_Caps.Click
        Dim ky As Keys
        If sender Is Key_Caps Then : ky = Keys.CapsLock
        ElseIf sender Is Key_Scroll Then : ky = Keys.Scroll
        ElseIf sender Is Key_Num Then : ky = Keys.NumLock
        End If
        keybd_event(ky, &H14, 1, 0) 'Press Input
        keybd_event(ky, &H14, 3, 0) 'Release Input
        Refresh_Key()
    End Sub
End Class
