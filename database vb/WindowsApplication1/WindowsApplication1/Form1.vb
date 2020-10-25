Public Class Form1

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_11DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me._11DataSet.Table1)
        'TODO: This line of code loads data into the 'Database1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database1DataSet.Table1)

    End Sub
End Class
