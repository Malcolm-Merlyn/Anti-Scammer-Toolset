<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoForm))
        Me.VideoPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.VideoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VideoPlayer
        '
        Me.VideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPlayer.Enabled = True
        Me.VideoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayer.Name = "VideoPlayer"
        Me.VideoPlayer.OcxState = CType(resources.GetObject("VideoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VideoPlayer.Size = New System.Drawing.Size(630, 388)
        Me.VideoPlayer.TabIndex = 0
        '
        'VideoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 388)
        Me.Controls.Add(Me.VideoPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VideoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Anonymous Message"
        CType(Me.VideoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VideoPlayer As AxWMPLib.AxWindowsMediaPlayer
End Class
