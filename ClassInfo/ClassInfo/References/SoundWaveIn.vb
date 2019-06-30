Imports System
Imports System.Threading
Imports System.Runtime.InteropServices

Friend Class WaveInHelper
    Public Shared Sub [Try](err As Integer)
        If err <> WaveNative.MMSYSERR_NOERROR Then
            Throw New Exception(err.ToString())
        End If
    End Sub
End Class

Public Delegate Sub BufferDoneEventHandler(data As IntPtr, size As Integer)

Friend Class WaveInBuffer
    Implements IDisposable
    Public NextBuffer As WaveInBuffer

    Private m_RecordEvent As New AutoResetEvent(False)
    Private m_WaveIn As IntPtr

    Private m_Header As WaveNative.WaveHdr
    Private m_HeaderData As Byte()
    Private m_HeaderHandle As GCHandle
    Private m_HeaderDataHandle As GCHandle

    Private m_Recording As Boolean

    Friend Shared Sub WaveInProc(hdrvr As IntPtr, uMsg As Integer, dwUser As Integer, ByRef wavhdr As WaveNative.WaveHdr, dwParam2 As Integer)
        If uMsg = WaveNative.MM_WIM_DATA Then
            Try
                Dim h As GCHandle = CType(wavhdr.dwUser, GCHandle)
                Dim buf As WaveInBuffer = CType(h.Target, WaveInBuffer)
                buf.OnCompleted()
            Catch
            End Try
        End If
    End Sub

    Public Sub New(waveInHandle As IntPtr, size As Integer)
        m_WaveIn = waveInHandle

        m_HeaderHandle = GCHandle.Alloc(m_Header, GCHandleType.Pinned)
        m_Header.dwUser = CType(GCHandle.Alloc(Me), IntPtr)
        m_HeaderData = New Byte(size - 1) {}
        m_HeaderDataHandle = GCHandle.Alloc(m_HeaderData, GCHandleType.Pinned)
        m_Header.lpData = m_HeaderDataHandle.AddrOfPinnedObject()
        m_Header.dwBufferLength = size
        WaveInHelper.[Try](WaveNative.waveInPrepareHeader(m_WaveIn, m_Header, Marshal.SizeOf(m_Header)))
    End Sub
    Protected Overrides Sub Finalize()
        Try
            Dispose()
        Finally
            MyBase.Finalize()
        End Try
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_Header.lpData <> IntPtr.Zero Then
            WaveNative.waveInUnprepareHeader(m_WaveIn, m_Header, Marshal.SizeOf(m_Header))
            m_HeaderHandle.Free()
            m_Header.lpData = IntPtr.Zero
        End If
        m_RecordEvent.Close()
        If m_HeaderDataHandle.IsAllocated Then
            m_HeaderDataHandle.Free()
        End If
        GC.SuppressFinalize(Me)
    End Sub

    Public ReadOnly Property Size() As Integer
        Get
            Return m_Header.dwBufferLength
        End Get
    End Property

    Public ReadOnly Property Data() As IntPtr
        Get
            Return m_Header.lpData
        End Get
    End Property

    Public Function Record() As Boolean
        SyncLock Me
            m_RecordEvent.Reset()
            m_Recording = WaveNative.waveInAddBuffer(m_WaveIn, m_Header, Marshal.SizeOf(m_Header)) = WaveNative.MMSYSERR_NOERROR
            Return m_Recording
        End SyncLock
    End Function

    Public Sub WaitFor()
        If m_Recording Then
            m_Recording = m_RecordEvent.WaitOne()
        Else
            Thread.Sleep(0)
        End If
    End Sub

    Private Sub OnCompleted()
        m_RecordEvent.[Set]()
        m_Recording = False
    End Sub
End Class

'Public Class WaveInRecorder
'    Implements IDisposable
'    Private m_WaveIn As IntPtr
'    Private m_Buffers As WaveInBuffer
'    ' linked list
'    Private m_CurrentBuffer As WaveInBuffer
'    Private m_ThreadRun As Boolean = False
'    Private m_DoneProc As BufferDoneEventHandler
'    Private m_Finished As Boolean

