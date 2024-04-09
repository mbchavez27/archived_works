Public Class Form1
    'Frog's Original Location and Size for SetBounds = 381,414,37,30 
    'Middle Location = 381
    'Car1 Orig Location and Size for SetBounds = 8, 366, 63, 30
    'Variables for Frog 
    Dim FrogSpeed As Integer = 15
    Dim Scores As Integer = 0
    'Variables for Car
    Dim CarSpeed As Integer = 30
    'Boolean Variables
    Dim Hit As Boolean = False
    Dim Finished As Boolean = False
    Dim ReturnLeft As Boolean = False
    Dim ReturnRight As Boolean = False
    Dim AddScore As Boolean = False
    Dim NewCars As Boolean = False
    Private Sub Frog_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'Movement Controls
        If e.KeyCode = Keys.A Then
            Frog.Left = Frog.Left - FrogSpeed
        End If
        If e.KeyCode = Keys.D Then
            Frog.Left = Frog.Left - -FrogSpeed
        End If
        If e.KeyCode = Keys.W Then
            Frog.Top = Frog.Top - FrogSpeed
        End If
        If e.KeyCode = Keys.S Then
            Frog.Top = Frog.Top - -FrogSpeed
        End If
        'User Interface Controls
        If e.KeyCode = Keys.Escape Then
            Form2.Number.Text = Val(HighScore.Text)
            Form2.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarMove.Enabled = True
        Collision.Enabled = True
        CarCollection.Enabled = True
        FrogDeaths.Enabled = True
        Scoring.Enabled = True
    End Sub
    Private Sub CarMove_Tick(sender As Object, e As EventArgs) Handles CarMove.Tick
        'Car Movement
        Car.Left = Car.Left - -CarSpeed
        Car2.Left = Car2.Left - CarSpeed
        Car3.Left = Car3.Left - -CarSpeed
        Car4.Left = Car4.Left - CarSpeed
        Car5.Left = Car5.Left - -CarSpeed
        Car6.Left = Car6.Left - CarSpeed
    End Sub
    Private Sub Frog_Click(sender As Object, e As EventArgs) Handles Frog.Click

    End Sub
    Private Sub Collision_Tick(sender As Object, e As EventArgs) Handles Collision.Tick
        'Collision
        If Frog.Bounds.IntersectsWith(Car.Bounds) Then
            Hit = True
        End If
        If Hit = True Then
            Hit = False
            Form2.Number.Text = Val(HighScore.Text)
            Frog.Hide()
            Form3.Show()
            Me.Close()
        End If
        If Frog.Bounds.IntersectsWith(Finish.Bounds) Then
            Finished = True
            AddScore = True
        End If
        If Finished = True Then
            Finished = False
            Frog.SetBounds(381, 414, 37, 30)
            Car.SetBounds(9, 366, 63, 30)
            Car2.SetBounds(734, 309, 63, 30)
            Car3.SetBounds(8, 249, 63, 30)
            Car4.SetBounds(732, 149, 63, 30)
            Car5.SetBounds(10, 93, 63, 30)
            Car6.SetBounds(732, 44, 63, 30)
        End If
        If Car.Bounds.IntersectsWith(RightEnd.Bounds) Then
            ReturnLeft = True
        End If
        If ReturnLeft = True Then
            ReturnLeft = False
            Car.SetBounds(9, 366, 63, 30)
            Car3.SetBounds(8, 249, 63, 30)
            Car5.SetBounds(10, 93, 63, 30)
        End If
    End Sub
    Private Sub CarCollection_Tick(sender As Object, e As EventArgs) Handles CarCollection.Tick
        'Collision
        If Car2.Bounds.IntersectsWith(LeftEnd.Bounds) Then
            ReturnRight = True
        End If
        If ReturnRight = True Then
            ReturnRight = False
            Car2.SetBounds(734, 309, 63, 30)
            Car4.SetBounds(732, 149, 63, 30)
            Car6.SetBounds(732, 44, 63, 30)
        End If
        If Car3.Bounds.IntersectsWith(RightEnd.Bounds) Then
            ReturnLeft = True
        End If
        If Car4.Bounds.IntersectsWith(LeftEnd.Bounds) Then
            ReturnRight = True
        End If
        If Car5.Bounds.IntersectsWith(RightEnd.Bounds) Then
            ReturnLeft = True
        End If
        If Car6.Bounds.IntersectsWith(LeftEnd.Bounds) Then
            ReturnRight = True
        End If
    End Sub
    Private Sub FrogDeaths_Tick(sender As Object, e As EventArgs) Handles FrogDeaths.Tick, Timer1.Tick
        If Frog.Bounds.IntersectsWith(Car2.Bounds) Then
            Hit = True
        End If
        If Frog.Bounds.IntersectsWith(Car3.Bounds) Then
            Hit = True
        End If
        If Frog.Bounds.IntersectsWith(Car4.Bounds) Then
            Hit = True
        End If
        If Frog.Bounds.IntersectsWith(Car5.Bounds) Then
            Hit = True
        End If
        If Frog.Bounds.IntersectsWith(Car6.Bounds) Then
            Hit = True
        End If
    End Sub
    Private Sub Scoring_Tick(sender As Object, e As EventArgs) Handles Scoring.Tick
        If AddScore = True Then
            AddScore = False
            Score.Text = Val(Score.Text) + 1
        End If
        If Val(Score.Text) > Val(HighScore.Text) Then
            HighScore.Text = Val(Score.Text)
        Else Score.Text = Val(Score.Text)
        End If
        If Val(Score.Text) = Val(HighScore.Text) Then
            Score.Text = Val(Score.Text)
        End If

    End Sub

    Private Sub HighScore_Click(sender As Object, e As EventArgs) Handles HighScore.Click

    End Sub

    Private Sub Car7_Click(sender As Object, e As EventArgs)

    End Sub
End Class
