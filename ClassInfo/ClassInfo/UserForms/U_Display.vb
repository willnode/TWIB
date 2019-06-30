Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class U_Display
#Region "Tuning"
    WithEvents watch As New Watchers.LightWatcher
    Dim onRead = True
    Dim onWrite = False
    Private Sub BrightSlider_ValueChanged(sender As Object, e As EventArgs) Handles BrightSlider.ValueChanged
        If Not onRead Then C_Display.Tuning.SetBrightness(BrightSlider.Value * 10)
        BrightLabel.Text = (BrightSlider.Value * 10).ToString("0") & " %"
    End Sub
    Private Sub Slider_MouseDown(sender As Object, e As MouseEventArgs) Handles GammaSlider.MouseDown, BrightSlider.MouseDown
        onWrite = True
    End Sub
    Private Sub Slider_MouseUp(sender As Object, e As MouseEventArgs) Handles GammaSlider.MouseUp, BrightSlider.MouseUp
        onWrite = False
    End Sub
    Private Sub GammaSlider_ValueChanged(sender As Object, e As EventArgs) Handles GammaSlider.ValueChanged
        If Not onRead Then C_Display.Tuning.SetGamma(GammaSlider.Value / 20)
        GammaLabel.Text = (GammaSlider.Value / 20).ToString("0.00") & " x"
    End Sub
    Private Sub watch_LightChange(sender As Object, e As EventArrivedEventArgs) Handles watch.LightChange
        onRead = True
        If Not onWrite Then
            Dim x = C_Display.Tuning.GetBrightness
            BrightSlider.Value = x / 10
            BrightSlider.Enabled = x > -1
        End If
        onRead = False
    End Sub
    Private Sub BrightLabel_Click(sender As Object, e As EventArgs) Handles BrightLabel.Click
        BrightSlider.Value = 50
    End Sub
    Private Sub GammaLabel_Click(sender As Object, e As EventArgs) Handles GammaLabel.Click
        GammaSlider.Value = 20
    End Sub


    Private Sub Fnt_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Fnt_Type.SelectedIndexChanged
        If Not onRead Then Info.Display.FontSmoothingType = Fnt_Type.SelectedIndex
        Fnt_Orien.Enabled = Fnt_Type.SelectedIndex = 2
        Fnt_Cont.Enabled = Fnt_Type.SelectedIndex = 2
        If ParentForm IsNot Nothing Then ParentForm.Refresh()
    End Sub

    Private Sub Fnt_Orien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Fnt_Orien.SelectedIndexChanged
        If Not onRead Then Info.Display.FontSmoothingOrien = Fnt_Orien.SelectedIndex
        If ParentForm IsNot Nothing Then ParentForm.Refresh()
    End Sub

    Private Sub Fnt_Cont_MouseUp(sender As Object, e As MouseEventArgs) Handles Fnt_Cont.MouseUp
        If ParentForm IsNot Nothing Then ParentForm.Refresh()
    End Sub

    Private Sub Fnt_Cont_ValueChanged(sender As Object, e As EventArgs) Handles Fnt_Cont.ValueChanged
        If Not onRead Then Info.Display.FontSmoothingContrast = Fnt_Cont.Value * 10
        Fnt_ContTxt.Text = (Fnt_Cont.Value / 10).ToString("0.00") & " x"
        Fnt_Prev.Refresh()
    End Sub

#End Region

