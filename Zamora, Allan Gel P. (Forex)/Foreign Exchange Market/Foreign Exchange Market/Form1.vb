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

        If cbFrom.SelectedIndex = cbTo.SelectedIndex Then
            MsgBox("Dont Use the same currency")
            txtFrom.Text = ""
        End If

        Dim selectedindex As Integer = cbFrom.SelectedIndex
        Dim selectedindex2 As Integer = cbTo.SelectedIndex

        Dim amount As Double = txtFrom.Text
        Dim res As Double

        Select Case selectedindex

            Case 0

                Select Case selectedindex2
                    Case 1
                        res = amount * 7.83
                    Case 2
                        res = amount * 1.37
                    Case 3
                        res = amount * 83.12
                    Case 4
                        res = amount * 322.66
                    Case 5
                        res = amount * 3.67
                    Case 6
                        res = amount * 56.7
                    Case 7
                        res = amount * 0.82
                    Case 8
                        res = amount * 149.22
                    Case 9
                        res = amount * 0.94
                End Select

            Case 1

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.13
                    Case 2
                        res = amount * 0.17
                    Case 3
                        res = amount * 10.61
                    Case 4
                        res = amount * 41.2
                    Case 5
                        res = amount * 0.47
                    Case 6
                        res = amount * 7.24
                    Case 7
                        res = amount * 0.1
                    Case 8
                        res = amount * 19.05
                    Case 9
                        res = amount * 0.12
                End Select

            Case 2

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.73
                    Case 1
                        res = amount * 5.72
                    Case 3
                        res = amount * 60.74
                    Case 4
                        res = amount * 235.8
                    Case 5
                        res = amount * 2.68
                    Case 6
                        res = amount * 41.44
                    Case 7
                        res = amount * 0.6
                    Case 8
                        res = amount * 109.05
                    Case 9
                        res = amount * 0.69

                End Select

            Case 3

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.012
                    Case 1
                        res = amount * 0.094
                    Case 2
                        res = amount * 0.26
                    Case 4
                        res = amount * 3.88
                    Case 5
                        res = amount * 0.044
                    Case 6
                        res = amount * 0.68
                    Case 7
                        res = amount * 0.0098
                    Case 8
                        res = amount * 1.8
                    Case 9
                        res = amount * 0.011
                End Select

            Case 4

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.0031
                    Case 1
                        res = amount * 0.024
                    Case 2
                        res = amount * 0.0042
                    Case 3
                        res = amount * 0.26
                    Case 5
                        res = amount * 0.011
                    Case 6
                        res = amount * 0.18
                    Case 7
                        res = amount * 0.0025
                    Case 8
                        res = amount * 0.46
                    Case 9
                        res = amount * 0.0029
                End Select

            Case 5

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.27
                    Case 1
                        res = amount * 2.13
                    Case 2
                        res = amount * 0.37
                    Case 3
                        res = amount * 22.63
                    Case 4
                        res = amount * 87.85
                    Case 6
                        res = amount * 15.44
                    Case 7
                        res = amount * 0.22
                    Case 8
                        res = amount * 40.63
                    Case 9
                        res = amount * 0.26
                End Select

            Case 6

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.018
                    Case 1
                        res = amount * 0.14
                    Case 2
                        res = amount * 0.024
                    Case 3
                        res = amount * 1.47
                    Case 4
                        res = amount * 5.69
                    Case 5
                        res = amount * 0.065
                    Case 7
                        res = amount * 0.014
                    Case 8
                        res = amount * 2.63
                    Case 9
                        res = amount * 0.017
                End Select

            Case 7

                Select Case selectedindex2
                    Case 0
                        res = amount * 1.22
                    Case 1
                        res = amount * 9.59
                    Case 2
                        res = amount * 1.67
                    Case 3
                        res = amount * 101.74
                    Case 4
                        res = amount * 394.94
                    Case 5
                        res = amount * 4.5
                    Case 6
                        res = amount * 69.4
                    Case 8
                        res = amount * 183.06
                    Case 9
                        res = amount * 1.15
                End Select

            Case 8

                Select Case selectedindex2
                    Case 0
                        res = amount * 0.0067
                    Case 1
                        res = amount * 0.052
                    Case 2
                        res = amount * 0.0092
                    Case 3
                        res = amount * 0.56
                    Case 4
                        res = amount * 2.16
                    Case 5
                        res = amount * 0.025
                    Case 6
                        res = amount * 0.38
                    Case 7
                        res = amount * 0.0055
                    Case 9
                        res = amount * 0.0063
                End Select

            Case 9

                Select Case selectedindex2
                    Case 0
                        res = amount * 1.06
                    Case 1
                        res = amount * 8.29
                    Case 2
                        res = amount * 1.45
                    Case 3
                        res = amount * 88.12
                    Case 4
                        res = amount * 342.07
                    Case 5
                        res = amount * 3.89
                    Case 6
                        res = amount * 60.11
                    Case 7
                        res = amount * 0.87
                    Case 8
                        res = amount * 158.2
                End Select

        End Select

        txtTo.Text = res.ToString("0.00")
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        cbFrom.SelectedIndex = -1
        cbTo.SelectedIndex = -1
        pbFrom.Image = Nothing
        pbTo.Image = Nothing
        txtFrom.Text = ""
        txtTo.Text = ""
    End Sub
End Class
