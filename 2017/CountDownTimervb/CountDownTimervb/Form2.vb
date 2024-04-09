Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Stopp_Click(sender As Object, e As EventArgs) Handles Stopp.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Created By EpicStryker and Stryker Entertainment")
    End Sub
End Class