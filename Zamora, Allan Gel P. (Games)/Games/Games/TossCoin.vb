Imports System.Data.SqlTypes
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class TossCoin
    Dim random02 As New Random()
    Dim coincount As Integer
    Dim pertick As Integer
    Dim money As Integer

    Private Sub TossCoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlPanel.BackColor = Color.FromArgb(100, 0, 0, 0)
        PBMoney.Image = My.Resources.bag
        PBLogo.Image = My.Resources.logo
    End Sub

    Private Sub HTChoose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HTChoose.SelectedIndexChanged
        PBYou.Image = If(HTChoose.SelectedIndex = 0, My.Resources.coin0, My.Resources.coin1)
    End Sub

    Private Sub BtnFlip_Click(sender As Object, e As EventArgs) Handles BtnFlip.Click
        If CBBet.SelectedItem Is Nothing Then
            MsgBox("Please select a bet first")
        Else
            If Integer.TryParse(TossBalance.Text, money) Then
                Dim selectedBet As Integer = CInt(CBBet.SelectedItem)
                If selectedBet > money Then
                    MsgBox("Insufficient amount, please top up")
                Else
                    pertick = 0
                    Timer1.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        coincount = random02.Next(0, 2)
        PBCom.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory, "tosscoin", "coin" & coincount & ".png"))

        pertick += 1

        If pertick < 20 Then

        Else
            Timer1.Enabled = False
            Dim userChoice As Integer = HTChoose.SelectedIndex

            If userChoice = coincount Then
                MsgBox("You Win")
                If Integer.TryParse(TossBalance.Text, money) Then
                    Select Case CBBet.SelectedIndex
                        Case 0
                            money += 100
                        Case 1
                            money += 200
                        Case 2
                            money += 300
                        Case 3
                            money += 400
                        Case 4
                            money += 500
                        Case 5
                            money += 600
                        Case 6
                            money += 700
                        Case 7
                            money += 800
                        Case 8
                            money += 900
                        Case 9
                            money += 1000
                    End Select
                    TossBalance.Text = money.ToString()
                    Jacken.JackBalance.Text = money.ToString()
                    Main.MainBalance.Text = money.ToString()
                End If
            Else
                MsgBox("You lose!")
                If Integer.TryParse(TossBalance.Text, money) Then
                    Select Case CBBet.SelectedIndex
                        Case 0
                            money -= 100
                        Case 1
                            money -= 200
                        Case 2
                            money -= 300
                        Case 3
                            money -= 400
                        Case 4
                            money -= 500
                        Case 5
                            money -= 600
                        Case 6
                            money -= 700
                        Case 7
                            money -= 800
                        Case 8
                            money -= 900
                        Case 9
                            money -= 1000
                    End Select
                    TossBalance.Text = money.ToString()
                    Jacken.JackBalance.Text = money.ToString()
                    Main.MainBalance.Text = money.ToString()

                End If
            End If
        End If
    End Sub
    Private Sub TossCoin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Main.Show()
        End If
    End Sub

End Class