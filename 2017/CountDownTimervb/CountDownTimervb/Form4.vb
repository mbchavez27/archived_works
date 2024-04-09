Public Class Form4
    Dim SubMin As Boolean
    Dim ResetSec As Boolean
    Dim SubSec As Boolean
    Public N10 As Boolean
    Public N5 As Boolean
    Public N20 As Boolean
    Dim DoneSec As Boolean
    Dim DoneMin As Boolean
    Dim Finished As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        SubMin = True
        Count.Enabled = True
        Start.Visible = False
        Button1.Visible = True
        CheckFinished.Enabled = True
        If N5 = True And Minutes.Text < 5 Then
            SubMin = False
        End If
        If N10 = True And Minutes.Text < 10 Then
            SubMin = False
        End If
        If N20 = True And Minutes.Text < 20 Then
            SubMin = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Count.Enabled = False
        Start.Visible = True
        Button1.Visible = False
    End Sub
    Private Sub Count_Tick(sender As Object, e As EventArgs) Handles Count.Tick
        'SubSec and SubMin
        If SubMin = True Then
            SubMin = False
            Minutes.Text = Val(Minutes.Text) - 1
            Cover.Visible = False
            SubSec = True
        End If
        If SubSec = True Then
            Seconds.Text = Val(Seconds.Text) - 1
        End If
        If Val(Seconds.Text) = 60 Then
            SubMin = True
        End If
        'Reset Sec
        If Val(Seconds.Text) < 0 Then
            SubMin = False
            ResetSec = True
        ElseIf Val(Seconds.Text) = 0 And DoneMin = True Then
            ResetSec = False
            Seconds.Text = Val(Seconds.Text) = 0
        End If
        If ResetSec = True Then
            ResetSec = False
            Seconds.Text = 60
            SubSec = True
            SubMin = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResetSec = False
        SubSec = False
        SubMin = False
        Start.Visible = True
        'Check Minutes
        If N20 = True Then
            Minutes.Text = 20
            Cover.Visible = True
            Seconds.Text = 60
        End If
        If N10 = True Then
            Minutes.Text = 10
            Cover.Visible = True
            Seconds.Text = 60
        End If
        If N5 = True Then
            Minutes.Text = 5
            Cover.Visible = True
            Seconds.Text = 60
        End If
    End Sub
    Private Sub CheckFinished_Tick(sender As Object, e As EventArgs) Handles CheckFinished.Tick
        'Finish Event 
        If Val(Seconds.Text) = 0 Then
            DoneSec = True
        End If
        If Val(Minutes.Text) = 0 Then
            DoneMin = True
        End If
        If DoneMin = True Then
            SubMin = False
            Minutes.Text = 0
            My.Computer.Audio.Play("C:\Users\Chavez\Documents\Max's Files\Musics\WAV\BROOKLYN NINE-NINE Ringtone.wav")
        End If
        If DoneSec = True Then
            DoneSec = False
            Seconds.Text = "00"
            Seconds.Text = 0
        End If
        If Val(Seconds.Text) = 0 And DoneMin = True Then
            Cover.Visible = True
        End If
    End Sub
End Class