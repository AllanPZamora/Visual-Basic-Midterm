<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.cbFrom = New System.Windows.Forms.ComboBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.cbTo = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.pbFrom = New System.Windows.Forms.PictureBox()
        Me.pbTo = New System.Windows.Forms.PictureBox()
        Me.naol1 = New System.Windows.Forms.Label()
        Me.naol2 = New System.Windows.Forms.Label()
        CType(Me.pbFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(158, 220)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 39)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtTo
        '
        Me.txtTo.Enabled = False
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
        Me.btnConvert.BackColor = System.Drawing.Color.Lime
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(59, 220)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(93, 39)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'pbFrom
        '
        Me.pbFrom.Location = New System.Drawing.Point(59, 23)
        Me.pbFrom.Name = "pbFrom"
        Me.pbFrom.Size = New System.Drawing.Size(186, 100)
        Me.pbFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFrom.TabIndex = 7
        Me.pbFrom.TabStop = False
        '
        'pbTo
        '
        Me.pbTo.Location = New System.Drawing.Point(59, 277)
        Me.pbTo.Name = "pbTo"
        Me.pbTo.Size = New System.Drawing.Size(186, 100)
        Me.pbTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTo.TabIndex = 8
        Me.pbTo.TabStop = False
        '
        'naol1
        '
        Me.naol1.AutoSize = True
        Me.naol1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.naol1.Location = New System.Drawing.Point(12, 169)
        Me.naol1.Name = "naol1"
        Me.naol1.Size = New System.Drawing.Size(0, 23)
        Me.naol1.TabIndex = 9
        '
        'naol2
        '
        Me.naol2.AutoSize = True
        Me.naol2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.naol2.Location = New System.Drawing.Point(12, 423)
        Me.naol2.Name = "naol2"
        Me.naol2.Size = New System.Drawing.Size(0, 23)
        Me.naol2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(302, 482)
        Me.Controls.Add(Me.naol2)
        Me.Controls.Add(Me.naol1)
        Me.Controls.Add(Me.pbTo)
        Me.Controls.Add(Me.pbFrom)
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
        CType(Me.pbFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbFrom As ComboBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtTo As TextBox
    Friend WithEvents cbTo As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents pbFrom As PictureBox
    Friend WithEvents pbTo As PictureBox
    Friend WithEvents naol1 As Label
    Friend WithEvents naol2 As Label
End Class
