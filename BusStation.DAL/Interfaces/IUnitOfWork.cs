using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BusStation.DAL.Entities;

namespace BusStation.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<BusCategory> BusCategories { get; }
        public IRepository<Bus> Buses { get; }
        public IRepository<Route> Routes { get; }
        public IRepository<RouteStop> RouteStops { get; }
        public IRepository<Stop> Stops { get; }
        public IRepository<Ticket> Tickets { get; }
        public IRepository<Trip> Trips { get; }
        public IRepository<UserTicket> UserTickets { get; }
        public IRepository<User> Users { get; }
    }
}
