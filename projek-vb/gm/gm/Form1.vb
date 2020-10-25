Public Class Form1
    Public user As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user = TextBox1.Text
        Me.Hide()
        Form2.Show()
    End Sub
End Class
