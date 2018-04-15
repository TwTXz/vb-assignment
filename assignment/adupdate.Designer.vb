<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adupdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtans = New System.Windows.Forms.TextBox()
        Me.cbques = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad11 = New System.Windows.Forms.RadioButton()
        Me.rad10 = New System.Windows.Forms.RadioButton()
        Me.mskphone = New System.Windows.Forms.MaskedTextBox()
        Me.mskic = New System.Windows.Forms.MaskedTextBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtans)
        Me.GroupBox2.Controls.Add(Me.cbques)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 147)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Information"
        '
        'lblid
        '
        Me.lblid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblid.Location = New System.Drawing.Point(101, 24)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(112, 20)
        Me.lblid.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Security Question :"
        '
        'txtans
        '
        Me.txtans.Location = New System.Drawing.Point(101, 101)
        Me.txtans.MaxLength = 30
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(232, 20)
        Me.txtans.TabIndex = 10
        '
        'cbques
        '
        Me.cbques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbques.FormattingEnabled = True
        Me.cbques.Items.AddRange(New Object() {"What is the name of your favourite pet?", "Who is your favourite actor, singer, or artist?", "What is the name of your bestfriend?", "Which city were you born?", "What is your favourite color and number?", "What is your favourite movie?"})
        Me.cbques.Location = New System.Drawing.Point(101, 75)
        Me.cbques.Name = "cbques"
        Me.cbques.Size = New System.Drawing.Size(232, 21)
        Me.cbques.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Answer :"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(101, 47)
        Me.txtpassword.MaxLength = 20
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(112, 20)
        Me.txtpassword.TabIndex = 7
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Password :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad11)
        Me.GroupBox1.Controls.Add(Me.rad10)
        Me.GroupBox1.Controls.Add(Me.mskphone)
        Me.GroupBox1.Controls.Add(Me.mskic)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 205)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'rad11
        '
        Me.rad11.AutoSize = True
        Me.rad11.Location = New System.Drawing.Point(142, 73)
        Me.rad11.Name = "rad11"
        Me.rad11.Size = New System.Drawing.Size(60, 17)
        Me.rad11.TabIndex = 23
        Me.rad11.Text = "11 num"
        Me.rad11.UseVisualStyleBackColor = True
        '
        'rad10
        '
        Me.rad10.AutoSize = True
        Me.rad10.Checked = True
        Me.rad10.Location = New System.Drawing.Point(76, 73)
        Me.rad10.Name = "rad10"
        Me.rad10.Size = New System.Drawing.Size(60, 17)
        Me.rad10.TabIndex = 22
        Me.rad10.TabStop = True
        Me.rad10.Text = "10 num"
        Me.rad10.UseVisualStyleBackColor = True
        '
        'mskphone
        '
        Me.mskphone.Location = New System.Drawing.Point(76, 47)
        Me.mskphone.Mask = "000-00000009"
        Me.mskphone.Name = "mskphone"
        Me.mskphone.Size = New System.Drawing.Size(94, 20)
        Me.mskphone.TabIndex = 4
        '
        'mskic
        '
        Me.mskic.Location = New System.Drawing.Point(76, 99)
        Me.mskic.Mask = "000000-00-0000"
        Me.mskic.Name = "mskic"
        Me.mskic.Size = New System.Drawing.Size(94, 20)
        Me.mskic.TabIndex = 5
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(76, 122)
        Me.txtaddress.MaxLength = 100
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(174, 62)
        Me.txtaddress.TabIndex = 6
        Me.txtaddress.Text = ""
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(76, 20)
        Me.txtname.MaxLength = 50
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(174, 20)
        Me.txtname.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "IC No. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Phone No. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Address :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Name :"
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(446, 215)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 32
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'adupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 262)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adupdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblid As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtans As TextBox
    Friend WithEvents cbques As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mskphone As MaskedTextBox
    Friend WithEvents mskic As MaskedTextBox
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents rad11 As RadioButton
    Friend WithEvents rad10 As RadioButton
End Class
