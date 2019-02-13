Public Class React_OS_Upgrade
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("This upgrade cannot be postponed at this time, please try again later!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While True
            MsgBox("Downloading and Installing ReactOS!")
        End While
    End Sub

    Private Sub React_OS_Upgrade_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
End Class