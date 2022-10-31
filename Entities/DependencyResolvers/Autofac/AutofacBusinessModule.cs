using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Business.DependencyResolvers.Autofac;
public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var proxyOptions = new ProxyGenerationOptions
        {
            Selector = new AspectInterceptorSelector()
        };

        builder.RegisterType<UserManager>()
            .As<IUserService>()
            .EnableInterfaceInterceptors(proxyOptions)
            .SingleInstance();
    }
}

