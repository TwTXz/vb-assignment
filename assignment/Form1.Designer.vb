<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(120, 55)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(110, 23)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add New Staff"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(120, 138)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 23)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "Fire Staff"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(120, 177)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(110, 23)
        Me.btnreport.TabIndex = 2
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(120, 98)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 23)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "Update Profile"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(120, 219)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(110, 23)
        Me.btnlogout.TabIndex = 4
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 277)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Management"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnlogout As Button
End Class
