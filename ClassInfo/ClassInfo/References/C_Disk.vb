Imports System
Imports System.Collections.Generic
Imports System.Management

Public Class C_Disk
#Region "Structures"
    Public Class DriveInfo
        Public Name As String
        Public Caption As String
        Public InterfaceType As String
        Public Description As String
        Public Index As Integer
        Public PNPID As String
        Public DeviceID As String
        Public SerialNumber As String
        Public SizeDetails As DriveInfo_SizeDetail
        Public Partitions As PartitionInfo()
        Public FirmwareRevision As String
        Public Signature As String
        Public SMART As SMARTInfo
    End Class
    Public Class DriveInfo_SizeDetail
        Public TotalHeads As ULong
        Public TotalCylinders As ULong
        Public TotalTracks As ULong
        Public TotalSectors As ULong
        Public TotalBytes As ULong

        Public _BytesPerSector As ULong
        Public _SectorsPerTrack As ULong
        Public _TrackPerCylinder As ULong
    End Class
    Public Class PartitionInfo
        Public DeviceID As String
        Public StartingOffset As ULong
        Public Size As ULong
        Public Type As String
        Public Index As Integer
        Public isBootable As Boolean
        Public isPrimartyBoot As Boolean
        Public isPrimaryPartition As Boolean
        Public Disks As DiskInfo()
    End Class
    Public Class DiskInfo
        Public Letter As String
        Public Label As String
        Public FreeSpace As Long
        Public TotalSpace As Long
        Public SerialNumber As String
        Public FileSystem As String
        Public DriveType As TypeDrive
        Public Partition As PartitionInfo
        Public Enum TypeDrive
            Unknown = 0
            NoRootDirectory = 1
            RemovableDisk = 2
            LocalDisk = 3
            NetworkDrive = 4
            CompactDisc = 5
            RAMDisk = 6
        End Enum
        Public Overrides Function ToString() As String
            Return "(" & Letter & ") " & Label
        End Function
    End Class
    Public Class SMARTInfo
        Public Supported As Boolean
        Public SmartIdx As Integer
        Public isStatusOK As Boolean
        Public Attributes As SMARTAttribute()
    End Class
    Public Class SMARTAttribute
        Public Idx As Byte
        Public AttrName As String
        Public Current As Integer
        Public Worst As Integer
        Public Threshold As Integer
        Public Data As Integer
        Public isOK As Boolean
        Public Sub New()

        End Sub
        Public Sub New(ByVal Index As Byte, Optional Name As String = "")
            Idx = Index : AttrName = Name
        End Sub
    End Class
