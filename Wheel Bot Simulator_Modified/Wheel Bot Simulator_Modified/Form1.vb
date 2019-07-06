Public Class WheelBot

    Dim BotDimension As Bot
    Dim Input As InitialValz
    Dim Output As Params
    Dim TargetPos As Point2D

    Private Sub Initialvalz_Click(sender As Object, e As EventArgs) Handles Initialvalz.Click

        BotDimension.WheelRad = txtWheelRad.Text
        BotDimension.StepsPerRev = txtStepsPerRev.Text
        BotDimension.BotWidth = txtChassisWidth.Text
        Input.Xpos = txtXPos.Text
        Input.YPos = txtYPos.Text
        Input.AngDeg = txtAngDeg.Text
        Input.Reldist = txtReldist.Text
        Input.RelAngDeg = txtRelAng.Text

    End Sub

    Private Sub Fwdcmd_Click(sender As Object, e As EventArgs) Handles Fwdcmd.Click
        Forwardcmd(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub revcmd_Click(sender As Object, e As EventArgs) Handles revcmd.Click
        Reversecmd(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub leftcwcmd_Click(sender As Object, e As EventArgs) Handles leftcwcmd.Click
        LeftWheelCW(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub leftccwcmd_Click(sender As Object, e As EventArgs) Handles leftccwcmd.Click
        LeftWheelCCW(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub rightcwcmd_Click(sender As Object, e As EventArgs) Handles rightcwcmd.Click
        RightWheelCW(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub rightccwcmd_Click(sender As Object, e As EventArgs) Handles rightccwcmd.Click
        RightWheelCCW(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub RotateBotCWCmd_Click(sender As Object, e As EventArgs) Handles RotateBotCWCmd.Click
        RotateBotCW(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub RotateBotCCWCmd_Click(sender As Object, e As EventArgs) Handles RotateBotCCWCmd.Click
        RotateBotCCW(BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub Mv2PointCmd_MouseDown(sender As Object, e As MouseEventArgs) Handles Mv2PointCmd.MouseDown
        Mv2Point(e.X, e.Y, BotDimension, Input, Output, TargetPos)
    End Sub

    Private Sub Mv2PointCmd_Click(sender As Object, e As EventArgs) Handles Mv2PointCmd.Click

    End Sub
End Class