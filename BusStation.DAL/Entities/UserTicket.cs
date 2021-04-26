using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.DAL.Entities
{
    public class UserTicket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TicketId{ get; set; }
    }
}
