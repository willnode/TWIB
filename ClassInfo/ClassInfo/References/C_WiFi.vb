Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.ComponentModel
Imports System.Text

Namespace C_WiFi
    Public Class Constants
        Public Const MAX_ADAPTER_NAME As Integer = 128

        Public Const MAX_HOSTNAME_LEN As Integer = 128

        Public Const MAX_DOMAIN_NAME_LEN As Integer = 128

        Public Const MAX_SCOPE_ID_LEN As Integer = 256

        Public Const MAX_ADAPTER_DESCRIPTION_LENGTH As Integer = 128

        Public Const MAX_ADAPTER_NAME_LENGTH As Integer = 256

        Public Const MAX_ADAPTER_ADDRESS_LENGTH As Integer = 8

        Public Const DEFAULT_MINIMUM_ENTITIES As Integer = 32

        Public Const NO_ERROR As Integer = 0

        Public Const ERROR_BUFFER_OVERFLOW As Integer = 111

        Public Const ERROR_INSUFFICIENT_BUFFER As Integer = 122

        <DebuggerNonUserCode()>
        Public Sub New()
        End Sub
    End Class
    Public Class Iphlapi
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Public Structure MIB_IFTABLE
            Public dwNumEntries As Integer

            Public rows As Iphlapi.MIB_IFROW()
        End Structure

        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Public Structure MIB_IFROW
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)>
            Public wszName As String

            Public dwIndex As UInteger

            Public dwType As UInteger

            Public dwMtu As UInteger

            Public dwSpeed As UInteger

            Public dwPhysAddrLen As UInteger

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)>
            Public bPhysAddr As Byte()

            Public dwAdminStatus As UInteger

            Public dwOperStatus As UInteger

            Public dwLastChange As UInteger

            Public dwInOctets As UInteger

            Public dwInUcastPkts As UInteger

            Public dwInNUcastPkts As UInteger

            Public dwInDiscards As UInteger

            Public dwInErrors As UInteger

            Public dwInUnknownProtos As UInteger

            Public dwOutOctets As UInteger

            Public dwOutUcastPkts As UInteger

            Public dwOutNUcastPkts As UInteger

            Public dwOutDiscards As UInteger

            Public dwOutErrors As UInteger

            Public dwOutQLen As UInteger

            Public dwDescrLen As Integer

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)>
            Public bDescr As Byte()
        End Structure

        Public Const MAX_INTERFACE_NAME_LEN As Integer = 256

        Public Const MAXLEN_PHYSADDR As Integer = 8

        Public Const MAXLEN_IFDESCR As Integer = 256

        <DebuggerNonUserCode()>
        Public Sub New()
        End Sub

        Public Declare Function GetIfTable Lib "iphlpapi.dll" (pIfTable As IntPtr, ByRef pdwSize As UInteger, bOrder As Boolean) As Integer

        Public Declare Function GetIfEntry Lib "iphlpapi.dll" (ByRef pIfRow As Iphlapi.MIB_IFROW) As Integer

        Public Shared Function getIfRows() As Iphlapi.MIB_IFROW()
            Dim num As UInteger = 0
            Dim intPtr As IntPtr = intPtr.Zero
            Dim ifTable As Integer = Iphlapi.GetIfTable(intPtr.Zero, num, False)
            Dim flag As Boolean = ifTable = 122
            If Not flag Then
                Throw New Win32Exception(ifTable)
            End If
            ' The following expression was wrapped in a checked-statement
            intPtr = Marshal.AllocHGlobal(CInt(num))
            ifTable = Iphlapi.GetIfTable(intPtr, num, False)
            flag = (ifTable <> 0)
            If flag Then
                Throw New Win32Exception(ifTable)
            End If
            Dim num2 As Integer = Marshal.ReadInt32(intPtr)
            Dim num3 As Integer = intPtr.ToInt32() + Marshal.SizeOf(GetType(Integer))
            Dim array As Iphlapi.MIB_IFROW() = New Iphlapi.MIB_IFROW(num2 - 1 + 1 - 1) {}
            Dim i As Integer = 0
            While i < num2
                Dim arg_C9_0_cp_0 As Iphlapi.MIB_IFROW() = array
                Dim arg_C9_0_cp_1 As Integer = i
                Dim expr_B0 As Object = Marshal.PtrToStructure(CType(num3, IntPtr), GetType(Iphlapi.MIB_IFROW))
                Dim mIB_IFROW As New Iphlapi.MIB_IFROW
                arg_C9_0_cp_0(arg_C9_0_cp_1) = (If((expr_B0 IsNot Nothing), (CType(expr_B0, Iphlapi.MIB_IFROW)), mIB_IFROW))
                num3 += Marshal.SizeOf(GetType(Iphlapi.MIB_IFROW))
                Math.Max(Interlocked.Increment(i), i - 1)
            End While
            Marshal.FreeHGlobal(intPtr)
            Return array
        End Function
    End Class
    Friend Class Ipifcons
        Public Const MIB_IF_TYPE_OTHER As Integer = 1

        Public Const MIB_IF_TYPE_ETHERNET As Integer = 6

        Public Const MIB_IF_TYPE_TOKENRING As Integer = 9

        Public Const MIB_IF_TYPE_FDDI As Integer = 15

        Public Const MIB_IF_TYPE_PPP As Integer = 23

        Public Const MIB_IF_TYPE_LOOPBACK As Integer = 24

        Public Const MIB_IF_TYPE_SLIP As Integer = 28

        Public Const MIB_IF_TYPE_IEEE80211 As Integer = 71

        Public Const MIB_IF_OPER_STATUS_NON_OPERATIONAL As Integer = 0

        Public Const MIB_IF_OPER_STATUS_UNREACHABLE As Integer = 1

        Public Const MIB_IF_OPER_STATUS_DISCONNECTED As Integer = 2

        Public Const MIB_IF_OPER_STATUS_CONNECTING As Integer = 3

        Public Const MIB_IF_OPER_STATUS_CONNECTED As Integer = 4

        Public Const MIB_IF_OPER_STATUS_OPERATIONAL As Integer = 5

        <DebuggerNonUserCode()>
        Public Sub New()
        End Sub
    End Class
    Public Class NetworkAdapter
        Private Const POWER_2_31 As UInteger = 4294967295

        Private mib_ifrow As Iphlapi.MIB_IFROW

        Private wrap_dwInOctets As Byte

        Private wrap_dwOutOctets As Byte

        Private wrap_dwInUcastPkts As Byte

        Private wrap_dwOutUcastPkts As Byte

        Private wrap_dwInNUcastPkts As Byte

        Private wrap_dwOutNUcastPkts As Byte

        Private bytesSentStart As Single

        Private sentBytesPrev As Single

        Private bytesRecvStart As Single

        Private recvBytesPrev As Single

        Private UpacketRecvStart As Single

        Private recvUPacketPrev As Single

        Private UpacketSentStart As Single

        Private sentUPacketPrev As Single

        Private NUpacketRecvStart As Single

        Private recvNUPacketPrev As Single

        Private NUpacketSentStart As Single

        Private sentNUPacketPrev As Single

        Private monitoring As Boolean

        Public TotalUp As Single

        Public TotalDown As Single

        Public SpeedUp As Single

        Public SpeedDown As Single

        Public PacketU_TotalUp As Single

        Public PacketU_TotalDown As Single

        Public PacketU_SpeedUp As Single

        Public PacketU_SpeedDown As Single

        Public PacketNU_TotalUp As Single

        Public PacketNU_TotalDown As Single

        Public PacketNU_SpeedUp As Single

        Public PacketNU_SpeedDown As Single

        Public Name As String

        Public Sub New(p_mib_ifrow As Iphlapi.MIB_IFROW)
            Me.wrap_dwInOctets = 0
            Me.wrap_dwOutOctets = 0
            Me.wrap_dwInUcastPkts = 0
            Me.wrap_dwOutUcastPkts = 0
            Me.wrap_dwInNUcastPkts = 0
            Me.wrap_dwOutNUcastPkts = 0
            Me.mib_ifrow = p_mib_ifrow
            ' The following expression was wrapped in a checked-expression
            Me.Name = Encoding.ASCII.GetString(Me.mib_ifrow.bDescr, 0, Me.mib_ifrow.dwDescrLen - 1)
        End Sub

        Protected Sub RefreshInfo()
            While Me.monitoring
                Try
                    Dim ifEntry As Integer = Iphlapi.GetIfEntry(Me.mib_ifrow)
                    ' The following expression was wrapped in a checked-statement
                    Dim flag As Boolean = 4294967295 * CUInt(Me.wrap_dwInOctets) + Me.mib_ifrow.dwInOctets < Me.TotalDown
                    If flag Then
                        Me.wrap_dwInOctets += 1
                    End If
                    Me.TotalDown = 4294967295 * CUInt(Me.wrap_dwInOctets) + Me.mib_ifrow.dwInOctets
                    flag = (4294967295 * CUInt(Me.wrap_dwOutOctets) + Me.mib_ifrow.dwOutOctets < Me.TotalUp)
                    If flag Then
                        Me.wrap_dwOutOctets += 1
                    End If
                    Me.TotalUp = 4294967295 * CUInt(Me.wrap_dwOutOctets) + Me.mib_ifrow.dwOutOctets
                    flag = (4294967295 * CUInt(Me.wrap_dwInUcastPkts) + Me.mib_ifrow.dwInUcastPkts < Me.PacketU_TotalDown)
                    If flag Then
                        Me.wrap_dwInUcastPkts += 1
                    End If
                    Me.PacketU_TotalDown = 4294967295 * CUInt(Me.wrap_dwInUcastPkts) + Me.mib_ifrow.dwInUcastPkts
                    flag = (4294967295 * CUInt(Me.wrap_dwOutUcastPkts) + Me.mib_ifrow.dwOutUcastPkts < Me.PacketU_TotalUp)
                    If flag Then
                        Me.wrap_dwOutUcastPkts += 1
                    End If
                    Me.PacketU_TotalUp = 4294967295 * CUInt(Me.wrap_dwOutUcastPkts) + Me.mib_ifrow.dwOutUcastPkts
                    flag = (4294967295 * CUInt(Me.wrap_dwInNUcastPkts) + Me.mib_ifrow.dwInNUcastPkts < Me.PacketNU_TotalDown)
                    If flag Then
                        Me.wrap_dwInNUcastPkts += 1
                    End If
                    Me.PacketNU_TotalDown = 4294967295 * CUInt(Me.wrap_dwInNUcastPkts) + Me.mib_ifrow.dwInNUcastPkts
                    flag = (4294967295 * CUInt(Me.wrap_dwOutNUcastPkts) + Me.mib_ifrow.dwOutNUcastPkts < Me.PacketNU_TotalUp)
                    If flag Then
                        Me.wrap_dwOutNUcastPkts += 1
                    End If
                    Me.PacketNU_TotalUp = 4294967295 * CUInt(Me.wrap_dwOutNUcastPkts) + Me.mib_ifrow.dwOutNUcastPkts
                    Me.SpeedDown = Me.TotalDown - Me.recvBytesPrev
                    Me.recvBytesPrev = Me.TotalDown
                    Me.SpeedUp = Me.TotalUp - Me.sentBytesPrev
                    Me.sentBytesPrev = Me.TotalUp
                    Me.PacketU_SpeedDown = Me.PacketU_TotalDown - Me.recvUPacketPrev
                    Me.recvUPacketPrev = Me.PacketU_TotalDown
                    Me.PacketU_SpeedUp = Me.PacketU_TotalUp - Me.sentUPacketPrev
                    Me.sentUPacketPrev = Me.PacketU_TotalUp
                    Me.PacketNU_SpeedDown = Me.PacketNU_TotalDown - Me.recvNUPacketPrev
                    Me.recvNUPacketPrev = Me.PacketNU_TotalDown
                    Me.PacketNU_SpeedUp = Me.PacketNU_TotalUp - Me.sentNUPacketPrev
                    Me.sentNUPacketPrev = Me.PacketNU_TotalUp
                Catch expr_2B2 As Exception
          
                End Try
                Thread.Sleep(999)
            End While
        End Sub

        Public Sub startMonitoring()
            Iphlapi.GetIfEntry(Me.mib_ifrow)
            Me.bytesRecvStart = Me.mib_ifrow.dwInOctets
            Me.bytesSentStart = Me.mib_ifrow.dwOutOctets
            Me.UpacketRecvStart = Me.mib_ifrow.dwInUcastPkts
            Me.UpacketSentStart = Me.mib_ifrow.dwOutUcastPkts
            Me.NUpacketRecvStart = Me.mib_ifrow.dwInNUcastPkts
            Me.NUpacketSentStart = Me.mib_ifrow.dwOutNUcastPkts
            Me.monitoring = True
            Dim thread As New Thread(New ThreadStart(AddressOf Me.RefreshInfo))
            thread.IsBackground = True
            thread.Start()
        End Sub

        Public Sub stopMonitoring()
            Me.monitoring = False
        End Sub

        Public Function isMonitored() As Boolean
            Return Me.monitoring
        End Function
    End Class
    Public Class NetworkMonitor
        Private networkAdapters As List(Of NetworkAdapter)

        <DebuggerNonUserCode()>
        Public Sub New()
        End Sub
        Public Shared Function isAvailable() As Boolean
            Return My.Computer.Network.IsAvailable
        End Function
        Public Function getAdapters() As List(Of NetworkAdapter)
            Dim flag As Boolean = Me.networkAdapters Is Nothing
            ' The following expression was wrapped in a checked-statement
            If flag Then
                Dim source As String() = (CType(Helper.WmiGetValue("root\CIMV2", "Win32_PerfFormattedData_Tcpip_NetworkInterface", "Name", -1), Object())).Cast(Of String)().ToArray()
                Dim ifRows As Iphlapi.MIB_IFROW() = Iphlapi.getIfRows()
                Me.networkAdapters = New List(Of NetworkAdapter)()
                For i As Integer = 0 To ifRows.Length - 1
                    Dim p_mib_ifrow As Iphlapi.MIB_IFROW = ifRows(i)
                    ' The following expression was wrapped in a unchecked-expression
                    flag = (CULng(p_mib_ifrow.dwOperStatus) = 5UL)
                    If flag Then
                        ' The following expression was wrapped in a unchecked-expression
                        Dim flag2 As Boolean = CULng(p_mib_ifrow.dwType) = 6UL OrElse CULng(p_mib_ifrow.dwType) = 71UL
                        If flag2 Then
                            Dim [string] As String = Encoding.ASCII.GetString(p_mib_ifrow.bDescr, 0, p_mib_ifrow.dwDescrLen - 1)
                            flag2 = source.Contains([string])
                            If flag2 Then
                                Me.networkAdapters.Add(New NetworkAdapter(p_mib_ifrow))
                            End If
                        End If
                    End If
                Next
            End If
            Return Me.networkAdapters
        End Function

        Public Function getAdapterNames() As String()
            ' The following expression was wrapped in a checked-statement
            Dim array As String() = New String(Me.networkAdapters.Count - 1 + 1 - 1) {}
            Dim i As Integer = 0
            While i < Me.networkAdapters.Count
                Dim networkAdapter As NetworkAdapter = Me.networkAdapters(i)
                array(i) = networkAdapter.Name
                Math.Max(Interlocked.Increment(i), i - 1)
            End While
            Return array
        End Function

        Public Function getNetworkAdapter(p_description As String) As NetworkAdapter
            Dim result As NetworkAdapter = Nothing
            Dim i As Integer = 0
            While i < Me.networkAdapters.Count
                Dim networkAdapter As NetworkAdapter = Me.networkAdapters(i)
                Dim flag As Boolean = String.Equals(networkAdapter.Name, p_description)
                If flag Then
                    result = networkAdapter
                    Exit While
                End If
                ' The following expression was wrapped in a checked-expression
                Math.Max(Interlocked.Increment(i), i - 1)
            End While
            Return result
        End Function
    End Class
