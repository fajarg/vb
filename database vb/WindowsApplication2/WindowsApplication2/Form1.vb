Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_11DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me._11DataSet.Table1)
        'TODO: This line of code loads data into the '_11DataSet3.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me._11DataSet3.Table1)
        'TODO: This line of code loads data into the '_11DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me._11DataSet.Table1)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
End Class
