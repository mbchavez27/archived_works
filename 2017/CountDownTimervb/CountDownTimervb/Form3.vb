Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Stopp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Minutes.Text = 20
        Form4.N20 = True
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Minutes.Text = 10
        Form4.N10 = True
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Minutes.Text = 0
        Form4.N5 = True
        Form4.Show()
        Me.Close()
    End Sub
End Class