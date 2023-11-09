Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Jacken
    Dim ran As New Random
    Dim money As Integer
    Private Sub ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ControlPanel.BackColor = Color.FromArgb(100, 0, 0, 0)

        PBMoney.Image = My.Resources.bag
        PBLogo.Image = My.Resources.logo

        PBRock.Image = My.Resources.rock
        PBPaper.Image = My.Resources.paper
        PBScissors.Image = My.Resources.scissors
    End Sub

    Private Sub PBRock_Click(sender As Object, e As EventArgs) Handles PBRock.Click
        PBYou.Image = My.Resources.rock
        PBYou.Tag = 0

        Dim userChoice As Integer = CInt(PBYou.Tag)
        Dim pbenemyValue As Integer = ran.Next(0, 3)
        Dim choices As String() = {"Rock", "Scissors", "Paper"}

        PBCom.Image = Image.FromFile(Directory.GetCurrentDirectory & "\handr\handr" & pbenemyValue & ".png")

        If Not HasSufficientFunds() Then
            MsgBox("Insufficient funds. Please top up.")
            Exit Sub
        End If

        If userChoice = pbenemyValue Then
            MsgBox("It's a tie!")
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        ElseIf (userChoice = 0 And pbenemyValue = 1) Or
              (userChoice = 1 And pbenemyValue = 2) Or
              (userChoice = 2 And pbenemyValue = 0) Then
            MsgBox("You win!")

            If Integer.TryParse(JackBalance.Text, money) Then
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
                JackBalance.Text = money.ToString()
                Main.MainBalance.Text = money.ToString()
                TossCoin.TossBalance.Text = money.ToString()
            End If
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        Else
            MsgBox("You lose!")
            If Integer.TryParse(JackBalance.Text, money) Then
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
                JackBalance.Text = money.ToString()
                Main.MainBalance.Text = money.ToString()
                TossCoin.TossBalance.Text = money.ToString()
            End If
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        End If
    End Sub

    Private Sub PBPaper_Click(sender As Object, e As EventArgs) Handles PBPaper.Click
        PBYou.Image = My.Resources.paper
        PBYou.Tag = 2

        Dim userChoice As Integer = CInt(PBYou.Tag)
        Dim pbenemyValue As Integer = ran.Next(0, 3)
        Dim choices As String() = {"Rock", "Scissors", "Paper"}

        PBCom.Image = Image.FromFile(Directory.GetCurrentDirectory & "\handr\handr" & pbenemyValue & ".png")
        If Not HasSufficientFunds() Then
            MsgBox("Insufficient funds. Please top up.")
            Exit Sub
        End If

        If userChoice = pbenemyValue Then
            MsgBox("It's a tie!")
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        ElseIf (userChoice = 0 And pbenemyValue = 1) Or
              (userChoice = 1 And pbenemyValue = 2) Or
              (userChoice = 2 And pbenemyValue = 0) Then
            MsgBox("You win!")

            If Integer.TryParse(JackBalance.Text, money) Then
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
                JackBalance.Text = money.ToString()
                Main.MainBalance.Text = money.ToString()
                TossCoin.TossBalance.Text = money.ToString()
            End If
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        Else
            MsgBox("You lose!")
            If Integer.TryParse(JackBalance.Text, money) Then
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
                JackBalance.Text = money.ToString()
                Main.MainBalance.Text = money.ToString()
                TossCoin.TossBalance.Text = money.ToString()
            End If
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        End If
    End Sub

    Private Sub PBScissors_Click(sender As Object, e As EventArgs) Handles PBScissors.Click
        PBYou.Image = My.Resources.scissors
        PBYou.Tag = 1

        Dim userChoice As Integer = CInt(PBYou.Tag)
        Dim pbenemyValue As Integer = ran.Next(0, 3)
        Dim choices As String() = {"Rock", "Scissors", "Paper"}

        PBCom.Image = Image.FromFile(Directory.GetCurrentDirectory & "\handr\handr" & pbenemyValue & ".png")
        If Not HasSufficientFunds() Then
            MsgBox("Insufficient funds. Please top up.")
            Exit Sub
        End If

        If userChoice = pbenemyValue Then
            MsgBox("It's a tie!")
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        ElseIf (userChoice = 0 And pbenemyValue = 1) Or
              (userChoice = 1 And pbenemyValue = 2) Or
              (userChoice = 2 And pbenemyValue = 0) Then
            MsgBox("You win!")

            If Integer.TryParse(JackBalance.Text, money) Then
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
                JackBalance.Text = money.ToString()
                Main.MainBalance.Text = money.ToString()
                TossCoin.TossBalance.Text = money.ToString()
            End If
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        Else
            MsgBox("You lose!")
            If Integer.TryParse(JackBalance.Text, money) Then
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
                JackBalance.Text = money.ToString()
                Main.MainBalance.Text = money.ToString()
                TossCoin.TossBalance.Text = money.ToString()
            End If
            PBYou.Image = Nothing
            PBCom.Image = Nothing
        End If
    End Sub

    Private Function HasSufficientFunds() As Boolean
        Dim betAmount As Integer

        If Integer.TryParse(JackBalance.Text, money) AndAlso Integer.TryParse(CBBet.SelectedItem.ToString(), betAmount) Then
            If money < betAmount Then
                Return False
            End If
        Else
            MsgBox("Invalid balance or bet amount.")
            Return False
        End If

        Return True
    End Function

    Private Sub Jacken_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Main.Show()
        End If
    End Sub

End Class