#Region "Mouse Hook"
    Private MouseHooker As New Inverter(False, False)

    Public Sub Refresh_Res()
        On Error Resume Next
        BrightSlider.Enabled = C_Display.Tuning.IsSupported
        MsHook_Refresh()
    End Sub
    Public Sub MsHook_Refresh()
        With MouseHooker
            If DH_Auto.Checked Then
                Dim x = SystemInformation.ScreenOrientation
                Select Case x
                    Case ScreenOrientation.Angle0
                        .Swap = False : .InvertX = False : .InvertY = False
                    Case ScreenOrientation.Angle90
                        .Swap = True : .InvertX = True : .InvertY = False
                    Case ScreenOrientation.Angle180
                        .Swap = False : .InvertX = True : .InvertY = True
                    Case ScreenOrientation.Angle270
                        .Swap = True : .InvertX = False : .InvertY = True
                    Case Else
                        Exit Sub
                End Select
            Else
                .Swap = DH_Swap.Checked : .InvertX = DH_FlipX.Checked : .InvertY = DH_FlipY.Checked
            End If
            If DH_Enable.Checked Then
                If Not .Running Then .Start()
            Else
                If .Running Then .Stop()
            End If
        End With
    End Sub

    Private Sub DH_CheckedChanged(sender As Object, e As EventArgs) Handles DH_Fixed.CheckedChanged, DH_Swap.CheckedChanged, DH_FlipY.CheckedChanged, DH_FlipX.CheckedChanged, DH_Enable.CheckedChanged
        MsHook_Refresh()
        DH_Auto.Enabled = DH_Enable.Checked
        DH_Fixed.Enabled = DH_Enable.Checked
        DH_FlipX.Enabled = DH_Enable.Checked And DH_Fixed.Checked
        DH_FlipY.Enabled = DH_Enable.Checked And DH_Fixed.Checked
        DH_Swap.Enabled = DH_Enable.Checked And DH_Fixed.Checked
    End Sub

    Private Sub Tip_Popup(sender As Object, e As PopupEventArgs) Handles Tip.Popup
        Tip.ToolTipTitle = e.AssociatedControl.Text

    End Sub



#End Region

#Region "ALS"

    Private Sub ALS_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles ALS_Enable.CheckedChanged
        If ALS_Enable.Checked Then
            StartCam()

        Else
            StopCam()
        End If
    End Sub
    Public Sub StartCam()
        ALS.Camera.RunGraph()
    End Sub
    Public Sub StopCam()
        ALS.Camera.StopGraph()
    End Sub

    Private Sub ALS_Updater_Tick(sender As Object, e As EventArgs) Handles ALS_Updater.Tick
        If ALS_Enable.Checked Then
            Dim x As Single = Helper.GetBrightness(ALS.SnapshotSourceImage)
            ALS_L.Text = x \ 2.55 & " %"
            x = (x \ 2.55 \ 10) * 10
            If x <> ALS.Tag Then
                If C_Display.Tuning.IsSupported Then C_Display.Tuning.SetBrightness(x)
                ALS.Tag = x
            End If
        End If
    End Sub
#End Region


    Private Sub U_Display_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Updater.Enabled = Visible
        onRead = True
        If Visible Then
            Refresh_Res()
            Fnt_Type.SelectedIndex = Info.Display.FontSmoothingType
            Fnt_Orien.SelectedIndex = Info.Display.FontSmoothingOrien
            Fnt_Cont.Value = Info.Display.FontSmoothingContrast \ 10
            onRead = False
        End If
    End Sub

    Protected Overrides Sub Finalize()
        watch.Dispose()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GammaSlider.Value = C_Display.Tuning.GetGamma * 20
        If C_Display.Tuning.IsSupported Then
            BrightSlider.Value = C_Display.Tuning.GetBrightness / 10
        Else
            BrightSlider.Enabled = False
        End If

        Dim _CameraChoice As New Camera_NET.CameraChoice()

        ' Get List of devices (cameras)
        _CameraChoice.UpdateDeviceList()

        ' To get an example of camera and resolution change look at other code samples 
        If _CameraChoice.Devices.Count > 0 Then
            ' Device moniker. It's like device id or handle.
            ' Run first camera if we have one
            Dim camera_moniker = _CameraChoice.Devices(0).Mon

            ' Set selected camera to camera control with default resolution
            ALS.SetCamera(camera_moniker, Nothing)
        End If
        If Not ALS_Enable.Checked Then StopCam()
        onRead = False
        Splash.AddLoadPoint()
    End Sub
End Class

