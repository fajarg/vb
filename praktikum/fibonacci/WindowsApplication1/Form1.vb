Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text < 1 Or TextBox1.Text > 30 Then
            Label2.Text = "Masukkan bilangan bulat antara 1 - 30"
            TextBox1.Text = ""
        Else
            Dim i As Integer = 1
            Dim j As Integer = 1
            Dim k As Integer
            Dim l As Integer
            Dim awal As Integer = 0
            Dim isiArray As New ArrayList(30)
            l = TextBox1.Text
            isiArray.Add(i)
            isiArray.Add(j)


            For awal = 0 To l - 1
                k = i
                i += j
                j = k
                isiArray.Add(i)
            Next
            ListBox1.DataSource = isiArray

        End If
    End Sub
End Class
