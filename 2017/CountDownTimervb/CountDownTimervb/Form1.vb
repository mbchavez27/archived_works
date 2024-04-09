Public Class Form1
    Dim AddSec As Boolean
    Dim AddMin As Boolean
    Dim ResetSec As Boolean

    Private Sub Starter_Click(sender As Object, e As EventArgs) Handles Starter.Click
        AddSec = True
        Count.Enabled = True
        Starter.Visible = False
        Stoppp.Visible = True
    End Sub

    Private Sub Count_Tick(sender As Object, e As EventArgs) Handles Count.Tick
        If AddSec = True Then
            Seconds.Text = Val(Seconds.Text) + 1
        End If
        If Val(Seconds.Text) > 60 Then
            ResetSec = True
        End If
        If ResetSec = True Then
            ResetSec = False
            Seconds.Text = 0
            Seconds.Text = Val(Seconds.Text) + 1
            Minutes.Text = Val(Minutes.Text) + 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Stoppp_Click(sender As Object, e As EventArgs) Handles Stoppp.Click
        Count.Enabled = False
        Stoppp.Visible = False
        Starter.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(Seconds.Text) > 0 And Val(Minutes.Text) > 0 Then
            Seconds.Text = 0
            Minutes.Text = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
