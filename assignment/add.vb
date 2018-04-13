Imports System.Text
Public Class add
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        Dim db As New DbFlightDataContext()
        Dim username, password, ic, gender As String

        username = txtname.Text
        password = txtpass.Text
        ic = mskic.Text

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
        Dim newid As String = code & num

        Try
            Dim insert As New Staff With {.StaffID = newid}
            db.Staffs.InsertOnSubmit(insert)
            db.SubmitChanges()
        Catch ex As Exception
            Console.Write(ex.ToString())
        End Try


        Console.Write(newid)

    End Sub
End Class