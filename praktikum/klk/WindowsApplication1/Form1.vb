Public Class Form1
    Dim firstnumber As Single
    Dim secondnumber As Single
    Dim Answernumber As Single
    Dim ArithmeticProcess As String
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        firstnumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "+"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        firstnumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "*"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        firstnumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "-"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        firstnumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "/"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub
End Class
