Public Class Form1

    Dim ticket As Integer = 0

    Private Sub FMProcess_Click(sender As Object, e As EventArgs) Handles FMProcess.Click
        Dim firstname As String = firstTxt.Text
        Dim lastname As String = lastTxt.Text

        If String.IsNullOrEmpty(firstname) OrElse String.IsNullOrEmpty(lastname) OrElse cbFrom.SelectedIndex = -1 OrElse cbTo.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim selectedIndex As Integer = cbFrom.SelectedIndex
            Dim selectedInex2 As Integer = cbTo.SelectedIndex
            Dim discount As Integer = cbDiscount.SelectedIndex
            Dim discounted As Double

            If selectedIndex = selectedInex2 Then
                MessageBox.Show("Don't use the same Place", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim res As Integer = Math.Abs(selectedIndex - selectedInex2) * 20

            If discount = 1 Then
                discounted = res * 0.1
            ElseIf discount = 2 Then
                discounted = res * 0.15
            ElseIf discount = 3 Then
                discounted = res * 0.2
            ElseIf discount = 4 Then
                discounted = res * 0.5
            End If

            Dim form2 As New Form2()

            form2.CurrentTicket = ticket
            ticket += 1
            form2.Namef2.Text = lastname + ", " + firstname
            form2.fromvb2.Text = cbFrom.SelectedItem.ToString()
            form2.tovb2.Text = cbTo.SelectedItem.ToString()
            form2.grossvb2.Text = res.ToString("0.00")
            form2.discountvb2.Text = discounted.ToString("0.00")
            form2.netvb2.Text = (res - discounted).ToString("0.00")

            form2.ticketvb2.Text = ticket.ToString("0000")

            Me.Hide()

            form2.Show()
        End If
    End Sub


    Public Sub SetTicket(newTicket As Integer)
        ticket = newTicket
    End Sub
    Public Sub ResetForm1()
        firstTxt.Text = String.Empty
        lastTxt.Text = String.Empty
        cbFrom.SelectedIndex = -1
        cbTo.SelectedIndex = -1
        cbDiscount.SelectedIndex = -1

    End Sub
End Class
