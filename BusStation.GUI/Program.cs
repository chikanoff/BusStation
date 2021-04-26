using BusStation.BLL.DI;
using Microsoft.Extensions.Configuration;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation.GUI
{
    static class Program
    {
        private static IKernel _container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureContainer();
            var form = _container.Get<MainForm>();
            Application.Run(form);
        }

        private static void ConfigureContainer()
        {
            //BLL dependencies
            NinjectModule serviceModule = new ServiceModule(GetConnectionString());
            NinjectModule busModule = new BusServiceModule();
            NinjectModule routeModule = new RouteServiceModule();
            NinjectModule routeStopModule = new RouteStopServiceModule();
            NinjectModule stopModule = new StopServiceModule();
            NinjectModule ticketModule = new TicketServiceModule();
            NinjectModule tripModule = new TripServiceModule();
            NinjectModule userModule = new UserServiceModule();
            NinjectModule userTicketModule = new UserTicketServiceModule();
            NinjectModule busCategoryModule = new BusCategoryServiceModule();

            _container = new StandardKernel(serviceModule, busModule, routeModule, routeStopModule,
                stopModule, ticketModule, tripModule, userModule, userTicketModule, busCategoryModule);
        }

        private static string GetConnectionString()
        {
            var curDir = Directory.GetCurrentDirectory();
            var config = new ConfigurationBuilder().AddJsonFile($"{curDir}\\config.json").Build();
            string connection = config["ConnectionStrings:BusStationDbConnection"];

            return connection;
        }
    }
}
