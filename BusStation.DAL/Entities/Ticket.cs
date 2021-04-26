using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.DAL.Entities
{
    public class Ticket
    {
        public int Id{ get; set; }
        public int TripId { get; set; }
        public int StartStopId { get; set; }
        public int EndStopId { get; set; }
        public int Price { get; set; }

    }
}
