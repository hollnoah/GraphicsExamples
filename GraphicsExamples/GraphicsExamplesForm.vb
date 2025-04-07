'Noah Holloway
'RCET 2265
'Spring 2025

Option Strict On
Option Explicit On

'TODO
'[] add functionality for all context menu iterms
'   [x] background color
'   [] pen width as drop  down or text input with max width defined
'   [] font 
'[] match functionality between context menu and top menu
'[x] add tooltip on picture box
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

    Function BackGroundColor(Optional newColor As Color = Nothing) As Color
        Static _backColor As Color = Color.White

        If newColor <> Nothing Then
            _backColor = newColor
        End If
        Return _backColor

    End Function

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1
        'define valid range of pen width
        'width > 1 looks weird, maybe draw rectangels?
        If newWidth > 100 Then
            _penWidth = 100
        ElseIf newWidth > 0 Then
            _penWidth = newWidth
        End If

        Return _penWidth
    End Function

    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForeGroundColor, PenWidth())


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

    Private Sub BackgroundColorContextMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextMenuItem.Click, BackgroundColorTopMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            BackGroundColor(ColorDialog.Color)
            DrawingPictureBox.BackColor = BackGroundColor()

        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Me.Hide()
        AboutForm.Show()
    End Sub
End Class
