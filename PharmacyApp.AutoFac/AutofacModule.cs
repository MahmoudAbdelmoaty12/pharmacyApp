using Autofac;
using pharmacyApp.Application.Contract;
using pharmacyApp.Application.Services;
using PharmacyApp.Context.Context;
using PharmacyApp.Infrastructure.Repositories;

public class AutofacModule : Autofac.Module
{
    public static IContainer ConfigureContainer()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<ApplicationUserService>().As<IApplicationUserService>();
        builder.RegisterType<ApplicationUserRepository>().As<IApplicationUser>();
        // Add other service and repository registrations as needed

        // Register your DbContext
        builder.RegisterType<AppDbContext>().AsSelf().InstancePerLifetimeScope();
        return builder.Build();
    }
}