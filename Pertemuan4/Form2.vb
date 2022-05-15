Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = Val(TextBox1.Text)
        TextBox2.Text = 4 / 5 * a
        TextBox3.Text = 9 / 5 * a + 32
        TextBox4.Text = a + 273
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Double
        a = Val(TextBox2.Text)
        TextBox1.Text = 5 / 4 * a
        TextBox3.Text = 9 / 4 * a + 32
        TextBox4.Text = 5 / 4 * a + 273
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Double
        a = Val(TextBox3.Text)
        TextBox1.Text = (a - 32) * 5 / 9
        TextBox2.Text = (a - 32) * 4 / 9
        TextBox4.Text = (a - 32) * 5 / 9 + 273
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Double
        a = Val(TextBox1.Text)
        TextBox2.Text = 4 / 5 * (a - 273)
        TextBox3.Text = 9 / 5 * (a - 273)
        TextBox1.Text = a - 273
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class