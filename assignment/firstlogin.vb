Public Class firstlogin
    Public newpass As String
    Public staffid As String = stafflogin.staffid
    Private validlist(1) As Integer

    Private Function isvalid() As Boolean
        Dim count As Integer = 0

        For a As Integer = 0 To 1
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

    Private Sub firstlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = stafflogin.dbuser.StaffName

        lblwel.Text = "Welcome to your first login, " & username & "!!"

    End Sub

    Private Sub txtnewpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnewpass.Validating
        newpass = txtnewpass.Text
        Dim haveupper As Integer = 0
        Dim havenum As Integer = 0

        For a As Integer = 0 To newpass.Length() - 1 Step 1
            If (Char.IsUpper(newpass.Chars(a))) Then
                haveupper += 1
            End If

            If (Char.IsDigit(newpass.Chars(a))) Then
                havenum += 1
            End If
        Next

        If (haveupper = 0 Or havenum = 0) Then
            err.SetError(txtnewpass, "Password must have 1 uppercase and 1 numeric")
            e.Cancel = False
            validlist(0) = 1
        Else
            err.SetError(txtnewpass, Nothing)
            validlist(0) = 0
        End If

    End Sub

    Private Sub txtconpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtconpass.Validating
        Dim conpass As String = txtconpass.Text
        Dim haveupper As Integer = 0
        Dim havenum As Integer = 0

        For a As Integer = 0 To conpass.Length() - 1 Step 1
            If (Char.IsUpper(conpass.Chars(a))) Then
                haveupper += 1
            End If

            If (Char.IsDigit(conpass.Chars(a))) Then
                havenum += 1
            End If
        Next

        If (haveupper = 0 Or havenum = 0) Then
            err.SetError(txtconpass, "Password must have 1 uppercase and 1 numeric.")
            e.Cancel = False
            validlist(1) = 1
        ElseIf (conpass <> newpass) Then
            err.SetError(txtconpass, "Password must same as above.")
            e.Cancel = False
            validlist(1) = 1
        Else
            err.SetError(txtconpass, Nothing)
            validlist(1) = 0
        End If
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.ValidateChildren()
        If isvalid() Then
            Return
        End If

        Dim db As New DbFlightDataContext()

        Try
            Dim updatecast = (From stf In db.Staffs
                              Where stf.StaffID.Equals(staffid)
                              Select stf).ToList()(0)
            updatecast.StaffPassword = newpass
            db.SubmitChanges()
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
        End Try

        Refresh()
        firstinfor.Show()
        Me.Close()

    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        txtnewpass.PasswordChar = ""
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        txtnewpass.PasswordChar = "*"
    End Sub


End Class