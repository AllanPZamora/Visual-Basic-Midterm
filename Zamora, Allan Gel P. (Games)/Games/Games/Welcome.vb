﻿Public Class Welcome

    Public Shared InputValue As String

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgLoad.Value = 0
        ProgLoad.Hide()
        Warning.Hide()
        LBload.Hide()
        PBLogo.Image = My.Resources.logo

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Integer.TryParse(TxtInput.Text, InputValue) Then
            If InputValue <= 99 Then
                MessageBox.Show("Error: Not enough balance. Please enter a balance greater than 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtInput.Text = ""
            ElseIf InputValue = 0 Then
                MessageBox.Show("Error: Balance cannot be zero. Please enter a valid balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtInput.Text = ""
            Else
                Main.MainBalance.Text = InputValue.ToString()
                Jacken.JackBalance.Text = InputValue.ToString()
                TossCoin.TossBalance.Text = InputValue.ToString()
                TxtInput.Hide()
                btnStart.Hide()
                Label3.Hide()
                Timer1.Start()
                Warning.Show()
                ProgLoad.Show()
                LBload.Show()
            End If
        Else
            MessageBox.Show("Please enter a valid number with numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtInput.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgLoad.Value = ProgLoad.Value + 2
        If ProgLoad.Value >= 100 Then
            Timer1.Stop()
            Main.Show()
            Me.Hide()
        End If
    End Sub

End Class