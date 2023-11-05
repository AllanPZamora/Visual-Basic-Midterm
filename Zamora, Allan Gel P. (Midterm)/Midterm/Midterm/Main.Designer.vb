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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtInput = New System.Windows.Forms.TextBox()
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
        Me.CBBrand.Size = New System.Drawing.Size(131, 26)
        Me.CBBrand.TabIndex = 4
        '
        'CBCar
        '
        Me.CBCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCar.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCar.FormattingEnabled = True
        Me.CBCar.Location = New System.Drawing.Point(153, 13)
        Me.CBCar.Name = "CBCar"
        Me.CBCar.Size = New System.Drawing.Size(188, 26)
        Me.CBCar.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtInput)
        Me.Panel1.Controls.Add(Me.Proceed)
        Me.Panel1.Controls.Add(Me.LBLMoney)
        Me.Panel1.Controls.Add(Me.CBCar)
        Me.Panel1.Controls.Add(Me.CBBrand)
        Me.Panel1.Location = New System.Drawing.Point(34, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 80)
        Me.Panel1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Price ₱:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Year(s) to Pay:"
        '
        'TxtInput
        '
        Me.TxtInput.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.TxtInput.Location = New System.Drawing.Point(232, 45)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(28, 26)
        Me.TxtInput.TabIndex = 8
        '
        'Proceed
        '
        Me.Proceed.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.Proceed.Location = New System.Drawing.Point(266, 45)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(75, 26)
        Me.Proceed.TabIndex = 7
        Me.Proceed.Text = "Proceed"
        Me.Proceed.UseVisualStyleBackColor = True
        '
        'LBLMoney
        '
        Me.LBLMoney.AutoSize = True
        Me.LBLMoney.BackColor = System.Drawing.Color.Transparent
        Me.LBLMoney.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMoney.Location = New System.Drawing.Point(62, 44)
        Me.LBLMoney.Name = "LBLMoney"
        Me.LBLMoney.Size = New System.Drawing.Size(0, 23)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents Label6 As Label
End Class
