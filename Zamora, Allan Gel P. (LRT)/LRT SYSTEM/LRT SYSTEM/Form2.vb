Public Class Form2
    Public Property CurrentTicket As Integer


    Public Sub SetValues(origin As String, destination As String, gross As String, discount As String, net As String)
        fromvb2.Text = origin
        tovb2.Text = destination
        grossvb2.Text = gross
        discountvb2.Text = discount
        netvb2.Text = net
    End Sub

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click

        CurrentTicket += 1
        Dim form1 As New Form1()
        form1.ResetForm1()
        form1.SetTicket(CurrentTicket)
        form1.Show()
        Me.Close()
    End Sub
End Class