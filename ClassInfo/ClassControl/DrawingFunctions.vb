Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class DrawingFunctions



    Public Enum BestFitStyle
        Zoom
        Stretch
    End Enum

    Public Shared Function GetBestFitRect(ByVal rectFrame As RectangleF, ByVal rect As Rectangle, Optional ByVal BestFitStyle As BestFitStyle = BestFitStyle.Zoom) As RectangleF
        Dim origImageRatio = rect.Width / rect.Height
        Dim canvasRatio = rectFrame.Width / rectFrame.Height
        Dim DrawRect As Rectangle
        If (origImageRatio > canvasRatio AndAlso BestFitStyle = BestFitStyle.Stretch) OrElse (origImageRatio < canvasRatio AndAlso BestFitStyle = BestFitStyle.Zoom) Then
            DrawRect = New Rectangle(rectFrame.Left, rectFrame.Top, rectFrame.Width, rectFrame.Width * (1 / origImageRatio))
        Else
            DrawRect = New Rectangle(rectFrame.Left, rectFrame.Top, rectFrame.Height * origImageRatio, rectFrame.Height)
        End If
        DrawRect.X += ((rectFrame.Width - DrawRect.Width) / 2)
        DrawRect.Y += ((rectFrame.Height - DrawRect.Height) / 2)
        Return DrawRect
    End Function

End Class