'Public Shared Function DisplayResNames(ByVal size As Size) As ResNames
'    Select Case size
'        'QVGA
'        Case New Size(160, 120) : Return New ResNames(size, "qQVGA", "Quarter QVGA", "QVGA")
'        Case New Size(240, 160) : Return New ResNames(size, "hQVGA", "Half QVGA", "QVGA")
'        Case New Size(320, 240) : Return New ResNames(size, "QVGA", "Standard QVGA", "QVGA")
'        Case New Size(360, 240) : Return New ResNames(size, "WQVGA", "Wide QVGA", "QVGA")
'        Case New Size(384, 240) : Return New ResNames(size, "WQVGA", "Wide QVGA", "QVGA")
'        Case New Size(400, 240) : Return New ResNames(size, "WQVGA", "Wide QVGA", "QVGA")
'        Case New Size(432, 240) : Return New ResNames(size, "FWQVGA", "Full Wide QVGA", "QVGA")
'            'VGA
'        Case New Size(480, 320) : Return New ResNames(size, "hVGA", "Half VGA", "VGA")
'        Case New Size(640, 480) : Return New ResNames(size, "VGA", "Standard VGA", "VGA")
'        Case New Size(720, 480) : Return New ResNames(size, "WVGA", "Wide VGA", "VGA")
'        Case New Size(800, 480) : Return New ResNames(size, "WVGA", "Wide VGA", "VGA")
'        Case New Size(854, 480) : Return New ResNames(size, "FWVGA", "Full Wide VGA", "VGA")
'        Case New Size(960, 640) : Return New ResNames(size, "DVGA", "Double VGA", "VGA")
'            'SVGA
'        Case New Size(1024, 576) : Return New ResNames(size, "WSVGA", "Wide SVGA", "SVGA")
'        Case New Size(800, 600) : Return New ResNames(size, "SVGA", "Standard SVGA", "SVGA")
'        Case New Size(1024, 600) : Return New ResNames(size, "WSVGA", "Wide SVGA", "SVGA")
'            'XGA
'        Case New Size(1152, 768) : Return New ResNames(size, "WXGA", "Wide XGA", "XGA")
'        Case New Size(1280, 768) : Return New ResNames(size, "WXGA", "Wide XGA", "XGA")
'        Case New Size(1366, 768) : Return New ResNames(size, "WXGA", "Wide XGA", "XGA")
'        Case New Size(1280, 800) : Return New ResNames(size, "WXGA", "Wide XGA", "XGA")
'        Case New Size(1152, 864) : Return New ResNames(size, "XGA+", "Standard XGA Plus", "XGA")
'        Case New Size(1440, 900) : Return New ResNames(size, "WXGA+", "Wide XGA Plus", "XGA")
'        Case New Size(1024, 768) : Return New ResNames(size, "XGA", "Standard XGA", "XGA")
'        Case New Size(2048, 1152) : Return New ResNames(size, "QWXGA", "Quad Wide XGA", "XGA")
'        Case New Size(2048, 1536) : Return New ResNames(size, "QXGA", "Quad XGA", "XGA")
'        Case New Size(2560, 1600) : Return New ResNames(size, "WQXGA", "Wide Quad XGA", "XGA")
'        Case New Size(3200, 1800) : Return New ResNames(size, "WQXGA+", "Wide Quad XGA Plus", "XGA")
'        Case New Size(4096, 3072) : Return New ResNames(size, "HXGA", "Hex[adecatuple] XGA", "XGA")
'        Case New Size(5120, 3200) : Return New ResNames(size, "WHXGA", "Wide Hex[adecatuple] XGA", "XGA")
'            'SXGA
'        Case New Size(1080, 960) : Return New ResNames(size, "SXGA-", "Standard SXGA Minus", "SXGA")
'        Case New Size(1280, 1024) : Return New ResNames(size, "SXGA", "Standard SXGA", "SXGA")
'        Case New Size(1400, 1050) : Return New ResNames(size, "SXGA+", "Standard SXGA Plus", "SXGA")
'        Case New Size(1440, 960) : Return New ResNames(size, "WSXGA", "Wide SXGA", "SXGA")
'        Case New Size(1680, 1050) : Return New ResNames(size, "WSXGA+", "Wide SXGA Plus", "SXGA")
'        Case New Size(2560, 2048) : Return New ResNames(size, "QSXGA", "Quad SXGA", "SXGA")
'        Case New Size(3200, 2048) : Return New ResNames(size, "WQSXGA", "Wide Quad SXGA", "SXGA")
'        Case New Size(5120, 4096) : Return New ResNames(size, "HSXGA", "Hex[adecatuple] SXGA", "SXGA")
'        Case New Size(6400, 4096) : Return New ResNames(size, "WHSXGA", "Wide Hex[adecatuple] SXGA", "SXGA")
'            'UXGA
'        Case New Size(1600, 1200) : Return New ResNames(size, "UXGA", "Standard UXGA", "UXGA")
'        Case New Size(1920, 1200) : Return New ResNames(size, "WUXGA", "Wide UXGA", "UXGA")
'        Case New Size(3200, 2400) : Return New ResNames(size, "QUXGA", "Quad UXGA", "UXGA")
'        Case New Size(3840, 2400) : Return New ResNames(size, "WQUXGA", "Wide Quad UXGA", "UXGA")
'        Case New Size(6400, 4800) : Return New ResNames(size, "HUXGA", "Hex[adecatuple] UXGA", "UXGA")
'        Case New Size(7680, 4800) : Return New ResNames(size, "WHUXGA", "Wide Hex[adecatuple] UXGA", "UXGA")
'            'HD
'        Case New Size(640, 360) : Return New ResNames(size, "nHD", "Ninth HD", "HD")
'        Case New Size(960, 540) : Return New ResNames(size, "qHD", "Quarter HD", "HD")
'        Case New Size(1080, 720) : Return New ResNames(size, "HD", "Standard HD", "HD")
'        Case New Size(1920, 1080) : Return New ResNames(size, "FHD", "Full HD", "HD")
'        Case New Size(2560, 1440) : Return New ResNames(size, "WQHD", "Wide Quad HD", "HD")
'            'UHD
'        Case New Size(3840, 2160) : Return New ResNames(size, "UHD", "Standard UHD", "UHD")
'        Case New Size(5120, 2160) : Return New ResNames(size, "UHD", "Standard UHD", "UHD")
'        Case New Size(5120, 2880) : Return New ResNames(size, "UHD+", "Standard UHD Plus", "UHD")
'        Case New Size(7680, 4320) : Return New ResNames(size, "FUHD", "Full UHD", "UHD")
'        Case New Size(15360, 8640) : Return New ResNames(size, "QUHD", "Quad UHD", "UHD")
'            'Old & Other
'        Case New Size(320, 200) : Return New ResNames(size, "CGA", "Color Graphic Array", "Old")
'        Case New Size(640, 200) : Return New ResNames(size, "CGA", "Color Graphic Array", "Old")
'        Case New Size(720, 350) : Return New ResNames(size, "MDA", "MonoChrome Display Adapter", "Old")
'        Case New Size(640, 350) : Return New ResNames(size, "EGA", "Enhanced Graphic Array", "Old")
'        Case New Size(4096, 2560) : Return New ResNames(size, "4K", "Digital Cinema Initiatives 4K", "Other")
'        Case Else : Return New ResNames(size, "----", "Unknown Resolution", "Other")
'    End Select
'End Function
'Public Class ResNames
'    Public AcroName As String
'    Public FullName As String
'    Public FamilyOf As String
'    Public ResSize As Size
'    Public Sub New(ByVal ResSize_ As Size, ByVal AcroName_ As String, ByVal FullName_ As String, ByVal FamilyOf_ As String)
'        ResSize = ResSize_
'        AcroName = AcroName_
'        FullName = FullName_
'        FamilyOf = FamilyOf_
'    End Sub
'End Class