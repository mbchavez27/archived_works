Imports System.Drawing
Public Class Form1
    'frog
    Dim down As Boolean
    Dim l1 As Boolean
    Dim l2 As Boolean
    Dim l3 As Boolean
    Dim l4 As Boolean
    Dim l5 As Boolean
    Dim l6 As Boolean
    Dim l7 As Boolean
    Dim l8 As Boolean
    Dim finished As Boolean
    Dim up As Boolean
    Dim safe As Boolean
    Dim death As Boolean
    Dim fas As Boolean
    Dim med As Boolean
    Dim cr As Boolean
    Dim truc As Boolean
    Dim backcr As Boolean
    Dim backcr2 As Boolean
    Dim backtruc As Boolean
    Dim backtruc2 As Boolean
    Dim backmed As Boolean
    Dim backmed2 As Boolean
    Dim backfas As Boolean
    Dim backfas2 As Boolean
    Dim turt As Boolean
    Dim turt2 As Boolean
    Dim backmedlog As Boolean
    Dim backmedlog2 As Boolean
    Dim smallback As Boolean
    Dim smallback2 As Boolean
    Dim logg As Boolean
    Dim logg2 As Boolean
    Dim go As Boolean
    Dim logggg As Boolean
    Dim lm As Boolean
    Dim faslg As Boolean
    Dim downcol As Boolean
    Dim leftcol As Boolean
    Dim rightcol As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FroggerMechanic.Enabled = True
        Ret.Enabled = True
        GameOver.Enabled = True
        WaterMechanics.Enabled = True
        WatRet.Enabled = True
        WaterSafety.Enabled = True
        LogSwimming.Enabled = True
        GameWin.Enabled = True
    End Sub

    Private Sub FroggerMechanic_Tick(sender As Object, e As EventArgs) Handles FroggerMechanic.Tick
        'Car Mechanics
        Car.Left = Car.Left - 12
        MedCar.Left = MedCar.Left - -10
        Truck.Left = Truck.Left - 8
        FasCar.Left = FasCar.Left - -20
        If FasCar.Right >= 225 Then
            fas = True
        End If
        If fas = True Then
            FasCar2.Left = FasCar2.Left - -20
        End If
        If MedCar.Right >= 184 Then
            med = True
        End If
        If med = True Then
            MedCar2.Left = MedCar2.Left - -10
        End If
        If Car.Right <= 320 Then
            cr = True
        End If
        If cr = True Then
            Car2.Left = Car2.Left - 12
        End If
        If Truck.Right <= 238 Then
            truc = True
        End If
        If truc = True Then
            Truck2.Left = Truck2.Left - 8
        End If
    End Sub

    Private Sub Movement_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            Frog.Top = Frog.Top - 41
        End If
        If e.KeyCode = Keys.S Then
            Frog.Top = Frog.Top - -41
        ElseIf Frog.Bottom > 421 Then
            Frog.Top = Frog.Top + 0
        End If
        If e.KeyCode = Keys.A Then
            Frog.Left = Frog.Left - 15
        End If
        If e.KeyCode = Keys.D Then
            Frog.Left = Frog.Left - -15
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles Border.Click
    End Sub

    Private Sub Ret_Tick(sender As Object, e As EventArgs) Handles Ret.Tick
        If Car.Right < -62 Then
            backcr = True
        End If
        If Car2.Right < -62 Then
            backcr2 = True
        End If
        If backcr = True Then
            backcr = False
            Car.Location = New Point(477, 380)
        End If
        If backcr2 = True Then
            backcr2 = False
            Car2.Location = New Point(477, 380)
        End If
        If MedCar.Right >= 560 Then
            backmed = True
        End If
        If MedCar2.Right >= 560 Then
            backmed2 = True
        End If
        If backmed = True Then
            backmed = False
            MedCar.Location = New Point(-80, 339)
        End If
        If backmed2 = True Then
            backmed2 = False
            MedCar2.Location = New Point(-80, 339)
        End If
        If Truck.Right < 8 Then
            backtruc = True
        End If
        If Truck2.Right < 8 Then
            backtruc2 = True
        End If
        If backtruc = True Then
            backtruc = False
            Truck.Location = New Point(481, 298)
        End If
        If backtruc2 = True Then
            backtruc2 = False
            Truck2.Location = New Point(481, 298)
        End If
        If FasCar.Right > 536 Then
            backfas = True
        End If
        If FasCar2.Right > 536 Then
            backfas2 = True
        End If
        If backfas = True Then
            backfas = False
            FasCar.Location = New Point(-52, 257)
        End If
        If backfas2 = True Then
            backfas2 = False
            FasCar2.Location = New Point(-52, 257)
        End If
    End Sub

    Private Sub GameOver_Tick(sender As Object, e As EventArgs) Handles GameOver.Tick
        If Frog.Bounds.IntersectsWith(Car.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(Car2.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(MedCar.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(MedCar2.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(Truck.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(Truck2.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(FasCar.Bounds) Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(FasCar2.Bounds) Then
            death = True
        End If
        If death = True Then
            Form3.Num.Text = Val(HighScore.Text)
            Form2.Show()
            Me.Close()
        End If
    End Sub
    Private Sub WaterMechanics_Tick(sender As Object, e As EventArgs) Handles WaterMechanics.Tick
        Turtle.Left = Turtle.Left - -15
        SmallLog.Left = SmallLog.Left - 12
        MedLog.Left = MedLog.Left - -10
        Log.Left = Log.Left - 8
        If Turtle.Right >= 207 Then
            go = True
        End If
        If go = True Then
            Turtle2.Left = Turtle2.Left - -15
        End If
        If SmallLog.Right <= 207 Then
            logggg = True
        End If
        If logggg = True Then
            SmallLog2.Left = SmallLog2.Left - 12
        End If
        If MedLog.Right >= 207 Then
            lm = True
        End If
        If lm = True Then
            MedLog2.Left = MedLog2.Left - -10
        End If
        If Log.Right <= 207 Then
            faslg = True
        End If
        If faslg = True Then
            Log2.Left = Log2.Left - 8
        End If
    End Sub
    Private Sub FasCar_Click(sender As Object, e As EventArgs) Handles FasCar.Click

    End Sub

    Private Sub WatRet_Tick(sender As Object, e As EventArgs) Handles WatRet.Tick
        If Turtle.Right > 550 Then
            turt = True
        End If
        If Turtle2.Right > 550 Then
            turt2 = True
        End If
        If turt = True Then
            turt = False
            Turtle.Location = New Point(-72, 175)
        End If
        If turt2 = True Then
            turt2 = False
            Turtle2.Location = New Point(-72, 175)
        End If
        If SmallLog.Right < -79 Then
            smallback = True
        End If
        If SmallLog2.Right < -79 Then
            smallback2 = True
        End If
        If smallback = True Then
            smallback = False
            SmallLog.Location = New Point(478, 134)
        End If
        If smallback2 = True Then
            smallback2 = False
            SmallLog2.Location = New Point(478, 134)
        End If
        If MedLog.Right > 600 Then
            backmed = True
        End If
        If MedLog2.Right > 600 Then
            backmed2 = True
        End If
        If backmed Then
            backmed = False
            MedLog.Location = New Point(-113, 93)
        End If
        If backmed2 = True Then
            backmed2 = False
            MedLog2.Location = New Point(-113, 93)
        End If
        If Log.Right < -30 Then
            logg = True
        End If
        If Log2.Right < -30 Then
            logg2 = True
        End If
        If logg = True Then
            logg = False
            Log.Location = New Point(477, 52)
        End If
        If logg2 = True Then
            logg2 = False
            Log2.Location = New Point(477, 52)
        End If
    End Sub

    Private Sub WaterSafety_Tick(sender As Object, e As EventArgs) Handles WaterSafety.Tick
        If Frog.Top < 214 Then
            up = True
        Else
            up = False
        End If
        If up = True And l1 = False And l2 = False And l3 = False And l4 = False And l5 = False And l6 = False And l7 = False And l8 = False Then
            death = True
        End If
        If Frog.Bounds.IntersectsWith(Midline.Bounds) Then
            death = False
        End If
        If up = False Then
            death = False
        End If
    End Sub

    Private Sub LogSwimming_Tick(sender As Object, e As EventArgs) Handles LogSwimming.Tick
        If Frog.Bounds.IntersectsWith(Turtle.Bounds) Then
            l1 = True
            Frog.Left = Frog.Left - -15
        Else
            l1 = False
        End If
        If Frog.Bounds.IntersectsWith(Turtle2.Bounds) Then
            l2 = True
            Frog.Left = Frog.Left - -15
        Else
            l2 = False
        End If
        If Frog.Bounds.IntersectsWith(SmallLog.Bounds) Then
            l3 = True
            Frog.Left = Frog.Left - 12
        Else
            l3 = False
        End If
        If Frog.Bounds.IntersectsWith(SmallLog2.Bounds) Then
            l4 = True
            Frog.Left = Frog.Left - 12
        Else
            l4 = False
        End If
        If Frog.Bounds.IntersectsWith(MedLog.Bounds) Then
            l5 = True
            Frog.Left = Frog.Left - -10
        Else
            l5 = False
        End If
        If Frog.Bounds.IntersectsWith(MedLog2.Bounds) Then
            l6 = True
            Frog.Left = Frog.Left - -10
        Else
            l6 = False
        End If
        If Frog.Bounds.IntersectsWith(Log.Bounds) Then
            l7 = True
            Frog.Left = Frog.Left - 8
        Else
            l7 = False
        End If
        If Frog.Bounds.IntersectsWith(Log2.Bounds) Then
            l8 = True
            Frog.Left = Frog.Left - 8
        Else
            l8 = False
        End If
    End Sub

    Private Sub GameWin_Tick(sender As Object, e As EventArgs) Handles GameWin.Tick
        If Frog.Bounds.IntersectsWith(FinLine.Bounds) Then
            finished = True
        End If
        If finished = True Then
            finished = False
            death = False
            Frog.Location = New Point(222, 421)
            Score.Text = Val(Score.Text) + 1
            If Score.Text > HighScore.Text Then
                HighScore.Text = Val(Score.Text)
            Else
                Score.Text = Val(Score.Text)
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Score.Click

    End Sub

    Private Sub Water_Click(sender As Object, e As EventArgs) Handles Water.Click

    End Sub
End Class

