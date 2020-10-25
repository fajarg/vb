Public Class Form7

 
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form3.skor
        Label5.Text = Form3.nyawa
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        Form3.skor = Form3.skor + 20
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.nyawa = Form3.nyawa - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form8.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.nyawa = Form3.nyawa - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form8.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        Form3.skor = Form3.skor + 20
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.nyawa = Form3.nyawa - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form8.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        Form3.skor = Form3.skor + 20
        Me.Hide()
        Form8.Show()
    End Sub
End Class