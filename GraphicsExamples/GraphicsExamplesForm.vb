'Noah Holloway
'RCET 2265
'Spring 2025

Option Strict On
Option Explicit On

'TODO
'[] add functionality for all context menu iterms
'[] background color
'[] pen width as drop  down or text input with max width defined
'[] font 
'[] match functionality between context menu and top menu
'[] add tooltip on picture box
'[] plot sine wave
'[] add erase mode
'[] draw shape tool 
'[] add about form
'[] add splash screen 

Public Class GraphicsExamplesForm
    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = ForeGroundColor

        If newColor <> Nothing Then
            _foreColor = newColor
        End If
        Return _foreColor

    End Function

    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForeGroundColor)


        g.DrawLine(pen, oldX, oldY, newX, newY)
        g.Dispose()
    End Sub


    'event handlers*****************************************************************************

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'Ignore
            Case "Middle"
                'TODO
        End Select

        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub ForegroundColorTopMenuItem_Click(sender As Object, e As EventArgs) Handles ForegroundColorTopMenuItem.Click, ForegroundColorContextMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            ForeGroundColor(ColorDialog.Color)
        Else
            MsgBox(result.ToString)
            MsgBox(ColorDialog.Color.ToString)
        End If

    End Sub

    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        DrawingPictureBox.Refresh()
    End Sub
End Class
