Imports MySql.Data.MySqlClient
Module modconn
    Public conn As MySqlConnection
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public simpan, ubah, hapus As String
    Public Sub bukaDB() 'method koneksi ke database 
        Dim sqlcon As String
        sqlcon = "server=localhost;Uid=root;Pwd=;Database=dbbiodata"
        conn = New MySqlConnection(sqlcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub
End Module
