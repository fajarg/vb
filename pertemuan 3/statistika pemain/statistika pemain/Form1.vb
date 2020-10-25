Public Class Form1
    Dim pemain As Integer = 0
    Dim laki As Integer = 0
    Dim Perempuan As Integer = 0
    Dim tertinggi As Double = 0
    Dim strategi As Integer = 0
    Dim perang As Integer = 0
    Dim catur As Integer = 0
    Dim petualangan As Integer = 0
    Dim kuis As Integer = 0
    Dim perasaan As Integer = 0
    Dim favorit As Integer = 0
    Dim nama_fav As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then laki = laki + 1
        Label18.Text = Perempuan
        Label16.Text = Perempuan
        If (RadioButton1.Checked = True) Then Perempuan = Perempuan + 1
        Label17.Text = laki
        Label16.Text = laki

        If (TextBox2.Text = tertinggi) Then tertinggi = TextBox2.Text
        Label19.Text = tertinggi


        If (CheckBox1.Checked = True) Then strategi = strategi + 1
        Label20.Text = strategi
        If (CheckBox2.Checked = True) Then strategi = perang + 1
        Label21.Text = perang
        If (CheckBox3.Checked = True) Then catur = catur + 1
        Label22.Text = catur
        If (CheckBox4.Checked = True) Then petualangan = petualangan + 1
        Label23.Text = petualangan
        If (CheckBox5.Checked = True) Then kuis = kuis + 1
        Label24.Text = kuis
        If (CheckBox6.Checked = True) Then perasaan = perasaan + 1
        Label25.Text = perasaan

        If (strategi > favorit) Then favorit = strategi
        nama_fav = strategi
        If (perang > favorit) Then favorit = perang
        nama_fav = perang
        If (catur > favorit) Then favorit = catur
        nama_fav = catur
        If (petualangan > favorit) Then favorit = petualangan
        nama_fav = petualangan
        If (kuis > favorit) Then favorit = kuis
        nama_fav = kuis
        If (perasaan > favorit) Then favorit = perasaan
        nama_fav = perasaan
    End Sub
End Class
