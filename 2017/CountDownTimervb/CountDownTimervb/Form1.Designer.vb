<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Count = New System.Windows.Forms.Timer(Me.components)
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Colon = New System.Windows.Forms.Label()
        Me.Starter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Stoppp = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Count
        '
        Me.Count.Interval = 1000
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.Font = New System.Drawing.Font("Gotham", 47.99999!, System.Drawing.FontStyle.Bold)
        Me.Minutes.Location = New System.Drawing.Point(12, 0)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(77, 71)
        Me.Minutes.TabIndex = 0
        Me.Minutes.Text = "0"
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.Font = New System.Drawing.Font("Gotham", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.Location = New System.Drawing.Point(135, 0)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(77, 71)
        Me.Seconds.TabIndex = 1
        Me.Seconds.Text = "0"
        '
        'Colon
        '
        Me.Colon.AutoSize = True
        Me.Colon.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon.Location = New System.Drawing.Point(99, 9)
        Me.Colon.Name = "Colon"
        Me.Colon.Size = New System.Drawing.Size(37, 53)
        Me.Colon.TabIndex = 2
        Me.Colon.Text = ":"
        '
        'Starter
        '
        Me.Starter.BackColor = System.Drawing.Color.LightCoral
        Me.Starter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Starter.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starter.Location = New System.Drawing.Point(15, 73)
        Me.Starter.Name = "Starter"
        Me.Starter.Size = New System.Drawing.Size(197, 69)
        Me.Starter.TabIndex = 3
        Me.Starter.Text = "Start"
        Me.Starter.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(58, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Stoppp
        '
        Me.Stoppp.BackColor = System.Drawing.Color.LightCoral
        Me.Stoppp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Stoppp.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stoppp.Location = New System.Drawing.Point(15, 73)
        Me.Stoppp.Name = "Stoppp"
        Me.Stoppp.Size = New System.Drawing.Size(197, 69)
        Me.Stoppp.TabIndex = 6
        Me.Stoppp.Text = "Stop"
        Me.Stoppp.UseVisualStyleBackColor = False
        Me.Stoppp.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Gotham", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 69)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(238, 286)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Stoppp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Starter)
        Me.Controls.Add(Me.Colon)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "StopWatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Count As Timer
    Friend WithEvents Minutes As Label
    Friend WithEvents Seconds As Label
    Friend WithEvents Colon As Label
    Friend WithEvents Starter As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Stoppp As Button
    Friend WithEvents Button2 As Button
End Class
