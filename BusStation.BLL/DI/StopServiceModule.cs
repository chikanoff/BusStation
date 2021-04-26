using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.BLL.Interfaces.EntityServices;
using BusStation.BLL.Services;
using Ninject.Modules;

namespace BusStation.BLL.DI
{
    public class StopServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStopService>()
                .To<StopService>();
        }
    }
}
