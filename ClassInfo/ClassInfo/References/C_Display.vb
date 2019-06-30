Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Class C_Display

    

    Public NotInheritable Class Tuning
        Public Shared Function GetBrightness() As Integer
            On Error GoTo q
            Return Helper.WmiGetValue("root\WMI", "WmiMonitorBrightness", "CurrentBrightness", 0)
            '     Exit Function
q:
            Return -1
        End Function
        Public Shared Function IsSupported() As Boolean
            Dim x = GetBrightness()
            Return x <> -1
        End Function
        Public Shared Sub SetBrightness(targetBrightness As Byte)
            Dim managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\WMI", "SELECT * FROM WmiMonitorBrightnessMethods")
            Dim managementObjectCollection As ManagementObjectCollection = managementObjectSearcher.[Get]()
            Using enumerator As ManagementObjectCollection.ManagementObjectEnumerator = managementObjectCollection.GetEnumerator()
                If enumerator.MoveNext() Then
                    Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
                    managementObject.InvokeMethod("WmiSetBrightness", New Object() {4294967295, targetBrightness})
                End If
            End Using
        End Sub
        '
        Private Declare Function GetDeviceGamma Lib "gdi32.dll" Alias "GetDeviceGammaRamp" (hdc As IntPtr, lpRamp As UShort()) As Boolean
        Private Declare Function SetDeviceGamma Lib "gdi32.dll" Alias "SetDeviceGammaRamp" (hdc As IntPtr, lpRamp As UShort()) As Boolean
        Private Declare Function GetDC Lib "User32.dll" (hWnd As IntPtr) As IntPtr
        Private Declare Function ReleaseDC Lib "User32.dll" (hWnd As IntPtr, hdc As IntPtr) As Integer
        Private Shared _RampSaved As UShort() = New UShort(768 - 1) {}

        Public Shared Function GetGamma() As Single
            Dim dC As IntPtr = GetDC(IntPtr.Zero)
            GetDeviceGamma(dC, _RampSaved)
            ReleaseDC(IntPtr.Zero, dC)
            Dim array() As Single = New Single() {1.0F, 1.0F, 1.0F}
            For i As Integer = 0 To 3 - 1
                Dim num As Single = 0.0F
                Dim num2 As Integer = 0
                Dim num3 As Integer = 256 * i
                Dim num4 As Integer = num3 + 256
                For j As Integer = num3 To num4 - 1
                    If j <> 0 AndAlso _RampSaved(j) <> 0 Then
                        Dim d As Double = CDec((j Mod 256)) / 256.0
                        Dim d2 As Double = CDec(_RampSaved(j)) / 65536.0
                        Dim num5 As Single = CSng((Math.Log(d2) / Math.Log(d)))
                        num += num5
                        num2 += 1
                    End If
                Next
                array(i) = num / CSng(num2)
            Next
            Return array(0)
        End Function

        Public Shared Function SetGamma(Gamma As Single) As Boolean
            Dim array As UShort() = New UShort(768 - 1) {}
            For i As Integer = 0 To 256 - 1
                Dim arg_74_0 As UShort() = array
                Dim arg_74_1 As Integer = i
                Dim arg_71_0 As UShort() = array
                Dim arg_71_1 As Integer = i + 256
                Dim arg_6C_0 As UShort() = array
                Dim arg_6C_1 As Integer = i + 512
                Dim expr_6A As UShort = CUShort(Math.Min(65535.0, Math.Max(0.0, Math.Pow(CDec((CSng((CDec((i + 1)) / 256.0)))), CDec(Gamma)) * 65535.0 + 0.5)))
                Dim num As UShort = expr_6A
                arg_6C_0(arg_6C_1) = expr_6A
                Dim expr_6E As UShort = num
                Dim num2 As UShort = expr_6E
                arg_71_0(arg_71_1) = expr_6E
                arg_74_0(arg_74_1) = num2
            Next
            Dim dC As IntPtr = GetDC(IntPtr.Zero)
            SetDeviceGamma(dC, array)
            ReleaseDC(IntPtr.Zero, dC)
            Return True
        End Function

    End Class
