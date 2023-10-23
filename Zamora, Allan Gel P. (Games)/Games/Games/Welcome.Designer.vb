<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgLoad = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Warning = New System.Windows.Forms.Label()
        Me.LBload = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgLoad
        '
        Me.ProgLoad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProgLoad.Location = New System.Drawing.Point(54, 181)
        Me.ProgLoad.Name = "ProgLoad"
        Me.ProgLoad.Size = New System.Drawing.Size(400, 23)
        Me.ProgLoad.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(58, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BetStation V1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Created By: Allan Zamora"
        '
        'PBLogo
        '
        Me.PBLogo.BackColor = System.Drawing.Color.Transparent
        Me.PBLogo.Location = New System.Drawing.Point(14, 34)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 47)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 3
        Me.PBLogo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Add Money"
        '
        'TxtInput
        '
        Me.TxtInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtInput.Location = New System.Drawing.Point(144, 134)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(222, 27)
        Me.TxtInput.TabIndex = 5
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(372, 134)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(82, 27)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Top Up"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Warning
        '
        Me.Warning.AutoSize = True
        Me.Warning.BackColor = System.Drawing.Color.Transparent
        Me.Warning.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warning.Location = New System.Drawing.Point(92, 212)
        Me.Warning.Name = "Warning"
        Me.Warning.Size = New System.Drawing.Size(308, 19)
        Me.Warning.TabIndex = 7
        Me.Warning.Text = "YOU WILL LOSE. Gamble at your own risk!"
        '
        'LBload
        '
        Me.LBload.AutoSize = True
        Me.LBload.BackColor = System.Drawing.Color.Transparent
        Me.LBload.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBload.Location = New System.Drawing.Point(50, 149)
        Me.LBload.Name = "LBload"
        Me.LBload.Size = New System.Drawing.Size(67, 19)
        Me.LBload.TabIndex = 8
        Me.LBload.Text = "Loading"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 249)
        Me.Controls.Add(Me.LBload)
        Me.Controls.Add(Me.Warning)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgLoad As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents Warning As Label
    Friend WithEvents LBload As Label
End Class
