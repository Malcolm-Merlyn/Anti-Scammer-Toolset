Public Class TrumpAntivirusForm

    Dim dots As String = ""
    Dim newTrumpMessage As String = "Donald Trump is going to make your computer great again"

    Public Sub LoadForm()
        If AntiScammerToolset.trumpProgressBarValue <= 276 Then
            trumpProgressBar.Value = AntiScammerToolset.trumpProgressBarValue
        End If

        If AntiScammerToolset.TrumpAntiVirusStep >= 2 Then
            For Each hillaryVirusForm As HillaryClintonVirusForm In AntiScammerToolset.hillaryVirusFormList
                hillaryVirusForm.Hide()
            Next
        End If

        If AntiScammerToolset.TrumpAntiVirusStep = 0 Then
            Label_0.Text = "Completed"
            Label_1.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_Scan
            newTrumpMessage = "Donald Trump is scanning your computer for viruses"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 1 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_VirusesFound
            newTrumpMessage = "Hillary Clinton virus has been detected"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 2 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_RemoveViruses
            newTrumpMessage = "Donald Trump is removing viruses from your computer"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 3 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_Firewall
            newTrumpMessage = "Donald Trump is building a Firewall"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 4 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SpywareCheck
            newTrumpMessage = "Donald Trump is checking your computer for Spyware"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 5 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SpywareCheck
            newTrumpMessage = "Donald Trump found 0 Spyware, Windows 10 not installed"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 6 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_TrojanCheck
            newTrumpMessage = "Donald Trump is checking your computer for Trojans"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 7 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_TrojanCheck
            newTrumpMessage = "Donald Trump found 0 Trojans"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 8 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_TrojanCheck
            newTrumpMessage = "Donald Trump gives you a small loan of 1 million Trojan Magnums"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 9 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SoftwareCheck
            newTrumpMessage = "Donald Trump discovered that the system is corrupt, only he can fix it"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 10 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SoftwareCheck
            newTrumpMessage = "Donald Trump is scanning your computer for unnecessary software"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 11 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SoftwareCheck
            newTrumpMessage = "Obamacare 1.0 has been detected and removed!"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 12 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "Completed"
            Label_8.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_HardwareCheck
            newTrumpMessage = "Donald Trump is checking your computer hardware specs"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 13 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "Completed"
            Label_8.Text = "Completed"
            Label_9.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_UpgradeComputer
            newTrumpMessage = "Donald Trump gives you an Intel I7-6950X and 256GB of RAM"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 14 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "Completed"
            Label_8.Text = "Completed"
            Label_9.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_UpgradeComputer
            newTrumpMessage = "Donald Trump gives you 2 NVIDIA TITAN X Pascal graphic cards"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep >= 15 Then
            Label_0.Text = "Completed"
            Label_1.Text = "Completed"
            Label_2.Text = "Completed"
            Label_3.Text = "Completed"
            Label_4.Text = "Completed"
            Label_5.Text = "Completed"
            Label_6.Text = "Completed"
            Label_7.Text = "Completed"
            Label_8.Text = "Completed"
            Label_9.Text = "Completed"
            trumpPictureBox.Image = My.Resources.Trump_UpgradeComputer
            trumpMessage.Text = "Donald Trump has made your computer great again!"
        End If
    End Sub

    Private Sub TrumpTimer_Tick(sender As Object, e As EventArgs) Handles TrumpTimer.Tick
        If AntiScammerToolset.TrumpAntiVirusStep = 0 Then
            Label_0.Text = "Completed"
            Label_1.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_Scan
            newTrumpMessage = "Donald Trump is scanning your computer for viruses"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 1 Then
            Label_1.Text = "Completed"
            Label_2.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_VirusesFound
            newTrumpMessage = "Hillary Clinton virus has been detected"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 2 Then
            Label_2.Text = "Completed"
            Label_3.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_RemoveViruses
            newTrumpMessage = "Donald Trump is removing viruses from your computer"
            For Each hillaryVirusForm As HillaryClintonVirusForm In AntiScammerToolset.hillaryVirusFormList
                hillaryVirusForm.Hide()
            Next
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 3 Then
            Label_3.Text = "Completed"
            Label_4.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_Firewall
            newTrumpMessage = "Donald Trump is building a Firewall"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 4 Then
            Label_4.Text = "Completed"
            Label_5.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SpywareCheck
            newTrumpMessage = "Donald Trump is checking your computer for Spyware"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 5 Then
            newTrumpMessage = "Donald Trump found 0 Spyware, Windows 10 not installed"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 6 Then
            Label_5.Text = "Completed"
            Label_6.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_TrojanCheck
            newTrumpMessage = "Donald Trump is checking your computer for Trojans"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 7 Then
            newTrumpMessage = "Donald Trump found 0 Trojans"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 8 Then
            newTrumpMessage = "Donald Trump gives you a small loan of 1 million Trojan Magnums"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 9 Then
            Label_6.Text = "Completed"
            Label_7.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_SoftwareCheck
            newTrumpMessage = "Donald Trump discovered that the system is corrupt, only he can fix it"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 10 Then
            newTrumpMessage = "Donald Trump is scanning your computer for unnecessary software"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 11 Then
            newTrumpMessage = "Obamacare 1.0 has been detected and removed!"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 12 Then
            Label_7.Text = "Completed"
            Label_8.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_HardwareCheck
            newTrumpMessage = "Donald Trump is checking your computer hardware specs"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 13 Then
            Label_8.Text = "Completed"
            Label_9.Text = "In Progress"
            trumpPictureBox.Image = My.Resources.Trump_UpgradeComputer
            newTrumpMessage = "Donald Trump gives you an Intel I7-6950X and 256GB of RAM"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 14 Then
            newTrumpMessage = "Donald Trump gives you 2 NVIDIA TITAN X Pascal graphic cards"
        ElseIf AntiScammerToolset.TrumpAntiVirusStep = 15 Then
            ProgressBarTimer.Stop()
            TrumpTimer.Stop()
            Label_9.Text = "Completed"
            trumpMessage.Text = "Donald Trump has made your computer great again!"
            trumpProgressBar.Value = 276
            Me.TopMost = False

            If AntiScammerToolset.trumpScanResults.Checked Then
                resultsTimer.Start()
            End If
        End If

        AntiScammerToolset.TrumpAntiVirusStep += 1
    End Sub

    Private Sub ProgressBarTimer_Tick(sender As Object, e As EventArgs) Handles ProgressBarTimer.Tick
        If dots = "" Then
            dots = "."
        ElseIf dots = "." Then
            dots = ".."
        ElseIf dots = ".." Then
            dots = "..."
        Else
            dots = ""
        End If

        trumpMessage.Text = newTrumpMessage & dots


        If Label_0.Text = "In Progress" Then
            Label_0.Text = "In Progress."
        ElseIf Label_0.Text = "In Progress." Then
            Label_0.Text = "In Progress.."
        ElseIf Label_0.Text = "In Progress.." Then
            Label_0.Text = "In Progress..."
        ElseIf Label_0.Text = "In Progress..." Then
            Label_0.Text = "In Progress"
        End If
        If Label_1.Text = "Waiting" Then
            Label_1.Text = "Waiting."
        ElseIf Label_1.Text = "Waiting." Then
            Label_1.Text = "Waiting.."
        ElseIf Label_1.Text = "Waiting.." Then
            Label_1.Text = "Waiting..."
        ElseIf Label_1.Text = "Waiting..." Then
            Label_1.Text = "Waiting"
        End If
        If Label_1.Text = "In Progress" Then
            Label_1.Text = "In Progress."
        ElseIf Label_1.Text = "In Progress." Then
            Label_1.Text = "In Progress.."
        ElseIf Label_1.Text = "In Progress.." Then
            Label_1.Text = "In Progress..."
        ElseIf Label_1.Text = "In Progress..." Then
            Label_1.Text = "In Progress"
        End If
        If Label_2.Text = "Waiting" Then
            Label_2.Text = "Waiting."
        ElseIf Label_2.Text = "Waiting." Then
            Label_2.Text = "Waiting.."
        ElseIf Label_2.Text = "Waiting.." Then
            Label_2.Text = "Waiting..."
        ElseIf Label_2.Text = "Waiting..." Then
            Label_2.Text = "Waiting"
        End If
        If Label_2.Text = "In Progress" Then
            Label_2.Text = "In Progress."
        ElseIf Label_2.Text = "In Progress." Then
            Label_2.Text = "In Progress.."
        ElseIf Label_2.Text = "In Progress.." Then
            Label_2.Text = "In Progress..."
        ElseIf Label_2.Text = "In Progress..." Then
            Label_2.Text = "In Progress"
        End If
        If Label_3.Text = "Waiting" Then
            Label_3.Text = "Waiting."
        ElseIf Label_3.Text = "Waiting." Then
            Label_3.Text = "Waiting.."
        ElseIf Label_3.Text = "Waiting.." Then
            Label_3.Text = "Waiting..."
        ElseIf Label_3.Text = "Waiting..." Then
            Label_3.Text = "Waiting"
        End If
        If Label_3.Text = "In Progress" Then
            Label_3.Text = "In Progress."
        ElseIf Label_3.Text = "In Progress." Then
            Label_3.Text = "In Progress.."
        ElseIf Label_3.Text = "In Progress.." Then
            Label_3.Text = "In Progress..."
        ElseIf Label_3.Text = "In Progress..." Then
            Label_3.Text = "In Progress"
        End If
        If Label_4.Text = "Waiting" Then
            Label_4.Text = "Waiting."
        ElseIf Label_4.Text = "Waiting." Then
            Label_4.Text = "Waiting.."
        ElseIf Label_4.Text = "Waiting.." Then
            Label_4.Text = "Waiting..."
        ElseIf Label_4.Text = "Waiting..." Then
            Label_4.Text = "Waiting"
        End If
        If Label_4.Text = "In Progress" Then
            Label_4.Text = "In Progress."
        ElseIf Label_4.Text = "In Progress." Then
            Label_4.Text = "In Progress.."
        ElseIf Label_4.Text = "In Progress.." Then
            Label_4.Text = "In Progress..."
        ElseIf Label_4.Text = "In Progress..." Then
            Label_4.Text = "In Progress"
        End If
        If Label_5.Text = "Waiting" Then
            Label_5.Text = "Waiting."
        ElseIf Label_5.Text = "Waiting." Then
            Label_5.Text = "Waiting.."
        ElseIf Label_5.Text = "Waiting.." Then
            Label_5.Text = "Waiting..."
        ElseIf Label_5.Text = "Waiting..." Then
            Label_5.Text = "Waiting"
        End If
        If Label_5.Text = "In Progress" Then
            Label_5.Text = "In Progress."
        ElseIf Label_5.Text = "In Progress." Then
            Label_5.Text = "In Progress.."
        ElseIf Label_5.Text = "In Progress.." Then
            Label_5.Text = "In Progress..."
        ElseIf Label_5.Text = "In Progress..." Then
            Label_5.Text = "In Progress"
        End If
        If Label_6.Text = "Waiting" Then
            Label_6.Text = "Waiting."
        ElseIf Label_6.Text = "Waiting." Then
            Label_6.Text = "Waiting.."
        ElseIf Label_6.Text = "Waiting.." Then
            Label_6.Text = "Waiting..."
        ElseIf Label_6.Text = "Waiting..." Then
            Label_6.Text = "Waiting"
        End If
        If Label_6.Text = "In Progress" Then
            Label_6.Text = "In Progress."
        ElseIf Label_6.Text = "In Progress." Then
            Label_6.Text = "In Progress.."
        ElseIf Label_6.Text = "In Progress.." Then
            Label_6.Text = "In Progress..."
        ElseIf Label_6.Text = "In Progress..." Then
            Label_6.Text = "In Progress"
        End If
        If Label_7.Text = "Waiting" Then
            Label_7.Text = "Waiting."
        ElseIf Label_7.Text = "Waiting." Then
            Label_7.Text = "Waiting.."
        ElseIf Label_7.Text = "Waiting.." Then
            Label_7.Text = "Waiting..."
        ElseIf Label_7.Text = "Waiting..." Then
            Label_7.Text = "Waiting"
        End If
        If Label_7.Text = "In Progress" Then
            Label_7.Text = "In Progress."
        ElseIf Label_7.Text = "In Progress." Then
            Label_7.Text = "In Progress.."
        ElseIf Label_7.Text = "In Progress.." Then
            Label_7.Text = "In Progress..."
        ElseIf Label_7.Text = "In Progress..." Then
            Label_7.Text = "In Progress"
        End If
        If Label_8.Text = "Waiting" Then
            Label_8.Text = "Waiting."
        ElseIf Label_8.Text = "Waiting." Then
            Label_8.Text = "Waiting.."
        ElseIf Label_8.Text = "Waiting.." Then
            Label_8.Text = "Waiting..."
        ElseIf Label_8.Text = "Waiting..." Then
            Label_8.Text = "Waiting"
        End If
        If Label_8.Text = "In Progress" Then
            Label_8.Text = "In Progress."
        ElseIf Label_8.Text = "In Progress." Then
            Label_8.Text = "In Progress.."
        ElseIf Label_8.Text = "In Progress.." Then
            Label_8.Text = "In Progress..."
        ElseIf Label_8.Text = "In Progress..." Then
            Label_8.Text = "In Progress"
        End If
        If Label_9.Text = "Waiting" Then
            Label_9.Text = "Waiting."
        ElseIf Label_9.Text = "Waiting." Then
            Label_9.Text = "Waiting.."
        ElseIf Label_9.Text = "Waiting.." Then
            Label_9.Text = "Waiting..."
        ElseIf Label_9.Text = "Waiting..." Then
            Label_9.Text = "Waiting"
        End If
        If Label_9.Text = "In Progress" Then
            Label_9.Text = "In Progress."
        ElseIf Label_9.Text = "In Progress." Then
            Label_9.Text = "In Progress.."
        ElseIf Label_9.Text = "In Progress.." Then
            Label_9.Text = "In Progress..."
        ElseIf Label_9.Text = "In Progress..." Then
            Label_9.Text = "In Progress"
        End If

        If trumpProgressBar.Value < 276 Then
            trumpProgressBar.Value += 1
            AntiScammerToolset.trumpProgressBarValue += 1
        End If
    End Sub

    Private Sub TrumpAntivirusForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If AntiScammerToolset.TrumpAntiVirusStep < 15 Then
            Me.ProgressBarTimer.Stop()
            Me.TrumpTimer.Stop()
            Dim newTrumpAntiVirusForm As New TrumpAntivirusForm
            newTrumpAntiVirusForm.LoadForm()
            newTrumpAntiVirusForm.TrumpTimer.Start()
            newTrumpAntiVirusForm.ProgressBarTimer.Start()
            newTrumpAntiVirusForm.TopMost = True
            newTrumpAntiVirusForm.Show()
        End If
    End Sub

    Private Sub resultsTimer_Tick(sender As Object, e As EventArgs) Handles resultsTimer.Tick
        resultsTimer.Stop()
        MessageBox.Show("Scan Results: " & Environment.NewLine & Environment.NewLine & "Donald Trump discovered and removed the Hillary Clinton virus!" & Environment.NewLine & "Donald Trump built a firewall" & Environment.NewLine & "Donald Trump discovered the system was corrupt and fixed it!" & Environment.NewLine & "Donald Trump upgraded your computer!", "Donald J. Trump Antivirus Scan Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Warning: " & Environment.NewLine & Environment.NewLine & "Indian Tech Support Scammer was detected on your computer, the scammer is using a remote desktop connection and can see your computer right now!", "Donald J. Trump Antivirus Scan Results", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class