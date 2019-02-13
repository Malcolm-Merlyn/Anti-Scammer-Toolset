<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scanner))
        Me.scanBtn = New System.Windows.Forms.Button()
        Me.scannerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scannerProgressBar = New System.Windows.Forms.ProgressBar()
        Me.scanningLbl = New System.Windows.Forms.Label()
        Me.scannedFilesLBox = New System.Windows.Forms.ListBox()
        Me.scannedFilesLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.loadFilesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'scanBtn
        '
        Me.scanBtn.BackColor = System.Drawing.Color.Silver
        Me.scanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scanBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanBtn.Location = New System.Drawing.Point(409, 255)
        Me.scanBtn.Name = "scanBtn"
        Me.scanBtn.Size = New System.Drawing.Size(83, 36)
        Me.scanBtn.TabIndex = 0
        Me.scanBtn.Text = "Stop"
        Me.scanBtn.UseVisualStyleBackColor = False
        '
        'scannerTimer
        '
        '
        'scannerProgressBar
        '
        Me.scannerProgressBar.Location = New System.Drawing.Point(12, 28)
        Me.scannerProgressBar.Name = "scannerProgressBar"
        Me.scannerProgressBar.Size = New System.Drawing.Size(480, 28)
        Me.scannerProgressBar.Step = 1
        Me.scannerProgressBar.TabIndex = 1
        '
        'scanningLbl
        '
        Me.scanningLbl.AutoSize = True
        Me.scanningLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanningLbl.ForeColor = System.Drawing.Color.White
        Me.scanningLbl.Location = New System.Drawing.Point(5, 7)
        Me.scanningLbl.Name = "scanningLbl"
        Me.scanningLbl.Size = New System.Drawing.Size(89, 16)
        Me.scanningLbl.TabIndex = 2
        Me.scanningLbl.Text = "Scanning: 0%"
        '
        'scannedFilesLBox
        '
        Me.scannedFilesLBox.FormattingEnabled = True
        Me.scannedFilesLBox.Location = New System.Drawing.Point(12, 90)
        Me.scannedFilesLBox.Name = "scannedFilesLBox"
        Me.scannedFilesLBox.Size = New System.Drawing.Size(480, 121)
        Me.scannedFilesLBox.TabIndex = 3
        '
        'scannedFilesLbl
        '
        Me.scannedFilesLbl.AutoSize = True
        Me.scannedFilesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scannedFilesLbl.ForeColor = System.Drawing.Color.White
        Me.scannedFilesLbl.Location = New System.Drawing.Point(5, 69)
        Me.scannedFilesLbl.Name = "scannedFilesLbl"
        Me.scannedFilesLbl.Size = New System.Drawing.Size(107, 16)
        Me.scannedFilesLbl.TabIndex = 4
        Me.scannedFilesLbl.Text = "Scanned Files: 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Viruses Found:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Malware Found:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Trojans Found:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(5, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Adware Found:"
        '
        'loadFilesTimer
        '
        Me.loadFilesTimer.Interval = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(117, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(117, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(117, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(117, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "0"
        '
        'Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 303)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.scannedFilesLbl)
        Me.Controls.Add(Me.scannedFilesLBox)
        Me.Controls.Add(Me.scanningLbl)
        Me.Controls.Add(Me.scannerProgressBar)
        Me.Controls.Add(Me.scanBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Scanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virus Scanner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scanBtn As Button
    Friend WithEvents scannerTimer As Timer
    Friend WithEvents scannerProgressBar As ProgressBar
    Friend WithEvents scanningLbl As Label
    Friend WithEvents scannedFilesLBox As ListBox
    Friend WithEvents scannedFilesLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents loadFilesTimer As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
