Public Class TossCoin

    Private Sub TossCoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlPanel.BackColor = Color.FromArgb(100, 0, 0, 0)
        PBMoney.Image = My.Resources.bag
        PBLogo.Image = My.Resources.logo
    End Sub





















    Private Sub TossCoin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Main.Show()
        End If
    End Sub

    Private Sub HTChoose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HTChoose.SelectedIndexChanged
        Select Case HTChoose.SelectedIndex
            Case 0
                PBYou.Image = My.Resources.coin0
            Case 1
                PBYou.Image = My.Resources.coin1
        End Select
    End Sub

    Private Sub BtnFlip_Click(sender As Object, e As EventArgs) Handles BtnFlip.Click

    End Sub
End Class