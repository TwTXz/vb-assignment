Public Class stafflogin

    Private username As String
    Private password As String

    Private Sub txtusername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtusername.Validating
        username = txtusername.Text
        If username = "" Then
            err.SetError(txtusername, "Please enter User Name")
            e.Cancel = False
        Else
            err.SetError(txtusername, Nothing)
        End If

    End Sub

    Private Sub txtpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpass.Validating
        password = txtpass.Text
        If password = "" Then
            err.SetError(txtpass, "Please enter password")
            e.Cancel = False
        Else
            err.SetError(txtpass, Nothing)
        End If

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim db As New DbFlightDataContext()
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim dbuser As Staff = db.Staffs.FirstOrDefault(Function(o) o.StaffName = username _
                                                       And o.StaffPassword = password)

        If dbuser Is Nothing Then
            MessageBox.Show("Wrong user name or password", "error", MessageBoxButtons.OK)
        End If

        If dbuser.StaffPassword.Equals("passwordfOrchange") Then
            firstlogin.Show()
            Me.Close()
        ElseIf dbuser.StaffType.Equals("ad") Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class