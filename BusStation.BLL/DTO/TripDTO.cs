using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.BLL.DTO
{
    public class TripDTO
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int BusId { get; set; }
        public DateTime Date { get; set; }
        public RouteDTO Route { get; set; }
        public BusDTO Bus { get; set; }
    }
}
