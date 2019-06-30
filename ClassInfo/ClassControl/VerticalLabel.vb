Imports System.ComponentModel

Public Class VerticalLabel
    Inherits System.Windows.Forms.Control
    Private _orien = ProgBarPlus.eRotateText.Left
  
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim x = 0
        Select Case _orien
            Case ProgBarPlus.eRotateText.Left : x = 270
            Case ProgBarPlus.eRotateText.Right : x = 90
        End Select
        Dim rect As Rectangle = DisplayRectangle
        rect.X += 5 : rect.Y += 1 : rect.Width -= 10
        rect = RotateRect(e, rect, x)
        Dim sf = New StringFormat
        sf.Alignment = StringAlignment.Center : sf.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(Text, Font, New SolidBrush(ForeColor), rect, sf)
    End Sub
    Protected Overrides Sub OnTextChanged(e As System.EventArgs)
        Invalidate()
    End Sub
    Private Function RotateRect(ByVal e As System.Windows.Forms.PaintEventArgs, ByVal TabRect As Rectangle, ByVal Rotate As Integer) As Rectangle

        Dim cp As New PointF(TabRect.Left + (TabRect.Width \ 2), TabRect.Top + (TabRect.Height \ 2))
        e.Graphics.TranslateTransform(cp.X, cp.Y)
        e.Graphics.RotateTransform(Rotate)
        Return New Rectangle(-(TabRect.Height \ 2), -(TabRect.Width \ 2), TabRect.Height, TabRect.Width)

    End Function
    <Category("Appearance")>
    Public Property Orientation As ProgBarPlus.eRotateText
        Get
            Return _orien
        End Get
        Set(value As ProgBarPlus.eRotateText)
            If _orien <> value Then
                _orien = value
                Invalidate()
            End If
        End Set
    End Property
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw + ControlStyles.UserPaint + ControlStyles.AllPaintingInWmPaint + ControlStyles.SupportsTransparentBackColor, True)
    End Sub
End Class
