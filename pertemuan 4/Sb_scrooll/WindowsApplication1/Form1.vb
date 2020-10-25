Public Class Form1

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label9.Text = HScrollBar1.Value
        If (HScrollBar1.Value < 5) Then Label6.Text = "Balita" Else If (HScrollBar1.Value < 12) Then Label6.Text = "anak -anak" Else If (HScrollBar1.Value < 18) Then Label6.Text = "Remaja" Else If (HScrollBar1.Value < 65) Then Label6.Text = "dewasa" Else If (HScrollBar1.Value > 65) Then Label6.Text = "manula"

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Label10.Text = 100 - VScrollBar1.Value
        Label20.Text = ((100 - VScrollBar1.Value)) / 3
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
        Label13.Text = 100 - VScrollBar2.Value
        Label20.Text = ((100 - VScrollBar1.Value)) + ((100 - VScrollBar2.Value)) / 3
    End Sub

    Private Sub VScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar3.Scroll
        Label16.Text = 100 - VScrollBar3.Value
        Label20.Text = ((100 - VScrollBar1.Value)) + ((100 - VScrollBar2.Value)) + ((100 - VScrollBar3.Value)) / 3
    End Sub

   
End Class