End Namespace

'MIB_IFROW2 Still Not Working, HELP!!!
'Namespace C_WiFi
'    Public Class NetworkMonitor
'        Private networkAdapters As List(Of NetworkAdapter)

'        Public Function getAdapters() As List(Of NetworkAdapter)
'            If networkAdapters Is Nothing Then
'                '
'                '				 * Init adapters...
'                '
'                Dim netInter As String() = CType(Helper.WmiGetValue("root\CIMV2", "Win32_NetworkAdapter", "Name", , "WHERE NetEnabled=True"), Object()).Cast(Of String).ToArray
'                '
'                Dim mib_ifrows As Iphlapi.MIB_IFROW2() = Iphlapi.getIfRows()
'                networkAdapters = New List(Of NetworkAdapter)()

'                Dim i As Integer = 0
'                While i < mib_ifrows.Length
'                    Dim mib_ifrow As Iphlapi.MIB_IFROW2 = mib_ifrows(i)

'                    ' Ignore WAN Miniport entries...
'                    Dim description As String = Replace(mib_ifrow.description.Skip(2).ToArray, Chr(0), "")
'                    Dim y = False
'                    'For Each z In netInter
'                    '    If Strings.InStr(description, z, CompareMethod.Text) > 0 AndAlso z.Length = description.Length Then y = True : Exit For
'                    'Next
'                    If netInter.Contains(description) Then
'                        networkAdapters.Add(New NetworkAdapter(mib_ifrow))
'                    End If
'                    i += 1
'                End While
'            End If

