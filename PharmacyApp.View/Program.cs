using Autofac;
using Autofac.Integration.Mvc;
using pharmacyApp.Application.Contract;
using pharmacyApp.Application.Services;
using System.Web.Mvc;

namespace PharmacyApp.View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the Autofac container
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacModule());
            var container = builder.Build();

            // Set up the DependencyResolver
            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
          // Application.Run(new Registration());
            //Application.Run(new Adminstraion());
            Application.Run(new Form1(container.Resolve<IApplicationUserService>()));
        }
    }
}