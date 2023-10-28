<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TossCoin
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
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.CBBet = New System.Windows.Forms.ComboBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TossBalance = New System.Windows.Forms.Label()
        Me.PBMoney = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnFlip = New System.Windows.Forms.Button()
        Me.HTChoose = New System.Windows.Forms.ComboBox()
        Me.PBCom = New System.Windows.Forms.PictureBox()
        Me.PBYou = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ControlPanel.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBYou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.CBBet)
        Me.ControlPanel.Controls.Add(Me.PBLogo)
        Me.ControlPanel.Controls.Add(Me.Label1)
        Me.ControlPanel.Controls.Add(Me.TossBalance)
        Me.ControlPanel.Controls.Add(Me.PBMoney)
        Me.ControlPanel.Location = New System.Drawing.Point(-9, -1)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(565, 56)
        Me.ControlPanel.TabIndex = 0
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
        'TossBalance
        '
        Me.TossBalance.AutoSize = True
        Me.TossBalance.BackColor = System.Drawing.Color.Transparent
        Me.TossBalance.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TossBalance.Location = New System.Drawing.Point(388, 16)
        Me.TossBalance.Name = "TossBalance"
        Me.TossBalance.Size = New System.Drawing.Size(0, 23)
        Me.TossBalance.TabIndex = 7
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
        'Timer1
        '
        '
        'BtnFlip
        '
        Me.BtnFlip.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFlip.Location = New System.Drawing.Point(225, 269)
        Me.BtnFlip.Name = "BtnFlip"
        Me.BtnFlip.Size = New System.Drawing.Size(75, 30)
        Me.BtnFlip.TabIndex = 3
        Me.BtnFlip.Text = "Flip"
        Me.BtnFlip.UseVisualStyleBackColor = True
        '
        'HTChoose
        '
        Me.HTChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HTChoose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.HTChoose.FormattingEnabled = True
        Me.HTChoose.Items.AddRange(New Object() {"Head", "Tail"})
        Me.HTChoose.Location = New System.Drawing.Point(225, 87)
        Me.HTChoose.Name = "HTChoose"
        Me.HTChoose.Size = New System.Drawing.Size(75, 26)
        Me.HTChoose.TabIndex = 4
        '
        'PBCom
        '
        Me.PBCom.Location = New System.Drawing.Point(326, 125)
        Me.PBCom.Name = "PBCom"
        Me.PBCom.Size = New System.Drawing.Size(125, 125)
        Me.PBCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCom.TabIndex = 2
        Me.PBCom.TabStop = False
        '
        'PBYou
        '
        Me.PBYou.Location = New System.Drawing.Point(75, 125)
        Me.PBYou.Name = "PBYou"
        Me.PBYou.Size = New System.Drawing.Size(125, 125)
        Me.PBYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBYou.TabIndex = 1
        Me.PBYou.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Choose:"
        '
        'TossCoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(514, 321)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HTChoose)
        Me.Controls.Add(Me.BtnFlip)
        Me.Controls.Add(Me.PBCom)
        Me.Controls.Add(Me.PBYou)
        Me.Controls.Add(Me.ControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TossCoin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toss Coin"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBYou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlPanel As Panel
    Friend WithEvents TossBalance As Label
    Friend WithEvents PBMoney As PictureBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBBet As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PBYou As PictureBox
    Friend WithEvents PBCom As PictureBox
    Friend WithEvents BtnFlip As Button
    Friend WithEvents HTChoose As ComboBox
    Friend WithEvents Label2 As Label
End Class
