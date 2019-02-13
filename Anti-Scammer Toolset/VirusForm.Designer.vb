<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VirusForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VirusForm))
        Me.MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.flashingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Image = New System.Windows.Forms.PictureBox()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoveTimer
        '
        Me.MoveTimer.Interval = 1
        '
        'flashingTimer
        '
        Me.flashingTimer.Interval = 1
        '
        'Image
        '
        Me.Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Image.Location = New System.Drawing.Point(0, 0)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(125, 125)
        Me.Image.TabIndex = 0
        Me.Image.TabStop = False
        Me.Image.Visible = False
        '
        'VirusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anti_Scammer_Toolset.My.Resources.Resources.Malcolm_Merlyn
        Me.ClientSize = New System.Drawing.Size(125, 125)
        Me.Controls.Add(Me.Image)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(125, 125)
        Me.MinimumSize = New System.Drawing.Size(125, 125)
        Me.Name = "VirusForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MoveTimer As Timer
    Friend WithEvents flashingTimer As Timer
    Friend WithEvents Image As PictureBox
End Class
