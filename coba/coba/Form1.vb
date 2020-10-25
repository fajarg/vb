Public Class Form1
    Dim t1 As Integer
    Dim t2 As Double
    Dim a As Integer
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        t1 = 0
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

        Label1.Text = t1

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        t1 = t1 + 1
        Label1.Text = t1
    End Sub

    

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = a + 1

        Label2.Text = a
    End Sub
End Class
