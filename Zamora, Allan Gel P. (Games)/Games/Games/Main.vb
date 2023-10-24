Public Class Main
    Private closingConfirmed As Boolean = False
    Private Sub BackPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPanel.BackColor = Color.FromArgb(100, 0, 0, 0)
        MainBalance.Text = Welcome.InputValue.ToString
        PBLogo.Image = My.Resources.logo
        PBMoney.Image = My.Resources.bag
        PBToss.Image = My.Resources.Tosscion
        PBJacken.Image = My.Resources.jacken
        PBSlots.Image = My.Resources.slotmachine
        PBL9.Image = My.Resources.lucky9

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not closingConfirmed Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True
            Else
                closingConfirmed = True
                Application.Exit()
            End If
        End If
    End Sub


    Private Sub Game1_Click(sender As Object, e As EventArgs) Handles PBToss.Click, LBToss.Click, game1.Click
        TossCoin.Show()
        Me.Hide()
    End Sub

    'Private Sub Game2_Click(sender As Object, e As EventArgs) Handles PBJaken.Click, PBJacken.Click, game2.Click
    '    TossCoin.Show()
    '    Me.Hide()
    'End Sub

    'Private Sub Game3_Click(sender As Object, e As EventArgs) Handles PBSlots.Click, LBSlots.Click, game3.Click
    '    TossCoin.Show()
    '    Me.Hide()
    'End Sub

    ''Private Sub Game4_Click(sender As Object, e As EventArgs) Handles PBL9.Click, LBL9.Click, game4.Click
    ''TossCoin.Show()
    '' Me.Hide()
    ''End Sub



End Class
