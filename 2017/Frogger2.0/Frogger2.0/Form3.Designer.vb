<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Scor = New System.Windows.Forms.Label()
        Me.Num = New System.Windows.Forms.Label()
        Me.Scoring = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Pixel-Art", 36.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FROGGER2.0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Pixel-Art", 24.0!)
        Me.Button1.Location = New System.Drawing.Point(115, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Pixel-Art", 24.0!)
        Me.Button2.Location = New System.Drawing.Point(115, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Scor
        '
        Me.Scor.AutoSize = True
        Me.Scor.Font = New System.Drawing.Font("Pixel-Art", 30.0!)
        Me.Scor.Location = New System.Drawing.Point(6, 184)
        Me.Scor.Name = "Scor"
        Me.Scor.Size = New System.Drawing.Size(293, 35)
        Me.Scor.TabIndex = 4
        Me.Scor.Text = "HighScore:"
        '
        'Num
        '
        Me.Num.AutoSize = True
        Me.Num.Font = New System.Drawing.Font("Pixel-Art", 30.0!)
        Me.Num.Location = New System.Drawing.Point(292, 186)
        Me.Num.Name = "Num"
        Me.Num.Size = New System.Drawing.Size(40, 35)
        Me.Num.TabIndex = 5
        Me.Num.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Frogger2._0.My.Resources.Resources.Stryker_Entertainment
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 108)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(364, 337)
        Me.Controls.Add(Me.Num)
        Me.Controls.Add(Me.Scor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Scor As Label
    Friend WithEvents Num As Label
    Friend WithEvents Scoring As Timer
End Class
