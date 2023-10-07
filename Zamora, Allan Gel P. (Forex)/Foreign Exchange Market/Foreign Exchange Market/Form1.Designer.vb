<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbFrom = New System.Windows.Forms.ComboBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.cbTo = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbFrom
        '
        Me.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrom.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFrom.FormattingEnabled = True
        Me.cbFrom.Items.AddRange(New Object() {"USD", "HKD", "CAD", "INR", "SLR", "AED", "PHP", "GBP", "JPY", "EUR"})
        Me.cbFrom.Location = New System.Drawing.Point(59, 129)
        Me.cbFrom.Name = "cbFrom"
        Me.cbFrom.Size = New System.Drawing.Size(186, 31)
        Me.cbFrom.TabIndex = 1
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtFrom.Location = New System.Drawing.Point(59, 166)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(186, 29)
        Me.txtFrom.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(152, 220)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 39)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtTo.Location = New System.Drawing.Point(59, 420)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(186, 29)
        Me.txtTo.TabIndex = 5
        '
        'cbTo
        '
        Me.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTo.FormattingEnabled = True
        Me.cbTo.Items.AddRange(New Object() {"USD", "HKD", "CAD", "INR", "SLR", "AED", "PHP", "GBP", "JPY", "EUR"})
        Me.cbTo.Location = New System.Drawing.Point(59, 383)
        Me.cbTo.Name = "cbTo"
        Me.cbTo.Size = New System.Drawing.Size(186, 31)
        Me.cbTo.TabIndex = 4
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(59, 220)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(93, 39)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(59, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 100)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(59, 277)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 100)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(302, 482)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.cbTo)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cbFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forex"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbFrom As ComboBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtTo As TextBox
    Friend WithEvents cbTo As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
