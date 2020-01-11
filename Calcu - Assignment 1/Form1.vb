Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles textInput.Click

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("7")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("8")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("9")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("4")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("5")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("6")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("2")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("3")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        textInput.Text = textInput.Text.TrimStart("0"c)
        textInput.Text += ("0")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If textInput.Text < " " Then
            textInput.Text = Mid(textInput.Text, 1, Len(textInput.Text) - 1 + 1)
        Else
            textInput.Text = Mid(textInput.Text, 1, Len(textInput.Text) - 1)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        textInput.Text = ""
    End Sub

End Class
