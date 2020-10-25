Public Class Form2
    Public b As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        b = 0
        MessageBox.Show("jawaban salah")
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b = 1
        MessageBox.Show("jawaban benar")
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b = 0
        MessageBox.Show("jawaban salah")
        Form3.Show()
        Me.Hide()
    End Sub
End Class