<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Windows93Upgrade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Windows93Upgrade))
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.postponeBtn = New System.Windows.Forms.Button()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.BackColor = System.Drawing.Color.Transparent
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(348, 9)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(631, 39)
        Me.timeLabel.TabIndex = 0
        Me.timeLabel.Text = "FREE UPGRADE STARTING IN: 0:30"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 652)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(695, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FREE UPGRADE IS READY TO INSTALL"
        '
        'postponeBtn
        '
        Me.postponeBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.postponeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.postponeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postponeBtn.Location = New System.Drawing.Point(819, 56)
        Me.postponeBtn.Name = "postponeBtn"
        Me.postponeBtn.Size = New System.Drawing.Size(148, 34)
        Me.postponeBtn.TabIndex = 2
        Me.postponeBtn.Text = "POSTPONE"
        Me.postponeBtn.UseVisualStyleBackColor = False
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 1000
        '
        'Windows93Upgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.Anti_Scammer_Toolset.My.Resources.Resources.Windows93Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 712)
        Me.Controls.Add(Me.postponeBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.timeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Windows93Upgrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows 93 Free Upgrade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents postponeBtn As Button
    Friend WithEvents UpdateTimer As Timer
End Class
