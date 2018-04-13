Public Class report
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DbFlightDataContext

        If tabcat.SelectedIndex = 0 Then
            Dim data = From s In db.Staffs Select s

            datatest.DataSource = data
        End If
    End Sub

    Private Sub tabcat_TabIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class