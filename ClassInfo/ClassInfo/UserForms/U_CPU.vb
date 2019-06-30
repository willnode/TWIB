Public Class U_CPU
    Dim lastBoot As Date
    Dim cpuCounter As New CPUMultiCounter
    Sub RefreshInfo()
        '  On Error Resume Next

        If cpuCounter.Cores.Length > 0 Then
            For Each i As ClassControl.ProgBarPlus In CpuCores.Controls
                i.Value = cpuCounter.Cores(i.Tag)
            Next
        End If
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        RefreshInfo()
    End Sub


    Private Sub U_CPU_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Updater.Enabled = Visible : Updater2.Enabled = Visible
        If Visible Then : cpuCounter.Start() : Else : cpuCounter.Stop() : End If
    End Sub

    Private Sub Updater2_Tick(sender As Object, e As EventArgs) Handles Updater2.Tick
        ClockCur.Text = (Info.CPUCore.GetCoreSpeed / 1024).ToString("0.00") + " GHz"
        ClockMax.Text = "/ " + (Info.CPUCore.GetMaxCoreSpeed / 1024).ToString("0.00") + " GHz"
        Dim x = Now - lastBoot
        InfoBoot.Text = If(x.TotalDays >= 1, Math.Floor(x.TotalDays).ToString("0") & " Days" & vbNewLine, "") & x.Hours.ToString("00") & ":" & x.Minutes.ToString("00") & ":" & x.Seconds.ToString("00")
        InfoProcess.Text = Info.CPUCore.GetSystemProcesses.ToString("0")
        InfoThreads.Text = cpuCounter.Threads.ToString("0")
        InfoHandles.Text = cpuCounter.Handle.ToString("0")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        On Error Resume Next
        lastBoot = Info.CPUCore.GetSystemLastBoot
        Info_Core.Text = Info.CPUCore.GetSystemLogicalProcessor.ToString("0")
        For i = 1 To Info.CPUCore.GetSystemLogicalProcessor
            Dim x As New ClassControl.ProgBarPlus
            x.BarBackColor = System.Drawing.Color.FromArgb(40, 40, 40)
            x.BarColorSolid = System.Drawing.Color.Silver
            x.BarColorSolidB = System.Drawing.Color.White
            x.BarPadding = New System.Windows.Forms.Padding(0)
            x.BorderStyle = System.Windows.Forms.BorderStyle.None
            x.Corners.All = 0
            x.Dock = DockStyle.Fill
            x.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            x.ForeColor = System.Drawing.Color.White
            x.Margin = New System.Windows.Forms.Padding(0)
            x.Name = "coreUsage" & i
            x.TextFormat = "#" & i
            x.TextShadow = True
            x.TextShadowColor = System.Drawing.Color.Black
            x.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
            x.Tag = i
            '
            CPUCores.RowStyles.Add(New RowStyle With {.SizeType = SizeType.Absolute, .Height = 30})
            CPUCores.Controls.Add(x, CPUCores.RowStyles.Count - 1, 0)
        Next
        Splash.AddLoadPoint()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Inf.SelectedIndexChanged

    End Sub
End Class
Public Class SystemInfo
    Public Class Processor
        Public Name As String
        Public AddressWidth As String
        Public Architecture As Architectures
        Enum Architectures
            x86 = 0
            MIPS = 1
            Alpha = 2
            PowerPC = 3
            ARM = 5
            Itanium = 6
            x64 = 9
        End Enum
        Public Decription As String
        Public DataWidth As String
        Public DeviceID As String
        Public NumberOfCores As Integer
        Public NumberOfLogicalProcessor As Integer
        Public ProcessorID As String
        Public ProcessorType
        Enum ProcessorTypes
            Other = 1
            Unknown = 2
            Central = 3
            Math = 4
            DSP = 5
            Video = 6
        End Enum
        Public Revision As UInteger
        Public Role As String
        Public Status As String
        Public Stepping As Integer
        Public Version As String
    End Class
    Public Class ComputerSystem
        Public AutomaticManagedPageFile As Boolean
        Public AutomaticResetBootOption As Boolean
        Public AutomaticResetCapacibility As Boolean

    End Class
End Class