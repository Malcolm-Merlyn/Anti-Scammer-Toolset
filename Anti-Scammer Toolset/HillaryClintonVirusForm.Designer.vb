<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HillaryClintonVirusForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HillaryClintonVirusForm))
        Me.emailsDeleted = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.counterTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'emailsDeleted
        '
        Me.emailsDeleted.AutoSize = True
        Me.emailsDeleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailsDeleted.ForeColor = System.Drawing.Color.Red
        Me.emailsDeleted.Location = New System.Drawing.Point(12, 280)
        Me.emailsDeleted.Name = "emailsDeleted"
        Me.emailsDeleted.Size = New System.Drawing.Size(805, 39)
        Me.emailsDeleted.TabIndex = 1
        Me.emailsDeleted.Text = "HILLARY CLINTON IS DELETING YOUR EMAILS: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anti_Scammer_Toolset.My.Resources.Resources.CtrlAltHillary
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 250)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'counterTimer
        '
        Me.counterTimer.Interval = 300
        '
        'HillaryClintonVirusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1051, 336)
        Me.Controls.Add(Me.emailsDeleted)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HillaryClintonVirusForm"
        Me.Text = "Hillary Clinton Virus"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents emailsDeleted As Label
    Friend WithEvents counterTimer As Timer
End Class
