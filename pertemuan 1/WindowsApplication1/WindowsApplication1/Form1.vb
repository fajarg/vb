Public Class Form1
    Public a As Integer
    Private Sub soal_Click(sender As Object, e As EventArgs) Handles soal.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = 0
        MessageBox.Show("jawaban salah")
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = 1
        MessageBox.Show("jawaban benar")
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = 0
        MessageBox.Show("jawaban salah")
        Form2.Show()
        Me.Hide()
    End Sub
End Class
