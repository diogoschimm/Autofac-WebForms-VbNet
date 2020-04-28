Public Class Compra

    Public Sub New(idCompra As Guid, dataCompra As Date, valorTotal As Decimal, idPessoa As Guid)
        Me.IdCompra = idCompra
        Me.DataCompra = dataCompra
        Me.ValorTotal = valorTotal
        Me.IdPessoa = idPessoa
    End Sub

    Public Sub New()

    End Sub

    Public Property IdCompra As Guid
    Public Property DataCompra As DateTime
    Public Property ValorTotal As Decimal
    Public Property IdPessoa As Guid

End Class
