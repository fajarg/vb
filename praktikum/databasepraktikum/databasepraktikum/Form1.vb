Imports MySql.Data.MySqlClient
Private Sub Button1_Click(sender As Object, e As EventArgs)
    Try

        simpan = "insert into biodata (nrp,nama,jurusan,alamat,telp,email) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
        cmd = New MySqlCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        Call isiGrid()
        Call bersih()
    Catch ex As Exception
        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
    End Try


End Sub


Public Class Form1
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Sub isiGrid()
        Call bukaDB() 'menjalankan method koneksi dari modul 
        da = New MySqlDataAdapter("Select * from biodata", conn)
        ds = New DataSet
        da.Fill(ds, "biodata")
        DataGridView1.DataSource = ds.Tables("biodata")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid()
    End Sub
End Class



