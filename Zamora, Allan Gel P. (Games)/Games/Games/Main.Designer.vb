<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.BackPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.game1 = New System.Windows.Forms.Panel()
        Me.LBToss = New System.Windows.Forms.Label()
        Me.PBToss = New System.Windows.Forms.PictureBox()
        Me.game2 = New System.Windows.Forms.Panel()
        Me.PBJaken = New System.Windows.Forms.Label()
        Me.PBJacken = New System.Windows.Forms.PictureBox()
        Me.game3 = New System.Windows.Forms.Panel()
        Me.LBSlots = New System.Windows.Forms.Label()
        Me.PBSlots = New System.Windows.Forms.PictureBox()
        Me.game4 = New System.Windows.Forms.Panel()
        Me.LBL9 = New System.Windows.Forms.Label()
        Me.PBL9 = New System.Windows.Forms.PictureBox()
        Me.BackPanel.SuspendLayout()
        Me.game1.SuspendLayout()
        CType(Me.PBToss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.game2.SuspendLayout()
        CType(Me.PBJacken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.game3.SuspendLayout()
        CType(Me.PBSlots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.game4.SuspendLayout()
        CType(Me.PBL9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackPanel
        '
        Me.BackPanel.Controls.Add(Me.Label1)
        Me.BackPanel.Location = New System.Drawing.Point(-5, -4)
        Me.BackPanel.Name = "BackPanel"
        Me.BackPanel.Size = New System.Drawing.Size(752, 68)
        Me.BackPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BetStation"
        '
        'game1
        '
        Me.game1.Controls.Add(Me.LBToss)
        Me.game1.Controls.Add(Me.PBToss)
        Me.game1.Location = New System.Drawing.Point(50, 149)
        Me.game1.Name = "game1"
        Me.game1.Size = New System.Drawing.Size(152, 162)
        Me.game1.TabIndex = 1
        '
        'LBToss
        '
        Me.LBToss.AutoSize = True
        Me.LBToss.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBToss.Location = New System.Drawing.Point(24, 123)
        Me.LBToss.Name = "LBToss"
        Me.LBToss.Size = New System.Drawing.Size(101, 25)
        Me.LBToss.TabIndex = 1
        Me.LBToss.Text = "Toss Coin"
        '
        'PBToss
        '
        Me.PBToss.Location = New System.Drawing.Point(25, 25)
        Me.PBToss.Name = "PBToss"
        Me.PBToss.Size = New System.Drawing.Size(100, 90)
        Me.PBToss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBToss.TabIndex = 0
        Me.PBToss.TabStop = False
        '
        'game2
        '
        Me.game2.Controls.Add(Me.PBJaken)
        Me.game2.Controls.Add(Me.PBJacken)
        Me.game2.Location = New System.Drawing.Point(215, 149)
        Me.game2.Name = "game2"
        Me.game2.Size = New System.Drawing.Size(152, 162)
        Me.game2.TabIndex = 2
        '
        'PBJaken
        '
        Me.PBJaken.AutoSize = True
        Me.PBJaken.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBJaken.Location = New System.Drawing.Point(13, 123)
        Me.PBJaken.Name = "PBJaken"
        Me.PBJaken.Size = New System.Drawing.Size(125, 25)
        Me.PBJaken.TabIndex = 2
        Me.PBJaken.Text = "Jack En Poy"
        '
        'PBJacken
        '
        Me.PBJacken.Location = New System.Drawing.Point(25, 25)
        Me.PBJacken.Name = "PBJacken"
        Me.PBJacken.Size = New System.Drawing.Size(100, 90)
        Me.PBJacken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBJacken.TabIndex = 1
        Me.PBJacken.TabStop = False
        '
        'game3
        '
        Me.game3.Controls.Add(Me.LBSlots)
        Me.game3.Controls.Add(Me.PBSlots)
        Me.game3.Location = New System.Drawing.Point(382, 149)
        Me.game3.Name = "game3"
        Me.game3.Size = New System.Drawing.Size(152, 162)
        Me.game3.TabIndex = 2
        '
        'LBSlots
        '
        Me.LBSlots.AutoSize = True
        Me.LBSlots.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSlots.Location = New System.Drawing.Point(11, 123)
        Me.LBSlots.Name = "LBSlots"
        Me.LBSlots.Size = New System.Drawing.Size(132, 25)
        Me.LBSlots.TabIndex = 3
        Me.LBSlots.Text = "Slot Machine"
        '
        'PBSlots
        '
        Me.PBSlots.Location = New System.Drawing.Point(25, 25)
        Me.PBSlots.Name = "PBSlots"
        Me.PBSlots.Size = New System.Drawing.Size(100, 90)
        Me.PBSlots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSlots.TabIndex = 2
        Me.PBSlots.TabStop = False
        '
        'game4
        '
        Me.game4.Controls.Add(Me.LBL9)
        Me.game4.Controls.Add(Me.PBL9)
        Me.game4.Location = New System.Drawing.Point(550, 149)
        Me.game4.Name = "game4"
        Me.game4.Size = New System.Drawing.Size(152, 162)
        Me.game4.TabIndex = 3
        '
        'LBL9
        '
        Me.LBL9.AutoSize = True
        Me.LBL9.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL9.Location = New System.Drawing.Point(17, 123)
        Me.LBL9.Name = "LBL9"
        Me.LBL9.Size = New System.Drawing.Size(116, 25)
        Me.LBL9.TabIndex = 5
        Me.LBL9.Text = "Lucky Nine"
        '
        'PBL9
        '
        Me.PBL9.Location = New System.Drawing.Point(25, 25)
        Me.PBL9.Name = "PBL9"
        Me.PBL9.Size = New System.Drawing.Size(100, 90)
        Me.PBL9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBL9.TabIndex = 4
        Me.PBL9.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 411)
        Me.Controls.Add(Me.game4)
        Me.Controls.Add(Me.game3)
        Me.Controls.Add(Me.game2)
        Me.Controls.Add(Me.game1)
        Me.Controls.Add(Me.BackPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.BackPanel.ResumeLayout(False)
        Me.BackPanel.PerformLayout()
        Me.game1.ResumeLayout(False)
        Me.game1.PerformLayout()
        CType(Me.PBToss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.game2.ResumeLayout(False)
        Me.game2.PerformLayout()
        CType(Me.PBJacken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.game3.ResumeLayout(False)
        Me.game3.PerformLayout()
        CType(Me.PBSlots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.game4.ResumeLayout(False)
        Me.game4.PerformLayout()
        CType(Me.PBL9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents game1 As Panel
    Friend WithEvents game2 As Panel
    Friend WithEvents game3 As Panel
    Friend WithEvents game4 As Panel
    Friend WithEvents PBToss As PictureBox
    Friend WithEvents PBJacken As PictureBox
    Friend WithEvents PBSlots As PictureBox
    Friend WithEvents PBL9 As PictureBox
    Friend WithEvents LBToss As Label
    Friend WithEvents PBJaken As Label
    Friend WithEvents LBSlots As Label
    Friend WithEvents LBL9 As Label
End Class
