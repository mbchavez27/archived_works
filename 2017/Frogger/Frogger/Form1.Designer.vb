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
        Me.Road1 = New System.Windows.Forms.PictureBox()
        Me.Start = New System.Windows.Forms.PictureBox()
        Me.Road2 = New System.Windows.Forms.PictureBox()
        Me.Frog = New System.Windows.Forms.PictureBox()
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.Middle = New System.Windows.Forms.PictureBox()
        Me.Finish = New System.Windows.Forms.PictureBox()
        Me.CarMove = New System.Windows.Forms.Timer(Me.components)
        Me.Collision = New System.Windows.Forms.Timer(Me.components)
        Me.CarCollection = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RightEnd = New System.Windows.Forms.PictureBox()
        Me.LeftEnd = New System.Windows.Forms.PictureBox()
        Me.Car2 = New System.Windows.Forms.PictureBox()
        Me.Car3 = New System.Windows.Forms.PictureBox()
        Me.Car4 = New System.Windows.Forms.PictureBox()
        Me.Car5 = New System.Windows.Forms.PictureBox()
        Me.Car6 = New System.Windows.Forms.PictureBox()
        Me.FrogDeaths = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Scoring = New System.Windows.Forms.Timer(Me.components)
        Me.Score = New System.Windows.Forms.Label()
        Me.HighScore = New System.Windows.Forms.Label()
        CType(Me.Road1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Road2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Middle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Road1
        '
        Me.Road1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Road1.Location = New System.Drawing.Point(-3, 226)
        Me.Road1.Name = "Road1"
        Me.Road1.Size = New System.Drawing.Size(812, 191)
        Me.Road1.TabIndex = 0
        Me.Road1.TabStop = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.DarkGreen
        Me.Start.Location = New System.Drawing.Point(-3, 414)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(812, 31)
        Me.Start.TabIndex = 1
        Me.Start.TabStop = False
        '
        'Road2
        '
        Me.Road2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Road2.Location = New System.Drawing.Point(-3, 24)
        Me.Road2.Name = "Road2"
        Me.Road2.Size = New System.Drawing.Size(812, 182)
        Me.Road2.TabIndex = 3
        Me.Road2.TabStop = False
        '
        'Frog
        '
        Me.Frog.BackColor = System.Drawing.Color.Orange
        Me.Frog.Location = New System.Drawing.Point(381, 414)
        Me.Frog.Name = "Frog"
        Me.Frog.Size = New System.Drawing.Size(37, 30)
        Me.Frog.TabIndex = 5
        Me.Frog.TabStop = False
        '
        'Car
        '
        Me.Car.BackColor = System.Drawing.Color.DarkRed
        Me.Car.Location = New System.Drawing.Point(8, 366)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(63, 30)
        Me.Car.TabIndex = 15
        Me.Car.TabStop = False
        '
        'Middle
        '
        Me.Middle.BackColor = System.Drawing.Color.DarkGreen
        Me.Middle.Location = New System.Drawing.Point(-3, 185)
        Me.Middle.Name = "Middle"
        Me.Middle.Size = New System.Drawing.Size(812, 46)
        Me.Middle.TabIndex = 6
        Me.Middle.TabStop = False
        '
        'Finish
        '
        Me.Finish.BackColor = System.Drawing.Color.DarkGreen
        Me.Finish.Location = New System.Drawing.Point(-3, -19)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(812, 57)
        Me.Finish.TabIndex = 7
        Me.Finish.TabStop = False
        '
        'CarMove
        '
        '
        'Collision
        '
        '
        'CarCollection
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Location = New System.Drawing.Point(809, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 452)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Green
        Me.PictureBox2.Location = New System.Drawing.Point(-19, -8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 452)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'RightEnd
        '
        Me.RightEnd.BackColor = System.Drawing.Color.Green
        Me.RightEnd.Location = New System.Drawing.Point(803, -1)
        Me.RightEnd.Name = "RightEnd"
        Me.RightEnd.Size = New System.Drawing.Size(54, 446)
        Me.RightEnd.TabIndex = 18
        Me.RightEnd.TabStop = False
        '
        'LeftEnd
        '
        Me.LeftEnd.BackColor = System.Drawing.Color.Green
        Me.LeftEnd.Location = New System.Drawing.Point(-50, -2)
        Me.LeftEnd.Name = "LeftEnd"
        Me.LeftEnd.Size = New System.Drawing.Size(54, 446)
        Me.LeftEnd.TabIndex = 19
        Me.LeftEnd.TabStop = False
        '
        'Car2
        '
        Me.Car2.BackColor = System.Drawing.Color.DarkRed
        Me.Car2.Location = New System.Drawing.Point(734, 309)
        Me.Car2.Name = "Car2"
        Me.Car2.Size = New System.Drawing.Size(63, 30)
        Me.Car2.TabIndex = 20
        Me.Car2.TabStop = False
        '
        'Car3
        '
        Me.Car3.BackColor = System.Drawing.Color.DarkRed
        Me.Car3.Location = New System.Drawing.Point(8, 249)
        Me.Car3.Name = "Car3"
        Me.Car3.Size = New System.Drawing.Size(63, 30)
        Me.Car3.TabIndex = 21
        Me.Car3.TabStop = False
        '
        'Car4
        '
        Me.Car4.BackColor = System.Drawing.Color.DarkRed
        Me.Car4.Location = New System.Drawing.Point(732, 149)
        Me.Car4.Name = "Car4"
        Me.Car4.Size = New System.Drawing.Size(63, 30)
        Me.Car4.TabIndex = 22
        Me.Car4.TabStop = False
        '
        'Car5
        '
        Me.Car5.BackColor = System.Drawing.Color.DarkRed
        Me.Car5.Location = New System.Drawing.Point(10, 93)
        Me.Car5.Name = "Car5"
        Me.Car5.Size = New System.Drawing.Size(63, 30)
        Me.Car5.TabIndex = 23
        Me.Car5.TabStop = False
        '
        'Car6
        '
        Me.Car6.BackColor = System.Drawing.Color.DarkRed
        Me.Car6.Location = New System.Drawing.Point(732, 44)
        Me.Car6.Name = "Car6"
        Me.Car6.Size = New System.Drawing.Size(63, 30)
        Me.Car6.TabIndex = 24
        Me.Car6.TabStop = False
        '
        'FrogDeaths
        '
        '
        'Timer1
        '
        '
        'Scoring
        '
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.BackColor = System.Drawing.Color.DarkGreen
        Me.Score.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Score.Font = New System.Drawing.Font("Pixel-Art", 30.0!)
        Me.Score.ForeColor = System.Drawing.Color.Orange
        Me.Score.Location = New System.Drawing.Point(13, 0)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(40, 35)
        Me.Score.TabIndex = 25
        Me.Score.Text = "0"
        '
        'HighScore
        '
        Me.HighScore.AutoSize = True
        Me.HighScore.BackColor = System.Drawing.Color.DarkGreen
        Me.HighScore.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HighScore.Font = New System.Drawing.Font("Pixel-Art", 30.0!)
        Me.HighScore.ForeColor = System.Drawing.Color.Orange
        Me.HighScore.Location = New System.Drawing.Point(764, 0)
        Me.HighScore.Name = "HighScore"
        Me.HighScore.Size = New System.Drawing.Size(40, 35)
        Me.HighScore.TabIndex = 27
        Me.HighScore.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 445)
        Me.Controls.Add(Me.HighScore)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Car6)
        Me.Controls.Add(Me.Car5)
        Me.Controls.Add(Me.Car4)
        Me.Controls.Add(Me.Car3)
        Me.Controls.Add(Me.Car2)
        Me.Controls.Add(Me.LeftEnd)
        Me.Controls.Add(Me.RightEnd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Frog)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.Middle)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Road2)
        Me.Controls.Add(Me.Road1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Frogger"
        CType(Me.Road1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Road2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Middle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Road1 As PictureBox
    Friend WithEvents Start As PictureBox
    Friend WithEvents Road2 As PictureBox
    Friend WithEvents Frog As PictureBox
    Friend WithEvents Car As PictureBox
    Friend WithEvents Middle As PictureBox
    Friend WithEvents Finish As PictureBox
    Friend WithEvents CarMove As Timer
    Friend WithEvents Collision As Timer
    Friend WithEvents CarCollection As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RightEnd As PictureBox
    Friend WithEvents LeftEnd As PictureBox
    Friend WithEvents Car2 As PictureBox
    Friend WithEvents Car3 As PictureBox
    Friend WithEvents Car4 As PictureBox
    Friend WithEvents Car5 As PictureBox
    Friend WithEvents Car6 As PictureBox
    Friend WithEvents FrogDeaths As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Scoring As Timer
    Friend WithEvents Score As Label
    Friend WithEvents HighScore As Label
End Class
