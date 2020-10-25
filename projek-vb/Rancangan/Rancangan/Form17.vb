Public Class Form17
    Public nyawa1 As Integer
    Public skor1 As Integer
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nyawa1 = 5
        skor1 = 0
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        skor1 = skor1 + 20
        Me.Hide()
        Form18.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nyawa1 = 5
        nyawa1 = nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form18.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nyawa1 = 5
        nyawa1 = nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form18.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        nyawa1 = 5
        skor1 = 0
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        skor1 = skor1 + 20
        Me.Hide()
        Form18.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nyawa1 = 5
        nyawa1 = nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form18.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nyawa1 = 5
        nyawa1 = nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form18.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        nyawa1 = 5
        skor1 = 0
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        skor1 = skor1 + 20
        Me.Hide()
        Form18.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        nyawa1 = 5
        nyawa1 = nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        Form18.Show()
    End Sub
End Class