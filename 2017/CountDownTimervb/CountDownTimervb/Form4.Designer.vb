<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Colon = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cover = New System.Windows.Forms.Label()
        Me.CheckFinished = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Gotham", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(99, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.LightCoral
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Start.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(43, 111)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(197, 69)
        Me.Start.TabIndex = 10
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.Font = New System.Drawing.Font("Gotham", 47.99999!, System.Drawing.FontStyle.Bold)
        Me.Minutes.Location = New System.Drawing.Point(19, 24)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(117, 71)
        Me.Minutes.TabIndex = 11
        Me.Minutes.Text = "05"
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.Font = New System.Drawing.Font("Gotham", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.Location = New System.Drawing.Point(157, 24)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(119, 71)
        Me.Seconds.TabIndex = 12
        Me.Seconds.Text = "60"
        '
        'Colon
        '
        Me.Colon.AutoSize = True
        Me.Colon.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon.Location = New System.Drawing.Point(129, 39)
        Me.Colon.Name = "Colon"
        Me.Colon.Size = New System.Drawing.Size(37, 53)
        Me.Colon.TabIndex = 13
        Me.Colon.Text = ":"
        '
        'Count
        '
        Me.Count.Interval = 1000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(43, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 69)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Pause"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCoral
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(43, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(197, 69)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Cover
        '
        Me.Cover.AutoSize = True
        Me.Cover.Font = New System.Drawing.Font("Gotham", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cover.Location = New System.Drawing.Point(153, 24)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(124, 71)
        Me.Cover.TabIndex = 16
        Me.Cover.Text = "00"
        '
        'CheckFinished
        '
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(284, 332)
        Me.Controls.Add(Me.Cover)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Colon)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Countdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Start As Button
    Friend WithEvents Minutes As Label
    Friend WithEvents Seconds As Label
    Friend WithEvents Colon As Label
    Friend WithEvents Count As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Cover As Label
    Friend WithEvents CheckFinished As Timer
End Class
