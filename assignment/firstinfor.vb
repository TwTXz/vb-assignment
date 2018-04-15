Public Class firstinfor

    Public staffid As String = firstlogin.staffid
    Public phoneno As String
    Public address As String
    Public question As String
    Public ans As String
    Private validlist(3) As Integer


    Private Function isvalid() As Boolean
        Dim count As Integer = 0

        For a As Integer = 0 To validlist.Count() - 1
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

    Private Sub mskphone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskphone.Validating
        phoneno = mskphone.Text

        If Not mskphone.MaskCompleted Then
            err.SetError(mskphone, "Phone Number is required")
            e.Cancel = False
            validlist(0) = 1
        Else
            err.SetError(mskphone, Nothing)
            validlist(0) = 0
        End If

    End Sub

    Private Sub txtaddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtaddress.Validating
        address = txtaddress.Text

        If address = "" Then
            err.SetError(txtaddress, "Address is required")
            e.Cancel = False
            validlist(1) = 1
        Else
            err.SetError(txtaddress, Nothing)
            validlist(1) = 0
        End If
    End Sub

    Private Sub cbques_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbques.Validating

        If cbques.SelectedIndex = -1 Then
            err.SetError(cbques, "Please a question")
            e.Cancel = False
            validlist(2) = 1
        Else
            err.SetError(cbques, Nothing)
            validlist(2) = 0
            question = cbques.SelectedItem.ToString()
        End If

    End Sub

    Private Sub txtans_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtans.Validating
        ans = txtans.Text

        If ans = "" Then
            err.SetError(txtans, "Please enter an answer")
            e.Cancel = False
            validlist(3) = 1
        Else
            err.SetError(txtans, Nothing)
            validlist(3) = 0
        End If
    End Sub

    Private Sub btnnext2_Click(sender As Object, e As EventArgs) Handles btnnext2.Click
        Me.ValidateChildren()
        If isvalid() Then
            Return
        End If

        Dim db As New DbFlightDataContext()

        Try
            Dim updatecast = (From stf In db.Staffs
                              Where stf.StaffID.Equals(staffid)
                              Select stf).ToList()(0)
            updatecast.StaffPhoneNo = phoneno
            updatecast.StaffAddress = address
            updatecast.Question = question
            updatecast.Answer = ans
            db.SubmitChanges()
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
        End Try

        MessageBox.Show("Thanks for your cooperation")
        stafflogin.Show()
        Me.Close()

    End Sub

    Private Sub rad11_CheckedChanged(sender As Object, e As EventArgs) Handles rad11.CheckedChanged, rad10.CheckedChanged
        If (rad10.Checked) Then
            mskphone.Mask = "000-0000000"
            mskphone.Focus()
        ElseIf (rad11.Checked) Then
            mskphone.Mask = "000-00000000"
            mskphone.Focus()
        End If
    End Sub
End Class