'            ' Return value
'            Return networkAdapters
'        End Function

'        '*
'        '		 *
'        '		 

'        Public Function getAdapterNames() As String()
'            Dim adapterNames As String() = New String(networkAdapters.Count - 1) {}
'            Dim i As Integer = 0
'            While i < networkAdapters.Count
'                Dim networkAdapter As NetworkAdapter = networkAdapters(i)
'                adapterNames(i) = networkAdapter.Name
'                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
'            End While

'            ' Return value
'            Return adapterNames
'        End Function

'        '*
'        '		 * Set monitored network adapter
'        '		 

'        Public Function getNetworkAdapter(p_description As String) As NetworkAdapter
'            Dim returnNetworkAdapter As NetworkAdapter = Nothing
'            Dim i As Integer = 0
'            While i < networkAdapters.Count
'                Dim networkAdapter As NetworkAdapter = networkAdapters(i)
'                If [String].Equals(networkAdapter.Name, p_description) Then
'                    returnNetworkAdapter = networkAdapter
'                    Exit While
'                End If
'                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
'            End While

'            ' Return value
'            Return returnNetworkAdapter
'        End Function
'    End Class

'    Public Class NetworkAdapter
'        '
'        ' Constants
'        '
'        Private Const POWER_2_31 As UInteger = CType(&HFFFFFFFFUI, UInteger)

