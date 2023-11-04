Imports System.IO
Public Class Main
    Dim Price As Double
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatsPanel.BackColor = Color.FromArgb(180, 221, 221, 255)
        Panel1.BackColor = Color.FromArgb(180, 221, 221, 255)
        'debug imgs
        ' PBCar.Image = My.Resources.t0

    End Sub
    Private Sub CBBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBrand.SelectedIndexChanged

        If CBBrand.SelectedIndex = 0 Then
            PBCar.Image = Nothing
            PBStats.Image = Nothing

            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Avanza")
            CBCar.Items.Add("Carmy")
            CBCar.Items.Add("Atlis")

        ElseIf CBBrand.SelectedIndex = 1 Then
            PBCar.Image = Nothing
            PBStats.Image = Nothing

            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("City")
            CBCar.Items.Add("Jazz")

        ElseIf CBBrand.SelectedIndex = 2 Then
            PBCar.Image = Nothing
            PBStats.Image = Nothing

            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Sentra")

            CBCar.Items.Add("Patrol")
        ElseIf CBBrand.SelectedIndex = 3 Then
            PBCar.Image = Nothing

            PBStats.Image = Nothing
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
            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Toyota\t" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Toyota" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then

            ElseIf CBCar.SelectedIndex = 1 Then

            ElseIf CBCar.SelectedIndex = 2 Then

            End If

        ElseIf CBBrand.SelectedIndex = 1 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Honda\h" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Honda" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then

            ElseIf CBCar.SelectedIndex = 1 Then

            End If

        ElseIf CBBrand.SelectedIndex = 2 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Nissan\n" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Nissan" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then

            ElseIf CBCar.SelectedIndex = 1 Then

            End If

        ElseIf CBBrand.SelectedIndex = 3 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            PBCar.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Kia\k" & CBCar.SelectedIndex & ".png")
            PBStats.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Stats\Kia" & CBCar.SelectedIndex & ".png")

            If CBCar.SelectedIndex = 0 Then

            ElseIf CBCar.SelectedIndex = 1 Then

            End If

        End If
    End Sub
End Class
