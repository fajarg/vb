Imports System.Drawing.Drawing2D

Public Class Form1
    Dim garis As Graphics
    Dim persegi As Graphics
    Dim elips As Graphics
    Dim pena As Pen
    Dim i As Integer = 0
    Dim x1, y1, x2, y2 As Integer
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pena = New Pen(Color.Red, 3)
        x1 = Val(TextBox1.Text)
        y1 = Val(TextBox3.Text)
        x2 = Val(TextBox2.Text)
        y2 = Val(TextBox4.Text)

        garis = PictureBox1.CreateGraphics
        garis.DrawLine(pena, x1, y1, x2, y2)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pena = New Pen(Color.Blue, 3)
        x1 = Val(TextBox1.Text)
        y1 = Val(TextBox3.Text)
        x2 = Val(TextBox2.Text)
        y2 = Val(TextBox4.Text)

        persegi = PictureBox1.CreateGraphics
        persegi.DrawRectangle(pena, x1, y1, x2, y2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pena = New Pen(Color.Blue, 3)
        x1 = Val(TextBox1.Text)
        y1 = Val(TextBox3.Text)
        x2 = Val(TextBox2.Text)
        y2 = Val(TextBox4.Text)

        elips = PictureBox1.CreateGraphics
        elips.DrawEllipse(pena, x1, y1, x2, y2)

       
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pena = New Pen(Color.Blue, 3)
        For i = 0 To 5
            x1 += Val(TextBox1.Text)
            y1 += Val(TextBox3.Text)
            x2 += Val(TextBox2.Text)
            y2 += Val(TextBox4.Text)

            elips = PictureBox1.CreateGraphics
            elips.DrawEllipse(pena, x1, y1, x2, y2)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
