<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffpage
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
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(74, 71)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(134, 23)
        Me.btnupdate.TabIndex = 0
        Me.btnupdate.Text = "Update Profile"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(75, 119)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(134, 23)
        Me.btnlogout.TabIndex = 1
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'staffpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnupdate)
        Me.Name = "staffpage"
        Me.Text = "staffpage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnupdate As Button
    Friend WithEvents btnlogout As Button
End Class
