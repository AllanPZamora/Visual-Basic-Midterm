Imports System.IO
Public Class Main
    Dim Price As Integer
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatsPanel.BackColor = Color.FromArgb(180, 221, 221, 255)
        Panel1.BackColor = Color.FromArgb(180, 221, 221, 255)
    End Sub

    Private Sub CBBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBrand.SelectedIndexChanged

        If CBBrand.SelectedIndex = 0 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            Checkout.TxtInt.Text = "10%"
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Avanza")
            CBCar.Items.Add("Carmy")
            CBCar.Items.Add("Atlis")

        ElseIf CBBrand.SelectedIndex = 1 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            Checkout.TxtInt.Text = "11%"
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("City")
            CBCar.Items.Add("Jazz")

        ElseIf CBBrand.SelectedIndex = 2 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            Checkout.TxtInt.Text = "09%"
            PBLogo.Image = Image.FromFile(Directory.GetCurrentDirectory & "\brand\logo" & CBBrand.SelectedIndex & ".png")

            CBCar.Items.Clear()
            CBCar.Items.Add("Sentra")

            CBCar.Items.Add("Patrol")
        ElseIf CBBrand.SelectedIndex = 3 Then
            PBStats.Image = Nothing
            PBCar.Image = Nothing
            LBLMoney.Text = ""
            Checkout.TxtInt.Text = "08%"
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

    Private Sub Proceed_Click(sender As Object, e As EventArgs) Handles Proceed.Click
        Dim total As Integer
        Dim totalprice As Integer
        Dim annualsale As Integer
        Dim monthly As Integer

        If TxtInput.Text = Nothing Then
            MsgBox("Please add years to pay")


        ElseIf CBBrand.SelectedIndex = "0" Then ' toyota

            If CBCar.SelectedIndex = "0" Then

                annualsale = Price * 0.1
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()
            ElseIf CBCar.SelectedIndex = "1" Then

                annualsale = Price * 0.1
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            ElseIf CBCar.SelectedIndex = "2" Then

                annualsale = Price * 0.1
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            End If

        ElseIf CBBrand.SelectedIndex = "1" Then 'honda

            If CBCar.SelectedIndex = "0" Then

                annualsale = Price * 0.11
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()
            ElseIf CBCar.SelectedIndex = "1" Then

                annualsale = Price * 0.11
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            End If

        ElseIf CBBrand.SelectedIndex = "2" Then 'nissan

            If CBCar.SelectedIndex = "0" Then

                annualsale = Price * 0.09
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            ElseIf CBCar.SelectedIndex = "1" Then

                annualsale = Price * 0.09
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            End If

        ElseIf CBBrand.SelectedIndex = "3" Then 'kia

            If CBCar.SelectedIndex = "0" Then

                annualsale = Price * 0.08
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            ElseIf CBCar.SelectedIndex = "1" Then

                annualsale = Price * 0.08
                total = annualsale * TxtInput.Text
                totalprice = total + Price
                monthly = (totalprice / (TxtInput.Text * 12))
                Checkout.TxtFixedPrice.Text = Price
                Checkout.TxtYear.Text = TxtInput.Text
                Checkout.TxtTotalPrice.Text = totalprice
                Checkout.TxtMonthly.Text = monthly
                Checkout.Show()
                Me.Hide()

            End If
        End If
    End Sub

End Class
