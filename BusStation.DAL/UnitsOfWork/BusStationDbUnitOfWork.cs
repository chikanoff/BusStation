using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.DAL.Connections;
using BusStation.DAL.Entities;
using BusStation.DAL.Interfaces;
using BusStation.DAL.Repositories;
using MySql.Data.MySqlClient;

namespace BusStation.DAL.UnitsOfWork
{
    public class BusStationDbUnitOfWork : IUnitOfWork
    {
        private readonly MySqlConnection _connection;
        private BusCategoryRepository _busCategories;
        private BusRepository _buses;
        private RouteRepository _routes;
        private RouteStopRepository _routeStops;
        private StopRepository _stops;
        private TicketRepository _tickets;
        private TripRepository _trips;
        private UserTicketRepository _userTickets;
        private UserRepository _users;

        public IRepository<BusCategory> BusCategories
        {
            get
            {
                if (_busCategories == null)
                {
                    _busCategories = new BusCategoryRepository(_connection);
                }

                return _busCategories;
            }
        }

        public IRepository<Bus> Buses
        {
            get
            {
                if (_buses == null)
                {
                    _buses = new BusRepository(_connection);
                }

                return _buses;
            }
        }

        public IRepository<Route> Routes
        {
            get
            {
                if (_routes == null)
                {
                    _routes = new RouteRepository(_connection);
                }

                return _routes;
            }
        }

        public IRepository<RouteStop> RouteStops
        {
            get
            {
                if (_routeStops == null)
                {
                    _routeStops = new RouteStopRepository(_connection);
                }

                return _routeStops;
            }
        }

        public IRepository<Stop> Stops
        {
            get
            {
                if (_stops == null)
                {
                    _stops = new StopRepository(_connection);
                }

                return _stops;
            }
        }

        public IRepository<Ticket> Tickets
        {
            get
            {
                if (_tickets == null)
                {
                    _tickets = new TicketRepository(_connection);
                }

                return _tickets;
            }
        }

        public IRepository<Trip> Trips
        {
            get
            {
                if (_trips == null)
                {
                    _trips = new TripRepository(_connection);
                }

                return _trips;
            }
        }

        public IRepository<UserTicket> UserTickets
        {
            get
            {
                if (_userTickets == null)
                {
                    _userTickets = new UserTicketRepository(_connection);
                }

                return _userTickets;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_connection);
                }

                return _users;
            }
        }

        public BusStationDbUnitOfWork(string connectionString)
        {
            _connection = new MyConnection(connectionString).ConnectToDatabase();
        }
    }
}
