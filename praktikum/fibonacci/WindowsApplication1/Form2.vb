Public Class Form2
    Dim n As Integer
    Dim hasil As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = TextBox1.Text
        While (n > 1)
            hasil *= n
            n -= 1

            Label3.Text = hasil
        End While
    End Sub
End Class