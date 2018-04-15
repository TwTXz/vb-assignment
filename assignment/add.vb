Imports System.Text
Public Class add
    Dim newid As String
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        Dim db As New DbFlightDataContext()
        Dim username, password, ic, gender, type As String

        username = txtname.Text
        password = txtpass.Text
        ic = mskic.Text

        If (cbtype.SelectedIndex = 0) Then
            type = "ad"
        Else
            type = "staff"
        End If

        If radmale.Checked Then
            gender = radmale.Text
        Else
            gender = radfemale.Text
        End If

        Dim getlastid = (From tab_s In db.Staffs
                         Select tab_s.StaffID).Max()

        Dim code As String = Mid(getlastid, 1, 1)
        Dim num As String = Mid(getlastid, 2, 4)
        num = (Integer.Parse(num) + 1).ToString("0000")
        Dim newid = code & num

        Try
            Dim insert As New Staff With {.StaffID = newid, .StaffName = username,
                                          .StaffICNo = ic,
                                          .StaffPassword = password,
                                          .StaffGender = gender,
                                          .StaffType = type,
                                          .status = "active"}
            db.Staffs.InsertOnSubmit(insert)
            db.SubmitChanges()
            MessageBox.Show("New staff is created")
        Catch ex As Exception
            Console.Write(ex.Message.ToString())
        End Try

    End Sub

    Private Sub add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
        cbtype.SelectedIndex = 0
        Dim db As New DbFlightDataContext()
        Dim getlastid = (From tab_s In db.Staffs
                         Select tab_s.StaffID).Max()

        Dim code As String = Mid(getlastid, 1, 1)
        Dim num As String = Mid(getlastid, 2, 4)
        num = (Integer.Parse(num) + 1).ToString("0000")
        Dim newid = code & num

        lblid.Text = newid
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtname.Text = ""
        mskic.Text = ""
        radmale.Checked = True
        txtname.Focus()
    End Sub
End Class