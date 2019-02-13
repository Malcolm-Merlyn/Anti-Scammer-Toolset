Imports System.IO

Public Class Scanner

    Dim scannedFiles As Integer = 0
    Dim fileNumber As Integer = 0
    Dim files As List(Of String) = FileHelper.GetFilesRecursive("C:\")

    Public Sub ScannerLoad()
        scannerTimer.Start()
        loadFilesTimer.Start()
    End Sub

    Private Sub scanBtn_Click(sender As Object, e As EventArgs) Handles scanBtn.Click
        If scanBtn.Text = "Scan" Then
            scannedFiles = 0
            fileNumber = 0
            scannerProgressBar.Value = 0
            scanningLbl.Text = "Scanning: 0%"
            scannedFilesLbl.Text = "Scanned Files: 0"
            scannedFilesLBox.Items.Clear()
            scannerTimer.Start()
            loadFilesTimer.Start()
            scanBtn.Text = "Stop"
        Else
            scannerTimer.Stop()
            loadFilesTimer.Stop()
            scanBtn.Text = "Scan"
        End If
    End Sub

    Private Sub scannerTimer_Tick(sender As Object, e As EventArgs) Handles scannerTimer.Tick
        If scannerProgressBar.Value <> 100 Then
            scannerProgressBar.Value = scannerProgressBar.Value + 1
            scanningLbl.Text = "Scanning: " & scannerProgressBar.Value & "%"
            Randomize()
            scannedFiles += Rnd() * 1000
            scannedFilesLbl.Text = "Scanned Files: " & scannedFiles
        Else
            scannerTimer.Stop()
            loadFilesTimer.Stop()
            scanBtn.Text = "Scan"
            MessageBox.Show("          Scan Results:" & Environment.NewLine & Environment.NewLine & "          Viruses Found: 0" & Environment.NewLine & "          Malware Found: 0" & Environment.NewLine &
                   "          Adware Found: 0" & Environment.NewLine & "          Trojans Found: 0" & Environment.NewLine & "          Scammers Found: 1" &
                   Environment.NewLine & Environment.NewLine & "          System Status: Healthy", "Scan Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("          Warning: 1 Scammer was detected!" & Environment.NewLine & "          Location: India" & Environment.NewLine & "          Bomb Scammer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub loadFilesTimer_Tick(sender As Object, e As EventArgs) Handles loadFilesTimer.Tick
        Try
            scannedFilesLBox.Items.Insert(0, files(fileNumber))
            fileNumber += 1
        Catch
            fileNumber = 0
        End Try
    End Sub

    Public Class FileHelper
        Public Shared Function GetFilesRecursive(ByVal initial As String) As List(Of String)
            Dim result As New List(Of String)
            Dim stack As New Stack(Of String)
            stack.Push(initial)

            Dim fileLimit As String = 0

            Do While (stack.Count > 0 And fileLimit < 400)
                Dim dir As String = stack.Pop
                Try
                    result.AddRange(Directory.GetFiles(dir, "*.*"))
                    Dim directoryName As String
                    For Each directoryName In Directory.GetDirectories(dir)
                        stack.Push(directoryName)
                    Next
                    fileLimit += 1
                Catch
                End Try
            Loop

            Return result
        End Function
    End Class
End Class