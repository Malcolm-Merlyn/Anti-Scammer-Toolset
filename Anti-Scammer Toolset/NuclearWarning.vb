Public Class NuclearWarning

    Dim color As String = "Yellow"

    Public Sub SetLocation(x As Integer, y As Integer)
        Me.Location = New Point(x, y)
        Me.TopMost = True
    End Sub

    Private Sub ColorTimer_Tick(sender As Object, e As EventArgs) Handles ColorTimer.Tick
        If color = "Yellow" Then
            Me.BackgroundImage = My.Resources.NuclearWarningRed
            color = "Red"
        Else
            Me.BackgroundImage = My.Resources.NuclearWarningYellow
            color = "Yellow"
        End If
    End Sub
End Class