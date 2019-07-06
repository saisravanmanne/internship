Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim angle As Integer = 5
        Select Case e.KeyCode
            Case Keys.Left
                PictureBox1.Left -= 2
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY)
                Me.Refresh()
            Case Keys.Right
                PictureBox1.Left += 2
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Me.Refresh()
            Case Keys.Up
                PictureBox1.Top -= 2
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                Me.Refresh()
            Case Keys.Down
                PictureBox1.Top += 2
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                Me.Refresh()
            Case Else
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
