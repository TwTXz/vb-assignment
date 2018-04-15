Public Class Form1
    Public staffid As String = stafflogin.staffid

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        add.ShowDialog()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        delete.ShowDialog()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        report.ShowDialog()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        adupdate.ShowDialog()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click

        stafflogin.Show()
        Me.Close()
    End Sub
End Class
