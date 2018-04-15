Public Class stafflogin

    Private username As String
    Private password As String
    Public dbuser As Staff
    Public staffid As String
    Private validlist(1) As Integer

    Private Function isvalid() As Boolean
        Dim count As Integer = 0

        For a As Integer = 0 To validlist.Count() - 1 Step 1
            If validlist(a) = 1 Then
                count += 1
            End If
        Next

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub txtusername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtusername.Validating
        username = txtusername.Text
        If username = "" Then
            err.SetError(txtusername, "Please enter User Name")
            e.Cancel = False
            validlist(0) = 1
        Else
            err.SetError(txtusername, Nothing)
            validlist(0) = 0
        End If

    End Sub

    Private Sub txtpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpass.Validating
        password = txtpass.Text
        If password = "" Then
            err.SetError(txtpass, "Please enter password")
            e.Cancel = False
            validlist(1) = 1
        Else
            err.SetError(txtpass, Nothing)
            validlist(1) = 0
        End If

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim db As New DbFlightDataContext()
        Me.ValidateChildren()
        If isvalid() Then
            Return
        End If

        dbuser = db.Staffs.FirstOrDefault(Function(o) o.StaffID = username _
                                                       And o.StaffPassword = password)

        If dbuser Is Nothing Then
            MessageBox.Show("Wrong user name or password", "error", MessageBoxButtons.OK)
        Else
            If dbuser.StaffPassword.Equals("passwordfOrchange") Then
                staffid = dbuser.StaffID

                firstlogin.Show()
                Me.Close()
            ElseIf dbuser.StaffType.Equals("ad") Then
                staffid = dbuser.StaffID
                Form1.Show()
                Me.Close()
            ElseIf dbuser.StaffType.Equals("staff") Then
                staffid = dbuser.StaffID
                staffpage.Show()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class