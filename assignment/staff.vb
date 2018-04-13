Public Class clstaff
    Public Property id As String
    Public Property name As String
    Public Property ic As String
    Public Property phone As String
    Public Property address As String
    Public Property email As String
    Public Property state As String
    Public Property city As String
    Public Property gender As String
    Public Property ques As String
    Public Property ans As String
    Public Property password As String

    Public Sub New()

    End Sub

    Public Sub New(id As String, name As String, ic As String, phone As String,
                   address As String, email As String, state As String, city As String,
                   gender As String, ques As String, ans As String, password As String)
        Me.id = id
        Me.name = name
        Me.ic = ic
        Me.phone = phone
        Me.address = address
        Me.email = email
        Me.state = state
        Me.city = city
        Me.gender = gender
        Me.ques = ques
        Me.ans = ans
        Me.password = password
    End Sub

    Public Sub New(id As String, name As String)
        Me.id = id
        Me.name = name

    End Sub

End Class
