Public Class DriverScanner

    Dim timerStep As Integer = 0

    Private Sub driverTimer_Tick(sender As Object, e As EventArgs) Handles driverTimer.Tick
        Try
            If timerStep < 10 Then
                UpdateText(videoCardDriverLabel)
            ElseIf timerStep = 10 Then
                driverProgressBar.Value = 10
                driversFoundLabel.Text = "Drivers Found: 1/12"
                videoCardDriverLabel.Text = "Driver Found!"
            ElseIf timerStep < 20 Then
                HidePanel0.Hide()
                UpdateText(ethernetDriverLabel)
            ElseIf timerStep = 20 Then
                driverProgressBar.Value = 20
                driversFoundLabel.Text = "Drivers Found: 2/12"
                ethernetDriverLabel.Text = "Driver Found!"
            ElseIf timerStep < 30 Then
                HidePanel1.Hide()
                UpdateText(wirelessCardDriverLabel)
            ElseIf timerStep = 30 Then
                driverProgressBar.Value = 30
                wirelessCardDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 40 Then
                HidePanel2.Hide()
                UpdateText(usb30DriverLabel)
            ElseIf timerStep = 40 Then
                driverProgressBar.Value = 40
                driversFoundLabel.Text = "Drivers Found: 3/12"
                usb30DriverLabel.Text = "Driver Found!"
            ElseIf timerStep < 50 Then
                HidePanel3.Hide()
                UpdateText(soundCardDriverLabel)
            ElseIf timerStep = 50 Then
                driverProgressBar.Value = 50
                driversFoundLabel.Text = "Drivers Found: 4/12"
                soundCardDriverLabel.Text = "Driver Found!"
            ElseIf timerStep < 60 Then
                HidePanel4.Hide()
                UpdateText(raidControllerDriverLabel)
            ElseIf timerStep = 60 Then
                driverProgressBar.Value = 60
                raidControllerDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 70 Then
                HidePanel5.Hide()
                UpdateText(uraniumCentrifugeDriverLabel)
            ElseIf timerStep = 70 Then
                driverProgressBar.Value = 70
                uraniumCentrifugeDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 80 Then
                HidePanel6.Hide()
                UpdateText(earthquakeDeviceDriverLabel)
            ElseIf timerStep = 80 Then
                driverProgressBar.Value = 80
                earthquakeDeviceDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 90 Then
                HidePanel7.Hide()
                UpdateText(rubiconDeviceDriverLabel)
            ElseIf timerStep = 90 Then
                driverProgressBar.Value = 90
                rubiconDeviceDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 100 Then
                HidePanel8.Hide()
                UpdateText(artificialIntelligenceDriverLabel)
            ElseIf timerStep = 100 Then
                driverProgressBar.Value = 100
                artificialIntelligenceDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 110 Then
                HidePanel9.Hide()
                UpdateText(fusionCoreDriverLabel)
            ElseIf timerStep = 110 Then
                driverProgressBar.Value = 110
                fusionCoreDriverLabel.Text = "Not Found!"
            ElseIf timerStep < 120 Then
                HidePanel10.Hide()
                UpdateText(missileSiloDriverLabel)
            ElseIf timerStep = 120 Then
                driverProgressBar.Value = 120
                missileSiloDriverLabel.Text = "Not Found!"
                MsgBox("Drivers Found: 4/12", "Results")
            End If
        Catch
        End Try

        If timerStep > 70 Then
            Dim r As Random = New Random
            Dim x As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
            Dim y As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)

            If x + 25 > Screen.PrimaryScreen.Bounds.Width Then
                x = x - 25
            End If
            If y + 25 > Screen.PrimaryScreen.Bounds.Height Then
                y = y - 25
            End If

            Dim newNuclearWarning As New NuclearWarning
            newNuclearWarning.SetLocation(x, y)
            newNuclearWarning.ColorTimer.Start()
            newNuclearWarning.Show()
        End If

        timerStep += 1
    End Sub

    Public Sub UpdateText(selectedLabel As Label)
        Try
            If selectedLabel.Text = "Scanning" Then
                selectedLabel.Text = "Scanning."
            ElseIf selectedLabel.Text = "Scanning." Then
                selectedLabel.Text = "Scanning.."
            ElseIf selectedLabel.Text = "Scanning.." Then
                selectedLabel.Text = "Scanning..."
            Else
                selectedLabel.Text = "Scanning"
            End If
        Catch
        End Try
    End Sub

    Private Sub DriverScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub
End Class