Public Class Form1



    '    0 USD
    '    1 HKD
    '    2 CAD
    '    3 INR
    '    4 SLR
    '    5 AED
    '    6 PHP
    '    7 GBP
    '    8 JPY
    '    9 EUR




    Private Sub cbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFrom.SelectedIndexChanged
        Dim imageResources() As Image = {My.Resources._0us, My.Resources._1hk, My.Resources._2ca, My.Resources._3in, My.Resources._4lk, My.Resources._5ae, My.Resources._6ph, My.Resources._7gb, My.Resources._8jp, My.Resources._9eu}

        If cbFrom.SelectedIndex >= 0 AndAlso cbFrom.SelectedIndex < imageResources.Length Then
            pbFrom.Image = imageResources(cbFrom.SelectedIndex)
        End If

    End Sub

    Private Sub cbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTo.SelectedIndexChanged
        Dim imageResources() As Image = {My.Resources._0us, My.Resources._1hk, My.Resources._2ca, My.Resources._3in, My.Resources._4lk, My.Resources._5ae, My.Resources._6ph, My.Resources._7gb, My.Resources._8jp, My.Resources._9eu}

        If cbTo.SelectedIndex >= 0 AndAlso cbTo.SelectedIndex < imageResources.Length Then
            pbTo.Image = imageResources(cbTo.SelectedIndex)
        End If

    End Sub
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

    End Sub
End Class
