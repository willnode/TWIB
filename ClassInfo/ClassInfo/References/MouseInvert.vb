Imports System.Threading

Public Class Inverter
    Private pos As Point = Cursor.Position
    Private invertX_ As Boolean
    Private invertY_ As Boolean
    Private swap_ As Boolean
    Private running_ As Boolean
    Private exit_ As Boolean

    Public Event InvertSettingsChanged As EventHandler

    Public ReadOnly Property Running() As Boolean
        Get
            Return Me.running_
        End Get
    End Property

    Public Property InvertX() As Boolean
        Get
            Return Me.invertX_
        End Get
        Set(value As Boolean)
            Me.invertX_ = value
            RaiseEvent InvertSettingsChanged(Me, New EventArgs())
        End Set
    End Property
    Public Property Swap() As Boolean
        Get
            Return Me.swap_
        End Get
        Set(value As Boolean)
            Me.swap_ = value
            RaiseEvent InvertSettingsChanged(Me, New EventArgs())
        End Set
    End Property

    Public Property InvertY() As Boolean
        Get
            Return Me.invertY_
        End Get
        Set(value As Boolean)
            Me.invertY_ = value
            RaiseEvent InvertSettingsChanged(Me, New EventArgs())
        End Set
    End Property

    Public Sub New(x As Boolean, y As Boolean)
        Me.invertX_ = x
        Me.invertY_ = y
        Me.pos = Cursor.Position
    End Sub

    Private Sub MouseLoop()
       While Not Me.exit_
            Dim position As Point = Cursor.Position : Dim num = 0, num2 = 0
            If swap_ Then
                num = If(Me.InvertX, (Me.pos.X - (position.Y - pos.Y)), pos.X + (position.Y - pos.Y))
                num2 = If(Me.InvertY, (Me.pos.Y - (position.X - pos.X)), pos.Y + (position.X - pos.X))
            Else
                num = If(Me.InvertX, (Me.pos.X - (position.X - Me.pos.X)), position.X)
                num2 = If(Me.InvertY, (Me.pos.Y - (position.Y - Me.pos.Y)), position.Y)
            End If
            If Me.InvertX Then
                If num < 2 Then num = 2
                If num > Screen.FromPoint(position).Bounds.Right - 2 Then num = Screen.FromPoint(position).Bounds.Right - 2
            End If
            If Me.InvertY Then
                If num2 < 2 Then num2 = 2
                If num2 > Screen.FromPoint(position).Bounds.Bottom - 2 Then num2 = Screen.FromPoint(position).Bounds.Bottom - 2
            End If
            Cursor.Position = New Point(num, num2)
            Me.pos = Cursor.Position
            Thread.Sleep(1)
        End While
        exit_ = False
    End Sub

    Public Sub Start()
        Me.pos = Cursor.Position
        Me.running_ = True
        Dim thread As New Thread(New ThreadStart(AddressOf Me.MouseLoop))
        thread.Priority = ThreadPriority.Highest
        thread.IsBackground = True
        thread.Start()
    End Sub

    Public Sub [Stop]()
        Me.running_ = False
        Me.exit_ = True
    End Sub
End Class