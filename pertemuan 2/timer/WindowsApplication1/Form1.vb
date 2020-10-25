Public Class stopwatch
    Dim t1 As Integer
    Dim t2 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        t1 = 0
        timer.Start()
    End Sub
       

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        timer.Stop()
        t2 = t1 / 10
        Label2.Text = t2
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        t1 = t1 + 1
    End Sub

    Private Sub stopwatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
