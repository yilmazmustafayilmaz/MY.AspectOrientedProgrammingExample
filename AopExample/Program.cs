using Autofac;
using Business.Abstract;
using Business.DependencyResolvers.Autofac;

var builder = new ContainerBuilder();
builder.RegisterModule(new AutofacBusinessModule());

var container = builder.Build();

var willBeIntercepted = container.Resolve<IUserService>();
willBeIntercepted.Add();

Console.ReadKey();

