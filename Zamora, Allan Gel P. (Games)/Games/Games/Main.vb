Public Class Main


    Private Sub BackPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPanel.BackColor = Color.FromArgb(100, 0, 0, 0)
        PBToss.Image = My.Resources.Tosscion
        PBJacken.Image = My.Resources.jacken
        PBSlots.Image = My.Resources.slotmachine
        PBL9.Image = My.Resources.lucky9

    End Sub

    Private Sub game1_Click(sender As Object, e As EventArgs) Handles PBToss.Click, LBToss.Click, game1.Click

    End Sub
End Class
