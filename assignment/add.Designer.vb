<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radfemale = New System.Windows.Forms.RadioButton()
        Me.radmale = New System.Windows.Forms.RadioButton()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.mskic = New System.Windows.Forms.MaskedTextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radfemale)
        Me.GroupBox1.Controls.Add(Me.radmale)
        Me.GroupBox1.Location = New System.Drawing.Point(309, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'radfemale
        '
        Me.radfemale.AutoSize = True
        Me.radfemale.Location = New System.Drawing.Point(60, 29)
        Me.radfemale.Name = "radfemale"
        Me.radfemale.Size = New System.Drawing.Size(59, 17)
        Me.radfemale.TabIndex = 1
        Me.radfemale.TabStop = True
        Me.radfemale.Text = "Female"
        Me.radfemale.UseVisualStyleBackColor = True
        '
        'radmale
        '
        Me.radmale.AutoSize = True
        Me.radmale.Location = New System.Drawing.Point(6, 29)
        Me.radmale.Name = "radmale"
        Me.radmale.Size = New System.Drawing.Size(48, 17)
        Me.radmale.TabIndex = 0
        Me.radmale.TabStop = True
        Me.radmale.Text = "Male"
        Me.radmale.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Location = New System.Drawing.Point(150, 157)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(75, 32)
        Me.btnconfirm.TabIndex = 2
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(249, 157)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 32)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "IC Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password :"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(91, 43)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(183, 20)
        Me.txtname.TabIndex = 7
        '
        'mskic
        '
        Me.mskic.Location = New System.Drawing.Point(91, 69)
        Me.mskic.Mask = "000000-00-0000"
        Me.mskic.Name = "mskic"
        Me.mskic.Size = New System.Drawing.Size(183, 20)
        Me.mskic.TabIndex = 8
        '
        'txtpass
        '
        Me.txtpass.Enabled = False
        Me.txtpass.Location = New System.Drawing.Point(91, 95)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(183, 20)
        Me.txtpass.TabIndex = 9
        Me.txtpass.Text = "passwordfOrchange"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Type :"
        '
        'cbtype
        '
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"Administative", "Staff"})
        Me.cbtype.Location = New System.Drawing.Point(91, 123)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(183, 21)
        Me.cbtype.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID :"
        '
        'lblid
        '
        Me.lblid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblid.Location = New System.Drawing.Point(91, 20)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(183, 19)
        Me.lblid.TabIndex = 13
        '
        'add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(463, 218)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbtype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.mskic)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnconfirm)
        Me.Name = "add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hiring Staff"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radfemale As RadioButton
    Friend WithEvents radmale As RadioButton
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents mskic As MaskedTextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbtype As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblid As Label
End Class
