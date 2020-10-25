Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "fajar" And TextBox2.Text = "123") Then
            MessageBox.Show("login berhasil")
        End If
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class