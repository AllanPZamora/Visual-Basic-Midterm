Public Class TossCoin






















    Private Sub TossCoin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        Else

            Main.Show()
        End If
    End Sub
End Class