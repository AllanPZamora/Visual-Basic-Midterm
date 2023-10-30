Public Class Jacken
    Private Sub ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ControlPanel.BackColor = Color.FromArgb(100, 0, 0, 0)

        PBMoney.Image = My.Resources.bag
        PBLogo.Image = My.Resources.logo

        PBRock.Image = My.Resources.rock
        PBPaper.Image = My.Resources.paper
        PBScissors.Image = My.Resources.scissors
    End Sub












    Private Sub Jacken_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Main.Show()
        End If
    End Sub


End Class