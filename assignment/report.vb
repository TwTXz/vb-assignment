Public Class report


    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DbFlightDataContext()
        Dim rs = (From stf In db.Staffs
                  Where stf.StaffGender = "Male")

        grdreport.DataSource = rs
        lbldate.Text = DateTime.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged, radFemale.CheckedChanged
        If (radmale.Checked) Then

            Dim db As New DbFlightDataContext()
            Dim rs = (From stf In db.Staffs
                      Where stf.StaffGender = "Male")

            grdreport.DataSource = rs
        Else
            Dim db As New DbFlightDataContext()
            Dim rs = (From stf In db.Staffs
                      Where stf.StaffGender = "Female")

            grdreport.DataSource = rs
        End If
    End Sub
End Class