
Imports System.Drawing
'to import graphic library
Public Class Form1
    Dim G As Graphics
    Dim BBG As Graphics
    Dim sRect As Rectangle
    Dim dRect As Rectangle
    Dim bmp As Bitmap
    Dim BB As Bitmap
    Dim guyx As Integer = 1
    Dim guyy As Integer = 1
    Dim rotateangle As Integer


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                guyy = guyy - 5
            Case Keys.Down
                guyy = guyy + 5
            Case Keys.Left
                guyx = guyx - 5
            Case Keys.Right
                guyx = guyx + 5





        End Select
        drawall()

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bmp = New Bitmap(ptiles.Image)
        G = Me.CreateGraphics
        BB = New Bitmap(Me.Width, Me.Height)

    End Sub

    Private Sub drawall()
        Dim x, y As Integer
        For x = 0 To 8
            For y = 0 To 8
                sRect = New Rectangle(200, 200, 50, 50)
                dRect = New Rectangle(x * 50, y * 50, 50, 50)
                G.DrawImage(bmp, dRect, sRect, GraphicsUnit.Pixel)


            Next
        Next

        bmp.MakeTransparent(Color.Wheat)
        sRect = New Rectangle(0, 0, 150, 150)
        G.DrawImage(bmp, guyx, guyy, sRect, GraphicsUnit.Pixel)


        G = Graphics.FromImage(BB)
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, Me.Width, Me.Height)


    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        drawall()
    End Sub

    Private Sub ptiles_Click(sender As Object, e As EventArgs) Handles ptiles.Click

    End Sub
End Class
