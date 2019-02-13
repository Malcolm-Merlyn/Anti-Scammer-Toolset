Public Class VideoForm

    Private Sub VideoForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            Me.VideoPlayer.URL = "anonymous.mp4"
            Me.VideoPlayer.settings.setMode("loop", True)
            Me.VideoPlayer.Ctlcontrols.play()
        End If
    End Sub
End Class