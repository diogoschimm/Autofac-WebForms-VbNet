Public Class Pessoa

    Public Sub New(id As Guid, nome As String)
        Me.Id = id
        Me.Nome = nome
    End Sub

    Public Sub New()

    End Sub

    Public Property Id As Guid
    Public Property Nome As String

End Class
