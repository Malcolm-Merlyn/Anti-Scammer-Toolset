Public Class Run

    Public Sub SetLocation(y As Integer)
        Me.Location = New Point(8, y - 270)
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        RunFunction()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        AntiScammerToolset.runBoxShown = False
        Me.Hide()
    End Sub

    Private Sub browseButton_Click(sender As Object, e As EventArgs) Handles browseButton.Click
        browseOpenFileDialog.ShowDialog()
    End Sub

    Private Sub Run_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AntiScammerToolset.runBoxShown = False
        Me.Hide()
    End Sub

    Public Sub RunFunction()
        If fileName.Text.ToLower = "cmd" Then
            Process.Start("cmd.exe")
            AntiScammerToolset.runBoxShown = False
            Me.Hide()
        ElseIf fileName.Text.ToLower = "syskey" Then
            Scanner.Show()
            Scanner.ScannerLoad()
            AntiScammerToolset.runBoxShown = False
            Me.Hide()
        ElseIf fileName.Text.ToLower = "eventvwr" Then
            Scanner.Show()
            Scanner.ScannerLoad()
            AntiScammerToolset.runBoxShown = False
            Me.Hide()
        Else
            Scanner.Show()
            Scanner.ScannerLoad()
            AntiScammerToolset.runBoxShown = False
            Me.Hide()
        End If
    End Sub
End Class