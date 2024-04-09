Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.HighScore.Text = Val(Number.Text)
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Number.Click

    End Sub
End Class