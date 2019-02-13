Imports System.IO
Imports System.Runtime.InteropServices
Public Class AntiScammerToolset

    Public runBoxShown As Boolean = False
    Public virus1Count As Integer = 0
    Public virus1Speed As Integer = 1
    Public gameActivated As Boolean = False
    Public hillaryVirusStarted As Boolean = False
    Public hillaryVirusCount As Integer = 0
    Public trumpAntivirusStarted As Boolean = False
    Public trumpProgressBarValue As Integer = 0
    Public gameForm As New VirusForm
    Dim Game0LocationX As Integer
    Dim Game0LocationY As Integer
    Dim scammerLevel1 As Integer = 0
    Dim scammerLevel5 As Integer = 0
    Dim scammerLevel10 As Integer = 0
    Public scammerKills As Integer = 0
    Public TrumpAntiVirusStep As Integer = 0
    Public currentDirectory As String = Directory.GetCurrentDirectory
    Public cthunVirusCount As Integer = 0

    Public hillaryVirusFormList As New List(Of HillaryClintonVirusForm)

    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    <DllImport("user32.dll")>
    Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyTimer.Tick
        Try
            Game0LocationX = gameForm.Location.X
            Game0LocationY = gameForm.Location.Y
        Catch
        End Try

        If (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.R) Then
            If Not fakeRunBox.Checked Then
                Return
            End If

            If runBoxShown = False Then
                Run.SetLocation(screenHeight)
                runBoxShown = True
                Run.Show()
            End If
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.X) Then
            Process.Start("http://www.ebay.ca/itm/x2-Intel-Xeon-E5-2699V3-x1-E5-2695V3-/322253414437?hash=item4b07cce025:g:hpkAAOSwxg5XzTWK")
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.V) Then
            If Not virus0.Checked Then
                Return
            End If

            virus0Timer.Start()
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.B) Then
            If Not virus1.Checked Then
                Return
            End If

            virus1Timer.Start()
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.G) Then
            If Not scammerGame.Checked Then
                Return
            End If
            If gameActivated Then
                Return
            End If

            Game0LocationX = Screen.PrimaryScreen.Bounds.Width / 2 - 63
            Game0LocationY = Screen.PrimaryScreen.Bounds.Height / 2 - 63
            gameForm.BackgroundImage = My.Resources.Merlyn_0
            gameForm.SetLocation(Game0LocationX, Game0LocationY)
            gameForm.Show()
            gameForm.flashingTimer.Start()
            scammerGameTimer.Start()
            ScammerKillCount.SetLocation(0, 0)
            ScammerKillCount.Show()
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.H) Then
            If Not hillaryClintonVirus.Checked Then
                Return
            End If
            If hillaryVirusStarted Then
                Return
            End If

            hillaryVirusStarted = True
            hillaryVirusTimer.Start()
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.T) Then
            If Not trumpAntivirus.Checked Then
                Return
            End If
            If trumpAntiVirusStarted Then
                Return
            End If

            TrumpAntivirusForm.Show()
            TrumpAntivirusForm.TrumpTimer.Start()
            TrumpAntivirusForm.ProgressBarTimer.Start
            TrumpAntivirusForm.TopMost = True
            trumpAntivirusStarted = True
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.N) Then
            If Not fakeDriverScanner.Checked Then
                Return
            End If

            DriverScanner.Show()
            DriverScanner.driverTimer.Start()
            DriverScanner.TopMost = True
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.J) Then
            If Not anonymousVideo.Checked Then
                Return
            End If

            Try
                VideoForm.VideoPlayer.URL = "anonymous.mp4"
                VideoForm.VideoPlayer.settings.setMode("loop", True)
                VideoForm.VideoPlayer.Ctlcontrols.play()
                VideoForm.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                VideoForm.TopMost = True
                VideoForm.Location = New Point(0, 0)
                VideoForm.Show()
            Catch
            End Try
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.Y) Then
            If Not fakeWindows93Update.Checked Then
                Return
            End If

            Windows93Upgrade.UpdateTimer.Start()
            Windows93Upgrade.TopMost = True
            Windows93Upgrade.Show()
        ElseIf (GetAsyncKeyState(Keys.LWin) <> 0 Or GetAsyncKeyState(Keys.RWin) <> 0) And GetAsyncKeyState(Keys.C) Then
            If Not CThunVirus.Checked Then
                Return
            End If

            CThunVirusTimer.Start()
        ElseIf GetAsyncKeyState(Keys.Escape) And GetAsyncKeyState(Keys.R) Then
            If Not reactOSupgrade.Checked Then
                Return
            End If

            React_OS_Upgrade.TopMost = True
            React_OS_Upgrade.Show()
        ElseIf GetAsyncKeyState(Keys.Enter) Then
            If runBoxShown = True Then
                Run.RunFunction()
            End If
        ElseIf GetAsyncKeyState(Keys.A) Then
            If virus1.Checked Then
                virus1Speed = 0
            End If
        ElseIf GetAsyncKeyState(Keys.Q) Then
            If virus1.Checked Then
                virus1Speed = 1
            End If
        ElseIf GetAsyncKeyState(Keys.W) Then
            If virus1.Checked Then
                virus1Speed = 2
            End If
        ElseIf GetAsyncKeyState(Keys.E) Then
            If virus1.Checked Then
                virus1Speed = 3
            End If
        ElseIf GetAsyncKeyState(Keys.R) Then
            If virus1.Checked Then
                virus1Speed = 4
            End If
        End If
        If GetAsyncKeyState(Keys.Up) Then
            If gameForm.Location.Y >= 4 Then
                Game0LocationY = gameForm.Location.Y - 4
            End If
        End If
        If GetAsyncKeyState(Keys.Down) Then
            If gameForm.Location.Y <= (Screen.PrimaryScreen.Bounds.Height - gameForm.Size.Height - 4) Then
                Game0LocationY = gameForm.Location.Y + 4
            End If
        End If
        If GetAsyncKeyState(Keys.Left) Then
            If gameForm.Location.X >= 4 Then
                Game0LocationX = gameForm.Location.X - 4
            End If
        End If
        If GetAsyncKeyState(Keys.Right) Then
            If gameForm.Location.X <= (Screen.PrimaryScreen.Bounds.Width - gameForm.Size.Width - 4) Then
                Game0LocationX = gameForm.Location.X + 4
            End If
        End If

        Try
            gameForm.Location = New Point(Game0LocationX, Game0LocationY)
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startButton.Click
        keyTimer.Start()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles merlynGlobalLbl.Click
        Process.Start("https://www.youtube.com/channel/UC_b1bYSup-dHfwIoIXP0zPQ")
    End Sub

    Private Sub Panel12_MouseClick(sender As Object, e As MouseEventArgs) Handles subscribePanel.MouseClick
        Process.Start("https://www.youtube.com/channel/UC_b1bYSup-dHfwIoIXP0zPQ")
    End Sub

    Private Sub Panel12_MouseMove(sender As Object, e As MouseEventArgs) Handles subscribePanel.MouseMove
        subscribePanel.BackgroundImage = My.Resources.Subscribe_2
    End Sub

    Private Sub Panel12_MouseLeave(sender As Object, e As EventArgs) Handles subscribePanel.MouseLeave
        subscribePanel.BackgroundImage = My.Resources.Subscribe
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("If you are using this program to make YouTube videos, please post a download link and a link to my channel in the video description and let everyone know where they can get the program!" & Environment.NewLine & Environment.NewLine & "Anti-Scammer Toolset has been designed by Malcolm Merlyn, read the INSTRUCTIONS file before use!" & Environment.NewLine & Environment.NewLine & "If you have any questions or suggestions please visit: https://www.youtube.com/c/malcolmmerlynglobal", "Anti-Scammer Toolset")
    End Sub

    Private Sub virus0Timer_Tick(sender As Object, e As EventArgs) Handles virus0Timer.Tick
        Dim r As Random = New Random
        Dim x As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
        Dim y As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
        Dim virusForm As New VirusForm
        virusForm.SetLocation(x, y)
        virusForm.Show()
    End Sub

    Private Sub virus1Timer_Tick(sender As Object, e As EventArgs) Handles virus1Timer.Tick
        If virus1Count = 10 Then
            virus1Timer.Stop()
            Return
        End If

        Dim r As Random = New Random
        Dim x As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
        Dim y As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
        Dim virusForm As New VirusForm
        virusForm.SetLocation(x, y)
        virusForm.Show()
        virusForm.MoveTimer.Start()
        virus1Count += 1
    End Sub

    Private Sub game0Timer_Tick(sender As Object, e As EventArgs) Handles scammerGameTimer.Tick
        scammerLevel1 += 1
        scammerLevel5 += 1
        scammerLevel10 += 1
        Dim r As Random = New Random
        Dim x As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
        Dim y As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
        Dim virusForm As New VirusForm
        virusForm.SetLocation(x, y)
        virus1Speed = 1
        virusForm.BackgroundImage = My.Resources.Level0_Scammer
        virusForm.type = "Scammer"
        virusForm.flashingTimer.Start()
        virusForm.MoveTimer.Start()
        virusForm.Show()

        If scammerLevel1 = 4 Then
            Dim x1 As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
            Dim y1 As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
            virusForm = New VirusForm
            virusForm.SetLocation(x1, y1)
            virus1Speed = 1
            virusForm.BackgroundImage = My.Resources.Level1_Scammer
            virusForm.type = "Scammer"
            virusForm.flashingTimer.Start()
            virusForm.MoveTimer.Start()
            virusForm.Show()
            scammerLevel1 = 0
        End If
        If scammerLevel5 = 10 Then
            Dim x2 As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
            Dim y2 As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
            virusForm = New VirusForm
            virusForm.SetLocation(x2, y2)
            virus1Speed = 1
            virusForm.BackgroundImage = My.Resources.Level5_Scammer
            virusForm.type = "Scammer"
            virusForm.flashingTimer.Start()
            virusForm.MoveTimer.Start()
            virusForm.Show()
            scammerLevel5 = 0
        End If
        If scammerLevel10 = 20 Then
            Dim x3 As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
            Dim y3 As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
            virusForm = New VirusForm
            virusForm.SetLocation(x3, y3)
            virus1Speed = 1
            virusForm.BackgroundImage = My.Resources.Level10_Scammer
            virusForm.type = "Scammer"
            virusForm.flashingTimer.Start()
            virusForm.MoveTimer.Start()
            virusForm.Show()
            scammerLevel10 = 0
        End If
    End Sub

    Private Sub AntiScammerToolset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("If you are using this program to make YouTube videos, please post a download link and a link to my channel in the video description and let everyone know where they can get the program!" & Environment.NewLine & Environment.NewLine & "Anti-Scammer Toolset has been designed by Malcolm Merlyn, read the INSTRUCTIONS file before use!" & Environment.NewLine & Environment.NewLine & "If you have any questions or suggestions please visit: https://www.youtube.com/c/malcolmmerlynglobal", "Anti-Scammer Toolset")
    End Sub

    Private Sub hillaryVirusTimer_Tick(sender As Object, e As EventArgs) Handles hillaryVirusTimer.Tick
        Dim newHillaryVirus As New HillaryClintonVirusForm
        newHillaryVirus.Show()
        newHillaryVirus.counterTimer.Start()
        hillaryVirusFormList.Add(newHillaryVirus)
        hillaryVirusTimer.Stop()
    End Sub

    Private Sub CThunVirusTimer_Tick(sender As Object, e As EventArgs) Handles CThunVirusTimer.Tick
        If cthunVirusCount = 10 Then
            CThunVirusTimer.Stop()
            Return
        End If

        Dim r As Random = New Random
        Dim x As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Width - 125)
        Dim y As Integer = r.Next(0, Screen.PrimaryScreen.Bounds.Height - 125)
        Dim virusForm As New VirusForm
        virusForm.BackgroundImage = Nothing
        virusForm.Image.Image = My.Resources.CThun
        virusForm.Image.Visible = True
        virusForm.SetLocation(x, y)
        virusForm.Show()
        virusForm.MoveTimer.Start()
        cthunVirusCount += 1
    End Sub
End Class