'        '
'        ' Member variables
'        '
'        Private mib_ifrow As Iphlapi.MIB_IFROW2
'        Private wrap_dwInOctets As Byte = 0
'        Private wrap_dwOutOctets As Byte = 0
'        Private wrap_dwInUcastPkts As Byte = 0
'        Private wrap_dwOutUcastPkts As Byte = 0
'        Private wrap_dwInNUcastPkts As Byte = 0
'        Private wrap_dwOutNUcastPkts As Byte = 0

'        Private bytesSentStart As Single
'        Private sentBytesPrev As Single
'        Private bytesRecvStart As Single
'        Private recvBytesPrev As Single

'        Private UpacketRecvStart As Single
'        Private recvUPacketPrev As Single
'        Private UpacketSentStart As Single
'        Private sentUPacketPrev As Single

'        Private NUpacketRecvStart As Single
'        Private recvNUPacketPrev As Single
'        Private NUpacketSentStart As Single
'        Private sentNUPacketPrev As Single
'        Private monitoring As Boolean

'        Public TotalUp As Single
'        Public TotalDown As Single
'        Public SpeedUp As Single
'        Public SpeedDown As Single

'        Public PacketU_TotalUp As Single
'        Public PacketU_TotalDown As Single
'        Public PacketU_SpeedUp As Single
'        Public PacketU_SpeedDown As Single

