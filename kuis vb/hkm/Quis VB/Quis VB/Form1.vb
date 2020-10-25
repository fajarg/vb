Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ellipse As Graphics
        Dim pena As Pen
        Dim curva As Graphics
        Dim cp() As Point = {New Point(0, 30), New Point(35, 0), New Point(70, 30)}
        Dim cp1() As Point = {New Point(90, 0), New Point(110, 30), New Point(130, 30), New Point(145, 0)}
        Dim x1, y1, x2, y2 As Integer

        pena = New Pen(Color.Black, 3)
        x1 = 20
        y1 = 20
        x2 = 35
        y2 = 30

        ellipse = PictureBox1.CreateGraphics
        ellipse.DrawLine(pena, x1, y1, x2, y2)
        pena = New Pen(Color.Black, 3)
        x1 = 35
        y1 = 30
        x2 = 50
        y2 = 20

        ellipse = PictureBox1.CreateGraphics
        ellipse.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Black, 3)

        curva = PictureBox1.CreateGraphics
        curva.DrawCurve(pena, cp)







        pena = New Pen(Color.Black, 3)
        x1 = 110
        y1 = 5
        x2 = 95
        y2 = 15

        ellipse = PictureBox1.CreateGraphics
        ellipse.DrawLine(pena, x1, y1, x2, y2)
        pena = New Pen(Color.Black, 3)
        x1 = 110
        y1 = 5
        x2 = 125
        y2 = 15

        ellipse = PictureBox1.CreateGraphics
        ellipse.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Black, 3)

       
        curva = PictureBox1.CreateGraphics
        curva.DrawCurve(pena, cp1)
    End Sub
End Class
