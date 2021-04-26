using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.DAL.Connections;
using BusStation.DAL.Entities;
using BusStation.DAL.Interfaces;
using MySql.Data.MySqlClient;

namespace BusStation.DAL.Repositories
{
    public class RouteStopRepository : IRepository<RouteStop>
    {
        private readonly MySqlConnection _conn;

        public RouteStopRepository(MySqlConnection conn)
        {
            _conn = conn;
        }
        public void Create(RouteStop item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into routesstops(routeId, stopId, stopNumberInRoute, distanceFromStart) values(@routeId, @stopId, @stopNumberInRoute, @distanceFromStart)", _conn);
                cmd.Parameters.AddWithValue("@routeId", item.RouteId);
                cmd.Parameters.AddWithValue("@stopId", item.StopId);
                cmd.Parameters.AddWithValue("@stopNumberInRoute", item.StopNumberInRoute);
                cmd.Parameters.AddWithValue("@distanceFromStart", item.DistanceFromStart);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(RouteStop item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update routesstops set routeId = @routeId, stopId = @stopId, stopNumberInRoute = @stopNumberInRoute, distanceFromStart = @distanceFromStart where id = @id", _conn);
                cmd.Parameters.AddWithValue("@routeId", item.RouteId);
                cmd.Parameters.AddWithValue("@stopId", item.StopId);
                cmd.Parameters.AddWithValue("@stopNumberInRoute", item.StopNumberInRoute);
                cmd.Parameters.AddWithValue("@distanceFromStart", item.DistanceFromStart);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from routesstops where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<RouteStop> Get()
        {
            IList<RouteStop> routeStops = new List<RouteStop>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from routesstops", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    routeStops.Add(new RouteStop
                    {
                        Id = reader.GetInt32(0),
                        RouteId = reader.GetInt32(1),
                        StopId = reader.GetInt32(2),
                        StopNumberInRoute = reader.GetInt32(3),
                        DistanceFromStart = reader.GetInt32(4)
                    });
                }
            }

            return routeStops;
        }

        public RouteStop Get(int id)
        {
            RouteStop rs = new RouteStop();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from routesstops where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rs = new RouteStop
                    {
                        Id = reader.GetInt32(0),
                        RouteId = reader.GetInt32(1),
                        StopId = reader.GetInt32(2),
                        StopNumberInRoute = reader.GetInt32(3),
                        DistanceFromStart = reader.GetInt32(4)
                    };
                }
            }

            return rs;
        }
    }
}
