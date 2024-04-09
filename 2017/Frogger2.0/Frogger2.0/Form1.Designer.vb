<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FroggerMechanic = New System.Windows.Forms.Timer(Me.components)
        Me.Ret = New System.Windows.Forms.Timer(Me.components)
        Me.GameOver = New System.Windows.Forms.Timer(Me.components)
        Me.WaterMechanics = New System.Windows.Forms.Timer(Me.components)
        Me.WatRet = New System.Windows.Forms.Timer(Me.components)
        Me.WaterSafety = New System.Windows.Forms.Timer(Me.components)
        Me.LogSwimming = New System.Windows.Forms.Timer(Me.components)
        Me.GameWin = New System.Windows.Forms.Timer(Me.components)
        Me.Score = New System.Windows.Forms.Label()
        Me.HighScore = New System.Windows.Forms.Label()
        Me.Frog = New System.Windows.Forms.PictureBox()
        Me.Log2 = New System.Windows.Forms.PictureBox()
        Me.MedLog2 = New System.Windows.Forms.PictureBox()
        Me.SmallLog2 = New System.Windows.Forms.PictureBox()
        Me.Turtle2 = New System.Windows.Forms.PictureBox()
        Me.Car2 = New System.Windows.Forms.PictureBox()
        Me.Truck2 = New System.Windows.Forms.PictureBox()
        Me.MedCar2 = New System.Windows.Forms.PictureBox()
        Me.FasCar2 = New System.Windows.Forms.PictureBox()
        Me.Border = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Midline = New System.Windows.Forms.PictureBox()
        Me.Turtle = New System.Windows.Forms.PictureBox()
        Me.SmallLog = New System.Windows.Forms.PictureBox()
        Me.MedLog = New System.Windows.Forms.PictureBox()
        Me.Log = New System.Windows.Forms.PictureBox()
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.MedCar = New System.Windows.Forms.PictureBox()
        Me.FasCar = New System.Windows.Forms.PictureBox()
        Me.Truck = New System.Windows.Forms.PictureBox()
        Me.FinLine = New System.Windows.Forms.PictureBox()
        Me.Water = New System.Windows.Forms.PictureBox()
        CType(Me.Frog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedLog2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmallLog2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turtle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Midline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turtle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmallLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Water, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FroggerMechanic
        '
        '
        'Ret
        '
        '
        'GameOver
        '
        '
        'WaterMechanics
        '
        '
        'WatRet
        '
        '
        'WaterSafety
        '
        '
        'LogSwimming
        '
        '
        'GameWin
        '
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Score.Font = New System.Drawing.Font("Pixel-Art", 32.0!)
        Me.Score.ForeColor = System.Drawing.Color.Goldenrod
        Me.Score.Location = New System.Drawing.Point(3, 4)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(44, 38)
        Me.Score.TabIndex = 25
        Me.Score.Text = "0"
        '
        'HighScore
        '
        Me.HighScore.AutoSize = True
        Me.HighScore.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HighScore.Font = New System.Drawing.Font("Pixel-Art", 32.0!)
        Me.HighScore.ForeColor = System.Drawing.Color.Goldenrod
        Me.HighScore.Location = New System.Drawing.Point(437, 4)
        Me.HighScore.Name = "HighScore"
        Me.HighScore.Size = New System.Drawing.Size(44, 38)
        Me.HighScore.TabIndex = 26
        Me.HighScore.Text = "0"
        '
        'Frog
        '
        Me.Frog.BackColor = System.Drawing.Color.Transparent
        Me.Frog.BackgroundImage = Global.Frogger2._0.My.Resources.Resources.Frog
        Me.Frog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Frog.Image = Global.Frogger2._0.My.Resources.Resources.Frog
        Me.Frog.Location = New System.Drawing.Point(222, 421)
        Me.Frog.Name = "Frog"
        Me.Frog.Size = New System.Drawing.Size(40, 40)
        Me.Frog.TabIndex = 0
        Me.Frog.TabStop = False
        '
        'Log2
        '
        Me.Log2.BackColor = System.Drawing.Color.DarkOrange
        Me.Log2.Location = New System.Drawing.Point(477, 52)
        Me.Log2.Name = "Log2"
        Me.Log2.Size = New System.Drawing.Size(140, 40)
        Me.Log2.TabIndex = 24
        Me.Log2.TabStop = False
        '
        'MedLog2
        '
        Me.MedLog2.BackColor = System.Drawing.Color.DarkOrange
        Me.MedLog2.Location = New System.Drawing.Point(-113, 93)
        Me.MedLog2.Name = "MedLog2"
        Me.MedLog2.Size = New System.Drawing.Size(120, 40)
        Me.MedLog2.TabIndex = 23
        Me.MedLog2.TabStop = False
        '
        'SmallLog2
        '
        Me.SmallLog2.BackColor = System.Drawing.Color.DarkOrange
        Me.SmallLog2.Location = New System.Drawing.Point(478, 134)
        Me.SmallLog2.Name = "SmallLog2"
        Me.SmallLog2.Size = New System.Drawing.Size(80, 40)
        Me.SmallLog2.TabIndex = 22
        Me.SmallLog2.TabStop = False
        '
        'Turtle2
        '
        Me.Turtle2.BackColor = System.Drawing.Color.DarkOrange
        Me.Turtle2.Location = New System.Drawing.Point(-75, 175)
        Me.Turtle2.Name = "Turtle2"
        Me.Turtle2.Size = New System.Drawing.Size(80, 40)
        Me.Turtle2.TabIndex = 21
        Me.Turtle2.TabStop = False
        '
        'Car2
        '
        Me.Car2.BackColor = System.Drawing.Color.Brown
        Me.Car2.Location = New System.Drawing.Point(477, 380)
        Me.Car2.Name = "Car2"
        Me.Car2.Size = New System.Drawing.Size(60, 40)
        Me.Car2.TabIndex = 19
        Me.Car2.TabStop = False
        '
        'Truck2
        '
        Me.Truck2.BackColor = System.Drawing.Color.Brown
        Me.Truck2.Location = New System.Drawing.Point(478, 298)
        Me.Truck2.Name = "Truck2"
        Me.Truck2.Size = New System.Drawing.Size(120, 40)
        Me.Truck2.TabIndex = 18
        Me.Truck2.TabStop = False
        '
        'MedCar2
        '
        Me.MedCar2.BackColor = System.Drawing.Color.Brown
        Me.MedCar2.Location = New System.Drawing.Point(-77, 339)
        Me.MedCar2.Name = "MedCar2"
        Me.MedCar2.Size = New System.Drawing.Size(80, 40)
        Me.MedCar2.TabIndex = 15
        Me.MedCar2.TabStop = False
        '
        'FasCar2
        '
        Me.FasCar2.BackColor = System.Drawing.Color.Brown
        Me.FasCar2.Location = New System.Drawing.Point(-55, 257)
        Me.FasCar2.Name = "FasCar2"
        Me.FasCar2.Size = New System.Drawing.Size(60, 40)
        Me.FasCar2.TabIndex = 14
        Me.FasCar2.TabStop = False
        '
        'Border
        '
        Me.Border.BackColor = System.Drawing.Color.Teal
        Me.Border.Location = New System.Drawing.Point(-10, 464)
        Me.Border.Name = "Border"
        Me.Border.Size = New System.Drawing.Size(500, 40)
        Me.Border.TabIndex = 8
        Me.Border.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 421)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 40)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Midline
        '
        Me.Midline.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Midline.Location = New System.Drawing.Point(-10, 216)
        Me.Midline.Name = "Midline"
        Me.Midline.Size = New System.Drawing.Size(500, 40)
        Me.Midline.TabIndex = 5
        Me.Midline.TabStop = False
        '
        'Turtle
        '
        Me.Turtle.BackColor = System.Drawing.Color.DarkOrange
        Me.Turtle.Location = New System.Drawing.Point(3, 175)
        Me.Turtle.Name = "Turtle"
        Me.Turtle.Size = New System.Drawing.Size(80, 40)
        Me.Turtle.TabIndex = 9
        Me.Turtle.TabStop = False
        '
        'SmallLog
        '
        Me.SmallLog.BackColor = System.Drawing.Color.DarkOrange
        Me.SmallLog.Location = New System.Drawing.Point(401, 134)
        Me.SmallLog.Name = "SmallLog"
        Me.SmallLog.Size = New System.Drawing.Size(80, 40)
        Me.SmallLog.TabIndex = 10
        Me.SmallLog.TabStop = False
        '
        'MedLog
        '
        Me.MedLog.BackColor = System.Drawing.Color.DarkOrange
        Me.MedLog.Location = New System.Drawing.Point(3, 93)
        Me.MedLog.Name = "MedLog"
        Me.MedLog.Size = New System.Drawing.Size(120, 40)
        Me.MedLog.TabIndex = 11
        Me.MedLog.TabStop = False
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.Color.DarkOrange
        Me.Log.Location = New System.Drawing.Point(341, 52)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(140, 40)
        Me.Log.TabIndex = 13
        Me.Log.TabStop = False
        '
        'Car
        '
        Me.Car.BackColor = System.Drawing.Color.Brown
        Me.Car.Location = New System.Drawing.Point(421, 380)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(60, 40)
        Me.Car.TabIndex = 2
        Me.Car.TabStop = False
        '
        'MedCar
        '
        Me.MedCar.BackColor = System.Drawing.Color.Brown
        Me.MedCar.Location = New System.Drawing.Point(3, 339)
        Me.MedCar.Name = "MedCar"
        Me.MedCar.Size = New System.Drawing.Size(80, 40)
        Me.MedCar.TabIndex = 3
        Me.MedCar.TabStop = False
        '
        'FasCar
        '
        Me.FasCar.BackColor = System.Drawing.Color.Brown
        Me.FasCar.Location = New System.Drawing.Point(3, 257)
        Me.FasCar.Name = "FasCar"
        Me.FasCar.Size = New System.Drawing.Size(60, 40)
        Me.FasCar.TabIndex = 6
        Me.FasCar.TabStop = False
        '
        'Truck
        '
        Me.Truck.BackColor = System.Drawing.Color.Brown
        Me.Truck.BackgroundImage = Global.Frogger2._0.My.Resources.Resources.Car
        Me.Truck.Image = Global.Frogger2._0.My.Resources.Resources.Car
        Me.Truck.Location = New System.Drawing.Point(361, 298)
        Me.Truck.Name = "Truck"
        Me.Truck.Size = New System.Drawing.Size(120, 40)
        Me.Truck.TabIndex = 4
        Me.Truck.TabStop = False
        '
        'FinLine
        '
        Me.FinLine.BackColor = System.Drawing.Color.DarkSlateGray
        Me.FinLine.Location = New System.Drawing.Point(-10, -5)
        Me.FinLine.Name = "FinLine"
        Me.FinLine.Size = New System.Drawing.Size(500, 56)
        Me.FinLine.TabIndex = 12
        Me.FinLine.TabStop = False
        '
        'Water
        '
        Me.Water.BackColor = System.Drawing.Color.DarkCyan
        Me.Water.Location = New System.Drawing.Point(-10, 52)
        Me.Water.Name = "Water"
        Me.Water.Size = New System.Drawing.Size(500, 163)
        Me.Water.TabIndex = 20
        Me.Water.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.HighScore)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Frog)
        Me.Controls.Add(Me.Log2)
        Me.Controls.Add(Me.MedLog2)
        Me.Controls.Add(Me.SmallLog2)
        Me.Controls.Add(Me.Turtle2)
        Me.Controls.Add(Me.Car2)
        Me.Controls.Add(Me.Truck2)
        Me.Controls.Add(Me.MedCar2)
        Me.Controls.Add(Me.FasCar2)
        Me.Controls.Add(Me.Border)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Midline)
        Me.Controls.Add(Me.Turtle)
        Me.Controls.Add(Me.SmallLog)
        Me.Controls.Add(Me.MedLog)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.MedCar)
        Me.Controls.Add(Me.FasCar)
        Me.Controls.Add(Me.Truck)
        Me.Controls.Add(Me.FinLine)
        Me.Controls.Add(Me.Water)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Frogger"
        CType(Me.Frog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedLog2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmallLog2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turtle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Midline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turtle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmallLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Water, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FroggerMechanic As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Car As PictureBox
    Friend WithEvents MedCar As PictureBox
    Friend WithEvents Truck As PictureBox
    Friend WithEvents Midline As PictureBox
    Friend WithEvents FasCar As PictureBox
    Friend WithEvents Border As PictureBox
    Friend WithEvents Turtle As PictureBox
    Friend WithEvents SmallLog As PictureBox
    Friend WithEvents MedLog As PictureBox
    Friend WithEvents FinLine As PictureBox
    Friend WithEvents Log As PictureBox
    Friend WithEvents FasCar2 As PictureBox
    Friend WithEvents Frog As PictureBox
    Friend WithEvents MedCar2 As PictureBox
    Friend WithEvents Truck2 As PictureBox
    Friend WithEvents Car2 As PictureBox
    Friend WithEvents Ret As Timer
    Friend WithEvents Water As PictureBox
    Friend WithEvents GameOver As Timer
    Friend WithEvents WaterMechanics As Timer
    Friend WithEvents Turtle2 As PictureBox
    Friend WithEvents WatRet As Timer
    Friend WithEvents SmallLog2 As PictureBox
    Friend WithEvents MedLog2 As PictureBox
    Friend WithEvents Log2 As PictureBox
    Friend WithEvents WaterSafety As Timer
    Friend WithEvents LogSwimming As Timer
    Friend WithEvents GameWin As Timer
    Friend WithEvents Score As Label
    Friend WithEvents HighScore As Label
End Class
