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
        Me.SuspendLayout()
        '
        'TxtFixedPrice
        '
        Me.TxtFixedPrice.Location = New System.Drawing.Point(123, 145)
        Me.TxtFixedPrice.Name = "TxtFixedPrice"
        Me.TxtFixedPrice.Size = New System.Drawing.Size(191, 20)
        Me.TxtFixedPrice.TabIndex = 0
        '
        'TxtYear
        '
        Me.TxtYear.Location = New System.Drawing.Point(123, 171)
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(191, 20)
        Me.TxtYear.TabIndex = 1
        '
        'TxtInt
        '
        Me.TxtInt.Location = New System.Drawing.Point(123, 197)
        Me.TxtInt.Name = "TxtInt"
        Me.TxtInt.Size = New System.Drawing.Size(191, 20)
        Me.TxtInt.TabIndex = 2
        '
        'TxtTotalPrice
        '
        Me.TxtTotalPrice.Location = New System.Drawing.Point(123, 223)
        Me.TxtTotalPrice.Name = "TxtTotalPrice"
        Me.TxtTotalPrice.Size = New System.Drawing.Size(191, 20)
        Me.TxtTotalPrice.TabIndex = 3
        '
        'TxtMonthly
        '
        Me.TxtMonthly.Location = New System.Drawing.Point(123, 249)
        Me.TxtMonthly.Name = "TxtMonthly"
        Me.TxtMonthly.Size = New System.Drawing.Size(191, 20)
        Me.TxtMonthly.TabIndex = 4
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 366)
        Me.Controls.Add(Me.TxtMonthly)
        Me.Controls.Add(Me.TxtTotalPrice)
        Me.Controls.Add(Me.TxtInt)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.TxtFixedPrice)
        Me.Name = "Checkout"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFixedPrice As TextBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents TxtInt As TextBox
    Friend WithEvents TxtTotalPrice As TextBox
    Friend WithEvents TxtMonthly As TextBox
End Class
