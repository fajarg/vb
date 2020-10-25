Public Class Form2
    Dim bil As Decimal
    Dim oper As Char
    Dim hasil As Decimal

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        oper = "+"
        bil = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        oper = "-"
        bil = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        oper = "/"
        bil = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        oper = "*"
        bil = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If oper = "+" Then
            hasil = bil + TextBox1.Text
        ElseIf oper = "-" Then
            hasil = bil - TextBox1.Text
        ElseIf oper = "/" Then
            hasil = bil / TextBox1.Text
        ElseIf oper = "*" Then
            hasil = bil * TextBox1.Text
        End If
        TextBox1.Text = hasil
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Me.Close()

    End Sub
End Class