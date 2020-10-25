Public Class Form1

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        MessageBox.Show("file baru telah dibuat")
        RichTextBox1.Text = " "
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        MessageBox.Show("file telah disimpan")
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.Title = "Save"
        dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        Dim underline As New Font(RichTextBox1.Font, FontStyle.Underline)
        RichTextBox1.SelectionFont = underline
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        Dim bold As New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionFont = bold
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        RichTextBox1.Paste()
    End Sub
End Class
