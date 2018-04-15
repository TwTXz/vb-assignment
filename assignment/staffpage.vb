Public Class staffpage
    Public staffid As String = stafflogin.staffid

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        stafflogin.Show()
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        staffupdate.Show()
    End Sub
End Class