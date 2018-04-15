Public Class delete

    Private Sub bind()
        Dim db As New DbFlightDataContext()
        Dim rs = (From stf In db.Staffs
                  Where stf.status = "active"
                  Select stf.StaffID, stf.StaffName, stf.StaffType)

        grdstaff.DataSource = rs
    End Sub

    Private Sub delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim name As String = txtsearch.Text
        Dim db As New DbFlightDataContext()
        Dim rs = (From stf In db.Staffs
                  Where stf.status = "active" _
                  And stf.StaffName.Contains(name)
                  Select stf.StaffID, stf.StaffName, stf.StaffType)

        grdstaff.DataSource = rs
    End Sub

    Private Sub grdstaff_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdstaff.CellDoubleClick
        Dim i As Integer = e.RowIndex
        Dim db As New DbFlightDataContext()
        If (i > -1) Then
            Dim decision As Integer = MessageBox.Show("do you want fire this staff??", "Warning", MessageBoxButtons.YesNo)

            If decision = DialogResult.Yes Then
                Dim id As String = CStr(grdstaff.Rows(i).Cells(0).Value)

                Dim update = db.Staffs.FirstOrDefault(Function(o) o.StaffID = id)

                update.status = "deactive"

                Try
                    db.SubmitChanges()
                Catch ex As Exception
                    Console.WriteLine(ex.Message, ToString())
                End Try
                bind()
            End If
        End If

    End Sub
End Class