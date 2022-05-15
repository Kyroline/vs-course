Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        Dim b As Integer
        Dim c As Double
        Dim d As Boolean
        Dim f As Char

        a = TextBox1.Text
        Label2.Text = a
        Button1.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
