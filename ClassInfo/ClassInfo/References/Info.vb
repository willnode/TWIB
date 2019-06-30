Imports System.Management
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Security
Imports System.Drawing.Imaging
Imports System.Text

Public NotInheritable Class Info
    '
    Declare Function GetKeyState Lib "user32" Alias "GetKeyState" (ByValnVirtKey As Int32) As Int16
    Public NotInheritable Class KeyBoard
        Public Shared Function isCapsLock() As Boolean
            Return GetKeyState(Keys.CapsLock)
        End Function
        Public Shared Function isScrollLock() As Boolean
            Return GetKeyState(Keys.Scroll)
        End Function
        Public Shared Function isNumLock() As Boolean
            Return GetKeyState(Keys.NumLock)
        End Function
    End Class

    '
   

    '
    Public NotInheritable Class Battery
        Public Shared BatteryHook As New Watchers.BatteryWatcher
        Public Shared Function GetBatteryNames() As String()
            Dim x = CType(Helper.WmiGetValue("\root\WMI", "BatteryStaticData", "ManufactureName"), Object()).Cast(Of String).ToArray
            If x.Length > 0 Then
                For i = 0 To x.Length - 1
                    x(i) = x(i) & " " & Helper.WmiGetValue("\root\WMI", "BatteryStaticData", "DeviceName", i)
                Next
            End If
            Return x
        End Function
        Public Shared Function GetBatterySummary() As String
            Try
                Dim BattCount As Single = Helper.WmiGetRowCount("\root\WMI", "BatteryStaticData")
                If BattCount > 0 Then
                    Dim remaining As Single = 0, full As Single = 0, isCharge As Boolean = False
                    For i = 0 To BattCount - 1
                        remaining += Helper.WmiGetValue("\root\WMI", "BatteryStatus", "RemainingCapacity", i)
                        full += Helper.WmiGetValue("\root\WMI", "BatteryFullChargedCapacity", "FullChargedCapacity", i)
                        isCharge = isCharge Or Helper.WmiGetValue("\root\WMI", "BatteryStatus", "Charging", i)
                    Next
                    Dim y = ((remaining / full) * 100).ToString("0.0") & " %"
                    If Not isCharge And remaining >= full - 1 Then
                        Dim x = 0
                        For i = 0 To BattCount - 1
                            x += Helper.WmiGetValue("\root\WMI", "BatteryStatus", "DischargeRate", i)
                        Next
                        Return If(x > 0, "", "!") & y
                    End If
                    Return If(isCharge, "+", "") & y
                Else
                    Return "----"
                End If
            Catch
                Return "----"
            End Try
        End Function

        Public Shared Function GetBatteryDesc(ByVal idx As Integer) As BatteryDesc
            Dim x As New BatteryDesc
            x.Percent = CInt(Math.Round(CDec(SystemInformation.PowerStatus.BatteryLifePercent * 100.0F)))
            x.Voltage = Helper.WmiGetValue("\root\WMI", "BatteryStatus", "Voltage", idx) / 1000.0F
            x.ChargeRate = Helper.WmiGetValue("\root\WMI", "BatteryStatus", "ChargeRate", idx)
            x.DischargeRate = Helper.WmiGetValue("\root\WMI", "BatteryStatus", "DischargeRate", idx)
            x.RemainingMAh = Helper.WmiGetValue("\root\WMI", "BatteryStatus", "RemainingCapacity", idx)
            x.FullChargedCapacity = Helper.WmiGetValue("\root\WMI", "BatteryFullChargedCapacity", "FullChargedCapacity", idx)
            x.DesignedCapacity = Helper.WmiGetValue("\root\WMI", "BatteryStaticData", "DesignedCapacity", idx)
            x.isCharging = Helper.WmiGetValue("\root\WMI", "BatteryStatus", "Charging", idx)
            'x.DeviceName = Helper.WmiGetValue("\root\WMI", "BatteryStaticData", "DeviceName", idx)
            'x.DeviceCaption = Helper.WmiGetValue("\root\WMI", "BatteryStaticData", "Caption", idx)
            'x.DeviceDescription = Helper.WmiGetValue("\root\WMI", "BatteryStaticData", "Description", idx)

            x.Voltage = Helper.FixVoltage(x.Voltage)
            x.ChargeRate = Helper.FixCurrent(x.ChargeRate)
            x.DischargeRate = Helper.FixCurrent(x.DischargeRate)
            x.RemainingMAh = Helper.FixCurrent(x.RemainingMAh)
            x.FullChargedCapacity = Helper.FixCurrent(x.FullChargedCapacity)
            x.DesignedCapacity = Helper.FixCurrent(x.DesignedCapacity)

            Return x
        End Function
        Public NotInheritable Class BatteryDesc
            Public Percent As Integer
            Public Voltage As Single
            Public ChargeRate As Integer
            Public DischargeRate As Integer
            Public RemainingMAh As Integer
            Public FullChargedCapacity As Integer
            Public DesignedCapacity As Integer
            Public isCharging As Boolean
            'Public DeviceName As String
            'Public DeviceCaption As String
            'Public DeviceDescription As String
            Public Sub New()
            End Sub

        End Class
    End Class

    '
    

    '
    Public NotInheritable Class Display

        <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Private Shared Function SystemParametersInfo(uiAction As Integer, uiParam As Integer, ByRef pvParam As RECT, fWinIni As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        Private Const SPIF_SENDWININICHANGE As Int32 = 2
        Private Const SPIF_UPDATEINIFILE As Int32 = 1
        Private Const SPIF_change As Int32 = SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE
        Private Const SPI_SETWORKAREA As Int32 = 47
        Private Const SPI_GETWORKAREA As Int32 = 48

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure RECT
            Public Left As Int32
            Public Top As Int32
            ' top is before right in the native struct
            Public Right As Int32
            Public Bottom As Int32
        End Structure
        Public Shared Function rectToRect(ByVal rect As Rectangle) As RECT
            Dim x As New RECT
            x.Left = rect.Left : x.Right = rect.Right : x.Top = rect.Top : x.Bottom = rect.Bottom
            Return x
        End Function
        Public Shared Function SetWorkspace(ByRef rect__1 As RECT) As Boolean
            ' Since you've declared the P/Invoke function correctly, you don't need to
            ' do the marshaling yourself manually. The .NET FW will take care of it.

            Dim result As Boolean = SystemParametersInfo(SPI_SETWORKAREA, IntPtr.Zero, rect__1, SPIF_change)
            If Not result Then
                ' Find out the error code
                MessageBox.Show("The last error was: " + Marshal.GetLastWin32Error().ToString())
            End If

            Return result
        End Function
        ''

        Public Shared Property FontSmoothingType() As SystemFunctionLib.Personalization.FontSmoothingType
            Get
                Return SystemFunctionLib.Personalization.Display.FontSmoothingType
            End Get
            Set(value As SystemFunctionLib.Personalization.FontSmoothingType)
                SystemFunctionLib.Personalization.Display.FontSmoothingType = value
            End Set
        End Property
        Public Shared Property FontSmoothingOrien() As SystemFunctionLib.Personalization.FontSmoothingOrientation
            Get
                Return SystemFunctionLib.Personalization.Display.FontSmoothingOrientation
            End Get
            Set(value As SystemFunctionLib.Personalization.FontSmoothingOrientation)
                SystemFunctionLib.Personalization.Display.FontSmoothingOrientation = value
            End Set
        End Property
        Public Shared Property FontSmoothingContrast() As Integer
            Get
                Return SystemFunctionLib.Personalization.Display.FontSmoothingContrast
            End Get
            Set(value As Integer)
                SystemFunctionLib.Personalization.Display.FontSmoothingContrast = value
            End Set
        End Property

        <DllImport("user32.dll")> _
        Private Shared Function GetForegroundWindow() As IntPtr
        End Function
        <DllImport("user32.dll")> _
        Private Shared Function GetDesktopWindow() As IntPtr
        End Function
        <DllImport("user32.dll")> _
        Private Shared Function GetShellWindow() As IntPtr
        End Function
        <DllImport("user32.dll", SetLastError:=True)> _
        Private Shared Function GetWindowRect(hwnd As IntPtr, ByRef rc As RECT) As Integer
        End Function
        <DllImport("user32.dll")> _
        Public Shared Function FindWindow(sClassName As [String], sAppName As [String]) As IntPtr
        End Function

        <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Private Shared Function GetWindowText(ByVal hwnd As IntPtr, ByVal lpString As StringBuilder, ByVal cch As Integer) As Integer
        End Function
        <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Private Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
        End Function
        Public Shared Function GetText(ByVal hWnd As IntPtr) As String
            Dim length As Integer
            If hWnd.ToInt32 = 0 Then
                Return Nothing
            End If
            length = GetWindowTextLength(hWnd)
            If length = 0 Then
                Return Nothing
            End If
            Dim sb As New System.Text.StringBuilder("", length)

            GetWindowText(hWnd, sb, sb.Capacity + 1)
            Return sb.ToString()
        End Function
        Public Shared Function isCurrentWindowFullScreen() As Boolean
            Dim desktopHandle As IntPtr = FindWindow("WorkerW", "")
            Dim shellHandle As IntPtr = GetShellWindow()
            Dim desktopHandle2 As IntPtr = FindWindow("Progman", "Program Manager")
            'Detect if the current app is running in full screen
            Dim runningFullScreen As Boolean = False
            Dim appBounds As RECT
            Dim screenBounds As Rectangle
            Dim hWnd As IntPtr = GetForegroundWindow()
            'getText
            '    Dim text_len = GetWindowTextLength(hWnd)
          
            'get the dimensions of the active window
            If (hWnd <> Nothing) AndAlso Not hWnd.Equals(IntPtr.Zero) Then
                'Check we haven't picked up the desktop or the shell
                If Not (hWnd.Equals(desktopHandle2) OrElse hWnd.Equals(desktopHandle) OrElse hWnd.Equals(shellHandle)) Then
                    GetWindowRect(hWnd, appBounds)
                    'determine if window is fullscreen
                    screenBounds = Screen.FromHandle(hWnd).Bounds

                    If (appBounds.Bottom - appBounds.Top) = screenBounds.Height AndAlso (appBounds.Right - appBounds.Left) = screenBounds.Width Then
                       Return True
                    End If
                End If
            End If
            Return False
        End Function


    End Class

    '
    Public NotInheritable Class CPUCore
        Public Shared CoreWMI As ManagementObjectSearcher = New ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor")
        Public Shared Core As New CPUCounter
        Public Shared Function GetCoreUsage() As Single
            '  Return Helper.WmiGetValue("root\CIMV2", "Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime", 0)
            Return Core.getCPUUsage
        End Function

        Public Shared Function GetCoreSpeed() As Single
            Return Helper.WmiGetValue("root\CIMV2", "Win32_Processor", "CurrentClockSpeed", 0)
        End Function
        Public Shared Function GetMaxCoreSpeed() As Single
            Return Helper.WmiGetValue("root\CIMV2", "Win32_Processor", "MaxClockSpeed", 0)
        End Function
        Public Shared Function GetCoreName() As String
            Return Helper.WmiGetValue("root\CIMV2", "Win32_Processor", "Name", 0)
        End Function
        Public Shared Function GetSystemLastBoot() As Date
            Return ManagementDateTimeConverter.ToDateTime(Helper.WmiGetValue("root/CIMV2", "CIM_OperatingSystem", "LastBootUpTime", 0))
        End Function
        Public Shared Function GetSystemLogicalProcessor() As Integer
            Return Helper.WmiGetValue("root/CIMV2", "Win32_Processor", "NumberOfLogicalProcessors", 0)
        End Function
        Public Shared Function GetSystemProcesses() As Integer
            Return Helper.WmiGetValue("root/CIMV2", "CIM_OperatingSystem", "NumberOfProcesses", 0)
        End Function
        Public Shared Function GetSystemThreads() As Long
            Return Helper.WmiGetRowCount("root/CIMV2", "Win32_Thread")
        End Function
        Public Shared Function GetTempAccessible() As Boolean
            Try
                Return Helper.WmiGetValue("root\WMI", "MSAcpi_ThermalZoneTemperature", "Active", 0)
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Shared GetTempDataLast As Single
        Public Shared Function GetTempData() As Single
            Try : GetTempDataLast = Helper.WmiGetValue("root\WMI", "MSAcpi_ThermalZoneTemperature", "CurrentTemperature", 0) / 10
                Return GetTempDataLast
            Catch : Return 0 : End Try
        End Function
        Public Shared Function GetTempDataCritical() As Single
            Try : Return Helper.WmiGetValue("root\WMI", "MSAcpi_ThermalZoneTemperature", "CriticalTripPoint", 0) / 10
            Catch : Return 0 : End Try
        End Function
        Public Shared Function GetTempDataThrottle() As Single
            Try : Return Helper.WmiGetValue("root\WMI", "MSAcpi_ThermalZoneTemperature", "PassiveTripPoint", 0) / 10
            Catch : Return 0 : End Try
        End Function
        Public Shared Function GetTempDataRefresh() As Single
            Try : Return Helper.WmiGetValue("root\WMI", "MSAcpi_ThermalZoneTemperature", "SamplingPeriod", 0)
            Catch : Return 0 : End Try
        End Function
    End Class

    '
    Public NotInheritable Class Memory
        Public Shared Function getPhysicalFree()
            Return My.Computer.Info.AvailablePhysicalMemory
        End Function
        Public Shared Function getPhysicalTotal()
            Return My.Computer.Info.TotalPhysicalMemory
        End Function
        Public Shared Function getVirtualFree()
            Return My.Computer.Info.AvailableVirtualMemory
        End Function
        Public Shared Function getVirtualTotal()
            Return My.Computer.Info.TotalVirtualMemory
        End Function
        Public Shared Function getPageUsed()
            Dim x() As Object = Helper.WmiGetValue("root/CIMV2", "Win32_PageFileUsage", "CurrentUsage"), y As ULong = 0
            For Each i As ULong In x
                y += i : Next
            Return y * 1048576
        End Function
        Public Shared Function getPageTotal()
            Dim x() As Object = Helper.WmiGetValue("root/CIMV2", "Win32_PageFileUsage", "AllocatedBaseSize"), y As ULong = 1
            For Each i As ULong In x
                y += i : Next
            Return y * 1048576
        End Function
    End Class

End Class


Public NotInheritable Class Helper
    Private Shared HelperPC As New PerformanceCounter
    Private Shared HelperWMISearcher As New ManagementObjectSearcher
    Public Shared Function WmiGetRowCount(WMINamespace As String, WMIClass As String) As Integer
        Dim searcher As New ManagementObjectSearcher( _
                     WMINamespace, "SELECT * FROM " + WMIClass)
        Dim x = 0 ': searcher.Options.ReturnImmediately = True : searcher.Options.DirectRead = True
            For Each queryObj As ManagementObject In searcher.Get()
                x += 1
            Next
        Return x
    End Function
    Public Shared Function WmiGetValue(WMINamespace As String, WMIClass As String, Member As String, Optional ByVal Index As Integer = -1, Optional AddQuery As String = "") As Object
        Try
            Dim searcher As New ManagementObjectSearcher( _
                      WMINamespace, _
                      "SELECT " + Member + " FROM " + WMIClass + " " + AddQuery)
            Dim x = 0 ': searcher.Options.ReturnImmediately = True : searcher.Options.DirectRead = True
            If Index <> -1 Then
                For Each queryObj As ManagementObject In searcher.Get()
                    If x = Index Then Return queryObj(Member)
                    x += 1
                Next
            Else
                Dim y() = {}
                Dim yy = searcher.Get
                For s = 0 To yy.Count - 1
                    ReDim Preserve y(y.Length)
                    y(y.Length - 1) = CType(yy(s), ManagementObject).GetPropertyValue(Member)
                Next
                Return y
            End If
        Catch
        End Try
        Return Nothing
    End Function
    Public Shared Function PCGetValue(ByVal category As String, ByVal counter As String, Optional ByVal instanceidx As Integer = -1) As Single
        HelperPC.CategoryName = category
        HelperPC.CounterName = counter
        Dim PCC As New PerformanceCounterCategory(category)
        Dim x As Single = 0
        If (instanceidx = -1) Then
            For Each i In PCC.GetInstanceNames
                HelperPC.InstanceName = i
                HelperPC.NextValue()
                x += HelperPC.NextValue
            Next
        Else
            HelperPC.InstanceName = PCC.GetInstanceNames(instanceidx)
            HelperPC.NextValue()
            System.Threading.Thread.Sleep(1000)
            x = HelperPC.NextValue
        End If
        Return x

    End Function

    Public Shared Function FixVoltage(Voltage As Single) As Single
        If Voltage < 4.0F Then
            Voltage *= 3.25F
        End If
        Return Voltage
    End Function
    Public Shared Function FixCurrent(Current As Integer) As Integer
        Return Current
    End Function
    Public Shared Function FixBytes(ByVal bytes As Long, Optional ByVal comma As Integer = 0, Optional ByVal usebit As Boolean = False) As String
        If Not usebit Then
            Select Case bytes.ToString.Length
                Case Is < 4
                    Return Microsoft.VisualBasic.FormatNumber(bytes, 0, -1, 0, -1) & " B"
                Case Is < 7
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1024, comma, -1, 0, -1) & " KB"
                Case Is < 10
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1048576, comma, -1, 0, -1) & " MB"
                Case Is < 13
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1073741824, comma, -1, 0, -1) & " GB"
                Case Else
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1099511627776, comma, -1, 0, -1) & " TB"
            End Select
        Else
            bytes *= 8
            Select Case bytes.ToString.Length
                Case Is < 4
                    Return Microsoft.VisualBasic.FormatNumber(bytes, 0, -1, 0, -1) & " b"
                Case Is < 7
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1024, comma, -1, 0, -1) & " Kb"
                Case Is < 10
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1048576, comma, -1, 0, -1) & " Mb"
                Case Is < 13
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1073741824, comma, -1, 0, -1) & " Gb"
                Case Else
                    Return Microsoft.VisualBasic.FormatNumber(bytes / 1099511627776, comma, -1, 0, -1) & " Tb"
            End Select
        End If
    End Function
    Public Shared Function BitmapToByteArray(bitmap As Bitmap) As Byte()
        Dim bmd As BitmapData = bitmap.LockBits(New Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.[ReadOnly], PixelFormat.Format32bppArgb)
        Dim bytes As Byte() = New Byte(bmd.Height * bmd.Stride - 1) {}
        Marshal.Copy(bmd.Scan0, bytes, 0, bmd.Height * bmd.Stride)
        bitmap.UnlockBits(bmd)
        Return bytes
    End Function

    Public Shared Function GetBrightness(bitmap As Bitmap) As Integer
        Dim bytes As Byte() = BitmapToByteArray(bitmap)
        Dim bright((bytes.Length / 4) - 1) As Integer
        Dim count As Integer = 0
        Dim i As Integer = 0
        While i < bytes.Length
            Dim r As Byte = bytes(i + 2), g As Byte = bytes(i + 1), b As Byte = bytes(i)
            bright(i \ 4) = CType(Math.Round((0.299 * r + 0.5876 * g + 0.114 * b)), Byte)

            i += 4
        End While
        Return bright.Average()
    End Function
    Public Shared Function FixDegree(ByVal degree As Long, Optional ByVal isCelcius As Boolean = True) As String
        If (isCelcius) Then
            Return (degree - 273).ToString("0") & " °C"
        Else
            Return ((degree - 273) / 5 * 9 + 32).ToString("0") & " °F"
        End If
    End Function


    Public Shared Function GetIconResource(ByVal Type As IconTypes, ByVal idx As Integer) As Image
        Return My.Resources.ResourceManager.GetObject(Type.ToString() & "_" & idx.ToString)
    End Function
    Enum IconTypes
        Audio = 0
        Batt = 1
        Core = 2
        Disk = 3
        Key_Caps = 4
        Key_Num = 5
        Key_Scroll = 6
        Light = 7
        Memo = 8
        Temp = 9
        WiFi = 10
    End Enum
