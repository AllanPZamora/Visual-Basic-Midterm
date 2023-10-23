Public Class Welcome

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
            Main.MainBalance.Text = InputValue.ToString()

            TxtInput.Hide()
            btnStart.Hide()
            Label3.Hide()
            Timer1.Start()
            Warning.Show()
            ProgLoad.Show()
            LBload.Show()
        Else
            MessageBox.Show("Please enter a valid number with numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtInput.Text = ""
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgLoad.Value = ProgLoad.Value + 1
        If ProgLoad.Value >= 100 Then
            Timer1.Stop()
            Main.Show()
            Me.Hide()
        End If
    End Sub

End Class