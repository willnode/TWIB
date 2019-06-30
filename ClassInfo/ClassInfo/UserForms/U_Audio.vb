Public Class U_Audio

    Public AudioDevice As CoreAudioApi.MMDevice
#Region "General Audio"
    Public WithEvents AudioHook As CoreAudioApi.AudioEndpointVolume
    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        On Error Resume Next
        If AudioDevice IsNot Nothing Then
            RPeak.Value = AudioDevice.AudioMeterInformation.PeakValues(1) * 100
            LPeak.Value = AudioDevice.AudioMeterInformation.PeakValues(0) * 100
        End If
    End Sub
    Public Sub InitDevices(Optional ByVal isFirst As Boolean = False)
        'Output
        Try
            AudioDevice = (New CoreAudioApi.MMDeviceEnumerator).GetDefaultAudioEndpoint(CoreAudioApi.EDataFlow.eRender, CoreAudioApi.ERole.eMultimedia)
        Catch
            AudioDevice = Nothing
        End Try
        If AudioDevice IsNot Nothing Then
            AudioHook = AudioDevice.AudioEndpointVolume
        Else
            AudioHook = Nothing
        End If
        VolSlider.Enabled = AudioDevice IsNot Nothing
        If AudioHook IsNot Nothing Then VolSlider.Value = AudioHook.MasterVolumeLevelScalar * 100
        'Input
        If WaveInRecorder.DeviceCount > 0 Then
            If isFirst Then
                WavFormat = New WaveFormat(16000, 16, 2)
                WavRecord = New WaveInRecorder(-1, WavFormat, 1024, 3, New BufferDoneEventHandler(AddressOf WavData))
            End If
            If Visible Then WavRecord.Start()
        Else
            If WavRecord IsNot Nothing Then WavRecord.Stop()
        End If
        WavL.Image = Nothing
    End Sub
    Private Sub U_Audio_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        On Error Resume Next
        Updater.Enabled = Me.Visible
        If Visible Then
            If WaveInRecorder.DeviceCount > 0 Then WavRecord.Start()
        Else
            WavRecord.Stop()
        End If
    End Sub

    Private Sub AudioHook_OnVolumeNotification(data As CoreAudioApi.AudioVolumeNotificationData) Handles AudioHook.OnVolumeNotification
        VolSlider.Value = AudioHook.MasterVolumeLevelScalar * 100
    End Sub

    Private Sub VolSlider_ValueChanged(sender As Object, e As EventArgs) Handles VolSlider.ValueChanged
        If AudioHook IsNot Nothing Then AudioHook.MasterVolumeLevelScalar = VolSlider.Value / 100
    End Sub
#End Region

    Dim WavFormat As WaveFormat
    Dim WavRecord As WaveInRecorder
    Dim WavBuffer() As Byte = {}, WavLeft() As Double = {}
    Dim avgdB As Single, mindB As Single = 0, maxdB As Single = 0
    Private Sub doLoad()
        InitDevices(True)
        'Dim y = (New CoreAudioApi.MMDeviceEnumerator).EnumerateAudioEndPoints(CoreAudioApi.EDataFlow.eAll, CoreAudioApi.EDeviceState.DEVICE_STATEMASK_ALL)


    End Sub
    Sub WavData(data As IntPtr, size As Integer)
        Try
            If WavBuffer.Length <> size Then WavBuffer = New Byte(size - 1) {}
            If WavLeft.Length <> WavBuffer.Length / 2 Then WavLeft = New Double(WavBuffer.Length / 2) {}
            ' If WavRight.Length <> WavBuffer.Length / 4 Then WavRight = New Double(WavBuffer.Length / 4) {}
            Runtime.InteropServices.Marshal.Copy(data, WavBuffer, 0, size)

            Dim i As Integer = 0, h = 0
            While i < WavBuffer.Length
                WavLeft(h) = CType(BitConverter.ToInt16(WavBuffer, i), Double)
                WavLeft(h + 1) = CType(BitConverter.ToInt16(WavBuffer, i + 2), Double)
                h += 2 : i += 4
            End While
            'Draw
            ' Set up for drawing
            Dim canvas As New Bitmap(WavL.Width, WavL.Height)
            Dim offScreenDC As Graphics = Graphics.FromImage(canvas)
            Dim pen As Pen = New System.Drawing.Pen(Color.WhiteSmoke, 2)
            offScreenDC.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            ' Determine channnel boundries
            Dim width As Integer = canvas.Width
            Dim height As Integer = canvas.Height
            Dim center As Double = height / 2

            ' Draw left channel
            Dim scale As Double = 0.49 * height / 32768
            ' a 16 bit sample has values from -32768 to 32767
            Dim xPrev As Integer = 0, yPrev As Integer = 0
            Dim x As Integer = 0
            While x < width
                Dim y As Integer = CType(center + (WavLeft(WavLeft.Length / width * x) * scale), Integer)
                If x = 0 Then
                    xPrev = 0 : yPrev = y
                Else
                    offScreenDC.DrawLine(pen, xPrev, yPrev, x, y)
                    xPrev = x : yPrev = y
                End If
                x += 1
            End While

            If WavL.Tag >= 10 Then
                Dim fft = FourierTransform.FFT(WavLeft)
                'Dim scaleHz As Double = (16000 / 2) / fft.Length
                mindB = Single.MaxValue : maxdB = Single.MinValue ': minHz = 0 : maxHz = 0
                mindB = fft.Min
                maxdB = fft.Max
                Dim z = (From p In fft Where p <> 0).ToArray
                avgdB = z.Average

                WavL.Tag = 0
            Else
                WavL.Tag += 1
            End If
            offScreenDC.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            Dim sf = New StringFormat : sf.LineAlignment = StringAlignment.Far
            'sf.Alignment = StringAlignment.Near
            'offScreenDC.DrawString(minHz.ToString("0.0") & " Hz - " & maxHz.ToString("0.0") & " Hz", Font, Brushes.WhiteSmoke, WavL.DisplayRectangle, sf)
            offScreenDC.DrawString(avgdB.ToString("0.0") & " dB", New Font(Font.Name, Font.Size + 7), Brushes.WhiteSmoke, WavL.DisplayRectangle, sf)
            sf.Alignment = StringAlignment.Far
            offScreenDC.DrawString(mindB.ToString("0.0") & " dB - " & maxdB.ToString("0.0") & " dB", Font, Brushes.WhiteSmoke, WavL.DisplayRectangle, sf)
            SyncLock WavL
                WavL.Image = canvas
            End SyncLock
            offScreenDC.Dispose()
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub New()
        On Error Resume Next

        ' This call is required by the designer.
        InitializeComponent()
        Font = New Font("Segoe UI", 11)
        ' Add any initialization after the InitializeComponent() call.
        doLoad()
        Splash.AddLoadPoint()
    End Sub
End Class
