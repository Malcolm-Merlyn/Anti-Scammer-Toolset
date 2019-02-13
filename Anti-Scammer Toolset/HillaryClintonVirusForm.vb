Public Class HillaryClintonVirusForm
    Private Sub counterTimer_Tick(sender As Object, e As EventArgs) Handles counterTimer.Tick
        AntiScammerToolset.hillaryVirusCount += 1
        If AntiScammerToolset.hillaryVirusCount <= 33000 Then
            emailsDeleted.Text = "HILLARY CLINTON IS DELETING YOUR EMAILS: " & AntiScammerToolset.hillaryVirusCount & "/33000"
        Else
            emailsDeleted.Text = "HILLARY CLINTON IS DELETING YOUR EMAILS: 33000/33000"
        End If
    End Sub

    Private Sub HillaryClintonVirusForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim newHillaryVirus1 As New HillaryClintonVirusForm
        newHillaryVirus1.Show()
        newHillaryVirus1.counterTimer.Start()
        AntiScammerToolset.hillaryVirusFormList.Add(newHillaryVirus1)
        Dim newHillaryVirus2 As New HillaryClintonVirusForm
        newHillaryVirus2.Show()
        newHillaryVirus2.counterTimer.Start()
        AntiScammerToolset.hillaryVirusFormList.Add(newHillaryVirus2)
    End Sub
End Class