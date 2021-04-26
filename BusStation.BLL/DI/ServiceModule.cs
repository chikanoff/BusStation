using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.DAL.Interfaces;
using BusStation.DAL.UnitsOfWork;
using Ninject.Modules;

namespace BusStation.BLL.DI
{
    public class ServiceModule : NinjectModule
    {
        private string _connectionString;

        public ServiceModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>()
                .To<BusStationDbUnitOfWork>()
                .WithConstructorArgument(_connectionString);
        }
    }
}
