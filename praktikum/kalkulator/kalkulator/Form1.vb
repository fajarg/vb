Public Class Form1
    Dim bil1 As Decimal
    Dim bil2 As Decimal
    Dim hasil As Decimal
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bil1 = TextBox1.Text
        bil2 = TextBox2.Text

        If ComboBox1.Text = "+" Then
            hasil = bil1 + bil2
        ElseIf ComboBox1.Text = "-" Then
            hasil = bil1 - bil2
        ElseIf ComboBox1.Text = "/" Then
            hasil = bil1 / bil2
        ElseIf ComboBox1.Text = "*" Then
            hasil = bil1 * bil2
        End If
        Label3.Text = hasil
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = "hasil perhitungan"
        ComboBox1.Text = "Operator"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
