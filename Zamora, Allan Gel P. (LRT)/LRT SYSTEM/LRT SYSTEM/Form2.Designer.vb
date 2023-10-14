<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Namef2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ticketvb2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fromvb2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tovb2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.discountvb2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grossvb2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.netvb2 = New System.Windows.Forms.TextBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Namef2
        '
        Me.Namef2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Namef2.Location = New System.Drawing.Point(12, 77)
        Me.Namef2.Name = "Namef2"
        Me.Namef2.ReadOnly = True
        Me.Namef2.Size = New System.Drawing.Size(312, 33)
        Me.Namef2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(333, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ticket No :"
        '
        'ticketvb2
        '
        Me.ticketvb2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ticketvb2.Location = New System.Drawing.Point(336, 77)
        Me.ticketvb2.Name = "ticketvb2"
        Me.ticketvb2.ReadOnly = True
        Me.ticketvb2.Size = New System.Drawing.Size(145, 33)
        Me.ticketvb2.TabIndex = 7
        Me.ticketvb2.Text = "0000"
        Me.ticketvb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Origin"
        '
        'fromvb2
        '
        Me.fromvb2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.fromvb2.Location = New System.Drawing.Point(12, 138)
        Me.fromvb2.Name = "fromvb2"
        Me.fromvb2.ReadOnly = True
        Me.fromvb2.Size = New System.Drawing.Size(226, 33)
        Me.fromvb2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(252, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Destination"
        '
        'tovb2
        '
        Me.tovb2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.tovb2.Location = New System.Drawing.Point(255, 138)
        Me.tovb2.Name = "tovb2"
        Me.tovb2.ReadOnly = True
        Me.tovb2.Size = New System.Drawing.Size(226, 33)
        Me.tovb2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Discount"
        '
        'discountvb2
        '
        Me.discountvb2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.discountvb2.Location = New System.Drawing.Point(12, 202)
        Me.discountvb2.Name = "discountvb2"
        Me.discountvb2.ReadOnly = True
        Me.discountvb2.Size = New System.Drawing.Size(147, 33)
        Me.discountvb2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(162, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Gross Fare"
        '
        'grossvb2
        '
        Me.grossvb2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.grossvb2.Location = New System.Drawing.Point(165, 202)
        Me.grossvb2.Name = "grossvb2"
        Me.grossvb2.ReadOnly = True
        Me.grossvb2.Size = New System.Drawing.Size(165, 33)
        Me.grossvb2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(333, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Net Fare"
        '
        'netvb2
        '
        Me.netvb2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.netvb2.Location = New System.Drawing.Point(336, 202)
        Me.netvb2.Name = "netvb2"
        Me.netvb2.ReadOnly = True
        Me.netvb2.Size = New System.Drawing.Size(145, 33)
        Me.netvb2.TabIndex = 17
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btndone.FlatAppearance.BorderSize = 0
        Me.btndone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btndone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndone.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btndone.Location = New System.Drawing.Point(418, 241)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(63, 24)
        Me.btndone.TabIndex = 19
        Me.btndone.Text = "Done"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(-5, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 56)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(-5, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 33)
        Me.Panel2.TabIndex = 21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.netvb2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grossvb2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.discountvb2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tovb2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fromvb2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ticketvb2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Namef2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Namef2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ticketvb2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fromvb2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tovb2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents discountvb2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents grossvb2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents netvb2 As TextBox
    Friend WithEvents btndone As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
