﻿'Noah Holloway
'RCET 2265
'Spring 2025

Option Strict On
Option Explicit On
Public Class GraphicsExamplesForm
    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If
        Return _foreColor

    End Function
    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        pen.Color = ForeGroundColor(Color.Lime)
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

    Sub DrawString()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red, 3)
        ' Create font and brush.
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Crimson)


        g.DrawString("Graphics!", drawFont, drawBrush, 200, 200)

        g.Dispose()
    End Sub

    'event handlers*****************************************************************************
    Private Sub GraphicsExamplesForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawEllipse()
        DrawString()
    End Sub

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class
