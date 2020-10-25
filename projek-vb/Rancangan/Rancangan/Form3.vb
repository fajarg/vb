Public Class Form3
    Public nyawa As Integer
    Public skor As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nyawa = 5
        skor = 0
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        skor = skor + 20
        Me.Hide()
        Form5.Show()

        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nyawa = 5
        skor = 0
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        skor = skor + 20
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nyawa = 5
        nyawa = nyawa - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form5.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        nyawa = 5
        skor = 0
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        skor = skor + 20
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nyawa = 5
        nyawa = nyawa - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nyawa = 5
        nyawa = nyawa - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form5.Show()
    End Sub

  
End Class