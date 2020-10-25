Public Class Form22

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form1.username
        Label4.Text = Form17.skor1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class