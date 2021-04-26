using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.DAL.Entities
{
    public class RouteStop
    {
        public int Id { get; set; }
        public int  RouteId { get; set; }
        public int StopId { get; set; }
        public int StopNumberInRoute { get; set; }
        public int DistanceFromStart{ get; set; }
    }
}
