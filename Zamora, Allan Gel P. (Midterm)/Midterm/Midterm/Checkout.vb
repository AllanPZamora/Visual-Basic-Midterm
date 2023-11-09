Public Class Checkout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.CBBrand.SelectedIndex = -1
        Main.CBCar.SelectedIndex = -1
        Main.PBCar.Image = Nothing
        Main.PBLogo.Image = Nothing
        Main.PBStats.Image = Nothing
        Main.TxtInput.Text = ""
        Main.LBLMoney.Text = ""

        Main.Show()
        Me.Hide()
    End Sub
End Class