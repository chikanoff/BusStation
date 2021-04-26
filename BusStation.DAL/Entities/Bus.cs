using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.DAL.Entities
{
    public class Bus
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int CategoryId { get; set; }
    }
}
