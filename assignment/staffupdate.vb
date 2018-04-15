Public Class staffupdate
    Public staffid As String = staffpage.staffid
    Private Sub staffupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DbFlightDataContext()

        Dim dbuser = db.Staffs.FirstOrDefault(Function(o) o.StaffID = staffid)

        txtname.Text = dbuser.StaffName
        mskphone.Text = dbuser.StaffPhoneNo
        mskic.Text = dbuser.StaffICNo
        txtaddress.Text = dbuser.StaffAddress
        lblid.Text = dbuser.StaffID
        txtpassword.Text = dbuser.StaffPassword
        cbques.SelectedItem = dbuser.Question
        txtans.Text = dbuser.Answer
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim db As New DbFlightDataContext()

        Dim dbuser = db.Staffs.FirstOrDefault(Function(o) o.StaffID = staffid)

        dbuser.StaffName = txtname.Text
        dbuser.StaffPhoneNo = mskphone.Text
        dbuser.StaffICNo = mskic.Text
        dbuser.StaffAddress = txtaddress.Text
        dbuser.StaffPassword = txtpassword.Text
        dbuser.Question = cbques.SelectedItem
        dbuser.Answer = txtans.Text

        Try
            db.SubmitChanges()
            MessageBox.Show("Update Successfully.")
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
        End Try
    End Sub
End Class