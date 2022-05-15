Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String
        nama = TextBox1.Text
        MessageBox.Show("Selamat Belajar VB.NET " + nama + " Cemungudh! eaaa", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class