End Class
Namespace Watchers
    Public Class LightWatcher
        Public Event LightChange(sender As Object, e As Management.EventArrivedEventArgs)
        WithEvents Watcher As ManagementEventWatcher

        Public Sub New()
            Watcher = New ManagementEventWatcher("root/WMI", "Select * From WmiMonitorBrightnessEvent")
            Watcher.Start()
        End Sub
        Public Sub Dispose()
            Watcher.Stop()
        End Sub
        Private Sub Watcher_EventArrived(sender As Object, e As EventArrivedEventArgs) Handles Watcher.EventArrived
            RaiseEvent LightChange(sender, e)
        End Sub
    End Class
    Public Delegate Sub BatteryChangeEventHandler(WithPower As Boolean)
    Public Class DeviceWatcher
        Dim last As String = "      "
        Public Event DeviceChange(sender As Object, e As Management.EventArrivedEventArgs)
        WithEvents Watcher As ManagementEventWatcher

        Public Sub New()
            Watcher = New ManagementEventWatcher("root/CIMV2", "Select * From Win32_DeviceChangeEvent")
            Watcher.Start()
        End Sub
        Public Sub Dispose()
            Watcher.Stop()
        End Sub
        Private Sub Watcher_EventArrived(sender As Object, e As EventArrivedEventArgs) Handles Watcher.EventArrived
            Dim y As String = e.NewEvent("TIME_CREATED")
            Dim z = CStr(y.Take(y.Length - 5).ToArray)
            If CStr(last.Take(last.Length - 5).ToArray) <> CStr(y.Take(y.Length - 5).ToArray) Then
                Dim x = e.NewEvent("TIME_CREATED")
                last = x
                RaiseEvent DeviceChange(sender, e)
            End If
        End Sub
    End Class
    Public Delegate Sub DeviceChangeEventHandler(WithPower As Boolean)
    Public Class BatteryWatcher

        Public Event BatteryChange(ByVal WithPower As Boolean)
        Private LastCheck As Single
        Private LastNames As Integer

        Public Sub New()
            AddHandler Microsoft.Win32.SystemEvents.PowerModeChanged, AddressOf Watcher_EventArrived
            LastNames = Info.Battery.GetBatteryNames.Length
            If LastNames > 0 Then LastCheck = GetRemSum()
        End Sub
        Private Function GetRemSum() As Single
            Dim x As Single = 0
            Dim y = CType(Helper.WmiGetValue("\root\WMI", "BatteryStatus", "RemainingCapacity"), Object())
            For Each i In y
                x += i
            Next
            Return x
        End Function
        Public Sub Check()
            If Info.Battery.GetBatteryNames.Length <> LastNames Then
                RaiseEvent BatteryChange(True)
                LastNames = Info.Battery.GetBatteryNames.Length
                Exit Sub
            End If

            Dim x As Integer = GetRemSum()
            If LastCheck <> x Then
                RaiseEvent BatteryChange(False)
                LastCheck = x
            End If
        End Sub
        Private Sub Watcher_EventArrived(sender As Object, e As Microsoft.Win32.PowerModeChangedEventArgs)
            RaiseEvent BatteryChange(True)
        End Sub
    End Class

End Namespace



