<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WheelBot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WheelBot))
        Me.txtWheelRad = New System.Windows.Forms.TextBox()
        Me.txtStepsPerRev = New System.Windows.Forms.TextBox()
        Me.txtChassisWidth = New System.Windows.Forms.TextBox()
        Me.txtXPos = New System.Windows.Forms.TextBox()
        Me.txtYPos = New System.Windows.Forms.TextBox()
        Me.txtAngDeg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Initialvalz = New System.Windows.Forms.Button()
        Me.txtReldist = New System.Windows.Forms.TextBox()
        Me.txtRelAng = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fwdcmd = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COMAngDeg = New System.Windows.Forms.TextBox()
        Me.COMYPos = New System.Windows.Forms.TextBox()
        Me.COMXPos = New System.Windows.Forms.TextBox()
        Me.leftccwcmd = New System.Windows.Forms.Button()
        Me.leftcwcmd = New System.Windows.Forms.Button()
        Me.rightccwcmd = New System.Windows.Forms.Button()
        Me.rightcwcmd = New System.Windows.Forms.Button()
        Me.revcmd = New System.Windows.Forms.Button()
        Me.RotateBotCWCmd = New System.Windows.Forms.Button()
        Me.RotateBotCCWCmd = New System.Windows.Forms.Button()
        Me.Mv2PointCmd = New System.Windows.Forms.PictureBox()
        CType(Me.Mv2PointCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtWheelRad
        '
        Me.txtWheelRad.Location = New System.Drawing.Point(26, 70)
        Me.txtWheelRad.Name = "txtWheelRad"
        Me.txtWheelRad.Size = New System.Drawing.Size(60, 20)
        Me.txtWheelRad.TabIndex = 0
        Me.txtWheelRad.Text = "1000"
        '
        'txtStepsPerRev
        '
        Me.txtStepsPerRev.Location = New System.Drawing.Point(104, 30)
        Me.txtStepsPerRev.Name = "txtStepsPerRev"
        Me.txtStepsPerRev.Size = New System.Drawing.Size(60, 20)
        Me.txtStepsPerRev.TabIndex = 1
        Me.txtStepsPerRev.Text = "1600"
        '
        'txtChassisWidth
        '
        Me.txtChassisWidth.Location = New System.Drawing.Point(201, 30)
        Me.txtChassisWidth.Name = "txtChassisWidth"
        Me.txtChassisWidth.Size = New System.Drawing.Size(60, 20)
        Me.txtChassisWidth.TabIndex = 2
        Me.txtChassisWidth.Text = "180"
        '
        'txtXPos
        '
        Me.txtXPos.Location = New System.Drawing.Point(26, 128)
        Me.txtXPos.Name = "txtXPos"
        Me.txtXPos.Size = New System.Drawing.Size(60, 20)
        Me.txtXPos.TabIndex = 3
        Me.txtXPos.Text = "0"
        '
        'txtYPos
        '
        Me.txtYPos.Location = New System.Drawing.Point(103, 169)
        Me.txtYPos.Name = "txtYPos"
        Me.txtYPos.Size = New System.Drawing.Size(60, 20)
        Me.txtYPos.TabIndex = 4
        Me.txtYPos.Text = "0"
        '
        'txtAngDeg
        '
        Me.txtAngDeg.Location = New System.Drawing.Point(201, 169)
        Me.txtAngDeg.Name = "txtAngDeg"
        Me.txtAngDeg.Size = New System.Drawing.Size(60, 20)
        Me.txtAngDeg.TabIndex = 5
        Me.txtAngDeg.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Input Ang Deg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Input Y Pos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Input X Pos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Steps Per Rev"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Wheel Radius"
        '
        'Initialvalz
        '
        Me.Initialvalz.Location = New System.Drawing.Point(146, 94)
        Me.Initialvalz.Name = "Initialvalz"
        Me.Initialvalz.Size = New System.Drawing.Size(75, 23)
        Me.Initialvalz.TabIndex = 48
        Me.Initialvalz.Text = "Submit"
        Me.Initialvalz.UseVisualStyleBackColor = True
        '
        'txtReldist
        '
        Me.txtReldist.Location = New System.Drawing.Point(286, 70)
        Me.txtReldist.Name = "txtReldist"
        Me.txtReldist.Size = New System.Drawing.Size(60, 20)
        Me.txtReldist.TabIndex = 49
        Me.txtReldist.Text = "100"
        '
        'txtRelAng
        '
        Me.txtRelAng.Location = New System.Drawing.Point(286, 128)
        Me.txtRelAng.Name = "txtRelAng"
        Me.txtRelAng.Size = New System.Drawing.Size(60, 20)
        Me.txtRelAng.TabIndex = 50
        Me.txtRelAng.Text = "45"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Rel Dist mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Rel Ang Deg"
        '
        'Fwdcmd
        '
        Me.Fwdcmd.Location = New System.Drawing.Point(52, 246)
        Me.Fwdcmd.Name = "Fwdcmd"
        Me.Fwdcmd.Size = New System.Drawing.Size(75, 23)
        Me.Fwdcmd.TabIndex = 53
        Me.Fwdcmd.Text = "Forward"
        Me.Fwdcmd.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(474, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "COM Angle"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(475, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "COM Y Pos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(473, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "COM X Pos"
        '
        'COMAngDeg
        '
        Me.COMAngDeg.Location = New System.Drawing.Point(481, 169)
        Me.COMAngDeg.Name = "COMAngDeg"
        Me.COMAngDeg.Size = New System.Drawing.Size(50, 20)
        Me.COMAngDeg.TabIndex = 61
        Me.COMAngDeg.Text = "0"
        '
        'COMYPos
        '
        Me.COMYPos.Location = New System.Drawing.Point(481, 112)
        Me.COMYPos.Name = "COMYPos"
        Me.COMYPos.Size = New System.Drawing.Size(51, 20)
        Me.COMYPos.TabIndex = 60
        Me.COMYPos.Text = "0"
        '
        'COMXPos
        '
        Me.COMXPos.Location = New System.Drawing.Point(478, 54)
        Me.COMXPos.Name = "COMXPos"
        Me.COMXPos.Size = New System.Drawing.Size(50, 20)
        Me.COMXPos.TabIndex = 59
        Me.COMXPos.Text = "0"
        '
        'leftccwcmd
        '
        Me.leftccwcmd.Location = New System.Drawing.Point(159, 302)
        Me.leftccwcmd.Name = "leftccwcmd"
        Me.leftccwcmd.Size = New System.Drawing.Size(91, 23)
        Me.leftccwcmd.TabIndex = 58
        Me.leftccwcmd.Text = "LeftWheelCCW"
        Me.leftccwcmd.UseVisualStyleBackColor = True
        '
        'leftcwcmd
        '
        Me.leftcwcmd.Location = New System.Drawing.Point(159, 246)
        Me.leftcwcmd.Name = "leftcwcmd"
        Me.leftcwcmd.Size = New System.Drawing.Size(91, 23)
        Me.leftcwcmd.TabIndex = 57
        Me.leftcwcmd.Text = "LeftWheelCW"
        Me.leftcwcmd.UseVisualStyleBackColor = True
        '
        'rightccwcmd
        '
        Me.rightccwcmd.Location = New System.Drawing.Point(286, 302)
        Me.rightccwcmd.Name = "rightccwcmd"
        Me.rightccwcmd.Size = New System.Drawing.Size(99, 23)
        Me.rightccwcmd.TabIndex = 56
        Me.rightccwcmd.Text = "RightWheelCCW"
        Me.rightccwcmd.UseVisualStyleBackColor = True
        '
        'rightcwcmd
        '
        Me.rightcwcmd.Location = New System.Drawing.Point(286, 246)
        Me.rightcwcmd.Name = "rightcwcmd"
        Me.rightcwcmd.Size = New System.Drawing.Size(99, 23)
        Me.rightcwcmd.TabIndex = 55
        Me.rightcwcmd.Text = "RightWheelCW"
        Me.rightcwcmd.UseVisualStyleBackColor = True
        '
        'revcmd
        '
        Me.revcmd.Location = New System.Drawing.Point(52, 302)
        Me.revcmd.Name = "revcmd"
        Me.revcmd.Size = New System.Drawing.Size(75, 23)
        Me.revcmd.TabIndex = 54
        Me.revcmd.Text = "Reverse"
        Me.revcmd.UseVisualStyleBackColor = True
        '
        'RotateBotCWCmd
        '
        Me.RotateBotCWCmd.Location = New System.Drawing.Point(104, 369)
        Me.RotateBotCWCmd.Name = "RotateBotCWCmd"
        Me.RotateBotCWCmd.Size = New System.Drawing.Size(82, 23)
        Me.RotateBotCWCmd.TabIndex = 65
        Me.RotateBotCWCmd.Text = "RotateBotCW"
        Me.RotateBotCWCmd.UseVisualStyleBackColor = True
        '
        'RotateBotCCWCmd
        '
        Me.RotateBotCCWCmd.Location = New System.Drawing.Point(237, 369)
        Me.RotateBotCCWCmd.Name = "RotateBotCCWCmd"
        Me.RotateBotCCWCmd.Size = New System.Drawing.Size(93, 23)
        Me.RotateBotCCWCmd.TabIndex = 66
        Me.RotateBotCCWCmd.Text = "RotateBotCCW"
        Me.RotateBotCCWCmd.UseVisualStyleBackColor = True
        '
        'Mv2PointCmd
        '
        Me.Mv2PointCmd.Image = CType(resources.GetObject("Mv2PointCmd.Image"), System.Drawing.Image)
        Me.Mv2PointCmd.Location = New System.Drawing.Point(423, 194)
        Me.Mv2PointCmd.Name = "Mv2PointCmd"
        Me.Mv2PointCmd.Size = New System.Drawing.Size(212, 198)
        Me.Mv2PointCmd.TabIndex = 67
        Me.Mv2PointCmd.TabStop = False
        '
        'WheelBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 434)
        Me.Controls.Add(Me.Mv2PointCmd)
        Me.Controls.Add(Me.RotateBotCCWCmd)
        Me.Controls.Add(Me.RotateBotCWCmd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.COMAngDeg)
        Me.Controls.Add(Me.COMYPos)
        Me.Controls.Add(Me.COMXPos)
        Me.Controls.Add(Me.leftccwcmd)
        Me.Controls.Add(Me.leftcwcmd)
        Me.Controls.Add(Me.rightccwcmd)
        Me.Controls.Add(Me.rightcwcmd)
        Me.Controls.Add(Me.revcmd)
        Me.Controls.Add(Me.Fwdcmd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRelAng)
        Me.Controls.Add(Me.txtReldist)
        Me.Controls.Add(Me.Initialvalz)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAngDeg)
        Me.Controls.Add(Me.txtYPos)
        Me.Controls.Add(Me.txtXPos)
        Me.Controls.Add(Me.txtChassisWidth)
        Me.Controls.Add(Me.txtStepsPerRev)
        Me.Controls.Add(Me.txtWheelRad)
        Me.Name = "WheelBot"
        Me.Text = "Wheel Bot Simulator"
        CType(Me.Mv2PointCmd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWheelRad As System.Windows.Forms.TextBox
    Friend WithEvents txtStepsPerRev As System.Windows.Forms.TextBox
    Friend WithEvents txtChassisWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtXPos As System.Windows.Forms.TextBox
    Friend WithEvents txtYPos As System.Windows.Forms.TextBox
    Friend WithEvents txtAngDeg As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Initialvalz As System.Windows.Forms.Button
    Friend WithEvents txtReldist As System.Windows.Forms.TextBox
    Friend WithEvents txtRelAng As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Fwdcmd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents COMAngDeg As System.Windows.Forms.TextBox
    Friend WithEvents COMYPos As System.Windows.Forms.TextBox
    Friend WithEvents COMXPos As System.Windows.Forms.TextBox
    Friend WithEvents leftccwcmd As System.Windows.Forms.Button
    Friend WithEvents leftcwcmd As System.Windows.Forms.Button
    Friend WithEvents rightccwcmd As System.Windows.Forms.Button
    Friend WithEvents rightcwcmd As System.Windows.Forms.Button
    Friend WithEvents revcmd As System.Windows.Forms.Button
    Friend WithEvents RotateBotCWCmd As System.Windows.Forms.Button
    Friend WithEvents RotateBotCCWCmd As System.Windows.Forms.Button
    Friend WithEvents Mv2PointCmd As System.Windows.Forms.PictureBox

End Class
