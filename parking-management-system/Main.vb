Public Class Main

    Sub switchpanel(panel As Form)
        Panel5.Controls.Clear()
        panel.TopLevel = False
        Panel5.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles accbtn.Click
        switchpanel(Accounts)
    End Sub

    Private Sub opbtn_Click(sender As Object, e As EventArgs) Handles opbtn.Click
        switchpanel(Operations)
    End Sub

    Private Sub secbtn_Click(sender As Object, e As EventArgs) Handles secbtn.Click
        switchpanel(Security)
    End Sub

    Private Sub repbtn_Click(sender As Object, e As EventArgs) Handles repbtn.Click
        switchpanel(Reports)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class