'    Private m_BufferProc As New WaveNative.WaveDelegate(AddressOf WaveInBuffer.WaveInProc)

'    Public Shared ReadOnly Property DeviceCount() As Integer
'        Get
'            Return WaveNative.waveInGetNumDevs()
'        End Get
'    End Property


'    Public Sub New(device As Integer, format As WaveFormat, bufferSize As Integer, bufferCount As Integer, doneProc As BufferDoneEventHandler)
'        m_DoneProc = doneProc
'        WaveInHelper.[Try](WaveNative.waveInOpen(m_WaveIn, device, format, m_BufferProc, IntPtr.Zero, WaveNative.CALLBACK_FUNCTION))
'        AllocateBuffers(bufferSize, bufferCount)
'        Dim i As Integer = 0
'        While i < bufferCount
'            SelectNextBuffer()
'            m_CurrentBuffer.Record()
'            i += 1
'        End While
'        WaveInHelper.[Try](WaveNative.waveInStart(m_WaveIn))

'    End Sub
'    Public Sub Start()
'        If Not m_ThreadRun Then
'            If DeviceCount > 0 Then
'                m_Finished = False : m_ThreadRun = True
'                Dim x = New Thread(New ThreadStart(AddressOf ThreadProc))
'                x.Start()
'            Else
'            End If
'        End If
'    End Sub
'    Public Sub [Stop]()
'        If m_ThreadRun Then
'            m_Finished = True : m_ThreadRun = False
'        End If
'    End Sub

'    Protected Overrides Sub Finalize()
'        Try
'            Dispose()
'        Finally
'            MyBase.Finalize()
'        End Try
'    End Sub
'    Public Sub Dispose() Implements IDisposable.Dispose
'        Try
'            m_Finished = True
'            If m_WaveIn <> IntPtr.Zero Then
'                WaveNative.waveInReset(m_WaveIn)
'            End If
'            WaitForAllBuffers()
'            m_DoneProc = Nothing
'            FreeBuffers()
'            If m_WaveIn <> IntPtr.Zero Then
'                WaveNative.waveInClose(m_WaveIn)
'            End If
'        Finally
'            m_WaveIn = IntPtr.Zero
'        End Try
'        GC.SuppressFinalize(Me)
'    End Sub
'    Private Sub ThreadProc()
'        While Not m_Finished
'            Advance()
'            If Not (m_DoneProc Is Nothing) AndAlso Not m_Finished Then
'                m_DoneProc(m_CurrentBuffer.Data, m_CurrentBuffer.Size)
'            End If
'            m_CurrentBuffer.Record()
'            Thread.Sleep(50)
'        End While
'    End Sub
'    Private Sub AllocateBuffers(bufferSize As Integer, bufferCount As Integer)
'        FreeBuffers()
'        If bufferCount > 0 Then
'            m_Buffers = New WaveInBuffer(m_WaveIn, bufferSize)
'            Dim Prev As WaveInBuffer = m_Buffers
'            Try
'                Dim i As Integer = 1
'                While i < bufferCount
'                    Dim Buf As New WaveInBuffer(m_WaveIn, bufferSize)
'                    Prev.NextBuffer = Buf
'                    Prev = Buf
'                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
'                End While
'            Finally
'                Prev.NextBuffer = m_Buffers
'            End Try
'        End If
'    End Sub
'    Private Sub FreeBuffers()
'        m_CurrentBuffer = Nothing
'        If Not (m_Buffers Is Nothing) Then
'            Dim First As WaveInBuffer = m_Buffers
'            m_Buffers = Nothing

'            Dim Current As WaveInBuffer = First
'            Do
'                Dim [Next] As WaveInBuffer = Current.NextBuffer
'                Current.Dispose()
'                Current = [Next]
'            Loop While Current IsNot First
'        End If
'    End Sub
'    Private Sub Advance()
'        SelectNextBuffer()
'        m_CurrentBuffer.WaitFor()
'    End Sub
'    Private Sub SelectNextBuffer()
'        m_CurrentBuffer = If(m_CurrentBuffer Is Nothing, m_Buffers, m_CurrentBuffer.NextBuffer)
'    End Sub
'    Private Sub WaitForAllBuffers()

