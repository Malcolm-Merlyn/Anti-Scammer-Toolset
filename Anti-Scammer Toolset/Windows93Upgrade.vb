Public Class Windows93Upgrade

    Dim counter As Integer = 0
    Dim updateIn As Integer = 30

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        counter += 1
        UpdateTime()

        Try
            If counter >= updateIn Then
                Process.Start(AntiScammerToolset.currentDirectory & "\windows93.exe")
                UpdateTimer.Stop()
                Me.Close()
            End If
        Catch
        End Try
    End Sub

    Private Sub postponeBtn_Click(sender As Object, e As EventArgs) Handles postponeBtn.Click
        updateIn += 1
        UpdateTime()

        If updateIn >= 59 Then
            updateIn = 59
            postponeBtn.Enabled = False
        End If
    End Sub

    Public Sub UpdateTime()
        Dim timeLeft As Integer = updateIn - counter
        If timeLeft < 0 Then
            timeLeft = 0
        End If

        If timeLeft < 10 Then
            timeLabel.Text = "FREE UPGRADE STARTING IN: 0:0" + timeLeft.ToString
        Else
            timeLabel.Text = "FREE UPGRADE STARTING IN: 0:" + timeLeft.ToString
        End If
    End Sub

    Private Sub Windows93Upgrade_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
End Class