﻿Public Class Form23

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form17.skor1
        Label5.Text = Form17.nyawa1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form17.nyawa1 = Form17.nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        If Form17.nyawa1 < 1 Then
            MessageBox.Show("GAME OVER, KESEMPATAN ANDA SUDAH HABIS")
            Form22.Show()
        Else
            Form24.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form17.nyawa1 = Form17.nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        If Form17.nyawa1 < 1 Then
            MessageBox.Show("GAME OVER, KESEMPATAN ANDA SUDAH HABIS")
            Form22.Show()
        Else
            Form24.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form17.nyawa1 = Form17.nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        If Form17.nyawa1 < 1 Then
            MessageBox.Show("GAME OVER, KESEMPATAN ANDA SUDAH HABIS")
            Form22.Show()
        Else
            Form24.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form17.nyawa1 = Form17.nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        If Form17.nyawa1 < 1 Then
            MessageBox.Show("GAME OVER, KESEMPATAN ANDA SUDAH HABIS")
            Form22.Show()
        Else
            Form24.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form17.nyawa1 = Form17.nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        If Form17.nyawa1 < 1 Then
            MessageBox.Show("GAME OVER, KESEMPATAN ANDA SUDAH HABIS")
            Form22.Show()
        Else
            Form24.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form17.nyawa1 = Form17.nyawa1 - 1
        Me.Hide()
        Form4.Show()
        MessageBox.Show("BOOM, ANDA TERKENA BOM")
        Form4.Hide()
        If Form17.nyawa1 < 1 Then
            MessageBox.Show("GAME OVER, KESEMPATAN ANDA SUDAH HABIS")
            Form22.Show()
        Else
            Form24.Show()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        Form17.skor1 = Form17.skor1 + 20
        Me.Hide()
        Form24.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("SELAMAT !!!, ANDA BERHASIL MENGHINDARI BOM")
        Form17.skor1 = Form17.skor1 + 20
        Me.Hide()
        Form24.Show()
    End Sub
End Class