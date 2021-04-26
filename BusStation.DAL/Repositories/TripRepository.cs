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
    public class TripRepository : IRepository<Trip>
    {
        private readonly MySqlConnection _conn;

        public TripRepository(MySqlConnection conn)
        {
            _conn = conn;
        }
        public void Create(Trip item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into trips(routeId, busId, date) values(@routeId, @busId, @date)", _conn);
                cmd.Parameters.AddWithValue("@routeId", item.RouteId);
                cmd.Parameters.AddWithValue("@busId", item.BusId);
                cmd.Parameters.AddWithValue("@date", item.Date);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Trip item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update trips set routeId = @routeId, busId = @busId, date = @date where id = @id", _conn);
                cmd.Parameters.AddWithValue("@routeId", item.RouteId);
                cmd.Parameters.AddWithValue("@busId", item.BusId);
                cmd.Parameters.AddWithValue("@date", item.Date);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from trips where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Trip> Get()
        {
            IList<Trip> trips = new List<Trip>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from trips", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    trips.Add(new Trip
                    {
                        Id = reader.GetInt32(0),
                        RouteId = reader.GetInt32(1),
                        BusId = reader.GetInt32(2),
                        Date = reader.GetDateTime(3)
                    });
                }
            }

            return trips;
        }

        public Trip Get(int id)
        {
            Trip trip = new Trip();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from trips where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    trip = new Trip
                    {
                        Id = reader.GetInt32(0),
                        RouteId = reader.GetInt32(1),
                        BusId = reader.GetInt32(2),
                        Date = reader.GetDateTime(3)
                    };
                }
            }

            return trip;
        }
    }
}
