<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jacken
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
        Me.MiddlePanel = New System.Windows.Forms.Panel()
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.CBBet = New System.Windows.Forms.ComboBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JackBalance = New System.Windows.Forms.Label()
        Me.PBMoney = New System.Windows.Forms.PictureBox()
        Me.PYou = New System.Windows.Forms.Panel()
        Me.PBYou = New System.Windows.Forms.PictureBox()
        Me.PCom = New System.Windows.Forms.Panel()
        Me.PBCom = New System.Windows.Forms.PictureBox()
        Me.PBRock = New System.Windows.Forms.PictureBox()
        Me.PBPaper = New System.Windows.Forms.PictureBox()
        Me.PBScissors = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ControlPanel.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PYou.SuspendLayout()
        CType(Me.PBYou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCom.SuspendLayout()
        CType(Me.PBCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MiddlePanel
        '
        Me.MiddlePanel.BackColor = System.Drawing.Color.Black
        Me.MiddlePanel.Location = New System.Drawing.Point(260, -4)
        Me.MiddlePanel.Name = "MiddlePanel"
        Me.MiddlePanel.Size = New System.Drawing.Size(5, 331)
        Me.MiddlePanel.TabIndex = 13
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.CBBet)
        Me.ControlPanel.Controls.Add(Me.PBLogo)
        Me.ControlPanel.Controls.Add(Me.Label1)
        Me.ControlPanel.Controls.Add(Me.JackBalance)
        Me.ControlPanel.Controls.Add(Me.PBMoney)
        Me.ControlPanel.Location = New System.Drawing.Point(-9, -1)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(565, 56)
        Me.ControlPanel.TabIndex = 14
        '
        'CBBet
        '
        Me.CBBet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBet.FormattingEnabled = True
        Me.CBBet.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900", "1000"})
        Me.CBBet.Location = New System.Drawing.Point(80, 27)
        Me.CBBet.Name = "CBBet"
        Me.CBBet.Size = New System.Drawing.Size(121, 26)
        Me.CBBet.TabIndex = 10
        '
        'PBLogo
        '
        Me.PBLogo.BackColor = System.Drawing.Color.Transparent
        Me.PBLogo.Location = New System.Drawing.Point(23, 5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 47)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 9
        Me.PBLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter your bet here:"
        '
        'JackBalance
        '
        Me.JackBalance.AutoSize = True
        Me.JackBalance.BackColor = System.Drawing.Color.Transparent
        Me.JackBalance.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JackBalance.Location = New System.Drawing.Point(388, 16)
        Me.JackBalance.Name = "JackBalance"
        Me.JackBalance.Size = New System.Drawing.Size(0, 23)
        Me.JackBalance.TabIndex = 7
        '
        'PBMoney
        '
        Me.PBMoney.BackColor = System.Drawing.Color.Transparent
        Me.PBMoney.Location = New System.Drawing.Point(335, 5)
        Me.PBMoney.Name = "PBMoney"
        Me.PBMoney.Size = New System.Drawing.Size(47, 47)
        Me.PBMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBMoney.TabIndex = 6
        Me.PBMoney.TabStop = False
        '
        'PYou
        '
        Me.PYou.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PYou.Controls.Add(Me.PBYou)
        Me.PYou.Location = New System.Drawing.Point(70, 100)
        Me.PYou.Name = "PYou"
        Me.PYou.Size = New System.Drawing.Size(125, 125)
        Me.PYou.TabIndex = 15
        '
        'PBYou
        '
        Me.PBYou.BackColor = System.Drawing.Color.Transparent
        Me.PBYou.Location = New System.Drawing.Point(13, 13)
        Me.PBYou.Name = "PBYou"
        Me.PBYou.Size = New System.Drawing.Size(100, 100)
        Me.PBYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBYou.TabIndex = 0
        Me.PBYou.TabStop = False
        '
        'PCom
        '
        Me.PCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PCom.Controls.Add(Me.PBCom)
        Me.PCom.Location = New System.Drawing.Point(340, 100)
        Me.PCom.Name = "PCom"
        Me.PCom.Size = New System.Drawing.Size(125, 125)
        Me.PCom.TabIndex = 16
        '
        'PBCom
        '
        Me.PBCom.BackColor = System.Drawing.Color.Transparent
        Me.PBCom.Location = New System.Drawing.Point(13, 13)
        Me.PBCom.Name = "PBCom"
        Me.PBCom.Size = New System.Drawing.Size(100, 100)
        Me.PBCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCom.TabIndex = 1
        Me.PBCom.TabStop = False
        '
        'PBRock
        '
        Me.PBRock.Location = New System.Drawing.Point(15, 255)
        Me.PBRock.Name = "PBRock"
        Me.PBRock.Size = New System.Drawing.Size(70, 55)
        Me.PBRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBRock.TabIndex = 17
        Me.PBRock.TabStop = False
        '
        'PBPaper
        '
        Me.PBPaper.Location = New System.Drawing.Point(95, 255)
        Me.PBPaper.Name = "PBPaper"
        Me.PBPaper.Size = New System.Drawing.Size(70, 55)
        Me.PBPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPaper.TabIndex = 18
        Me.PBPaper.TabStop = False
        '
        'PBScissors
        '
        Me.PBScissors.Location = New System.Drawing.Point(175, 255)
        Me.PBScissors.Name = "PBScissors"
        Me.PBScissors.Size = New System.Drawing.Size(70, 55)
        Me.PBScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBScissors.TabIndex = 19
        Me.PBScissors.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "You"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Computer"
        '
        'Jacken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(514, 321)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBScissors)
        Me.Controls.Add(Me.PBPaper)
        Me.Controls.Add(Me.PBRock)
        Me.Controls.Add(Me.PCom)
        Me.Controls.Add(Me.PYou)
        Me.Controls.Add(Me.ControlPanel)
        Me.Controls.Add(Me.MiddlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Jacken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JackEnPoy"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PYou.ResumeLayout(False)
        CType(Me.PBYou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCom.ResumeLayout(False)
        CType(Me.PBCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MiddlePanel As Panel
    Friend WithEvents ControlPanel As Panel
    Friend WithEvents CBBet As ComboBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents JackBalance As Label
    Friend WithEvents PBMoney As PictureBox
    Friend WithEvents PYou As Panel
    Friend WithEvents PCom As Panel
    Friend WithEvents PBRock As PictureBox
    Friend WithEvents PBPaper As PictureBox
    Friend WithEvents PBScissors As PictureBox
    Friend WithEvents PBYou As PictureBox
    Friend WithEvents PBCom As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
