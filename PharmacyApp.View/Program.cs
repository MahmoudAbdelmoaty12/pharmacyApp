using pharmacyApp.Application.Contract;
using pharmacyApp.Application.Services;
using PharmacyApp.Context.Context;
using PharmacyApp.Infrastructure.Repositories;

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
            
            ApplicationConfiguration.Initialize();
            //  Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);

            //  // Build the Autofac container
            //  var builder = new ContainerBuilder();
            //  builder.RegisterModule(new AutofacModule());
            //  var container = builder.Build();

            //  // Set up the DependencyResolver
            //  var resolver = new AutofacDependencyResolver(container);
            //  DependencyResolver.SetResolver(resolver);
            //  // To customize application configuration such as set high DPI settings or default font,
            //  // see https://aka.ms/applicationconfiguration.
            //  ApplicationConfiguration.Initialize();
            //// Application.Run(new Registration());
            //Application.Run(new Adminstraion(new ApplicationUserService(new ApplicationUserRepository(new AppDbContext()))));
            //  Application.Run(new Form1(container.Resolve<IApplicationUserService>()));
            //Application.Run(new Form1(new ApplicationUserService(new ApplicationUserRepository(new AppDbContext()))));
            //Application.Run( new UI_AddMedicine(new MedicineService(new MedicineRepository(new AppDbContext()))));
            //Application.Run(new MedicineForm());
           Application.Run(new Registration(new ApplicationUserService(new ApplicationUserRepository(new AppDbContext()))));

            //Application.Run(new Pharmacy());
        }
    }
}