'        Public PacketNU_TotalUp As Single
'        Public PacketNU_TotalDown As Single
'        Public PacketNU_SpeedUp As Single
'        Public PacketNU_SpeedDown As Single

'        Public Name As String
'        Public Sub New(p_mib_ifrow As Iphlapi.MIB_IFROW2)
'            Me.mib_ifrow = p_mib_ifrow
'            Name = mib_ifrow.description
'        End Sub
'        Protected Sub RefreshInfo()
'            While monitoring
'                Try
'                    Dim x = Iphlapi.GetIfEntry2(mib_ifrow)
'                    TotalDown = mib_ifrow.inOctets
'                    TotalUp = mib_ifrow.outOctets

'                    PacketU_TotalDown = mib_ifrow.inUcastPkts
'                    PacketU_TotalUp = mib_ifrow.outUcastPkts

'                    PacketNU_TotalDown = mib_ifrow.inNUcastPkts
'                    PacketNU_TotalUp = mib_ifrow.outNUcastPkts

'                    SpeedDown = TotalDown - recvBytesPrev : recvBytesPrev = TotalDown
'                    SpeedUp = TotalUp - sentBytesPrev : sentBytesPrev = TotalUp

'                    PacketU_SpeedDown = PacketU_TotalDown - recvUPacketPrev : recvUPacketPrev = PacketU_TotalDown
'                    PacketU_SpeedUp = PacketU_TotalUp - sentUPacketPrev : sentUPacketPrev = PacketU_TotalUp