'        Dim Buf As WaveInBuffer = m_Buffers
'        While Buf.NextBuffer IsNot m_Buffers
'            Buf.WaitFor()
'            Buf = Buf.NextBuffer
'        End While

'    End Sub
'End Class
Public Class WaveInRecorder
    Implements IDisposable

    Private m_WaveIn As IntPtr

    Private m_Buffers As WaveInBuffer

    Private m_CurrentBuffer As WaveInBuffer

    Private m_ThreadRun As Boolean

    Private m_DoneProc As BufferDoneEventHandler

    Private m_Finished As Boolean

    Private m_BufferProc As WaveNative.WaveDelegate

    Public Shared ReadOnly Property DeviceCount() As Integer
        Get
            Return WaveNative.waveInGetNumDevs()
        End Get
    End Property

    Public Sub New(device As Integer, format As WaveFormat, bufferSize As Integer, bufferCount As Integer, doneProc As BufferDoneEventHandler)
        Me.m_ThreadRun = False
        Me.m_BufferProc = AddressOf WaveInBuffer.WaveInProc
        Me.m_DoneProc = doneProc
        WaveInHelper.[Try](WaveNative.waveInOpen(Me.m_WaveIn, device, format, Me.m_BufferProc, IntPtr.Zero, 196608))
        Me.AllocateBuffers(bufferSize, bufferCount)
        Dim i As Integer = 0
        While i < bufferCount
            Me.SelectNextBuffer()
            Me.m_CurrentBuffer.Record()
            ' The following expression was wrapped in a checked-expression
            Math.Max(Interlocked.Increment(i), i - 1)
        End While
        WaveInHelper.[Try](WaveNative.waveInStart(Me.m_WaveIn))
    End Sub

    Public Sub Start()
        Dim flag As Boolean = Not Me.m_ThreadRun
        If flag Then
            Me.m_Finished = False
            Me.m_ThreadRun = True
            Dim thread As New Thread(New ThreadStart(AddressOf Me.ThreadProc))
            thread.Start()
        End If
    End Sub

    Public Sub [Stop]()
        Dim threadRun As Boolean = Me.m_ThreadRun
        If threadRun Then
            Me.m_Finished = True
            Me.m_ThreadRun = False
        End If
    End Sub

    Protected Overrides Sub Finalize()
        Me.Dispose()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Try
            Me.m_Finished = True
            Dim flag As Boolean = Me.m_WaveIn <> IntPtr.Zero
            If flag Then
                WaveNative.waveInReset(Me.m_WaveIn)
            End If
            Me.WaitForAllBuffers()
            Me.m_DoneProc = Nothing
            Me.FreeBuffers()
            flag = (Me.m_WaveIn <> IntPtr.Zero)
            If flag Then
                WaveNative.waveInClose(Me.m_WaveIn)
            End If
        Finally
            Me.m_WaveIn = IntPtr.Zero
        End Try
        GC.SuppressFinalize(Me)
    End Sub

    Private Sub ThreadProc()
        While Not Me.m_Finished
            Me.Advance()
            Dim flag As Boolean = Me.m_DoneProc IsNot Nothing AndAlso Not Me.m_Finished
            If flag Then
                Me.m_DoneProc(Me.m_CurrentBuffer.Data, Me.m_CurrentBuffer.Size)
            End If
            Me.m_CurrentBuffer.Record()
            Thread.Sleep(50)
        End While
    End Sub

    Private Sub AllocateBuffers(bufferSize As Integer, bufferCount As Integer)
        Me.FreeBuffers()
        Dim flag As Boolean = bufferCount > 0
        If flag Then
            Me.m_Buffers = New WaveInBuffer(Me.m_WaveIn, bufferSize)
            Dim waveInBuffer As WaveInBuffer = Me.m_Buffers
            Try
                Dim i As Integer = 1
                While i < bufferCount
                    Dim waveInBuffer2 As WaveInBuffer = New WaveInBuffer(Me.m_WaveIn, bufferSize)
                    waveInBuffer.NextBuffer = waveInBuffer2
                    waveInBuffer = waveInBuffer2
                    ' The following expression was wrapped in a checked-expression
                    Math.Max(Interlocked.Increment(i), i - 1)
                End While
            Finally
                waveInBuffer.NextBuffer = Me.m_Buffers
            End Try
        End If
    End Sub

    Private Sub FreeBuffers()
        Me.m_CurrentBuffer = Nothing
        Dim flag As Boolean = Me.m_Buffers IsNot Nothing
        If flag Then
            Dim buffers As WaveInBuffer = Me.m_Buffers
            Me.m_Buffers = Nothing
            Dim waveInBuffer As WaveInBuffer = buffers
            Do
                Dim nextBuffer As WaveInBuffer = waveInBuffer.NextBuffer
                waveInBuffer.Dispose()
                waveInBuffer = nextBuffer
            Loop While waveInBuffer IsNot buffers
        End If
    End Sub

    Private Sub Advance()
        Me.SelectNextBuffer()
        Me.m_CurrentBuffer.WaitFor()
    End Sub

    Private Sub SelectNextBuffer()
        Me.m_CurrentBuffer = (If((Me.m_CurrentBuffer Is Nothing), Me.m_Buffers, Me.m_CurrentBuffer.NextBuffer))
    End Sub

    Private Sub WaitForAllBuffers()
        Dim waveInBuffer As WaveInBuffer = Me.m_Buffers
        While waveInBuffer.NextBuffer IsNot Me.m_Buffers
            waveInBuffer.WaitFor()
            waveInBuffer = waveInBuffer.NextBuffer
        End While
    End Sub