End Class
'NotInheritable Class DisplayManager
'    NotInheritable Class SafeNativeMethods
'        Private Sub New()
'        End Sub
'        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
'        Public Structure DEVMODE
'            ' You can define the following constant
'            ' but OUTSIDE the structure because you know
'            ' that size and layout of the structure is very important
'            ' CCHDEVICENAME = 32 = 0x50
'            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
'            Public dmDeviceName As String
'            ' In addition you can define the last character array
'            ' as following:
'            '[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
'            'public Char[] dmDeviceName;

'            ' After the 32-bytes array
'            <MarshalAs(UnmanagedType.U2)> _
'            Public dmSpecVersion As UInt16

'            <MarshalAs(UnmanagedType.U2)> _
'            Public dmDriverVersion As UInt16

'            <MarshalAs(UnmanagedType.U2)> _
'            Public dmSize As UInt16

'            <MarshalAs(UnmanagedType.U2)> _
'            Public dmDriverExtra As UInt16

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmFields As UInt32

'            Public dmPosition As POINTL

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmDisplayOrientation As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmDisplayFixedOutput As UInt32

'            <MarshalAs(UnmanagedType.I2)> _
'            Public dmColor As Int16

'            <MarshalAs(UnmanagedType.I2)> _
'            Public dmDuplex As Int16

'            <MarshalAs(UnmanagedType.I2)> _
'            Public dmYResolution As Int16

'            <MarshalAs(UnmanagedType.I2)> _
'            Public dmTTOption As Int16

'            <MarshalAs(UnmanagedType.I2)> _
'            Public dmCollate As Int16

'            ' CCHDEVICENAME = 32 = 0x50
'            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
'            Public dmFormName As String
'            ' Also can be defined as
'            '[MarshalAs(UnmanagedType.ByValArray, 
'            '    SizeConst = 32, ArraySubType = UnmanagedType.U1)]
'            'public Byte[] dmFormName;

'            <MarshalAs(UnmanagedType.U2)> _
'            Public dmLogPixels As UInt16

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmBitsPerPel As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmPelsWidth As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmPelsHeight As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmDisplayFlags As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmDisplayFrequency As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmICMMethod As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmICMIntent As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmMediaType As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmDitherType As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmReserved1 As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmReserved2 As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmPanningWidth As UInt32

'            <MarshalAs(UnmanagedType.U4)> _
'            Public dmPanningHeight As UInt32

'            ''' <summary>
'            ''' Initializes the structure variables.
'            ''' </summary>
'            Public Sub Initialize()
'                Me.dmDeviceName = New String(New Char(31) {})
'                Me.dmFormName = New String(New Char(31) {})
'                Me.dmSize = CType(Marshal.SizeOf(Me), UShort)
'            End Sub
'        End Structure

'        ' 8-bytes structure
'        <StructLayout(LayoutKind.Sequential)> _
'        Public Structure POINTL
'            Public x As Int32
'            Public y As Int32
'        End Structure



'        ' display device
'        ' graphics mode
'        <DllImport("User32.dll", SetLastError:=True, BestFitMapping:=False, ThrowOnUnmappableChar:=True)> _
'        Public Shared Function EnumDisplaySettings(<MarshalAs(UnmanagedType.LPTStr)> lpszDeviceName As [String], <MarshalAs(UnmanagedType.U4)> iModeNum As Int32, <[In], Out> ByRef lpDevMode As DEVMODE) As <MarshalAs(UnmanagedType.Bool)> [Boolean]
'            ' graphics mode settings
'        End Function

'        Public Const ENUM_CURRENT_SETTINGS As Integer = -1
'        Public Const DMDO_DEFAULT As Integer = 0
'        Public Const DMDO_90 As Integer = 1
'        Public Const DMDO_180 As Integer = 2
'        Public Const DMDO_270 As Integer = 3



'        <DllImport("User32.dll", SetLastError:=True, BestFitMapping:=False, ThrowOnUnmappableChar:=True)> _
'        Public Shared Function ChangeDisplaySettings(<[In], Out> ByRef lpDevMode As DEVMODE, <MarshalAs(UnmanagedType.U4)> dwflags As UInteger) As <MarshalAs(UnmanagedType.I4)> Integer
'        End Function



'        <DllImport("kernel32.dll", SetLastError:=True, BestFitMapping:=False, ThrowOnUnmappableChar:=True)> _
'        Public Shared Function FormatMessage(<MarshalAs(UnmanagedType.U4)> dwFlags As UInteger, <MarshalAs(UnmanagedType.U4)> lpSource As UInteger, <MarshalAs(UnmanagedType.U4)> dwMessageId As UInteger, <MarshalAs(UnmanagedType.U4)> dwLanguageId As UInteger, <MarshalAs(UnmanagedType.LPTStr)> ByRef lpBuffer As String, <MarshalAs(UnmanagedType.U4)> nSize As UInteger, _
'        <MarshalAs(UnmanagedType.U4)> Arguments As UInteger) As <MarshalAs(UnmanagedType.Bool)> UInteger
'        End Function

'        Public Const FORMAT_MESSAGE_FROM_HMODULE As UInteger = &H800

'        Public Const FORMAT_MESSAGE_ALLOCATE_BUFFER As UInteger = &H100
'        Public Const FORMAT_MESSAGE_IGNORE_INSERTS As UInteger = &H200
'        Public Const FORMAT_MESSAGE_FROM_SYSTEM As UInteger = &H1000
'        Public Const FORMAT_MESSAGE_FLAGS As UInteger = FORMAT_MESSAGE_ALLOCATE_BUFFER Or FORMAT_MESSAGE_IGNORE_INSERTS Or FORMAT_MESSAGE_FROM_SYSTEM
'    End Class
'    Enum Orientation
'        [Default] = 0
'        Clockwise90 = 1
'        Clockwise180 = 2
'        Clockwise270 = 3
'    End Enum

'    Structure DisplaySettings
'        Public Property Index() As Integer
'            Get
'                Return m_Index
'            End Get
'            Set(value As Integer)
'                m_Index = value
'            End Set
'        End Property
'        Private m_Index As Integer
'        Public Property Width() As Integer
'            Get
'                Return m_Width
'            End Get
'            Set(value As Integer)
'                m_Width = value
'            End Set
'        End Property
'        Private m_Width As Integer
'        Public Property Height() As Integer
'            Get
'                Return m_Height
'            End Get
'            Set(value As Integer)
'                m_Height = value
'            End Set
'        End Property
'        Private m_Height As Integer
'        Public Property Orientation() As Orientation
'            Get
'                Return m_Orientation
'            End Get
'            Set(value As Orientation)
'                m_Orientation = value
'            End Set
'        End Property
'        Private m_Orientation As Orientation
'        Public Property BitCount() As Integer
'            Get
'                Return m_BitCount
'            End Get
'            Set(value As Integer)
'                m_BitCount = value
'            End Set
'        End Property
'        Private m_BitCount As Integer
'        Public Property Frequency() As Integer
'            Get
'                Return m_Frequency
'            End Get
'            Set(value As Integer)
'                m_Frequency = value
'            End Set
'        End Property
'        Private m_Frequency As Integer

'        Public Overrides Function Equals(obj As Object) As Boolean
'            Return Me = obj
'        End Function

'        Public Overrides Function ToString() As String
'            Return String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0} x {1}, {2} Bit, {3} Hz", Width, Height, BitCount, _
'                Frequency)

'        End Function

'        Shared Operator =(ByVal l1 As DisplaySettings, ByVal l2 As DisplaySettings) As Boolean
'            Return ((l1.m_Height = l2.m_Height) AndAlso (l1.m_Width = l2.m_Width)) AndAlso ((l1.m_Frequency = l2.m_Frequency) AndAlso (l1.m_BitCount = l2.m_BitCount))
'        End Operator
'        Shared Operator <>(ByVal l1 As DisplaySettings, ByVal l2 As DisplaySettings) As Boolean
'            Return Not (((l1.m_Height = l2.m_Height) AndAlso (l1.m_Width = l2.m_Width)) AndAlso ((l1.m_Frequency = l2.m_Frequency) AndAlso (l1.m_BitCount = l2.m_BitCount)))
'        End Operator
'    End Structure

'    Enum DisplayChangeResult
'        ''' <summary>
'        ''' Windows XP: The settings change was unsuccessful because system is DualView capable.
'        ''' </summary>
'        BadDualView = -6
'        ''' <summary>
'        ''' An invalid parameter was passed in. This can include an invalid flag or combination of flags.
'        ''' </summary>
'        BadParam = -5
'        ''' <summary>
'        ''' An invalid set of flags was passed in.
'        ''' </summary>
'        BadFlags = -4
'        ''' <summary>
'        ''' Windows NT/2000/XP: Unable to write settings to the registry.
'        ''' </summary>
'        NotUpdated = -3
'        ''' <summary>
'        ''' The graphics mode is not supported.
'        ''' </summary>
'        BadMode = -2
'        ''' <summary>
'        ''' The display driver failed the specified graphics mode.
'        ''' </summary>
'        Failed = -1
'        ''' <summary>
'        ''' The settings change was successful.
'        ''' </summary>
'        Successful = 0
'        ''' <summary>
'        ''' The computer must be restarted in order for the graphics mode to work.
'        ''' </summary>
'        Restart = 1
'    End Enum

'    Private Sub New()
'    End Sub
'    ''' <summary>
'    ''' Returns a DisplaySettings object encapsulates the current display settings.
'    ''' </summary>
'    Public Shared Function GetCurrentSettings() As DisplaySettings
'        Return CreateDisplaySettingsObject(-1, GetDeviceMode())
'    End Function

'    ''' <summary>
'    ''' Changes the current display settings with the new settings provided. May throw InvalidOperationException if failed. Check the exception message for more details.
'    ''' </summary>
'    ''' <param name="set">The new settings.</param>
'    ''' <remarks>
'    ''' Internally calls ChangeDisplaySettings() native function.
'    ''' </remarks>
'    Public Shared Sub SetDisplaySettings([set] As DisplaySettings)
'        Dim mode As SafeNativeMethods.DEVMODE = GetDeviceMode()

'        mode.dmPelsWidth = CType([set].Width, UInteger)
'        mode.dmPelsHeight = CType([set].Height, UInteger)
'        mode.dmDisplayOrientation = CType([set].Orientation, UInteger)
'        mode.dmBitsPerPel = CType([set].BitCount, UInteger)
'        mode.dmDisplayFrequency = CType([set].Frequency, UInteger)

'        Dim result As DisplayChangeResult = CType(SafeNativeMethods.ChangeDisplaySettings(mode, 0), DisplayChangeResult)

'        Dim msg As String = Nothing
'        Select Case result
'            Case DisplayChangeResult.BadDualView
'                msg = "The settings change was unsuccessful because system is DualView capable."
'                Exit Select
'            Case DisplayChangeResult.BadParam
'                msg = "An invalid parameter was passed in. This can include an invalid flag or combination of flags."
'                Exit Select
'            Case DisplayChangeResult.BadFlags
'                msg = "An invalid set of flags was passed in."
'                Exit Select
'            Case DisplayChangeResult.NotUpdated
'                msg = "Unable to write settings to the registry."
'                Exit Select
'            Case DisplayChangeResult.BadMode
'                msg = "The graphics mode is not supported."
'                Exit Select
'            Case DisplayChangeResult.Failed
'                msg = "The display driver failed the specified graphics mode."
'                Exit Select
'            Case DisplayChangeResult.Restart
'                msg = "The computer must be restarted in order for the graphics mode to work."
'                Exit Select
'        End Select

'        If Not (msg Is Nothing) Then
'            Throw New InvalidOperationException(msg)
'        End If
'    End Sub

'    ''' <summary>
'    ''' Enumerates all supported display modes.
'    ''' </summary>
'    ''' <remarks>
'    ''' Internally calls EnumDisplaySettings() native function.
'    ''' Because of the nature of EnumDisplaySettings() it calls it many times and uses the <code>yield return</code> statement to simulate an enumerator.
'    ''' </remarks>
'    Public Shared Function GetModesEnumerator() As DisplaySettings()
'        Dim mode As New SafeNativeMethods.DEVMODE()

'        mode.Initialize()

'        Dim idx As Integer = 0
'        Dim x As DisplaySettings() = {}
'        While SafeNativeMethods.EnumDisplaySettings(Nothing, idx, mode)
'            ReDim Preserve x(x.Length)
'            x(x.Length - 1) = CreateDisplaySettingsObject(Math.Max(Threading.Interlocked.Increment(idx), idx - 1), mode)
'        End While
'        Return x
'    End Function

'    ''' <summary>
'    ''' Rotates the screen from its current location by 90 degrees either clockwise or anti-clockwise.
'    ''' </summary>
'    Public Shared Sub RotateScreen(direction As Orientation)
'        Dim x As DisplaySettings = DisplayManager.GetCurrentSettings()

'        If direction <> x.Orientation Then
'            If (x.Orientation = direction + 1) OrElse (x.Orientation = direction - 1) Then
'                Dim tmp As Integer = x.Height
'                x.Height = x.Width
'                x.Width = tmp
'            End If
'            x.Orientation = direction

'            SetDisplaySettings(x)
'        End If
'    End Sub
'    Public Shared Sub SetDisplayScreenWithRotate(ByVal setting As DisplaySettings, ByVal direction As Orientation)
'        Dim x As DisplaySettings = setting

'        If direction <> x.Orientation Then
'            If (x.Orientation = direction + 1) OrElse (x.Orientation = direction - 1) Then
'                Dim tmp As Integer = x.Height
'                x.Height = x.Width
'                x.Width = tmp
'            End If
'            x.Orientation = direction

'            SetDisplaySettings(x)
'        End If
'    End Sub

'    ''' <summary>
'    ''' A private helper methods used to derive a DisplaySettings object from the DEVMODE structure.
'    ''' </summary>
'    ''' <param name="idx">The mode index attached with the settings. Starts form zero. Is -1 for the current settings.</param>
'    ''' <param name="mode">The current DEVMODE object represents the display information to derive the DisplaySettings object from.</param>
'    Private Shared Function CreateDisplaySettingsObject(idx As Integer, mode As SafeNativeMethods.DEVMODE) As DisplaySettings
'        Return New DisplaySettings() With { _
'            .Index = idx, _
'             .Width = CType(mode.dmPelsWidth, Integer), _
'             .Height = CType(mode.dmPelsHeight, Integer), _
'             .Orientation = CType(mode.dmDisplayOrientation, Orientation), _
'             .BitCount = CType(mode.dmBitsPerPel, Integer), _
'             .Frequency = CType(mode.dmDisplayFrequency, Integer) _
'        }
'    End Function

'    ''' <summary>
'    ''' A private helper method used to retrieve current display settings as a DEVMODE object.
'    ''' </summary>
'    ''' <remarks>
'    ''' Internally calls EnumDisplaySettings() native function with the value ENUM_CURRENT_SETTINGS (-1) to retrieve the current settings.
'    ''' </remarks>
'    Private Shared Function GetDeviceMode() As SafeNativeMethods.DEVMODE
'        Dim mode As New SafeNativeMethods.DEVMODE()

'        mode.Initialize()

'        If SafeNativeMethods.EnumDisplaySettings(Nothing, SafeNativeMethods.ENUM_CURRENT_SETTINGS, mode) Then
'            Return mode
'        Else
'            Throw New InvalidOperationException(GetLastError())
'        End If
'    End Function

'    Private Shared Function GetLastError() As String
'        Dim err As Integer = Marshal.GetLastWin32Error()

'        Dim msg As String = ""

'        If SafeNativeMethods.FormatMessage(SafeNativeMethods.FORMAT_MESSAGE_FLAGS, SafeNativeMethods.FORMAT_MESSAGE_FROM_HMODULE, CType(err, UInteger), 0, msg, 0, _
'            0) = 0 Then
'            Return "Fatal error."
'        Else
'            Return msg
'        End If
'    End Function
'End Class