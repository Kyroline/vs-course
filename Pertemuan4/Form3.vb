Public Class Form3
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim c As Integer
        Dim b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        Select Case b
            Case 1
                a = a * 1000
            Case 2
                a = a * 100
            Case 3
                a = a * 10
            Case 5
                a = a / 10
            Case 6
                a = a / 100
            Case 7
                a = a / 1000
        End Select
        Select Case c
            Case 1
                a = a / 1000
            Case 2
                a = a / 100
            Case 3
                a = a / 10
            Case 5
                a = a * 10
            Case 6
                a = a * 100
            Case 7
                a = a * 1000
        End Select
        TextBox4.Text = a
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class