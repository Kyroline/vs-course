Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        Dim c, d As Integer

        a = TextBox1.Text
        b = TextBox2.Text

        c = Convert.ToInt32(a)
        d = Convert.ToInt32(b)

        Dim f As Integer = c + d
        Label3.Text = f.ToString
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As String
        Dim c, d As Integer

        a = TextBox1.Text
        b = TextBox2.Text

        c = Convert.ToInt32(a)
        d = Convert.ToInt32(b)

        Dim f As Integer = c - d
        Label3.Text = f.ToString
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As String
        Dim c, d As Integer

        a = TextBox1.Text
        b = TextBox2.Text

        c = Convert.ToInt32(a)
        d = Convert.ToInt32(b)

        Dim f As Integer = c * d
        Label3.Text = f.ToString
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b As String
        Dim c, d As Integer

        a = TextBox1.Text
        b = TextBox2.Text

        c = Convert.ToInt32(a)
        d = Convert.ToInt32(b)

        Dim f As Integer = c / d
        Label3.Text = f.ToString
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class