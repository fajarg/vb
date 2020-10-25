Public Class Form1
    Dim n As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_11DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me._11DataSet.Table1)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        n = (TextBox2.Text * 200000) + (TextBox3.Text * 150000)
        total.Text = n
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub
End Class
