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
'[x] add splash screen 

Public Class GraphicsExamplesForm
    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

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

    Sub DrawSinWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Indigo)
        Dim ymax As Integer
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = (DrawingPictureBox.Height \ 2)
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width

        ymax = yOffset - 1 '-1 cause i was like 1 pixel short, more pleasing to the eye this way
        oldY = yOffset
        ymax *= -1

        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY
            Select Case x
                Case 90
                    Console.WriteLine($"x={x} y={newY}")
                Case 180
                    Console.WriteLine($"x={x} y={newY}")
                Case 270
                    Console.WriteLine($"x={x} y={newY}")
                Case 360
                    Console.WriteLine($"x={x} y={newY}")
            End Select
        Next

        g.Dispose()
    End Sub


    'event handlers*****************************************************************************

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY, lastVerticalLineX As Integer
        Dim lastColor As Color
        Dim lastWidth As Integer

        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'Ignore
            Case "Middle"
                'manually draw a line from top to bottom
                '  DrawWithMouse(DrawingPictureBox.Width \ 2, 0, DrawingPictureBox.Width \ 2, DrawingPictureBox.Height)

                'draw a line top to bottom on the current mouse x location
                lastColor = ForeGroundColor() 'save user colo
                lastWidth = PenWidth() ' save user pen width
                PenWidth(3) 'set wider pen width 
                ForeGroundColor(BackGroundColor())
                DrawWithMouse(lastVerticalLineX, 0, lastVerticalLineX, DrawingPictureBox.Height)

                PenWidth(1)
                ForeGroundColor(lastColor)
                DrawWithMouse(e.X, 0, e.X, DrawingPictureBox.Height)
                lastVerticalLineX = e.X
                PenWidth(lastWidth)

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
        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub GraphicsExamplesForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static isStartUp As Boolean = True
        If isStartUp Then
            SplashForm.Show()
            isStartUp = False

        End If

    End Sub

    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        DrawingPictureBox.Refresh()
        DrawSinWave()
    End Sub
End Class
