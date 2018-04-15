<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firstinfor
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
        Me.components = New System.ComponentModel.Container()
        Me.btnnext2 = New System.Windows.Forms.Button()
        Me.txtans = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbques = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.mskphone = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rad10 = New System.Windows.Forms.RadioButton()
        Me.rad11 = New System.Windows.Forms.RadioButton()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnext2
        '
        Me.btnnext2.Location = New System.Drawing.Point(167, 257)
        Me.btnnext2.Name = "btnnext2"
        Me.btnnext2.Size = New System.Drawing.Size(75, 23)
        Me.btnnext2.TabIndex = 19
        Me.btnnext2.Text = "Next"
        Me.btnnext2.UseVisualStyleBackColor = True
        '
        'txtans
        '
        Me.txtans.Location = New System.Drawing.Point(107, 230)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(252, 20)
        Me.txtans.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Answer :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Question :"
        '
        'cbques
        '
        Me.cbques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbques.FormattingEnabled = True
        Me.cbques.Items.AddRange(New Object() {"What is the name of your favourite pet?", "Who is your favourite actor, singer, or artist?", "What is the name of your bestfriend?", "Which city were you born?", "What is your favourite color and number?", "What is your favourite movie?"})
        Me.cbques.Location = New System.Drawing.Point(107, 201)
        Me.cbques.Name = "cbques"
        Me.cbques.Size = New System.Drawing.Size(252, 21)
        Me.cbques.TabIndex = 15
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(107, 120)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(252, 64)
        Me.txtaddress.TabIndex = 14
        '
        'mskphone
        '
        Me.mskphone.Location = New System.Drawing.Point(107, 60)
        Me.mskphone.Mask = "000-0000000"
        Me.mskphone.Name = "mskphone"
        Me.mskphone.Size = New System.Drawing.Size(252, 20)
        Me.mskphone.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Phone No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Plese complete the following information"
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'rad10
        '
        Me.rad10.AutoSize = True
        Me.rad10.Checked = True
        Me.rad10.Location = New System.Drawing.Point(107, 87)
        Me.rad10.Name = "rad10"
        Me.rad10.Size = New System.Drawing.Size(60, 17)
        Me.rad10.TabIndex = 20
        Me.rad10.TabStop = True
        Me.rad10.Text = "10 num"
        Me.rad10.UseVisualStyleBackColor = True
        '
        'rad11
        '
        Me.rad11.AutoSize = True
        Me.rad11.Location = New System.Drawing.Point(173, 86)
        Me.rad11.Name = "rad11"
        Me.rad11.Size = New System.Drawing.Size(60, 17)
        Me.rad11.TabIndex = 21
        Me.rad11.Text = "11 num"
        Me.rad11.UseVisualStyleBackColor = True
        '
        'firstinfor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 308)
        Me.Controls.Add(Me.rad11)
        Me.Controls.Add(Me.rad10)
        Me.Controls.Add(Me.btnnext2)
        Me.Controls.Add(Me.txtans)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbques)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.mskphone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "firstinfor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "firstinfor"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnext2 As Button
    Friend WithEvents txtans As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbques As ComboBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents mskphone As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents rad11 As RadioButton
    Friend WithEvents rad10 As RadioButton
End Class
