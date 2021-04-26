using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.DAL.Entities
{
    public class BusCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PriceForOneKm{ get; set; }
    }
}
