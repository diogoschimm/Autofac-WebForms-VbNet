Public Class CompraService
    Implements ICompraService

    Public Function ObterCompras() As IList(Of Compra) Implements ICompraService.ObterCompras

        Dim idPessoa1 As New Guid("9569B3DC-416F-4CAB-848E-18FC835F1814")
        Dim idPessoa2 As New Guid("DE2A6192-D4C5-4211-8D25-E4B57E0B5124")

        Dim lista As New List(Of Compra) From {
            New Compra(Guid.NewGuid, Now, 100, idPessoa1),
            New Compra(Guid.NewGuid, Now, 50, idPessoa1),
            New Compra(Guid.NewGuid, Now, 89.99, idPessoa1),
            New Compra(Guid.NewGuid, Now, 299.99, idPessoa1),
            New Compra(Guid.NewGuid, Now, 350, idPessoa2),
            New Compra(Guid.NewGuid, Now, 450.99, idPessoa2)
        }

        Return lista
    End Function

End Class
