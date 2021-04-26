using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.BLL.DTO
{
    public class TicketDTO
    {
        public int Id{ get; set; }
        public int TripId { get; set; }
        public int StartStopId { get; set; }
        public int EndStopId { get; set; }
        public int Price { get; set; }
        public StopDTO StartStop { get; set; }
        public StopDTO EndStop { get; set; }
        public TripDTO Trip { get; set; }

    }
}
