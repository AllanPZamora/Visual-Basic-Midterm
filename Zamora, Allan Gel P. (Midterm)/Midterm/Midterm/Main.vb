Imports System.IO
Public Class Main
    Dim Price As Double
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatsPanel.BackColor = Color.FromArgb(180, 221, 221, 255)
        Panel1.BackColor = Color.FromArgb(180, 221, 221, 255)
    End Sub

    Private Sub CBBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBrand.SelectedIndexChanged

        If CBBrand.SelectedIndex = 0 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Avanza")
            CBCar.Items.Add("Carmy")
            CBCar.Items.Add("Atlis")

        ElseIf CBBrand.SelectedIndex = 1 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("City")
            CBCar.Items.Add("Jazz")

        ElseIf CBBrand.SelectedIndex = 2 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Sentra")

            CBCar.Items.Add("Patrol")
        ElseIf CBBrand.SelectedIndex = 3 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Rio")
            CBCar.Items.Add("Sarento")
        End If

    End Sub
    Private Sub CBCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCar.SelectedIndexChanged

        If CBBrand.SelectedIndex = 0 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing

            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Car\Toyota\t" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Toyota" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then
                Price = 1077000
                LBLMoney.Text = Format(Price, "#,##0.00")
            ElseIf CBCar.SelectedIndex = 1 Then
                Price = 1992000
                LBLMoney.Text = Format(Price, "#,##0.00")
            ElseIf CBCar.SelectedIndex = 2 Then
                Price = 1595000
                LBLMoney.Text = Format(Price, "#,##0.00")
            End If

        ElseIf CBBrand.SelectedIndex = 1 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing

            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Car\Honda\h" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Honda" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then
                Price = 1058000
                LBLMoney.Text = Format(Price, "#,##0.00")
            ElseIf CBCar.SelectedIndex = 1 Then
                Price = 1090000
                LBLMoney.Text = Format(Price, "#,##0.00")
            End If

        ElseIf CBBrand.SelectedIndex = 2 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing

            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Car\Nissan\n" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Nissan" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then
                Price = 1048000
                LBLMoney.Text = Format(Price, "#,##0.00")
            ElseIf CBCar.SelectedIndex = 1 Then
                Price = 4538000
                LBLMoney.Text = Format(Price, "#,##0.00")
            End If

        ElseIf CBBrand.SelectedIndex = 3 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Car\Kia\k" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Kia" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then
                Price = 1085000
                LBLMoney.Text = Format(Price, "#,##0.00")
            ElseIf CBCar.SelectedIndex = 1 Then
                Price = 2395000
                LBLMoney.Text = Format(Price, "#,##0.00")
            End If

        End If
    End Sub


End Class
