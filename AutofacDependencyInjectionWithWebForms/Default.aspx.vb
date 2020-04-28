Public Class _Default
    Inherits System.Web.UI.Page

    Public Property _pessoaService As IPessoaService

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_dados_Click(sender As Object, e As EventArgs) Handles btn_dados.Click

        Dim pessoa As New Pessoa(New Guid("9569B3DC-416F-4CAB-848E-18FC835F1814"), "Diogoschimm")

        Me.gv_dados.DataSource = _pessoaService.ObterCompras(pessoa)
        Me.gv_dados.DataBind()

    End Sub

End Class