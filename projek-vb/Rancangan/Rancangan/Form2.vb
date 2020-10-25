Public Class Form2

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form1.username
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form17.Show()
    End Sub
End Class