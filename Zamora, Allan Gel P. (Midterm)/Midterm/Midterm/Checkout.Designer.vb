<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Me.TxtFixedPrice = New System.Windows.Forms.TextBox()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.TxtInt = New System.Windows.Forms.TextBox()
        Me.TxtTotalPrice = New System.Windows.Forms.TextBox()
        Me.TxtMonthly = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtFixedPrice
        '
        Me.TxtFixedPrice.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtFixedPrice.Location = New System.Drawing.Point(178, 75)
        Me.TxtFixedPrice.Name = "TxtFixedPrice"
        Me.TxtFixedPrice.Size = New System.Drawing.Size(191, 22)
        Me.TxtFixedPrice.TabIndex = 0
        '
        'TxtYear
        '
        Me.TxtYear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtYear.Location = New System.Drawing.Point(178, 101)
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(191, 22)
        Me.TxtYear.TabIndex = 1
        '
        'TxtInt
        '
        Me.TxtInt.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtInt.Location = New System.Drawing.Point(178, 127)
        Me.TxtInt.Name = "TxtInt"
        Me.TxtInt.Size = New System.Drawing.Size(191, 22)
        Me.TxtInt.TabIndex = 2
        '
        'TxtTotalPrice
        '
        Me.TxtTotalPrice.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtTotalPrice.Location = New System.Drawing.Point(178, 153)
        Me.TxtTotalPrice.Name = "TxtTotalPrice"
        Me.TxtTotalPrice.Size = New System.Drawing.Size(191, 22)
        Me.TxtTotalPrice.TabIndex = 3
        '
        'TxtMonthly
        '
        Me.TxtMonthly.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtMonthly.Location = New System.Drawing.Point(178, 179)
        Me.TxtMonthly.Name = "TxtMonthly"
        Me.TxtMonthly.Size = New System.Drawing.Size(191, 22)
        Me.TxtMonthly.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(65, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MONTHLY DUES :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(80, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TOTAL PRICE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(48, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "AMOUNT INTEREST :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(67, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "YEAR(S) TO PAY :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(118, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "PRICE :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 39)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Buy Again"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMonthly)
        Me.Controls.Add(Me.TxtTotalPrice)
        Me.Controls.Add(Me.TxtInt)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.TxtFixedPrice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFixedPrice As TextBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents TxtInt As TextBox
    Friend WithEvents TxtTotalPrice As TextBox
    Friend WithEvents TxtMonthly As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
