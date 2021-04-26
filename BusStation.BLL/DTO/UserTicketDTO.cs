using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.BLL.DTO
{
    public class UserTicketDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TicketId{ get; set; }
        public UserDTO User { get; set; }
        public TicketDTO Ticket { get; set; }
    }
}
