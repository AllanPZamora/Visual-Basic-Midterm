Public Class Form1
    Private Sub cbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFrom.SelectedIndexChanged
        Dim imageResources() As Image = {My.Resources._0us, My.Resources._1hk, My.Resources._2ca, My.Resources._3in, My.Resources._4lk, My.Resources._5ae, My.Resources._6ph, My.Resources._7gb, My.Resources._8jp, My.Resources._9eu}
        Dim currencySymbols() As String = {"$", "HK$", "C$", "₹", "SLR", "AED", "₱", "£", "¥", "€"}

        If cbFrom.SelectedIndex >= 0 AndAlso cbFrom.SelectedIndex < imageResources.Length Then
            pbFrom.Image = imageResources(cbFrom.SelectedIndex)

            If cbFrom.SelectedIndex >= 0 AndAlso cbFrom.SelectedIndex < currencySymbols.Length Then
                naol1.Text = currencySymbols(cbFrom.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub cbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTo.SelectedIndexChanged
        Dim imageResources() As Image = {My.Resources._0us, My.Resources._1hk, My.Resources._2ca, My.Resources._3in, My.Resources._4lk, My.Resources._5ae, My.Resources._6ph, My.Resources._7gb, My.Resources._8jp, My.Resources._9eu}
        Dim currencySymbols() As String = {"$", "HK$", "C$", "₹", "SLR", "AED", "₱", "£", "¥", "€"}

        If cbTo.SelectedIndex >= 0 AndAlso cbTo.SelectedIndex < imageResources.Length Then
            pbTo.Image = imageResources(cbTo.SelectedIndex)

            If cbTo.SelectedIndex >= 0 AndAlso cbTo.SelectedIndex < currencySymbols.Length Then
                naol2.Text = currencySymbols(cbTo.SelectedIndex)
            End If
        End If
    End Sub
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If cbFrom.SelectedIndex = -1 Then
            MsgBox("Please select the source currency")
            txtFrom.Text = ""
            Return
        ElseIf cbTo.SelectedIndex = -1 Then
            MsgBox("Please select the target currency")
            txtFrom.Text = ""
            Return
        ElseIf cbFrom.SelectedIndex = cbTo.SelectedIndex Then
            MsgBox("Don't use the same currency")
            txtFrom.Text = ""
            Return
        End If

        Dim selectedindex As Integer = cbFrom.SelectedIndex
        Dim selectedindex2 As Integer = cbTo.SelectedIndex
        Dim amount As Double
            Dim res As Double

            Dim conversionFactors(,) As Double = {
                {0, 7.83, 1.37, 83.12, 322.66, 3.67, 56.7, 0.82, 149.22, 0.94},
                {0.13, 0, 0.17, 10.61, 41.2, 0.47, 7.24, 0.1, 19.05, 0.12},
                {0.73, 5.73, 0, 60.92, 236.75, 2.69, 41.65, 0.6, 109.12, 0.7},
                {0.012, 0.094, 0.016, 0, 3.88, 0.044, 0.0098, 0.68, 1.8, 0.11},
                {0.0031, 0.024, 0.0042, 0.26, 0, 0.011, 0.18, 0.0025, 0.46, 0.0029},
                {0.27, 2.13, 0.37, 22.13, 87.85, 0, 15.44, 0.22, 40.63, 0.26},
                {0.018, 0.14, 0.024, 1.47, 5.69, 0.065, 0, 0.014, 2.63, 0.017},
                {1.22, 9.59, 1.66, 101.74, 394.94, 4.5, 69.4, 0, 182.67, 1.15},
                {0.0067, 0.052, 0.0092, 0.56, 2.16, 0.025, 0.38, 0.0055, 0, 0.0063},
                {1.06, 8.3, 1.44, 87.67, 340.68, 3.87, 59.96, 0.87, 157.07, 0}
            }

            Try
            amount = Double.Parse(txtFrom.Text)
            res = amount * conversionFactors(selectedindex, selectedindex2)
            txtTo.Text = res.ToString("0.00")
        Catch ex As Exception
                MsgBox("Enter a valid amount")
            End Try
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        cbFrom.SelectedIndex = -1
        cbTo.SelectedIndex = -1
        pbFrom.Image = Nothing
        pbTo.Image = Nothing
        txtFrom.Text = ""
        txtTo.Text = ""
        naol1.Text = ""
        naol2.Text = ""

    End Sub
End Class
