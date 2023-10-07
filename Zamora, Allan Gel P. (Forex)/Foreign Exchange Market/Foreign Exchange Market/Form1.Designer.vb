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
        Me.SuspendLayout()
        '
        'cbFrom
        '
        Me.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrom.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFrom.FormattingEnabled = True
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
        Me.btnReset.Location = New System.Drawing.Point(152, 237)
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
        Me.cbTo.Location = New System.Drawing.Point(59, 383)
        Me.cbTo.Name = "cbTo"
        Me.cbTo.Size = New System.Drawing.Size(186, 31)
        Me.cbTo.TabIndex = 4
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(59, 237)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(93, 39)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(302, 482)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbFrom As ComboBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtTo As TextBox
    Friend WithEvents cbTo As ComboBox
    Friend WithEvents btnConvert As Button
End Class