End Class
Public Enum WaveFormats
    Pcm = 1
    Float = 3
End Enum

<StructLayout(LayoutKind.Sequential)> _
Public Class WaveFormat
    Public wFormatTag As Short
    Public nChannels As Short
    Public nSamplesPerSec As Integer
    Public nAvgBytesPerSec As Integer
    Public nBlockAlign As Short
    Public wBitsPerSample As Short
    Public cbSize As Short

    Public Sub New(rate As Integer, bits As Integer, channels As Integer)
        wFormatTag = CType(WaveFormats.Pcm, Short)
        nChannels = CType(channels, Short)
        nSamplesPerSec = rate
        wBitsPerSample = CType(bits, Short)
        cbSize = 0

        nBlockAlign = CType(channels * (bits / 8), Short)
        nAvgBytesPerSec = nSamplesPerSec * nBlockAlign
    End Sub
End Class

Friend Class WaveNative
    ' consts
    Public Const MMSYSERR_NOERROR As Integer = 0
    ' no error
    Public Const MM_WOM_OPEN As Integer = &H3BB
    Public Const MM_WOM_CLOSE As Integer = &H3BC
    Public Const MM_WOM_DONE As Integer = &H3BD

    Public Const MM_WIM_OPEN As Integer = &H3BE
    Public Const MM_WIM_CLOSE As Integer = &H3BF
    Public Const MM_WIM_DATA As Integer = &H3C0

    Public Const CALLBACK_FUNCTION As Integer = &H30000
    ' dwCallback is a FARPROC 
    Public Const TIME_MS As Integer = &H1
    ' time in milliseconds 
    Public Const TIME_SAMPLES As Integer = &H2
    ' number of wave samples 
    Public Const TIME_BYTES As Integer = &H4
    ' current byte offset 
    ' callbacks
    Public Delegate Sub WaveDelegate(hdrvr As IntPtr, uMsg As Integer, dwUser As Integer, ByRef wavhdr As WaveHdr, dwParam2 As Integer)

    ' structs 

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure WaveHdr
        Public lpData As IntPtr
        ' pointer to locked data buffer
        Public dwBufferLength As Integer
        ' length of data buffer
        Public dwBytesRecorded As Integer
        ' used for input only
        Public dwUser As IntPtr
        ' for client's use
        Public dwFlags As Integer
        ' assorted flags (see defines)
        Public dwLoops As Integer
        ' loop control counter
        Public lpNext As IntPtr
        ' PWaveHdr, reserved for driver
        Public reserved As Integer
        ' reserved for driver
    End Structure

    Private Const mmdll As String = "winmm.dll"

    ' WaveOut calls
    <DllImport(mmdll)> _
    Public Shared Function waveOutGetNumDevs() As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutPrepareHeader(hWaveOut As IntPtr, ByRef lpWaveOutHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutUnprepareHeader(hWaveOut As IntPtr, ByRef lpWaveOutHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutWrite(hWaveOut As IntPtr, ByRef lpWaveOutHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutOpen(ByRef hWaveOut As IntPtr, uDeviceID As Integer, lpFormat As WaveFormat, dwCallback As WaveDelegate, dwInstance As IntPtr, dwFlags As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutReset(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutClose(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutPause(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutRestart(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutGetPosition(hWaveOut As IntPtr, ByRef lpInfo As Integer, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutSetVolume(hWaveOut As IntPtr, dwVolume As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutGetVolume(hWaveOut As IntPtr, ByRef dwVolume As Integer) As Integer
    End Function

    ' WaveIn calls
    <DllImport(mmdll)> _
    Public Shared Function waveInGetNumDevs() As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInAddBuffer(hwi As IntPtr, ByRef pwh As WaveHdr, cbwh As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInClose(hwi As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInOpen(ByRef phwi As IntPtr, uDeviceID As Integer, lpFormat As WaveFormat, dwCallback As WaveDelegate, dwInstance As IntPtr, dwFlags As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInPrepareHeader(hWaveIn As IntPtr, ByRef lpWaveInHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInUnprepareHeader(hWaveIn As IntPtr, ByRef lpWaveInHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInReset(hwi As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInStart(hwi As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInStop(hwi As IntPtr) As Integer
    End Function
End Class

Public Class FourierTransform
    Private Shared n As Integer, nu As Integer

    Private Shared Function BitReverse(j As Integer) As Integer
        Dim j2 As Integer
        Dim j1 As Integer = j
        Dim k As Integer = 0
        For i = 1 To nu
            j2 = j1 / 2
            k = 2 * k + j1 - 2 * j2
            j1 = j2
        Next
        Return k
    End Function

    Public Shared Function FFT(ByRef x As Double()) As Double()
        ' Assume n is a power of 2
        n = x.Length - 1
        nu = Math.Log(n) / Math.Log(2)
        Dim n2 As Integer = n / 2
        Dim nu1 As Integer = nu - 1
        Dim xre As Double() = New Double(n - 1) {}
        Dim xim As Double() = New Double(n - 1) {}
        Dim magnitude As Double() = New Double(n2 - 1) {}
        Dim decibel As Double() = New Double(n2 - 1) {}
        Dim tr As Double, ti As Double, p As Double, arg As Double, c As Double, s As Double
        Dim i As Integer = 0
        For i = 0 To n - 1
            xre(i) = x(i)
            xim(i) = 0.0F
        Next
        Dim k As Integer = 0
        Dim l As Integer = 1
        For l = 1 To nu
            While k < n
                For i = 1 To n2
                    p = BitReverse(k >> nu1)
                    arg = 2 * CType(Math.PI, Double) * p / n
                    c = CType(Math.Cos(arg), Double)
                    s = CType(Math.Sin(arg), Double)
                    tr = xre(k + n2) * c + xim(k + n2) * s
                    ti = xim(k + n2) * c - xre(k + n2) * s
                    xre(k + n2) = xre(k) - tr
                    xim(k + n2) = xim(k) - ti
                    xre(k) += tr
                    xim(k) += ti
                    k += 1
                Next
                k += n2
            End While
            k = 0
            nu1 -= 1
            n2 = n2 / 2
        Next
        k = 0
        Dim r As Integer
        Do While k < n
            r = BitReverse(k)
            If r > k Then
                tr = xre(k)
                ti = xim(k)
                xre(k) = xre(r)
                xim(k) = xim(r)
                xre(r) = tr
                xim(r) = ti
            End If
            k += 1
        Loop
        For i = 0 To (n / 2) - 1
            'magnitude[i] = (float)(Math.Sqrt((xre[i] * xre[i]) + (xim[i] * xim[i])));
            decibel(i) = 10.0 * Math.Log10(CType(Math.Sqrt((xre(i) * xre(i)) + (xim(i) * xim(i))), Single))

        Next
        'return magnitude;
        Return decibel
    End Function
End Class
