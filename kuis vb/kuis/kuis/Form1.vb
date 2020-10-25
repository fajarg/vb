Public Class Form1

    Dim persegi As Graphics
    Dim garis As Graphics
    Dim pena As Pen
    Dim elip As Graphics
    Dim x1, y1, x2, y2 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pena = New Pen(Color.Red, 7)
        x1 = Val(195)
        y1 = Val(200)
        x2 = Val(140)
        y2 = Val(40)

        persegi = PictureBox1.CreateGraphics
        persegi.DrawRectangle(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 7)
        x1 = Val(215)
        y1 = Val(170)
        x2 = Val(100)
        y2 = Val(30)

        persegi = PictureBox1.CreateGraphics
        persegi.DrawRectangle(pena, x1, y1, x2, y2)



        pena = New Pen(Color.Red, 7)
        x1 = Val(220)
        y1 = Val(118)
        x2 = Val(220)
        y2 = Val(170)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 7)
        x1 = Val(220)
        y1 = Val(120)
        x2 = Val(240)
        y2 = Val(90)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 15)
        x1 = Val(220)
        y1 = Val(20)
        x2 = Val(70)
        y2 = Val(70)

        elip = PictureBox1.CreateGraphics
        elip.DrawEllipse(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 7)
        x1 = Val(180)
        y1 = Val(90)
        x2 = Val(233)
        y2 = Val(40)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 7)
        x1 = Val(182)
        y1 = Val(87)
        x2 = Val(203)
        y2 = Val(111)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 7)
        x1 = Val(200)
        y1 = Val(110)
        x2 = Val(235)
        y2 = Val(80)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 30)
        x1 = Val(270)
        y1 = Val(6)
        x2 = Val(312)
        y2 = Val(66)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)

        pena = New Pen(Color.Red, 30)
        x1 = Val(310)
        y1 = Val(60)
        x2 = Val(310)
        y2 = Val(170)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)


        pena = New Pen(Color.Red, 7)
        x1 = Val(235)
        y1 = Val(40)
        x2 = Val(8)
        y2 = Val(8)

        elip = PictureBox1.CreateGraphics
        elip.DrawEllipse(pena, x1, y1, x2, y2)

    End Sub
End Class
