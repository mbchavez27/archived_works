<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HighScore = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Pixel-Art", 36.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(39, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Frogger"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Pixel-Art", 24.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Orange
        Me.Button1.Location = New System.Drawing.Point(74, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Pixel-Art", 24.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Orange
        Me.Button2.Location = New System.Drawing.Point(74, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 71)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'HighScore
        '
        Me.HighScore.AutoSize = True
        Me.HighScore.Font = New System.Drawing.Font("Pixel-Art", 24.0!)
        Me.HighScore.ForeColor = System.Drawing.Color.Orange
        Me.HighScore.Location = New System.Drawing.Point(12, 300)
        Me.HighScore.Name = "HighScore"
        Me.HighScore.Size = New System.Drawing.Size(234, 28)
        Me.HighScore.TabIndex = 3
        Me.HighScore.Text = "HighScore:"
        '
        'Number
        '
        Me.Number.AutoSize = True
        Me.Number.Font = New System.Drawing.Font("Pixel-Art", 24.0!)
        Me.Number.ForeColor = System.Drawing.Color.Orange
        Me.Number.Location = New System.Drawing.Point(240, 303)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(32, 28)
        Me.Number.TabIndex = 4
        Me.Number.Text = "0"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(330, 344)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.HighScore)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HighScore As Label
    Friend WithEvents Number As Label
End Class
