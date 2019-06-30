Imports System.Runtime.InteropServices
Imports System.Threading

Public Class CPUCounter

    Public Declare Auto Function GetSystemTimes Lib "kernel32.dll" (ByRef idleTime As  _
        Int64, ByRef kernelTime As Int64, ByRef userTime As Int64) As Boolean

    <DllImport("user32.dll")> _
    Private Shared Function GetLastInputInfo(ByRef plii As LASTINPUTINFO) As Boolean
    End Function

    Friend Structure LASTINPUTINFO
        Public cbSize As UInteger
        Public dwTime As UInteger
    End Structure


    Dim sIdle, sKernel, sUser As Double

    Dim eIdle, eKernel, eUser As Double

    Dim systemTime As Long
    Dim IsFirstLaunch = True


    Public totalCpuUsage As Double
    Public Function getCPUUsage() As Double
        '
        If IsFirstLaunch Then GoTo FillDelay
        GetSystemTimes(eIdle, eKernel, eUser)
        systemTime = (eKernel - sKernel) + (eUser - sUser)
        totalCpuUsage = (systemTime - (eIdle - sIdle)) * (100) / (systemTime)

FillDelay:
        GetSystemTimes(sIdle, sKernel, sUser)

        If IsFirstLaunch Then
            IsFirstLaunch = False
            Return 0
        Else
            Return totalCpuUsage
        End If

    End Function

End Class
'Public Class DiskCounter
'    Public ActiveTime As Double
'    Public DiskRead As Double
'    Public DiskWrite As Double
'    Public OnWorking As Boolean = False
'    Dim Counter As New ManagementOperationObserver
'    Dim searcher As New ManagementObjectSearcher("root/WMI", "Select * From Win32_PerfFormattedData_PerfDisk_PhysicalDisk")
'    Public Sub New()
'        Refresh()
'    End Sub
'    Public Sub Refresh()
'        If Not OnWorking Then
'            AddHandler Counter.ObjectReady, AddressOf Counter_ObjectReady
'            'AddHandler Counter.Completed, AddressOf Counter_Completed
'            searcher.Get(Counter)

'            OnWorking = True
'            Do While OnWorking
'                Threading.Thread.Sleep(0)
'            Loop
'        End If
'    End Sub

'    Private Sub Counter_Completed(sender As Object, e As CompletedEventArgs)
'        OnWorking = False
'        '  RemoveHandler Counter.ObjectReady, AddressOf Counter_ObjectReady
'        RemoveHandler Counter.Completed, AddressOf Counter_Completed

'    End Sub


'    Private Sub Counter_ObjectReady(sender As Object, e As ObjectReadyEventArgs)
'        ActiveTime = e.NewObject("PercentDiskTime")
'        DiskRead = e.NewObject("Disk Read Bytes/sec")
'        DiskWrite = e.NewObject("Disk Write Bytes/sec")
'        OnWorking = False
'    End Sub

'    Private Sub Counter_Progress(sender As Object, e As ProgressEventArgs)

'    End Sub
'End Class

Public Class CPUMultiCounter
    Public Cores() As ULong = {}
    Public Threads As Single = 0
    Public Handle As Single = 0
    Public isRunning As Boolean
    Public Sub New()

    End Sub
    Protected Sub Refresh()
        While isRunning
            Cores = CType(Helper.WmiGetValue("root\CIMV2", "Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime"), Object()).Cast(Of ULong).ToArray
            Threads = 0 : Handle = 0
            For Each I As Process In Process.GetProcesses
                Threads += I.Threads.Count : Handle += I.HandleCount
            Next
            Thread.Sleep(500)
        End While
    End Sub
    Public Sub Start()
        If Not isRunning Then
            isRunning = True
            Dim thread As New Thread(New ThreadStart(AddressOf Me.Refresh))
            thread.IsBackground = True : thread.Priority = ThreadPriority.Normal
            thread.Start()
        End If
    End Sub
    Public Sub [Stop]()
        isRunning = False
    End Sub
End Class

