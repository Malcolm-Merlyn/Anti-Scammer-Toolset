Public Class VirusForm

    Dim xDirection As String = "Right"
    Dim yDirection As String = "Down"
    Dim oDirection As String = "Minus"
    Public type As String = "Malcolm Merlyn"

    Public Sub SetLocation(x As Integer, y As Integer)
        Me.Location = New Point(x, y)
    End Sub

    Private Sub MoveTimer_Tick(sender As Object, e As EventArgs) Handles MoveTimer.Tick
        If Me.Location.X <= 0 Then
            xDirection = "Right"
        End If
        If Me.Location.X >= (Screen.PrimaryScreen.Bounds.Width - Me.Size.Width) Then
            xDirection = "Left"
        End If
        If Me.Location.Y <= 0 Then
            yDirection = "Down"
        End If
        If Me.Location.Y >= (Screen.PrimaryScreen.Bounds.Height - Me.Size.Height) Then
            yDirection = "Up"
        End If

        Dim newX, newY As Integer
        If xDirection = "Right" Then
            newX = Me.Location.X + AntiScammerToolset.virus1Speed
        Else
            newX = Me.Location.X - AntiScammerToolset.virus1Speed
        End If
        If yDirection = "Down" Then
            newY = Me.Location.Y + AntiScammerToolset.virus1Speed
        Else
            newY = Me.Location.Y - AntiScammerToolset.virus1Speed
        End If

        Me.Location = New Point(newX, newY)

        If type = "Malcolm Merlyn" Then
            If Me.Opacity = 1 Then
                oDirection = "Minus"
            End If
            If Me.Opacity <= 0.1 Then
                oDirection = "Plus"
            End If

            If oDirection = "Minus" Then
                Me.Opacity -= 0.01
            Else
                Me.Opacity += 0.01
            End If
        End If

        If type.Contains("Scammer") Then
            Dim xComplete As Boolean = False
            Dim yComplete As Boolean = False
            If (Me.Location.X > AntiScammerToolset.gameForm.Location.X) And (Me.Location.X < (AntiScammerToolset.gameForm.Location.X + 125)) Then
                xComplete = True
            End If
            If (Me.Location.X + 125 > AntiScammerToolset.gameForm.Location.X) And (Me.Location.X < (AntiScammerToolset.gameForm.Location.X + 125)) Then
                xComplete = True
            End If
            If (Me.Location.Y > AntiScammerToolset.gameForm.Location.Y) And (Me.Location.Y < (AntiScammerToolset.gameForm.Location.Y + 125)) Then
                yComplete = True
            End If
            If (Me.Location.Y + 125 > AntiScammerToolset.gameForm.Location.Y) And (Me.Location.Y < (AntiScammerToolset.gameForm.Location.Y + 125)) Then
                yComplete = True
            End If
            If xComplete And yComplete Then
                MoveTimer.Stop()
                AntiScammerToolset.scammerKills += 1
                If AntiScammerToolset.scammerKills = 10 Then
                    AntiScammerToolset.gameForm.BackgroundImage = My.Resources.Merlyn_1
                End If
                If AntiScammerToolset.scammerKills >= 503 Then

                End If
                ScammerKillCount.Label1.Text = "Scammers Killed: " & AntiScammerToolset.scammerKills & "/503"
                Me.Close()
            End If
        End If
    End Sub

    Private Sub flashingTimer_Tick(sender As Object, e As EventArgs) Handles flashingTimer.Tick
        If Me.Opacity = 1 Then
            oDirection = "Minus"
        End If
        If Me.Opacity <= 0.8 Then
            oDirection = "Plus"
        End If

        If oDirection = "Minus" Then
            Me.Opacity -= 0.01
        Else
            Me.Opacity += 0.01
        End If
    End Sub
End Class