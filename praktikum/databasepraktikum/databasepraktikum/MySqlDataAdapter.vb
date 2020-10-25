
Class MySqlDataAdapter

    Private _p1 As String
    Private _conn As MySqlConnection

    Sub New(p1 As String, conn As MySqlConnection)
        ' TODO: Complete member initialization 
        _p1 = p1
        _conn = conn
    End Sub

    Sub Fill(ds As DataSet, p2 As String)
        Throw New NotImplementedException
    End Sub

End Class
