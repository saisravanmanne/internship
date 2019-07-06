Public Module RoboChassis

    Public Structure Bot

        Dim WheelRad As Double      'Radius of the Wheel
        Dim StepsPerRev As Integer  'Steps per Revolution 
        Dim BotWidth As Double      'Distance between wheels of bot

    End Structure

    Public Structure InitialValz

        Dim Xpos As Double          'Input X Centre of Mass Position
        Dim YPos As Double          'Input Y Centre of Mass Position
        Dim AngDeg As Double        'Input Ang in Deg
        Dim Reldist As Double       'Input Relative distance to be moved in mm
        Dim RelAngDeg As Double     'Input Relative angle to be moved in Deg

    End Structure

    Public Structure Params

        Dim numStepsOp As Integer   'pulses output 
        Dim theta As Double         'angle to be moved in radians
        Dim APS As Double           'angle per step

    End Structure

    Public Structure Point2D

        Dim X As Double             'Output for Left wheel 
        Dim Y As Double             'Output for Right wheel

    End Structure

    Dim i As Double = 0
    Dim dummy1 As Double = 0
    Public Sub Forwardcmd(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Dim dist2MvWheel2 As Double
        Dim Dummytheta As Double
        Dim DummynumStepsOp As Double

        Output.APS = (2 * Math.PI) / BotDimension.StepsPerRev
        Output.theta = Input.Reldist / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        If dummy1 = Input.AngDeg Then
            i = i + 1
        Else
            i = 1
        End If

        If i <= 1 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.AngDeg - dummy1
            dist2MvWheel2 = BotDimension.BotWidth * Input.AngDeg * Math.PI / 180
            Dummytheta = dist2MvWheel2 / BotDimension.WheelRad
            DummynumStepsOp = Math.Round(Output.theta / Output.APS)
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text
        End If

        dummy1 = Input.AngDeg
        WheelBot.COMXPos.Text = Math.Round(WheelBot.COMXPos.Text + Input.Reldist * Math.Cos(WheelBot.COMAngDeg.Text * Math.PI / 180))
        WheelBot.COMYPos.Text = Math.Round(WheelBot.COMYPos.Text + Input.Reldist * Math.Sin(WheelBot.COMAngDeg.Text * Math.PI / 180))

        TargetPos.X = -0.5 * DummynumStepsOp
        TargetPos.Y = 0.5 * DummynumStepsOp

        TargetPos.X = Output.numStepsOp
        TargetPos.Y = Output.numStepsOp
        'VectorMove(TargetPos, False)
    End Sub


    Dim j As Double = 0
    Public Sub Reversecmd(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Dim dist2MvWheel2 As Double
        Dim Dummytheta As Double
        Dim DummynumStepsOp As Double

        Output.APS = (2 * Math.PI) / BotDimension.StepsPerRev
        Output.theta = Input.Reldist / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        If dummy1 = Input.AngDeg Then
            j = j + 2
        Else
            j = 1
        End If

        If j <= 1 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.AngDeg - dummy1
            dist2MvWheel2 = BotDimension.BotWidth * Input.AngDeg * Math.PI / 180
            Dummytheta = dist2MvWheel2 / BotDimension.WheelRad
            DummynumStepsOp = Math.Round(Output.theta / Output.APS)
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text
        End If

        dummy1 = Input.AngDeg
        WheelBot.COMXPos.Text = Math.Round(WheelBot.COMXPos.Text - Input.Reldist * Math.Cos(WheelBot.COMAngDeg.Text * Math.PI / 180))
        WheelBot.COMYPos.Text = Math.Round(WheelBot.COMYPos.Text - Input.Reldist * Math.Sin(WheelBot.COMAngDeg.Text * Math.PI / 180))

        TargetPos.X = -0.5 * DummynumStepsOp
        TargetPos.Y = 0.5 * DummynumStepsOp

        TargetPos.X = -1 * Output.numStepsOp
        TargetPos.Y = -1 * Output.numStepsOp

        'VectorMove(TargetPos, False)
    End Sub

    Dim dist2MvWheel As Double
    Dim k As Double = 0
    Public Sub LeftWheelCW(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Output.APS = (2 * 3.1459) / BotDimension.StepsPerRev
        dist2MvWheel = BotDimension.BotWidth * Input.RelAngDeg * Math.PI / 180
        Output.theta = dist2MvWheel / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        TargetPos.X = Output.numStepsOp

        If i = 0 And j = 0 And k = 0 And l = 0 And m = 0 And n = 0 And p = 0 And q = 0 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text - Input.RelAngDeg + Input.AngDeg
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text - Input.RelAngDeg
        End If

        k = k + 1
        WheelBot.COMXPos.Text = Math.Round((WheelBot.COMXPos.Text + 90 * Math.Sin((WheelBot.COMAngDeg.Text + Input.RelAngDeg) * Math.PI / 180)) + (90 * Math.Sin(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        WheelBot.COMYPos.Text = Math.Round((WheelBot.COMYPos.Text - 90 * Math.Cos((WheelBot.COMAngDeg.Text + Input.RelAngDeg) * Math.PI / 180)) + (90 * Math.Cos(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        'VectorMove(TargetPos, False)
    End Sub

    Dim l As Double = 0
    Public Sub LeftWheelCCW(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Output.APS = (2 * 3.1459) / BotDimension.StepsPerRev
        dist2MvWheel = BotDimension.BotWidth * Input.RelAngDeg * Math.PI / 180
        Output.theta = dist2MvWheel / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        TargetPos.X = -1 * Output.numStepsOp

        If i = 0 And j = 0 And k = 0 And l = 0 And m = 0 And n = 0 And p = 0 And q = 0 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.RelAngDeg + Input.AngDeg
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.RelAngDeg
        End If

        l = l + 1
        WheelBot.COMXPos.Text = Math.Round((WheelBot.COMXPos.Text - 90 * Math.Sin((WheelBot.COMAngDeg.Text - Input.RelAngDeg) * Math.PI / 180)) - (90 * Math.Sin(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        WheelBot.COMYPos.Text = Math.Round((WheelBot.COMYPos.Text - 90 * Math.Cos((WheelBot.COMAngDeg.Text - Input.RelAngDeg) * Math.PI / 180)) + (90 * Math.Cos(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        'VectorMove(TargetPos, False)
    End Sub

    Dim m As Double = 0
    Public Sub RightWheelCW(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Output.APS = (2 * 3.1459) / BotDimension.StepsPerRev
        dist2MvWheel = BotDimension.BotWidth * Input.RelAngDeg * Math.PI / 180
        Output.theta = dist2MvWheel / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        TargetPos.Y = Output.numStepsOp

        If i = 0 And j = 0 And k = 0 And l = 0 And m = 0 And n = 0 And p = 0 And q = 0 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.RelAngDeg + Input.AngDeg
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.RelAngDeg
        End If

        m = m + 1
        WheelBot.COMXPos.Text = Math.Round((WheelBot.COMXPos.Text + 90 * Math.Sin((WheelBot.COMAngDeg.Text - Input.RelAngDeg) * Math.PI / 180)) + (90 * Math.Sin(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        WheelBot.COMYPos.Text = Math.Round((WheelBot.COMYPos.Text + 90 * Math.Cos((WheelBot.COMAngDeg.Text - Input.RelAngDeg) * Math.PI / 180)) - (90 * Math.Cos(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        'VectorMove(TargetPos, False)
    End Sub

    Dim n As Double = 0
    Public Sub RightWheelCCW(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Output.APS = (2 * 3.1459) / BotDimension.StepsPerRev
        dist2MvWheel = BotDimension.BotWidth * Input.RelAngDeg * Math.PI / 180
        Output.theta = dist2MvWheel / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        TargetPos.Y = -1 * Output.numStepsOp

        If i = 0 And j = 0 And k = 0 And l = 0 And m = 0 And n = 0 And p = 0 And q = 0 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text - Input.RelAngDeg + Input.AngDeg
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text - Input.RelAngDeg
        End If

        n = n + 1
        WheelBot.COMXPos.Text = Math.Round((WheelBot.COMXPos.Text - 90 * Math.Sin((WheelBot.COMAngDeg.Text + Input.RelAngDeg) * Math.PI / 180)) - (90 * Math.Sin(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        WheelBot.COMYPos.Text = Math.Round((WheelBot.COMYPos.Text + 90 * Math.Cos((WheelBot.COMAngDeg.Text + Input.RelAngDeg) * Math.PI / 180)) - (90 * Math.Cos(WheelBot.COMAngDeg.Text * Math.PI / 180)))
        'VectorMove(TargetPos, False)
    End Sub

    Dim p As Double = 0
    Public Sub RotateBotCW(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Output.APS = (2 * 3.1459) / BotDimension.StepsPerRev
        dist2MvWheel = BotDimension.BotWidth * Input.RelAngDeg * Math.PI / 180
        Output.theta = dist2MvWheel / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        TargetPos.X = Math.Round(0.5 * Output.numStepsOp)
        TargetPos.Y = Math.Round(-0.5 * Output.numStepsOp)

        If i = 0 And j = 0 And k = 0 And l = 0 And m = 0 And n = 0 And p = 0 And q = 0 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text - Input.RelAngDeg + Input.AngDeg
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text - Input.RelAngDeg
        End If

        p = p + 1
        'VectorMove(TargetPos, False)
    End Sub

    Dim q As Double = 0
    Public Sub RotateBotCCW(ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Output.APS = (2 * 3.1459) / BotDimension.StepsPerRev
        dist2MvWheel = BotDimension.BotWidth * Input.RelAngDeg * Math.PI / 180
        Output.theta = dist2MvWheel / BotDimension.WheelRad
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        TargetPos.X = Math.Round(-0.5 * Output.numStepsOp)
        TargetPos.Y = Math.Round(0.5 * Output.numStepsOp)

        If i = 0 And j = 0 And k = 0 And l = 0 And m = 0 And n = 0 And p = 0 And q = 0 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.RelAngDeg + Input.AngDeg
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Input.RelAngDeg
        End If

        q = q + 1
        'VectorMove(TargetPos, False)
    End Sub

    Dim AngleRad As Double
    Dim dummy3 As Double
    Dim r As Double = 0
    Dim dummytheta As Double
    Dim dummynumStepsOp As Double
    Dim RelAngRad As Double
    Public Sub Mv2Point(ByVal DestX As Double, ByVal DestY As Double, ByVal BotDimension As Bot, ByVal Input As InitialValz, ByVal Output As Params, ByVal TargetPos As Point2D)

        Dim Dist2Mv As Double
        Dim Dist2Mv2 As Double
        Dim XPos As Double
        Dim YPos As Double
        'Dim PixelperMM As Double

        XPos = DestX
        YPos = 198 - DestY

        If XPos = 0 And YPos = 0 Then
            AngleRad = 0
        Else
            AngleRad = Math.Atan(YPos / XPos)
        End If

        RelAngRad = (AngleRad - (WheelBot.COMAngDeg.Text * Math.PI / 180))
        Dist2Mv = Math.Sqrt((WheelBot.COMXPos.Text - XPos) ^ 2 + (WheelBot.COMYPos.Text - YPos) ^ 2)

        If RelAngRad > Math.PI Then
            RelAngRad = (-2 * Math.PI) + RelAngRad
        ElseIf RelAngRad < -1 * Math.PI Then
            RelAngRad = (2 * Math.PI) + RelAngRad
        Else
            RelAngRad = RelAngRad
        End If

        Output.APS = (2 * Math.PI) / BotDimension.StepsPerRev
        Dist2Mv2 = BotDimension.BotWidth * RelAngRad
        dummytheta = Dist2Mv2 / BotDimension.WheelRad
        Output.theta = Dist2Mv / BotDimension.WheelRad
        dummynumStepsOp = Math.Round(dummytheta / Output.APS)
        Output.numStepsOp = Math.Round(Output.theta / Output.APS)

        'First Bot should rotate and then move to the point.
        TargetPos.X = -0.5 * dummynumStepsOp
        TargetPos.Y = 0.5 * dummynumStepsOp

        TargetPos.X = Output.numStepsOp
        TargetPos.Y = Output.numStepsOp

        If dummy3 = Math.Round(RelAngRad * 180 / Math.PI) Then
            r = r + 1
        Else
            r = 1
        End If

        If r <= 1 Then
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text + Math.Round(RelAngRad * 180 / Math.PI)
        Else
            WheelBot.COMAngDeg.Text = WheelBot.COMAngDeg.Text
        End If

        dummy3 = Math.Round(RelAngRad * 180 / Math.PI)
        WheelBot.COMXPos.Text = XPos
        WheelBot.COMYPos.Text = YPos
        'VectorMove(TargetPos, False)
    End Sub
End Module