'                    PacketNU_SpeedDown = PacketNU_TotalDown - recvNUPacketPrev : recvNUPacketPrev = PacketNU_TotalDown
'                    PacketNU_SpeedUp = PacketNU_TotalUp - sentNUPacketPrev : sentNUPacketPrev = PacketNU_TotalUp

'                Catch ex As Exception

'                End Try
'                Threading.Thread.Sleep(999)
'            End While

'        End Sub

'        Public Sub startMonitoring()
'            Iphlapi.GetIfEntry2(mib_ifrow)
'            bytesRecvStart = mib_ifrow.InOctets
'            bytesSentStart = mib_ifrow.OutOctets
'            UpacketRecvStart = mib_ifrow.InUcastPkts
'            UpacketSentStart = mib_ifrow.OutUcastPkts
'            NUpacketRecvStart = mib_ifrow.InNUcastPkts
'            NUpacketSentStart = mib_ifrow.OutNUcastPkts
'            monitoring = True
'            Dim x = New Threading.Thread(New Threading.ThreadStart(AddressOf RefreshInfo))
'            x.IsBackground = True : x.Priority = Threading.ThreadPriority.BelowNormal
'            x.Start()
'        End Sub

'        Public Sub stopMonitoring()
'            monitoring = False
'        End Sub

'        Public Function isMonitored() As Boolean
'            Return monitoring
'        End Function

'    End Class

'    Public Class Constants
'        Public Const MAX_ADAPTER_NAME As Integer = 128
'        Public Const MAX_HOSTNAME_LEN As Integer = 128
'        Public Const MAX_DOMAIN_NAME_LEN As Integer = 128
'        Public Const MAX_SCOPE_ID_LEN As Integer = 256
'        Public Const MAX_ADAPTER_DESCRIPTION_LENGTH As Integer = 128
'        Public Const MAX_ADAPTER_NAME_LENGTH As Integer = 256
'        Public Const MAX_ADAPTER_ADDRESS_LENGTH As Integer = 8
'        Public Const DEFAULT_MINIMUM_ENTITIES As Integer = 32

'        Public Const NO_ERROR As Integer = 0
'        Public Const ERROR_BUFFER_OVERFLOW As Integer = 111
'        Public Const ERROR_INSUFFICIENT_BUFFER As Integer = 122
'    End Class

'    Public Class Iphlapi
'        Public Const MAX_INTERFACE_NAME_LEN As Integer = 256
'        Public Const MAXLEN_PHYSADDR As Integer = 8
'        Public Const MAXLEN_IFDESCR As Integer = 256

'        Friend Enum InterfaceConnectionType As Integer
'            Dedicated = 1
'            Passive = 2
'            Demand = 3
'            Maximum = 4
'        End Enum
'        Friend Enum InterfaceTunnelType As Integer
'            None = 0
'            Other = 1
'            Direct = 2
'            SixToFour = 11
'            Isatap = 13
'            Teredo = 14
'            IpHttps = 15
'        End Enum
'        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
'        Public Structure MIB_IFROW2
'            ' MIB_IF_ROW2
'            Private Const GuidLength As Integer = 16
'            Private Const IfMaxStringSize As Integer = 256
'            Private Const IfMaxPhysAddressLength As Integer = 32

