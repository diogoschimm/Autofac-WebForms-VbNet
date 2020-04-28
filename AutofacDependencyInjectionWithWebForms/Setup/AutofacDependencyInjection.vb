Imports Autofac

Public Class AutofacDependencyInjection

    Public Shared Sub RegisterServices(builder As ContainerBuilder)

        builder.RegisterType(Of CompraService)().As(Of ICompraService)().InstancePerRequest()
        builder.RegisterType(Of PessoaService)().As(Of IPessoaService)().InstancePerRequest()

    End Sub

End Class
