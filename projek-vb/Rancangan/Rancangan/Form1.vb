Public Class Form1
    Public username As String

  
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = TextBox1.Text
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = " "
    End Sub
End Class
