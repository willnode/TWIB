Public Class ClrDialog
    Private Declare Function SetSystemCursor Lib "user32.dll" (ByVal hCursor As IntPtr, ByVal id As Integer) As Boolean
    Private Const IDC_ARROW As UInt32 = 32512
    Private lastCur As Icon
    Private WithEvents hk As New WindowsHookLib.MouseHook
    Private _clr As Color
    Private slideFree As Boolean = False
    Public isToolBarChange As Boolean = False
    Public Property Colour As Color
        Get
            Return _clr
        End Get
        Set(value As Color)
            _clr = value
            P.BackColor = value
            If isToolBarChange Then DockForm.BackColor = value
        End Set
    End Property
    Private Sub O_Pick_Click(sender As Object, e As EventArgs) Handles O_Pick.Click
        slideFree = False
        lastCur = Drawing.Icon.FromHandle(Cursors.Arrow.CopyHandle)
        SetSystemCursor(Cursors.Cross.CopyHandle, IDC_ARROW)
        hk.InstallHook()
    End Sub

    Private Sub Color_Change(sender As Object, e As EventArgs) Handles R.ValueChanged, G.ValueChanged, B.ValueChanged
        If slideFree Then Colour = Color.FromArgb(R.Value, G.Value, B.Value)
    End Sub

    Private Sub B_OK_Click(sender As Object, e As EventArgs) Handles B_OK.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub O_Cancel_Click(sender As Object, e As EventArgs) Handles O_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub hk_MouseClick(sender As Object, e As MouseEventArgs) Handles hk.MouseClick
        hk.RemoveHook()
        Colour = P.BackColor
        slideFree = True
        Dim OldCursor As IntPtr = lastCur.Handle

        'Set the system cursor
        SetSystemCursor(OldCursor, IDC_ARROW)
    End Sub

    Private Sub hk_MouseMove(sender As Object, e As WindowsHookLib.MouseEventArgs) Handles hk.MouseMove
        Dim x = New Bitmap(1, 1)
        Dim g = Graphics.FromImage(x)
        g.CopyFromScreen(Cursor.Position, New Point(0, 0), New Size(1, 1), CopyPixelOperation.SourceCopy)
        Dim c = x.GetPixel(0, 0)
        P.BackColor = c
        R.Value = c.R : Me.G.Value = c.G : B.Value = c.B
    End Sub

    Private Sub ClrDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        R.Value = Colour.R
        G.Value = Colour.G
        B.Value = Colour.B
        slideFree = True
    End Sub

    Private Sub P_BackColorChanged(sender As Object, e As EventArgs) Handles P.BackColorChanged
        T.Text = "#" & Hex(Convert.ToInt32(P.BackColor.ToArgb))
    End Sub

End Class