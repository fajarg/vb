Public Class Form1
    Dim t1 As Integer
    Dim t2 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        t2 = t1 / 10
        If (TextBox1.Text = "50" And TextBox1.Text = "100" And TextBox1.Text = "25" And TextBox1.Text = "30") Then MessageBox.Show("selamat jwbn benar")


        End if
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t1 = t1 + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        t1 = 0
    End Sub
End Class
