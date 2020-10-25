
Class MySqlConnection

    Private _sqlcon As String

    Sub New(sqlcon As String)
        ' TODO: Complete member initialization 
        _sqlcon = sqlcon
    End Sub

    Sub Open()
        Throw New NotImplementedException
    End Sub

    Function State() As ConnectionState
        Throw New NotImplementedException
    End Function

End Class
