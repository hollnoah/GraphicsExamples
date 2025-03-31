'Noah Holloway
'RCET 2265
'Spring 2025

Option Strict On
Option Explicit On
Public Class GraphicsExamplesForm
    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        ' pen.Color = Color.Black
        g.DrawLine(pen, 50, 50, 100, 100)
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red, 3)

        ' pen.Color = Color.Black
        g.DrawRectangle(pen, 150, 150, 300, 300)
        g.Dispose()
    End Sub

    Sub DrawEllipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.DarkSalmon, 3)

        ' pen.Color = Color.Black
        g.DrawEllipse(pen, 160, 160, 290, 240)
        g.Dispose()
    End Sub

    'event handlers*****************************************************************************
    Private Sub GraphicsExamplesForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawEllipse()
    End Sub

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class
