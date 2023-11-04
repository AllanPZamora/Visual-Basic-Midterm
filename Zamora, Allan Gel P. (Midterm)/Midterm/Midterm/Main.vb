Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatsPanel.BackColor = Color.FromArgb(180, 221, 221, 255)
        Panel1.BackColor = Color.FromArgb(180, 221, 221, 255)
        PBStats.Image = My.Resources.toyota0
    End Sub
    Private Sub CBBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBrand.SelectedIndexChanged

    End Sub
End Class
