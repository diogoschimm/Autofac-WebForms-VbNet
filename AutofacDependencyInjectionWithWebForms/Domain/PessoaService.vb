Public Class PessoaService
    Implements IPessoaService

    Private ReadOnly _compraService As ICompraService

    Public Sub New(compraService As ICompraService)
        Me._compraService = compraService
    End Sub

    Public Function ObterCompras(pessoa As Pessoa) As IList(Of Compra) Implements IPessoaService.ObterCompras
        Return _compraService.ObterCompras.Where(Function(c) c.IdPessoa.ToString() = pessoa.Id.ToString()).ToList()
    End Function

End Class
