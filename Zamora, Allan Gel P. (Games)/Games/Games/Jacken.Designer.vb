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
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.CBBet = New System.Windows.Forms.ComboBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JackBalance = New System.Windows.Forms.Label()
        Me.PBMoney = New System.Windows.Forms.PictureBox()
        Me.ControlPanel.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ControlPanel.TabIndex = 12
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
        'Jacken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(514, 321)
        Me.Controls.Add(Me.ControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Jacken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JackEnPoy"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ControlPanel As Panel
    Friend WithEvents CBBet As ComboBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents JackBalance As Label
    Friend WithEvents PBMoney As PictureBox
End Class
