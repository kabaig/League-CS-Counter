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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timer_box = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dataLabel_MinionsSpawned = New System.Windows.Forms.Label()
        Me.dataLabel_CurrentWave = New System.Windows.Forms.Label()
        Me.dataLabel_PerfectCS = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wavetimer = New System.Windows.Forms.Timer(Me.components)
        Me.perfectcounter = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current time"
        '
        'timer_box
        '
        Me.timer_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_box.Location = New System.Drawing.Point(12, 25)
        Me.timer_box.Mask = "##:##"
        Me.timer_box.Name = "timer_box"
        Me.timer_box.Size = New System.Drawing.Size(131, 32)
        Me.timer_box.TabIndex = 1
        Me.timer_box.Text = "0030"
        Me.timer_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(79, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current Wave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Minions Spawned"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Perfect CS"
        '
        'dataLabel_MinionsSpawned
        '
        Me.dataLabel_MinionsSpawned.Location = New System.Drawing.Point(104, 124)
        Me.dataLabel_MinionsSpawned.Name = "dataLabel_MinionsSpawned"
        Me.dataLabel_MinionsSpawned.Size = New System.Drawing.Size(39, 13)
        Me.dataLabel_MinionsSpawned.TabIndex = 4
        Me.dataLabel_MinionsSpawned.Text = "0"
        Me.dataLabel_MinionsSpawned.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dataLabel_CurrentWave
        '
        Me.dataLabel_CurrentWave.Location = New System.Drawing.Point(104, 104)
        Me.dataLabel_CurrentWave.Name = "dataLabel_CurrentWave"
        Me.dataLabel_CurrentWave.Size = New System.Drawing.Size(39, 13)
        Me.dataLabel_CurrentWave.TabIndex = 4
        Me.dataLabel_CurrentWave.Text = "0"
        Me.dataLabel_CurrentWave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dataLabel_PerfectCS
        '
        Me.dataLabel_PerfectCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dataLabel_PerfectCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataLabel_PerfectCS.Location = New System.Drawing.Point(12, 171)
        Me.dataLabel_PerfectCS.Name = "dataLabel_PerfectCS"
        Me.dataLabel_PerfectCS.Size = New System.Drawing.Size(131, 46)
        Me.dataLabel_PerfectCS.TabIndex = 5
        Me.dataLabel_PerfectCS.Text = "0"
        Me.dataLabel_PerfectCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'wavetimer
        '
        Me.wavetimer.Interval = 30000
        '
        'perfectcounter
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 235)
        Me.Controls.Add(Me.dataLabel_PerfectCS)
        Me.Controls.Add(Me.dataLabel_CurrentWave)
        Me.Controls.Add(Me.dataLabel_MinionsSpawned)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.timer_box)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "League Minon Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timer_box As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dataLabel_MinionsSpawned As System.Windows.Forms.Label
    Friend WithEvents dataLabel_CurrentWave As System.Windows.Forms.Label
    Friend WithEvents dataLabel_PerfectCS As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents wavetimer As System.Windows.Forms.Timer
    Friend WithEvents perfectcounter As System.Windows.Forms.Timer

End Class