'            Friend interfaceLuid As UInt64
'            Friend interfaceIndex As UInt32
'            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=GuidLength)> _
'            Friend interfaceGuid As Byte()
'            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=IfMaxStringSize + 1)> _
'            Friend [alias] As Char()
'            ' Null terminated string
'            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=IfMaxStringSize + 1)> _
'            Friend description As Char()
'            ' Null terminated string
'            Friend physicalAddressLength As UInt32
'            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=IfMaxPhysAddressLength)> _
'            Friend physicalAddress As Byte()
'            ' ANSI
'            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=IfMaxPhysAddressLength)> _
'            Friend permanentPhysicalAddress As Byte()
'            ' ANSI
'            Friend mtu As UInt32
'            Friend type As NetworkInterfaceType
'            Friend tunnelType As InterfaceTunnelType
'            Friend mediaType As UInt32
'            ' Enum
'            Friend physicalMediumType As UInt32
'            ' Enum
'            Friend accessType As UInt32
'            ' Enum
'            Friend directionType As UInt32
'            ' Enum
'            Friend interfaceAndOperStatusFlags As Byte
'            ' Flags Enum
'            Friend operStatus As OperationalStatus
'            Friend adminStatus As UInt32
'            ' Enum
'            Friend mediaConnectState As UInt32
'            ' Enum
'            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=GuidLength)> _
'            Friend networkGuid As Byte()
'            Friend connectionType As InterfaceConnectionType
'            Friend transmitLinkSpeed As UInt64
'            Friend receiveLinkSpeed As UInt64
'            Friend inOctets As UInt64
'            Friend inUcastPkts As UInt64
'            Friend inNUcastPkts As UInt64
'            Friend inDiscards As UInt64
'            Friend inErrors As UInt64
'            Friend inUnknownProtos As UInt64
'            Friend inUcastOctets As UInt64
'            Friend inMulticastOctets As UInt64
'            Friend inBroadcastOctets As UInt64
'            Friend outOctets As UInt64
'            Friend outUcastPkts As UInt64
'            Friend outNUcastPkts As UInt64
'            Friend outDiscards As UInt64
'            Friend outErrors As UInt64
'            Friend outUcastOctets As UInt64
'            Friend outMulticastOctets As UInt64
'            Friend outBroadcastOctets As UInt64
'            Friend outQLen As UInt64

'            Public Overrides Function ToString() As String
'                Return description
'            End Function
'        End Structure
'        <StructLayout(LayoutKind.Sequential)> _
'        Structure MIB_IF_TABLE2
'            Public NumEntries As Integer
'            Public Table As MIB_IFROW2()
'        End Structure

'        <DllImportAttribute("Iphlpapi.dll")> _
'        Private Shared Function GetIfTable2(ByRef Table As Integer) As Integer
'        End Function
'        <DllImport("iphlpapi.dll")> _
'        Friend Shared Function GetIfEntry2(ByRef pIfRow As MIB_IFROW2) As UInteger
'        End Function

'        Public Shared Function getIfRows() As MIB_IFROW2()
'            ' Init
'            Dim size As UInteger = 0
'            Dim result As Integer = 0
'            Dim pMIB_IFTABLE As IntPtr = IntPtr.Zero
'            ' Get the size of MIB_IFTABLE structure
'            result = GetIfTable2(IntPtr.Zero)
'            If result = 0 Then
'                pMIB_IFTABLE = Marshal.AllocHGlobal(CType(size, Integer))
'                result = GetIfTable2(pMIB_IFTABLE)
'            Else
'                Throw New System.ComponentModel.Win32Exception(result)
'            End If

'            If result <> Constants.NO_ERROR Then
'                Throw New System.ComponentModel.Win32Exception(result)
'            End If

'            Dim numEntries As Integer = Marshal.ReadInt32(pMIB_IFTABLE)
'            Dim pMIB_IFROW As Integer = CType(pMIB_IFTABLE.ToInt32(), Integer) + Marshal.SizeOf(GetType(Integer))
'            Dim mib_ifrows As MIB_IFROW2() = New MIB_IFROW2(CType(numEntries, Integer) - 1) {}
'            Dim i As Integer = 0
'            While i < numEntries
'                mib_ifrows(i) = CType(Marshal.PtrToStructure(CType(pMIB_IFROW, IntPtr), GetType(MIB_IFROW2)), MIB_IFROW2)
'                pMIB_IFROW += Marshal.SizeOf(GetType(MIB_IFROW2))
'                i += 1
'            End While

'            ' Deallocate memory...
'            Marshal.FreeHGlobal(pMIB_IFTABLE)

'            ' Return value
'            Return mib_ifrows
'        End Function
'    End Class


'End Namespace