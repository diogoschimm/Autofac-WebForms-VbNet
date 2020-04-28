# Autofac-WebForms-VbNet
Usando AutoFac para projetos Legados com Web.Forms no VB.NET

Comando no Package Manager Console  

```
Install-Package Autofac.Web  
```

## Alteração no Arquivo Web.Config

```xml
<system.webServer>
  <modules>
    <add
      name="ContainerDisposal"
      type="Autofac.Integration.Web.ContainerDisposalModule, Autofac.Integration.Web"
      preCondition="managedHandler"/>
    <add
      name="PropertyInjection"
      type="Autofac.Integration.Web.Forms.PropertyInjectionModule, Autofac.Integration.Web"
      preCondition="managedHandler"/>
  </modules>
</system.webServer>
```

## Alteração no arquivo Global.asax.vb

No arquivo Global.asax criamos um variavel static para Container  

```vb
Imports Autofac
Imports Autofac.Integration.Web

Public Class Global_asax
    Inherits HttpApplication
    Implements IContainerProviderAccessor

    Shared _containerProvider As IContainerProvider

    Public ReadOnly Property ContainerProvider As IContainerProvider Implements IContainerProviderAccessor.ContainerProvider
        Get
            Return _containerProvider
        End Get
    End Property

    Sub Application_Start(sender As Object, e As EventArgs)

        Dim builder As New ContainerBuilder()
        AutofacDependencyInjection.RegisterServices(builder)
        _containerProvider = New ContainerProvider(builder.Build())

    End Sub

End Class
```

## Arquivo AutofacDependencyInjection

Onde faremos a resolução das dependências  

```vb
Imports Autofac

Public Class AutofacDependencyInjection

    Public Shared Sub RegisterServices(builder As ContainerBuilder)

        builder.RegisterType(Of CompraService)().As(Of ICompraService)().InstancePerRequest()
        builder.RegisterType(Of PessoaService)().As(Of IPessoaService)().InstancePerRequest()

    End Sub

End Class
```

## Arquivo Default.aspx.vb

Usamos o property injection para o serviço de pessoa  

```vb
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
```

### Exemplo do arquivo de serviço de pessoa

```vb
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
```