#End Region
    Public Drives As DriveInfo() = {}
    Public Sub New()
    End Sub
    Public Sub RefreshDrives()
        '      On Error Resume Next
        'Drives
            Drives = {}
            Dim drvsrch = New ManagementObjectSearcher("root/CIMV2", "SELECT * FROM Win32_DiskDrive")

            For Each drive As ManagementObject In drvsrch.[Get]()
                ReDim Preserve Drives(Drives.Length)
                Drives(Drives.Length - 1) = New DriveInfo
                With Drives(Drives.Length - 1)
                    .Index = drive("Index")
                    .Caption = drive("Caption")
                    .Description = drive("Description")
                    .Signature = drive("Signature")
                    .FirmwareRevision = drive("FirmwareRevision")
                    .PNPID = drive("PNPDeviceID")
                    .DeviceID = drive("DeviceID")
                    .SerialNumber = drive("SerialNumber")
                    .InterfaceType = drive("InterfaceType")
                    .SMART = New SMARTInfo()
                    'Sizes
                    .SizeDetails = New DriveInfo_SizeDetail
                    With .SizeDetails
                        .TotalBytes = drive("Size")
                        .TotalCylinders = drive("TotalCylinders")
                        .TotalTracks = drive("TotalTracks")
                        .TotalHeads = drive("TotalHeads")
                        .TotalSectors = drive("TotalSectors")
                        ._BytesPerSector = drive("BytesPerSector")
                        ._SectorsPerTrack = drive("SectorsPerTrack")
                        ._TrackPerCylinder = drive("TracksPerCylinder")
                    End With

                    'Partitions
                    .Partitions = {}
                    Dim pttsrch = New ManagementObjectSearcher("root/CIMV2", "ASSOCIATORS OF {Win32_DiskDrive.DeviceID=""" & Replace(.DeviceID, "\", "\\") & """} WHERE AssocClass = Win32_DiskDriveToDiskPartition")
                    For Each partition As ManagementObject In pttsrch.[Get]()
                        ReDim Preserve .Partitions(.Partitions.Length)
                        .Partitions(.Partitions.Length - 1) = New PartitionInfo
                        With .Partitions(.Partitions.Length - 1)
                            .DeviceID = partition("DeviceID")
                            .Disks = {}
                            .Index = partition("Index")
                            .Size = partition("Size")
                            .StartingOffset = partition("StartingOffset")
                            .isBootable = partition("Bootable")
                            .isPrimartyBoot = partition("BootPartition")
                            .isPrimaryPartition = partition("PrimaryPartition")
                            .Type = partition("Type")
                            Dim dsksrch = New ManagementObjectSearcher("root/CIMV2", "ASSOCIATORS OF {Win32_DiskPartition.DeviceID=""" & .DeviceID & """} WHERE AssocClass = Win32_LogicalDiskToPartition")
                            For Each disk As ManagementObject In dsksrch.[Get]()
                                ReDim Preserve .Disks(.Disks.Length)
                                .Disks(.Disks.Length - 1) = New DiskInfo
                                .Disks(.Disks.Length - 1).Partition = Drives(Drives.Length - 1).Partitions(.Index)
                                With .Disks(.Disks.Length - 1)
                                    .Letter = disk("Name")
                                    .Label = disk("VolumeName")
                                    .DriveType = disk("DriveType")
                                    .FreeSpace = disk("FreeSpace")
                                    .TotalSpace = disk("Size")
                                    .SerialNumber = disk("VolumeSerialNumber")
                                    .FileSystem = disk("FileSystem")
                                End With
                            Next
                        End With
                    Next
                End With
            Next

            'SMART
            drvsrch = New ManagementObjectSearcher("root/WMI", "SELECT InstanceName FROM MSStorageDriver_FailurePredictData")
            Dim skidx = 0
            For Each drive As ManagementObject In drvsrch.[Get]()
                For Each i As DriveInfo In Drives
                    Dim x = Strings.InStr(drive("InstanceName").toupper, i.PNPID.ToUpper, CompareMethod.Text)
                    If x > 0 Then
                        i.SMART.Supported = True
                        i.SMART.isStatusOK = Helper.WmiGetValue("root/WMI", "MSStorageDriver_FailurePredictStatus", "PredictFailure", skidx) = False
                        i.SMART.Attributes = {}
                        For y = 0 To 30
                            ReDim Preserve i.SMART.Attributes(i.SMART.Attributes.Length)
                            i.SMART.Attributes(i.SMART.Attributes.Length - 1) = New SMARTAttribute()
                        Next
                        i.SMART.SmartIdx = skidx
                        '  RefreshSMART(i.Index)
                    Else
                        i.SMART.Supported = False
                    End If
                Next
                skidx += 1
            Next
    End Sub
    Public Sub RefreshSMART(ByVal DriveIndex As Integer)
        ' retrive attribute flags, value worste and vendor data information
        Dim bytes As Byte() = Helper.WmiGetValue("root/WMI", "MSStorageDriver_FailurePredictData", "VendorSpecific", Drives(DriveIndex).SMART.SmartIdx)
        Dim threshbytes As Byte() = Helper.WmiGetValue("root/WMI", "MSStorageDriver_FailurePredictThresholds", "VendorSpecific", Drives(DriveIndex).SMART.SmartIdx)
        Dim i As Integer = 0
        While i < bytes.Length / 12
            Try
                Dim id As Integer = bytes(i * 12 + 2)
                If id = 0 Then Exit Try

                Dim flags As Integer = bytes(i * 12 + 4)
                'least significant status byte, +3 most significant byte, but not used so ignored.
                'bool advisory = (flags & 0x1) == 0x0;
                Dim failureImminent As Boolean = ((flags And &H1) = &H1)
                'bool onlineDataCollection = (flags & 0x2) == 0x2;
                Dim thresh As Integer = threshbytes(i * 12 + 3)
                Dim value As Integer = bytes(i * 12 + 5)
                Dim worst As Integer = bytes(i * 12 + 6)
                Dim vendordata As Integer = BitConverter.ToInt32(bytes, i * 12 + 7)

                With Drives(DriveIndex).SMART.Attributes(i)
                    .Idx = id
                    .Current = value
                    .Threshold = thresh
                    .Worst = worst
                    .Data = vendordata
                    .isOK = (Not failureImminent)
                End With
            Catch
            End Try
            i += 1
        End While

    End Sub
    Public Class PerfDisk
        Protected isRun As Boolean = True
        Public DiskTimes As ULong()
        Public Sub New()
            Dim x As New Threading.Thread(New Threading.ThreadStart(AddressOf Refresh))
            x.IsBackground = True
            x.Start()
        End Sub
        Protected Sub Refresh()
            While isRun
                Dim x = CType(Helper.WmiGetValue("root/CIMV2", "Win32_PerfFormattedData_PerfDisk_PhysicalDisk", "PercentDiskTime"), Object()).Cast(Of ULong).ToArray
                DiskTimes = x
                Threading.Thread.Sleep(999)
            End While
        End Sub
        Public Property Enabled As Boolean
            Get
                Return isRun
            End Get
            Set(value As Boolean)
                If value <> isRun Then
                    isRun = value
                    If value Then
                        Dim x As New Threading.Thread(New Threading.ThreadStart(AddressOf Refresh))
                        x.IsBackground = True
                        x.Start()
                    End If
                End If
            End Set
        End Property
    End Class
End Class
