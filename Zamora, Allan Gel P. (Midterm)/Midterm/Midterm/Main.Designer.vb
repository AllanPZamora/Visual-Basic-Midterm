<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.StatsPanel = New System.Windows.Forms.Panel()
        Me.PBStats = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBCar = New System.Windows.Forms.PictureBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.CBBrand = New System.Windows.Forms.ComboBox()
        Me.CBCar = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Proceed = New System.Windows.Forms.Button()
        Me.LBLMoney = New System.Windows.Forms.Label()
        Me.StatsPanel.SuspendLayout()
        CType(Me.PBStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatsPanel
        '
        Me.StatsPanel.Controls.Add(Me.PBStats)
        Me.StatsPanel.Controls.Add(Me.Label4)
        Me.StatsPanel.Controls.Add(Me.Label3)
        Me.StatsPanel.Controls.Add(Me.Label2)
        Me.StatsPanel.Location = New System.Drawing.Point(474, 329)
        Me.StatsPanel.Name = "StatsPanel"
        Me.StatsPanel.Size = New System.Drawing.Size(252, 80)
        Me.StatsPanel.TabIndex = 0
        '
        'PBStats
        '
        Me.PBStats.BackColor = System.Drawing.Color.Transparent
        Me.PBStats.Location = New System.Drawing.Point(115, 10)
        Me.PBStats.Name = "PBStats"
        Me.PBStats.Size = New System.Drawing.Size(126, 60)
        Me.PBStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBStats.TabIndex = 3
        Me.PBStats.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ACCELERATION:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HANDLING:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TOP SPEED:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(666, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'PBCar
        '
        Me.PBCar.BackColor = System.Drawing.Color.Transparent
        Me.PBCar.Location = New System.Drawing.Point(196, 132)
        Me.PBCar.Name = "PBCar"
        Me.PBCar.Size = New System.Drawing.Size(387, 236)
        Me.PBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCar.TabIndex = 2
        Me.PBCar.TabStop = False
        '
        'PBLogo
        '
        Me.PBLogo.BackColor = System.Drawing.Color.Transparent
        Me.PBLogo.Location = New System.Drawing.Point(34, 20)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(130, 100)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 3
        Me.PBLogo.TabStop = False
        '
        'CBBrand
        '
        Me.CBBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBrand.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBrand.FormattingEnabled = True
        Me.CBBrand.Items.AddRange(New Object() {"Toyota", "Honda", "Nissan", "Kia"})
        Me.CBBrand.Location = New System.Drawing.Point(16, 13)
        Me.CBBrand.Name = "CBBrand"
        Me.CBBrand.Size = New System.Drawing.Size(99, 26)
        Me.CBBrand.TabIndex = 4
        '
        'CBCar
        '
        Me.CBCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCar.FormattingEnabled = True
        Me.CBCar.Location = New System.Drawing.Point(132, 13)
        Me.CBCar.Name = "CBCar"
        Me.CBCar.Size = New System.Drawing.Size(157, 26)
        Me.CBCar.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Proceed)
        Me.Panel1.Controls.Add(Me.LBLMoney)
        Me.Panel1.Controls.Add(Me.CBCar)
        Me.Panel1.Controls.Add(Me.CBBrand)
        Me.Panel1.Location = New System.Drawing.Point(34, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 80)
        Me.Panel1.TabIndex = 6
        '
        'Proceed
        '
        Me.Proceed.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.Proceed.Location = New System.Drawing.Point(189, 45)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(100, 26)
        Me.Proceed.TabIndex = 7
        Me.Proceed.Text = "Proceed"
        Me.Proceed.UseVisualStyleBackColor = True
        '
        'LBLMoney
        '
        Me.LBLMoney.AutoSize = True
        Me.LBLMoney.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.LBLMoney.Location = New System.Drawing.Point(33, 50)
        Me.LBLMoney.Name = "LBLMoney"
        Me.LBLMoney.Size = New System.Drawing.Size(0, 18)
        Me.LBLMoney.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Midterm.My.Resources.Resources.Untitled_design_20231104_223232_0000
        Me.ClientSize = New System.Drawing.Size(764, 436)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatsPanel)
        Me.Controls.Add(Me.PBCar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Room"
        Me.StatsPanel.ResumeLayout(False)
        Me.StatsPanel.PerformLayout()
        CType(Me.PBStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatsPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PBStats As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PBCar As PictureBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents CBBrand As ComboBox
    Friend WithEvents CBCar As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLMoney As Label
    Friend WithEvents Proceed As Button
End Class
