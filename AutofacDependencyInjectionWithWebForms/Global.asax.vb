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